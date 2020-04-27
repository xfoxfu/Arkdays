using System;
using System.Collections.Generic;

namespace Torappu
{
    public class PlayerBuildingTrading
    {
        public PlayerBuildingTradingBuff buff { get; set; }

        public PlayerRoomState state { get; set; }

        [System.Text.Json.Serialization.JsonConverter(typeof(Noha.Arkdays.Types.JsonDateNumberConverter))]
        public DateTime lastUpdateTime { get; set; }

        public BuildingData.OrderType strategy;

        public int stockLimit { get; set; }

        public int apCost { get; set; }

        public List<PlayerBuildingTradingOrder> stock { get; set; }

        public PlayerBuildingTradingNext next { get; set; }

        public PlayerBuildingTrading()
        {
        }
    }
}
