using System.Collections.Generic;

namespace Torappu
{
    public class MissionPlayerState
    {
        public MissionHoldingState state { get; set; }

        public List<MissionCalcState> progress { get; set; }
    }
}
