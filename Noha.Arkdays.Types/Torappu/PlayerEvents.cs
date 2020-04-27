using System;

namespace Torappu
{
    public class PlayerEvents
    {
        [System.Text.Json.Serialization.JsonConverter(typeof(Noha.Arkdays.Types.JsonDateNumberConverter))]
        public DateTime building { get; set; }

        public long status { get; set; }

        public PlayerEvents()
        {
        }
    }
}
