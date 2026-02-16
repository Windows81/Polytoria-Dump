using MoonSharp.Interpreter;
using Polytoria.Lua;

namespace Polytoria.Datamodel.Proxies
{
	public class SignalProxy : InstanceProxy
	{
		private readonly Signal signal;

		public LuaEvent Invoked => null;

		[MoonSharpHidden]
		public SignalProxy(Signal target)
			: base(null)
		{
		}

		public void Invoke(params object[] par)
		{
		}
	}
}
