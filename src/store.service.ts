import { Inject, Injectable } from "@nestjs/common";
import { AppConfigService } from "./config";
import level, { LevelDB } from "level";

@Injectable()
export class StoreService {
  private readonly storage: LevelDB;

  public constructor(@Inject(AppConfigService) config: AppConfigService) {
    this.storage = level(config.database);
    this.put = this.storage.put;
    this.get = this.storage.get;
    this.del = this.storage.del;
    this.clear = this.storage.clear;
    this.batch = this.storage.batch.bind(this.storage);
    this.iterator = this.storage.iterator.bind(this.storage);
  }

  public put: LevelDB["put"];
  public get: LevelDB["get"];
  public del: LevelDB["del"];
  public clear: LevelDB["clear"];

  public batch: LevelDB["batch"];

  public iterator: LevelDB["iterator"];
}
