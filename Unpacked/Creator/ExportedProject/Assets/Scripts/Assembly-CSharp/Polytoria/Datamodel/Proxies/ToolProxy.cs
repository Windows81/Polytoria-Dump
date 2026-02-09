using MoonSharp.Interpreter;
using Polytoria.Lua;

namespace Polytoria.Datamodel.Proxies
{
	public class ToolProxy : DynamicInstanceProxy
	{
		private readonly Tool tool;

		public LuaEvent Activated => null;

		public LuaEvent Deactivated => null;

		public LuaEvent Equipped => null;

		public LuaEvent Unequipped => null;

		public bool Droppable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[MoonSharpHidden]
		public ToolProxy(Tool target)
			: base(null)
		{
		}

		public void Play(string anim)
		{
		}
	}
}
