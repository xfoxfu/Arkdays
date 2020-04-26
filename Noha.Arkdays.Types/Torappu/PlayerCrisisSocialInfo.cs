using System.Collections.Generic;

namespace Torappu
{
    public class PlayerCrisisSocialInfo
    {
        public class AssistChar
        {
            public string charId { get; set; }

            public int cnt { get; set; }

            public AssistChar()
            {
            }
        }

        public int assistCnt { get; set; }

        public int maxPnt { get; set; }

        public List<AssistChar> chars { get; set; }

        public PlayerCrisisSocialInfo()
        {
        }
    }
}
