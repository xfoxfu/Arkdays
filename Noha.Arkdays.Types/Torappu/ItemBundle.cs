using System;

namespace Torappu
{
    public class ItemBundle
    {
        public string id { get; set; }

        public int count { get; set; }

        public ItemType type { get; set; }

        public bool isEmpty { get; }
    }
}
