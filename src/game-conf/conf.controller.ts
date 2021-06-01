import { Controller, Get } from "@nestjs/common";
import { TableService } from "../common/table.service";
import { ServerDomains } from "../consts";
import type { Torappu } from "../types";

@Controller({ host: [ServerDomains.ConfServer] })
export class ConfController {
  constructor(private readonly tables: TableService) {}
  @Get("/config/prod/official/network_config")
  getNetworkConfig(): Torappu.Network.NetworkRouterConfig {
    // TODO: generate own config
    return this.tables.confNetworkConfig;
  }

  @Get("/config/prod/official/remote_config")
  getRemoteConfig(): Partial<Torappu.Config.RemoteConfig.InternalConfig> {
    return { enableSDKNetSecure: false, enableGameBI: false };
  }

  @Get("/config/prod/official/:platform/version")
  getPlatformVersion(): Torappu.Resource.HotUpdater.VersionInfo {
    return this.tables.confVersion;
  }
}
