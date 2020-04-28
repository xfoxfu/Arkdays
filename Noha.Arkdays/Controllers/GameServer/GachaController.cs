using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Torappu;
using System.Threading.Tasks;
using Noha.Arkdays.Services;
using System.Linq;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Noha.Arkdays.Utils;

namespace Noha.Arkdays.Controllers.GameServer
{
    [ApiController]
    [Host(Constants.GameServer)]
    [Route("gacha")]
    public class GachaController : ControllerBase
    {
        private readonly ITableHolder<CharacterDB> _charTable;
        private readonly ITableHolder<SyncDataResponse> _playerData;

        public GachaController(ITableHolder<CharacterDB> charTable, ITableHolder<SyncDataResponse> playerData)
        {
            _charTable = charTable;
            _playerData = playerData;
        }

        [HttpPost("tenAdvancedGacha")]
        public TenAdvancedGachaResponse TenAdvancedGacha([FromBody] TenAdvancedGachaRequest req)
        {
            var res = new List<GachaResult>();
            for (var i = 0; i < 10; i++)
            {
                var star = Gacha.RandomStar();
                var chars = _charTable.Value
                    .Where(chr => chr.Value.profession != ProfessionCategory.NONE
                                && chr.Value.profession != ProfessionCategory.TOKEN
                                && chr.Value.profession != ProfessionCategory.TRAP)
                    .Where(kv => (int)kv.Value.rarity == star)
                    .Select(kv => kv.Key);
                var char_id = Gacha.FromList(chars);
                res.Add(new GachaResult
                {
                    charInstId = _playerData.Value.user.troop.chars.Where(c => c.Value.charId == char_id).First().Value.instId,
                    charId = char_id,
                    isNew = false,
                    itemGet = new ItemBundle[] { }
                });
            }
            return new TenAdvancedGachaResponse
            {
                gachaResultList = res.ToArray()
            };
        }
    }
}