using MoonSharp.Interpreter;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	public class UILabelProxy : UIViewProxy
	{
		private readonly UILabel uiLabel;

		public string Text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Color TextColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public TextJustify JustifyText
		{
			get
			{
				return default(TextJustify);
			}
			set
			{
			}
		}

		public TextVerticalAlign VerticalAlign
		{
			get
			{
				return default(TextVerticalAlign);
			}
			set
			{
			}
		}

		public float FontSize
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float MaxFontSize
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool AutoSize
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public TextFontPreset Font
		{
			get
			{
				return default(TextFontPreset);
			}
			set
			{
			}
		}

		public Color OutlineColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public float OutlineWidth
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
		public UILabelProxy(UILabel target)
			: base(null)
		{
		}
	}
}
