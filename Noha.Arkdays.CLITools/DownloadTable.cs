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
    public static class DownloadTable
    {

        [Verb("download-table", HelpText = "Download latest table from GitHub.")]
        public class Options
        {
            [Option('o', "output", Default = "AssetBundles/_tables")]
            public string OutputDir { get; set; } = "AssetBundles/_tables";

            const string SOURCE = "https://raw.githubusercontent.com/Kengxxiao/ArknightsGameData/master/zh_CN/gamedata/excel/";
            [Option('s', "source", Default = SOURCE)]
            public string Source { get; set; } = SOURCE;
        }

        private static HttpClient client = new HttpClient();

        public static async Task Handle(Options options)
        {
            Utils.EnsureDirectory(Environment.CurrentDirectory + "/" + options.OutputDir + "/.phantom");
            var origDir = Environment.CurrentDirectory; // protect workdir
            Environment.CurrentDirectory = Environment.CurrentDirectory + "/" + options.OutputDir;

            client = new HttpClient()
            {
                BaseAddress = new System.Uri(options.Source),
            };

            await Task.WhenAll(new[]{
                Download("activity_table.json"),
                Download("audio_data.json"),
                Download("building_data.json"),
                Download("character_table.json"),
                Download("charword_table.json"),
                Download("checkin_table.json"),
                Download("clue_data.json"),
                Download("crisis_table.json"),
                Download("data_version.txt"),
                Download("enemy_handbook_table.json"),
                Download("favor_table.json"),
                Download("gacha_table.json"),
                Download("gamedata_const.json"),
                Download("handbook_info_table.json"),
                Download("handbook_table.json"),
                Download("handbook_team_table.json"),
                Download("item_table.json"),
                Download("mission_table.json"),
                Download("open_server_table.json"),
                Download("range_table.json"),
                Download("shop_client_table.json"),
                Download("skill_table.json"),
                Download("skin_table.json"),
                Download("stage_table.json"),
                Download("story_table.json"),
                Download("tip_table.json"),
                Download("token_table.json"),
                Download("zone_table.json"),
            });

        }

        public static async Task Download(string name)
        {
            Utils.EnsureDirectory(name);
            using (var file = new FileStream(name, FileMode.Create))
            {
                var response = await client.GetAsync(name);
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"{name} Non-successful status code {response.StatusCode}");
                }
                await response.Content.CopyToAsync(file);
                Console.WriteLine($"downloaded {name}");
            }
        }
    }
}