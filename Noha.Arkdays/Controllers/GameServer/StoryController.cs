using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Torappu;
using System.Threading.Tasks;
using Noha.Arkdays.Services;
using System.Linq;
using System;

namespace Noha.Arkdays.Controllers.GameServer
{
    [ApiController]
    [Host(Constants.GameServer)]
    [Route("story")]
    public class StoryController : ControllerBase
    {
        [HttpPost("finishStory")]
        public FinishStoryResponse FinishStory([FromBody] FinishStoryRequest req)
        {
            return new FinishStoryResponse { };
        }
    }
}