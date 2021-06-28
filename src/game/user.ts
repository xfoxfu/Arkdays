import {
  Injectable,
  NestMiddleware,
  createParamDecorator,
  ExecutionContext,
  NestInterceptor,
  CallHandler,
} from "@nestjs/common";
import { Request, Response, NextFunction } from "express";
import { computeDelta } from "../common/diff";
import { GameDataService, TokenService } from "../common/entity";
import { Torappu } from "../types";
import { Observable, from } from "rxjs";
import { convertBoolean, convertDate } from "../common/convert-type";

declare module "express-serve-static-core" {
  interface Request {
    user?: Torappu.PlayerDataModel;
    uid?: string;
  }
}

@Injectable()
export class UserMiddleware implements NestMiddleware {
  constructor(
    private readonly tokenSvc: TokenService,
    private readonly sGameData: GameDataService,
  ) {}

  async use(req: Request, _res: Response, next: NextFunction): Promise<void> {
    if (typeof req.headers["secret"] === "string") {
      const uid = await this.tokenSvc.GetAccount(req.headers["secret"]);
      req.uid = uid;

      if (!(await this.sGameData.Exists(uid))) {
        await this.sGameData.Initialize(uid);
      }
      const user = await this.sGameData.Get(uid);
      req.user = user;
    }

    next();
  }
}

export const User = createParamDecorator(
  (_data: unknown, ctx: ExecutionContext): Torappu.PlayerDataModel => {
    const req: Request = ctx.switchToHttp().getRequest();
    if (!req.user) throw new Error("user is not attached to request");
    return req.user;
  },
);

type ApiResponse<T> = T &
  Partial<Pick<Torappu.PlayerDeltaResponse, "playerDataDelta">>;

@Injectable()
export class DeltaInterceptor<T> implements NestInterceptor<T, ApiResponse<T>> {
  constructor(private readonly sGameData: GameDataService) {}

  intercept(
    context: ExecutionContext,
    next: CallHandler,
  ): Observable<ApiResponse<T>> {
    return from(
      (async (): Promise<ApiResponse<T>> => {
        const req = context.switchToHttp().getRequest<Request>();
        const data = await next.handle().toPromise<T>();
        if (!req.uid || !req.user) return data;
        const original = await this.sGameData.Get(req.uid ?? "");

        if (!req.uid) throw new Error("uid is not attached to request");
        if (!req.user) throw new Error("user is not attached to request");
        await this.sGameData.Set(req.uid, req.user);

        const playerDataDelta = computeDelta(original, req.user);
        return convertBoolean(
          convertDate({ playerDataDelta, ...data }),
        ) as ApiResponse<T>;
      })(),
    );
  }
}
