
namespace Torappu
{
    public class PlayerSocialReward
    {
        [System.Text.Json.Serialization.JsonConverter(typeof(Noha.Arkdays.Types.JsonBoolNumberConverter))]
        public bool canReceive { get; set; }

        public int first { get; set; }

        public int assistAmount { get; set; }

        public int comfortAmount { get; set; }

        public PlayerSocialReward()
        {
        }
    }
}
