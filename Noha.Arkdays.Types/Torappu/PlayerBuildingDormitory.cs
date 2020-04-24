
namespace Torappu
{
	public class PlayerBuildingDormitory
	{
		public class Buff
		{
			public class APCost
			{
				public class SingleTarget
				{
					public string target;

					public int value;

					public SingleTarget()
					{
					}
				}

				public int all;

				public SingleTarget single;

				public APCost()
				{
				}
			}

			public APCost apCost;

			public Buff()
			{
			}
		}

		public Buff buff;

		public int comfort;

		public PlayerBuildingDIYSolution diySolution;

		public PlayerBuildingDormitory()
		{
		}
	}
}
