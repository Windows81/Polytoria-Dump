using MoonSharp.Interpreter;
using Polytoria.Datamodel.Services;
using Polytoria.Lua;

namespace Polytoria.Datamodel.Proxies.Services
{
	public class DatastoreProxy
	{
		private readonly Datastore datastore;

		public string Key => null;

		public bool Loading => false;

		public LuaEvent Loaded => null;

		[MoonSharpHidden]
		public DatastoreProxy(Datastore target)
		{
		}

		[LuaCallbackParameter("callback", typeof(object), "value", true)]
		[LuaCallbackParameter("callback", typeof(bool), "success", false)]
		[LuaCallbackParameter("callback", typeof(string), "error", true)]
		public void Get(string key, DynValue callback)
		{
		}

		[LuaCallbackParameter("callback", typeof(bool), "success", false)]
		[LuaCallbackParameter("callback", typeof(string), "error", true)]
		public void Set(string key, DynValue value, DynValue callback = null)
		{
		}

		[LuaCallbackParameter("callback", typeof(bool), "success", false)]
		[LuaCallbackParameter("callback", typeof(string), "error", true)]
		public void Remove(string key, DynValue callback = null)
		{
		}
	}
}
