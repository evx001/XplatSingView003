using System;
using System.Threading.Tasks;

namespace crossPlatSingView003
{
	public class FakeWebService
	{
		public int SleepDuration { get; set; }

		public FakeWebService ()
		{
			SleepDuration = 1; 
		}

		private Task Sleep ()
		{ 
			return Task.Delay (SleepDuration);
		}

		public async Task<User> Login (string username, string password)
		{
			await Sleep ();
			return new User { Id = "1", Username = username }; 
		}
	}
}

