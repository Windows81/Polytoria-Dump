using MoonSharp.Interpreter;

namespace Polytoria.Datamodel.Proxies
{
	public class ModelProxy : DynamicInstanceProxy
	{
		private readonly Model model;

		[MoonSharpHidden]
		public ModelProxy(Model target)
			: base(null)
		{
		}
	}
}
