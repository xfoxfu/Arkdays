using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Torappu
{
    public struct PlayerDataDelta
    {
        public const string DELTA_FIELD = "playerDataDelta";

        public const string MODIFY_FIELD = "modified";

        public const string DELETED_FIELD = "deleted";

        public JObject modified;

        public JObject deleted;

        public bool IsEmpty()
        {
            return default(bool);
        }
    }
}
