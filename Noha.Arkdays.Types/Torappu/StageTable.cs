using System;
using System.Collections.Generic;

namespace Torappu
{
    public class StageTable
    {
        public Dictionary<string, StageData> stages { get; set; }

        public Dictionary<string, CampaignData> campaigns { get; set; }

        public Dictionary<string, CampaignGroupData> campaignGroups { get; set; }

        public Dictionary<string, RuneStageGroupData> runeStageGroups { get; set; }

        public Dictionary<string, MapThemeData> mapThemes { get; set; }

        public Dictionary<string, TileAppendInfo> tileInfo { get; set; }

        public Dictionary<string, WeeklyForceOpenTable> forceOpenTable { get; set; }

        public Dictionary<string, TimelyDropTimeInfo> timelyStageDropInfo { get; set; }

        public Dictionary<string, TimelyDropInfo> timelyTable { get; set; }

        public Dictionary<string, StageValidInfo> stageValidInfo { get; set; }
    }
}
