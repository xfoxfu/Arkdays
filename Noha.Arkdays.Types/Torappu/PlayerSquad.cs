
namespace Torappu
{
    public class PlayerSquad
    {
        public int squadId { get; set; }

        public string name { get; set; }

        public PlayerSquadItem[] slots { get; set; }

        public PlayerSquad()
        {
        }
    }
}
