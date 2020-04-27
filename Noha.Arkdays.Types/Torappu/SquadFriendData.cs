using System;

namespace Torappu
{
    public class SquadFriendData : FriendCommonData
    {
        public SharedCharData assistChar { get; set; }

        public int assistSlotIndex { get; set; }

        public SquadFriendData()
        {
        }
    }
}
