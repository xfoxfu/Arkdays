using System.Collections.Generic;

namespace Torappu
{
	public class PlayerCrisisTraining
	{
		public List<string> currentStage;

		public Dictionary<string, PlayerCrisisTrainingStage> stage;

		public long nextSyncTs;

		public PlayerCrisisTraining()
		{
		}
	}
}
