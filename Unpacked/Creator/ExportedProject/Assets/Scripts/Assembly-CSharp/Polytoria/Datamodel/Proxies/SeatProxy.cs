using MoonSharp.Interpreter;
using Polytoria.Lua;

namespace Polytoria.Datamodel.Proxies
{
	public class SeatProxy : PartProxy
	{
		private readonly Seat seat;

		public Player Occupant => null;

		[LuaEventParameter(typeof(Player), "occupant", false)]
		public LuaEvent Sat => null;

		[LuaEventParameter(typeof(Player), "occupant", false)]
		public LuaEvent Vacated => null;

		[MoonSharpHidden]
		public SeatProxy(Seat target)
			: base(null)
		{
		}
	}
}
