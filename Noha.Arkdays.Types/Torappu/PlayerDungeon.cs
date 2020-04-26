using System.Collections.Generic;

namespace Torappu
{
    public class PlayerDungeon
    {
        public Dictionary<string, PlayerStage> stages { get; set; }

        public Dictionary<string, PlayerZone> zones { get; set; }

        public PlayerCampaign campaigns { get; set; }

        public PlayerDungeon()
        {
        }
    }
}
