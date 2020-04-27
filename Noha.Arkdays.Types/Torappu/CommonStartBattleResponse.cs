
namespace Torappu
{
    public abstract class CommonStartBattleResponse : PlayerDeltaResponse
    {
        public int result { get; set; }

        public string battleId { get; set; }
    }
}
