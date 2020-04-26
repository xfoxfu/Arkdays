using System;

namespace Torappu
{
    public class PlayerBuildingHire
    {
        public PlayerBuildingHireBuff buff { get; set; }

        public int recruitSlotId { get; set; }

        public PlayerBuildingHiringState state { get; set; }

        public double processPoint { get; set; }

        public float speed { get; set; }

        public DateTime lastUpdateTime { get; set; }

        public int refreshCount { get; set; }

        public DateTime completeWorkTime { get; set; }
    }
}
