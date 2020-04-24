using System.Collections.Generic;

namespace Torappu
{
	public class MissionPlayerData
	{
		public enum MissionGroupState
		{
			Uncomplete,
			Complete
		}

		public MissionPlayerDataGroup missions;

		public MissionDailyRewards missionRewards;

		public Dictionary<string, MissionGroupState> missionGroups;

		public MissionPlayerData()
		{
		}
	}
}
