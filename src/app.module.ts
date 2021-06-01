import { Module } from "@nestjs/common";
import { AppController } from "./app.controller";
import { ConfigModule } from "@nestjs/config";
import { loadConfig, AppConfigService } from "./config";
import { StoreService } from "./store.service";

@Module({
  imports: [
    ConfigModule.forRoot({
      isGlobal: true,
      load: [loadConfig],
    }),
  ],
  controllers: [AppController],
  providers: [AppConfigService, StoreService],
})
export class AppModule {}
