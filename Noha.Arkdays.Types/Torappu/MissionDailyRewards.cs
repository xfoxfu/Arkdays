using System.Collections.Generic;

namespace Torappu
{
    public class MissionDailyRewards
    {
        public int dailyPoint { get; set; }

        public int weeklyPoint { get; set; }

        public Dictionary<string, Dictionary<string, int>> rewards { get; set; }
    }
}
