namespace HGSDK
{
    // Namespace: HGSDK
    public class AuthRequest
    {
        // Fields
        public string token { get; set; }
    }

    // Namespace: HGSDK
    public class AuthResponse
    {
        // Fields
        public string uid { get; set; }
        public bool isAuthenticate { get; set; }
        public bool isMinor { get; set; }
        public bool needAuthenticate { get; set; }
    }
}