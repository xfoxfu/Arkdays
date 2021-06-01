import { Injectable } from "@nestjs/common";
import { SignJWT } from "jose/jwt/sign";
import { jwtVerify } from "jose/jwt/verify";
import { createSecretKey } from "crypto";
import { JWTPayload } from "jose/webcrypto/types";

interface Token {
  account: string;
}

@Injectable()
export class TokenService {
  private readonly key = createSecretKey(Buffer.from("TEST_SECRET"));

  public async Issue(account: string): Promise<string> {
    return await new SignJWT({ account })
      .setIssuedAt()
      .setExpirationTime("31d")
      .sign(this.key);
  }

  public async GetPayload(token: string): Promise<JWTPayload> {
    const data = await jwtVerify(token, this.key);
    return data.payload;
  }

  public async GetAccount(token: string): Promise<string> {
    return ((await this.GetPayload(token)) as unknown as Token).account;
  }
}
