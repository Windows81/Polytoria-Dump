using MoonSharp.Interpreter;
using Polytoria.Datamodel.Services;
using Polytoria.Lua;

namespace Polytoria.Datamodel.Proxies.Services
{
	public class InsertServiceProxy
	{
		private readonly InsertService insertService;

		[MoonSharpHidden]
		public InsertServiceProxy(InsertService target)
		{
		}

		[LuaCallbackParameter("callback", typeof(Instance), "model", false)]
		public void Model(int id, DynValue callback = null)
		{
		}
	}
}
