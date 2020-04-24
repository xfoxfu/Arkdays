using System;
using System.Collections.Generic;

namespace Torappu
{
	public class PlayerBuildingMeeting
	{
		public List<string> visitedUser;

		public PlayerBuildingMeetingBuff buff;

		public int state;

		public int processPoint;

		public float speed;

		public List<PlayerBuildingMeetingClue> ownStock;

		public List<PlayerBuildingMeetingClue> receiveStock;

		public Dictionary<string, string> board;

		public PlayerBuildingMeetingSocialReward socialReward;

		public int received;

		public PlayerBuildingMeetingInfoShareState infoShare;

		public DateTime lastUpdateTime;

		public PlayerBuildingMeetingClue dailyReward;

		public PlayerBuildingMeeting()
		{
		}
	}
}
