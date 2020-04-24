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

            await Download("activity_table.json");
            await Download("audio_data.json");
            await Download("building_data.json");
            await Download("character_table.json");
            await Download("charword_table.json");
            await Download("checkin_table.json");
            await Download("clue_data.json");
            await Download("crisis_table.json");
            await Download("data_version.txt");
            await Download("enemy_handbook_table.json");
            await Download("favor_table.json");
            await Download("gacha_table.json");
            await Download("gamedata_const.json");
            await Download("handbook_info_table.json");
            await Download("handbook_table.json");
            await Download("handbook_team_table.json");
            await Download("item_table.json");
            await Download("mission_table.json");
            await Download("open_server_table.json");
            await Download("range_table.json");
            await Download("shop_client_table.json");
            await Download("skill_table.json");
            await Download("skin_table.json");
            await Download("stage_table.json");
            await Download("story_table.json");
            await Download("tip_table.json");
            await Download("token_table.json");
            await Download("zone_table.json");
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