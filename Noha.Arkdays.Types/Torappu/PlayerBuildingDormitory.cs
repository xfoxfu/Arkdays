
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
                    public string target { get; set; }

                    public int value { get; set; }
                }

                public int all { get; set; }

                public SingleTarget single { get; set; }
            }

            public APCost apCost { get; set; }
        }

        public Buff buff { get; set; }

        public int comfort { get; set; }

        public PlayerBuildingDIYSolution diySolution { get; set; }
    }
}
