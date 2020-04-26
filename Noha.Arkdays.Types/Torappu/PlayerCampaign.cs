
using System.Collections.Generic;

namespace Torappu
{
    public class PlayerCampaign
    {
        public class Instance
        {
            public int maxKills { get; set; }

            public int[] rewardStatus { get; set; }

            public Instance()
            {
            }
        }

        public int campaignCurrentFee { get; set; }

        public int campaignTotalFee { get; set; }

        public string activeGroupId { get; set; }

        public Dictionary<string, Instance> instances { get; set; }

        public PlayerCampaign()
        {
        }
    }
}
