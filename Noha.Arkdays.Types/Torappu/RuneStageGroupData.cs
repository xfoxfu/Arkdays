using System;
using System.Collections.Generic;

namespace Torappu
{
    public class RuneStageGroupData
    {
        public class RuneStageInst
        {
            public string stageId { get; set; }

            public string[] activePackedRuneIds { get; set; }

            public RuneStageInst()
            {
            }
        }

        public string groupId { get; set; }

        public List<RuneStageInst> activeRuneStages { get; set; }

        public long startTs { get; set; }

        public long endTs { get; set; }

        public RuneStageGroupData()
        {
        }
    }
}
