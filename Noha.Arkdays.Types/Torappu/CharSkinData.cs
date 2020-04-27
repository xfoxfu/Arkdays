using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Torappu
{
    public class CharSkinData
    {
        public class DisplaySkin
        {
            public string skinName { get; set; }

            public List<string> colorList { get; set; }

            public List<string> titleList { get; set; }

            public string modelName { get; set; }

            public string drawerName { get; set; }

            public string skinGroupId { get; set; }

            public string skinGroupName { get; set; }

            public int skinGroupSortIndex { get; set; }

            public string content { get; set; }

            public string dialog { get; set; }

            public string usage { get; set; }

            public string description { get; set; }

            public string obtainApproach { get; set; }

            public int sortId { get; set; }

            public DisplaySkin()
            {
            }
        }

        public struct BattleSkin
        {

            public bool overwritePrefab { get; set; }

            public string skinOrPrefabId { get; set; }

        }

        public string skinId { get; set; }

        public string charId { get; set; }

        public string tokenSkinId { get; set; }

        public string illustId { get; set; }

        public string avatarId { get; set; }

        public string portraitId { get; set; }

        public string buildingId { get; set; }

        public BattleSkin battleSkin { get; set; }

        [JsonPropertyName("isBuySkin")]
        public bool isBuyAble { get; set; }

        public DisplaySkin displaySkin { get; set; }
    }
}
