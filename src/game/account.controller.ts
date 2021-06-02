import { Body, Controller, Headers, Post } from "@nestjs/common";
import { TokenService } from "../common/entity/token.service";
import { GameDataService } from "../common/entity/gamedata.service";
import { Routes, ServerDomains } from "../consts";
import type { Torappu } from "../types";
import { getUnixTime } from "date-fns";

@Controller({ host: [ServerDomains.GameServer] })
export class AccountController {
  constructor(
    private readonly tokenSvc: TokenService,
    private readonly sGameData: GameDataService,
  ) {}

  @Post(Routes.LOGIN)
  public async Login(
    @Body() req: Torappu.LoginRequest & Torappu.LoginRequestV002,
  ): Promise<Omit<Torappu.LoginResponse, "playerDataDelta">> {
    const uid = await this.tokenSvc.GetAccount(req.token);
    await this.sGameData.Initialize(uid);
    return {
      result: 0,
      uid,
      secret: req.token,
      serviceLicenseVersion: 0,
    };
  }

  @Post(Routes.SYNC_DATA)
  public async SyncData(
    @Headers("secret") secret: string,
  ): Promise<Torappu.SyncDataResponse> {
    const uid = await this.tokenSvc.GetAccount(secret);
    const user = await this.sGameData.Get(uid);
    return {
      result: 0,
      ts: getUnixTime(new Date()),
      user,
    } as Torappu.SyncDataResponse;
  }

  @Post(Routes.SYNC_STATUS)
  public SyncStatus(
    @Body() _: Torappu.PlayerSyncStatusRequest,
  ): Torappu.PlayerSyncStatusResponse {
    return {
      ts: getUnixTime(new Date()),
      result: {},
    };
  }
}
