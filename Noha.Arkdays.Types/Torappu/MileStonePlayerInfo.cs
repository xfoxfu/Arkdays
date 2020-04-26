using System.Collections.Generic;

namespace Torappu
{
    public class MileStonePlayerInfo
    {
        public class MileStoneRewardTicketItem
        {
            public long ts { get; set; }

            public int count { get; set; }
        }

        public Dictionary<string, int> points { get; set; }

        public Dictionary<string, MileStoneRewardTicketItem> rewards { get; set; }
    }
}
