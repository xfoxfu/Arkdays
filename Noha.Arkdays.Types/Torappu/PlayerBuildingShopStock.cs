using System;

namespace Torappu
{
    public class PlayerBuildingShopStock
    {
        public float buffSpeed { get; set; }

        public PlayerRoomState state { get; set; }

        public string formulaId { get; set; }

        public int itemCnt { get; set; }

        public double processPoint { get; set; }

        public DateTime lastUpdateTime { get; set; }

        public long saveTime { get; set; }

        public DateTime completeWorkTime { get; set; }

        public PlayerBuildingShopStock()
        {
        }
    }
}
