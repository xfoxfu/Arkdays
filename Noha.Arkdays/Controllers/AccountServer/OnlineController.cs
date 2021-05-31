using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using HGSDK;
using System.Threading.Tasks;
using System.Dynamic;

namespace Noha.Arkdays.Controllers.AccountServer
{
    [Controller]
    [Host(Constants.AccountServer)]
    [Route("online/v1")]
    public class OnlineController : ControllerBase
    {
        [HttpPost("ping")]
        public dynamic Ping([FromBody] PingRequest req)
        {
            return new PingResponse
            {
                result = 0,
                message = "OK",
                interval = 4330,
                timeLeft = -1,
                alertTime = 600,
            };
        }
    }
}
