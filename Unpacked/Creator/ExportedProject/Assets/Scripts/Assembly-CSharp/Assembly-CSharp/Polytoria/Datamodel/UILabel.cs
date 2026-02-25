namespace Polytoria.Datamodel;

[Instantiatable]
[Token(Token = "0x200036E")]
public class UILabel : UIView
{
	[Token(Token = "0x4000ED0")]
	public const float FONT_SCALE = 1.5; //Field offset: 0x0
	[FieldOffset(Offset = "0x1F8")]
	[Token(Token = "0x4000ED1")]
	private TMP_Text tmp; //Field offset: 0x1F8
	[FieldOffset(Offset = "0x200")]
	[SyncVar(hook = "SyncSetTextJustify")]
	[Token(Token = "0x4000ED2")]
	private TextJustify justify; //Field offset: 0x200
	[FieldOffset(Offset = "0x204")]
	[SyncVar(hook = "SyncSetTextAlign")]
	[Token(Token = "0x4000ED3")]
	private TextVerticalAlign verticalAlign; //Field offset: 0x204
	[FieldOffset(Offset = "0x208")]
	[SyncVar(hook = "SyncSetFontSize")]
	[Token(Token = "0x4000ED4")]
	private float fontSize; //Field offset: 0x208
	[FieldOffset(Offset = "0x20C")]
	[SyncVar(hook = "SyncSetMaxFontSize")]
	[Token(Token = "0x4000ED5")]
	private float maxFontSize; //Field offset: 0x20C
	[FieldOffset(Offset = "0x210")]
	[SyncVar(hook = "SyncSetAutoSize")]
	[Token(Token = "0x4000ED6")]
	private bool autoSize; //Field offset: 0x210
	[FieldOffset(Offset = "0x218")]
	[SyncVar(hook = "SyncSetText")]
	[Token(Token = "0x4000ED7")]
	private string text; //Field offset: 0x218
	[FieldOffset(Offset = "0x220")]
	[SyncVar(hook = "SyncSetColor")]
	[Token(Token = "0x4000ED8")]
	private Color textColor; //Field offset: 0x220
	[FieldOffset(Offset = "0x230")]
	[SyncVar(hook = "SyncSetFont")]
	[Token(Token = "0x4000ED9")]
	private TextFontPreset font; //Field offset: 0x230
	[FieldOffset(Offset = "0x234")]
	[SyncVar(hook = "SyncSetOutlineColor")]
	[Token(Token = "0x4000EDA")]
	private Color outlineColor; //Field offset: 0x234
	[FieldOffset(Offset = "0x244")]
	[SyncVar(hook = "SyncSetOutlineWidth")]
	[Token(Token = "0x4000EDB")]
	private float outlineWidth; //Field offset: 0x244
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x4000EDC")]
	public Action<TextJustify, TextJustify> _Mirror_SyncVarHookDelegate_justify; //Field offset: 0x248
	[FieldOffset(Offset = "0x250")]
	[Token(Token = "0x4000EDD")]
	public Action<TextVerticalAlign, TextVerticalAlign> _Mirror_SyncVarHookDelegate_verticalAlign; //Field offset: 0x250
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x4000EDE")]
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_fontSize; //Field offset: 0x258
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x4000EDF")]
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_maxFontSize; //Field offset: 0x260
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x4000EE0")]
	public Action<Boolean, Boolean> _Mirror_SyncVarHookDelegate_autoSize; //Field offset: 0x268
	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x4000EE1")]
	public Action<String, String> _Mirror_SyncVarHookDelegate_text; //Field offset: 0x270
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4000EE2")]
	public Action<Color, Color> _Mirror_SyncVarHookDelegate_textColor; //Field offset: 0x278
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x4000EE3")]
	public Action<TextFontPreset, TextFontPreset> _Mirror_SyncVarHookDelegate_font; //Field offset: 0x280
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x4000EE4")]
	public Action<Color, Color> _Mirror_SyncVarHookDelegate_outlineColor; //Field offset: 0x288
	[FieldOffset(Offset = "0x290")]
	[Token(Token = "0x4000EE5")]
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_outlineWidth; //Field offset: 0x290

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000AFC")]
	public bool AutoSize
	{
		[Address(RVA = "0x499300", Offset = "0x498500", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60024BC")]
		 get { } //Length: 8
		[Address(RVA = "0x499380", Offset = "0x498580", Length = "0x87")]
		[CalledBy(Type = typeof(UIButton), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIButton), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UILabel), Member = "SyncSetAutoSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UILabel), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UILabel), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UILabelProxy), Member = "set_AutoSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
		[Calls(Type = typeof(TMP_Text), Member = "set_enableAutoSizing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60024BD")]
		 set { } //Length: 135
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000AFD")]
	public TextFontPreset Font
	{
		[Address(RVA = "0x499320", Offset = "0x498520", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60024BE")]
		 get { } //Length: 7
		[Address(RVA = "0x4994C0", Offset = "0x4986C0", Length = "0x120")]
		[CalledBy(Type = typeof(UIButton), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIButton), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UILabel), Member = "SyncSetFont", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextFontPreset), typeof(TextFontPreset)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UILabel), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UILabel), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UILabelProxy), Member = "set_Font", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextFontPreset)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400070")]
		[ContainsInvalidInstructions]
		[Token(Token = "0x60024BF")]
		 set { } //Length: 288
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000AFA")]
	public float FontSize
	{
		[Address(RVA = "0x499310", Offset = "0x498510", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60024B8")]
		 get { } //Length: 9
		[Address(RVA = "0x499410", Offset = "0x498610", Length = "0xAF")]
		[CalledBy(Type = typeof(UIButton), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIButton), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UILabel), Member = "SyncSetFontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UILabel), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UILabel), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UILabelProxy), Member = "set_FontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Calls(Type = typeof(UILabel), Member = "set_NetworkmaxFontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TMP_Text), Member = "set_fontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60024B9")]
		 set { } //Length: 175
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000AF8")]
	public TextJustify JustifyText
	{
		[Address(RVA = "0x499330", Offset = "0x498530", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60024B4")]
		 get { } //Length: 7
		[Address(RVA = "0x4996D0", Offset = "0x4988D0", Length = "0xD1")]
		[CalledBy(Type = typeof(UIButton), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIButton), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UILabel), Member = "SyncSetTextJustify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextJustify), typeof(TextJustify)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UILabel), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UILabel), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UILabelProxy), Member = "set_JustifyText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextJustify)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400070")]
		[Calls(Type = typeof(TMP_Text), Member = "set_alignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAlignmentOptions)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60024B5")]
		 set { } //Length: 209
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000AFB")]
	public float MaxFontSize
	{
		[Address(RVA = "0x499340", Offset = "0x498540", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60024BA")]
		 get { } //Length: 9
		[Address(RVA = "0x4997B0", Offset = "0x4989B0", Length = "0xBC")]
		[CalledBy(Type = typeof(UIButton), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIButton), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UILabel), Member = "SyncSetMaxFontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UILabel), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UILabel), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UILabelProxy), Member = "set_MaxFontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Calls(Type = typeof(TMP_Text), Member = "set_fontSizeMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TMP_Text), Member = "set_fontSizeMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60024BB")]
		 set { } //Length: 188
	}

	[Token(Token = "0x17000B04")]
	public bool NetworkautoSize
	{
		[Address(RVA = "0x499300", Offset = "0x498500", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60024D5")]
		 get { } //Length: 8
		[Address(RVA = "0x499870", Offset = "0x498A70", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
		[Token(Token = "0x60024D6")]
		 set { } //Length: 104
	}

	[Token(Token = "0x17000B07")]
	public TextFontPreset Networkfont
	{
		[Address(RVA = "0x499320", Offset = "0x498520", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60024DB")]
		 get { } //Length: 7
		[Address(RVA = "0x499950", Offset = "0x498B50", Length = "0x65")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400070")]
		[Token(Token = "0x60024DC")]
		 set { } //Length: 101
	}

	[Token(Token = "0x17000B02")]
	public float NetworkfontSize
	{
		[Address(RVA = "0x499310", Offset = "0x498510", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60024D1")]
		 get { } //Length: 9
		[Address(RVA = "0x4998E0", Offset = "0x498AE0", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Token(Token = "0x60024D2")]
		 set { } //Length: 104
	}

	[Token(Token = "0x17000B00")]
	public TextJustify Networkjustify
	{
		[Address(RVA = "0x499330", Offset = "0x498530", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60024CD")]
		 get { } //Length: 7
		[Address(RVA = "0x4999C0", Offset = "0x498BC0", Length = "0x65")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400070")]
		[Token(Token = "0x60024CE")]
		 set { } //Length: 101
	}

	[Token(Token = "0x17000B03")]
	public float NetworkmaxFontSize
	{
		[Address(RVA = "0x499340", Offset = "0x498540", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60024D3")]
		 get { } //Length: 9
		[Address(RVA = "0x499A30", Offset = "0x498C30", Length = "0x68")]
		[CalledBy(Type = typeof(UILabel), Member = "set_FontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Token(Token = "0x60024D4")]
		 set { } //Length: 104
	}

	[Token(Token = "0x17000B08")]
	public Color NetworkoutlineColor
	{
		[Address(RVA = "0x499350", Offset = "0x498550", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60024DD")]
		 get { } //Length: 14
		[Address(RVA = "0x499AA0", Offset = "0x498CA0", Length = "0x71")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
		[Token(Token = "0x60024DE")]
		 set { } //Length: 113
	}

	[Token(Token = "0x17000B09")]
	public float NetworkoutlineWidth
	{
		[Address(RVA = "0x499360", Offset = "0x498560", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60024DF")]
		 get { } //Length: 9
		[Address(RVA = "0x499B20", Offset = "0x498D20", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Token(Token = "0x60024E0")]
		 set { } //Length: 104
	}

	[Token(Token = "0x17000B05")]
	public string Networktext
	{
		[Address(RVA = "0x44B4C0", Offset = "0x44A6C0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60024D7")]
		 get { } //Length: 8
		[Address(RVA = "0x499C10", Offset = "0x498E10", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C130")]
		[Token(Token = "0x60024D8")]
		 set { } //Length: 103
	}

	[Token(Token = "0x17000B06")]
	public Color NetworktextColor
	{
		[Address(RVA = "0x4784A0", Offset = "0x4776A0", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60024D9")]
		 get { } //Length: 14
		[Address(RVA = "0x499B90", Offset = "0x498D90", Length = "0x71")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
		[Token(Token = "0x60024DA")]
		 set { } //Length: 113
	}

	[Token(Token = "0x17000B01")]
	public TextVerticalAlign NetworkverticalAlign
	{
		[Address(RVA = "0x499370", Offset = "0x498570", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60024CF")]
		 get { } //Length: 7
		[Address(RVA = "0x499C80", Offset = "0x498E80", Length = "0x65")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400070")]
		[Token(Token = "0x60024D0")]
		 set { } //Length: 101
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000AFE")]
	public Color OutlineColor
	{
		[Address(RVA = "0x499350", Offset = "0x498550", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60024C0")]
		 get { } //Length: 14
		[Address(RVA = "0x499CF0", Offset = "0x498EF0", Length = "0x7A")]
		[CalledBy(Type = typeof(UILabelProxy), Member = "set_OutlineColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
		[Calls(Type = typeof(UILabel), Member = "UpdateOutline", ReturnType = typeof(void))]
		[Token(Token = "0x60024C1")]
		 set { } //Length: 122
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000AFF")]
	public float OutlineWidth
	{
		[Address(RVA = "0x499360", Offset = "0x498560", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60024C2")]
		 get { } //Length: 9
		[Address(RVA = "0x499D70", Offset = "0x498F70", Length = "0x8E")]
		[CalledBy(Type = typeof(UIButton), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIButton), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UILabel), Member = "SyncSetOutlineWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UILabel), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UILabel), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UILabelProxy), Member = "set_OutlineWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Calls(Type = typeof(UILabel), Member = "UpdateOutline", ReturnType = typeof(void))]
		[Token(Token = "0x60024C3")]
		 set { } //Length: 142
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000AF6")]
	public string Text
	{
		[Address(RVA = "0x44B4C0", Offset = "0x44A6C0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60024B0")]
		 get { } //Length: 8
		[Address(RVA = "0x499EB0", Offset = "0x4990B0", Length = "0x9B")]
		[CalledBy(Type = typeof(UIButton), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIButton), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UILabel), Member = "SyncSetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UILabel), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UILabel), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UILabelProxy), Member = "set_Text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C130")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60024B1")]
		 set { } //Length: 155
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000AF7")]
	public Color TextColor
	{
		[Address(RVA = "0x4784A0", Offset = "0x4776A0", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60024B2")]
		 get { } //Length: 14
		[Address(RVA = "0x499E00", Offset = "0x499000", Length = "0xAF")]
		[CalledBy(Type = typeof(UIButton), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIButton), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UILabel), Member = "SyncSetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(Color)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UILabel), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UILabel), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UILabelProxy), Member = "set_TextColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60024B3")]
		 set { } //Length: 175
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000AF9")]
	public TextVerticalAlign VerticalAlign
	{
		[Address(RVA = "0x499370", Offset = "0x498570", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60024B6")]
		 get { } //Length: 7
		[Address(RVA = "0x499F50", Offset = "0x499150", Length = "0xB1")]
		[CalledBy(Type = typeof(UIButton), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UIButton), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UILabel), Member = "SyncSetTextAlign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextVerticalAlign), typeof(TextVerticalAlign)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UILabel), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UILabel), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UILabelProxy), Member = "set_VerticalAlign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextVerticalAlign)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400070")]
		[Calls(Type = typeof(TMP_Text), Member = "set_verticalAlignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VerticalAlignmentOptions)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60024B7")]
		 set { } //Length: 177
	}

	[Address(RVA = "0x498F30", Offset = "0x498130", Length = "0x3C7")]
	[CalledBy(Type = typeof(UIButton), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UIView), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[Token(Token = "0x60024CB")]
	public UILabel() { }

	[Address(RVA = "0x497DB0", Offset = "0x496FB0", Length = "0x90")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UIView), Member = "Awake", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60024C5")]
	protected virtual void Awake() { }

	[Address(RVA = "0x497E50", Offset = "0x497050", Length = "0x1A9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "set_VerticalAlign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextVerticalAlign)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UILabel), Member = "set_OutlineWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UILabel), Member = "UpdateOutline", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[Calls(Type = typeof(UILabel), Member = "set_Font", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextFontPreset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UILabel), Member = "set_AutoSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UILabel), Member = "set_MaxFontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(UILabel), Member = "set_JustifyText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextJustify)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UILabel), Member = "set_TextColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UILabel), Member = "set_Text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIView), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UILabel), Member = "set_FontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x60024C9")]
	protected virtual void CopyProperties(Instance clone) { }

	[Address(RVA = "0x498000", Offset = "0x497200", Length = "0x500")]
	[CalledBy(Type = typeof(UIButton), Member = "DeserializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(Color))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UIView), Member = "DeserializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), typeof(System.Action`2<System.Int32Enum, System.Int32Enum>), "System.Int32Enum"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color&), typeof(System.Action`2<UnityEngine.Color, UnityEngine.Color>), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(System.Action`2<System.Single, System.Single>), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "System.Action`2<T, T>", "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(System.Action`2<System.Object, System.Object>), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60024E2")]
	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	[Address(RVA = "0x499300", Offset = "0x498500", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60024BC")]
	public bool get_AutoSize() { }

	[Address(RVA = "0x499320", Offset = "0x498520", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60024BE")]
	public TextFontPreset get_Font() { }

	[Address(RVA = "0x499310", Offset = "0x498510", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60024B8")]
	public float get_FontSize() { }

	[Address(RVA = "0x499330", Offset = "0x498530", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60024B4")]
	public TextJustify get_JustifyText() { }

	[Address(RVA = "0x499340", Offset = "0x498540", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60024BA")]
	public float get_MaxFontSize() { }

	[Address(RVA = "0x499300", Offset = "0x498500", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60024D5")]
	public bool get_NetworkautoSize() { }

	[Address(RVA = "0x499320", Offset = "0x498520", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60024DB")]
	public TextFontPreset get_Networkfont() { }

	[Address(RVA = "0x499310", Offset = "0x498510", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60024D1")]
	public float get_NetworkfontSize() { }

	[Address(RVA = "0x499330", Offset = "0x498530", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60024CD")]
	public TextJustify get_Networkjustify() { }

	[Address(RVA = "0x499340", Offset = "0x498540", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60024D3")]
	public float get_NetworkmaxFontSize() { }

	[Address(RVA = "0x499350", Offset = "0x498550", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60024DD")]
	public Color get_NetworkoutlineColor() { }

	[Address(RVA = "0x499360", Offset = "0x498560", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60024DF")]
	public float get_NetworkoutlineWidth() { }

	[Address(RVA = "0x44B4C0", Offset = "0x44A6C0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60024D7")]
	public string get_Networktext() { }

	[Address(RVA = "0x4784A0", Offset = "0x4776A0", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60024D9")]
	public Color get_NetworktextColor() { }

	[Address(RVA = "0x499370", Offset = "0x498570", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60024CF")]
	public TextVerticalAlign get_NetworkverticalAlign() { }

	[Address(RVA = "0x499350", Offset = "0x498550", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60024C0")]
	public Color get_OutlineColor() { }

	[Address(RVA = "0x499360", Offset = "0x498560", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60024C2")]
	public float get_OutlineWidth() { }

	[Address(RVA = "0x44B4C0", Offset = "0x44A6C0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60024B0")]
	public string get_Text() { }

	[Address(RVA = "0x4784A0", Offset = "0x4776A0", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60024B2")]
	public Color get_TextColor() { }

	[Address(RVA = "0x499370", Offset = "0x498570", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60024B6")]
	public TextVerticalAlign get_VerticalAlign() { }

	[Address(RVA = "0x498500", Offset = "0x497700", Length = "0x15A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Text), Member = "get_fontMaterial", ReturnType = typeof(Material))]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Instance), Member = "OnDestroy", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60024CA")]
	protected virtual void OnDestroy() { }

	[Address(RVA = "0x498660", Offset = "0x497860", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Instance), Member = "OnHide", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60024C7")]
	protected virtual void OnHide() { }

	[Address(RVA = "0x4986E0", Offset = "0x4978E0", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Instance), Member = "get_Parent", ReturnType = typeof(Instance))]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIView), Member = "OnShow", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60024C8")]
	protected virtual void OnShow() { }

	[Address(RVA = "0x498790", Offset = "0x497990", Length = "0x22C")]
	[CalledBy(Type = typeof(UIButton), Member = "SerializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIView), Member = "SerializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarULong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Color)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60024E1")]
	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	[Address(RVA = "0x499380", Offset = "0x498580", Length = "0x87")]
	[CalledBy(Type = typeof(UIButton), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIButton), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UILabel), Member = "SyncSetAutoSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UILabel), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UILabel), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UILabelProxy), Member = "set_AutoSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
	[Calls(Type = typeof(TMP_Text), Member = "set_enableAutoSizing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60024BD")]
	public void set_AutoSize(bool value) { }

	[Address(RVA = "0x4994C0", Offset = "0x4986C0", Length = "0x120")]
	[CalledBy(Type = typeof(UIButton), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIButton), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UILabel), Member = "SyncSetFont", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextFontPreset), typeof(TextFontPreset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UILabel), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UILabel), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UILabelProxy), Member = "set_Font", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextFontPreset)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400070")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60024BF")]
	public void set_Font(TextFontPreset value) { }

	[Address(RVA = "0x499410", Offset = "0x498610", Length = "0xAF")]
	[CalledBy(Type = typeof(UIButton), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIButton), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UILabel), Member = "SyncSetFontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UILabel), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UILabel), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UILabelProxy), Member = "set_FontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Calls(Type = typeof(UILabel), Member = "set_NetworkmaxFontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "set_fontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60024B9")]
	public void set_FontSize(float value) { }

	[Address(RVA = "0x4996D0", Offset = "0x4988D0", Length = "0xD1")]
	[CalledBy(Type = typeof(UIButton), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIButton), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UILabel), Member = "SyncSetTextJustify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextJustify), typeof(TextJustify)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UILabel), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UILabel), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UILabelProxy), Member = "set_JustifyText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextJustify)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400070")]
	[Calls(Type = typeof(TMP_Text), Member = "set_alignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAlignmentOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60024B5")]
	public void set_JustifyText(TextJustify value) { }

	[Address(RVA = "0x4997B0", Offset = "0x4989B0", Length = "0xBC")]
	[CalledBy(Type = typeof(UIButton), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIButton), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UILabel), Member = "SyncSetMaxFontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UILabel), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UILabel), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UILabelProxy), Member = "set_MaxFontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Calls(Type = typeof(TMP_Text), Member = "set_fontSizeMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "set_fontSizeMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60024BB")]
	public void set_MaxFontSize(float value) { }

	[Address(RVA = "0x499870", Offset = "0x498A70", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
	[Token(Token = "0x60024D6")]
	public void set_NetworkautoSize(in bool value) { }

	[Address(RVA = "0x499950", Offset = "0x498B50", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400070")]
	[Token(Token = "0x60024DC")]
	public void set_Networkfont(in TextFontPreset value) { }

	[Address(RVA = "0x4998E0", Offset = "0x498AE0", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Token(Token = "0x60024D2")]
	public void set_NetworkfontSize(in float value) { }

	[Address(RVA = "0x4999C0", Offset = "0x498BC0", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400070")]
	[Token(Token = "0x60024CE")]
	public void set_Networkjustify(in TextJustify value) { }

	[Address(RVA = "0x499A30", Offset = "0x498C30", Length = "0x68")]
	[CalledBy(Type = typeof(UILabel), Member = "set_FontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Token(Token = "0x60024D4")]
	public void set_NetworkmaxFontSize(in float value) { }

	[Address(RVA = "0x499AA0", Offset = "0x498CA0", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[Token(Token = "0x60024DE")]
	public void set_NetworkoutlineColor(in Color value) { }

	[Address(RVA = "0x499B20", Offset = "0x498D20", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Token(Token = "0x60024E0")]
	public void set_NetworkoutlineWidth(in float value) { }

	[Address(RVA = "0x499C10", Offset = "0x498E10", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C130")]
	[Token(Token = "0x60024D8")]
	public void set_Networktext(in string value) { }

	[Address(RVA = "0x499B90", Offset = "0x498D90", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[Token(Token = "0x60024DA")]
	public void set_NetworktextColor(in Color value) { }

	[Address(RVA = "0x499C80", Offset = "0x498E80", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400070")]
	[Token(Token = "0x60024D0")]
	public void set_NetworkverticalAlign(in TextVerticalAlign value) { }

	[Address(RVA = "0x499CF0", Offset = "0x498EF0", Length = "0x7A")]
	[CalledBy(Type = typeof(UILabelProxy), Member = "set_OutlineColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[Calls(Type = typeof(UILabel), Member = "UpdateOutline", ReturnType = typeof(void))]
	[Token(Token = "0x60024C1")]
	public void set_OutlineColor(Color value) { }

	[Address(RVA = "0x499D70", Offset = "0x498F70", Length = "0x8E")]
	[CalledBy(Type = typeof(UIButton), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIButton), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UILabel), Member = "SyncSetOutlineWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UILabel), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UILabel), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UILabelProxy), Member = "set_OutlineWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Calls(Type = typeof(UILabel), Member = "UpdateOutline", ReturnType = typeof(void))]
	[Token(Token = "0x60024C3")]
	public void set_OutlineWidth(float value) { }

	[Address(RVA = "0x499EB0", Offset = "0x4990B0", Length = "0x9B")]
	[CalledBy(Type = typeof(UIButton), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIButton), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UILabel), Member = "SyncSetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UILabel), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UILabel), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UILabelProxy), Member = "set_Text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C130")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60024B1")]
	public void set_Text(string value) { }

	[Address(RVA = "0x499E00", Offset = "0x499000", Length = "0xAF")]
	[CalledBy(Type = typeof(UIButton), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIButton), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UILabel), Member = "SyncSetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UILabel), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UILabel), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UILabelProxy), Member = "set_TextColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60024B3")]
	public void set_TextColor(Color value) { }

	[Address(RVA = "0x499F50", Offset = "0x499150", Length = "0xB1")]
	[CalledBy(Type = typeof(UIButton), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIButton), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UILabel), Member = "SyncSetTextAlign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextVerticalAlign), typeof(TextVerticalAlign)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UILabel), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UILabel), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UILabelProxy), Member = "set_VerticalAlign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextVerticalAlign)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400070")]
	[Calls(Type = typeof(TMP_Text), Member = "set_verticalAlignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VerticalAlignmentOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60024B7")]
	public void set_VerticalAlign(TextVerticalAlign value) { }

	[Address(RVA = "0x4989C0", Offset = "0x497BC0", Length = "0x130")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIView), Member = "Start", ReturnType = typeof(void))]
	[Calls(Type = typeof(UILabel), Member = "set_Text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UILabel), Member = "set_TextColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UILabel), Member = "set_JustifyText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextJustify)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UILabel), Member = "set_VerticalAlign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextVerticalAlign)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UILabel), Member = "set_FontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UILabel), Member = "set_MaxFontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UILabel), Member = "set_AutoSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UILabel), Member = "set_Font", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextFontPreset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[Calls(Type = typeof(UILabel), Member = "UpdateOutline", ReturnType = typeof(void))]
	[Calls(Type = typeof(UILabel), Member = "set_OutlineWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x60024C6")]
	protected virtual void Start() { }

	[Address(RVA = "0x498AF0", Offset = "0x497CF0", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "set_AutoSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x60024AB")]
	private void SyncSetAutoSize(bool oldValue, bool newValue) { }

	[Address(RVA = "0x498B00", Offset = "0x497D00", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "set_TextColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Token(Token = "0x60024AC")]
	private void SyncSetColor(Color oldValue, Color newValue) { }

	[Address(RVA = "0x498B30", Offset = "0x497D30", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "set_Font", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextFontPreset)}, ReturnType = typeof(void))]
	[Token(Token = "0x60024AD")]
	private void SyncSetFont(TextFontPreset oldValue, TextFontPreset newValue) { }

	[Address(RVA = "0x498B20", Offset = "0x497D20", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "set_FontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x60024A9")]
	private void SyncSetFontSize(float oldValue, float newValue) { }

	[Address(RVA = "0x498B40", Offset = "0x497D40", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "set_MaxFontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x60024AA")]
	private void SyncSetMaxFontSize(float oldValue, float newValue) { }

	[Address(RVA = "0x498B50", Offset = "0x497D50", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60024AE")]
	private void SyncSetOutlineColor(Color oldValue, Color newValue) { }

	[Address(RVA = "0x498BD0", Offset = "0x497DD0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "set_OutlineWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x60024AF")]
	private void SyncSetOutlineWidth(float oldValue, float newValue) { }

	[Address(RVA = "0x498C00", Offset = "0x497E00", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "set_Text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60024A6")]
	private void SyncSetText(string oldtext, string newtext) { }

	[Address(RVA = "0x498BE0", Offset = "0x497DE0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "set_VerticalAlign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextVerticalAlign)}, ReturnType = typeof(void))]
	[Token(Token = "0x60024A8")]
	private void SyncSetTextAlign(TextVerticalAlign oldValue, TextVerticalAlign newValue) { }

	[Address(RVA = "0x498BF0", Offset = "0x497DF0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UILabel), Member = "set_JustifyText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextJustify)}, ReturnType = typeof(void))]
	[Token(Token = "0x60024A7")]
	private void SyncSetTextJustify(TextJustify oldValue, TextJustify newValue) { }

	[Address(RVA = "0x498C10", Offset = "0x497E10", Length = "0x312")]
	[CalledBy(Type = typeof(UIButton), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIButton), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UILabel), Member = "set_OutlineColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UILabel), Member = "set_OutlineWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UILabel), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UILabel), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "SetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "set_fontMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(TMP_Text), Member = "get_fontMaterial", ReturnType = typeof(Material))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Token(Token = "0x60024C4")]
	private void UpdateOutline() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x60024CC")]
	public virtual bool Weaved() { }

}

