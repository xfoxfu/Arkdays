using System.Collections.Generic;

namespace Torappu
{
    public class PlayerBuilding
    {
        public PlayerBuildingStatus status;

        public Dictionary<string, PlayerBuildingChar> chars;

        public List<int> assist;

        public Dictionary<string, PlayerBuildingRoomSlot> roomSlots;

        public PlayerBuildingRoom rooms;

        public Dictionary<string, PlayerBuildingFurnitureInfo> furniture;

        public Dictionary<string, PlayerBuildingDIYPreset> diyPresetSolutions;
    }
}
