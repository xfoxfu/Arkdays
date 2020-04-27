using System;
using System.Collections.Generic;

namespace Torappu
{
    public class StageData
    {
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public enum PerformanceStageFlag
        {
            NORMAL_STAGE,
            PERFORMANCE_STAGE
        }

        public class DisplayRewards
        {
            public ItemType type { get; set; }

            public string id { get; set; }

            public StageDropType dropType { get; set; }

            public DisplayRewards()
            {
            }
        }

        public class DisplayDetailRewards : DisplayRewards
        {
            public OccPer occPercent { get; set; }

            public float GetPercent { get; set; }

            public float CannotGetPercent { get; set; }

            public DisplayDetailRewards()
            {
            }
        }

        public class StageDropInfo
        {
            public ItemBundle[] firstPassRewards { get; set; }

            public ItemBundle[] firstCompleteRewards { get; set; }

            public WeightItemBundle[][] passRewards { get; set; }

            public WeightItemBundle[][] completeRewards { get; set; }

            public List<DisplayRewards> displayRewards { get; set; }

            public List<DisplayDetailRewards> displayDetailRewards { get; set; }

            public StageDropInfo()
            {
            }
        }

        public struct ConditionDesc
        {
            public string stageId { get; set; }

            public PlayerBattleRank completeState { get; set; }
        }

        public StageType stageType { get; set; }

        public LevelData.Difficulty difficulty { get; set; }

        public PerformanceStageFlag performanceStageFlag { get; set; }

        public List<ConditionDesc> unlockCondition { get; set; }

        public string stageId { get; set; }

        public string levelId { get; set; }

        public string zoneId { get; set; }

        public string code { get; set; }

        public string name { get; set; }

        public string description { get; set; }

        public string hardStagedId { get; set; }

        public string dangerLevel { get; set; }

        public float dangerPoint { get; set; }

        public string loadingPicId { get; set; }

        public bool canPractice { get; set; }

        public bool canBattleReplay { get; set; }

        public int apCost { get; set; }

        public int apFailReturn { get; set; }

        public string etItemId { get; set; }

        public int etCost { get; set; }

        public int etFailReturn { get; set; }

        public string etButtonStyle { get; set; }

        public int apProtectTimes { get; set; }

        public int diamondOnceDrop { get; set; }

        public int practiceTicketCost { get; set; }

        public int dailyStageDifficulty { get; set; }

        public int expGain { get; set; }

        public int goldGain { get; set; }

        public int loseExpGain { get; set; }

        public int loseGoldGain { get; set; }

        public int passFavor { get; set; }

        public int completeFavor { get; set; }

        public int slProgress { get; set; }

        public string displayMainItem { get; set; }

        public bool hilightMark { get; set; }

        public bool bossMark { get; set; }

        public bool isPredefined { get; set; }

        public bool isStoryOnly { get; set; }

        public AppearanceStyle appearanceStyle { get; set; }

        public StageDropInfo stageDropInfo { get; set; }

        public bool isStagePatch { get; set; }

        public string mainStageId { get; set; }
    }
}
