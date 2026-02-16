using MoonSharp.Interpreter;
using Polytoria.Lua;

namespace Polytoria.Datamodel.Proxies
{
	public class NetworkEventProxy : InstanceProxy
	{
		private readonly NetworkEvent networkEvent;

		[LuaEventParameter(typeof(Player), "sender", false)]
		[LuaEventParameter(typeof(NetMessage), "message", false)]
		public LuaEvent InvokedServer => null;

		[LuaEventParameter(null, "sender", false)]
		[LuaEventParameter(typeof(NetMessage), "message", false)]
		public LuaEvent InvokedClient => null;

		[MoonSharpHidden]
		public NetworkEventProxy(NetworkEvent target)
			: base(null)
		{
		}

		public void InvokeServer(NetMessage msg)
		{
		}

		public void InvokeClient(NetMessage msg, Player player)
		{
		}

		public void InvokeClients(NetMessage msg)
		{
		}
	}
}
