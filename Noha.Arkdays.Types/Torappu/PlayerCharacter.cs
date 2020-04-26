
namespace Torappu
{
    public class PlayerCharacter
    {
        public int instId { get; set; }

        public string charId { get; set; }

        public int level { get; set; }

        public int exp { get; set; }

        public EvolvePhase evolvePhase { get; set; }

        public int potentialRank { get; set; }

        public int defaultSkillIndex { get; set; }

        public int favorPoint { get; set; }

        public int mainSkillLvl { get; set; }

        public long gainTime { get; set; }

        public string skin { get; set; }

        public PlayerCharSkill[] skills { get; set; }

        public PlayerCharacter()
        {
        }

        public int GetFinalSkillLvl(int skillIndex)
        {
            return default(int);
        }
    }
}
