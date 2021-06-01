import { NestFactory } from "@nestjs/core";
import { AppModule } from "./app.module";
import { readFile } from "fs/promises";
import http from "http";
import https from "https";
import { ExpressAdapter } from "@nestjs/platform-express";
import express from "express";
import { Logger } from "@nestjs/common";

async function bootstrap() {
  const server = express();
  const app = await NestFactory.create(AppModule, new ExpressAdapter(server));
  await app.init();

  http.createServer(server).listen(3000);

  try {
    const httpsOptions = {
      key: (await readFile("./cert/privkey.pem")).toString(),
      cert: (await readFile("./cert/fullchain.pem")).toString(),
    };
    https.createServer(httpsOptions, server).listen(5001);
  } catch (e: unknown) {
    if (e instanceof Error) {
      app
        .get(Logger)
        .warn(`Disable SSL because of Error ${e.message ?? "unknown error"}`);
    } else {
      console.error(e);
    }
  }
}
bootstrap().catch(console.error);
