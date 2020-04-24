using System.Collections.Generic;

namespace Torappu
{
	public class PlayerTroop
	{
		public int troopCapacity;

		public int curSquadCount;

		public int curCharInstCount;

		public Dictionary<string, PlayerSquad> squads;

		public Dictionary<string, PlayerCharacter> chars;

		public PlayerTroop()
		{
		}
	}
}
