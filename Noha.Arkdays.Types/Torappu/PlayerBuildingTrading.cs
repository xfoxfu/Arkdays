using System;
using System.Collections.Generic;

namespace Torappu
{
    public class PlayerBuildingTrading
    {
        public PlayerBuildingTradingBuff buff { get; set; }

        public PlayerRoomState state { get; set; }

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
