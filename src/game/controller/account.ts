import { Body, Controller, Post } from "@nestjs/common";
import { TokenService } from "../../common/entity/token.service";
import { Routes, ServerDomains } from "../../consts";
import type { Torappu } from "../../types";
import { getUnixTime } from "date-fns";
import { User } from "../user";

@Controller({ host: [ServerDomains.GameServer] })
export class AccountController {
  constructor(private readonly tokenSvc: TokenService) {}

  @Post(Routes.LOGIN)
  public async Login(
    @Body() req: Torappu.LoginRequest & Torappu.LoginRequestV002,
  ): Promise<Omit<Torappu.LoginResponse, "playerDataDelta">> {
    const uid = await this.tokenSvc.GetAccount(req.token);
    return {
      result: 0,
      uid,
      secret: req.token,
      serviceLicenseVersion: 0,
    };
  }

  @Post(Routes.SYNC_DATA)
  public SyncData(
    @User() user: Torappu.PlayerDataModel,
  ): Torappu.SyncDataResponse {
    user.status.lastRefreshTs = new Date();
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
    user.status.lastRefreshTs = new Date();
    return {
      ts: getUnixTime(new Date()),
      result: {},
    };
  }
}
