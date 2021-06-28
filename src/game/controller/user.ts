import { Body, Controller, Post } from "@nestjs/common";
import { Routes, ServerDomains } from "../../consts";
import type { Torappu } from "../../types";
import { User } from "../user";

@Controller({ host: [ServerDomains.GameServer] })
export class UserController {
  @Post(Routes.CHANGE_SECRETARY)
  public ChangeSecretary(
    @Body() req: Torappu.ChangeSecretaryRequest,
    @User() user: Torappu.PlayerDataModel,
  ): Torappu.ChangeSecretaryResponse {
    user.status.secretary = user.troop.chars[req.charInstId].charId;
    user.status.secretarySkinId = req.skinId;
    console.log(req, user.status.secretary, user.status.secretarySkinId);
    return {};
  }
}
