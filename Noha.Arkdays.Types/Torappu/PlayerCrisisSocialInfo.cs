using System.Collections.Generic;

namespace Torappu
{
	public class PlayerCrisisSocialInfo
	{
		public class AssistChar
		{
			public string charId;

			public int cnt;

			public AssistChar()
			{
			}
		}

		public int assistCnt;

		public int maxPnt;

		public List<AssistChar> chars;

		public PlayerCrisisSocialInfo()
		{
		}
	}
}
