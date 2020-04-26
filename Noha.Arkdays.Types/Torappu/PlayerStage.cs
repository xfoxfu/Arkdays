
namespace Torappu
{
    public class PlayerStage
    {
        public string stageId { get; set; }

        public int completeTimes { get; set; }

        public PlayerStageState state { get; set; }

        public bool hasBattleReplay { get; set; }

        public int noCostCnt { get; set; }

        public PlayerStage()
        {
        }
    }
}
