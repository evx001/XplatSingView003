using System;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;

namespace crossPlatSingView003
{
	public interface ISettings
	{
		User User { get; set; }

		void Save ();
	}
}

