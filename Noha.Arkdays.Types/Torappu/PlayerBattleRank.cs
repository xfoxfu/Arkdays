
namespace Torappu
{
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
    public enum PlayerBattleRank
    {
        FAIL = 1,
        PASS,
        COMPLETE
    }
}
