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

			public AttributeType attributeType;

			public FormulaItemType formulaItem;

			public float value;

			public bool loadFromBlackboard;

			public bool fetchBaseValueFromSourceEntity;


		}

		public List<AbnormalFlag> abnormalFlags;

		public List<AbnormalFlag> abnormalImmunes;

		public List<AbnormalCombo> abnormalCombos;

		public List<AbnormalCombo> abnormalComboImmunes;

		public AttributeModifier[] attributeModifiers;

	}
}
