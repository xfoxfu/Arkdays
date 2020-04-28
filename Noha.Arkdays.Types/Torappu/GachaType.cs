using System.Text.Json.Serialization;

namespace Torappu
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum GachaType
    {
        None = -1,
        Diamond,
        SingleTicket,
        TenTicket,
        LimitSingle,
        LimitTen
    }
}
