using System.Collections.Generic;

namespace Torappu
{
    public abstract class CommonFinishBattleResponse : PlayerDeltaResponse
    {
        public class RewardModel
        {
            public string id { get; set; }

            public ItemType type { get; set; }

            public int count { get; set; }

            // public GachaResult charGet { get; set; }
        }

        public int result { get; set; }

        public int apFailReturn { get; set; }

        public List<RewardModel> rewards { get; set; }

        public List<RewardModel> unusualRewards { get; set; }

        public List<RewardModel> additionalRewards { get; set; }

        public List<RewardModel> diamondMaterialRewards { get; set; }

        public List<RewardModel> furnitureRewards { get; set; }
    }
}
