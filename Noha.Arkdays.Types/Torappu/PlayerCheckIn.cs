using System;
using System.Collections.Generic;

namespace Torappu
{
    public class PlayerCheckIn
    {
        public bool canCheckIn { get; set; }

        public string checkInGroupId { get; set; }

        public int checkInRewardIndex { get; set; }

        public List<bool> checkInHistory { get; set; }

        public PlayerCheckIn()
        {
        }
    }
}
