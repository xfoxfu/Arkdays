using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Torappu;
using System.Threading.Tasks;

namespace Noha.Arkdays.Controllers.GameServer
{
    [ApiController]
    [Host(Constants.GameServer)]
    [Route("account")]
    public class AccountController : ControllerBase
    {
        [HttpPost("login")]
        public LoginResponse Login([FromBody] LoginRequestV002 req)
        {
            return new LoginResponse
            {
                result = 0,
                uid = "112165182",
                secret = "In7aw+5mJsaYTYBvgeszDABHS2U8nfK7",
                serviceLicenseVersion = 0
            };
        }

        // [HttpGet("syncData")]
        // public Sync
    }
}