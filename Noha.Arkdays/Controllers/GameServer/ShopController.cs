using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Torappu;
using System.Threading.Tasks;
using Noha.Arkdays.Services;
using System.Linq;
using System;
using System.Collections.Generic;

namespace Noha.Arkdays.Controllers.GameServer
{
    [ApiController]
    [Host(Constants.GameServer)]
    [Route("shop")]
    public class ShopController : ControllerBase
    {
        private readonly ITableHolder<SkinTable> _skinTable;

        public ShopController(ITableHolder<SkinTable> skinTable)
        {
            _skinTable = skinTable;
        }

        [HttpPost("getSkinGoodList")]
        public GetSkinGoodListResponse GetSkinGoodList([FromBody] GetSkinGoodListRequest req)
        {
            return new GetSkinGoodListResponse
            {
                goodList = new List<ShopSkinItemViewModel>()
                /* _skinTable.Value.charSkins
                    .Where(s => req.charIdList.Contains(s.Value.charId))
                    .Select(s => new ShopSkinItemViewModel
                    {
                        goodId = s.Value.tokenSkinId,
                        slotId = 0,
                        skinId = s.Value.skinId,
                        originPrice = 0,
                        price = 0,
                        discount = 0,
                        skinName = s.Value.displaySkin.skinName,
                        currencyUnit = ShopCurrencyUnit.DIAMOND,
                        startDateTime = DateTime.Now.AddDays(-1).ToBinary() / 1000,
                        endDateTime = DateTime.Now.AddDays(7).ToBinary() / 1000,
                    })
                    .ToList() */
            };
        }
    }
}