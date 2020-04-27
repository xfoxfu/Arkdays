using System.Collections.Generic;

namespace Torappu
{
    public class CampaignFinishBattleResponse : CommonFinishBattleResponse
    {
        public int currentFeeBefore { get; set; }

        public int currentFeeAfter { get; set; }

        public string[] unlockStages { get; set; }

        // public List<ServiceAlertStruct> alert { get; set; }
    }
}
