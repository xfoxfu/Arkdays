
using System.Collections.Generic;

namespace Torappu
{
    public class PlayerBuildingWorkshopBuff
    {
        public class Cost
        {
            public string type { get; set; }

            public long limit { get; set; }

            public long reduction { get; set; }

            public Cost()
            {
            }
        }

        public class CostRe
        {
            public string type { get; set; }

            public long from { get; set; }

            public long change { get; set; }

            public CostRe()
            {
            }
        }

        public Dictionary<string, float> rate { get; set; }

        public Cost cost { get; set; }

        public CostRe costRe { get; set; }

        public PlayerBuildingWorkshopBuff()
        {
        }
    }
}
