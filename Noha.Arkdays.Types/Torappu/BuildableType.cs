using System.Text.Json.Serialization;

namespace Torappu
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum BuildableType
    {
        NONE,
        MELEE,
        RANGED,
        ALL
    }
}
