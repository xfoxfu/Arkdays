using System;
using System.Collections.Generic;
namespace Torappu
{
    public class AttributeModifierData
    {
        public class AttributeModifier
        {
            public enum FormulaItemType
            {
                ADDITION,
                MULTIPLIER,
                FINAL_ADDITION,
                FINAL_SCALER
            }
            public AttributeType attributeType { get; set; }
            public FormulaItemType formulaItem { get; set; }
            public float value { get; set; }
            public bool loadFromBlackboard { get; set; }
            public bool fetchBaseValueFromSourceEntity { get; set; }

        }
        public List<AbnormalFlag> abnormalFlags { get; set; }
        public List<AbnormalFlag> abnormalImmunes { get; set; }
        public List<AbnormalCombo> abnormalCombos { get; set; }
        public List<AbnormalCombo> abnormalComboImmunes { get; set; }
        public AttributeModifier[] attributeModifiers { get; set; }
    }
}
