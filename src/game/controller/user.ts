import { Body, Controller, Post } from "@nestjs/common";
import { TableService } from "../../common/table.service";
import { Routes, ServerDomains } from "../../consts";
import { Torappu } from "../../types";
import { User } from "../user";

@Controller({ host: [ServerDomains.GameServer] })
export class UserController {
  constructor(private readonly tables: TableService) {}

  @Post(Routes.CHANGE_SECRETARY)
  public ChangeSecretary(
    @Body() req: Torappu.ChangeSecretaryRequest,
    @User() user: Torappu.PlayerDataModel,
  ): Torappu.ChangeSecretaryResponse {
    user.status.secretary = user.troop.chars[req.charInstId].charId;
    user.status.secretarySkinId = req.skinId;
    return {};
  }

  @Post(Routes.BIND_NICKNAME)
  public BindNickname(
    @Body() req: Torappu.BindNickNameRequest,
    @User() user: Torappu.PlayerDataModel,
  ): Torappu.BindNickNameResponse {
    user.status.nickName = req.nickName;
    user.status.nickNumber = "0000";
    return { result: 0 };
  }

  @Post(Routes.CHECKIN_HOME)
  public CheckIn(
    @Body() req: Torappu.CheckInRequest,
    @User() user: Torappu.PlayerDataModel,
  ): Torappu.CheckInResponse {
    user.checkIn.canCheckIn = false;
    user.checkIn.checkInHistory.push(false);

    const item =
      this.tables.checkin_table.groups[user.checkIn.checkInGroupId].items[
        user.checkIn.checkInRewardIndex
      ];
    if (item.itemType === Torappu.ItemType.GOLD) {
      user.status.gold += item.count;
    } else if (item.itemType === Torappu.ItemType.DIAMOND) {
      user.status.freeDiamond += item.count;
    } // else if(item.itemType === Torappu.ItemType.)
    return {
      signInRewards: [
        {
          type: item.itemType,
          id: item.itemId,
          charGet: null as unknown as Torappu.GachaResult,
          count: item.count,
        },
      ],
      subscriptionRewards: [],
    };
  }
}
