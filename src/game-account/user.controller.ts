import { Body, Controller, Post } from "@nestjs/common";
import { ServerDomains } from "../consts";
import type { HgSDK } from "../types";

@Controller({ host: [ServerDomains.AccountServer], path: "/user" })
export class UserController {
  @Post("login")
  public Login(@Body() _: HgSDK.LoginRequest): HgSDK.LoginResponse {
    return {
      result: 0,
      uid: "1145141919810",
      role: 0,
      token: "eNchDECdrSxNJby+ec9U378srSxNJby+",
      isAuthenticate: true,
      isMinor: false,
      needAuthenticate: false,
      // issuedAt:new System.DateTime(),
      // expiresIn:new System.DateTime().AddYears(1),
      issuedAt: new Date(),
      expiresIn: new Date(),
      isLatestUserAgreement: true,
      captcha: "",
    };
  }

  @Post("auth")
  public Auth(@Body() _: HgSDK.AuthRequest): HgSDK.AuthResponse {
    return {
      uid: "1145141919810",
      isAuthenticate: true,
      isMinor: false,
      needAuthenticate: false,
      isLatestUserAgreement: true,
    };
  }
}
