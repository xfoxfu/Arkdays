
namespace Torappu
{
    public class PlayerSquad
    {
        [System.Text.Json.Serialization.JsonConverter(typeof(Noha.Arkdays.Types.JsonNumberStringConverter))]
        public int squadId { get; set; }

        public string name { get; set; }

        public PlayerSquadItem[] slots { get; set; }

        public PlayerSquad()
        {
        }
    }
}
