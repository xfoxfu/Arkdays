using System;

namespace Torappu
{
    public class PlayerBuildingTraining
    {
        public PlayerBuildingTrainingBuff buff { get; set; }

        [System.Text.Json.Serialization.JsonConverter(typeof(Noha.Arkdays.Types.JsonDateNumberConverter))]
        public DateTime lastUpdateTime { get; set; }

        public PlayerBuildingTrainer trainer { get; set; }

        public PlayerBuildingTrainee trainee { get; set; }

        [System.Text.Json.Serialization.JsonConverter(typeof(Noha.Arkdays.Types.JsonDateNumberConverter))]
        public DateTime completeWorkTime { get; set; }

        public PlayerBuildingTraining()
        {
        }
    }
}
