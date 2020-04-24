using System.Collections.Generic;

namespace Torappu
{
    public class PlayerActivity
    {
        public class PlayerDefaultActivity
        {
            public int coin;

            public Dictionary<string, int> shop;

            public PlayerDefaultActivity()
            {
            }
        }

        public class PlayerMissionOnlyTypeActivity
        {
            public PlayerMissionOnlyTypeActivity()
            {
            }
        }

        public class PlayerCheckinOnlyTypeActivity
        {
            public List<int> history;

            public PlayerCheckinOnlyTypeActivity()
            {
            }
        }

        public class PlayerCollectionTypeActivity
        {
            public class PlayerCollectionInfo
            {
                public string ts;

                public PlayerCollectionInfo()
                {
                }
            }

            public Dictionary<string, int> point;

            public Dictionary<string, PlayerCollectionInfo> history;

            public PlayerCollectionTypeActivity()
            {
            }
        }

        public class PlayerAVGOnlyTypeActivity
        {
            public bool isOpen;

            public PlayerAVGOnlyTypeActivity()
            {
            }
        }

        public class PlayerLoginOnlyTypeActivity
        {
            public int reward;

            public PlayerLoginOnlyTypeActivity()
            {
            }
        }

        public class PlayerAct3D0Activity
        {
            public class BoxState
            {
                public Dictionary<string, int> content;

                public BoxState()
                {
                }
            }

            public class MileStone
            {
                public int point;

                public Dictionary<string, int> rewards;

                public MileStone()
                {
                }
            }

            public string faction;

            public int gachaCoin;

            public int ticket;

            public Dictionary<string, int> clue;

            public Dictionary<string, BoxState> box;

            public MileStone milestone;

            public PlayerAct3D0Activity()
            {
            }
        }

        public class PlayerAct4D0Activity
        {
            public class MileStone
            {
                public int point;

                public Dictionary<string, int> rewards;

                public MileStone()
                {
                }
            }

            public Dictionary<string, int> story;

            public MileStone milestone;

            public PlayerAct4D0Activity()
            {
            }
        }

        public class PlayerAct5D0Activity
        {
            public MileStonePlayerInfo milestone;

            public PlayerAct5D0Activity()
            {
            }
        }

        public class PlayerAct5D1Activity
        {
            public class PlayerAct5D1Shop
            {
                public class ProgressInfo
                {
                    public int count;

                    public int order;

                    public ProgressInfo()
                    {
                    }
                }

                public Dictionary<string, int> info;

                public Dictionary<string, ProgressInfo> progressInfo;

                public PlayerAct5D1Shop()
                {
                }
            }

            public class PlayerActRuneStage
            {
                public string schedule;

                public int available;

                public int scores;

                public Dictionary<string, int> rune;

                public PlayerActRuneStage()
                {
                }
            }

            public int coin;

            public int pt;

            public PlayerAct5D1Shop shop;

            public Dictionary<string, PlayerActRuneStage> runeStage;

            public Dictionary<string, List<string>> stageEnemy;

            public PlayerAct5D1Activity()
            {
            }
        }

        public class PlayerAct9D0Activity
        {
            public int coin;

            public List<string> favorList;

            public PlayerAct9D0Activity()
            {
            }
        }

        public Dictionary<string, PlayerDefaultActivity> defaultActivityList;

        public Dictionary<string, PlayerMissionOnlyTypeActivity> missionOnlyActivityList;

        public Dictionary<string, PlayerCheckinOnlyTypeActivity> checkinOnlyActivityList;

        public Dictionary<string, PlayerCollectionTypeActivity> collectionActivityList;

        public Dictionary<string, PlayerAVGOnlyTypeActivity> avgOnlyActivityList;

        public Dictionary<string, PlayerLoginOnlyTypeActivity> loginOnlyActivityList;

        public Dictionary<string, PlayerAct3D0Activity> act3D0ActivityList;

        public Dictionary<string, PlayerAct4D0Activity> act4D0ActivityList;

        public Dictionary<string, PlayerAct5D0Activity> act5D0ActivityList;

        public Dictionary<string, PlayerAct5D1Activity> act5D1ActivityList;

        public Dictionary<string, PlayerAct9D0Activity> act9D0ActivityList;

        public PlayerActivity()
        {
        }
    }
}
