import { Global, Module } from "@nestjs/common";
import { ConfigModule } from "@nestjs/config";
import { AppConfigService, loadConfig } from "./config.service";
import { StoreService } from "./store.service";

@Global()
@Module({
  imports: [
    ConfigModule.forRoot({
      isGlobal: true,
      load: [loadConfig],
    }),
  ],
  providers: [AppConfigService, StoreService],
  exports: [AppConfigService, StoreService],
})
export class CommonModule {}
