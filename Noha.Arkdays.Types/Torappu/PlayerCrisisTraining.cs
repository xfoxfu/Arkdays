using System.Collections.Generic;

namespace Torappu
{
    public class PlayerCrisisTraining
    {
        public List<string> currentStage { get; set; }

        public Dictionary<string, PlayerCrisisTrainingStage> stage { get; set; }

        public long nextSyncTs { get; set; }

        public PlayerCrisisTraining()
        {
        }
    }
}
