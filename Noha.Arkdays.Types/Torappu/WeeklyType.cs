
namespace Torappu
{
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
    public enum WeeklyType
    {
        NONE,
        MATERIAL,
        EVOLVE
    }
}
