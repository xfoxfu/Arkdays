using System;
using System.Collections.Generic;

namespace Torappu
{
	public class PlayerStatus
	{
		public string nickName;

		public string nickNumber;

		public string serverName;

		public int ap;

		public DateTime lastApAddTime;

		public DateTime lastRefreshTs;

		public int level;

		public int exp;

		public int maxAp;

		public int practiceTicket;

		public long gold;

		public int diamondShard;

		public int recruitLicense;

		public int gachaTicket;

		public int tenGachaTicket;

		public int instantFinishTicket;

		public int hggShard;

		public int lggShard;

		public int socialPoint;

		public int buyApRemainTimes;

		public bool apLimitUpFlag;

		public long registerTs;

		public string secretary;

		public string secretarySkinId;

		public string resume;

		public DateTime monthlySubscriptionEndTime;

		public DateTime monthlySubscriptionStartTime;

		public int progress;

		public string mainStageProgress;

		public int iosDiamond;

		public int androidDiamond;

		public int payDiamond;

		public int freeDiamond;

		public Dictionary<string, bool> flags;

		public List<PlayerFriendAssist> friendAssist;

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
