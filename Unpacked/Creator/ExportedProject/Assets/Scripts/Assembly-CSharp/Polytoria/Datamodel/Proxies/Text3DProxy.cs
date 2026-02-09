using MoonSharp.Interpreter;
using TMPro;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	public class Text3DProxy : DynamicInstanceProxy
	{
		private readonly Text3D text3D;

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

		public bool FaceCamera
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public HorizontalAlignmentOptions HorizontalAlignment
		{
			get
			{
				return default(HorizontalAlignmentOptions);
			}
			set
			{
			}
		}

		public VerticalAlignmentOptions VerticalAlignment
		{
			get
			{
				return default(VerticalAlignmentOptions);
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

		[MoonSharpHidden]
		public Text3DProxy(Text3D target)
			: base(null)
		{
		}
	}
}
