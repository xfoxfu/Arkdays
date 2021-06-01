import { Injectable } from "@nestjs/common";
import { ConfigService } from "@nestjs/config";

export interface Config {
  port: number;
  database: string;
}

@Injectable()
export class AppConfigService {
  constructor(private configService: ConfigService<Config>) {}

  get database(): string {
    return this.configService.get<string>("database", "arkdays.db");
  }

  get port(): number {
    return this.configService.get<number>("port", 3000);
  }

  static loadConfig = (): Config => ({
    port: parseInt(process.env.PORT ?? "3000", 10),
    database: process.env.DATABASE ?? "arkdays.db",
  });
}
