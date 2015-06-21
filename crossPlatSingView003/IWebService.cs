using System;
using System.Threading.Tasks;

namespace crossPlatSingView003
{
	public interface IWebService
	{
		Task<User> Login (string username, string password);

		Task<User> Register (User user);

		Task<User [] > GetFriends (string userId);

		Task<User> AddFriend (string userId);

		Task<Conversation [] > GetCoversations (string username);

		Task<Message [] > GetMessages (string conversationId);

		Task<Message> SendMessage (Message message);
	}
}

