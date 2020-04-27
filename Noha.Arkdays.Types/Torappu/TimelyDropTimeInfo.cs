using System.Collections.Generic;

namespace Torappu
{
    public class TimelyDropTimeInfo
    {
        public long startTs { get; set; }

        public long endTs { get; set; }

        public string stagePic { get; set; }

        public string dropPicId { get; set; }

        public string stageUnlock { get; set; }

        public string entranceDownPicId { get; set; }

        public string entranceUpPicId { get; set; }

        public string timelyGroupId { get; set; }

        public string weeklyPicId { get; set; }

        public Dictionary<string, long> apSupplyOutOfDateDict { get; set; }
    }
}
