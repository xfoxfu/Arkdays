using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using HGSDK;
using System.Threading.Tasks;

namespace Noha.Arkdays.Controllers.AccountServer
{
    [ApiController]
    [Host(Constants.AccountServer)]
    [Route("user")]
    public class UserController : ControllerBase
    {
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest req)
        {
            return Ok(new LoginResponse()
            {
                result = 0,
                uid = "1145141919810",
                role = 0,
                token = "eNchDECdrSxNJby+ec9U378srSxNJby+",
                isAuthenticate = true,
                isMinor = false,
                needAuthenticate = false,
                // issuedAt = new System.DateTime(),
                // expiresIn = new System.DateTime().AddYears(1),
            });
        }

        [HttpPost("auth")]
        public AuthResponse Auth([FromBody] AuthRequest req)
        {
            return new AuthResponse
            {
                uid = "1145141919810",
                isAuthenticate = true,
                isMinor = false,
                needAuthenticate = false,
            };
        }
    }
}