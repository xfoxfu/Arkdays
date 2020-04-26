using System.Collections.Generic;

namespace Torappu
{
    public class PlayerBuildingMeetingClue
    {
        public string id { get; set; }

        public string type { get; set; }

        public int number { get; set; }

        public int uid { get; set; }

        public int nickNum { get; set; }

        public string name { get; set; }

        public List<PlayerBuildingMeetingClueChar> chars { get; set; }

        public int inUse { get; set; }

        public long ts { get; set; }

        public PlayerBuildingMeetingClue()
        {
        }
    }
}
