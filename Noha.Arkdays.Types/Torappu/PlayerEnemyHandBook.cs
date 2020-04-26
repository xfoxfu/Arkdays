using System.Collections.Generic;

namespace Torappu
{
    public class PlayerEnemyHandBook
    {
        public Dictionary<string, int> enemies { get; set; }

        public Dictionary<string, List<string>> stage { get; set; }

        public PlayerEnemyHandBook()
        {
        }
    }
}
