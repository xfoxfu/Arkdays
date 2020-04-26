using System.Collections.Generic;

namespace Torappu
{
    public class PlayerCrisis
    {
        public struct BoxItem
        {
            public string id { get; set; }

            public ItemType type { get; set; }

            public int count { get; set; }
        }

        public string currentSeason { get; set; }

        public Dictionary<string, PlayerCrisisMap> map { get; set; }

        public PlayerCrisisShop shop { get; set; }

        public PlayerCrisisTraining training { get; set; }

        public Dictionary<string, PlayerCrisisSeason> season { get; set; }

        public long lastSyncTs { get; set; }

        public long nextSyncTs { get; set; }

        public List<BoxItem> box { get; set; }

        public PlayerCrisis()
        {
        }
    }
}
