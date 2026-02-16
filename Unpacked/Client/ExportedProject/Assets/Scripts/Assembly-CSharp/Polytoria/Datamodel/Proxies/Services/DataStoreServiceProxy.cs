using MoonSharp.Interpreter;
using Polytoria.Datamodel.Services;

namespace Polytoria.Datamodel.Proxies.Services
{
	public class DataStoreServiceProxy
	{
		private readonly DataStoreService dataStoreService;

		[MoonSharpHidden]
		public DataStoreServiceProxy(DataStoreService target)
		{
		}

		public Datastore GetDatastore(string key)
		{
			return null;
		}
	}
}
