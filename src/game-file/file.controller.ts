import { Controller, Get } from "@nestjs/common";
import { TableService } from "../common/table.service";
import { ServerDomains } from "../consts";
import type { Torappu } from "../types";

@Controller({ host: [ServerDomains.FileServer] })
export class FileController {
  constructor(private readonly tables: TableService) {}

  @Get("/announce/:platform/preannouncement.meta.json")
  getPreAnnouncement(): Torappu.PreAnnounceData {
    return this.tables.fsPreAnnounceMeta;
  }

  @Get("/announce/:platform/preannouncement/:id.html")
  getAnnouncenment(): string {
    return "Announce not implemented.";
  }
}
