using System.Collections.Generic;

namespace Torappu
{
    public class MissionPlayerData
    {
        public enum MissionGroupState
        {
            Uncomplete,
            Complete
        }

        public MissionPlayerDataGroup missions { get; set; }

        public MissionDailyRewards missionRewards { get; set; }

        public Dictionary<string, MissionGroupState> missionGroups { get; set; }
    }
}
