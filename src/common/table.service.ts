// Disable lint rules because files are fetched with desired type.
/* eslint-disable @typescript-eslint/no-unsafe-return, @typescript-eslint/no-explicit-any */
import { Injectable } from "@nestjs/common";
import { readFile } from "fs/promises";
import { join } from "path";
import type { Torappu } from "../types";

const setStore = async (store: Map<string, unknown>, path: string) => {
  store.set(
    path,
    JSON.parse(
      (await readFile(join(__dirname, "..", "..", "assets", path))).toString(),
    ),
  );
};

@Injectable()
export class TableService {
  public constructor(private readonly store: Map<string, any>) {}

  public async initialize(): Promise<TableService> {
    const store = new Map();

    await setStore(store, "conf/network_config");
    await setStore(store, "conf/remote_config");
    await setStore(store, "conf/version");

    return new TableService(store);
  }

  public get confNetworkConfig(): Torappu.Network.NetworkRouterConfig {
    return this.store.get("conf/network_config");
  }
  public get confRemoteConfig(): Partial<Torappu.Config.RemoteConfig.InternalConfig> {
    return this.store.get("conf/remote_config");
  }
  public get confVersion(): Torappu.Resource.HotUpdater.VersionInfo {
    return this.store.get("conf/version");
  }
}
