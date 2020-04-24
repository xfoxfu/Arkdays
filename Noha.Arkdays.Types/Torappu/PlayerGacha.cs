using System.Collections.Generic;

namespace Torappu
{
	public class PlayerGacha
	{
		public class PlayerNewbeeGachaPool
		{
			public bool openFlag;

			public int cnt;

			public PlayerNewbeeGachaPool()
			{
			}
		}

		public class PlayerGachaPool
		{
			public int cnt;

			public int maxCnt;

			public bool avail;

			public PlayerGachaPool()
			{
			}
		}

		public class PlayerFreeLimitGacha
		{
			public int leastFree;

			public PlayerFreeLimitGacha()
			{
			}
		}

		public PlayerNewbeeGachaPool newbee;

		public Dictionary<string, PlayerGachaPool> normal;

		public Dictionary<string, PlayerFreeLimitGacha> limit;

		public PlayerGacha()
		{
		}
	}
}
