using System.Collections.Generic;

namespace Torappu
{
    public class PlayerCrisisPermanent
    {
        public enum RuneStatusMask
        {
            UNLOCK = 1,
            COMPLETE
        }

        public Dictionary<string, int> rune { get; set; }

        public PlayerCrisisChallenge challenge { get; set; }

        public int point { get; set; }

        public long nextSyncTs { get; set; }

        public PlayerCrisisPermanent()
        {
        }
    }
}
