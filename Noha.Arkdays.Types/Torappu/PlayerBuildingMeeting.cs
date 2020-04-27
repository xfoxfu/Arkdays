using System;
using System.Collections.Generic;

namespace Torappu
{
    public class PlayerBuildingMeeting
    {
        public List<string> visitedUser { get; set; }

        public PlayerBuildingMeetingBuff buff { get; set; }

        public int state { get; set; }

        public int processPoint { get; set; }

        public float speed { get; set; }

        public List<PlayerBuildingMeetingClue> ownStock { get; set; }

        public List<PlayerBuildingMeetingClue> receiveStock { get; set; }

        public Dictionary<string, string> board { get; set; }

        public PlayerBuildingMeetingSocialReward socialReward { get; set; }

        public int received { get; set; }

        public PlayerBuildingMeetingInfoShareState infoShare { get; set; }

        [System.Text.Json.Serialization.JsonConverter(typeof(Noha.Arkdays.Types.JsonDateNumberConverter))]
        public DateTime lastUpdateTime { get; set; }

        public PlayerBuildingMeetingClue dailyReward { get; set; }

        public PlayerBuildingMeeting()
        {
        }
    }
}
