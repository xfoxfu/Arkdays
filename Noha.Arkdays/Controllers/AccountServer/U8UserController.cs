using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using U8.SDK;
using System.Threading.Tasks;

namespace Noha.Arkdays.Controllers.AccountServer
{
    [ApiController]
    [Host(Constants.AccountServer)]
    [Route("u8/user")]
    public class U8UserController : ControllerBase
    {
        [HttpPost("getToken")]
        public U8LoginResult GetToken()
        {
            return new U8LoginResult
            {
                result = 0,
                uid = "114514",
                channelUid = "1919810",
                token = "70cfc1ef80771c97a01628259f6f3af5",
                isGuest = 0,
                extension = "{\"isGuest\":0}"
            };
        }

        [HttpPost("verifyAccount")]
        public object VerifyAccount()
        {
            return new { uid = "114514" };
        }
    }
}