import { mkdir, writeFile } from "fs/promises";
import got from "got";
import { join } from "path";

const mkdirP = (path: string) => mkdir(path).catch(() => {});

const targetDir = join(__dirname, "..", "assets");

const clientConf = got.extend({
  headers: {
    Accept: "*/*",
    "User-Agent": "arknights/398 CFNetwork/1240.0.4 Darwin/20.5.0",
    "Accept-Language": "en-us",
    "Accept-Encoding": "gzip, deflate, br",
    "X-Unity-Version": "2017.4.39f1",
  },
});
const fetch = async (
  prefix: string,
  url: string,
  target?: string,
): Promise<string> => {
  const value = (await clientConf.get(url)).body;
  await writeFile(
    join(targetDir, prefix, target ?? url.substr(url.lastIndexOf("/"))),
    value,
  );
  console.log("[*] " + url);
  return value;
};

const main = async () => {
  await mkdirP(join(targetDir, "conf"));
  await mkdirP(join(targetDir, "fs"));
  await mkdirP(join(targetDir, "gamedata"));
  // prettier-ignore
  await Promise.all([
    fetch("conf", "https://ak-conf.hypergryph.com/config/prod/official/network_config"),
    fetch("conf", "https://ak-conf.hypergryph.com/config/prod/official/remote_config"),
    fetch("conf", "https://ak-conf.hypergryph.com/config/prod/official/Android/version", "Android-version"),
    fetch("fs", "https://ak-fs.hypergryph.com/announce/Android/preannouncement.meta.json", "Android-preannouncement.meta.json"),
    fetch("conf", "https://ak-conf.hypergryph.com/config/prod/official/IOS/version", "IOS-version"),
    fetch("fs", "https://ak-fs.hypergryph.com/announce/IOS/preannouncement.meta.json", "IOS-preannouncement.meta.json"),
    fetch("gamedata", "https://raw.githubusercontent.com/Kengxxiao/ArknightsGameData/master/zh_CN/gamedata/excel/activity_table.json"),
    fetch("gamedata", "https://raw.githubusercontent.com/Kengxxiao/ArknightsGameData/master/zh_CN/gamedata/excel/audio_data.json"),
    fetch("gamedata", "https://raw.githubusercontent.com/Kengxxiao/ArknightsGameData/master/zh_CN/gamedata/excel/building_data.json"),
    fetch("gamedata", "https://raw.githubusercontent.com/Kengxxiao/ArknightsGameData/master/zh_CN/gamedata/excel/campaign_table.json"),
    fetch("gamedata", "https://raw.githubusercontent.com/Kengxxiao/ArknightsGameData/master/zh_CN/gamedata/excel/chapter_table.json"),
    fetch("gamedata", "https://raw.githubusercontent.com/Kengxxiao/ArknightsGameData/master/zh_CN/gamedata/excel/char_meta_table.json"),
    fetch("gamedata", "https://raw.githubusercontent.com/Kengxxiao/ArknightsGameData/master/zh_CN/gamedata/excel/char_patch_table.json"),
    fetch("gamedata", "https://raw.githubusercontent.com/Kengxxiao/ArknightsGameData/master/zh_CN/gamedata/excel/character_table.json"),
    fetch("gamedata", "https://raw.githubusercontent.com/Kengxxiao/ArknightsGameData/master/zh_CN/gamedata/excel/charword_table.json"),
    fetch("gamedata", "https://raw.githubusercontent.com/Kengxxiao/ArknightsGameData/master/zh_CN/gamedata/excel/checkin_table.json"),
    fetch("gamedata", "https://raw.githubusercontent.com/Kengxxiao/ArknightsGameData/master/zh_CN/gamedata/excel/clue_data.json"),
    fetch("gamedata", "https://raw.githubusercontent.com/Kengxxiao/ArknightsGameData/master/zh_CN/gamedata/excel/crisis_table.json"),
    fetch("gamedata", "https://raw.githubusercontent.com/Kengxxiao/ArknightsGameData/master/zh_CN/gamedata/excel/data_version.txt"),
    fetch("gamedata", "https://raw.githubusercontent.com/Kengxxiao/ArknightsGameData/master/zh_CN/gamedata/excel/enemy_handbook_table.json"),
    fetch("gamedata", "https://raw.githubusercontent.com/Kengxxiao/ArknightsGameData/master/zh_CN/gamedata/excel/favor_table.json"),
    fetch("gamedata", "https://raw.githubusercontent.com/Kengxxiao/ArknightsGameData/master/zh_CN/gamedata/excel/gacha_table.json"),
    fetch("gamedata", "https://raw.githubusercontent.com/Kengxxiao/ArknightsGameData/master/zh_CN/gamedata/excel/gamedata_const.json"),
    fetch("gamedata", "https://raw.githubusercontent.com/Kengxxiao/ArknightsGameData/master/zh_CN/gamedata/excel/handbook_info_table.json"),
    fetch("gamedata", "https://raw.githubusercontent.com/Kengxxiao/ArknightsGameData/master/zh_CN/gamedata/excel/handbook_table.json"),
    fetch("gamedata", "https://raw.githubusercontent.com/Kengxxiao/ArknightsGameData/master/zh_CN/gamedata/excel/handbook_team_table.json"),
    fetch("gamedata", "https://raw.githubusercontent.com/Kengxxiao/ArknightsGameData/master/zh_CN/gamedata/excel/item_table.json"),
    fetch("gamedata", "https://raw.githubusercontent.com/Kengxxiao/ArknightsGameData/master/zh_CN/gamedata/excel/medal_table.json"),
    fetch("gamedata", "https://raw.githubusercontent.com/Kengxxiao/ArknightsGameData/master/zh_CN/gamedata/excel/mission_table.json"),
    fetch("gamedata", "https://raw.githubusercontent.com/Kengxxiao/ArknightsGameData/master/zh_CN/gamedata/excel/open_server_table.json"),
    fetch("gamedata", "https://raw.githubusercontent.com/Kengxxiao/ArknightsGameData/master/zh_CN/gamedata/excel/player_avatar_table.json"),
    fetch("gamedata", "https://raw.githubusercontent.com/Kengxxiao/ArknightsGameData/master/zh_CN/gamedata/excel/range_table.json"),
    fetch("gamedata", "https://raw.githubusercontent.com/Kengxxiao/ArknightsGameData/master/zh_CN/gamedata/excel/replicate_table.json"),
    fetch("gamedata", "https://raw.githubusercontent.com/Kengxxiao/ArknightsGameData/master/zh_CN/gamedata/excel/retro_table.json"),
    fetch("gamedata", "https://raw.githubusercontent.com/Kengxxiao/ArknightsGameData/master/zh_CN/gamedata/excel/roguelike_table.json"),
    fetch("gamedata", "https://raw.githubusercontent.com/Kengxxiao/ArknightsGameData/master/zh_CN/gamedata/excel/shop_client_table.json"),
    fetch("gamedata", "https://raw.githubusercontent.com/Kengxxiao/ArknightsGameData/master/zh_CN/gamedata/excel/skill_table.json"),
    fetch("gamedata", "https://raw.githubusercontent.com/Kengxxiao/ArknightsGameData/master/zh_CN/gamedata/excel/skin_table.json"),
    fetch("gamedata", "https://raw.githubusercontent.com/Kengxxiao/ArknightsGameData/master/zh_CN/gamedata/excel/stage_table.json"),
    fetch("gamedata", "https://raw.githubusercontent.com/Kengxxiao/ArknightsGameData/master/zh_CN/gamedata/excel/story_review_table.json"),
    fetch("gamedata", "https://raw.githubusercontent.com/Kengxxiao/ArknightsGameData/master/zh_CN/gamedata/excel/story_table.json"),
    fetch("gamedata", "https://raw.githubusercontent.com/Kengxxiao/ArknightsGameData/master/zh_CN/gamedata/excel/tip_table.json"),
    fetch("gamedata", "https://raw.githubusercontent.com/Kengxxiao/ArknightsGameData/master/zh_CN/gamedata/excel/token_table.json"),
    fetch("gamedata", "https://raw.githubusercontent.com/Kengxxiao/ArknightsGameData/master/zh_CN/gamedata/excel/zone_table.json"),
  ]);
  console.log("files fetched");
};

main()
  .then(() => process.exit())
  .catch(console.error);
