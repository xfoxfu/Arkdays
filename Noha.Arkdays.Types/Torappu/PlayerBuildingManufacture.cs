using System;

namespace Torappu
{
	public class PlayerBuildingManufacture
	{
		public PlayerBuildingManufactureBuff buff;

		public PlayerRoomState state;

		public string formulaId;

		public int remainSolutionCnt;

		public int outputSolutionCnt;

		public DateTime lastUpdateTime;

		public double processPoint;

		public long saveTime;

		public DateTime completeWorkTime;

		public int capacity;

		public int apCost;

		public PlayerBuildingManufacture()
		{
		}
	}
}
