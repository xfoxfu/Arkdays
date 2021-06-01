import { Injectable } from "@nestjs/common";
import { StoreService } from "../store.service";

const STORE_PREFIX = "account:";
const getKey = (account: string): string => `${STORE_PREFIX}${account}`;

@Injectable()
export class AccountService {
  public constructor(private readonly store: StoreService) {}

  public async Register(account: string, password: string): Promise<void> {
    if (await this.store.get(getKey(account))) {
      throw new Error("account already registered");
    }
    await this.store.put(getKey(account), JSON.stringify({ password }));
  }

  public async Login(account: string, password: string): Promise<boolean> {
    const user = JSON.parse(await this.store.get(getKey(account))) as {
      password: string;
    };
    if (user.password === password) return true;
    return false;
  }
}
