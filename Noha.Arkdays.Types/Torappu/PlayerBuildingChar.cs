using System;

namespace Torappu
{
    public class PlayerBuildingChar
    {
        public class BubbleContainer
        {
            public PlayerBuildingCharBubble normal;

            public PlayerBuildingCharBubble assist;
        }

        public string charId;

        public DateTime lastApAddTime;

        public long ap;

        public string roomSlotId;

        public int index;

        public int changeScale;

        public BubbleContainer bubble;

        public string skinIdInVisit;
    }
}
