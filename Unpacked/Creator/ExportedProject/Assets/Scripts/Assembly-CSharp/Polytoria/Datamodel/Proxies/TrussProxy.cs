using MoonSharp.Interpreter;

namespace Polytoria.Datamodel.Proxies
{
	public class TrussProxy : ClimbableProxy
	{
		private readonly Truss truss;

		[MoonSharpHidden]
		public TrussProxy(Truss target)
			: base(null)
		{
		}
	}
}
