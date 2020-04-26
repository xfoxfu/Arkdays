using System.Collections.Generic;

namespace Torappu
{
    public class PlayerBuildingShop
    {
        public PlayerBuildingShopStock[] stock { get; set; }

        public List<PlayerBuildingShopOutputItem> outputItem { get; set; }

        public PlayerBuildingShop()
        {
        }
    }
}
