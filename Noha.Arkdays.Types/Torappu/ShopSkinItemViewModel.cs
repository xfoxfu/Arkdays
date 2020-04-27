
namespace Torappu
{
    public class ShopSkinItemViewModel
    {
        public string goodId { get; set; }

        public int slotId { get; set; }

        public string skinId { get; set; }

        public int originPrice { get; set; }

        public int price { get; set; }

        public float discount { get; set; }

        public string skinName { get; set; }

        public ShopCurrencyUnit currencyUnit { get; set; }

        public long startDateTime { get; set; }

        public long endDateTime { get; set; }

        public ShopSkinItemViewModel()
        {
        }
    }
}
