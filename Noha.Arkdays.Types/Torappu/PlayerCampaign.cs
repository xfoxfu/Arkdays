
using System.Collections.Generic;

namespace Torappu
{
    public class PlayerCampaign
    {
        public class Instance
        {
            public int maxKills;

            public int[] rewardStatus;

            public Instance()
            {
            }
        }

        public int campaignCurrentFee;

        public int campaignTotalFee;

        public string activeGroupId;

        public Dictionary<string, Instance> instances;

        public PlayerCampaign()
        {
        }
    }
}
