using System;
using System.Runtime.InteropServices;
using Mirror;
using TMPro;
using UnityEngine;

namespace Polytoria.Datamodel
{
	[Instantiatable]
	public class UILabel : UIView
	{
		public const float FONT_SCALE = 1.5f;

		private TMP_Text tmp;

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

		[SyncVar(hook = "SyncSetOutlineColor")]
		private Color outlineColor;

		[SyncVar(hook = "SyncSetOutlineWidth")]
		private float outlineWidth;

		public Action<TextJustify, TextJustify> _Mirror_SyncVarHookDelegate_justify;

		public Action<TextVerticalAlign, TextVerticalAlign> _Mirror_SyncVarHookDelegate_verticalAlign;

		public Action<float, float> _Mirror_SyncVarHookDelegate_fontSize;

		public Action<float, float> _Mirror_SyncVarHookDelegate_maxFontSize;

		public Action<bool, bool> _Mirror_SyncVarHookDelegate_autoSize;

		public Action<string, string> _Mirror_SyncVarHookDelegate_text;

		public Action<Color, Color> _Mirror_SyncVarHookDelegate_textColor;

		public Action<TextFontPreset, TextFontPreset> _Mirror_SyncVarHookDelegate_font;

		public Action<Color, Color> _Mirror_SyncVarHookDelegate_outlineColor;

		public Action<float, float> _Mirror_SyncVarHookDelegate_outlineWidth;

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

		[CreatorProperty]
		[Archivable]
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

		public Color NetworkoutlineColor
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

		public float NetworkoutlineWidth
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

		private void SyncSetOutlineColor(Color oldValue, Color newValue)
		{
		}

		private void SyncSetOutlineWidth(float oldValue, float newValue)
		{
		}

		private void UpdateOutline()
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

		protected override void OnDestroy()
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
