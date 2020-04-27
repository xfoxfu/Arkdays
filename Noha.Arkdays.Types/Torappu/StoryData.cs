using System;
using System.Text.RegularExpressions;

namespace Torappu
{
    public class StoryData
    {
        public struct Trigger
        {
            [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
            public enum TriggerType
            {
                GAME_START,
                BEFORE_BATTLE,
                AFTER_BATTLE,
                SWITCH_TO_SCENE,
                PAGE_LOADED,
                STORY_FINISH,
                CUSTOM_OPERATION,
                STORY_FINISH_OR_PAGE_LOADED,
                ACTIVITY_LOADED,
                ACTIVITY_ANNOUNCE,
                CRISIS_SEASON_LOADED,
                E_NUM
            }

            public const int TRIGGER_TYPE_NUM = 11;

            public TriggerType type { get; set; }

            public string key { get; set; }

            public bool useRegex { get; set; }
        }

        public class Condition
        {
            public class StageCondition
            {
                public string stageId { get; set; }

                public PlayerStageState minState { get; set; }

                public PlayerStageState maxState { get; set; }
            }

            public int minProgress { get; set; }

            public int maxProgress { get; set; }

            public int minPlayerLevel { get; set; }

            public string[] requiredFlags { get; set; }

            public string[] excludedFlags { get; set; }

            public StageCondition[] requiredStages { get; set; }
        }

        public string id { get; set; }

        public bool needCommit { get; set; }

        public bool repeatable { get; set; }

        public bool disabled { get; set; }

        public Trigger trigger { get; set; }

        public Condition condition { get; set; }

        public int setProgress { get; set; }

        public string[] setFlags { get; set; }

        public ItemBundle[] completedRewards { get; set; }

        public bool forceOmitCommit { get; set; }
    }
}
