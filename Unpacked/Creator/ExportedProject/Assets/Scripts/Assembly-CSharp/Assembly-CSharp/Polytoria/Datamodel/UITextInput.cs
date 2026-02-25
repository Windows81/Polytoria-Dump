namespace Polytoria.Datamodel;

[Instantiatable]
[Token(Token = "0x200036F")]
public class UITextInput : UIView
{
	[FieldOffset(Offset = "0x1F8")]
	[Token(Token = "0x4000EE6")]
	private TMP_InputField inputField; //Field offset: 0x1F8
	[FieldOffset(Offset = "0x200")]
	[Token(Token = "0x4000EE7")]
	private TMP_Text placeholderText; //Field offset: 0x200
	[FieldOffset(Offset = "0x208")]
	[Token(Token = "0x4000EE8")]
	public LuaEvent Changed; //Field offset: 0x208
	[FieldOffset(Offset = "0x210")]
	[Token(Token = "0x4000EE9")]
	public LuaEvent Submitted; //Field offset: 0x210
	[FieldOffset(Offset = "0x218")]
	[SyncVar(hook = "SyncSetTextJustify")]
	[Token(Token = "0x4000EEA")]
	private TextJustify justify; //Field offset: 0x218
	[FieldOffset(Offset = "0x21C")]
	[SyncVar(hook = "SyncSetTextAlign")]
	[Token(Token = "0x4000EEB")]
	private TextVerticalAlign verticalAlign; //Field offset: 0x21C
	[FieldOffset(Offset = "0x220")]
	[SyncVar(hook = "SyncSetFontSize")]
	[Token(Token = "0x4000EEC")]
	private float fontSize; //Field offset: 0x220
	[FieldOffset(Offset = "0x224")]
	[SyncVar(hook = "SyncSetMaxFontSize")]
	[Token(Token = "0x4000EED")]
	private float maxFontSize; //Field offset: 0x224
	[FieldOffset(Offset = "0x228")]
	[SyncVar(hook = "SyncSetAutoSize")]
	[Token(Token = "0x4000EEE")]
	private bool autoSize; //Field offset: 0x228
	[FieldOffset(Offset = "0x230")]
	[SyncVar(hook = "SyncSetText")]
	[Token(Token = "0x4000EEF")]
	private string text; //Field offset: 0x230
	[FieldOffset(Offset = "0x238")]
	[SyncVar(hook = "SyncSetColor")]
	[Token(Token = "0x4000EF0")]
	private Color textColor; //Field offset: 0x238
	[FieldOffset(Offset = "0x248")]
	[SyncVar(hook = "SyncSetFont")]
	[Token(Token = "0x4000EF1")]
	private TextFontPreset font; //Field offset: 0x248
	[FieldOffset(Offset = "0x250")]
	[SyncVar(hook = "SyncSetPlaceholder")]
	[Token(Token = "0x4000EF2")]
	private string placeholder; //Field offset: 0x250
	[FieldOffset(Offset = "0x258")]
	[SyncVar(hook = "SyncSetPlaceholderColor")]
	[Token(Token = "0x4000EF3")]
	private Color placeholderColor; //Field offset: 0x258
	[FieldOffset(Offset = "0x268")]
	[SyncVar(hook = "SyncSetIsReadOnly")]
	[Token(Token = "0x4000EF4")]
	private bool isReadOnly; //Field offset: 0x268
	[FieldOffset(Offset = "0x269")]
	[SyncVar(hook = "SyncSetIsMultiline")]
	[Token(Token = "0x4000EF5")]
	private bool isMultiline; //Field offset: 0x269
	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x4000EF6")]
	public Action<TextJustify, TextJustify> _Mirror_SyncVarHookDelegate_justify; //Field offset: 0x270
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4000EF7")]
	public Action<TextVerticalAlign, TextVerticalAlign> _Mirror_SyncVarHookDelegate_verticalAlign; //Field offset: 0x278
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x4000EF8")]
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_fontSize; //Field offset: 0x280
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x4000EF9")]
	public Action<Single, Single> _Mirror_SyncVarHookDelegate_maxFontSize; //Field offset: 0x288
	[FieldOffset(Offset = "0x290")]
	[Token(Token = "0x4000EFA")]
	public Action<Boolean, Boolean> _Mirror_SyncVarHookDelegate_autoSize; //Field offset: 0x290
	[FieldOffset(Offset = "0x298")]
	[Token(Token = "0x4000EFB")]
	public Action<String, String> _Mirror_SyncVarHookDelegate_text; //Field offset: 0x298
	[FieldOffset(Offset = "0x2A0")]
	[Token(Token = "0x4000EFC")]
	public Action<Color, Color> _Mirror_SyncVarHookDelegate_textColor; //Field offset: 0x2A0
	[FieldOffset(Offset = "0x2A8")]
	[Token(Token = "0x4000EFD")]
	public Action<TextFontPreset, TextFontPreset> _Mirror_SyncVarHookDelegate_font; //Field offset: 0x2A8
	[FieldOffset(Offset = "0x2B0")]
	[Token(Token = "0x4000EFE")]
	public Action<String, String> _Mirror_SyncVarHookDelegate_placeholder; //Field offset: 0x2B0
	[FieldOffset(Offset = "0x2B8")]
	[Token(Token = "0x4000EFF")]
	public Action<Color, Color> _Mirror_SyncVarHookDelegate_placeholderColor; //Field offset: 0x2B8
	[FieldOffset(Offset = "0x2C0")]
	[Token(Token = "0x4000F00")]
	public Action<Boolean, Boolean> _Mirror_SyncVarHookDelegate_isReadOnly; //Field offset: 0x2C0
	[FieldOffset(Offset = "0x2C8")]
	[Token(Token = "0x4000F01")]
	public Action<Boolean, Boolean> _Mirror_SyncVarHookDelegate_isMultiline; //Field offset: 0x2C8

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000B10")]
	public bool AutoSize
	{
		[Address(RVA = "0x468BB0", Offset = "0x467DB0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60024EF")]
		 get { } //Length: 8
		[Address(RVA = "0x49B780", Offset = "0x49A980", Length = "0xAE")]
		[CalledBy(Type = typeof(UITextInput), Member = "SyncSetAutoSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UITextInput), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UITextInput), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UITextInputProxy), Member = "set_AutoSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
		[Calls(Type = typeof(TMP_Text), Member = "set_enableAutoSizing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60024F0")]
		 set { } //Length: 174
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000B11")]
	public TextFontPreset Font
	{
		[Address(RVA = "0x49B6A0", Offset = "0x49A8A0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60024F1")]
		 get { } //Length: 7
		[Address(RVA = "0x49B920", Offset = "0x49AB20", Length = "0x120")]
		[CalledBy(Type = typeof(UITextInput), Member = "SyncSetFont", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextFontPreset), typeof(TextFontPreset)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UITextInput), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UITextInput), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UITextInputProxy), Member = "set_Font", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextFontPreset)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400070")]
		[ContainsInvalidInstructions]
		[Token(Token = "0x60024F2")]
		 set { } //Length: 288
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000B0E")]
	public float FontSize
	{
		[Address(RVA = "0x404EF0", Offset = "0x4040F0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60024EB")]
		 get { } //Length: 9
		[Address(RVA = "0x49B830", Offset = "0x49AA30", Length = "0xEF")]
		[CalledBy(Type = typeof(UITextInput), Member = "SyncSetFontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UITextInput), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UITextInput), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UITextInputProxy), Member = "set_FontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Calls(Type = typeof(UITextInput), Member = "set_NetworkmaxFontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TMP_Text), Member = "set_fontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60024EC")]
		 set { } //Length: 239
	}

	[Token(Token = "0x17000B16")]
	public bool IsFocused
	{
		[Address(RVA = "0x49B6B0", Offset = "0x49A8B0", Length = "0x21")]
		[CalledBy(Type = typeof(UITextInputProxy), Member = "get_IsFocused", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60024FB")]
		 get { } //Length: 33
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000B14")]
	public bool IsMultiline
	{
		[Address(RVA = "0x49B6E0", Offset = "0x49A8E0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60024F7")]
		 get { } //Length: 8
		[Address(RVA = "0x49BEE0", Offset = "0x49B0E0", Length = "0x8E")]
		[CalledBy(Type = typeof(UITextInput), Member = "SyncSetIsMultiline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UITextInput), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UITextInputProxy), Member = "set_IsMultiline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
		[Calls(Type = typeof(TMP_InputField), Member = "set_lineType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LineType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60024F8")]
		 set { } //Length: 142
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000B15")]
	public bool IsReadOnly
	{
		[Address(RVA = "0x49B6F0", Offset = "0x49A8F0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60024F9")]
		 get { } //Length: 8
		[Address(RVA = "0x49BF70", Offset = "0x49B170", Length = "0x86")]
		[CalledBy(Type = typeof(UITextInput), Member = "SyncSetIsReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UITextInput), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UITextInputProxy), Member = "set_IsReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60024FA")]
		 set { } //Length: 134
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000B0C")]
	public TextJustify JustifyText
	{
		[Address(RVA = "0x408990", Offset = "0x407B90", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60024E7")]
		 get { } //Length: 7
		[Address(RVA = "0x49C000", Offset = "0x49B200", Length = "0x111")]
		[CalledBy(Type = typeof(UITextInput), Member = "SyncSetTextJustify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextJustify), typeof(TextJustify)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UITextInput), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UITextInput), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UITextInputProxy), Member = "set_JustifyText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextJustify)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400070")]
		[Calls(Type = typeof(TMP_Text), Member = "set_alignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAlignmentOptions)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TMP_Text), Member = "get_alignment", ReturnType = typeof(TextAlignmentOptions))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60024E8")]
		 set { } //Length: 273
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000B0F")]
	public float MaxFontSize
	{
		[Address(RVA = "0x49B700", Offset = "0x49A900", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60024ED")]
		 get { } //Length: 9
		[Address(RVA = "0x49C120", Offset = "0x49B320", Length = "0x14C")]
		[CalledBy(Type = typeof(UITextInput), Member = "SyncSetMaxFontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UITextInput), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UITextInput), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UITextInputProxy), Member = "set_MaxFontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Calls(Type = typeof(TMP_Text), Member = "set_fontSizeMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TMP_Text), Member = "set_fontSizeMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60024EE")]
		 set { } //Length: 332
	}

	[Token(Token = "0x17000B1B")]
	public bool NetworkautoSize
	{
		[Address(RVA = "0x468BB0", Offset = "0x467DB0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600251A")]
		 get { } //Length: 8
		[Address(RVA = "0x49C270", Offset = "0x49B470", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
		[Token(Token = "0x600251B")]
		 set { } //Length: 104
	}

	[Token(Token = "0x17000B1E")]
	public TextFontPreset Networkfont
	{
		[Address(RVA = "0x49B6A0", Offset = "0x49A8A0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002520")]
		 get { } //Length: 7
		[Address(RVA = "0x49C350", Offset = "0x49B550", Length = "0x65")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400070")]
		[Token(Token = "0x6002521")]
		 set { } //Length: 101
	}

	[Token(Token = "0x17000B19")]
	public float NetworkfontSize
	{
		[Address(RVA = "0x404EF0", Offset = "0x4040F0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002516")]
		 get { } //Length: 9
		[Address(RVA = "0x49C2E0", Offset = "0x49B4E0", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Token(Token = "0x6002517")]
		 set { } //Length: 104
	}

	[Token(Token = "0x17000B22")]
	public bool NetworkisMultiline
	{
		[Address(RVA = "0x49B6E0", Offset = "0x49A8E0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002528")]
		 get { } //Length: 8
		[Address(RVA = "0x49C3C0", Offset = "0x49B5C0", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
		[Token(Token = "0x6002529")]
		 set { } //Length: 104
	}

	[Token(Token = "0x17000B21")]
	public bool NetworkisReadOnly
	{
		[Address(RVA = "0x49B6F0", Offset = "0x49A8F0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002526")]
		 get { } //Length: 8
		[Address(RVA = "0x49C430", Offset = "0x49B630", Length = "0x68")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
		[Token(Token = "0x6002527")]
		 set { } //Length: 104
	}

	[Token(Token = "0x17000B17")]
	public TextJustify Networkjustify
	{
		[Address(RVA = "0x408990", Offset = "0x407B90", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002512")]
		 get { } //Length: 7
		[Address(RVA = "0x49C4A0", Offset = "0x49B6A0", Length = "0x65")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400070")]
		[Token(Token = "0x6002513")]
		 set { } //Length: 101
	}

	[Token(Token = "0x17000B1A")]
	public float NetworkmaxFontSize
	{
		[Address(RVA = "0x49B700", Offset = "0x49A900", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002518")]
		 get { } //Length: 9
		[Address(RVA = "0x49C510", Offset = "0x49B710", Length = "0x68")]
		[CalledBy(Type = typeof(UITextInput), Member = "set_FontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
		[Token(Token = "0x6002519")]
		 set { } //Length: 104
	}

	[Token(Token = "0x17000B1F")]
	public string Networkplaceholder
	{
		[Address(RVA = "0x438B40", Offset = "0x437D40", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002522")]
		 get { } //Length: 8
		[Address(RVA = "0x49C600", Offset = "0x49B800", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C130")]
		[Token(Token = "0x6002523")]
		 set { } //Length: 103
	}

	[Token(Token = "0x17000B20")]
	public Color NetworkplaceholderColor
	{
		[Address(RVA = "0x49B710", Offset = "0x49A910", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002524")]
		 get { } //Length: 14
		[Address(RVA = "0x49C580", Offset = "0x49B780", Length = "0x71")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
		[Token(Token = "0x6002525")]
		 set { } //Length: 113
	}

	[Token(Token = "0x17000B1C")]
	public string Networktext
	{
		[Address(RVA = "0x49B730", Offset = "0x49A930", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600251C")]
		 get { } //Length: 8
		[Address(RVA = "0x49C6F0", Offset = "0x49B8F0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C130")]
		[Token(Token = "0x600251D")]
		 set { } //Length: 103
	}

	[Token(Token = "0x17000B1D")]
	public Color NetworktextColor
	{
		[Address(RVA = "0x49B720", Offset = "0x49A920", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600251E")]
		 get { } //Length: 14
		[Address(RVA = "0x49C670", Offset = "0x49B870", Length = "0x71")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
		[Token(Token = "0x600251F")]
		 set { } //Length: 113
	}

	[Token(Token = "0x17000B18")]
	public TextVerticalAlign NetworkverticalAlign
	{
		[Address(RVA = "0x49B740", Offset = "0x49A940", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002514")]
		 get { } //Length: 7
		[Address(RVA = "0x49C760", Offset = "0x49B960", Length = "0x65")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400070")]
		[Token(Token = "0x6002515")]
		 set { } //Length: 101
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000B12")]
	public string Placeholder
	{
		[Address(RVA = "0x438B40", Offset = "0x437D40", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60024F3")]
		 get { } //Length: 8
		[Address(RVA = "0x49C880", Offset = "0x49BA80", Length = "0x92")]
		[CalledBy(Type = typeof(UITextInput), Member = "SyncSetPlaceholder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UITextInput), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UITextInput), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UITextInputProxy), Member = "set_Placeholder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C130")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60024F4")]
		 set { } //Length: 146
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000B13")]
	public Color PlaceholderColor
	{
		[Address(RVA = "0x49B710", Offset = "0x49A910", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60024F5")]
		 get { } //Length: 14
		[Address(RVA = "0x49C7D0", Offset = "0x49B9D0", Length = "0xA6")]
		[CalledBy(Type = typeof(UITextInputProxy), Member = "set_PlaceholderColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60024F6")]
		 set { } //Length: 166
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000B0A")]
	public string Text
	{
		[Address(RVA = "0x49B750", Offset = "0x49A950", Length = "0x21")]
		[CalledBy(Type = typeof(UITextInputProxy), Member = "get_Text", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60024E3")]
		 get { } //Length: 33
		[Address(RVA = "0x49C9E0", Offset = "0x49BBE0", Length = "0x8F")]
		[CalledBy(Type = typeof(UITextInput), Member = "SyncSetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UITextInput), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UITextInput), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UITextInputProxy), Member = "set_Text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C130")]
		[Calls(Type = typeof(TMP_InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60024E4")]
		 set { } //Length: 143
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000B0B")]
	public Color TextColor
	{
		[Address(RVA = "0x49B720", Offset = "0x49A920", Length = "0xE")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60024E5")]
		 get { } //Length: 14
		[Address(RVA = "0x49C920", Offset = "0x49BB20", Length = "0xBF")]
		[CalledBy(Type = typeof(UITextInput), Member = "SyncSetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(Color)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UITextInput), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UITextInput), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UITextInputProxy), Member = "set_TextColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60024E6")]
		 set { } //Length: 191
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000B0D")]
	public TextVerticalAlign VerticalAlign
	{
		[Address(RVA = "0x49B740", Offset = "0x49A940", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60024E9")]
		 get { } //Length: 7
		[Address(RVA = "0x49CA70", Offset = "0x49BC70", Length = "0xF3")]
		[CalledBy(Type = typeof(UITextInput), Member = "SyncSetTextAlign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextVerticalAlign), typeof(TextVerticalAlign)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UITextInput), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UITextInput), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UITextInputProxy), Member = "set_VerticalAlign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextVerticalAlign)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400070")]
		[Calls(Type = typeof(TMP_Text), Member = "set_verticalAlignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VerticalAlignmentOptions)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60024EA")]
		 set { } //Length: 243
	}

	[Address(RVA = "0x49B1B0", Offset = "0x49A3B0", Length = "0x4EC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(LuaEvent), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UIView), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[Token(Token = "0x600250E")]
	public UITextInput() { }

	[Address(RVA = "0x49B030", Offset = "0x49A230", Length = "0xBD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(LuaEvent), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CompilerGenerated]
	[Token(Token = "0x600250F")]
	private void <Awake>b__67_0(string s) { }

	[Address(RVA = "0x49B0F0", Offset = "0x49A2F0", Length = "0xBD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(LuaEvent), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CompilerGenerated]
	[Token(Token = "0x6002510")]
	private void <Awake>b__67_1(string s) { }

	[Address(RVA = "0x49A010", Offset = "0x499210", Length = "0x250")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UIView), Member = "Awake", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Selectable), Member = "set_interactable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UnityEvent`1), Member = "AddListener", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Events.UnityAction`1<T0>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002509")]
	protected virtual void Awake() { }

	[Address(RVA = "0x49A270", Offset = "0x499470", Length = "0x207")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITextInput), Member = "set_FontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UITextInput), Member = "set_IsReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[Calls(Type = typeof(UITextInput), Member = "set_Placeholder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UITextInput), Member = "set_Font", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextFontPreset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UITextInput), Member = "set_AutoSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UITextInput), Member = "set_MaxFontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UITextInput), Member = "set_VerticalAlign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextVerticalAlign)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UITextInput), Member = "set_IsMultiline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UITextInput), Member = "set_JustifyText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextJustify)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UITextInput), Member = "set_TextColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UITextInput), Member = "set_Text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIView), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600250D")]
	protected virtual void CopyProperties(Instance clone) { }

	[Address(RVA = "0x49A480", Offset = "0x499680", Length = "0x5D9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UIView), Member = "DeserializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), typeof(System.Action`2<System.Int32Enum, System.Int32Enum>), "System.Int32Enum"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(System.Action`2<System.Single, System.Single>), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "System.Action`2<T, T>", "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(System.Action`2<System.Object, System.Object>), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(Color))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color&), typeof(System.Action`2<UnityEngine.Color, UnityEngine.Color>), typeof(Color)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600252B")]
	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	[Address(RVA = "0x49AA60", Offset = "0x499C60", Length = "0x20")]
	[CalledBy(Type = typeof(UITextInputProxy), Member = "Focus", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_InputField), Member = "ActivateInputField", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60024FC")]
	public void Focus() { }

	[Address(RVA = "0x468BB0", Offset = "0x467DB0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60024EF")]
	public bool get_AutoSize() { }

	[Address(RVA = "0x49B6A0", Offset = "0x49A8A0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60024F1")]
	public TextFontPreset get_Font() { }

	[Address(RVA = "0x404EF0", Offset = "0x4040F0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60024EB")]
	public float get_FontSize() { }

	[Address(RVA = "0x49B6B0", Offset = "0x49A8B0", Length = "0x21")]
	[CalledBy(Type = typeof(UITextInputProxy), Member = "get_IsFocused", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60024FB")]
	public bool get_IsFocused() { }

	[Address(RVA = "0x49B6E0", Offset = "0x49A8E0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60024F7")]
	public bool get_IsMultiline() { }

	[Address(RVA = "0x49B6F0", Offset = "0x49A8F0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60024F9")]
	public bool get_IsReadOnly() { }

	[Address(RVA = "0x408990", Offset = "0x407B90", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60024E7")]
	public TextJustify get_JustifyText() { }

	[Address(RVA = "0x49B700", Offset = "0x49A900", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60024ED")]
	public float get_MaxFontSize() { }

	[Address(RVA = "0x468BB0", Offset = "0x467DB0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600251A")]
	public bool get_NetworkautoSize() { }

	[Address(RVA = "0x49B6A0", Offset = "0x49A8A0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002520")]
	public TextFontPreset get_Networkfont() { }

	[Address(RVA = "0x404EF0", Offset = "0x4040F0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002516")]
	public float get_NetworkfontSize() { }

	[Address(RVA = "0x49B6E0", Offset = "0x49A8E0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002528")]
	public bool get_NetworkisMultiline() { }

	[Address(RVA = "0x49B6F0", Offset = "0x49A8F0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002526")]
	public bool get_NetworkisReadOnly() { }

	[Address(RVA = "0x408990", Offset = "0x407B90", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002512")]
	public TextJustify get_Networkjustify() { }

	[Address(RVA = "0x49B700", Offset = "0x49A900", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002518")]
	public float get_NetworkmaxFontSize() { }

	[Address(RVA = "0x438B40", Offset = "0x437D40", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002522")]
	public string get_Networkplaceholder() { }

	[Address(RVA = "0x49B710", Offset = "0x49A910", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002524")]
	public Color get_NetworkplaceholderColor() { }

	[Address(RVA = "0x49B730", Offset = "0x49A930", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600251C")]
	public string get_Networktext() { }

	[Address(RVA = "0x49B720", Offset = "0x49A920", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600251E")]
	public Color get_NetworktextColor() { }

	[Address(RVA = "0x49B740", Offset = "0x49A940", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002514")]
	public TextVerticalAlign get_NetworkverticalAlign() { }

	[Address(RVA = "0x438B40", Offset = "0x437D40", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60024F3")]
	public string get_Placeholder() { }

	[Address(RVA = "0x49B710", Offset = "0x49A910", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60024F5")]
	public Color get_PlaceholderColor() { }

	[Address(RVA = "0x49B750", Offset = "0x49A950", Length = "0x21")]
	[CalledBy(Type = typeof(UITextInputProxy), Member = "get_Text", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60024E3")]
	public string get_Text() { }

	[Address(RVA = "0x49B720", Offset = "0x49A920", Length = "0xE")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60024E5")]
	public Color get_TextColor() { }

	[Address(RVA = "0x49B740", Offset = "0x49A940", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60024E9")]
	public TextVerticalAlign get_VerticalAlign() { }

	[Address(RVA = "0x498660", Offset = "0x497860", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Instance), Member = "OnHide", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600250B")]
	protected virtual void OnHide() { }

	[Address(RVA = "0x49AA90", Offset = "0x499C90", Length = "0x3F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIView), Member = "OnShow", ReturnType = typeof(void))]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600250C")]
	protected virtual void OnShow() { }

	[Address(RVA = "0x49AAD0", Offset = "0x499CD0", Length = "0x287")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIView), Member = "SerializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarULong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(Color)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600252A")]
	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	[Address(RVA = "0x49B780", Offset = "0x49A980", Length = "0xAE")]
	[CalledBy(Type = typeof(UITextInput), Member = "SyncSetAutoSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITextInput), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITextInput), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITextInputProxy), Member = "set_AutoSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
	[Calls(Type = typeof(TMP_Text), Member = "set_enableAutoSizing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60024F0")]
	public void set_AutoSize(bool value) { }

	[Address(RVA = "0x49B920", Offset = "0x49AB20", Length = "0x120")]
	[CalledBy(Type = typeof(UITextInput), Member = "SyncSetFont", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextFontPreset), typeof(TextFontPreset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITextInput), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITextInput), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITextInputProxy), Member = "set_Font", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextFontPreset)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400070")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60024F2")]
	public void set_Font(TextFontPreset value) { }

	[Address(RVA = "0x49B830", Offset = "0x49AA30", Length = "0xEF")]
	[CalledBy(Type = typeof(UITextInput), Member = "SyncSetFontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITextInput), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITextInput), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITextInputProxy), Member = "set_FontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Calls(Type = typeof(UITextInput), Member = "set_NetworkmaxFontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "set_fontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60024EC")]
	public void set_FontSize(float value) { }

	[Address(RVA = "0x49BEE0", Offset = "0x49B0E0", Length = "0x8E")]
	[CalledBy(Type = typeof(UITextInput), Member = "SyncSetIsMultiline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITextInput), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITextInputProxy), Member = "set_IsMultiline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
	[Calls(Type = typeof(TMP_InputField), Member = "set_lineType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LineType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60024F8")]
	public void set_IsMultiline(bool value) { }

	[Address(RVA = "0x49BF70", Offset = "0x49B170", Length = "0x86")]
	[CalledBy(Type = typeof(UITextInput), Member = "SyncSetIsReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITextInput), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITextInputProxy), Member = "set_IsReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60024FA")]
	public void set_IsReadOnly(bool value) { }

	[Address(RVA = "0x49C000", Offset = "0x49B200", Length = "0x111")]
	[CalledBy(Type = typeof(UITextInput), Member = "SyncSetTextJustify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextJustify), typeof(TextJustify)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITextInput), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITextInput), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITextInputProxy), Member = "set_JustifyText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextJustify)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400070")]
	[Calls(Type = typeof(TMP_Text), Member = "set_alignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAlignmentOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "get_alignment", ReturnType = typeof(TextAlignmentOptions))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60024E8")]
	public void set_JustifyText(TextJustify value) { }

	[Address(RVA = "0x49C120", Offset = "0x49B320", Length = "0x14C")]
	[CalledBy(Type = typeof(UITextInput), Member = "SyncSetMaxFontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITextInput), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITextInput), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITextInputProxy), Member = "set_MaxFontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Calls(Type = typeof(TMP_Text), Member = "set_fontSizeMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "set_fontSizeMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60024EE")]
	public void set_MaxFontSize(float value) { }

	[Address(RVA = "0x49C270", Offset = "0x49B470", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
	[Token(Token = "0x600251B")]
	public void set_NetworkautoSize(in bool value) { }

	[Address(RVA = "0x49C350", Offset = "0x49B550", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400070")]
	[Token(Token = "0x6002521")]
	public void set_Networkfont(in TextFontPreset value) { }

	[Address(RVA = "0x49C2E0", Offset = "0x49B4E0", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Token(Token = "0x6002517")]
	public void set_NetworkfontSize(in float value) { }

	[Address(RVA = "0x49C3C0", Offset = "0x49B5C0", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
	[Token(Token = "0x6002529")]
	public void set_NetworkisMultiline(in bool value) { }

	[Address(RVA = "0x49C430", Offset = "0x49B630", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BD90")]
	[Token(Token = "0x6002527")]
	public void set_NetworkisReadOnly(in bool value) { }

	[Address(RVA = "0x49C4A0", Offset = "0x49B6A0", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400070")]
	[Token(Token = "0x6002513")]
	public void set_Networkjustify(in TextJustify value) { }

	[Address(RVA = "0x49C510", Offset = "0x49B710", Length = "0x68")]
	[CalledBy(Type = typeof(UITextInput), Member = "set_FontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C000")]
	[Token(Token = "0x6002519")]
	public void set_NetworkmaxFontSize(in float value) { }

	[Address(RVA = "0x49C600", Offset = "0x49B800", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C130")]
	[Token(Token = "0x6002523")]
	public void set_Networkplaceholder(in string value) { }

	[Address(RVA = "0x49C580", Offset = "0x49B780", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[Token(Token = "0x6002525")]
	public void set_NetworkplaceholderColor(in Color value) { }

	[Address(RVA = "0x49C6F0", Offset = "0x49B8F0", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C130")]
	[Token(Token = "0x600251D")]
	public void set_Networktext(in string value) { }

	[Address(RVA = "0x49C670", Offset = "0x49B870", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[Token(Token = "0x600251F")]
	public void set_NetworktextColor(in Color value) { }

	[Address(RVA = "0x49C760", Offset = "0x49B960", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400070")]
	[Token(Token = "0x6002515")]
	public void set_NetworkverticalAlign(in TextVerticalAlign value) { }

	[Address(RVA = "0x49C880", Offset = "0x49BA80", Length = "0x92")]
	[CalledBy(Type = typeof(UITextInput), Member = "SyncSetPlaceholder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITextInput), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITextInput), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITextInputProxy), Member = "set_Placeholder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C130")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60024F4")]
	public void set_Placeholder(string value) { }

	[Address(RVA = "0x49C7D0", Offset = "0x49B9D0", Length = "0xA6")]
	[CalledBy(Type = typeof(UITextInputProxy), Member = "set_PlaceholderColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60024F6")]
	public void set_PlaceholderColor(Color value) { }

	[Address(RVA = "0x49C9E0", Offset = "0x49BBE0", Length = "0x8F")]
	[CalledBy(Type = typeof(UITextInput), Member = "SyncSetText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITextInput), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITextInput), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITextInputProxy), Member = "set_Text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C130")]
	[Calls(Type = typeof(TMP_InputField), Member = "set_text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60024E4")]
	public void set_Text(string value) { }

	[Address(RVA = "0x49C920", Offset = "0x49BB20", Length = "0xBF")]
	[CalledBy(Type = typeof(UITextInput), Member = "SyncSetColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color), typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITextInput), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITextInput), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITextInputProxy), Member = "set_TextColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60024E6")]
	public void set_TextColor(Color value) { }

	[Address(RVA = "0x49CA70", Offset = "0x49BC70", Length = "0xF3")]
	[CalledBy(Type = typeof(UITextInput), Member = "SyncSetTextAlign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextVerticalAlign), typeof(TextVerticalAlign)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITextInput), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITextInput), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITextInputProxy), Member = "set_VerticalAlign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextVerticalAlign)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180400070")]
	[Calls(Type = typeof(TMP_Text), Member = "set_verticalAlignment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VerticalAlignmentOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60024EA")]
	public void set_VerticalAlign(TextVerticalAlign value) { }

	[Address(RVA = "0x49AD60", Offset = "0x499F60", Length = "0x15B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITextInput), Member = "set_MaxFontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIView), Member = "Start", ReturnType = typeof(void))]
	[Calls(Type = typeof(UITextInput), Member = "set_Text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UITextInput), Member = "set_JustifyText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextJustify)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UITextInput), Member = "set_VerticalAlign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextVerticalAlign)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UITextInput), Member = "set_FontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(UITextInput), Member = "set_AutoSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UITextInput), Member = "set_TextColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UITextInput), Member = "set_Font", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextFontPreset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UITextInput), Member = "set_Placeholder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600250A")]
	protected virtual void Start() { }

	[Address(RVA = "0x49AEC0", Offset = "0x49A0C0", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITextInput), Member = "set_AutoSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002502")]
	private void SyncSetAutoSize(bool oldValue, bool newValue) { }

	[Address(RVA = "0x49AED0", Offset = "0x49A0D0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITextInput), Member = "set_TextColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002503")]
	private void SyncSetColor(Color oldValue, Color newValue) { }

	[Address(RVA = "0x49AF00", Offset = "0x49A100", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITextInput), Member = "set_Font", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextFontPreset)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002504")]
	private void SyncSetFont(TextFontPreset oldValue, TextFontPreset newValue) { }

	[Address(RVA = "0x49AEF0", Offset = "0x49A0F0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITextInput), Member = "set_FontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002500")]
	private void SyncSetFontSize(float oldValue, float newValue) { }

	[Address(RVA = "0x49AF10", Offset = "0x49A110", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITextInput), Member = "set_IsMultiline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002507")]
	private void SyncSetIsMultiline(bool oldValue, bool newValue) { }

	[Address(RVA = "0x49AF20", Offset = "0x49A120", Length = "0xC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITextInput), Member = "set_IsReadOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002508")]
	private void SyncSetIsReadOnly(bool oldValue, bool newValue) { }

	[Address(RVA = "0x49AF30", Offset = "0x49A130", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITextInput), Member = "set_MaxFontSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002501")]
	private void SyncSetMaxFontSize(float oldValue, float newValue) { }

	[Address(RVA = "0x49AFF0", Offset = "0x49A1F0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITextInput), Member = "set_Placeholder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002505")]
	private void SyncSetPlaceholder(string oldValue, string newValue) { }

	[Address(RVA = "0x49AF40", Offset = "0x49A140", Length = "0xA6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001BEB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002506")]
	private void SyncSetPlaceholderColor(Color oldValue, Color newValue) { }

	[Address(RVA = "0x49B020", Offset = "0x49A220", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITextInput), Member = "set_Text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60024FD")]
	private void SyncSetText(string oldtext, string newtext) { }

	[Address(RVA = "0x49B000", Offset = "0x49A200", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITextInput), Member = "set_VerticalAlign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextVerticalAlign)}, ReturnType = typeof(void))]
	[Token(Token = "0x60024FF")]
	private void SyncSetTextAlign(TextVerticalAlign oldValue, TextVerticalAlign newValue) { }

	[Address(RVA = "0x49B010", Offset = "0x49A210", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UITextInput), Member = "set_JustifyText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextJustify)}, ReturnType = typeof(void))]
	[Token(Token = "0x60024FE")]
	private void SyncSetTextJustify(TextJustify oldValue, TextJustify newValue) { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002511")]
	public virtual bool Weaved() { }

}

