using Polytoria.Lua;

namespace Polytoria.Datamodel
{
	[Instantiatable]
	public class Signal : Instance
	{
		public LuaEvent Invoked;

		public void Invoke(params object[] par)
		{
		}

		public override bool Weaved()
		{
			return false;
		}
	}
}
