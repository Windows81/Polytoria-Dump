using MoonSharp.Interpreter;
using Polytoria.Lua;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	public class RemoveEventProxy : InstanceProxy
	{
		private readonly RemoteEvent remoteEvent;

		[LuaEventParameter(typeof(Player), "sender", false)]
		[LuaEventParameter(typeof(object), "value", false)]
		public LuaEvent Invoked => null;

		[MoonSharpHidden]
		public RemoveEventProxy(RemoteEvent target)
			: base(null)
		{
		}

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
	}
}
