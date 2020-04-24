namespace U8.SDK
{
    public class U8LoginResult
    {
        // Fields
        public int result { get; set; }
        public string uid { get; set; }
        public string channelUid { get; set; }
        public string token { get; set; }
        public string extension { get; set; }
        public int isGuest { get; set; }
        public string error { get; set; }
    }
}