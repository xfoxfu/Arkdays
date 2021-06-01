import { Module } from "@nestjs/common";
import { U8UserController } from "./u8-user.controller";
import { UserController } from "./user.controller";

@Module({
  imports: [],
  controllers: [UserController, U8UserController],
  providers: [],
})
export class AccountModule {}
