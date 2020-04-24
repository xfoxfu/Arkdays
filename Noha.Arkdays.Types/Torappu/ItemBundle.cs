using System;

namespace Torappu
{
    public class ItemBundle
    {
        public string id;

        public int count;

        public ItemType type;

        public bool isEmpty { get; }
    }
}
