using MoonSharp.Interpreter;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	public class UIViewProxy : UIFieldProxy
	{
		private readonly UIView uiView;

		public Color BorderColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public float BorderWidth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Color Color
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public float CornerRadius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[MoonSharpHidden]
		public UIViewProxy(UIView target)
			: base(null)
		{
		}
	}
}
