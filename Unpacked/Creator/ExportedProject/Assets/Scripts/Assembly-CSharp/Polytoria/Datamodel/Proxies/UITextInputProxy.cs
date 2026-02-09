using MoonSharp.Interpreter;
using Polytoria.Lua;
using UnityEngine;

namespace Polytoria.Datamodel.Proxies
{
	public class UITextInputProxy : UIViewProxy
	{
		private readonly UITextInput uiTextInput;

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

		public string Placeholder
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Color PlaceholderColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public bool IsMultiline
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsReadOnly
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsFocused => false;

		[LuaEventParameter(typeof(string), "value", false)]
		public LuaEvent Changed => null;

		[LuaEventParameter(typeof(string), "value", false)]
		public LuaEvent Submitted => null;

		[MoonSharpHidden]
		public UITextInputProxy(UITextInput target)
			: base(null)
		{
		}

		public void Focus()
		{
		}
	}
}
