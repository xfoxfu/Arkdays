using System;

namespace Noha.Arkdays.Utils
{
    public static class Time
    {
        public static long GetTimeStamp()
        {
            return Convert.ToInt64(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds);
        }
    }
}