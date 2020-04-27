using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Torappu
{
    public abstract class CommonStartBattleRequest
    {
        public class SquadSlotModel
        {
            public int charInstId { get; set; }

            public int skillIndex { get; set; }

            public SquadSlotModel()
            {
            }
        }

        public class SquadModel
        {
            public string squadId { get; set; }

            public string name { get; set; }

            public List<SquadSlotModel> slots { get; set; }

            public SquadModel()
            {
            }
        }

        [JsonConverter(typeof(Noha.Arkdays.Types.JsonBoolNumberConverter))]
        public bool usePracticeTicket { get; set; }

        public string stageId { get; set; }

        public SquadModel squad { get; set; }

        public SquadFriendData? assistFriend;

        [JsonConverter(typeof(Noha.Arkdays.Types.JsonBoolNumberConverter))]
        public bool isReplay { get; set; }

        public long startTs { get; set; }

        protected CommonStartBattleRequest()
        {
        }
    }
}
