
using System.Collections.Generic;

namespace Torappu
{
    public class PlayerBuildingRoom
    {
        public Dictionary<string, PlayerBuildingManufacture> manufact { get; set; }

        public Dictionary<string, PlayerBuildingShop> shop { get; set; }

        public Dictionary<string, PlayerBuildingPower> power { get; set; }

        public Dictionary<string, PlayerBuildingControl> control { get; set; }

        public Dictionary<string, PlayerBuildingMeeting> meeting { get; set; }

        public Dictionary<string, PlayerBuildingHire> hire { get; set; }

        public Dictionary<string, PlayerBuildingDormitory> dorm { get; set; }

        public Dictionary<string, PlayerBuildingTraining> training { get; set; }

        public Dictionary<string, PlayerBuildingWorkshop> workshop { get; set; }

        public Dictionary<string, PlayerBuildingTrading> trading { get; set; }

        public PlayerBuildingRoom()
        {
        }
    }
}
