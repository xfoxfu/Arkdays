import { Module } from "@nestjs/common";
import { AccountController } from "./account.controller";
import { ShopController } from "./shop.controller";

@Module({
  imports: [],
  controllers: [AccountController, ShopController],
  providers: [],
})
export class GameModule {}
