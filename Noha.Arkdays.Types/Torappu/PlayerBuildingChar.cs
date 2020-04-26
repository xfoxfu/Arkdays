using System;

namespace Torappu
{
    public class PlayerBuildingChar
    {
        public class BubbleContainer
        {
            public PlayerBuildingCharBubble normal { get; set; }

            public PlayerBuildingCharBubble assist { get; set; }
        }

        public string charId { get; set; }

        public DateTime lastApAddTime { get; set; }

        public long ap { get; set; }

        public string roomSlotId { get; set; }

        public int index { get; set; }

        public int changeScale { get; set; }

        public BubbleContainer bubble { get; set; }

        public string skinIdInVisit { get; set; }
    }
}
