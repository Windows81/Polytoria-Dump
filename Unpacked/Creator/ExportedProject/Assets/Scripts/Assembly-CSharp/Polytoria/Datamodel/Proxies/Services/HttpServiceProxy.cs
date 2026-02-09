using MoonSharp.Interpreter;
using Polytoria.Datamodel.Services;
using Polytoria.Lua;

namespace Polytoria.Datamodel.Proxies.Services
{
	public class HttpServiceProxy
	{
		private readonly HttpService httpService;

		[MoonSharpHidden]
		public HttpServiceProxy(HttpService target)
		{
		}

		[LuaCallbackParameter("callback", typeof(string), "data", true)]
		[LuaCallbackParameter("callback", typeof(bool), "error", false)]
		[LuaCallbackParameter("callback", typeof(string), "message", true)]
		public static void Get(string url, DynValue callback = null, Table headers = null)
		{
		}

		[LuaCallbackParameter("callback", typeof(string), "data", true)]
		[LuaCallbackParameter("callback", typeof(bool), "error", false)]
		[LuaCallbackParameter("callback", typeof(string), "message", true)]
		public static void Post(string url, string body, DynValue callback = null, Table headers = null)
		{
		}

		[LuaCallbackParameter("callback", typeof(string), "data", true)]
		[LuaCallbackParameter("callback", typeof(bool), "error", false)]
		[LuaCallbackParameter("callback", typeof(string), "message", true)]
		public static void Put(string url, string body, DynValue callback = null, Table headers = null)
		{
		}

		[LuaCallbackParameter("callback", typeof(string), "data", true)]
		[LuaCallbackParameter("callback", typeof(bool), "error", false)]
		[LuaCallbackParameter("callback", typeof(string), "message", true)]
		public static void Delete(string url, DynValue callback = null, Table headers = null)
		{
		}

		[LuaCallbackParameter("callback", typeof(string), "data", true)]
		[LuaCallbackParameter("callback", typeof(bool), "error", false)]
		[LuaCallbackParameter("callback", typeof(string), "message", true)]
		public static void Patch(string url, string body, DynValue callback = null, Table headers = null)
		{
		}
	}
}
