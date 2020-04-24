using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using U8.SDK;
using System.Threading.Tasks;
using System.IO;

namespace Noha.Arkdays.Controllers.AccountServer
{
    [ApiController]
    [Host(Constants.AccountServer)]
    [Route("u8/pay")]
    public class U8PayController : ControllerBase
    {
        [HttpPost("getAllProductList")]
        public async Task<string> GetAllProductList()
        {
            using (var reader = new StreamReader(Path.Combine(Constants.DataPath, "AllProductList.json")))
                return await reader.ReadToEndAsync();
        }
    }
}