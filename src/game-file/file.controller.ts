import { Controller, Get, Param } from "@nestjs/common";
import { TableService } from "../common/table.service";
import { ServerDomains } from "../consts";
import type { Torappu } from "../types";

@Controller({ host: [ServerDomains.FileServer] })
export class FileController {
  constructor(private readonly tables: TableService) {}

  @Get("/announce/:platform/preannouncement.meta.json")
  getPreAnnouncement(
    @Param("platform") platform: string,
  ): Torappu.PreAnnounceData {
    if (platform === "Android") return this.tables.fsPreAnnounceMetaAndroid;
    else if (platform === "IOS") return this.tables.fsPreAnnounceMetaIOS;

    throw new Error("invalid client type");
  }

  @Get("/announce/:platform/preannouncement/:id.html")
  getAnnouncenment(): string {
    return "Announce not implemented.";
  }
}
