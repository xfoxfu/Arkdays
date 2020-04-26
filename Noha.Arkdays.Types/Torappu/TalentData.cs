using System;

namespace Torappu
{
    public class TalentData
    {
        public CharacterData.UnlockCondition unlockCondition;

        public int requiredPotentialRank { get; set; }

        public string prefabKey { get; set; }

        public string name { get; set; }

        public string description { get; set; }

        public string rangeId { get; set; }

        public Blackboard blackboard { get; set; }

    }
}
