using System;
using System.Collections.Generic;

namespace Torappu
{
    public class PlayerCheckIn
    {
        [System.Text.Json.Serialization.JsonConverter(typeof(Noha.Arkdays.Types.JsonBoolNumberConverter))]
        public bool canCheckIn { get; set; }

        public string checkInGroupId { get; set; }

        public int checkInRewardIndex { get; set; }

        /// <summary>
        /// checkInHistory is actually `List<bool>`
        /// </summary>
        public List<int> checkInHistory { get; set; }

        public PlayerCheckIn()
        {
        }
    }
}
