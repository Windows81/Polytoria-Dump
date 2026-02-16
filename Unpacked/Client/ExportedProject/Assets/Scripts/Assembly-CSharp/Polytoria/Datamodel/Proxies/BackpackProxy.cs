using MoonSharp.Interpreter;

namespace Polytoria.Datamodel.Proxies
{
	public class BackpackProxy : InstanceProxy
	{
		private readonly Backpack backpack;

		[MoonSharpHidden]
		public BackpackProxy(Backpack target)
			: base(null)
		{
		}
	}
}
