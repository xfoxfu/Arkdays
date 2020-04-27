using System;

namespace Torappu
{
    public class PlayerBuildingManufacture
    {
        public PlayerBuildingManufactureBuff buff { get; set; }

        public PlayerRoomState state { get; set; }

        public string formulaId { get; set; }

        public int remainSolutionCnt { get; set; }

        public int outputSolutionCnt { get; set; }

        [System.Text.Json.Serialization.JsonConverter(typeof(Noha.Arkdays.Types.JsonDateNumberConverter))]
        public DateTime lastUpdateTime { get; set; }

        public double processPoint { get; set; }

        public long saveTime { get; set; }

        [System.Text.Json.Serialization.JsonConverter(typeof(Noha.Arkdays.Types.JsonDateNumberConverter))]
        public DateTime completeWorkTime { get; set; }

        public int capacity { get; set; }

        public int apCost { get; set; }
    }
}
