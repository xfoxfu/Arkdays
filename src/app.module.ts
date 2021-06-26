import { Global, Module } from "@nestjs/common";
import { AppController } from "./app.controller";
import { CommonModule } from "./common/common.module";
import { AccountModule } from "./game-account/account.module";
import { ConfModule } from "./game-conf/conf.module";
import { FileModule } from "./game-file/file.module";
import { GameModule } from "./game/game.module";
import { LoggerModule } from "nestjs-pino";
import PinoPretty from "pino-pretty";

@Global()
@Module({
  imports: [
    CommonModule,
    ConfModule,
    FileModule,
    AccountModule,
    GameModule,
    LoggerModule.forRoot({
      pinoHttp: { prettyPrint: { singleLine: true }, prettifier: PinoPretty },
    }),
  ],
  controllers: [AppController],
  providers: [],
})
export class AppModule {}
