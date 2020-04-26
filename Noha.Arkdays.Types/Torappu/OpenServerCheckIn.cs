using System.Collections.Generic;

namespace Torappu
{
    public class OpenServerCheckIn
    {
        public bool isAvailable { get; set; }

        public List<bool> history { get; set; }
    }
}
