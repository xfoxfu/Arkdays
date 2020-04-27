using System;
using System.Collections.Generic;

namespace Torappu
{
    public class CampaignData
    {
        public struct CampaignDropInfo
        {
            public ItemBundle[] firstPassRewards { get; set; }

            public WeightItemBundle[][] passRewards { get; set; }

            public List<StageData.DisplayDetailRewards> displayDetailRewards { get; set; }
        }

        public struct BreakRewardLadder
        {
            public int killCnt { get; set; }

            public int breakFeeAdd { get; set; }

            public ItemBundle[] rewards { get; set; }
        }

        public struct DropLadder
        {
            public int killCnt { get; set; }

            public CampaignDropInfo dropInfo { get; set; }
        }

        public struct GainLadder
        {
            public int killCnt { get; set; }

            public int apFailReturn { get; set; }

            public int favor { get; set; }

            public int expGain { get; set; }

            public int goldGain { get; set; }
        }

        public string stageId { get; set; }

        public List<GainLadder> gainLadders { get; set; }

        public List<BreakRewardLadder> breakLadders { get; set; }

        public List<DropLadder> dropLadders { get; set; }

        public List<StageData.DisplayRewards> displayRewards { get; set; }

        public List<StageData.DisplayDetailRewards> displayDetailRewards { get; set; }
    }
}
