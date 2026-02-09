using Mirror;
using Polytoria.Lua;

namespace Polytoria.Datamodel
{
	[Instantiatable]
	public class NetworkEvent : Instance
	{
		public LuaEvent InvokedServer;

		public LuaEvent InvokedClient;

		public void InvokeServer(NetMessage msg)
		{
		}

		public void InvokeClient(NetMessage msg, Player player)
		{
		}

		public void InvokeClients(NetMessage msg)
		{
		}

		[Command(requiresAuthority = false)]
		private void InvokeCmd(NetMessage msg, NetworkConnectionToClient sender = null)
		{
		}

		[TargetRpc]
		private void InvokeTargetRpc(NetworkConnection target, NetMessage msg)
		{
		}

		[ClientRpc]
		private void InvokeClientRpc(NetMessage msg)
		{
		}

		public override bool Weaved()
		{
			return false;
		}

		protected void UserCode_InvokeCmd__NetMessage__NetworkConnectionToClient(NetMessage msg, NetworkConnectionToClient sender)
		{
		}

		protected static void InvokeUserCode_InvokeCmd__NetMessage__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_InvokeTargetRpc__NetworkConnection__NetMessage(NetworkConnection target, NetMessage msg)
		{
		}

		protected static void InvokeUserCode_InvokeTargetRpc__NetworkConnection__NetMessage(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_InvokeClientRpc__NetMessage(NetMessage msg)
		{
		}

		protected static void InvokeUserCode_InvokeClientRpc__NetMessage(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		static NetworkEvent()
		{
		}
	}
}
