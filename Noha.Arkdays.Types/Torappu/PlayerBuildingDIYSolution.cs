using System.Collections.Generic;

namespace Torappu
{
    public class PlayerBuildingDIYSolution
    {
        public string wallPaper { get; set; }

        public string floor { get; set; }

        public List<PlayerBuildingFurniturePositionInfo> carpet { get; set; }

        public List<PlayerBuildingFurniturePositionInfo> other { get; set; }
    }
}
