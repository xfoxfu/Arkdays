
using System.Collections.Generic;

namespace Torappu
{
    public class PlayerBuildingRoom
    {
        public Dictionary<string, PlayerBuildingManufacture> manufact;

        public Dictionary<string, PlayerBuildingShop> shop;

        public Dictionary<string, PlayerBuildingPower> power;

        public Dictionary<string, PlayerBuildingControl> control;

        public Dictionary<string, PlayerBuildingMeeting> meeting;

        public Dictionary<string, PlayerBuildingHire> hire;

        public Dictionary<string, PlayerBuildingDormitory> dorm;

        public Dictionary<string, PlayerBuildingTraining> training;

        public Dictionary<string, PlayerBuildingWorkshop> workshop;

        public Dictionary<string, PlayerBuildingTrading> trading;

        public PlayerBuildingRoom()
        {
        }
    }
}
