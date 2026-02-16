using MoonSharp.Interpreter;
using Polytoria.Lua;

namespace Polytoria.Datamodel.Proxies
{
	public class PlayersProxy : InstanceProxy
	{
		private readonly Players players;

		[LuaEventParameter(typeof(Player), "player", false)]
		public LuaEvent PlayerAdded => null;

		[LuaEventParameter(typeof(Player), "player", false)]
		public LuaEvent PlayerRemoved => null;

		public bool PlayerCollisionEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Player LocalPlayer => null;

		[MoonSharpHidden]
		public PlayersProxy(Players target)
			: base(null)
		{
		}

		public Player[] GetPlayers()
		{
			return null;
		}

		public Player GetPlayer(string username)
		{
			return null;
		}

		public Player GetPlayerByID(int id)
		{
			return null;
		}
	}
}
