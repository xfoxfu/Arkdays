using System.Collections.Generic;

namespace Torappu
{
    public class PlayerBuilding
    {
        public PlayerBuildingStatus status { get; set; }

        public Dictionary<string, PlayerBuildingChar> chars { get; set; }

        public List<int> assist { get; set; }

        public Dictionary<string, PlayerBuildingRoomSlot> roomSlots { get; set; }

        public PlayerBuildingRoom rooms { get; set; }

        public Dictionary<string, PlayerBuildingFurnitureInfo> furniture { get; set; }

        public Dictionary<string, PlayerBuildingDIYPreset> diyPresetSolutions { get; set; }
    }
}
