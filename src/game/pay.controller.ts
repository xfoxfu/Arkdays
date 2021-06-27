import { Body, Controller, Post } from "@nestjs/common";
import { Routes, ServerDomains } from "../consts";
import type { Torappu } from "../types";

@Controller({ host: [ServerDomains.GameServer] })
export class PayController {
  @Post(Routes.PAY_GET_UNCONFIRMED_ORDER_LIST)
  public UnconfirmedOrder(
    @Body() _: Torappu.PayGetUnConfirmedOrderListRequest,
  ): Torappu.PayGetUnconfirmedOrderListResponse {
    return { orderIdList: [] };
  }
}
