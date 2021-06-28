import { Body, Controller, Post } from "@nestjs/common";
import { Routes, ServerDomains } from "../../consts";
import type { Torappu } from "../../types";
import { User } from "../user";

@Controller({ host: [ServerDomains.GameServer] })
export class CharBuildController {
  @Post(Routes.CHANGE_SKIN_SELECT)
  public ChangeSkin(
    @Body() req: Torappu.ChangeCharSkinRequest,
    @User() user: Torappu.PlayerDataModel,
  ): Torappu.ChangeCharSkinResponse {
    user.troop.chars[req.charInstId].skin = req.skinId;
    return {};
  }

  @Post(Routes.SET_DEFAULT_SKILL)
  public SetDefaultSkill(
    @Body() req: Torappu.SetDefaultSkillRequest,
    @User() user: Torappu.PlayerDataModel,
  ): Torappu.SetDefaultSkillResponse {
    user.troop.chars[req.charInstId].defaultSkillIndex = req.defaultSkillIndex;
    return {};
  }
}
