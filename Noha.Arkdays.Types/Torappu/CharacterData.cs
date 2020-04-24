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
            public EvolvePhase phase;

            public int level;


        }

        public class TalentDataBundle
        {

            public TalentData[] candidates;








        }

        public class TraitData
        {
            public UnlockCondition unlockCondition;

            public int requiredPotentialRank;

            public Blackboard blackboard;

            public string overrideDescripton;

            public string prefabKey;

            public string rangeId;

        }

        public class TraitDataBundle
        {

            public TraitData[] candidates;




        }

        public class PhaseData
        {
            public string characterPrefabKey;

            public string rangeId;

            public int maxLevel;

            public AttributesKeyFrame attributesKeyFrames;

            public ItemBundle[] evolveCost;

        }

        public class MainSkill
        {
            public class SpecializeLevelData
            {
                public UnlockCondition unlockCond;

                public int lvlUpTime;

                public ItemBundle[] levelUpCost;

            }

            public string skillId;

            public string overridePrefabKey;

            public string overrideTokenKey;

            public SpecializeLevelData[] specializeLevelUpData;

            public UnlockCondition initialUnlockCond;


        }

        public class PotentialRank
        {
            public enum TypeEnum
            {
                BUFF,
                CUSTOM
            }

            public TypeEnum type;

            public string description;

            public ExternalBuff buff;

            public ItemBundle[] equivalentCost;

        }

        public class PotentialCost
        {
            public string itemId;

            public float percent;

        }

        public class SkillLevelCost
        {
            public UnlockCondition unlockCond;

            public ItemBundle[] lvlUpCost;

        }

        public string name;

        public string description;

        public bool canUseGeneralPotentialItem;

        public string potentialItemId;

        public int team;

        public string displayNumber;

        public string tokenKey;

        public string appellation;

        public BuildableType position;

        public string[] tagList;

        public string displayLogo;

        public string itemUsage;

        public string itemDesc;

        public string itemObtainApproach;

        public int maxPotentialLevel;

        public RarityRank rarity;

        public ProfessionCategory profession;

        public TraitDataBundle trait;

        public PhaseData[] phases;

        public MainSkill[] skills;

        public TalentDataBundle[] talents;

        public PotentialRank[] potentialRanks;

        public AttributesDeltaKeyFrame favorKeyFrames;

        public SkillLevelCost[] allSkillLvlup;


    }
}
