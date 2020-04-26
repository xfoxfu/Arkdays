using System.Collections.Generic;

namespace Torappu
{
    public class PlayerTroop
    {
        public int troopCapacity { get; set; }

        public int curSquadCount { get; set; }

        public int curCharInstCount { get; set; }

        public Dictionary<string, PlayerSquad> squads { get; set; }

        public Dictionary<string, PlayerCharacter> chars { get; set; }

        public PlayerTroop()
        {
        }
    }
}
