using System;
using System.Text.Json.Serialization;
using Noha.Arkdays.Types;

namespace Torappu
{
    public class PlayerBuildingLabor
    {
        public float buffSpeed { get; set; }

        public int value { get; set; }

        public int maxValue { get; set; }

        [JsonConverter(typeof(JsonDateNumberConverter))]
        public DateTime lastUpdateTime { get; set; }

        public double processPoint { get; set; }
    }
}
