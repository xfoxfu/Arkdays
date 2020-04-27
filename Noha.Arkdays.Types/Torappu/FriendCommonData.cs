using System;

namespace Torappu
{
    public class FriendCommonData
    {
        public string nickName { get; set; }

        public string uid { get; set; }

        public string serverName { get; set; }

        public string nickNumber { get; set; }

        public int level { get; set; }

        public DateTime lastOnlineTime { get; set; }

        public bool recentVisited { get; set; }

        public FriendCommonData()
        {
        }
    }
}
