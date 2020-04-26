
namespace Torappu
{
    public class PlayerCrisisSeason
    {
        public int coin { get; set; }

        public int tCoin { get; set; }

        public PlayerCrisisPermanent permanent { get; set; }

        public PlayerCrisisTemporary temporary { get; set; }

        public PlayerCrisisSocialInfo sInfo { get; set; }

        public PlayerCrisisSeason()
        {
        }
    }
}
