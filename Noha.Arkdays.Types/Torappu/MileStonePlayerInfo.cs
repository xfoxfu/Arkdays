using System.Collections.Generic;

namespace Torappu
{
    public class MileStonePlayerInfo
    {
        public class MileStoneRewardTicketItem
        {
            public long ts;

            public int count;
        }

        public Dictionary<string, int> points;

        public Dictionary<string, MileStoneRewardTicketItem> rewards;
    }
}
