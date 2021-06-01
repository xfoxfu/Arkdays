import { Controller, Post } from "@nestjs/common";
import { ServerDomains } from "../consts";
import type { Torappu } from "../types";

@Controller({ host: [ServerDomains.AccountServer], path: "/u8/pay" })
export class U8PayController {
  @Post("getAllProductList")
  public GetAllProductList(): Partial<Torappu.SDK.U8ExternalTools.U8ProductListData> {
    return {
      productList: [],
    };
  }
}
