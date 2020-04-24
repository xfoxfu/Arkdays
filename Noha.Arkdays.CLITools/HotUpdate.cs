using System;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using CommandLine;
using Noha.Arkdays.Types.Torappu.Network;
using Noha.Arkdays.Types.Torappu.Resource;

namespace Noha.Arkdays.CLITools
{
    public static class HotUpdate
    {

        [Verb("hot-update", HelpText = "Retrieve latest hot update data.")]
        public class Options
        {
            private const string DEFAULT_OUTPUT = "AssetBundles";
            [Option('o', "output", Default = DEFAULT_OUTPUT)]
            public string OutputDir { get; set; } = DEFAULT_OUTPUT;

            private const string DEFAULT_BASE_ADDRESS = "https://ak-fs.hypergryph.com/assetbundle/official/";
            [Option('a', "address", Default = DEFAULT_BASE_ADDRESS)]
            public string BaseAddress { get; set; } = DEFAULT_BASE_ADDRESS;
        }

        private static string ResVersion = "";
        private static HttpClient client = new HttpClient();

        private static async Task Download(string name, HotUpdateInfo.ABInfo? abInfo = null)
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
                    // TODO: validate file hash
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

        private static async Task DownloadRes(string name, HotUpdateInfo.ABInfo? abInfo = null)
        {
            await Download(Path.Join("IOS", "assets", ResVersion, name), abInfo);
        }

        private static void EnsureDirectory(string name)
        {
            var dir = Path.GetDirectoryName(name);
            if (!String.IsNullOrEmpty(dir) && !Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
        }

        private static async Task<T> GetJson<T>(string name)
        {
            using (var fs = new FileStream(name, FileMode.Open))
            {
                return await JsonSerializer.DeserializeAsync<T>(fs);
            }
        }

        private static async Task<T> GetJsonRes<T>(string name)
        {
            using (var fs = new FileStream(Path.Join("IOS", "assets", ResVersion, name), FileMode.Open))
            {
                return await JsonSerializer.DeserializeAsync<T>(fs);
            }
        }

        public static async Task Handle(Options options)
        {
            var origDir = Environment.CurrentDirectory; // protect workdir
            Environment.CurrentDirectory = Environment.CurrentDirectory + "/" + options.OutputDir;

            client = new HttpClient()
            {
                BaseAddress = new System.Uri(options.BaseAddress),
            };

            await Download("network_config");
            var networkConfig = JsonSerializer.Deserialize<NetworkRouterConfig.Content>((await GetJson<NetworkRouterConfig>("network_config")).content);
            if (networkConfig == null)
            {
                throw new Exception("network_config is null, which may means a failed deserialization");
            }
            Console.WriteLine("use server url={0}", networkConfig.configs[networkConfig.funcVer].network.hotUpdateUrl);
            client = new HttpClient()
            {
                BaseAddress = new Uri(networkConfig.configs[networkConfig.funcVer].network.hotUpdateUrl + "/"),
            };

            await Download("remote_config");
            await Download("IOS/version");
            var version = await GetJson<VersionInfo>("IOS/version");
            Console.WriteLine("clientVer={0} resVer={1}", version.clientVersion, version.resVersion);
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

            Environment.CurrentDirectory = origDir; // restore workdir
        }
    }
}