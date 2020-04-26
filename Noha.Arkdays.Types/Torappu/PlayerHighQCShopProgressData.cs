using System.Collections.Generic;

namespace Torappu
{
    public class PlayerHighQCShopProgressData
    {
        public List<PlayerGoodItemData> info { get; set; }

        public Dictionary<string, PlayerGoodProgressData> progressInfo { get; set; }

        public PlayerHighQCShopProgressData()
        {
        }
    }
}
