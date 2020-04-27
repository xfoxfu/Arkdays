using System;

namespace Torappu
{
    public class CampaignGroupData
    {
        public string groupId { get; set; }

        public string[] activeCamps { get; set; }

        public long startTs { get; set; }

        public long endTs { get; set; }

        public CampaignGroupData()
        {
        }
    }
}
