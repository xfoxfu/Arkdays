using System.Collections.Generic;

namespace Torappu
{
    public class OpenServerChainLogin
    {
        public bool isAvailable { get; set; }

        public int nowIndex { get; set; }

        public List<bool> history { get; set; }
    }
}
