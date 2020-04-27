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
    [Route("campaign")]
    public class CampaignController : ControllerBase
    {
        [HttpPost("battleStart")]
        public CampaignStartBattleResponse BattleStart([FromBody] CampaignStartBattleRequest req)
        {
            return new CampaignStartBattleResponse
            {
                result = 0,
                battleId = "0913f930-8142-11ea-931d-4fc3078f82b2",
            };
        }

        [HttpPost("battleFinish")]
        public CampaignFinishBattleResponse BattleFinish([FromBody] CampaignFinishBattleRequest req)
        {
            return new CampaignFinishBattleResponse
            {
                currentFeeBefore = 1800,
                currentFeeAfter = 1800,
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