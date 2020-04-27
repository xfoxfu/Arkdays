using System;

namespace Torappu
{
    public class ZoneData
    {
        public string zoneID { get; set; }

        public int zoneIndex { get; set; }

        public ZoneType type { get; set; }

        public string zoneNameFirst { get; set; }

        public string zoneNameSecond { get; set; }

        public string zoneNameTitleCurrent { get; set; }

        public string zoneNameTitleUnCurrent { get; set; }

        public string zoneNameTitleEx { get; set; }

        public string zoneNameThird { get; set; }

        public string lockedText { get; set; }

        public bool canPreview { get; set; }

        public ZoneData()
        {
        }
    }
}
