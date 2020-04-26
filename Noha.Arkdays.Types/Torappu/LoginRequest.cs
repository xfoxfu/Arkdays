
namespace Torappu
{
    public class LoginRequest
    {
        public string uid { get; set; }
        public string token { get; set; }
        public string assetsVersion { get; set; }
        public string clientVersion { get; set; }
        public PlatformKey platform { get; set; }
        public string deviceId { get; set; }
        public string deviceId2 { get; set; }
        public string deviceId3 { get; set; }
    }
}
