using MoonSharp.Interpreter;

namespace Polytoria.Datamodel.Proxies
{
	public class PlayerGUIProxy : InstanceProxy
	{
		private readonly PlayerGUI playerGUI;

		public float Opacity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

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
		public PlayerGUIProxy(PlayerGUI target)
			: base(null)
		{
		}
	}
}
