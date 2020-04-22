using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Noha.Arkdays.Types.Torappu.Network
{
    public class NetworkRouterConfig
    {
        // Fields
        public string sign { get; set; }
        public string content { get; set; }
        public class Content
        {
            // Fields
            public string configVer { get; set; }
            public string funcVer { get; set; }
            public Dictionary<string, NetworkRouterConfig.Config> configs { get; set; }
        }

        public class Config
        {
            [JsonPropertyName("override")]
            public bool useOverride { get; set; }
            public UrlConfiguration network { get; set; }
        }
    }

    public class UrlConfiguration
    {
        // Fields
        [JsonPropertyName("gs")]
        public string gameServerUrl { get; set; }
        [JsonPropertyName("as")]
        public string sdkServerUrl { get; set; }
        [JsonPropertyName("u8")]
        public string u8ServerUrl { get; set; }
        [JsonPropertyName("hu")]
        public string hotUpdateUrl { get; set; }
        [JsonPropertyName("an")]
        public string announceUrl { get; set; }
        [JsonPropertyName("prean")]
        public string preAnnounceUrl { get; set; }
        [JsonPropertyName("sl")]
        public string serviceLicenseUrl { get; set; }
        [JsonPropertyName("of")]
        public string officialUrl { get; set; }
        [JsonPropertyName("pkgAd")]
        public string packageDownloadUrlAndroid { get; set; }
        [JsonPropertyName("pkgIOS")]
        public string packageDownloadUrlIOS { get; set; }
        [JsonPropertyName("secure")]
        public bool enableSecure { get; set; }
    }
}
