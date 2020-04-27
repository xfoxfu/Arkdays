using System;

namespace Torappu
{
    public class PlayerCharSkill
    {
        [System.Text.Json.Serialization.JsonConverter(typeof(Noha.Arkdays.Types.JsonBoolNumberConverter))]
        public bool unlock { get; set; }

        public string skillId { get; set; }

        public int specializeLevel { get; set; }

        public PlayerCharSkill()
        {
        }
    }
}
