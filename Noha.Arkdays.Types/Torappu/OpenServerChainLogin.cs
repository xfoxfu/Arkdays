using System.Collections.Generic;

namespace Torappu
{
    public class OpenServerChainLogin
    {
        public bool isAvailable { get; set; }

        public int nowIndex { get; set; }

        /// <summary>
        /// Actually is `List<bool>`
        /// </summary>
        public List<int> history { get; set; }
    }
}
