using System.Collections.Generic;

namespace Torappu
{
	public class PlayerCrisis
	{
		public struct BoxItem
		{
			public string id;

			public ItemType type;

			public int count;
		}

		public string currentSeason;

		public Dictionary<string, PlayerCrisisMap> map;

		public PlayerCrisisShop shop;

		public PlayerCrisisTraining training;

		public Dictionary<string, PlayerCrisisSeason> season;

		public long lastSyncTs;

		public long nextSyncTs;

		public List<BoxItem> box;

		public PlayerCrisis()
		{
		}
	}
}
