using System;
using System.Collections.Generic;

namespace Torappu
{
    public class SkinTable
    {
        public Dictionary<string, CharSkinData> charSkins { get; set; }

        public Dictionary<string, Dictionary<string, string>> buildinEvolveMap { get; set; }

        public SkinTable()
        {
        }
    }
}
