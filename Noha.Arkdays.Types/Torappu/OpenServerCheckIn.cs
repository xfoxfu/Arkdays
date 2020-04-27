using System.Collections.Generic;

namespace Torappu
{
    public class OpenServerCheckIn
    {
        public bool isAvailable { get; set; }

        /// <summary>
        /// Actually is `List<bool>`
        /// </summary>
        public List<int> history { get; set; }
    }
}
