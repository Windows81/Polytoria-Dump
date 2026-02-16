using MoonSharp.Interpreter;

namespace Polytoria.Datamodel.Proxies
{
	public class SkyBaseProxy : InstanceProxy
	{
		private readonly SkyBase skyBase;

		[MoonSharpHidden]
		public SkyBaseProxy(SkyBase target)
			: base(null)
		{
		}
	}
}
