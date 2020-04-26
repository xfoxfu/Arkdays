namespace Torappu
{
    // Namespace: Torappu
    public class SyncDataRequest
    {
        // Fields
        public PlatformKey platform { get; set; }
    }

    // Namespace: Torappu
    public class SyncDataResponse : PlayerInitResponse
    {
        // Fields
        public long ts { get; set; }
    }
}