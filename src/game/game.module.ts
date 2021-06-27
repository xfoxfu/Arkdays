import { Module, MiddlewareConsumer, RequestMethod } from "@nestjs/common";
import { AccountController } from "./account.controller";
import { PayController } from "./pay.controller";
import { ShopController } from "./shop.controller";
import { DeltaInterceptor, UserMiddleware } from "./user";

@Module({
  imports: [],
  controllers: [AccountController, ShopController, PayController],
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
