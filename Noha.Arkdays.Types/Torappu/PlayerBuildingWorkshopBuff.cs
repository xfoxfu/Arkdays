
using System.Collections.Generic;

namespace Torappu
{
    public class PlayerBuildingWorkshopBuff
    {
        public class Cost
        {
            public string type;

            public long limit;

            public long reduction;

            public Cost()
            {
            }
        }

        public class CostRe
        {
            public string type;

            public long from;

            public long change;

            public CostRe()
            {
            }
        }

        public Dictionary<string, float> rate;

        public Cost cost;

        public CostRe costRe;

        public PlayerBuildingWorkshopBuff()
        {
        }
    }
}
