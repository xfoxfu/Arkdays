using System;
using System.Reflection;
namespace Torappu
{
    public class AttributesData
    {
        public int maxHp { get; set; }
        public int atk { get; set; }
        public int def { get; set; }
        public float magicResistance { get; set; }
        public int cost { get; set; }
        public int blockCnt { get; set; }
        public float moveSpeed { get; set; }
        public float attackSpeed { get; set; }
        public float baseAttackTime { get; set; }
        public int respawnTime { get; set; }
        public float hpRecoveryPerSec { get; set; }
        public float spRecoveryPerSec { get; set; }
        public int maxDeployCount { get; set; }
        public int maxDeckStackCnt { get; set; }
        public int tauntLevel { get; set; }
        public int massLevel { get; set; }
        public int baseForceLevel { get; set; }
        private int abilityRangeForwardExtend { get; set; }
        private float defPenetrate { get; set; }
        private float magicResistPenetrate { get; set; }
        private float hpRecoveryPerSecByMaxHpRatio { get; set; }
        private float defPenetrateFixed { get; set; }
        private float oneMinusStatusResistance { get; set; }
        public bool stunImmune { get; set; }
        public bool silenceImmune { get; set; }
        public bool sleepImmune { get; set; }
    }
}
