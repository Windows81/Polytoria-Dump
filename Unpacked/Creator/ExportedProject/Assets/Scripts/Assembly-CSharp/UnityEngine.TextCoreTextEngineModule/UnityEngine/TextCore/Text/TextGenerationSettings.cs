namespace UnityEngine.TextCore.Text;

[Token(Token = "0x2000047")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
internal class TextGenerationSettings : IEquatable<TextGenerationSettings>
{
	[Token(Token = "0x400027D")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal static Func<Boolean> IsEditorTextRenderingModeBitmap; //Field offset: 0x0
	[Token(Token = "0x400029C")]
	public const int maxVisibleCharacters = 99999; //Field offset: 0x0
	[Token(Token = "0x4000295")]
	public const bool tagNoParsing = False; //Field offset: 0x0
	[Token(Token = "0x400029D")]
	public const int maxVisibleWords = 99999; //Field offset: 0x0
	[Token(Token = "0x400029E")]
	public const int maxVisibleLines = 99999; //Field offset: 0x0
	[Token(Token = "0x400029F")]
	public const int firstVisibleCharacter = 0; //Field offset: 0x0
	[Token(Token = "0x40002A0")]
	public const bool useMaxVisibleDescender = False; //Field offset: 0x0
	[Token(Token = "0x40002A3")]
	public const float charWidthMaxAdj = 0; //Field offset: 0x0
	[Token(Token = "0x400028D")]
	public const float fontSizeMax = 0; //Field offset: 0x0
	[Token(Token = "0x400028C")]
	public const float fontSizeMin = 0; //Field offset: 0x0
	[Token(Token = "0x400028B")]
	public const bool autoSize = False; //Field offset: 0x0
	[Token(Token = "0x400029A")]
	public const float lineSpacingMax = 0; //Field offset: 0x0
	[Token(Token = "0x4000298")]
	public const float lineSpacing = 0; //Field offset: 0x0
	[Token(Token = "0x4000287")]
	public const float wordWrappingRatio = 0.4; //Field offset: 0x0
	[Token(Token = "0x400027E")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal static Func<Boolean> IsEditorTextRenderingModeRaster; //Field offset: 0x8
	[Token(Token = "0x400028E")]
	internal static readonly List<OTL_FeatureTag> fontFeatures; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400027F")]
	private RenderedText m_RenderedText; //Field offset: 0x10
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000280")]
	private string m_CachedRenderedText; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000281")]
	public Rect screenRect; //Field offset: 0x38
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000282")]
	public FontAsset fontAsset; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000283")]
	public FontStyles fontStyle; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000284")]
	public TextSettings textSettings; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000285")]
	public TextAlignment textAlignment; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000286")]
	public TextOverflowMode overflowMode; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000288")]
	public Color color; //Field offset: 0x68
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000289")]
	public bool shouldConvertToLinearSpace; //Field offset: 0x78
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x400028A")]
	public int fontSize; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400028F")]
	public bool emojiFallbackSupport; //Field offset: 0x80
	[FieldOffset(Offset = "0x81")]
	[Token(Token = "0x4000290")]
	public bool richText; //Field offset: 0x81
	[FieldOffset(Offset = "0x82")]
	[Token(Token = "0x4000291")]
	public bool isRightToLeft; //Field offset: 0x82
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x4000292")]
	public float extraPadding; //Field offset: 0x84
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000293")]
	public bool parseControlCharacters; //Field offset: 0x88
	[FieldOffset(Offset = "0x89")]
	[Token(Token = "0x4000294")]
	public bool isPlaceholder; //Field offset: 0x89
	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x4000296")]
	public float characterSpacing; //Field offset: 0x8C
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000297")]
	public float wordSpacing; //Field offset: 0x90
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x4000299")]
	public float paragraphSpacing; //Field offset: 0x94
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400029B")]
	public TextWrappingMode textWrappingMode; //Field offset: 0x98
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x40002A1")]
	public TextFontWeight fontWeight; //Field offset: 0x9C
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40002A2")]
	public bool isIMGUI; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x40002A4")]
	public float pixelsPerPoint; //Field offset: 0xA4

	[Token(Token = "0x1700005F")]
	public RenderedText renderedText
	{
		[Address(RVA = "0xB08680", Offset = "0xB07880", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001E4")]
		 get { } //Length: 19
		[Address(RVA = "0x1A60860", Offset = "0x1A5FA60", Length = "0x3B")]
		[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ComputeTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderedText&), typeof(float), typeof(float), "System.Nullable`1<Single>"}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ConvertUssToTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "System.Nullable`1<Single>"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60001E5")]
		 set { } //Length: 59
	}

	[Token(Token = "0x17000060")]
	public string text
	{
		[Address(RVA = "0x1A607E0", Offset = "0x1A5F9E0", Length = "0x56")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RenderedText), Member = "CreateString", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60001E6")]
		 get { } //Length: 86
		[Address(RVA = "0x1A608A0", Offset = "0x1A5FAA0", Length = "0x106")]
		[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ConvertUssToTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "System.Nullable`1<Single>"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.IMGUITextHandle", Member = "ConvertGUIStyleToGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), "UnityEngine.GUIStyle", typeof(Color), typeof(string), typeof(Rect)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60001E7")]
		 set { } //Length: 262
	}

	[Address(RVA = "0x1A60670", Offset = "0x1A5F870", Length = "0xF2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60001EE")]
	private static TextGenerationSettings() { }

	[Address(RVA = "0x1A60770", Offset = "0x1A5F970", Length = "0x63")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60001E8")]
	public TextGenerationSettings() { }

	[Address(RVA = "0x1A5EC90", Offset = "0x1A5DE90", Length = "0x369")]
	[CalledBy(Type = typeof(TextGenerationSettings), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(float), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001E9")]
	public override bool Equals(TextGenerationSettings other) { }

	[Address(RVA = "0x1A5F000", Offset = "0x1A5E200", Length = "0xF8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextGenerationSettings), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60001EA")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xB08680", Offset = "0xB07880", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001E4")]
	public RenderedText get_renderedText() { }

	[Address(RVA = "0x1A607E0", Offset = "0x1A5F9E0", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderedText), Member = "CreateString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60001E6")]
	public string get_text() { }

	[Address(RVA = "0x1A5F100", Offset = "0x1A5E300", Length = "0x2D9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HashCode), Member = "Add", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderedText)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderedText)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HashCode), Member = "Add", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HashCode), Member = "Add", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HashCode), Member = "Add", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HashCode), Member = "Add", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HashCode), Member = "Add", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HashCode), Member = "Add", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HashCode), Member = "ToHashCode", ReturnType = typeof(int))]
	[Token(Token = "0x60001EB")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1A60840", Offset = "0x1A5FA40", Length = "0x13")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60001EC")]
	public static bool op_Inequality(TextGenerationSettings left, TextGenerationSettings right) { }

	[Address(RVA = "0x1A60860", Offset = "0x1A5FA60", Length = "0x3B")]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ComputeTextSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderedText&), typeof(float), typeof(float), "System.Nullable`1<Single>"}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ConvertUssToTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "System.Nullable`1<Single>"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60001E5")]
	public void set_renderedText(RenderedText value) { }

	[Address(RVA = "0x1A608A0", Offset = "0x1A5FAA0", Length = "0x106")]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ConvertUssToTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "System.Nullable`1<Single>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.IMGUITextHandle", Member = "ConvertGUIStyleToGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), "UnityEngine.GUIStyle", typeof(Color), typeof(string), typeof(Rect)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001E7")]
	public void set_text(string value) { }

	[Address(RVA = "0x1A5F3E0", Offset = "0x1A5E5E0", Length = "0x1280")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(RenderedText), Member = "CreateString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60001ED")]
	public virtual string ToString() { }

}

