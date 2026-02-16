using MoonSharp.Interpreter;

namespace Polytoria.Datamodel.Proxies
{
	public class GUIProxy : InstanceProxy
	{
		private readonly GUI gui;

		public bool Visible
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
		public GUIProxy(GUI target)
			: base(null)
		{
		}
	}
}
