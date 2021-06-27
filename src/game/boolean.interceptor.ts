import {
  Injectable,
  NestInterceptor,
  ExecutionContext,
  CallHandler,
} from "@nestjs/common";
import { Observable } from "rxjs";
import { map } from "rxjs/operators";

@Injectable()
export class BooleanInterceptor<T> implements NestInterceptor<T, null> {
  intercept(context: ExecutionContext, next: CallHandler): Observable<null> {
    return next.handle().pipe(map((data) => null));
  }
}
