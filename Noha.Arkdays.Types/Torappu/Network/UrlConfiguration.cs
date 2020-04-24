
using System.Text.Json.Serialization;

namespace Torappu.Network
{
    public struct UrlConfiguration
    {
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
