using System;

namespace Torappu
{
    public class PlayerBuildingTraining
    {
        public PlayerBuildingTrainingBuff buff { get; set; }

        public DateTime lastUpdateTime { get; set; }

        public PlayerBuildingTrainer trainer { get; set; }

        public PlayerBuildingTrainee trainee { get; set; }

        public DateTime completeWorkTime { get; set; }

        public PlayerBuildingTraining()
        {
        }
    }
}
