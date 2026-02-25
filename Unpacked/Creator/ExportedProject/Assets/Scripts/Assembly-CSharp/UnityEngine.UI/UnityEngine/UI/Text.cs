namespace UnityEngine.UI;

[AddComponentMenu("UI/Legacy/Text", 100)]
[RequireComponent(typeof(CanvasRenderer))]
[Token(Token = "0x2000074")]
public class Text : MaskableGraphic, ILayoutElement
{
	[Token(Token = "0x400024D")]
	protected static Material s_DefaultText; //Field offset: 0x0
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	[Token(Token = "0x4000249")]
	private FontData m_FontData; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	[TextArea(3, 10)]
	[Token(Token = "0x400024A")]
	protected string m_Text; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x400024B")]
	private TextGenerator m_TextCache; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x400024C")]
	private TextGenerator m_TextCacheForLayout; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x400024E")]
	protected bool m_DisableFontTextureRebuiltCallback; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x400024F")]
	private readonly UIVertex[] m_TempVerts; //Field offset: 0x108

	[Token(Token = "0x17000141")]
	public bool alignByGeometry
	{
		[Address(RVA = "0x1CDA570", Offset = "0x1CD9770", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60004BF")]
		 get { } //Length: 30
		[Address(RVA = "0x1CDADC0", Offset = "0x1CD9FC0", Length = "0x3A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60004C0")]
		 set { } //Length: 58
	}

	[Token(Token = "0x17000140")]
	public TextAnchor alignment
	{
		[Address(RVA = "0x1CDA590", Offset = "0x1CD9790", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60004BD")]
		 get { } //Length: 29
		[Address(RVA = "0x1CDAE00", Offset = "0x1CDA000", Length = "0x57")]
		[CalledBy(Type = typeof(DefaultControls), Member = "CreateButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CalledBy(Type = typeof(DefaultControls), Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60004BE")]
		 set { } //Length: 87
	}

	[Token(Token = "0x17000137")]
	public TextGenerator cachedTextGenerator
	{
		[Address(RVA = "0x1CDA630", Offset = "0x1CD9830", Length = "0xAC")]
		[CalledBy(Type = typeof(InputField), Member = "GetCharacterIndexFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(InputField), Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputField), Member = "GenerateHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Text), Member = "FontTextureChanged", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Text), Member = "OnEnable", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Text), Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(TextGenerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TextGenerator), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60004AD")]
		 get { } //Length: 172
	}

	[Token(Token = "0x17000138")]
	public TextGenerator cachedTextGeneratorForLayout
	{
		[Address(RVA = "0x1CDA5B0", Offset = "0x1CD97B0", Length = "0x73")]
		[CalledBy(Type = typeof(InputField), Member = "get_preferredWidth", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(InputField), Member = "get_preferredHeight", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(Text), Member = "get_preferredWidth", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(Text), Member = "get_preferredHeight", ReturnType = typeof(float))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(TextGenerator), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60004AE")]
		 get { } //Length: 115
	}

	[Token(Token = "0x1700014D")]
	public override float flexibleHeight
	{
		[Address(RVA = "0x18B16D0", Offset = "0x18B08D0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004DB")]
		 get { } //Length: 9
	}

	[Token(Token = "0x1700014A")]
	public override float flexibleWidth
	{
		[Address(RVA = "0x18B16D0", Offset = "0x18B08D0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004D8")]
		 get { } //Length: 9
	}

	[Token(Token = "0x1700013A")]
	public Font font
	{
		[Address(RVA = "0x1CDA720", Offset = "0x1CD9920", Length = "0x1E")]
		[CalledBy(Type = typeof(DefaultControls), Member = "SetDefaultTextValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FontUpdateTracker), Member = "TrackText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FontUpdateTracker), Member = "UntrackText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "UnityEngine.UI.InputField+EditState")]
		[CalledBy(Type = typeof(InputField), Member = "IsValidChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputField), Member = "ActivateInputField", ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "CalculateLengthOfDropdownText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "SetFiltersPostProcessing", ReturnType = typeof(void))]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60004B1")]
		 get { } //Length: 30
		[Address(RVA = "0x1CDAF20", Offset = "0x1CDA120", Length = "0x11D")]
		[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Dropdown)}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Toggle)}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputField)}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text), typeof(Color)}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowserItem", Member = "OnSkinRefreshed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SimpleFileBrowser.UISkin", typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Button)}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowserContextMenu", Member = "RefreshSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SimpleFileBrowser.UISkin"}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "RefreshSkin", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Text), Member = "AssignDefaultFontIfNecessary", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Text), Member = "AssignDefaultFont", ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowserDeleteConfirmationPanel", Member = "RefreshSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SimpleFileBrowser.UISkin"}, ReturnType = typeof(void))]
		[CallerCount(Count = 17)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(FontUpdateTracker), Member = "UntrackText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(FontUpdateTracker), Member = "TrackText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60004B2")]
		 set { } //Length: 285
	}

	[Token(Token = "0x17000142")]
	public int fontSize
	{
		[Address(RVA = "0x1CDA6E0", Offset = "0x1CD98E0", Length = "0x1D")]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "CalculateLengthOfDropdownText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "SetFiltersPostProcessing", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60004C1")]
		 get { } //Length: 29
		[Address(RVA = "0x1CDAE60", Offset = "0x1CDA060", Length = "0x57")]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "RefreshSkin", ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowserContextMenu", Member = "RefreshSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SimpleFileBrowser.UISkin"}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowserDeleteConfirmationPanel", Member = "RefreshSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SimpleFileBrowser.UISkin"}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowserItem", Member = "OnSkinRefreshed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SimpleFileBrowser.UISkin", typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text), typeof(Color)}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputField)}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Button)}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Dropdown)}, ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Toggle)}, ReturnType = typeof(void))]
		[CallerCount(Count = 15)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60004C2")]
		 set { } //Length: 87
	}

	[Token(Token = "0x17000146")]
	public FontStyle fontStyle
	{
		[Address(RVA = "0x1CDA700", Offset = "0x1CD9900", Length = "0x1D")]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "CalculateLengthOfDropdownText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "SetFiltersPostProcessing", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60004C9")]
		 get { } //Length: 29
		[Address(RVA = "0x1CDAEC0", Offset = "0x1CDA0C0", Length = "0x57")]
		[CalledBy(Type = typeof(DefaultControls), Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60004CA")]
		 set { } //Length: 87
	}

	[Token(Token = "0x17000143")]
	public HorizontalWrapMode horizontalOverflow
	{
		[Address(RVA = "0x1CDA740", Offset = "0x1CD9940", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60004C3")]
		 get { } //Length: 29
		[Address(RVA = "0x1CDB040", Offset = "0x1CDA240", Length = "0x57")]
		[CalledBy(Type = typeof(InputField), Member = "set_contentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputField), Member = "EnforceContentType", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputField), Member = "EnforceTextHOverflow", ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60004C4")]
		 set { } //Length: 87
	}

	[Token(Token = "0x1700014E")]
	public override int layoutPriority
	{
		[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
		[CallerCount(Count = 51)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004DC")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000145")]
	public float lineSpacing
	{
		[Address(RVA = "0x1CDA760", Offset = "0x1CD9960", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60004C7")]
		 get { } //Length: 31
		[Address(RVA = "0x1CDB0A0", Offset = "0x1CDA2A0", Length = "0x60")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60004C8")]
		 set { } //Length: 96
	}

	[Token(Token = "0x17000139")]
	public virtual Texture mainTexture
	{
		[Address(RVA = "0x1CDA780", Offset = "0x1CD9980", Length = "0x1F3")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Font), Member = "get_material", ReturnType = typeof(Material))]
		[Calls(Type = typeof(Material), Member = "get_mainTexture", ReturnType = typeof(Texture))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60004AF")]
		 get { } //Length: 499
	}

	[Token(Token = "0x1700014B")]
	public override float minHeight
	{
		[Address(RVA = "0x3E3710", Offset = "0x3E2910", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004D9")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000148")]
	public override float minWidth
	{
		[Address(RVA = "0x3E3710", Offset = "0x3E2910", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004D6")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000147")]
	public float pixelsPerUnit
	{
		[Address(RVA = "0x1CDA980", Offset = "0x1CD9B80", Length = "0x16B")]
		[CalledBy(Type = typeof(Text), Member = "get_preferredWidth", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(InputField), Member = "GetUnclampedCharacterLineFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(TextGenerator)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(InputField), Member = "GetCharacterIndexFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(InputField), Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputField), Member = "GenerateHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputField), Member = "get_preferredWidth", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(InputField), Member = "get_preferredHeight", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(Text), Member = "GetGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(TextGenerationSettings))]
		[CalledBy(Type = typeof(Text), Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Text), Member = "get_preferredHeight", ReturnType = typeof(float))]
		[CallerCount(Count = 16)]
		[Calls(Type = typeof(Font), Member = "get_fontSize", ReturnType = typeof(int))]
		[Calls(Type = typeof(Font), Member = "get_dynamic", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Canvas), Member = "get_scaleFactor", ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60004CB")]
		 get { } //Length: 363
	}

	[Token(Token = "0x1700014C")]
	public override float preferredHeight
	{
		[Address(RVA = "0x1CDAAF0", Offset = "0x1CD9CF0", Length = "0x104")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Graphic), Member = "GetPixelAdjustedRect", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(Text), Member = "GetGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(TextGenerationSettings))]
		[Calls(Type = typeof(Text), Member = "get_cachedTextGeneratorForLayout", ReturnType = typeof(TextGenerator))]
		[Calls(Type = typeof(TextGenerator), Member = "GetPreferredHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextGenerationSettings)}, ReturnType = typeof(float))]
		[Calls(Type = typeof(Text), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60004DA")]
		 get { } //Length: 260
	}

	[Token(Token = "0x17000149")]
	public override float preferredWidth
	{
		[Address(RVA = "0x1CDAC00", Offset = "0x1CD9E00", Length = "0x11C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Text), Member = "GetGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(TextGenerationSettings))]
		[Calls(Type = typeof(Text), Member = "get_cachedTextGeneratorForLayout", ReturnType = typeof(TextGenerator))]
		[Calls(Type = typeof(TextGenerator), Member = "GetPreferredWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextGenerationSettings)}, ReturnType = typeof(float))]
		[Calls(Type = typeof(Text), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60004D7")]
		 get { } //Length: 284
	}

	[Token(Token = "0x1700013D")]
	public bool resizeTextForBestFit
	{
		[Address(RVA = "0x1CDAD20", Offset = "0x1CD9F20", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60004B7")]
		 get { } //Length: 30
		[Address(RVA = "0x1CDB110", Offset = "0x1CDA310", Length = "0x57")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60004B8")]
		 set { } //Length: 87
	}

	[Token(Token = "0x1700013F")]
	public int resizeTextMaxSize
	{
		[Address(RVA = "0x1CDAD40", Offset = "0x1CD9F40", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60004BB")]
		 get { } //Length: 29
		[Address(RVA = "0x1CDB170", Offset = "0x1CDA370", Length = "0x57")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60004BC")]
		 set { } //Length: 87
	}

	[Token(Token = "0x1700013E")]
	public int resizeTextMinSize
	{
		[Address(RVA = "0x1CDAD60", Offset = "0x1CD9F60", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60004B9")]
		 get { } //Length: 29
		[Address(RVA = "0x1CDB1D0", Offset = "0x1CDA3D0", Length = "0x57")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60004BA")]
		 set { } //Length: 87
	}

	[Token(Token = "0x1700013C")]
	public bool supportRichText
	{
		[Address(RVA = "0x1CDAD80", Offset = "0x1CD9F80", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60004B5")]
		 get { } //Length: 30
		[Address(RVA = "0x1CDB230", Offset = "0x1CDA430", Length = "0x57")]
		[CalledBy(Type = typeof(DefaultControls), Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60004B6")]
		 set { } //Length: 87
	}

	[Token(Token = "0x1700013B")]
	public override string text
	{
		[Address(RVA = "0x2E7250", Offset = "0x2E6450", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004B3")]
		 get { } //Length: 8
		[Address(RVA = "0x1CDB290", Offset = "0x1CDA490", Length = "0xEE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsUnknownMethods(Count = 3)]
		[Token(Token = "0x60004B4")]
		 set { } //Length: 238
	}

	[Token(Token = "0x17000144")]
	public VerticalWrapMode verticalOverflow
	{
		[Address(RVA = "0x1CDADA0", Offset = "0x1CD9FA0", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60004C5")]
		 get { } //Length: 29
		[Address(RVA = "0x1CDB380", Offset = "0x1CDA580", Length = "0x57")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60004C6")]
		 set { } //Length: 87
	}

	[Address(RVA = "0x1CDA4C0", Offset = "0x1CD96C0", Length = "0xA4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FontData), Member = "get_defaultFontData", ReturnType = typeof(FontData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(MaskableGraphic), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x60004AC")]
	protected Text() { }

	[Address(RVA = "0x1CD96D0", Offset = "0x1CD88D0", Length = "0x57")]
	[CalledBy(Type = typeof(DefaultControls), Member = "SetDefaultTextValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Resources), Member = "GetBuiltinResource", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
	[Calls(Type = typeof(Text), Member = "set_font", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font)}, ReturnType = typeof(void))]
	[Token(Token = "0x60004CF")]
	internal void AssignDefaultFont() { }

	[Address(RVA = "0x1CD9620", Offset = "0x1CD8820", Length = "0xAE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Resources), Member = "GetBuiltinResource", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
	[Calls(Type = typeof(Text), Member = "set_font", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004D0")]
	internal void AssignDefaultFontIfNecessary() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004D4")]
	public override void CalculateLayoutInputHorizontal() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004D5")]
	public override void CalculateLayoutInputVertical() { }

	[Address(RVA = "0x1CD9730", Offset = "0x1CD8930", Length = "0x11F")]
	[CalledBy(Type = typeof(FontUpdateTracker), Member = "RebuildForFont", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Text), Member = "get_cachedTextGenerator", ReturnType = typeof(TextGenerator))]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "IsRebuildingGraphics", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CanvasUpdateRegistry), Member = "IsRebuildingLayout", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60004B0")]
	public void FontTextureChanged() { }

	[Address(RVA = "0x1CDA570", Offset = "0x1CD9770", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004BF")]
	public bool get_alignByGeometry() { }

	[Address(RVA = "0x1CDA590", Offset = "0x1CD9790", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004BD")]
	public TextAnchor get_alignment() { }

	[Address(RVA = "0x1CDA630", Offset = "0x1CD9830", Length = "0xAC")]
	[CalledBy(Type = typeof(InputField), Member = "GetCharacterIndexFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(InputField), Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "GenerateHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Text), Member = "FontTextureChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Text), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Text), Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TextGenerator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextGenerator), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004AD")]
	public TextGenerator get_cachedTextGenerator() { }

	[Address(RVA = "0x1CDA5B0", Offset = "0x1CD97B0", Length = "0x73")]
	[CalledBy(Type = typeof(InputField), Member = "get_preferredWidth", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(InputField), Member = "get_preferredHeight", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(Text), Member = "get_preferredWidth", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(Text), Member = "get_preferredHeight", ReturnType = typeof(float))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TextGenerator), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60004AE")]
	public TextGenerator get_cachedTextGeneratorForLayout() { }

	[Address(RVA = "0x18B16D0", Offset = "0x18B08D0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004DB")]
	public override float get_flexibleHeight() { }

	[Address(RVA = "0x18B16D0", Offset = "0x18B08D0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004D8")]
	public override float get_flexibleWidth() { }

	[Address(RVA = "0x1CDA720", Offset = "0x1CD9920", Length = "0x1E")]
	[CalledBy(Type = typeof(DefaultControls), Member = "SetDefaultTextValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontUpdateTracker), Member = "TrackText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontUpdateTracker), Member = "UntrackText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "KeyPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Event)}, ReturnType = "UnityEngine.UI.InputField+EditState")]
	[CalledBy(Type = typeof(InputField), Member = "IsValidChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "ActivateInputField", ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "CalculateLengthOfDropdownText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "SetFiltersPostProcessing", ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004B1")]
	public Font get_font() { }

	[Address(RVA = "0x1CDA6E0", Offset = "0x1CD98E0", Length = "0x1D")]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "CalculateLengthOfDropdownText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "SetFiltersPostProcessing", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004C1")]
	public int get_fontSize() { }

	[Address(RVA = "0x1CDA700", Offset = "0x1CD9900", Length = "0x1D")]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "CalculateLengthOfDropdownText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "SetFiltersPostProcessing", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004C9")]
	public FontStyle get_fontStyle() { }

	[Address(RVA = "0x1CDA740", Offset = "0x1CD9940", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004C3")]
	public HorizontalWrapMode get_horizontalOverflow() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004DC")]
	public override int get_layoutPriority() { }

	[Address(RVA = "0x1CDA760", Offset = "0x1CD9960", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004C7")]
	public float get_lineSpacing() { }

	[Address(RVA = "0x1CDA780", Offset = "0x1CD9980", Length = "0x1F3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Font), Member = "get_material", ReturnType = typeof(Material))]
	[Calls(Type = typeof(Material), Member = "get_mainTexture", ReturnType = typeof(Texture))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004AF")]
	public virtual Texture get_mainTexture() { }

	[Address(RVA = "0x3E3710", Offset = "0x3E2910", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004D9")]
	public override float get_minHeight() { }

	[Address(RVA = "0x3E3710", Offset = "0x3E2910", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004D6")]
	public override float get_minWidth() { }

	[Address(RVA = "0x1CDA980", Offset = "0x1CD9B80", Length = "0x16B")]
	[CalledBy(Type = typeof(Text), Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Text), Member = "GetGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(TextGenerationSettings))]
	[CalledBy(Type = typeof(InputField), Member = "get_preferredHeight", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(InputField), Member = "get_preferredWidth", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(Text), Member = "get_preferredHeight", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(InputField), Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "GetCharacterIndexFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(InputField), Member = "GetUnclampedCharacterLineFromPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(TextGenerator)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Text), Member = "get_preferredWidth", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(InputField), Member = "GenerateHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Font), Member = "get_fontSize", ReturnType = typeof(int))]
	[Calls(Type = typeof(Font), Member = "get_dynamic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Canvas), Member = "get_scaleFactor", ReturnType = typeof(float))]
	[Token(Token = "0x60004CB")]
	public float get_pixelsPerUnit() { }

	[Address(RVA = "0x1CDAAF0", Offset = "0x1CD9CF0", Length = "0x104")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graphic), Member = "GetPixelAdjustedRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Text), Member = "GetGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(TextGenerationSettings))]
	[Calls(Type = typeof(Text), Member = "get_cachedTextGeneratorForLayout", ReturnType = typeof(TextGenerator))]
	[Calls(Type = typeof(TextGenerator), Member = "GetPreferredHeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextGenerationSettings)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Text), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004DA")]
	public override float get_preferredHeight() { }

	[Address(RVA = "0x1CDAC00", Offset = "0x1CD9E00", Length = "0x11C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Text), Member = "GetGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(TextGenerationSettings))]
	[Calls(Type = typeof(Text), Member = "get_cachedTextGeneratorForLayout", ReturnType = typeof(TextGenerator))]
	[Calls(Type = typeof(TextGenerator), Member = "GetPreferredWidth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextGenerationSettings)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Text), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004D7")]
	public override float get_preferredWidth() { }

	[Address(RVA = "0x1CDAD20", Offset = "0x1CD9F20", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004B7")]
	public bool get_resizeTextForBestFit() { }

	[Address(RVA = "0x1CDAD40", Offset = "0x1CD9F40", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004BB")]
	public int get_resizeTextMaxSize() { }

	[Address(RVA = "0x1CDAD60", Offset = "0x1CD9F60", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004B9")]
	public int get_resizeTextMinSize() { }

	[Address(RVA = "0x1CDAD80", Offset = "0x1CD9F80", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004B5")]
	public bool get_supportRichText() { }

	[Address(RVA = "0x2E7250", Offset = "0x2E6450", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004B3")]
	public override string get_text() { }

	[Address(RVA = "0x1CDADA0", Offset = "0x1CD9FA0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004C5")]
	public VerticalWrapMode get_verticalOverflow() { }

	[Address(RVA = "0x1CD9850", Offset = "0x1CD8A50", Length = "0x242")]
	[CalledBy(Type = typeof(InputField), Member = "UpdateLabel", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "get_preferredWidth", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(InputField), Member = "get_preferredHeight", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(Text), Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Text), Member = "get_preferredWidth", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(Text), Member = "get_preferredHeight", ReturnType = typeof(float))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Text), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[Calls(Type = typeof(Font), Member = "get_dynamic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "get_pivot", ReturnType = typeof(Vector2))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004D1")]
	public TextGenerationSettings GetGenerationSettings(Vector2 extents) { }

	[Address(RVA = "0x1CD9AA0", Offset = "0x1CD8CA0", Length = "0x140")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004D2")]
	public static Vector2 GetTextAnchorPivot(TextAnchor anchor) { }

	[Address(RVA = "0x1CD9C10", Offset = "0x1CD8E10", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontUpdateTracker), Member = "UntrackText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaskableGraphic), Member = "OnDisable", ReturnType = typeof(void))]
	[Token(Token = "0x60004CD")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x1CD9C70", Offset = "0x1CD8E70", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MaskableGraphic), Member = "OnEnable", ReturnType = typeof(void))]
	[Calls(Type = typeof(Text), Member = "get_cachedTextGenerator", ReturnType = typeof(TextGenerator))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontUpdateTracker), Member = "TrackText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60004CC")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x1CD9CF0", Offset = "0x1CD8EF0", Length = "0x743")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Graphic), Member = "PixelAdjustPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800F5320")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(Text), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[Calls(Type = typeof(TextGenerator), Member = "get_verts", ReturnType = typeof(System.Collections.Generic.IList`1<UnityEngine.UIVertex>))]
	[Calls(Type = typeof(TextGenerator), Member = "PopulateWithErrors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextGenerationSettings), typeof(GameObject)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Text), Member = "GetGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(TextGenerationSettings))]
	[Calls(Type = typeof(VertexHelper), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Text), Member = "get_cachedTextGenerator", ReturnType = typeof(TextGenerator))]
	[Calls(Type = typeof(VertexHelper), Member = "AddUIVertexQuad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIVertex[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60004D3")]
	protected virtual void OnPopulateMesh(VertexHelper toFill) { }

	[Address(RVA = "0x1CDADC0", Offset = "0x1CD9FC0", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004C0")]
	public void set_alignByGeometry(bool value) { }

	[Address(RVA = "0x1CDAE00", Offset = "0x1CDA000", Length = "0x57")]
	[CalledBy(Type = typeof(DefaultControls), Member = "CreateButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(DefaultControls), Member = "CreateDropdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60004BE")]
	public void set_alignment(TextAnchor value) { }

	[Address(RVA = "0x1CDAF20", Offset = "0x1CDA120", Length = "0x11D")]
	[CalledBy(Type = typeof(Text), Member = "AssignDefaultFont", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Text), Member = "AssignDefaultFontIfNecessary", ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "RefreshSkin", ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowserContextMenu", Member = "RefreshSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SimpleFileBrowser.UISkin"}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Button)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowserDeleteConfirmationPanel", Member = "RefreshSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SimpleFileBrowser.UISkin"}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text), typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputField)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Toggle)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Dropdown)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowserItem", Member = "OnSkinRefreshed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SimpleFileBrowser.UISkin", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontUpdateTracker), Member = "UntrackText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontUpdateTracker), Member = "TrackText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004B2")]
	public void set_font(Font value) { }

	[Address(RVA = "0x1CDAE60", Offset = "0x1CDA060", Length = "0x57")]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "RefreshSkin", ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowserContextMenu", Member = "RefreshSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SimpleFileBrowser.UISkin"}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowserDeleteConfirmationPanel", Member = "RefreshSkin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SimpleFileBrowser.UISkin"}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowserItem", Member = "OnSkinRefreshed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SimpleFileBrowser.UISkin", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Text), typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputField)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Button)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Dropdown)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.UISkin", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Toggle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60004C2")]
	public void set_fontSize(int value) { }

	[Address(RVA = "0x1CDAEC0", Offset = "0x1CDA0C0", Length = "0x57")]
	[CalledBy(Type = typeof(DefaultControls), Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60004CA")]
	public void set_fontStyle(FontStyle value) { }

	[Address(RVA = "0x1CDB040", Offset = "0x1CDA240", Length = "0x57")]
	[CalledBy(Type = typeof(InputField), Member = "set_contentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContentType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "EnforceContentType", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "EnforceTextHOverflow", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60004C4")]
	public void set_horizontalOverflow(HorizontalWrapMode value) { }

	[Address(RVA = "0x1CDB0A0", Offset = "0x1CDA2A0", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60004C8")]
	public void set_lineSpacing(float value) { }

	[Address(RVA = "0x1CDB110", Offset = "0x1CDA310", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60004B8")]
	public void set_resizeTextForBestFit(bool value) { }

	[Address(RVA = "0x1CDB170", Offset = "0x1CDA370", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60004BC")]
	public void set_resizeTextMaxSize(int value) { }

	[Address(RVA = "0x1CDB1D0", Offset = "0x1CDA3D0", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60004BA")]
	public void set_resizeTextMinSize(int value) { }

	[Address(RVA = "0x1CDB230", Offset = "0x1CDA430", Length = "0x57")]
	[CalledBy(Type = typeof(DefaultControls), Member = "CreateInputField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Resources)}, ReturnType = typeof(GameObject))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60004B6")]
	public void set_supportRichText(bool value) { }

	[Address(RVA = "0x1CDB290", Offset = "0x1CDA490", Length = "0xEE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60004B4")]
	public override void set_text(string value) { }

	[Address(RVA = "0x1CDB380", Offset = "0x1CDA580", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60004C6")]
	public void set_verticalOverflow(VerticalWrapMode value) { }

	[Address(RVA = "0x1CDA440", Offset = "0x1CD9640", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Graphic), Member = "UpdateGeometry", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004CE")]
	protected virtual void UpdateGeometry() { }

}

