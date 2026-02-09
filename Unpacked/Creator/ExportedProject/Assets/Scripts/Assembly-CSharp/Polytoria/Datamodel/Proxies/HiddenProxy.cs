using MoonSharp.Interpreter;

namespace Polytoria.Datamodel.Proxies
{
	public class HiddenProxy : InstanceProxy
	{
		private readonly Hidden hidden;

		[MoonSharpHidden]
		public HiddenProxy(Hidden target)
			: base(null)
		{
		}
	}
}
