import { Injectable } from "@nestjs/common";
import { Torappu } from "../../types";
import { StoreService } from "../store.service";
import { TableService } from "../table.service";
import { last } from "lodash";
import { getUnixTime } from "date-fns";

const STORE_PREFIX = "gamedata:";
const getKey = (account: string): string => `${STORE_PREFIX}${account}`;

@Injectable()
export class GameDataService {
  public constructor(
    private readonly store: StoreService,
    private readonly tables: TableService,
  ) {}

  public async Exists(account: string): Promise<boolean> {
    return await this.store.exists(getKey(account));
  }

  public async Get(account: string): Promise<Torappu.PlayerDataModel> {
    return JSON.parse(
      await this.store.get(getKey(account)),
    ) as Torappu.PlayerDataModel;
  }

  public async Set(
    account: string,
    data: Torappu.PlayerDataModel,
  ): Promise<void> {
    await this.store.put(getKey(account), JSON.stringify(data));
  }

  public async Initialize(account: string): Promise<void> {
    if (await this.store.exists(getKey(account))) return;
    const playerData: Torappu.PlayerDataModel = this.tables.playerInit;

    playerData.status.flags = Object.fromEntries(
      Object.keys(this.tables.story_table).map((k) => [k, true]),
    );
    playerData.dungeon.stages = Object.fromEntries(
      Object.values(this.tables.stage_table.stages).map((s) => [
        s.stageId,
        {
          stageId: s.stageId,
          completeTimes: 1,
          state: Torappu.PlayerStageState.COMPLETE,
          hasBattleReplay: false,
          noCostCnt: 1,
        },
      ]),
    );
    // _syncDataHolder.Value.user.dungeon.campaigns:new PlayerCampaign
    // {
    //     campaignCurrentFee:1800,
    //     campaignTotalFee:1800,
    //     activeGroupId:_stageTableHolder.Value.campaignGroups.LastOrDefault().Value.groupId,
    //     instances:_stageTableHolder.Value.campaigns
    //         .ToDictionary(v => v.Key, v => new PlayerCampaign.Instance
    //         {
    //             maxKills:400,
    //             rewardStatus:new[] { 1, 1, 1, 1, 1, 1, 1, 1 },
    //         })
    // };
    playerData.skin.characterSkins = Object.fromEntries(
      Object.entries(this.tables.skin_table.charSkins).map(([k, _]) => [
        k,
        1 as unknown as boolean,
      ]),
    );
    playerData.troop.troopCapacity = Object.keys(
      this.tables.character_table,
    ).length;
    let instId = 0;
    playerData.troop.chars = Object.fromEntries(
      Object.entries(this.tables.character_table)
        .filter(
          ([_, Value]) =>
            Value.profession != Torappu.ProfessionCategory.NONE &&
            Value.profession != Torappu.ProfessionCategory.TOKEN &&
            Value.profession != Torappu.ProfessionCategory.TRAP,
        )
        .map(([Key, Value]) => [
          instId,
          {
            instId: instId++,
            charId: Key,
            favorPoint: 25570,
            potentialRank: Value.maxPotentialLevel,
            mainSkillLvl: 7,
            skin:
              last(
                Object.values(this.tables.skin_table.charSkins).filter(
                  (v) => v.charId === Key,
                ),
              )?.skinId ?? "",
            level: last(Value.phases)?.maxLevel ?? 1,
            exp: 0,
            evolvePhase:
              Value.phases.length === 3
                ? Torappu.EvolvePhase.PHASE_2
                : Value.phases.length === 2
                ? Torappu.EvolvePhase.PHASE_1
                : Torappu.EvolvePhase.PHASE_0,
            defaultSkillIndex: Value.skills.length - 1,
            gainTime: 1587109206,
            skills: Value.skills.map((s) => ({
              skillId: s.skillId,
              unlock: true,
              // state: false,
              specializeLevel: s.levelUpCostCond.length ?? 0,
              // completeUpgradeTime: 0,
            })),
          },
        ]),
    );
    playerData.event.building = new Date();
    playerData.event.status = getUnixTime(new Date());

    await this.store.put(getKey(account), JSON.stringify(playerData));
  }
}
