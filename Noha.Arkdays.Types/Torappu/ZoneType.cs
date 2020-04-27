
namespace Torappu
{
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
    public enum ZoneType
    {
        NONE,
        MAINLINE,
        WEEKLY,
        ACTIVITY,
        GUIDE,
        TRAINING,
        CAMPAIGN
    }
}
