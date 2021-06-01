import { Body, Controller, Post } from "@nestjs/common";
import { ServerDomains } from "../consts";
import type { HgSDK } from "../types";

@Controller({ host: [ServerDomains.AccountServer], path: "/u8/online/v1" })
export class U8OnlineController {
  @Post("ping")
  public Ping(@Body() _: HgSDK.PingRequest): HgSDK.PingResponse {
    return {
      result: 0,
      message: "OK",
      interval: 4330,
    };
  }

  @Post("loginout")
  public LoginOut(@Body() _: HgSDK.LoginoutRequest): HgSDK.LoginoutResponse {
    return {
      result: 0,
    };
  }
}
