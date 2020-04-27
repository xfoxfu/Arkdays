
namespace Torappu
{
    public class SquadFormationRequest
    {
        public class SquadSlot
        {
            public int charInstId { get; set; }

            public int skillIndex { get; set; }

            public SquadSlot()
            {
            }
        }

        public string squadId { get; set; }

        public SquadSlot[] slots { get; set; }

        [System.Text.Json.Serialization.JsonConverter(typeof(Noha.Arkdays.Types.JsonBoolNumberConverter))]
        public bool changeSkill { get; set; }

        public SquadFormationRequest()
        {
        }
    }
}
