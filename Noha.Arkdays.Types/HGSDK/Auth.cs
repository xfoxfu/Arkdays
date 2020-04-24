namespace HGSDK
{
    // Namespace: HGSDK
    public class AuthRequest
    {
        // Fields
        public string token;
    }

    // Namespace: HGSDK
    public class AuthResponse
    {
        // Fields
        public string uid;
        public bool isAuthenticate;
        public bool isMinor;
        public bool needAuthenticate;
    }
}