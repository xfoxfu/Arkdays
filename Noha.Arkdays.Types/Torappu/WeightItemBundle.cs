using System;

namespace Torappu
{
    public class WeightItemBundle
    {
        public string id { get; set; }

        public ItemType type { get; set; }

        public StageDropType dropType { get; set; }

        public int count { get; set; }

        public int weight { get; set; }
    }
}
