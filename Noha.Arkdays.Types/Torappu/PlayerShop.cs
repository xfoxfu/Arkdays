
namespace Torappu
{
    public class PlayerShop
    {
        public PlayerLowQCShopProgressData lowQCShop { get; set; }

        public PlayerHighQCShopProgressData highQCShop { get; set; }

        public PlayerCommonShopProgressData extraQCShop { get; set; }

        public PlayerLMTGSProgressData lmtgsQCShop { get; set; }

        public PlayerEPGSProgressData epgsQCShop { get; set; }

        public PlayerCashProgressData cashShop { get; set; }

        public PlayerGiftProgressData giftShop { get; set; }

        public PlayerSocialShopData socialShop { get; set; }

        public PlayerFurnitureShopData furnitureShop { get; set; }

        public PlayerShop()
        {
        }
    }
}
