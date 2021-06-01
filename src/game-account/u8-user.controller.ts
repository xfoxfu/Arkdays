import { Body, Controller, Post } from "@nestjs/common";
import { ServerDomains } from "../consts";
import type { Torappu, U8 } from "../types";

@Controller({ host: [ServerDomains.AccountServer], path: "/u8/user/v1" })
export class U8UserController {
  @Post("getToken")
  public GetToken(@Body() req: U8.SDK.SDKMeta): Partial<U8.SDK.U8LoginResult> {
    const payload = JSON.parse(req.extension) as {
      uid: string;
      access_token: string;
    };
    return {
      result: 0,
      uid: payload.uid,
      channelUid: "0",
      token: payload.access_token,
      isGuest: false,
      extension: '{"isGuest":0}',
    };
  }

  @Post("verifyAccount")
  public VerifyAccount(): Torappu.SDK.U8ExternalTools.U8VerifyAccountResponse {
    return { uid: "114514" };
  }
}
