using MoonSharp.Interpreter;
using Polytoria.Datamodel.Services;

namespace Polytoria.Datamodel.Proxies.Services
{
	public class FilterServiceProxy
	{
		private readonly FilterService filterService;

		[MoonSharpHidden]
		public FilterServiceProxy(FilterService target)
		{
		}

		public static string Filter(string input)
		{
			return null;
		}
	}
}
