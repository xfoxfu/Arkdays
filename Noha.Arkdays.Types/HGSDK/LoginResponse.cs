using System;
namespace HGSDK
{
    public class LoginResponse
    {
        public int result { get; set; }
        public string uid { get; set; }
        public int role { get; set; }
        public string token { get; set; }
        public bool isAuthenticate { get; set; }
        public bool isMinor { get; set; }
        public bool needAuthenticate { get; set; }
        public DateTime issuedAt { get; set; }
        public DateTime expiresIn { get; set; }
    }
}
