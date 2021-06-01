import { Global, Module } from "@nestjs/common";
import { ConfigModule } from "@nestjs/config";
import { AppConfigService } from "./config.service";
import { StoreService } from "./store.service";
import { TableService } from "./table.service";
import { AccountService, GameDataService } from "./entity";
import { TokenService } from "./entity/token.service";

@Global()
@Module({
  imports: [
    ConfigModule.forRoot({
      isGlobal: true,
      load: [AppConfigService.loadConfig],
    }),
  ],
  providers: [
    AppConfigService,
    StoreService,
    {
      provide: TableService,
      useFactory: TableService.initialize,
    },
    AccountService,
    GameDataService,
    TokenService,
  ],
  exports: [
    AppConfigService,
    StoreService,
    TableService,
    AccountService,
    GameDataService,
    TokenService,
  ],
})
export class CommonModule {}
