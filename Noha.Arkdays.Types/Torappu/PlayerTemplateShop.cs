using System.Collections.Generic;

namespace Torappu
{
    public class PlayerTemplateShop
    {
        public int coin { get; set; }

        public List<PlayerGoodItemData> info { get; set; }

        public Dictionary<string, PlayerGoodProgressData> progressInfo { get; set; }

        public PlayerTemplateShop()
        {
        }
    }
}
