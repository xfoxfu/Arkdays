import { Body, Controller, Post } from "@nestjs/common";
import { Routes, ServerDomains } from "../../consts";
import type { Torappu } from "../../types";
import { User } from "../user";
import { v4 as uuid } from "uuid";

@Controller({ host: [ServerDomains.GameServer] })
export class QuestController {
  @Post(Routes.SQUAD_FORMATION)
  public SquadFormation(
    @Body() req: Torappu.SquadFormationRequest,
    @User() user: Torappu.PlayerDataModel,
  ): Torappu.SquadFormationResponse {
    const squad = user.troop.squads[req.squadId];
    squad.slots = req.slots;
    return {};
  }

  @Post(Routes.DEFAULT_BATTLE_START)
  public DefaultBattleStart(
    @Body() _req: Torappu.DefaultStartBattleRequest,
    @User() _user: Torappu.PlayerDataModel,
  ): Torappu.DefaultStartBattleResponse {
    return {
      result: 0,
      battleId: uuid(),
      apFailReturn: 0,
      isApProtect: false,
      notifyPowerScoreNotEnoughIfFailed: false,
    } as Torappu.DefaultStartBattleResponse;
  }

  @Post(Routes.DEFAULT_BATTLE_FINISH)
  public DefaultBattleFinish(
    @Body() _req: Torappu.DefaultFinishBattleRequest,
    @User() _user: Torappu.PlayerDataModel,
  ): Torappu.DefaultFinishBattleResponse {
    return {
      goldScale: 1.2,
      expScale: 1.2,
      firstRewards: [],
      unlockStages: [],
      result: 0,
      apFailReturn: 0,
      rewards: [],
      unusualRewards: [],
      additionalRewards: [],
      diamondMaterialRewards: [],
      furnitureRewards: [],
      alert: [],
      suggestFriend: false,
    } as Torappu.DefaultFinishBattleResponse;
  }

  @Post(Routes.FINISH_STORY_STAGE)
  public FinishStoryStage(
    @Body() _req: Torappu.StoryOnlyStartBattleRequest,
    @User() _user: Torappu.PlayerDataModel,
  ): Torappu.StoryOnlyStartBattleResponse {
    return {
      rewards: [],
      unlockStages: [],
      result: 0,
      alert: [],
    } as Torappu.StoryOnlyStartBattleResponse;
  }
}
