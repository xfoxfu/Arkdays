using System;
using System.Collections.Generic;

namespace Torappu
{
	public class PlayerBuildingTrading
	{
		public PlayerBuildingTradingBuff buff;

		public PlayerRoomState state;

		public DateTime lastUpdateTime;

		public BuildingData.OrderType strategy;

		public int stockLimit;

		public int apCost;

		public List<PlayerBuildingTradingOrder> stock;

		public PlayerBuildingTradingNext next;

		public PlayerBuildingTrading()
		{
		}
	}
}
