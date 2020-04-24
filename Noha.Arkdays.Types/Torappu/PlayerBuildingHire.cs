using System;

namespace Torappu
{
	public class PlayerBuildingHire
	{
		public PlayerBuildingHireBuff buff;

		public int recruitSlotId;

		public PlayerBuildingHiringState state;

		public double processPoint;

		public float speed;

		public DateTime lastUpdateTime;

		public int refreshCount;

		public DateTime completeWorkTime;

		public PlayerBuildingHire()
		{
		}
	}
}
