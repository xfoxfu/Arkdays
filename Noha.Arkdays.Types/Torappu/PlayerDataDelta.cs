using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Torappu
{
    public class PlayerDataDelta
    {
        public const string DELTA_FIELD = "playerDataDelta";

        public const string MODIFY_FIELD = "modified";

        public const string DELETED_FIELD = "deleted";

        public PlayerDataModel modified { get; set; }

        public JObject deleted { get; set; }

        public PlayerDataDelta()
        {
            modified = null;
            deleted = null;
        }
    }
}
