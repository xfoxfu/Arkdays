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
                    public int tagId;

                    public bool pick;

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

                public State state;

                public int[] tags;

                public TagItem[] selectTags;

                public DateTime startTs;

                public DateTime maxFinishTs;

                public DateTime realFinishTs;

                public int durationInSec;

                public SlotModel()
                {
                }
            }

            public Dictionary<string, SlotModel> slots;

            public NormalModel()
            {
            }
        }

        public NormalModel normal;

        public PlayerRecruit()
        {
        }
    }
}
