import { Injectable } from "@nestjs/common";
import { StoreService } from "../store.service";

@Injectable()
export class GameDataService {
  private static readonly STORE_PREFIX = "gamedata:";

  public constructor(private readonly store: StoreService) {}
}
