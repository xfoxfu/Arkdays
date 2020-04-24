namespace HGSDK
{
    // Namespace: HGSDK
    public class PingRequest
    {
        // Fields
        public string token { get; set; }
        public int interval { get; set; }
    }

    // Namespace: HGSDK
    public class PingResponse
    {
        // Fields
        public int result { get; set; }
        public int interval { get; set; }
        public string message { get; set; }
        public int timeLeft { get; set; }
        public int alertTime { get; set; }
    }
}