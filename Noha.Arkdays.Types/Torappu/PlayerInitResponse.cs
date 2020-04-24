using Newtonsoft.Json.Linq;

namespace Torappu
{
	public abstract class PlayerInitResponse
	{
		public JObject user;

		protected PlayerInitResponse()
		{
		}
	}
}
