using MoonSharp.Interpreter;

namespace Polytoria.Datamodel.Proxies
{
	public class LocalScriptProxy : BaseScriptProxy
	{
		private readonly LocalScript localScript;

		[MoonSharpHidden]
		public LocalScriptProxy(LocalScript target)
			: base(null)
		{
		}
	}
}
