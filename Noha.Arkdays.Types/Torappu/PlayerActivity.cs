using System.Collections.Generic;

namespace Torappu
{
    public class PlayerActivity
    {
        public class PlayerDefaultActivity
        {
            public int coin { get; set; }

            public Dictionary<string, int> shop { get; set; }

        }

        public class PlayerMissionOnlyTypeActivity
        {
        }

        public class PlayerCheckinOnlyTypeActivity
        {
            public List<int> history { get; set; }

        }

        public class PlayerCollectionTypeActivity
        {
            public class PlayerCollectionInfo
            {
                public string ts { get; set; }

            }

            public Dictionary<string, int> point { get; set; }

            public Dictionary<string, PlayerCollectionInfo> history { get; set; }

        }

        public class PlayerAVGOnlyTypeActivity
        {
            public bool isOpen { get; set; }

        }

        public class PlayerLoginOnlyTypeActivity
        {
            public int reward { get; set; }

        }

        public class PlayerAct3D0Activity
        {
            public class BoxState
            {
                public Dictionary<string, int> content { get; set; }

            }

            public class MileStone
            {
                public int point { get; set; }

                public Dictionary<string, int> rewards { get; set; }

            }

            public string faction { get; set; }

            public int gachaCoin { get; set; }

            public int ticket { get; set; }

            public Dictionary<string, int> clue { get; set; }

            public Dictionary<string, BoxState> box { get; set; }

            public MileStone milestone { get; set; }

        }

        public class PlayerAct4D0Activity
        {
            public class MileStone
            {
                public int point { get; set; }

                public Dictionary<string, int> rewards { get; set; }

            }

            public Dictionary<string, int> story { get; set; }

            public MileStone milestone { get; set; }

        }

        public class PlayerAct5D0Activity
        {
            public MileStonePlayerInfo milestone { get; set; }

        }

        public class PlayerAct5D1Activity
        {
            public class PlayerAct5D1Shop
            {
                public class ProgressInfo
                {
                    public int count { get; set; }

                    public int order { get; set; }

                }

                public Dictionary<string, int> info { get; set; }

                public Dictionary<string, ProgressInfo> progressInfo { get; set; }

            }

            public class PlayerActRuneStage
            {
                public string schedule { get; set; }

                public int available { get; set; }

                public int scores { get; set; }

                public Dictionary<string, int> rune { get; set; }

            }

            public int coin { get; set; }

            public int pt { get; set; }

            public PlayerAct5D1Shop shop { get; set; }

            public Dictionary<string, PlayerActRuneStage> runeStage { get; set; }

            public Dictionary<string, List<string>> stageEnemy { get; set; }

        }

        public class PlayerAct9D0Activity
        {
            public int coin { get; set; }

            public List<string> favorList { get; set; }

        }

        public Dictionary<string, PlayerDefaultActivity> defaultActivityList { get; set; }

        public Dictionary<string, PlayerMissionOnlyTypeActivity> missionOnlyActivityList { get; set; }

        public Dictionary<string, PlayerCheckinOnlyTypeActivity> checkinOnlyActivityList { get; set; }

        public Dictionary<string, PlayerCollectionTypeActivity> collectionActivityList { get; set; }

        public Dictionary<string, PlayerAVGOnlyTypeActivity> avgOnlyActivityList { get; set; }

        public Dictionary<string, PlayerLoginOnlyTypeActivity> loginOnlyActivityList { get; set; }

        public Dictionary<string, PlayerAct3D0Activity> act3D0ActivityList { get; set; }

        public Dictionary<string, PlayerAct4D0Activity> act4D0ActivityList { get; set; }

        public Dictionary<string, PlayerAct5D0Activity> act5D0ActivityList { get; set; }

        public Dictionary<string, PlayerAct5D1Activity> act5D1ActivityList { get; set; }

        public Dictionary<string, PlayerAct9D0Activity> act9D0ActivityList { get; set; }

    }
}
