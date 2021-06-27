import { Body, Controller, Headers, Post, Req } from "@nestjs/common";
import { TokenService } from "../common/entity/token.service";
import { GameDataService } from "../common/entity/gamedata.service";
import { Routes, ServerDomains } from "../consts";
import type { Torappu } from "../types";
import { getUnixTime } from "date-fns";
import { User } from "./user";
import { Request } from "express";

@Controller({ host: [ServerDomains.GameServer] })
export class AccountController {
  constructor(
    private readonly tokenSvc: TokenService,
    private readonly sGameData: GameDataService,
  ) {}

  @Post(Routes.LOGIN)
  public Login(
    @Body() req: Torappu.LoginRequest & Torappu.LoginRequestV002,
    @Req() rawReq: Request,
  ): Omit<Torappu.LoginResponse, "playerDataDelta"> {
    return {
      result: 0,
      uid: (rawReq as unknown as { uid?: string }).uid ?? "INVALID_USER",
      secret: req.token,
      serviceLicenseVersion: 0,
    };
  }

  @Post(Routes.SYNC_DATA)
  public SyncData(
    @User() user: Torappu.PlayerDataModel,
  ): Torappu.SyncDataResponse {
    user.status.lastRefreshTs = getUnixTime(new Date()) as unknown as Date;
    return {
      result: 0,
      ts: getUnixTime(new Date()),
      user,
    } as Torappu.SyncDataResponse;
  }

  @Post(Routes.SYNC_STATUS)
  public SyncStatus(
    @Body() _: Torappu.PlayerSyncStatusRequest,
    @User() user: Torappu.PlayerDataModel,
  ): Torappu.PlayerSyncStatusResponse {
    user.status.lastRefreshTs = getUnixTime(new Date()) as unknown as Date;
    return {
      ts: getUnixTime(new Date()),
      result: {},
    };
  }
}
