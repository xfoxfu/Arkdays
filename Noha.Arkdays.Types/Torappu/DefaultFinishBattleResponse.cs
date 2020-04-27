using System.Collections.Generic;

namespace Torappu
{
    public class DefaultFinishBattleResponse : CommonFinishBattleResponse
    {
        public float goldScale { get; set; }

        public float expScale { get; set; }

        public List<RewardModel> firstRewards { get; set; }

        public string[] unlockStages { get; set; }

        // public List<ServiceAlertStruct> alert{get;set;}
    }
}
