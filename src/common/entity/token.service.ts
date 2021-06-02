import { Injectable } from "@nestjs/common";
import { StoreService } from "../store.service";
import { randomBytes } from "crypto";
import { addDays, getUnixTime } from "date-fns";

const randomKey = () => randomBytes(24).toString("base64");

const STORE_PREFIX = "as-token:";
const getKey = (account: string): string => `${STORE_PREFIX}${account}`;

interface IPayload {
  account: string;
  issuedAt: number;
  expiresAt: number;
}

@Injectable()
export class TokenService {
  public constructor(private readonly store: StoreService) {}

  public async Issue(account: string): Promise<[string, IPayload]> {
    const token = randomKey();
    const issuedAt = getUnixTime(new Date());
    const expiresAt = getUnixTime(addDays(issuedAt, 32));
    const payload = { account, issuedAt, expiresAt };
    await this.store.put(getKey(token), JSON.stringify(payload));
    return [token, payload];
  }

  public async GetPayload(token: string): Promise<IPayload> {
    return JSON.parse(await this.store.get(getKey(token))) as IPayload;
  }

  public async GetAccount(token: string): Promise<string> {
    return (await this.GetPayload(token)).account;
  }
}
