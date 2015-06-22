using System;
using System.Threading.Tasks;
using Org.Apache.Http.Authentication;
using crossPlatSingView003;

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

		public async Task<User> Register (User user)
		{
			await Sleep ();
			return user;
		}

		public async Task<User[]> GetFriends (string userId)
		{
			await Sleep ();
			return new [] {
				new User { Id = "2", Username = "JAdams" },
				new User { Id = "3", Username = "TJefferson" },
				new User { Id = "4", Username = "GWashington" },
			};
		}

		public async Task<User> AddFriend (string userId, string username)
		{
			await Sleep ();
			return new User { Id = "5",  Username = username };
		}

		public async Task<Conversation[]>
		GetConversations (string userId)
		{
			await Sleep ();
			return new [] {
				new Conversation { Id = "1", UserId = "2" },
				new Conversation { Id = "2 ", UserId = "3" },
				new Conversation { Id = "3 ", UserId = "4" },
			};
		}

		public async Task<Message[]> GetMessage (int
			conversationId)
		{
			await Sleep ();
			////////// multiple ToString conversions //////////////////
			return new [] {
				new Message {
					Id = "1",
					ConversationId = conversationId.ToString (),
					UserId = "2",
					Text = "Hey",
				},
				new Message {
					Id = "2",
					ConversationId = conversationId.ToString (),
					UserId = "1",
					Text = "What's Up?",
				},
				new Message {
					Id = "3",
					ConversationId = conversationId.ToString (),
					UserId = "2",
					Text = "Have you seen Fury Road yet?",
				},
				new Message {
					Id = "4",
					ConversationId = conversationId.ToString (),
					UserId = "1",
					Text = "It's Awesome!!!",
				},
			};
		}

		public async Task<Message> SendMessage (Message message)
		{
			await Sleep ();
			return message;
		}

		/*class end */
	}
	/* namespaceEnd*/
}
