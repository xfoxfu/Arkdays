
namespace Torappu
{
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
    public enum AppearanceStyle
    {
        MAIN_NORMAL,
        MAIN_PREDEFINED,
        SUB,
        TRAINING,
        HIGH_DIFFICULTY,
        MIST_OPS
    }
}
