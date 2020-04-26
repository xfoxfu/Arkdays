using System.Collections.Generic;

namespace Torappu
{
    public class PlayerGacha
    {
        public class PlayerNewbeeGachaPool
        {
            public bool openFlag { get; set; }

            public int cnt { get; set; }

            public PlayerNewbeeGachaPool()
            {
            }
        }

        public class PlayerGachaPool
        {
            public int cnt { get; set; }

            public int maxCnt { get; set; }

            public bool avail { get; set; }

            public PlayerGachaPool()
            {
            }
        }

        public class PlayerFreeLimitGacha
        {
            public int leastFree { get; set; }

            public PlayerFreeLimitGacha()
            {
            }
        }

        public PlayerNewbeeGachaPool newbee { get; set; }

        public Dictionary<string, PlayerGachaPool> normal { get; set; }

        public Dictionary<string, PlayerFreeLimitGacha> limit { get; set; }

        public PlayerGacha()
        {
        }
    }
}
