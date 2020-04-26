using Newtonsoft.Json.Linq;

namespace Torappu
{
    public abstract class PlayerInitResponse
    {
        public JObject user { get; set; }

        protected PlayerInitResponse()
        {
        }
    }
}
