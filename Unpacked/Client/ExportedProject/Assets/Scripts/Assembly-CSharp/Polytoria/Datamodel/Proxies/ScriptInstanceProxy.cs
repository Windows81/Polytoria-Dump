using MoonSharp.Interpreter;

namespace Polytoria.Datamodel.Proxies
{
	public class ScriptInstanceProxy : BaseScriptProxy
	{
		private readonly ScriptInstance scriptInstance;

		[MoonSharpHidden]
		public ScriptInstanceProxy(ScriptInstance target)
			: base(null)
		{
		}
	}
}
