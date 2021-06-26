import { Global, Module } from "@nestjs/common";
import { AppController } from "./app.controller";
import { CommonModule } from "./common/common.module";
import { AccountModule } from "./game-account/account.module";
import { ConfModule } from "./game-conf/conf.module";
import { FileModule } from "./game-file/file.module";
import { GameModule } from "./game/game.module";
import { LoggerModule } from "nestjs-pino";

@Global()
@Module({
  imports: [
    CommonModule,
    ConfModule,
    FileModule,
    AccountModule,
    GameModule,
    LoggerModule.forRoot(),
  ],
  controllers: [AppController],
  providers: [],
})
export class AppModule {}
