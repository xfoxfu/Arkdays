using System;

namespace Torappu
{
    public class GachaResult
    {
        public int charInstId { get; set; }

        public string charId { get; set; }

        public bool isNew { get; set; }

        public ItemBundle[] itemGet { get; set; }

        public GachaResult()
        {
        }
    }
}
