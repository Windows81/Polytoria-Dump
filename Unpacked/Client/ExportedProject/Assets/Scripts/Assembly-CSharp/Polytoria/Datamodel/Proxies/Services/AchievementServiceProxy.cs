using MoonSharp.Interpreter;
using Polytoria.Datamodel.Services;
using Polytoria.Lua;

namespace Polytoria.Datamodel.Proxies.Services
{
	public class AchievementServiceProxy
	{
		private readonly AchievementService achievementService;

		[MoonSharpHidden]
		public AchievementServiceProxy(AchievementService target)
		{
		}

		[LuaCallbackParameter("callback", typeof(bool), "success", false)]
		[LuaCallbackParameter("callback", typeof(string), "error", true)]
		public void Award(int userID, int achievementID, DynValue callback)
		{
		}

		[LuaCallbackParameter("callback", typeof(bool), "owned", false)]
		[LuaCallbackParameter("callback", typeof(bool), "success", false)]
		[LuaCallbackParameter("callback", typeof(string), "error", true)]
		public void HasAchievement(int userID, int achievementID, DynValue callback)
		{
		}
	}
}
