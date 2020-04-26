namespace HGSDK
{
    public class LoginRequest
    {
        // Fields
        public string account { get; set; }
        public string password { get; set; }
        public string deviceId { get; set; }
        public Torappu.PlatformKey platform;
    }
}