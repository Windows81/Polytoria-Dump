using System;
using System.Runtime.InteropServices;
using Mirror;
using Polytoria.Lua;
using TMPro;
using UnityEngine;

namespace Polytoria.Datamodel
{
	[Instantiatable]
	public class UITextInput : UIView
	{
		private TMP_InputField inputField;

		private TMP_Text placeholderText;

		public LuaEvent Changed;

		public LuaEvent Submitted;

		[SyncVar(hook = "SyncSetTextJustify")]
		private TextJustify justify;

		[SyncVar(hook = "SyncSetTextAlign")]
		private TextVerticalAlign verticalAlign;

		[SyncVar(hook = "SyncSetFontSize")]
		private float fontSize;

		[SyncVar(hook = "SyncSetMaxFontSize")]
		private float maxFontSize;

		[SyncVar(hook = "SyncSetAutoSize")]
		private bool autoSize;

		[SyncVar(hook = "SyncSetText")]
		private string text;

		[SyncVar(hook = "SyncSetColor")]
		private Color textColor;

		[SyncVar(hook = "SyncSetFont")]
		private TextFontPreset font;

		[SyncVar(hook = "SyncSetPlaceholder")]
		private string placeholder;

		[SyncVar(hook = "SyncSetPlaceholderColor")]
		private Color placeholderColor;

		[SyncVar(hook = "SyncSetIsReadOnly")]
		private bool isReadOnly;

		[SyncVar(hook = "SyncSetIsMultiline")]
		private bool isMultiline;

		public Action<TextJustify, TextJustify> _Mirror_SyncVarHookDelegate_justify;

		public Action<TextVerticalAlign, TextVerticalAlign> _Mirror_SyncVarHookDelegate_verticalAlign;

		public Action<float, float> _Mirror_SyncVarHookDelegate_fontSize;

		public Action<float, float> _Mirror_SyncVarHookDelegate_maxFontSize;

		public Action<bool, bool> _Mirror_SyncVarHookDelegate_autoSize;

		public Action<string, string> _Mirror_SyncVarHookDelegate_text;

		public Action<Color, Color> _Mirror_SyncVarHookDelegate_textColor;

		public Action<TextFontPreset, TextFontPreset> _Mirror_SyncVarHookDelegate_font;

		public Action<string, string> _Mirror_SyncVarHookDelegate_placeholder;

		public Action<Color, Color> _Mirror_SyncVarHookDelegate_placeholderColor;

		public Action<bool, bool> _Mirror_SyncVarHookDelegate_isReadOnly;

		public Action<bool, bool> _Mirror_SyncVarHookDelegate_isMultiline;

		[CreatorProperty]
		[Archivable]
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

		[CreatorProperty]
		[Archivable]
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

		[CreatorProperty]
		[Archivable]
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

		[CreatorProperty]
		[Archivable]
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

		[CreatorProperty]
		[Archivable]
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

		[CreatorProperty]
		[Archivable]
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

		[CreatorProperty]
		[Archivable]
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

		[CreatorProperty]
		[Archivable]
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

		[CreatorProperty]
		[Archivable]
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

		[CreatorProperty]
		[Archivable]
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

		[CreatorProperty]
		[Archivable]
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

		[CreatorProperty]
		[Archivable]
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

		public TextJustify Networkjustify
		{
			get
			{
				return default(TextJustify);
			}
			[param: In]
			set
			{
			}
		}

		public TextVerticalAlign NetworkverticalAlign
		{
			get
			{
				return default(TextVerticalAlign);
			}
			[param: In]
			set
			{
			}
		}

		public float NetworkfontSize
		{
			get
			{
				return 0f;
			}
			[param: In]
			set
			{
			}
		}

		public float NetworkmaxFontSize
		{
			get
			{
				return 0f;
			}
			[param: In]
			set
			{
			}
		}

		public bool NetworkautoSize
		{
			get
			{
				return false;
			}
			[param: In]
			set
			{
			}
		}

		public string Networktext
		{
			get
			{
				return null;
			}
			[param: In]
			set
			{
			}
		}

		public Color NetworktextColor
		{
			get
			{
				return default(Color);
			}
			[param: In]
			set
			{
			}
		}

		public TextFontPreset Networkfont
		{
			get
			{
				return default(TextFontPreset);
			}
			[param: In]
			set
			{
			}
		}

		public string Networkplaceholder
		{
			get
			{
				return null;
			}
			[param: In]
			set
			{
			}
		}

		public Color NetworkplaceholderColor
		{
			get
			{
				return default(Color);
			}
			[param: In]
			set
			{
			}
		}

		public bool NetworkisReadOnly
		{
			get
			{
				return false;
			}
			[param: In]
			set
			{
			}
		}

		public bool NetworkisMultiline
		{
			get
			{
				return false;
			}
			[param: In]
			set
			{
			}
		}

		public void Focus()
		{
		}

		private void SyncSetText(string oldtext, string newtext)
		{
		}

		private void SyncSetTextJustify(TextJustify oldValue, TextJustify newValue)
		{
		}

		private void SyncSetTextAlign(TextVerticalAlign oldValue, TextVerticalAlign newValue)
		{
		}

		private void SyncSetFontSize(float oldValue, float newValue)
		{
		}

		private void SyncSetMaxFontSize(float oldValue, float newValue)
		{
		}

		private void SyncSetAutoSize(bool oldValue, bool newValue)
		{
		}

		private void SyncSetColor(Color oldValue, Color newValue)
		{
		}

		private void SyncSetFont(TextFontPreset oldValue, TextFontPreset newValue)
		{
		}

		private void SyncSetPlaceholder(string oldValue, string newValue)
		{
		}

		private void SyncSetPlaceholderColor(Color oldValue, Color newValue)
		{
		}

		private void SyncSetIsMultiline(bool oldValue, bool newValue)
		{
		}

		private void SyncSetIsReadOnly(bool oldValue, bool newValue)
		{
		}

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		protected override void OnHide()
		{
		}

		protected override void OnShow()
		{
		}

		protected override void CopyProperties(Instance clone)
		{
		}

		public override bool Weaved()
		{
			return false;
		}

		public override void SerializeSyncVars(NetworkWriter writer, bool forceAll)
		{
		}

		public override void DeserializeSyncVars(NetworkReader reader, bool initialState)
		{
		}
	}
}
