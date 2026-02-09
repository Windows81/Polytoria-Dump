using MoonSharp.Interpreter;
using Polytoria.Lua;

namespace Polytoria.Datamodel.Proxies
{
	public class ValueBaseProxy : InstanceProxy
	{
		private readonly ValueBase valueBase;

		public LuaEvent Changed => null;

		[MoonSharpHidden]
		public ValueBaseProxy(ValueBase target)
			: base(null)
		{
		}
	}
}
