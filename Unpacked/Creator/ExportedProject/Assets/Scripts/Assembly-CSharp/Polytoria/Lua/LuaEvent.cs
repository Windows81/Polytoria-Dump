using System.Collections.Generic;
using MoonSharp.Interpreter;

namespace Polytoria.Lua
{
	public class LuaEvent
	{
		private List<DynValue> callbacks;

		public void Connect(DynValue func)
		{
		}

		public void Disconnect(DynValue func)
		{
		}

		[MoonSharpHidden]
		public void Invoke(params object[] par)
		{
		}
	}
}
