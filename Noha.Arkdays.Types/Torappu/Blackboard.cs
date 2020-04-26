using System;
using System.Collections.Generic;
namespace Torappu
{
    public class Blackboard : List<Blackboard.DataPair>
    {
        public struct DataPair
        {
            public string key { get; set; }
            public float value { get; set; }
            public string valueStr { get; set; }
            public bool isNumericValue { get; set; }
            public bool isStringValue { get; }
        }
    }
}
