import { Module } from "@nestjs/common";
import { U8OnlineController } from "./u8-online.controller";
import { U8PayController } from "./u8-pay.controller";
import { U8UserController } from "./u8-user.controller";
import { UserController } from "./user.controller";

@Module({
  imports: [],
  controllers: [
    UserController,
    U8UserController,
    U8OnlineController,
    U8PayController,
  ],
  providers: [],
})
export class AccountModule {}
