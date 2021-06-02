import { Body, Controller, Post } from "@nestjs/common";
import { Routes, ServerDomains } from "../consts";
import type { Torappu } from "../types";

@Controller({ host: [ServerDomains.GameServer] })
export class ShopController {
  @Post(Routes.SHOP_SKIN_LIST)
  public SkinList(
    @Body() _: Torappu.GetSkinGoodListRequest,
  ): Torappu.GetSkinGoodListResponse {
    return { goodList: [] };
  }
}
