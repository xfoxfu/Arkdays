using System;
using System.Collections.Generic;

namespace Torappu
{
    public class PlayerRecruit
    {
        public class NormalModel
        {
            public class SlotModel
            {
                public class TagItem
                {
                    public int tagId { get; set; }

                    public bool pick { get; set; }

                    public TagItem()
                    {
                    }
                }

                public enum State
                {
                    LOCK,
                    IDLE,
                    BUSY,
                    FAST_FINISH
                }

                public State state { get; set; }

                public int[] tags { get; set; }

                public TagItem[] selectTags { get; set; }

                [System.Text.Json.Serialization.JsonConverter(typeof(Noha.Arkdays.Types.JsonDateNumberConverter))]
                public DateTime startTs { get; set; }

                [System.Text.Json.Serialization.JsonConverter(typeof(Noha.Arkdays.Types.JsonDateNumberConverter))]
                public DateTime maxFinishTs { get; set; }

                [System.Text.Json.Serialization.JsonConverter(typeof(Noha.Arkdays.Types.JsonDateNumberConverter))]
                public DateTime realFinishTs { get; set; }

                public int durationInSec { get; set; }

                public SlotModel()
                {
                }
            }

            public Dictionary<string, SlotModel> slots { get; set; }

            public NormalModel()
            {
            }
        }

        public NormalModel normal { get; set; }

        public PlayerRecruit()
        {
        }
    }
}
