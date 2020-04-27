using System;
namespace Torappu
{
    public class CharacterData
    {
        public class AttributesKeyFrame : KeyFrames<AttributesData>
        {
        }
        public class AttributesDeltaKeyFrame : KeyFrames<AttributesDeltaData, AttributesData>
        {
        }
        public struct UnlockCondition
        {
            public EvolvePhase phase { get; set; }
            public int level { get; set; }
        }
        public class TalentDataBundle
        {
            public TalentData[] candidates { get; set; }
        }
        public class TraitData
        {
            public UnlockCondition unlockCondition { get; set; }
            public int requiredPotentialRank { get; set; }
            public Blackboard blackboard { get; set; }
            public string overrideDescripton { get; set; }
            public string prefabKey { get; set; }
            public string rangeId { get; set; }
        }
        public class TraitDataBundle
        {
            public TraitData[] candidates { get; set; }
        }
        public class PhaseData
        {
            public string characterPrefabKey { get; set; }
            public string rangeId { get; set; }
            public int maxLevel { get; set; }
            public AttributesKeyFrame attributesKeyFrames { get; set; }
            public ItemBundle[] evolveCost { get; set; }
        }
        public class MainSkill
        {
            public class SpecializeLevelData
            {
                public UnlockCondition unlockCond { get; set; }
                public int lvlUpTime { get; set; }
                public ItemBundle[] levelUpCost { get; set; }
            }
            public string skillId { get; set; }
            public string overridePrefabKey { get; set; }
            public string overrideTokenKey { get; set; }
            [System.Text.Json.Serialization.JsonPropertyName("levelUpCostCond")]
            public SpecializeLevelData[] specializeLevelUpData { get; set; }
            public UnlockCondition initialUnlockCond { get; set; }
        }
        public class PotentialRank
        {
            public enum TypeEnum
            {
                BUFF,
                CUSTOM
            }
            public TypeEnum type { get; set; }
            public string description { get; set; }
            public ExternalBuff buff { get; set; }
            public ItemBundle[] equivalentCost { get; set; }
        }
        public class PotentialCost
        {
            public string itemId { get; set; }
            public float percent { get; set; }
        }
        public class SkillLevelCost
        {
            public UnlockCondition unlockCond { get; set; }
            public ItemBundle[] lvlUpCost { get; set; }
        }
        public string name { get; set; }
        public string description { get; set; }
        public bool canUseGeneralPotentialItem { get; set; }
        public string potentialItemId { get; set; }
        public int team { get; set; }
        public string displayNumber { get; set; }
        public string tokenKey { get; set; }
        public string appellation { get; set; }
        public BuildableType position { get; set; }
        public string[] tagList { get; set; }
        public string displayLogo { get; set; }
        public string itemUsage { get; set; }
        public string itemDesc { get; set; }
        public string itemObtainApproach { get; set; }
        public int maxPotentialLevel { get; set; }
        public RarityRank rarity { get; set; }
        public ProfessionCategory profession { get; set; }
        public TraitDataBundle trait { get; set; }
        public PhaseData[] phases { get; set; }
        public MainSkill[] skills { get; set; }
        public TalentDataBundle[] talents { get; set; }
        public PotentialRank[] potentialRanks { get; set; }
        public AttributesDeltaKeyFrame favorKeyFrames { get; set; }
        public SkillLevelCost[] allSkillLvlup { get; set; }
    }
}
