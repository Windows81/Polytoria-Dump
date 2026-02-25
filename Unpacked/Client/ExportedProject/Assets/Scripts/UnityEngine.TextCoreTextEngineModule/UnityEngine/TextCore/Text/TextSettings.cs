namespace UnityEngine.TextCore.Text;

[ExcludeFromObjectFactory]
[ExcludeFromPreset]
[NativeHeader("Modules/TextCoreTextEngine/Native/TextSettings.h")]
[Token(Token = "0x2000039")]
public class TextSettings : ScriptableObject
{
	[CompilerGenerated]
	[Token(Token = "0x200003B")]
	private sealed class <>c__DisplayClass96_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000180")]
		public List<IntPtr> globalFontAssetFallbacks; //Field offset: 0x10

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000194")]
		public <>c__DisplayClass96_0() { }

		[Address(RVA = "0x1A6CFC0", Offset = "0x1A6C1C0", Length = "0x142")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(FontAsset), Member = "get_atlasPopulationMode", ReturnType = typeof(AtlasPopulationMode))]
		[Calls(Type = typeof(FontAsset), Member = "get_characterTable", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.Character>))]
		[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(FontAsset), Member = "get_nativeFontAsset", ReturnType = typeof(IntPtr))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002D410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000195")]
		internal void <GetGlobalFallbacks>b__0(FontAsset fallback) { }

		[Address(RVA = "0x1A6D110", Offset = "0x1A6C310", Length = "0x142")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(FontAsset), Member = "get_atlasPopulationMode", ReturnType = typeof(AtlasPopulationMode))]
		[Calls(Type = typeof(FontAsset), Member = "get_characterTable", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.Character>))]
		[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(FontAsset), Member = "get_nativeFontAsset", ReturnType = typeof(IntPtr))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002D410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000196")]
		internal void <GetGlobalFallbacks>b__1(FontAsset fallback) { }

		[Address(RVA = "0x1A6D260", Offset = "0x1A6C460", Length = "0x181")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(FontAsset), Member = "get_atlasPopulationMode", ReturnType = typeof(AtlasPopulationMode))]
		[Calls(Type = typeof(FontAsset), Member = "get_characterTable", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.Character>))]
		[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(FontAsset), Member = "get_nativeFontAsset", ReturnType = typeof(IntPtr))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002D410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000197")]
		internal void <GetGlobalFallbacks>b__2(TextAsset fallback) { }

	}

	[Token(Token = "0x200003A")]
	public struct FontReferenceMap
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400017E")]
		public Font font; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400017F")]
		public FontAsset fontAsset; //Field offset: 0x8

		[Address(RVA = "0x310490", Offset = "0x30F690", Length = "0x32")]
		[CallerCount(Count = 48)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000193")]
		public FontReferenceMap(Font font, FontAsset fontAsset) { }

	}

	[Token(Token = "0x400016A")]
	private static List<FontAsset> s_FallbackOSFontAssetInternal; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000173")]
	private static SpriteAsset <s_GlobalSpriteAsset>k__BackingField; //Field offset: 0x8
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000166")]
	protected string m_Version; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("m_defaultFontAsset")]
	[SerializeField]
	[Token(Token = "0x4000167")]
	protected FontAsset m_DefaultFontAsset; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("m_defaultFontAssetPath")]
	[SerializeField]
	[Token(Token = "0x4000168")]
	protected string m_DefaultFontAssetPath; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[FormerlySerializedAs("m_fallbackFontAssets")]
	[SerializeField]
	[Token(Token = "0x4000169")]
	protected List<FontAsset> m_FallbackFontAssets; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[FormerlySerializedAs("m_matchMaterialPreset")]
	[SerializeField]
	[Token(Token = "0x400016B")]
	protected bool m_MatchMaterialPreset; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[FormerlySerializedAs("m_missingGlyphCharacter")]
	[SerializeField]
	[Token(Token = "0x400016C")]
	protected int m_MissingCharacterUnicode; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x400016D")]
	protected bool m_ClearDynamicDataOnBuild; //Field offset: 0x40
	[FieldOffset(Offset = "0x41")]
	[SerializeField]
	[Token(Token = "0x400016E")]
	private bool m_EnableEmojiSupport; //Field offset: 0x41
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x400016F")]
	private List<TextAsset> m_EmojiFallbackTextAssets; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[FormerlySerializedAs("m_defaultSpriteAsset")]
	[SerializeField]
	[Token(Token = "0x4000170")]
	protected SpriteAsset m_DefaultSpriteAsset; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[FormerlySerializedAs("m_defaultSpriteAssetPath")]
	[SerializeField]
	[Token(Token = "0x4000171")]
	protected string m_DefaultSpriteAssetPath; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x4000172")]
	protected List<SpriteAsset> m_FallbackSpriteAssets; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[Token(Token = "0x4000174")]
	protected uint m_MissingSpriteCharacterUnicode; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[FormerlySerializedAs("m_defaultStyleSheet")]
	[SerializeField]
	[Token(Token = "0x4000175")]
	protected TextStyleSheet m_DefaultStyleSheet; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Token(Token = "0x4000176")]
	protected string m_StyleSheetsResourcePath; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[FormerlySerializedAs("m_defaultColorGradientPresetsPath")]
	[SerializeField]
	[Token(Token = "0x4000177")]
	protected string m_DefaultColorGradientPresetsPath; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	[Token(Token = "0x4000178")]
	protected UnicodeLineBreakingRules m_UnicodeLineBreakingRules; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[FormerlySerializedAs("m_warningsDisabled")]
	[SerializeField]
	[Token(Token = "0x4000179")]
	protected bool m_DisplayWarnings; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400017A")]
	internal Dictionary<Int32, FontAsset> m_FontLookup; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400017B")]
	internal List<FontReferenceMap> m_FontReferences; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400017C")]
	private IntPtr m_NativeTextSettings; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400017D")]
	private bool m_IsNativeTextSettingsDirty; //Field offset: 0xB0

	[Token(Token = "0x17000040")]
	public bool clearDynamicDataOnBuild
	{
		[Address(RVA = "0x4C4260", Offset = "0x4C3460", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600016B")]
		 get { } //Length: 5
		[Address(RVA = "0x4C4270", Offset = "0x4C3470", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600016C")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700004A")]
	public string defaultColorGradientPresetsPath
	{
		[Address(RVA = "0x2DD220", Offset = "0x2DC420", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600017F")]
		 get { } //Length: 8
		[Address(RVA = "0x2DD550", Offset = "0x2DC750", Length = "0x10")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000180")]
		 set { } //Length: 16
	}

	[Token(Token = "0x1700003A")]
	public FontAsset defaultFontAsset
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x600015D")]
		 get { } //Length: 5
		[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600015E")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700003B")]
	public string defaultFontAssetPath
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x600015F")]
		 get { } //Length: 5
		[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000160")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000043")]
	public SpriteAsset defaultSpriteAsset
	{
		[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000171")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD610", Offset = "0x2DC810", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000172")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000044")]
	public string defaultSpriteAssetPath
	{
		[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000173")]
		 get { } //Length: 5
		[Address(RVA = "0x324160", Offset = "0x323360", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000174")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000048")]
	public TextStyleSheet defaultStyleSheet
	{
		[Address(RVA = "0x3F5890", Offset = "0x3F4A90", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600017B")]
		 get { } //Length: 5
		[Address(RVA = "0x5ECDD0", Offset = "0x5EBFD0", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600017C")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700004C")]
	public bool displayWarnings
	{
		[Address(RVA = "0xE6C540", Offset = "0xE6B740", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000183")]
		 get { } //Length: 8
		[Address(RVA = "0xE6C910", Offset = "0xE6BB10", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000184")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000042")]
	public List<TextAsset> emojiFallbackTextAssets
	{
		[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x600016F")]
		 get { } //Length: 5
		[Address(RVA = "0x1A6C400", Offset = "0x1A6B600", Length = "0x23")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000170")]
		 set { } //Length: 35
	}

	[Token(Token = "0x17000041")]
	public bool enableEmojiSupport
	{
		[Address(RVA = "0x1A6C250", Offset = "0x1A6B450", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600016D")]
		 get { } //Length: 7
		[Address(RVA = "0x16BD1A0", Offset = "0x16BC3A0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600016E")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700003C")]
	public List<FontAsset> fallbackFontAssets
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000161")]
		 get { } //Length: 95
		[Address(RVA = "0x1A6C430", Offset = "0x1A6B630", Length = "0x23")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000162")]
		 set { } //Length: 35
	}

	[Token(Token = "0x1700003D")]
	internal List<FontAsset> fallbackOSFontAssets
	{
		[Address(RVA = "0x1A6C260", Offset = "0x1A6B460", Length = "0xAB")]
		[CalledBy(Type = "UnityEngine.UIElements.UITKTextJobSystem", Member = "GenerateTextJobified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext", typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextGenerator), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(TextGenerator), Member = "GetTextElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(uint), typeof(FontAsset), typeof(FontStyles), typeof(TextFontWeight), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(TextElement))]
		[CalledBy(Type = typeof(TextGenerator), Member = "PopulateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextProcessingElement[])}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TextGenerator), Member = "GetEllipsisSpecialCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Font), Member = "GetOSFallbacks", ReturnType = typeof(String[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(FontAsset), Member = "CreateFontAssetOSFallbackList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(int)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.FontAsset>))]
		[CallsUnknownMethods(Count = 3)]
		[Token(Token = "0x6000163")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
		internal get { } //Length: 171
	}

	[Obsolete("The Fallback Sprite Assets list is now obsolete. Use the emojiFallbackTextAssets instead.", True)]
	[Token(Token = "0x17000045")]
	public List<SpriteAsset> fallbackSpriteAssets
	{
		[Address(RVA = "0x3B3490", Offset = "0x3B2690", Length = "0x5")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000175")]
		 get { } //Length: 5
		[Address(RVA = "0xB087D0", Offset = "0xB079D0", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000176")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700004B")]
	public UnicodeLineBreakingRules lineBreakingRules
	{
		[Address(RVA = "0x1A6C310", Offset = "0x1A6B510", Length = "0x8D")]
		[CalledBy(Type = "UnityEngine.UIElements.UITKTextJobSystem", Member = "GenerateTextJobified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext", typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(UnicodeLineBreakingRules), Member = "LoadLineBreakingRules", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000181")]
		 get { } //Length: 141
		[Address(RVA = "0x2DD530", Offset = "0x2DC730", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000182")]
		 set { } //Length: 19
	}

	[Token(Token = "0x1700003E")]
	public bool matchMaterialPreset
	{
		[Address(RVA = "0x3408F0", Offset = "0x33FAF0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000167")]
		 get { } //Length: 5
		[Address(RVA = "0x340A60", Offset = "0x33FC60", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000168")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700003F")]
	public int missingCharacterUnicode
	{
		[Address(RVA = "0x3DCA70", Offset = "0x3DBC70", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000169")]
		 get { } //Length: 4
		[Address(RVA = "0x5AABF0", Offset = "0x5A9DF0", Length = "0x4")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x600016A")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000047")]
	public uint missingSpriteCharacterUnicode
	{
		[Address(RVA = "0x3B4390", Offset = "0x3B3590", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000179")]
		 get { } //Length: 4
		[Address(RVA = "0x96AEC0", Offset = "0x96A0C0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600017A")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700004D")]
	internal IntPtr nativeTextSettings
	{
		[Address(RVA = "0x1A6C3A0", Offset = "0x1A6B5A0", Length = "0x1D")]
		[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ConvertUssToNativeTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Nullable`1<Single>"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(TextSettings), Member = "UpdateNativeTextSettings", ReturnType = typeof(void))]
		[Token(Token = "0x600018D")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
		internal get { } //Length: 29
	}

	[Token(Token = "0x17000046")]
	internal static SpriteAsset s_GlobalSpriteAsset
	{
		[Address(RVA = "0x1A6C3C0", Offset = "0x1A6B5C0", Length = "0x37")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CompilerGenerated]
		[Token(Token = "0x6000178")]
		internal get { } //Length: 55
		[Address(RVA = "0x1A6C460", Offset = "0x1A6B660", Length = "0x56")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[Token(Token = "0x6000177")]
		private set { } //Length: 86
	}

	[Token(Token = "0x17000049")]
	public string styleSheetsResourcePath
	{
		[Address(RVA = "0x2DD190", Offset = "0x2DC390", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600017D")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD440", Offset = "0x2DC640", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600017E")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000039")]
	public internal string version
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x600015B")]
		 get { } //Length: 5
		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600015C")]
		internal set { } //Length: 13
	}

	[Address(RVA = "0x1A6C110", Offset = "0x1A6B310", Length = "0x13C")]
	[CalledBy(Type = "UnityEngine.UIElements.PanelTextSettings", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.RuntimeTextSettings", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000190")]
	public TextSettings() { }

	[Address(RVA = "0x1A6B250", Offset = "0x1A6A450", Length = "0xBC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(Name = "TextSettings::Create")]
	[Token(Token = "0x600018A")]
	private static IntPtr CreateNativeObject(IntPtr[] fallbacks) { }

	[Address(RVA = "0x1A6B210", Offset = "0x1A6A410", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000191")]
	private static IntPtr CreateNativeObject_Injected(ref ManagedSpanWrapper fallbacks) { }

	[Address(RVA = "0x1A6B310", Offset = "0x1A6A510", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(Name = "TextSettings::Destroy")]
	[Token(Token = "0x600018B")]
	private static void DestroyNativeObject(IntPtr m_NativeTextSettings) { }

	[Address(RVA = "0x4C4260", Offset = "0x4C3460", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600016B")]
	public bool get_clearDynamicDataOnBuild() { }

	[Address(RVA = "0x2DD220", Offset = "0x2DC420", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600017F")]
	public string get_defaultColorGradientPresetsPath() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x600015D")]
	public FontAsset get_defaultFontAsset() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x600015F")]
	public string get_defaultFontAssetPath() { }

	[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000171")]
	public SpriteAsset get_defaultSpriteAsset() { }

	[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000173")]
	public string get_defaultSpriteAssetPath() { }

	[Address(RVA = "0x3F5890", Offset = "0x3F4A90", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600017B")]
	public TextStyleSheet get_defaultStyleSheet() { }

	[Address(RVA = "0xE6C540", Offset = "0xE6B740", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000183")]
	public bool get_displayWarnings() { }

	[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x600016F")]
	public List<TextAsset> get_emojiFallbackTextAssets() { }

	[Address(RVA = "0x1A6C250", Offset = "0x1A6B450", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600016D")]
	public bool get_enableEmojiSupport() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000161")]
	public List<FontAsset> get_fallbackFontAssets() { }

	[Address(RVA = "0x1A6C260", Offset = "0x1A6B460", Length = "0xAB")]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextJobSystem", Member = "GenerateTextJobified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext", typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextGenerator), Member = "GetTextElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(uint), typeof(FontAsset), typeof(FontStyles), typeof(TextFontWeight), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(TextElement))]
	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextProcessingElement[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextGenerator), Member = "GetEllipsisSpecialCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Font), Member = "GetOSFallbacks", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontAsset), Member = "CreateFontAssetOSFallbackList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(int)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.FontAsset>))]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000163")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal List<FontAsset> get_fallbackOSFontAssets() { }

	[Address(RVA = "0x3B3490", Offset = "0x3B2690", Length = "0x5")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000175")]
	public List<SpriteAsset> get_fallbackSpriteAssets() { }

	[Address(RVA = "0x1A6C310", Offset = "0x1A6B510", Length = "0x8D")]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextJobSystem", Member = "GenerateTextJobified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext", typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UnicodeLineBreakingRules), Member = "LoadLineBreakingRules", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000181")]
	public UnicodeLineBreakingRules get_lineBreakingRules() { }

	[Address(RVA = "0x3408F0", Offset = "0x33FAF0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000167")]
	public bool get_matchMaterialPreset() { }

	[Address(RVA = "0x3DCA70", Offset = "0x3DBC70", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000169")]
	public int get_missingCharacterUnicode() { }

	[Address(RVA = "0x3B4390", Offset = "0x3B3590", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000179")]
	public uint get_missingSpriteCharacterUnicode() { }

	[Address(RVA = "0x1A6C3A0", Offset = "0x1A6B5A0", Length = "0x1D")]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ConvertUssToNativeTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Nullable`1<Single>"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextSettings), Member = "UpdateNativeTextSettings", ReturnType = typeof(void))]
	[Token(Token = "0x600018D")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal IntPtr get_nativeTextSettings() { }

	[Address(RVA = "0x1A6C3C0", Offset = "0x1A6B5C0", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CompilerGenerated]
	[Token(Token = "0x6000178")]
	internal static SpriteAsset get_s_GlobalSpriteAsset() { }

	[Address(RVA = "0x2DD190", Offset = "0x2DC390", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600017D")]
	public string get_styleSheetsResourcePath() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x600015B")]
	public string get_version() { }

	[Address(RVA = "0x1A6B350", Offset = "0x1A6A550", Length = "0x2E6")]
	[CalledBy(Type = "UnityEngine.UIElements.TextUtilities", Member = "GetFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement"}, ReturnType = typeof(FontAsset))]
	[CalledBy(Type = "UnityEngine.IMGUITextHandle", Member = "ConvertGUIStyleToGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), "UnityEngine.GUIStyle", typeof(Color), typeof(string), typeof(Rect)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAssetFactory), Member = "ConvertFontToFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font)}, ReturnType = typeof(FontAsset))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextSettings), Member = "InitializeFontReferenceLookup", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000188")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal FontAsset GetCachedFontAsset(Font font) { }

	[Address(RVA = "0x19865B0", Offset = "0x19857B0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000166")]
	internal override List<FontAsset> GetFallbackFontAssets(bool isRaster, int textPixelSize = -1) { }

	[Address(RVA = "0x1A6B640", Offset = "0x1A6A840", Length = "0x27E")]
	[CalledBy(Type = typeof(TextSettings), Member = "UpdateNativeTextSettings", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(List`1), Member = "ForEach", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Font), Member = "GetOSFallbacks", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontAsset), Member = "CreateFontAssetOSFallbackList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(int)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.FontAsset>))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600018E")]
	private IntPtr[] GetGlobalFallbacks() { }

	[Address(RVA = "0x1A6B8C0", Offset = "0x1A6AAC0", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Font), Member = "GetOSFallbacks", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontAsset), Member = "CreateFontAssetOSFallbackList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(int)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.FontAsset>))]
	[Token(Token = "0x6000189")]
	private List<FontAsset> GetOSFontAssetList() { }

	[Address(RVA = "0x1A6B920", Offset = "0x1A6AB20", Length = "0x36")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000164")]
	internal override List<FontAsset> GetStaticFallbackOSFontAsset() { }

	[Address(RVA = "0x1A6B960", Offset = "0x1A6AB60", Length = "0x248")]
	[CalledBy(Type = typeof(TextSettings), Member = "GetCachedFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font)}, ReturnType = typeof(FontAsset))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000187")]
	protected void InitializeFontReferenceLookup() { }

	[Address(RVA = "0x1A6BBB0", Offset = "0x1A6ADB0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000186")]
	private void OnDestroy() { }

	[Address(RVA = "0x1A6BC10", Offset = "0x1A6AE10", Length = "0x19F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UnicodeLineBreakingRules), Member = "LoadLineBreakingRules", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Resources), Member = "Load", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000185")]
	private void OnEnable() { }

	[Address(RVA = "0x4C4270", Offset = "0x4C3470", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600016C")]
	public void set_clearDynamicDataOnBuild(bool value) { }

	[Address(RVA = "0x2DD550", Offset = "0x2DC750", Length = "0x10")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000180")]
	public void set_defaultColorGradientPresetsPath(string value) { }

	[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600015E")]
	public void set_defaultFontAsset(FontAsset value) { }

	[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000160")]
	public void set_defaultFontAssetPath(string value) { }

	[Address(RVA = "0x2DD610", Offset = "0x2DC810", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000172")]
	public void set_defaultSpriteAsset(SpriteAsset value) { }

	[Address(RVA = "0x324160", Offset = "0x323360", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000174")]
	public void set_defaultSpriteAssetPath(string value) { }

	[Address(RVA = "0x5ECDD0", Offset = "0x5EBFD0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600017C")]
	public void set_defaultStyleSheet(TextStyleSheet value) { }

	[Address(RVA = "0xE6C910", Offset = "0xE6BB10", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000184")]
	public void set_displayWarnings(bool value) { }

	[Address(RVA = "0x1A6C400", Offset = "0x1A6B600", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000170")]
	public void set_emojiFallbackTextAssets(List<TextAsset> value) { }

	[Address(RVA = "0x16BD1A0", Offset = "0x16BC3A0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600016E")]
	public void set_enableEmojiSupport(bool value) { }

	[Address(RVA = "0x1A6C430", Offset = "0x1A6B630", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000162")]
	public void set_fallbackFontAssets(List<FontAsset> value) { }

	[Address(RVA = "0xB087D0", Offset = "0xB079D0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000176")]
	public void set_fallbackSpriteAssets(List<SpriteAsset> value) { }

	[Address(RVA = "0x2DD530", Offset = "0x2DC730", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000182")]
	public void set_lineBreakingRules(UnicodeLineBreakingRules value) { }

	[Address(RVA = "0x340A60", Offset = "0x33FC60", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000168")]
	public void set_matchMaterialPreset(bool value) { }

	[Address(RVA = "0x5AABF0", Offset = "0x5A9DF0", Length = "0x4")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x600016A")]
	public void set_missingCharacterUnicode(int value) { }

	[Address(RVA = "0x96AEC0", Offset = "0x96A0C0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600017A")]
	public void set_missingSpriteCharacterUnicode(uint value) { }

	[Address(RVA = "0x1A6C460", Offset = "0x1A6B660", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[Token(Token = "0x6000177")]
	private static void set_s_GlobalSpriteAsset(SpriteAsset value) { }

	[Address(RVA = "0x2DD440", Offset = "0x2DC640", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600017E")]
	public void set_styleSheetsResourcePath(string value) { }

	[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600015C")]
	internal void set_version(string value) { }

	[Address(RVA = "0x1A6BDB0", Offset = "0x1A6AFB0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000165")]
	internal override void SetStaticFallbackOSFontAsset(List<FontAsset> fontAssets) { }

	[Address(RVA = "0x1A6BE60", Offset = "0x1A6B060", Length = "0xCB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600018C")]
	private static void UpdateFallbacks(IntPtr ptr, IntPtr[] fallbacks) { }

	[Address(RVA = "0x1A6BE10", Offset = "0x1A6B010", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000192")]
	private static void UpdateFallbacks_Injected(IntPtr ptr, ref ManagedSpanWrapper fallbacks) { }

	[Address(RVA = "0x1A6BF30", Offset = "0x1A6B130", Length = "0x1D5")]
	[CalledBy(Type = "UnityEngine.UIElements.ATGTextJobSystem", Member = "GenerateTextJobified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext", typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextSettings), Member = "get_nativeTextSettings", ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TextSettings), Member = "GetGlobalFallbacks", ReturnType = typeof(IntPtr[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600018F")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal void UpdateNativeTextSettings() { }

}

