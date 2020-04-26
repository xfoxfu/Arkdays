using System.Collections.Generic;

namespace Torappu
{
    public class PlayerFurnitureShopData
    {
        public List<PlayerGoodItemData> info { get; set; }

        public Dictionary<string, int> groupInfo { get; set; }

        public PlayerFurnitureShopData()
        {
        }
    }
}
