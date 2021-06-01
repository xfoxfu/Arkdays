import { Global, Module } from "@nestjs/common";
import { AppController } from "./app.controller";
import { CommonModule } from "./common/common.module";
import { ConfModule } from "./game-conf/conf.module";

@Global()
@Module({
  imports: [CommonModule, ConfModule],
  controllers: [AppController],
  providers: [],
})
export class AppModule {}
