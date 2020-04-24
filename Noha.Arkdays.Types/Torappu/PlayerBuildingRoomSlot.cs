using System;

namespace Torappu
{
	public class PlayerBuildingRoomSlot
	{
		public int level;

		public PlayerRoomSlotState state;

		public BuildingData.RoomType roomId;

		public int[] charInstIds;

		public DateTime completeConstructTime;

		public PlayerBuildingRoomSlot()
		{
		}
	}
}
