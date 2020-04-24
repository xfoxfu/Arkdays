
namespace Torappu
{
	public class PlayerCharacter
	{
		public int instId;

		public string charId;

		public int level;

		public int exp;

		public EvolvePhase evolvePhase;

		public int potentialRank;

		public int defaultSkillIndex;

		public int favorPoint;

		public int mainSkillLvl;

		public long gainTime;

		public string skin;

		public PlayerCharSkill[] skills;

		public PlayerCharacter()
		{
		}

		public int GetFinalSkillLvl(int skillIndex)
		{
			return default(int);
		}
	}
}
