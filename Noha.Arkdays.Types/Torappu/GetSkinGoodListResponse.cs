using System.Collections.Generic;

namespace Torappu
{
    public class GetSkinGoodListResponse : PlayerDeltaResponse
    {
        public List<ShopSkinItemViewModel> goodList { get; set; }

        public GetSkinGoodListResponse()
        {
        }
    }
}
