using System.Collections.Generic;

namespace Torappu
{
    public class StoryOnlyStartBattleResponse : PlayerDeltaResponse
    {
        public int result { get; set; }

        public List<CommonFinishBattleResponse.RewardModel> rewards { get; set; }

        public string[] unlockStages { get; set; }

        // public List<ServiceAlertStruct> alert;
    }
}
