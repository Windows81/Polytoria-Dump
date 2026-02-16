using MoonSharp.Interpreter;
using Polytoria.Lua;

namespace Polytoria.Datamodel.Proxies
{
	public class GameProxy : InstanceProxy
	{
		private readonly Game game;

		[LuaEventParameter(typeof(float), "deltaTime", false)]
		public LuaEvent Rendered => null;

		public int GameID => 0;

		public int PlayersConnected => 0;

		public int InstanceCount => 0;

		public int LocalInstanceCount => 0;

		[MoonSharpHidden]
		public GameProxy(Game target)
			: base(null)
		{
		}
	}
}
