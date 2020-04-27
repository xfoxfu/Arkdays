
namespace Torappu
{
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
    public enum StageDropType
    {
        NONE,
        ONCE,
        NORMAL,
        SPECIAL,
        ADDITIONAL,
        APRETURN,
        DIAMOND_MATERIAL,
        FUNITURE_DROP,
        COMPLETE
    }
}
