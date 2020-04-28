using System.Collections.Generic;

namespace Torappu
{
    public class PlayerCrisisChallenge
    {
        public class PlayerChallengeTask
        {
            public long fts { get; set; }

            public long rts { get; set; }

            public PlayerChallengeTask()
            {
            }
        }

        public Dictionary<string, long> pointList { get; set; }

        public Dictionary<string, PlayerChallengeTask> taskList { get; set; }

        public int topPoint { get; set; }

        public PlayerCrisisChallenge()
        {
        }
    }
}
