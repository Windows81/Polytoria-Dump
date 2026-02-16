using Polytoria.Lua;

namespace Polytoria.Datamodel
{
	public class ValueBase : Instance
	{
		public LuaEvent Changed;

		protected void InvokeChanged()
		{
		}

		public override bool Weaved()
		{
			return false;
		}
	}
}
