using MoonSharp.Interpreter;

namespace Polytoria.Datamodel.Proxies
{
	public class UIVerticalLayoutProxy : UIHVLayoutProxy
	{
		private readonly UIVerticalLayout uiVerticalLayout;

		[MoonSharpHidden]
		public UIVerticalLayoutProxy(UIVerticalLayout target)
			: base(null)
		{
		}
	}
}
