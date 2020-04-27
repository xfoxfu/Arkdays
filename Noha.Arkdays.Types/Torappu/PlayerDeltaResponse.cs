
namespace Torappu
{
    public abstract class PlayerDeltaResponse
    {
        public PlayerDataDelta playerDataDelta { get; set; }

        protected PlayerDeltaResponse()
        {
            playerDataDelta = new PlayerDataDelta();
        }
    }
}
