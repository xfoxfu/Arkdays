using System;
using System.Collections.Generic;

namespace Torappu
{
    public class PlayerStatus
    {
        public string nickName { get; set; }

        public string nickNumber { get; set; }

        public string serverName { get; set; }

        public int ap { get; set; }

        [System.Text.Json.Serialization.JsonConverter(typeof(Noha.Arkdays.Types.JsonDateNumberConverter))]
        public DateTime lastApAddTime { get; set; }

        [System.Text.Json.Serialization.JsonConverter(typeof(Noha.Arkdays.Types.JsonDateNumberConverter))]
        public DateTime lastRefreshTs { get; set; }

        public int level { get; set; }

        public int exp { get; set; }

        public int maxAp { get; set; }

        public int practiceTicket { get; set; }

        public long gold { get; set; }

        public int diamondShard { get; set; }

        public int recruitLicense { get; set; }

        public int gachaTicket { get; set; }

        public int tenGachaTicket { get; set; }

        public int instantFinishTicket { get; set; }

        public int hggShard { get; set; }

        public int lggShard { get; set; }

        public int socialPoint { get; set; }

        public int buyApRemainTimes { get; set; }

        [System.Text.Json.Serialization.JsonConverter(typeof(Noha.Arkdays.Types.JsonBoolNumberConverter))]
        public bool apLimitUpFlag { get; set; }

        public long registerTs { get; set; }

        public string secretary { get; set; }

        public string secretarySkinId { get; set; }

        public string resume { get; set; }

        [System.Text.Json.Serialization.JsonConverter(typeof(Noha.Arkdays.Types.JsonDateNumberConverter))]
        public DateTime monthlySubscriptionEndTime { get; set; }

        [System.Text.Json.Serialization.JsonConverter(typeof(Noha.Arkdays.Types.JsonDateNumberConverter))]
        public DateTime monthlySubscriptionStartTime { get; set; }

        public int progress { get; set; }

        public string mainStageProgress { get; set; }

        public int iosDiamond { get; set; }

        public int androidDiamond { get; set; }

        public int payDiamond { get; set; }

        public int freeDiamond { get; set; }

        /// <summary>
        /// Actually is `Dictionary<string, bool>`
        /// </summary>
        public Dictionary<string, int> flags { get; set; }

        public List<PlayerFriendAssist> friendAssist { get; set; }

        public int diamond
        {
            get
            {
                return default(int);
            }
        }

        public PlayerStatus()
        {
        }
    }
}
