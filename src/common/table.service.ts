// Disable lint rules because files are fetched with desired type.
/* eslint-disable @typescript-eslint/no-unsafe-return, @typescript-eslint/no-explicit-any */
import { Injectable } from "@nestjs/common";
import { readFile } from "fs/promises";
import { join } from "path";
import type { Torappu } from "../types";

const setStore = async (
  store: Map<string, unknown>,
  path: string,
  parse = true,
) => {
  const content = (
    await readFile(join(__dirname, "..", "..", "assets", path))
  ).toString();
  store.set(path, parse ? JSON.parse(content) : content);
};

@Injectable()
export class TableService {
  public constructor(private readonly store: Map<string, any>) {}

  public static initialize = async (): Promise<TableService> => {
    const store = new Map();

    await setStore(store, "conf/network_config");
    await setStore(store, "conf/remote_config");
    await setStore(store, "conf/version");

    await setStore(store, "fs/preannouncement.meta.json");

    await setStore(store, "gamedata/activity_table.json");
    await setStore(store, "gamedata/audio_data.json");
    await setStore(store, "gamedata/building_data.json");
    await setStore(store, "gamedata/campaign_table.json");
    await setStore(store, "gamedata/chapter_table.json");
    await setStore(store, "gamedata/char_meta_table.json");
    await setStore(store, "gamedata/char_patch_table.json");
    await setStore(store, "gamedata/character_table.json");
    await setStore(store, "gamedata/charword_table.json");
    await setStore(store, "gamedata/checkin_table.json");
    await setStore(store, "gamedata/clue_data.json");
    await setStore(store, "gamedata/crisis_table.json");
    await setStore(store, "gamedata/data_version.txt", false);
    await setStore(store, "gamedata/enemy_handbook_table.json");
    await setStore(store, "gamedata/favor_table.json");
    await setStore(store, "gamedata/gacha_table.json");
    await setStore(store, "gamedata/gamedata_const.json");
    await setStore(store, "gamedata/handbook_info_table.json");
    await setStore(store, "gamedata/handbook_table.json");
    await setStore(store, "gamedata/handbook_team_table.json");
    await setStore(store, "gamedata/item_table.json");
    await setStore(store, "gamedata/medal_table.json");
    await setStore(store, "gamedata/mission_table.json");
    await setStore(store, "gamedata/open_server_table.json");
    await setStore(store, "gamedata/player_avatar_table.json");
    await setStore(store, "gamedata/range_table.json");
    await setStore(store, "gamedata/replicate_table.json");
    await setStore(store, "gamedata/retro_table.json");
    await setStore(store, "gamedata/roguelike_table.json");
    await setStore(store, "gamedata/shop_client_table.json");
    await setStore(store, "gamedata/skill_table.json");
    await setStore(store, "gamedata/skin_table.json");
    await setStore(store, "gamedata/stage_table.json");
    await setStore(store, "gamedata/story_review_table.json");
    await setStore(store, "gamedata/story_table.json");
    await setStore(store, "gamedata/tip_table.json");
    await setStore(store, "gamedata/token_table.json");
    await setStore(store, "gamedata/zone_table.json");

    await setStore(store, "player_init.json");

    return new TableService(store);
  };

  public get confNetworkConfig(): Torappu.Network.NetworkRouterConfig {
    return this.store.get("conf/network_config");
  }
  public get confRemoteConfig(): Partial<Torappu.Config.RemoteConfig.InternalConfig> {
    return this.store.get("conf/remote_config");
  }
  public get confVersion(): Torappu.Resource.HotUpdater.VersionInfo {
    return this.store.get("conf/version");
  }

  public get fsPreAnnounceMeta(): Torappu.PreAnnounceData {
    return this.store.get("fs/preannouncement.meta.json");
  }

