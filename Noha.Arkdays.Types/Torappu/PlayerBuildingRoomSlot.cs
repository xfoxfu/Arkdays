using System;

namespace Torappu
{
    public class PlayerBuildingRoomSlot
    {
        public int level { get; set; }

        public PlayerRoomSlotState state { get; set; }

        public BuildingData.RoomType roomId;

        public int[] charInstIds { get; set; }

        [System.Text.Json.Serialization.JsonConverter(typeof(Noha.Arkdays.Types.JsonDateNumberConverter))]
        public DateTime completeConstructTime { get; set; }

        public PlayerBuildingRoomSlot()
        {
        }
    }
}
