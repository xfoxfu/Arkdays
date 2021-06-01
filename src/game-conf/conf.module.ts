import { Module } from "@nestjs/common";
import { ConfController } from "./conf.controller";

@Module({
  imports: [],
  controllers: [ConfController],
  providers: [],
})
export class ConfModule {}
