using System;
using System.Reflection;

namespace Torappu
{
    public class AttributesData
    {
        public static readonly AttributesData ZERO;

        public int maxHp;

        public int atk;

        public int def;

        public float magicResistance;

        public int cost;

        public int blockCnt;

        public float moveSpeed;

        public float attackSpeed;

        public float baseAttackTime;

        public int respawnTime;

        public float hpRecoveryPerSec;

        public float spRecoveryPerSec;

        public int maxDeployCount;

        public int maxDeckStackCnt;

        public int tauntLevel;

        public int massLevel;

        public int baseForceLevel;

        private int abilityRangeForwardExtend;

        private float defPenetrate;

        private float magicResistPenetrate;

        private float hpRecoveryPerSecByMaxHpRatio;

        private float defPenetrateFixed;

        private float oneMinusStatusResistance;

        public bool stunImmune;

        public bool silenceImmune;

        public bool sleepImmune;
    }
}
