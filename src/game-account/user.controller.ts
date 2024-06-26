import { Body, Controller, Post } from "@nestjs/common";
import { AccountService } from "../common/entity";
import { TokenService } from "../common/entity/token.service";
import { Routes, ServerDomains } from "../consts";
import type { HgSDK } from "../types";

@Controller({ host: [ServerDomains.AccountServer] })
export class UserController {
  constructor(
    private readonly accountSvc: AccountService,
    private readonly tokenSvc: TokenService,
  ) {}

  @Post(Routes.SDK_LOGIN_BY_PWD)
  public async Login(
    @Body() req: HgSDK.LoginRequest,
  ): Promise<HgSDK.LoginResponse> {
    if (await this.accountSvc.Login(req.account, req.password)) {
      const [token, payload] = await this.tokenSvc.Issue(req.account);
      return {
        result: 0,
        uid: req.account,
        role: 0,
        token: token,
        isAuthenticate: true,
        isMinor: false,
        needAuthenticate: false,
        issuedAt: new Date(payload.issuedAt),
        expiresIn: new Date(payload.expiresAt),
        isLatestUserAgreement: true,
        captcha: null,
      };
    } else {
      return { result: 1 } as unknown as HgSDK.LoginResponse;
    }
  }

  @Post(Routes.SDK_AUTH)
  public async Auth(
    @Body() req: HgSDK.AuthRequest,
  ): Promise<HgSDK.AuthResponse> {
    return {
      uid: await this.tokenSvc.GetAccount(req.token),
      isAuthenticate: true,
      isMinor: false,
      needAuthenticate: false,
      isLatestUserAgreement: true,
    };
  }

  @Post(Routes.SDK_SEND_SMS_CODE)
  public SendSMS(
    @Body() req: HgSDK.UserSendSmsCodeRequest,
  ): HgSDK.UserSendSmsCodeResponse {
    return { result: 0, code: req.account, captcha: null };
  }

  @Post(Routes.SDK_USER_REGISTER)
  public async Register(
    @Body() req: HgSDK.UserRegisterRequest,
  ): Promise<HgSDK.UserRegisterResponse> {
    await this.accountSvc.Register(req.account, req.password);
    const [token, payload] = await this.tokenSvc.Issue(req.account);
    return {
      result: 0,
      uid: req.account,
      role: 0,
      token,
      // issuedAt: new Date(payload.issuedAt ?? Date.now()),
      // expiresIn: new Date(payload.expiresAt ?? Date.now()),
      errMsg: "",
      needAuthenticate: false,
      isLatestUserAgreement: true,
      captcha: null,
    } as unknown as HgSDK.UserRegisterResponse;
  }
}
