using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Torappu;
using System.Threading.Tasks;
using Noha.Arkdays.Services;
using System.Linq;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Noha.Arkdays.Controllers.GameServer
{
    [ApiController]
    [Host(Constants.GameServer)]
    [Route("quest")]
    public class QuestController : ControllerBase
    {
        [HttpPost("squadFormation")]
        public object SquadFormation([FromBody] SquadFormationRequest req)
        {
            var ret = new
            {
                playerDataDelta = new
                {
                    modified = new
                    {
                        troop = new
                        {
                            squads = new Dictionary<string, PlayerSquad>
                            {
                                [req.squadId] = new PlayerSquad
                                {
                                    squadId = Convert.ToInt32(req.squadId),
                                    name = "假的编队",
                                    slots = req.slots
                                        .Select(s => s != null ? new PlayerSquadItem
                                        {
                                            charInstId = s.charInstId,
                                            skillIndex = s.skillIndex,
                                        } : null)
                                        .ToArray()
                                }
                            }
                        }
                    }
                }
            };
            return ret;
        }

        [HttpPost("battleStart")]
        public DefaultStartBattleResponse BattleStart([FromBody] DefaultStartBattleRequest req)
        {
            return new DefaultStartBattleResponse
            {
                result = 0,
                battleId = "0913f930-8142-11ea-931d-4fc3078f82b2",
                apFailReturn = 0,
                isApProtect = false,
                notifyPowerScoreNotEnoughIfFailed = false,
            };
        }

        [HttpPost("battleFinish")]
        public DefaultFinishBattleResponse BattleFinish([FromBody] DefaultFinishBattleRequest req)
        {
            return new DefaultFinishBattleResponse
            {
                goldScale = 1.2F,
                expScale = 1.2F,
                firstRewards = new List<CommonFinishBattleResponse.RewardModel>(),
                unlockStages = new string[] { },
                result = 0,
                apFailReturn = 0,
                rewards = new List<CommonFinishBattleResponse.RewardModel>(),
                unusualRewards = new List<CommonFinishBattleResponse.RewardModel>(),
                additionalRewards = new List<CommonFinishBattleResponse.RewardModel>(),
                diamondMaterialRewards = new List<CommonFinishBattleResponse.RewardModel>(),
                furnitureRewards = new List<CommonFinishBattleResponse.RewardModel>(),
            };
        }
    }
}