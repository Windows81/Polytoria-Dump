using MoonSharp.Interpreter;

namespace Polytoria.Datamodel.Proxies
{
	public class UIButtonProxy : UILabelProxy
	{
		private readonly UIButton uiButton;

		public bool Interactable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[MoonSharpHidden]
		public UIButtonProxy(UIButton target)
			: base(null)
		{
		}
	}
}
