import { Body, Controller, Post } from "@nestjs/common";
import { Routes, ServerDomains } from "../consts";
import type { HgSDK } from "../types";

@Controller({ host: [ServerDomains.AccountServer] })
export class U8OnlineController {
  @Post(Routes.SDK_PING)
  public Ping(@Body() _: HgSDK.PingRequest): HgSDK.PingResponse {
    return {
      result: 0,
      message: "OK",
      interval: 4330,
    };
  }

  @Post(Routes.SDK_LOGINOUT)
  public LoginOut(@Body() _: HgSDK.LoginoutRequest): HgSDK.LoginoutResponse {
    return {
      result: 0,
    };
  }
}
