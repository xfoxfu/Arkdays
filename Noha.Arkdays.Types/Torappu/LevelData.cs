using System;
using System.Collections.Generic;

namespace Torappu
{
    public class LevelData
    {
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public enum Difficulty
        {
            NONE,
            NORMAL,
            FOUR_STAR,
            ALL
        }
    }
}
