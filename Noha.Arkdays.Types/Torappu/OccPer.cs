
namespace Torappu
{
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
    public enum OccPer
    {
        ALWAYS,
        ALMOST,
        USUAL,
        OFTEN,
        SOMETIMES,
        NEVER
    }
}
