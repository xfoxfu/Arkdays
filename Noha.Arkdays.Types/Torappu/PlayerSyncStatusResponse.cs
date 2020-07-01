using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace Torappu
{
    public class PlayerSyncStatusResponse : PlayerDeltaResponse
    {
        public long ts;

        public Dictionary<string, JObject> result;

        public PlayerSyncStatusResponse()
        {
        }
    }
}
