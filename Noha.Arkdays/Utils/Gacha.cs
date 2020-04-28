using System;
using System.Collections.Generic;
using System.Linq;

namespace Noha.Arkdays.Utils
{
    public static class Gacha
    {
        private static readonly Random rand = new Random(DateTime.Now.GetHashCode());

        public static int RandomStar()
        {
            return 5;
            var doub = rand.NextDouble();
            if (doub <= 0.02)
                return 5;
            else if (doub <= 0.10)
                return 4;
            else if (doub <= 0.60)
                return 3;
            else
                return 2;
        }

        public static T FromList<T>(IEnumerable<T> list)
        {
            var idx = rand.Next(0, list.Count());
            return list.ElementAt(idx);
        }
    }
}