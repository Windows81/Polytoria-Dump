using MoonSharp.Interpreter;

namespace Polytoria.Datamodel.Proxies
{
	public class ModuleScriptProxy : BaseScriptProxy
	{
		private readonly ModuleScript moduleScript;

		[MoonSharpHidden]
		public ModuleScriptProxy(ModuleScript target)
			: base(null)
		{
		}
	}
}
