using System;
using System.Collections.Generic;

namespace Torappu
{
    public class SharedCharData
    {
        public class SharedCharSkillData
        {
            public string skillId { get; set; }

            public int specializeLevel { get; set; }

            public SharedCharSkillData()
            {
            }
        }

        public string charId { get; set; }

        public string skinId { get; set; }

        public int potentialRank { get; set; }

        public SharedCharSkillData[] skills { get; set; }

        public int skillIndex { get; set; }

        public int mainSkillLvl { get; set; }

        public int evolvePhase { get; set; }

        public int level { get; set; }

        public int favorPoint { get; set; }

        public Dictionary<string, int> crisisRecord { get; set; }

        public SharedCharData()
        {
        }
    }
}
