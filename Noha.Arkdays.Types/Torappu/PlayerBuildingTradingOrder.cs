
namespace Torappu
{
    public class PlayerBuildingTradingOrder
    {
        public long instId { get; set; }

        public BuildingData.OrderType type;

        public ItemBundle[] delivery { get; set; }

        public ItemBundle gain { get; set; }

        public PlayerBuildingTradingOrder()
        {
        }
    }
}
