using System.Collections.Generic;

namespace Torappu
{
	public class PlayerCrisisChallenge
	{
		public class PlayerChallengeTask
		{
			public long fts;

			public long rts;

			public PlayerChallengeTask()
			{
			}
		}

		public Dictionary<int, long> pointList;

		public Dictionary<string, PlayerChallengeTask> taskList;

		public int topPoint;

		public PlayerCrisisChallenge()
		{
		}
	}
}
