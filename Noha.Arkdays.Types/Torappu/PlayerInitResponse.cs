using Newtonsoft.Json.Linq;

namespace Torappu
{
    public abstract class PlayerInitResponse
    {
        public PlayerDataModel user { get; set; }

        protected PlayerInitResponse()
        {
        }
    }
}
