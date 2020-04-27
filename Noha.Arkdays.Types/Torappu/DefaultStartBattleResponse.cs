
namespace Torappu
{
    public class DefaultStartBattleResponse : CommonStartBattleResponse
    {
        [System.Text.Json.Serialization.JsonConverter(typeof(Noha.Arkdays.Types.JsonBoolNumberConverter))]
        public bool isApProtect { get; set; }

        public int apFailReturn { get; set; }

        public bool notifyPowerScoreNotEnoughIfFailed { get; set; }
    }
}
