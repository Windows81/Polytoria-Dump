using MoonSharp.Interpreter;
using Polytoria.Datamodel.Services;

namespace Polytoria.Datamodel.Proxies.Services
{
	public class ChatServiceProxy
	{
		private readonly ChatService chatService;

		[MoonSharpHidden]
		public ChatServiceProxy(ChatService target)
		{
		}

		public void BroadcastMessage(string message)
		{
		}

		public void UnicastMessage(string message, Player player)
		{
		}
	}
}
