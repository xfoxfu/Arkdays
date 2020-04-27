using System;
using System.Collections.Generic;

namespace Torappu
{
    public class WeeklyForceOpenTable
    {
        public string id { get; set; }

        public long startTime { get; set; }

        public long endTime { get; set; }

        public List<string> forceOpenList { get; set; }

        public WeeklyForceOpenTable()
        {
        }
    }
}
