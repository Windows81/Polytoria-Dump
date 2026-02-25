namespace TMPro;

[ExcludeFromPreset]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.ugui@2.0/manual/TextMeshPro/Settings.html")]
[Token(Token = "0x2000086")]
public class TMP_Settings : ScriptableObject
{
	[Token(Token = "0x2000087")]
	internal class LineBreakingTable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000431")]
		public HashSet<UInt32> leadingCharacters; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000432")]
		public HashSet<UInt32> followingCharacters; //Field offset: 0x18

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600048B")]
		public LineBreakingTable() { }

	}

	[Token(Token = "0x400040B")]
	private static TMP_Settings s_Instance; //Field offset: 0x0
	[Token(Token = "0x400040D")]
	internal static string s_CurrentAssetVersion; //Field offset: 0x8
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x400040C")]
	internal string assetVersion; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("m_enableWordWrapping")]
	[SerializeField]
	[Token(Token = "0x400040E")]
	private TextWrappingModes m_TextWrappingMode; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x400040F")]
	private bool m_enableKerning; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000410")]
	private List<OTL_FeatureTag> m_ActiveFontFeatures; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000411")]
	private bool m_enableExtraPadding; //Field offset: 0x30
	[FieldOffset(Offset = "0x31")]
	[SerializeField]
	[Token(Token = "0x4000412")]
	private bool m_enableTintAllSprites; //Field offset: 0x31
	[FieldOffset(Offset = "0x32")]
	[SerializeField]
	[Token(Token = "0x4000413")]
	private bool m_enableParseEscapeCharacters; //Field offset: 0x32
	[FieldOffset(Offset = "0x33")]
	[SerializeField]
	[Token(Token = "0x4000414")]
	private bool m_EnableRaycastTarget; //Field offset: 0x33
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Token(Token = "0x4000415")]
	private bool m_GetFontFeaturesAtRuntime; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000416")]
	private int m_missingGlyphCharacter; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Token(Token = "0x4000417")]
	private bool m_ClearDynamicDataOnBuild; //Field offset: 0x3C
	[FieldOffset(Offset = "0x3D")]
	[SerializeField]
	[Token(Token = "0x4000418")]
	private bool m_warningsDisabled; //Field offset: 0x3D
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x4000419")]
	private TMP_FontAsset m_defaultFontAsset; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x400041A")]
	private string m_defaultFontAssetPath; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x400041B")]
	private float m_defaultFontSize; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	[Token(Token = "0x400041C")]
	private float m_defaultAutoSizeMinRatio; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x400041D")]
	private float m_defaultAutoSizeMaxRatio; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	[Token(Token = "0x400041E")]
	private Vector2 m_defaultTextMeshProTextContainerSize; //Field offset: 0x5C
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	[Token(Token = "0x400041F")]
	private Vector2 m_defaultTextMeshProUITextContainerSize; //Field offset: 0x64
	[FieldOffset(Offset = "0x6C")]
	[SerializeField]
	[Token(Token = "0x4000420")]
	private bool m_autoSizeTextContainer; //Field offset: 0x6C
	[FieldOffset(Offset = "0x6D")]
	[SerializeField]
	[Token(Token = "0x4000421")]
	private bool m_IsTextObjectScaleStatic; //Field offset: 0x6D
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x4000422")]
	private List<TMP_FontAsset> m_fallbackFontAssets; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Token(Token = "0x4000423")]
	private bool m_matchMaterialPreset; //Field offset: 0x78
	[FieldOffset(Offset = "0x79")]
	[SerializeField]
	[Token(Token = "0x4000424")]
	private bool m_HideSubTextObjects; //Field offset: 0x79
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	[Token(Token = "0x4000425")]
	private TMP_SpriteAsset m_defaultSpriteAsset; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	[Token(Token = "0x4000426")]
	private string m_defaultSpriteAssetPath; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	[Token(Token = "0x4000427")]
	private bool m_enableEmojiSupport; //Field offset: 0x90
	[FieldOffset(Offset = "0x94")]
	[SerializeField]
	[Token(Token = "0x4000428")]
	private uint m_MissingCharacterSpriteUnicode; //Field offset: 0x94
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	[Token(Token = "0x4000429")]
	private List<TMP_Asset> m_EmojiFallbackTextAssets; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	[Token(Token = "0x400042A")]
	private string m_defaultColorGradientPresetsPath; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	[Token(Token = "0x400042B")]
	private TMP_StyleSheet m_defaultStyleSheet; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	[Token(Token = "0x400042C")]
	private string m_StyleSheetsResourcePath; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	[Token(Token = "0x400042D")]
	private TextAsset m_leadingCharacters; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	[Token(Token = "0x400042E")]
	private TextAsset m_followingCharacters; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	[Token(Token = "0x400042F")]
	private LineBreakingTable m_linebreakingRules; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	[Token(Token = "0x4000430")]
	private bool m_UseModernHangulLineBreakingRules; //Field offset: 0xD0

	[Token(Token = "0x170000EF")]
	public static bool autoSizeTextContainer
	{
		[Address(RVA = "0x18E96A0", Offset = "0x18E88A0", Length = "0x4F")]
		[CalledBy(Type = typeof(TMP_Text), Member = "LoadDefaultSettings", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000467")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170000E6")]
	public static bool clearDynamicDataOnBuild
	{
		[Address(RVA = "0x18E96F0", Offset = "0x18E88F0", Length = "0x4F")]
		[CalledBy(Type = typeof(TMP_FontAsset), Member = "CreateFontAssetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(TMP_FontAsset))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600045D")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170000F9")]
	public static string defaultColorGradientPresetsPath
	{
		[Address(RVA = "0x18E9740", Offset = "0x18E8940", Length = "0x52")]
		[CalledBy(Type = typeof(TMP_Text), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000477")]
		 get { } //Length: 82
	}

	[Token(Token = "0x170000E8")]
	public static TMP_FontAsset defaultFontAsset
	{
		[Address(RVA = "0x18E97F0", Offset = "0x18E89F0", Length = "0x4F")]
		[CalledBy(Type = typeof(TextMeshPro), Member = "LoadFontAsset", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextMeshPro), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(TextMeshProUGUI), Member = "LoadFontAsset", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextMeshProUGUI), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(TMP_FontAsset), Member = "HasCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TMP_FontAsset), Member = "HasCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UInt32[]&), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TMP_Text), Member = "GetEllipsisSpecialCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "GetTextElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_FontAsset), typeof(FontStyles), typeof(FontWeight), typeof(Boolean&)}, ReturnType = typeof(TMP_TextElement))]
		[CallerCount(Count = 18)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600045F")]
		 get { } //Length: 79
		[Address(RVA = "0x18EA6D0", Offset = "0x18E98D0", Length = "0x60")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000460")]
		 set { } //Length: 96
	}

	[Token(Token = "0x170000E9")]
	public static string defaultFontAssetPath
	{
		[Address(RVA = "0x18E97A0", Offset = "0x18E89A0", Length = "0x4F")]
		[CalledBy(Type = typeof(TMP_Text), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000461")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170000EA")]
	public static float defaultFontSize
	{
		[Address(RVA = "0x18E9840", Offset = "0x18E8A40", Length = "0x50")]
		[CalledBy(Type = typeof(TMP_Text), Member = "LoadDefaultSettings", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000462")]
		 get { } //Length: 80
	}

	[Token(Token = "0x170000F4")]
	public static TMP_SpriteAsset defaultSpriteAsset
	{
		[Address(RVA = "0x18E9900", Offset = "0x18E8B00", Length = "0x52")]
		[CalledBy(Type = typeof(TMP_SpriteAsset), Member = "SearchForSpriteByUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_SpriteAsset), typeof(uint), typeof(bool), typeof(Int32&)}, ReturnType = typeof(TMP_SpriteAsset))]
		[CalledBy(Type = typeof(TMP_SpriteAsset), Member = "SearchForSpriteByHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_SpriteAsset), typeof(int), typeof(bool), typeof(Int32&)}, ReturnType = typeof(TMP_SpriteAsset))]
		[CalledBy(Type = typeof(TMP_Text), Member = "GetTextElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_FontAsset), typeof(FontStyles), typeof(FontWeight), typeof(Boolean&)}, ReturnType = typeof(TMP_TextElement))]
		[CalledBy(Type = typeof(TMP_Text), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600046E")]
		 get { } //Length: 82
		[Address(RVA = "0x18EA740", Offset = "0x18E9940", Length = "0x66")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600046F")]
		 set { } //Length: 102
	}

	[Token(Token = "0x170000F5")]
	public static string defaultSpriteAssetPath
	{
		[Address(RVA = "0x18E98A0", Offset = "0x18E8AA0", Length = "0x52")]
		[CalledBy(Type = typeof(TMP_Text), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000470")]
		 get { } //Length: 82
	}

	[Token(Token = "0x170000FA")]
	public static TMP_StyleSheet defaultStyleSheet
	{
		[Address(RVA = "0x18E9960", Offset = "0x18E8B60", Length = "0x52")]
		[CalledBy(Type = typeof(TMP_Text), Member = "GetStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TMP_Style))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000478")]
		 get { } //Length: 82
		[Address(RVA = "0x18EA7B0", Offset = "0x18E99B0", Length = "0x66")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000479")]
		 set { } //Length: 102
	}

	[Token(Token = "0x170000EC")]
	public static float defaultTextAutoSizingMaxRatio
	{
		[Address(RVA = "0x18E99C0", Offset = "0x18E8BC0", Length = "0x50")]
		[CalledBy(Type = typeof(TMP_Text), Member = "LoadDefaultSettings", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000464")]
		 get { } //Length: 80
	}

	[Token(Token = "0x170000EB")]
	public static float defaultTextAutoSizingMinRatio
	{
		[Address(RVA = "0x18E9A20", Offset = "0x18E8C20", Length = "0x50")]
		[CalledBy(Type = typeof(TMP_Text), Member = "LoadDefaultSettings", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000463")]
		 get { } //Length: 80
	}

	[Token(Token = "0x170000ED")]
	public static Vector2 defaultTextMeshProTextContainerSize
	{
		[Address(RVA = "0x18E9A80", Offset = "0x18E8C80", Length = "0x5D")]
		[CalledBy(Type = typeof(TMP_Text), Member = "LoadDefaultSettings", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000465")]
		 get { } //Length: 93
	}

	[Token(Token = "0x170000EE")]
	public static Vector2 defaultTextMeshProUITextContainerSize
	{
		[Address(RVA = "0x18E9AE0", Offset = "0x18E8CE0", Length = "0x5D")]
		[CalledBy(Type = typeof(TMP_Text), Member = "LoadDefaultSettings", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000466")]
		 get { } //Length: 93
	}

	[Token(Token = "0x170000F8")]
	public static List<TMP_Asset> emojiFallbackTextAssets
	{
		[Address(RVA = "0x18E9B40", Offset = "0x18E8D40", Length = "0x52")]
		[CalledBy(Type = typeof(TextMeshPro), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(TextMeshProUGUI), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000475")]
		 get { } //Length: 82
		[Address(RVA = "0x18EA820", Offset = "0x18E9A20", Length = "0x66")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000476")]
		 set { } //Length: 102
	}

	[Token(Token = "0x170000F6")]
	public static bool enableEmojiSupport
	{
		[Address(RVA = "0x18E9BA0", Offset = "0x18E8DA0", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000471")]
		 get { } //Length: 82
		[Address(RVA = "0x18EA890", Offset = "0x18E9A90", Length = "0x57")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000472")]
		 set { } //Length: 87
	}

	[Token(Token = "0x170000E0")]
	public static bool enableExtraPadding
	{
		[Address(RVA = "0x18E9C00", Offset = "0x18E8E00", Length = "0x4F")]
		[CalledBy(Type = typeof(TMP_Text), Member = "LoadDefaultSettings", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000456")]
		 get { } //Length: 79
	}

	[Obsolete("The \"enableKerning\" property has been deprecated. Use the \"fontFeatures\" property to control what features are enabled by default on newly created text components.")]
	[Token(Token = "0x170000DE")]
	public static bool enableKerning
	{
		[Address(RVA = "0x18E9C50", Offset = "0x18E8E50", Length = "0xBB")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.UInt32Enum>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt32Enum"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000454")]
		 get { } //Length: 187
	}

	[Token(Token = "0x170000E2")]
	public static bool enableParseEscapeCharacters
	{
		[Address(RVA = "0x18E9D10", Offset = "0x18E8F10", Length = "0x4F")]
		[CalledBy(Type = typeof(TMP_Text), Member = "LoadDefaultSettings", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000458")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170000E3")]
	public static bool enableRaycastTarget
	{
		[Address(RVA = "0x18E9D60", Offset = "0x18E8F60", Length = "0x4F")]
		[CalledBy(Type = typeof(TMP_Text), Member = "LoadDefaultSettings", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000459")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170000E1")]
	public static bool enableTintAllSprites
	{
		[Address(RVA = "0x18E9DB0", Offset = "0x18E8FB0", Length = "0x4F")]
		[CalledBy(Type = typeof(TMP_Text), Member = "LoadDefaultSettings", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000457")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170000F1")]
	public static List<TMP_FontAsset> fallbackFontAssets
	{
		[Address(RVA = "0x18E9E00", Offset = "0x18E9000", Length = "0x4F")]
		[CalledBy(Type = typeof(TextMeshPro), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(TextMeshProUGUI), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(TMP_FontAsset), Member = "HasCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TMP_FontAsset), Member = "HasCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UInt32[]&), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TMP_Text), Member = "GetEllipsisSpecialCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "GetTextElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_FontAsset), typeof(FontStyles), typeof(FontWeight), typeof(Boolean&)}, ReturnType = typeof(TMP_TextElement))]
		[CallerCount(Count = 25)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600046A")]
		 get { } //Length: 79
		[Address(RVA = "0x18EA8F0", Offset = "0x18E9AF0", Length = "0x60")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600046B")]
		 set { } //Length: 96
	}

	[Token(Token = "0x170000FD")]
	public static TextAsset followingCharacters
	{
		[Address(RVA = "0x18E9E50", Offset = "0x18E9050", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600047C")]
		 get { } //Length: 82
	}

	[Token(Token = "0x170000DF")]
	public static List<OTL_FeatureTag> fontFeatures
	{
		[Address(RVA = "0x18E9EB0", Offset = "0x18E90B0", Length = "0x4F")]
		[CalledBy(Type = typeof(TMP_Text), Member = "LoadDefaultSettings", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000455")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170000E4")]
	public static bool getFontFeaturesAtRuntime
	{
		[Address(RVA = "0x18E9F00", Offset = "0x18E9100", Length = "0x4F")]
		[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryAddGlyphInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Glyph&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryAddCharacterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_Character&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryGetCharacter_and_QueueRenderToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_Character&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TMP_FontAsset), Member = "UpdateFontAssetData", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600045A")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170000F3")]
	public static bool hideSubTextObjects
	{
		[Address(RVA = "0x18E9F50", Offset = "0x18E9150", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600046D")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000100")]
	public static TMP_Settings instance
	{
		[Address(RVA = "0x18E9FA0", Offset = "0x18E91A0", Length = "0x2CA")]
		[CallerCount(Count = 62)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TMP_Settings), Member = "get_isTMPSettingsNull", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Resources), Member = "Load", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009740")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000480")]
		 get { } //Length: 714
	}

	[Token(Token = "0x170000F0")]
	public static bool isTextObjectScaleStatic
	{
		[Address(RVA = "0x18EA2F0", Offset = "0x18E94F0", Length = "0x4F")]
		[CalledBy(Type = typeof(TMP_Text), Member = "LoadDefaultSettings", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000468")]
		 get { } //Length: 79
		[Address(RVA = "0x18EA960", Offset = "0x18E9B60", Length = "0x54")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000469")]
		 set { } //Length: 84
	}

	[Token(Token = "0x17000101")]
	internal static bool isTMPSettingsNull
	{
		[Address(RVA = "0x18EA270", Offset = "0x18E9470", Length = "0x7E")]
		[CalledBy(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Token(Token = "0x6000481")]
		internal get { } //Length: 126
	}

	[Token(Token = "0x170000FC")]
	public static TextAsset leadingCharacters
	{
		[Address(RVA = "0x18EA340", Offset = "0x18E9540", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600047B")]
		 get { } //Length: 82
	}

	[Token(Token = "0x170000FE")]
	public static LineBreakingTable linebreakingRules
	{
		[Address(RVA = "0x18EA3A0", Offset = "0x18E95A0", Length = "0x99")]
		[CalledBy(Type = typeof(TMP_Text), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextWrappingModes)}, ReturnType = typeof(Vector2))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[Calls(Type = typeof(TMP_Settings), Member = "LoadLinebreakingRules", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600047D")]
		 get { } //Length: 153
	}

	[Token(Token = "0x170000F2")]
	public static bool matchMaterialPreset
	{
		[Address(RVA = "0x18EA440", Offset = "0x18E9640", Length = "0x4F")]
		[CalledBy(Type = typeof(TextMeshPro), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(TextMeshProUGUI), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600046C")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170000F7")]
	public static uint missingCharacterSpriteUnicode
	{
		[Address(RVA = "0x18EA490", Offset = "0x18E9690", Length = "0x51")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000473")]
		 get { } //Length: 81
		[Address(RVA = "0x18EA9C0", Offset = "0x18E9BC0", Length = "0x56")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000474")]
		 set { } //Length: 86
	}

	[Token(Token = "0x170000E5")]
	public static int missingGlyphCharacter
	{
		[Address(RVA = "0x18EA4F0", Offset = "0x18E96F0", Length = "0x4E")]
		[CalledBy(Type = typeof(TextMeshPro), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(TextMeshProUGUI), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600045B")]
		 get { } //Length: 78
		[Address(RVA = "0x18EAA20", Offset = "0x18E9C20", Length = "0x53")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600045C")]
		 set { } //Length: 83
	}

	[Token(Token = "0x170000FB")]
	public static string styleSheetsResourcePath
	{
		[Address(RVA = "0x18EA540", Offset = "0x18E9740", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600047A")]
		 get { } //Length: 82
	}

	[Token(Token = "0x170000DD")]
	public static TextWrappingModes textWrappingMode
	{
		[Address(RVA = "0x18EA5A0", Offset = "0x18E97A0", Length = "0x4E")]
		[CalledBy(Type = typeof(TMP_Text), Member = "LoadDefaultSettings", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000453")]
		 get { } //Length: 78
	}

	[Token(Token = "0x170000FF")]
	public static bool useModernHangulLineBreakingRules
	{
		[Address(RVA = "0x18EA5F0", Offset = "0x18E97F0", Length = "0x52")]
		[CalledBy(Type = typeof(TMP_Text), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextWrappingModes)}, ReturnType = typeof(Vector2))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600047E")]
		 get { } //Length: 82
		[Address(RVA = "0x18EAA80", Offset = "0x18E9C80", Length = "0x57")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600047F")]
		 set { } //Length: 87
	}

	[Token(Token = "0x170000DC")]
	public static string version
	{
		[Address(RVA = "0x18EA650", Offset = "0x18E9850", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000451")]
		 get { } //Length: 44
	}

	[Token(Token = "0x170000E7")]
	public static bool warningsDisabled
	{
		[Address(RVA = "0x18EA680", Offset = "0x18E9880", Length = "0x4F")]
		[CalledBy(Type = typeof(TextMeshPro), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(TextMeshProUGUI), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(TMP_FontAsset), Member = "AddSynthesizedCharactersAndFaceMetrics", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "DrawUnderlineMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Int32&), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Color32)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_Text), Member = "DrawTextHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Int32&), typeof(Color32)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600045E")]
		 get { } //Length: 79
	}

	[Address(RVA = "0x18E9540", Offset = "0x18E8740", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600048A")]
	private static TMP_Settings() { }

	[Address(RVA = "0x18E95B0", Offset = "0x18E87B0", Length = "0xEB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000489")]
	public TMP_Settings() { }

	[Address(RVA = "0x18E96A0", Offset = "0x18E88A0", Length = "0x4F")]
	[CalledBy(Type = typeof(TMP_Text), Member = "LoadDefaultSettings", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000467")]
	public static bool get_autoSizeTextContainer() { }

	[Address(RVA = "0x18E96F0", Offset = "0x18E88F0", Length = "0x4F")]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "CreateFontAssetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(TMP_FontAsset))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600045D")]
	public static bool get_clearDynamicDataOnBuild() { }

	[Address(RVA = "0x18E9740", Offset = "0x18E8940", Length = "0x52")]
	[CalledBy(Type = typeof(TMP_Text), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000477")]
	public static string get_defaultColorGradientPresetsPath() { }

	[Address(RVA = "0x18E97F0", Offset = "0x18E89F0", Length = "0x4F")]
	[CalledBy(Type = typeof(TextMeshPro), Member = "LoadFontAsset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "LoadFontAsset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "HasCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "HasCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UInt32[]&), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetEllipsisSpecialCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetTextElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_FontAsset), typeof(FontStyles), typeof(FontWeight), typeof(Boolean&)}, ReturnType = typeof(TMP_TextElement))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600045F")]
	public static TMP_FontAsset get_defaultFontAsset() { }

	[Address(RVA = "0x18E97A0", Offset = "0x18E89A0", Length = "0x4F")]
	[CalledBy(Type = typeof(TMP_Text), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000461")]
	public static string get_defaultFontAssetPath() { }

	[Address(RVA = "0x18E9840", Offset = "0x18E8A40", Length = "0x50")]
	[CalledBy(Type = typeof(TMP_Text), Member = "LoadDefaultSettings", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000462")]
	public static float get_defaultFontSize() { }

	[Address(RVA = "0x18E9900", Offset = "0x18E8B00", Length = "0x52")]
	[CalledBy(Type = typeof(TMP_SpriteAsset), Member = "SearchForSpriteByUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_SpriteAsset), typeof(uint), typeof(bool), typeof(Int32&)}, ReturnType = typeof(TMP_SpriteAsset))]
	[CalledBy(Type = typeof(TMP_SpriteAsset), Member = "SearchForSpriteByHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_SpriteAsset), typeof(int), typeof(bool), typeof(Int32&)}, ReturnType = typeof(TMP_SpriteAsset))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetTextElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_FontAsset), typeof(FontStyles), typeof(FontWeight), typeof(Boolean&)}, ReturnType = typeof(TMP_TextElement))]
	[CalledBy(Type = typeof(TMP_Text), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600046E")]
	public static TMP_SpriteAsset get_defaultSpriteAsset() { }

	[Address(RVA = "0x18E98A0", Offset = "0x18E8AA0", Length = "0x52")]
	[CalledBy(Type = typeof(TMP_Text), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000470")]
	public static string get_defaultSpriteAssetPath() { }

	[Address(RVA = "0x18E9960", Offset = "0x18E8B60", Length = "0x52")]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TMP_Style))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000478")]
	public static TMP_StyleSheet get_defaultStyleSheet() { }

	[Address(RVA = "0x18E99C0", Offset = "0x18E8BC0", Length = "0x50")]
	[CalledBy(Type = typeof(TMP_Text), Member = "LoadDefaultSettings", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000464")]
	public static float get_defaultTextAutoSizingMaxRatio() { }

	[Address(RVA = "0x18E9A20", Offset = "0x18E8C20", Length = "0x50")]
	[CalledBy(Type = typeof(TMP_Text), Member = "LoadDefaultSettings", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000463")]
	public static float get_defaultTextAutoSizingMinRatio() { }

	[Address(RVA = "0x18E9A80", Offset = "0x18E8C80", Length = "0x5D")]
	[CalledBy(Type = typeof(TMP_Text), Member = "LoadDefaultSettings", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000465")]
	public static Vector2 get_defaultTextMeshProTextContainerSize() { }

	[Address(RVA = "0x18E9AE0", Offset = "0x18E8CE0", Length = "0x5D")]
	[CalledBy(Type = typeof(TMP_Text), Member = "LoadDefaultSettings", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000466")]
	public static Vector2 get_defaultTextMeshProUITextContainerSize() { }

	[Address(RVA = "0x18E9B40", Offset = "0x18E8D40", Length = "0x52")]
	[CalledBy(Type = typeof(TextMeshPro), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000475")]
	public static List<TMP_Asset> get_emojiFallbackTextAssets() { }

	[Address(RVA = "0x18E9BA0", Offset = "0x18E8DA0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000471")]
	public static bool get_enableEmojiSupport() { }

	[Address(RVA = "0x18E9C00", Offset = "0x18E8E00", Length = "0x4F")]
	[CalledBy(Type = typeof(TMP_Text), Member = "LoadDefaultSettings", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000456")]
	public static bool get_enableExtraPadding() { }

	[Address(RVA = "0x18E9C50", Offset = "0x18E8E50", Length = "0xBB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.UInt32Enum>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt32Enum"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000454")]
	public static bool get_enableKerning() { }

	[Address(RVA = "0x18E9D10", Offset = "0x18E8F10", Length = "0x4F")]
	[CalledBy(Type = typeof(TMP_Text), Member = "LoadDefaultSettings", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000458")]
	public static bool get_enableParseEscapeCharacters() { }

	[Address(RVA = "0x18E9D60", Offset = "0x18E8F60", Length = "0x4F")]
	[CalledBy(Type = typeof(TMP_Text), Member = "LoadDefaultSettings", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000459")]
	public static bool get_enableRaycastTarget() { }

	[Address(RVA = "0x18E9DB0", Offset = "0x18E8FB0", Length = "0x4F")]
	[CalledBy(Type = typeof(TMP_Text), Member = "LoadDefaultSettings", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000457")]
	public static bool get_enableTintAllSprites() { }

	[Address(RVA = "0x18E9E00", Offset = "0x18E9000", Length = "0x4F")]
	[CalledBy(Type = typeof(TextMeshPro), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "HasCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "HasCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UInt32[]&), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetEllipsisSpecialCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetTextElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_FontAsset), typeof(FontStyles), typeof(FontWeight), typeof(Boolean&)}, ReturnType = typeof(TMP_TextElement))]
	[CallerCount(Count = 25)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600046A")]
	public static List<TMP_FontAsset> get_fallbackFontAssets() { }

	[Address(RVA = "0x18E9E50", Offset = "0x18E9050", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600047C")]
	public static TextAsset get_followingCharacters() { }

	[Address(RVA = "0x18E9EB0", Offset = "0x18E90B0", Length = "0x4F")]
	[CalledBy(Type = typeof(TMP_Text), Member = "LoadDefaultSettings", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000455")]
	public static List<OTL_FeatureTag> get_fontFeatures() { }

	[Address(RVA = "0x18E9F00", Offset = "0x18E9100", Length = "0x4F")]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryAddGlyphInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Glyph&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryAddCharacterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_Character&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryGetCharacter_and_QueueRenderToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_Character&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "UpdateFontAssetData", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600045A")]
	public static bool get_getFontFeaturesAtRuntime() { }

	[Address(RVA = "0x18E9F50", Offset = "0x18E9150", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600046D")]
	public static bool get_hideSubTextObjects() { }

	[Address(RVA = "0x18E9FA0", Offset = "0x18E91A0", Length = "0x2CA")]
	[CallerCount(Count = 62)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_isTMPSettingsNull", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Resources), Member = "Load", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009740")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000480")]
	public static TMP_Settings get_instance() { }

	[Address(RVA = "0x18EA2F0", Offset = "0x18E94F0", Length = "0x4F")]
	[CalledBy(Type = typeof(TMP_Text), Member = "LoadDefaultSettings", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000468")]
	public static bool get_isTextObjectScaleStatic() { }

	[Address(RVA = "0x18EA270", Offset = "0x18E9470", Length = "0x7E")]
	[CalledBy(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000481")]
	internal static bool get_isTMPSettingsNull() { }

	[Address(RVA = "0x18EA340", Offset = "0x18E9540", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600047B")]
	public static TextAsset get_leadingCharacters() { }

	[Address(RVA = "0x18EA3A0", Offset = "0x18E95A0", Length = "0x99")]
	[CalledBy(Type = typeof(TMP_Text), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextWrappingModes)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(TMP_Settings), Member = "LoadLinebreakingRules", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600047D")]
	public static LineBreakingTable get_linebreakingRules() { }

	[Address(RVA = "0x18EA440", Offset = "0x18E9640", Length = "0x4F")]
	[CalledBy(Type = typeof(TextMeshPro), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600046C")]
	public static bool get_matchMaterialPreset() { }

	[Address(RVA = "0x18EA490", Offset = "0x18E9690", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000473")]
	public static uint get_missingCharacterSpriteUnicode() { }

	[Address(RVA = "0x18EA4F0", Offset = "0x18E96F0", Length = "0x4E")]
	[CalledBy(Type = typeof(TextMeshPro), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600045B")]
	public static int get_missingGlyphCharacter() { }

	[Address(RVA = "0x18EA540", Offset = "0x18E9740", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600047A")]
	public static string get_styleSheetsResourcePath() { }

	[Address(RVA = "0x18EA5A0", Offset = "0x18E97A0", Length = "0x4E")]
	[CalledBy(Type = typeof(TMP_Text), Member = "LoadDefaultSettings", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000453")]
	public static TextWrappingModes get_textWrappingMode() { }

	[Address(RVA = "0x18EA5F0", Offset = "0x18E97F0", Length = "0x52")]
	[CalledBy(Type = typeof(TMP_Text), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextWrappingModes)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600047E")]
	public static bool get_useModernHangulLineBreakingRules() { }

	[Address(RVA = "0x18EA650", Offset = "0x18E9850", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000451")]
	public static string get_version() { }

	[Address(RVA = "0x18EA680", Offset = "0x18E9880", Length = "0x4F")]
	[CalledBy(Type = typeof(TextMeshPro), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "AddSynthesizedCharactersAndFaceMetrics", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "DrawUnderlineMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Int32&), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Color32)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "DrawTextHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Int32&), typeof(Color32)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600045E")]
	public static bool get_warningsDisabled() { }

	[Address(RVA = "0x18E8E40", Offset = "0x18E8040", Length = "0xC7")]
	[CalledBy(Type = typeof(TMP_Settings), Member = "LoadLinebreakingRules", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.UInt32>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000488")]
	private static HashSet<UInt32> GetCharacters(TextAsset file) { }

	[Address(RVA = "0x18E8F10", Offset = "0x18E8110", Length = "0xAB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000484")]
	public static TMP_FontAsset GetFontAsset() { }

	[Address(RVA = "0x18E8FC0", Offset = "0x18E81C0", Length = "0x9C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000483")]
	public static TMP_Settings GetSettings() { }

	[Address(RVA = "0x18E9060", Offset = "0x18E8260", Length = "0xAE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000485")]
	public static TMP_SpriteAsset GetSpriteAsset() { }

	[Address(RVA = "0x18E9110", Offset = "0x18E8310", Length = "0xAE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000486")]
	public static TMP_StyleSheet GetStyleSheet() { }

	[Address(RVA = "0x18E91C0", Offset = "0x18E83C0", Length = "0x13F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Resources), Member = "Load", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000482")]
	public static TMP_Settings LoadDefaultSettings() { }

	[Address(RVA = "0x18E9300", Offset = "0x18E8500", Length = "0x1C0")]
	[CalledBy(Type = typeof(TMP_Settings), Member = "get_linebreakingRules", ReturnType = typeof(LineBreakingTable))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TMP_Settings), Member = "GetCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAsset)}, ReturnType = typeof(System.Collections.Generic.HashSet`1<System.UInt32>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000487")]
	public static void LoadLinebreakingRules() { }

	[Address(RVA = "0x18EA6D0", Offset = "0x18E98D0", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000460")]
	public static void set_defaultFontAsset(TMP_FontAsset value) { }

	[Address(RVA = "0x18EA740", Offset = "0x18E9940", Length = "0x66")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600046F")]
	public static void set_defaultSpriteAsset(TMP_SpriteAsset value) { }

	[Address(RVA = "0x18EA7B0", Offset = "0x18E99B0", Length = "0x66")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000479")]
	public static void set_defaultStyleSheet(TMP_StyleSheet value) { }

	[Address(RVA = "0x18EA820", Offset = "0x18E9A20", Length = "0x66")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000476")]
	public static void set_emojiFallbackTextAssets(List<TMP_Asset> value) { }

	[Address(RVA = "0x18EA890", Offset = "0x18E9A90", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000472")]
	public static void set_enableEmojiSupport(bool value) { }

	[Address(RVA = "0x18EA8F0", Offset = "0x18E9AF0", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600046B")]
	public static void set_fallbackFontAssets(List<TMP_FontAsset> value) { }

	[Address(RVA = "0x18EA960", Offset = "0x18E9B60", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000469")]
	public static void set_isTextObjectScaleStatic(bool value) { }

	[Address(RVA = "0x18EA9C0", Offset = "0x18E9BC0", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000474")]
	public static void set_missingCharacterSpriteUnicode(uint value) { }

	[Address(RVA = "0x18EAA20", Offset = "0x18E9C20", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600045C")]
	public static void set_missingGlyphCharacter(int value) { }

	[Address(RVA = "0x18EAA80", Offset = "0x18E9C80", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600047F")]
	public static void set_useModernHangulLineBreakingRules(bool value) { }

	[Address(RVA = "0x18E94D0", Offset = "0x18E86D0", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000452")]
	internal void SetAssetVersion() { }

}

