import { Body, Controller, Post } from "@nestjs/common";
import { getUnixTime } from "date-fns";
import { Routes, ServerDomains } from "../../consts";
import type { Torappu } from "../../types";
import { User } from "../user";

@Controller({ host: [ServerDomains.GameServer] })
export class QuestController {
  @Post(Routes.SQUAD_FORMATION)
  public SquadFormation(
    @Body() req: Torappu.SquadFormationRequest,
    @User() user: Torappu.PlayerDataModel,
  ): Torappu.SquadFormationResponse {
    console.log(req);
    const squad = user.troop.squads[req.squadId];
    squad.slots = req.slots.map((s) =>
      s !== null
        ? {
            charInstId: s.charInstId,
            skillIndex: s.skillIndex,
          }
        : (null as unknown as Torappu.PlayerSquadItem),
    );
    return {};
  }

  @Post(Routes.DEFAULT_BATTLE_START)
  public DefaultBattleStart(
    @Body() req: Torappu.DefaultStartBattleRequest,
    @User() user: Torappu.PlayerDataModel,
  ): Torappu.DefaultStartBattleResponse {
    return {
      result: 0,
      battleId: "0913f930-8142-11ea-931d-4fc3078f82b2",
      apFailReturn: 0,
      isApProtect: false,
      notifyPowerScoreNotEnoughIfFailed: false,
    } as Torappu.DefaultStartBattleResponse;
  }
}
