using System;

namespace crossPlatSingView003
{
	public class FakeSettings : ISettings
	{
		public User User { get; set; }

		public void Save ()
		{
		}
	}
}

