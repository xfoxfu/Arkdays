import { Controller, Get } from "@nestjs/common";
import { TableService } from "../common/table.service";
import { ServerDomains } from "../consts";
import type { Torappu } from "../types";

@Controller({ host: [ServerDomains.ConfServer] })
export class ConfController {
  constructor(private readonly tables: TableService) {}
  @Get("/config/prod/official/network_config")
  getNetworkConfig(): Torappu.Network.NetworkRouterConfig {
    // TODO: dynamically fetch from server
    return {
      sign: "SOME_INVALID_SIGN",
      content: JSON.stringify({
        configVer: "5",
        funcVer: "V018",
        configs: {
          V018: {
            override: true,
            network: {
              gs: `https://${ServerDomains.GameServer}`,
              as: `https://${ServerDomains.AccountServer}`,
              u8: `https://${ServerDomains.AccountServer}/u8`,
              hu: `https://ak.hycdn.cn/assetbundle/official`,
              hv: `https://${ServerDomains.ConfServer}/config/prod/official/{0}/version`,
              rc: `https://${ServerDomains.ConfServer}/config/prod/official/remote_config`,
              an: `https://${ServerDomains.FileServer}/announce/{0}/announcement.meta.json`,
              prean: `https://${ServerDomains.FileServer}/announce/{0}/preannouncement.meta.json`,
              sl: `https://${ServerDomains.WebServer}/protocol/service`,
              of: `https://${ServerDomains.WebServer}/index.html`,
              pkgAd: `https://${ServerDomains.WebServer}/download`,
              pkgIOS: `https://apps.apple.com/cn/app/id1454663939`,
              secure: false,
            },
          },
          V019: { override: false },
        },
      }),
    };
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
