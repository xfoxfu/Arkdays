import { Body, Controller, Post } from "@nestjs/common";
import { getUnixTime } from "date-fns";
import { Routes, ServerDomains } from "../../consts";
import type { Torappu } from "../../types";
import { User } from "../user";

@Controller({ host: [ServerDomains.GameServer] })
export class CrisisController {
  @Post(Routes.CRISIS_GET_INFO)
  public GetInfo(
    @Body() _req: Torappu.CrisisGetInfoRequest,
    @User() _user: Torappu.PlayerDataModel,
  ): Torappu.CrisisGetInfoResponse {
    return {
      ts: getUnixTime(new Date()),
      data: {
        runeInfoList: {},
        seasonInfo: [],
        trainingInfo: {
          stages: {},
          runeInfo: {},
        },
        stageRune: {},
      },
    };
  }
}
