namespace Torappu
{
    public abstract class CommonFinishBattleRequest
    {
        public struct BattleData
        {
            public string isCheat { get; set; }

            public long completeTime { get; set; }

            // public BattleLogger.BattleStats stats { get; set; }
        }

        public string data { get; set; }

        public BattleData battleData { get; set; }

        protected CommonFinishBattleRequest()
        {
        }
    }
}
