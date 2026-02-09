using Mirror;
using Polytoria.Lua;
using UnityEngine;

namespace Polytoria.Datamodel
{
	public class RemoteEvent : Instance
	{
		public LuaEvent Invoked;

		public void Invoke(string val)
		{
		}

		public void Invoke(bool val)
		{
		}

		public void Invoke(float val)
		{
		}

		public void Invoke(int val)
		{
		}

		public void Invoke(Vector3 val)
		{
		}

		public void Invoke(Color val)
		{
		}

		public void Invoke(Instance val)
		{
		}

		[Command(requiresAuthority = false)]
		private void CmdInvokeString(string val, NetworkConnectionToClient sender = null)
		{
		}

		[Command(requiresAuthority = false)]
		private void CmdInvokeBool(bool val, NetworkConnectionToClient sender = null)
		{
		}

		[Command(requiresAuthority = false)]
		private void CmdInvokeFloat(float val, NetworkConnectionToClient sender = null)
		{
		}

		[Command(requiresAuthority = false)]
		private void CmdInvokeInt(int val, NetworkConnectionToClient sender = null)
		{
		}

		[Command(requiresAuthority = false)]
		private void CmdInvokeVec3(Vector3 val, NetworkConnectionToClient sender = null)
		{
		}

		[Command(requiresAuthority = false)]
		private void CmdInvokeColor(Color val, NetworkConnectionToClient sender = null)
		{
		}

		[Command(requiresAuthority = false)]
		private void CmdInvokeInstance(Instance val, NetworkConnectionToClient sender = null)
		{
		}

		public override bool Weaved()
		{
			return false;
		}

		protected void UserCode_CmdInvokeString__String__NetworkConnectionToClient(string val, NetworkConnectionToClient sender)
		{
		}

		protected static void InvokeUserCode_CmdInvokeString__String__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_CmdInvokeBool__Boolean__NetworkConnectionToClient(bool val, NetworkConnectionToClient sender)
		{
		}

		protected static void InvokeUserCode_CmdInvokeBool__Boolean__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_CmdInvokeFloat__Single__NetworkConnectionToClient(float val, NetworkConnectionToClient sender)
		{
		}

		protected static void InvokeUserCode_CmdInvokeFloat__Single__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_CmdInvokeInt__Int32__NetworkConnectionToClient(int val, NetworkConnectionToClient sender)
		{
		}

		protected static void InvokeUserCode_CmdInvokeInt__Int32__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_CmdInvokeVec3__Vector3__NetworkConnectionToClient(Vector3 val, NetworkConnectionToClient sender)
		{
		}

		protected static void InvokeUserCode_CmdInvokeVec3__Vector3__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_CmdInvokeColor__Color__NetworkConnectionToClient(Color val, NetworkConnectionToClient sender)
		{
		}

		protected static void InvokeUserCode_CmdInvokeColor__Color__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		protected void UserCode_CmdInvokeInstance__Instance__NetworkConnectionToClient(Instance val, NetworkConnectionToClient sender)
		{
		}

		protected static void InvokeUserCode_CmdInvokeInstance__Instance__NetworkConnectionToClient(NetworkBehaviour obj, NetworkReader reader, NetworkConnectionToClient senderConnection)
		{
		}

		static RemoteEvent()
		{
		}
	}
}
