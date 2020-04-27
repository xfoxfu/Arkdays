using System;
using System.Collections.Generic;

namespace Torappu
{
    public class ZoneTable
    {
        public Dictionary<string, ZoneData> zones { get; set; }

        public Dictionary<string, WeeklyZoneData> weeklyAdditionInfo { get; set; }

        public Dictionary<string, ZoneValidInfo> zoneValidInfo { get; set; }

        public ZoneTable()
        {
        }
    }
}
