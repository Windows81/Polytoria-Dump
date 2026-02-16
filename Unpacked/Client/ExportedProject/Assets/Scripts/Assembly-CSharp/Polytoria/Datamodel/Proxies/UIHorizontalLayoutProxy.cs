using MoonSharp.Interpreter;

namespace Polytoria.Datamodel.Proxies
{
	public class UIHorizontalLayoutProxy : UIHVLayoutProxy
	{
		private readonly UIHorizontalLayout uiHorizontalLayout;

		[MoonSharpHidden]
		public UIHorizontalLayoutProxy(UIHorizontalLayout target)
			: base(null)
		{
		}
	}
}