  public get activity_table(): unknown {
    return this.store.get("gamedata/activity_table.json");
  }
  public get audio_data(): unknown {
    return this.store.get("gamedata/audio_data.json");
  }
  public get building_data(): unknown {
    return this.store.get("gamedata/building_data.json");
  }
  public get campaign_table(): unknown {
    return this.store.get("gamedata/campaign_table.json");
  }
  public get chapter_table(): unknown {
    return this.store.get("gamedata/chapter_table.json");
  }
  public get char_meta_table(): unknown {
    return this.store.get("gamedata/char_meta_table.json");
  }
  public get char_patch_table(): unknown {
    return this.store.get("gamedata/char_patch_table.json");
  }
  public get character_table(): Record<string, Torappu.CharacterData> {
    return this.store.get("gamedata/character_table.json");
  }
  public get charword_table(): unknown {
    return this.store.get("gamedata/charword_table.json");
  }
  public get checkin_table(): unknown {
    return this.store.get("gamedata/checkin_table.json");
  }
  public get clue_data(): unknown {
    return this.store.get("gamedata/clue_data.json");
  }
  public get crisis_table(): unknown {
    return this.store.get("gamedata/crisis_table.json");
  }
  public get data_version(): unknown {
    return this.store.get("gamedata/data_version.txt");
  }
  public get enemy_handbook_table(): unknown {
    return this.store.get("gamedata/enemy_handbook_table.json");
  }
  public get favor_table(): unknown {
    return this.store.get("gamedata/favor_table.json");
  }
  public get gacha_table(): unknown {
    return this.store.get("gamedata/gacha_table.json");
  }
  public get gamedata_const(): unknown {
    return this.store.get("gamedata/gamedata_const.json");
  }
  public get handbook_info_table(): unknown {
    return this.store.get("gamedata/handbook_info_table.json");
  }
  public get handbook_table(): unknown {
    return this.store.get("gamedata/handbook_table.json");
  }
  public get handbook_team_table(): unknown {
    return this.store.get("gamedata/handbook_team_table.json");
  }
  public get item_table(): unknown {
    return this.store.get("gamedata/item_table.json");
  }
  public get medal_table(): unknown {
    return this.store.get("gamedata/medal_table.json");
  }
  public get mission_table(): unknown {
    return this.store.get("gamedata/mission_table.json");
  }
  public get open_server_table(): unknown {
    return this.store.get("gamedata/open_server_table.json");
  }
  public get player_avatar_table(): unknown {
    return this.store.get("gamedata/player_avatar_table.json");
  }
  public get range_table(): unknown {
    return this.store.get("gamedata/range_table.json");
  }
  public get replicate_table(): unknown {
    return this.store.get("gamedata/replicate_table.json");
  }
  public get retro_table(): unknown {
    return this.store.get("gamedata/retro_table.json");
  }
  public get roguelike_table(): unknown {
    return this.store.get("gamedata/roguelike_table.json");
  }
  public get shop_client_table(): unknown {
    return this.store.get("gamedata/shop_client_table.json");
  }
  public get skill_table(): unknown {
    return this.store.get("gamedata/skill_table.json");
  }
  public get skin_table(): Torappu.SkinTable {
    return this.store.get("gamedata/skin_table.json");
  }
  public get stage_table(): Torappu.StageTable {
    return this.store.get("gamedata/stage_table.json");
  }
  public get story_review_table(): unknown {
    return this.store.get("gamedata/story_review_table.json");
  }
  public get story_table(): Record<string, Torappu.StoryData> {
    return this.store.get("gamedata/story_table.json");
  }
  public get tip_table(): Torappu.TipTable {
    return this.store.get("gamedata/tip_table.json");
  }
  public get token_table(): unknown {
    return this.store.get("gamedata/token_table.json");
  }
  public get zone_table(): Torappu.ZoneTable {
    return this.store.get("gamedata/zone_table.json");
  }

  public get playerInit(): Torappu.PlayerDataModel {
    return this.store.get("player_init.json");
  }
}
