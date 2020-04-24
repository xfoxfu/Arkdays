
namespace Torappu
{
    public class LoginResponse
    {
        public int result { get; set; }

        public string uid { get; set; }

        public string secret { get; set; }

        public int serviceLicenseVersion { get; set; }

        public PlayerDataDelta playerDataDelta { get; set; }

        public LoginResponse()
        {
        }
    }
}
