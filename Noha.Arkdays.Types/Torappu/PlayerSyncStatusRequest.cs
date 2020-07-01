using System.Collections.Generic;

namespace Torappu
{
	public class PlayerSyncStatusRequest
	{
		public long modules;

		public Dictionary<long, PlayerSyncParam> paramDict;

		public PlayerSyncStatusRequest()
		{
		}
	}
}
