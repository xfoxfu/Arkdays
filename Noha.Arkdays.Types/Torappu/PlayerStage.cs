
namespace Torappu
{
    public class PlayerStage
    {
        public string stageId { get; set; }

        public int completeTimes { get; set; }

        public PlayerStageState state { get; set; }

        [System.Text.Json.Serialization.JsonConverter(typeof(Noha.Arkdays.Types.JsonBoolNumberConverter))]
        public bool hasBattleReplay { get; set; }

        public int noCostCnt { get; set; }

        public PlayerStage()
        {
        }
    }
}
