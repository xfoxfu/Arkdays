import { Body, Controller, Post } from "@nestjs/common";
import { TokenService } from "../../common/entity/token.service";
import { Routes, ServerDomains } from "../../consts";
import type { Torappu } from "../../types";
import { fromUnixTime, getUnixTime, isWithinInterval } from "date-fns";
import { User } from "../user";
import { getDayBound, maybeJsonDate } from "../../common/utils";
import { TableService } from "../../common/table.service";
import { find } from "lodash";

@Controller({ host: [ServerDomains.GameServer] })
export class AccountController {
  constructor(
    private readonly tokenSvc: TokenService,
    private readonly tables: TableService,
  ) {}

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
    const previousRefreshTs = maybeJsonDate(user.status.lastRefreshTs);
    user.status.lastRefreshTs = new Date();
    if (
      isWithinInterval(getDayBound(), {
        start: previousRefreshTs,
        end: user.status.lastRefreshTs,
      })
    ) {
      const currentGroup =
        this.tables.checkin_table.groups[user.checkIn.checkInGroupId];
      if (
        isWithinInterval(user.status.lastRefreshTs, {
          start: fromUnixTime(currentGroup.signStartTime),
          end: fromUnixTime(currentGroup.signEndTime),
        })
      ) {
        user.checkIn.canCheckIn = true;
        user.checkIn.checkInRewardIndex += 1;
      } else {
        const availableGroup = find(
          Object.values(this.tables.checkin_table.groups),
          (g) =>
            isWithinInterval(user.status.lastRefreshTs, {
              start: fromUnixTime(g.signStartTime),
              end: fromUnixTime(g.signEndTime),
            }),
        );
        user.checkIn.canCheckIn = true;
        user.checkIn.checkInGroupId =
          availableGroup?.groupId ?? "INVALID_GROUP";
        user.checkIn.checkInRewardIndex = 0;
        user.checkIn.checkInHistory = [];
      }
    }

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
