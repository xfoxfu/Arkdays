using System;

namespace Torappu
{
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
    public enum StageType
    {
        MAIN,
        DAILY,
        TRAINING,
        ACTIVITY,
        GUIDE,
        SUB,
        CAMPAIGN,
        ENUM
    }
}
