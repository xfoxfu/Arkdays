import { Global, Module } from "@nestjs/common";
import { ConfigModule } from "@nestjs/config";
import { AppConfigService } from "./config.service";
import { StoreService } from "./store.service";
import { TableService } from "./table.service";

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
  ],
  exports: [AppConfigService, StoreService, TableService],
})
export class CommonModule {}
