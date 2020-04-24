using System;
using System.Collections.Generic;

namespace Torappu
{
    public class Blackboard : List<Blackboard.DataPair>
    {
        public struct DataPair
        {
            public string key;

            public float value;

            public string valueStr;

            public bool isNumericValue { get; set; }

            public bool isStringValue { get; }
        }
    }
}
