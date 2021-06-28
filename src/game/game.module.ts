import { Module, MiddlewareConsumer, RequestMethod } from "@nestjs/common";
import { AccountController } from "./controller/account";
import { CharBuildController } from "./controller/charbuild";
import { CrisisController } from "./controller/crisis";
import { PayController } from "./controller/pay";
import { QuestController } from "./controller/quest";
import { ShopController } from "./controller/shop";
import { UserController } from "./controller/user";
import { DeltaInterceptor, UserMiddleware } from "./user";

@Module({
  imports: [],
  controllers: [
    AccountController,
    ShopController,
    PayController,
    CharBuildController,
    UserController,
    CrisisController,
    QuestController,
  ],
  providers: [
    {
      provide: "APP_INTERCEPTOR",
      useClass: DeltaInterceptor,
    },
  ],
})
export class GameModule {
  configure(consumer: MiddlewareConsumer): void {
    consumer.apply(UserMiddleware).forRoutes({
      path: "*",
      method: RequestMethod.ALL,
    });
  }
}
