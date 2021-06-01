import { Controller, Post } from "@nestjs/common";
import { ServerDomains } from "../consts";
import type { Torappu, U8 } from "../types";

@Controller({ host: [ServerDomains.AccountServer], path: "/u8/user/v1" })
export class U8UserController {
  @Post("getToken")
  public GetToken(): Partial<U8.SDK.U8LoginResult> {
    return {
      result: 0,
      uid: "114514",
      channelUid: "1919810",
      token: "70cfc1ef80771c97a01628259f6f3af5",
      isGuest: false,
      extension: '{"isGuest":0}',
    };
  }

  @Post("verifyAccount")
  public VerifyAccount(): Torappu.SDK.U8ExternalTools.U8VerifyAccountResponse {
    return { uid: "114514" };
  }
}
