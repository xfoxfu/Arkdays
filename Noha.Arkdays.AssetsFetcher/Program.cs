using System;
using System.Net;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Dynamic;
using System.IO;
using Noha.Arkdays.Types.Torappu.Network;
using Noha.Arkdays.Types.Torappu.Resource;
using System.Linq;
using System.Net.Http;

namespace Noha.Arkdays.AssetsFetcher
{
    class Program
    {
        public static string ByteArrayToString(byte[] ba)
        {
            return BitConverter.ToString(ba).Replace("-", "");
        }

        internal const string AB_PATH = "AssetBundles";
        internal static string ResVersion = "";
        internal static HttpClient client = new HttpClient()
        {
            BaseAddress = new System.Uri("https://ak-fs.hypergryph.com/assetbundle/official/")
        };

        static async Task Download(string name, HotUpdateInfo.ABInfo? abInfo = null)
        {
            EnsureDirectory(name);
            if (!String.IsNullOrEmpty(abInfo?.md5) && abInfo?.md5.Length == 32)
            {
                try
                {
                    using (var fs = new FileInfo(name).Open(FileMode.Open))
                    {
                        if (fs.Length == abInfo?.totalSize)
                        {
                            Console.WriteLine($"cache used {name}");
                            return;
                        }
                    }
                    // using (var file = new FileStream(name, FileMode.Open))
                    // {
                    //     using (var md5 = System.Security.Cryptography.MD5.Create())
                    //     {
                    //         var hash = await md5.ComputeHashAsync(file);
                    //         if (ByteArrayToString(hash).ToUpper() == abInfo?.md5.ToUpper())
                    //         {
                    //             Console.WriteLine($"cache used {name}");
                    //             return;
                    //         }
                    //     }
                    // }
                }
                catch (FileNotFoundException) { }
                catch (Exception e)
                {
                    throw e;
                }
            }
            using (var file = new FileStream(name, FileMode.Create))
            {
                var response = await client.GetAsync(name);
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"Non-successful status code {response.StatusCode}");
                }
                await response.Content.CopyToAsync(file);
                Console.WriteLine($"downloaded {name}");
            }
        }

        static async Task DownloadRes(string name, HotUpdateInfo.ABInfo? abInfo = null)
        {
            await Download(Path.Join("IOS", "assets", ResVersion, name), abInfo);
        }

        static void EnsureDirectory(string name)
        {
            var dir = Path.GetDirectoryName(name);
            if (dir.Length > 0 && !Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
        }

        static async Task<T> GetJson<T>(string name)
        {
            return await JsonSerializer.DeserializeAsync<T>(new FileStream(name, FileMode.Open));
        }

        static async Task<T> GetJsonRes<T>(string name)
        {
            return await JsonSerializer.DeserializeAsync<T>(new FileStream(Path.Join("IOS", "assets", ResVersion, name), FileMode.Open));
        }

        static async Task Main(string[] args)
        {
            Environment.CurrentDirectory = Environment.CurrentDirectory + "/" + AB_PATH;
            await Download("network_config");
            var networkConfig = JsonSerializer.Deserialize<NetworkRouterConfig.Content>((await GetJson<NetworkRouterConfig>("network_config")).content);
            client = new HttpClient()
            {
                BaseAddress = new Uri(networkConfig.configs[networkConfig.funcVer].network.hotUpdateUrl + "/"),
            };

            await Download("remote_config");
            await Download("IOS/version");
            var version = await GetJson<VersionInfo>("IOS/version");
            System.Diagnostics.Debug.Assert(version.clientVersion == "1.0.01");
            ResVersion = version.resVersion;

            await DownloadRes("hot_update_list.json");
            var hotUpdateList = await GetJsonRes<HotUpdateInfo>("hot_update_list.json");

            foreach (var ab in hotUpdateList.abInfos)
            {
                var file = ab.name.Replace('/', '_').Replace(".ab", ".dat");
                int attempts = 0;
                while (attempts < 3)
                {
                    try
                    {
                        await DownloadRes(file, ab);
                        attempts = 0xFF;
                    }
                    catch (Exception e)
                    {
                        attempts += 1;
                        if (attempts >= 3)
                        {
                            Console.WriteLine($"download failed for {file}, message ${e.Message}");
                        }
                    }
                }
            }
        }
    }
}
