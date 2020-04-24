using System.Collections.Generic;

namespace Torappu
{
	public class PlayerCrisisPermanent
	{
		public enum RuneStatusMask
		{
			UNLOCK = 1,
			COMPLETE
		}

		public Dictionary<string, int> rune;

		public PlayerCrisisChallenge challenge;

		public int point;

		public long nextSyncTs;

		public PlayerCrisisPermanent()
		{
		}
	}
}
