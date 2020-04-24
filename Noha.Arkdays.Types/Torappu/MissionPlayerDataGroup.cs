using System.Collections.Generic;

namespace Torappu
{
    public class MissionPlayerDataGroup : Dictionary<string, Dictionary<string, MissionPlayerState>>
    {
        public class MissionTypeString
        {
            public const string DAILY = "DAILY";

            public const string WEEKLY = "WEEKLY";

            public const string ACTIVITY = "ACTIVITY";

            public const string MAIN = "MAIN";

            public const string SUB = "SUB";

            public const string GUIDE = "GUIDE";

            public const string OPENSERVER = "OPENSERVER";
        }
    }
}
