namespace UnityEngine.TextCore.Text;

[ExcludeFromPreset]
[NativeHeader("Modules/TextCoreTextEngine/Native/FontAsset.h")]
[Token(Token = "0x200002E")]
public class FontAsset : TextAsset
{
	[CompilerGenerated]
	[Token(Token = "0x200002F")]
	private sealed class <>c
	{
		[Token(Token = "0x400013F")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000140")]
		public static Func<Character, UInt32> <>9__191_0; //Field offset: 0x8
		[Token(Token = "0x4000141")]
		public static Func<Glyph, UInt32> <>9__192_0; //Field offset: 0x10

		[Address(RVA = "0x1A3BA70", Offset = "0x1A3AC70", Length = "0xA7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000118")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000119")]
		public <>c() { }

		[Address(RVA = "0x1A3B920", Offset = "0x1A3AB20", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600011A")]
		internal uint <SortCharacterTable>b__191_0(Character c) { }

		[Address(RVA = "0x18B3A50", Offset = "0x18B2C50", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600011B")]
		internal uint <SortGlyphTable>b__192_0(Glyph c) { }

	}

	[Token(Token = "0x40000F7")]
	private static Dictionary<Int32, FontAsset> kFontAssetByInstanceId; //Field offset: 0x0
	[Token(Token = "0x400012A")]
	private static readonly List<WeakReference`1<FontAsset>> s_CallbackInstances; //Field offset: 0x8
	[Token(Token = "0x400012B")]
	private static ProfilerMarker k_ReadFontAssetDefinitionMarker; //Field offset: 0x10
	[Token(Token = "0x400012C")]
	private static ProfilerMarker k_AddSynthesizedCharactersMarker; //Field offset: 0x18
	[Token(Token = "0x400012D")]
	private static ProfilerMarker k_TryAddGlyphMarker; //Field offset: 0x20
	[Token(Token = "0x400012E")]
	private static ProfilerMarker k_TryAddCharacterMarker; //Field offset: 0x28
	[Token(Token = "0x400012F")]
	private static ProfilerMarker k_TryAddCharactersMarker; //Field offset: 0x30
	[Token(Token = "0x4000130")]
	private static ProfilerMarker k_UpdateLigatureSubstitutionRecordsMarker; //Field offset: 0x38
	[Token(Token = "0x4000131")]
	private static ProfilerMarker k_UpdateGlyphAdjustmentRecordsMarker; //Field offset: 0x40
	[Token(Token = "0x4000132")]
	private static ProfilerMarker k_UpdateDiacriticalMarkAdjustmentRecordsMarker; //Field offset: 0x48
	[Token(Token = "0x4000133")]
	private static ProfilerMarker k_ClearFontAssetDataMarker; //Field offset: 0x50
	[Token(Token = "0x4000134")]
	private static ProfilerMarker k_UpdateFontAssetDataMarker; //Field offset: 0x58
	[Token(Token = "0x4000135")]
	private static string s_DefaultMaterialSuffix; //Field offset: 0x60
	[Token(Token = "0x4000136")]
	private static HashSet<Int32> k_SearchedFontAssetLookup; //Field offset: 0x68
	[Token(Token = "0x4000137")]
	private static List<FontAsset> k_FontAssets_FontFeaturesUpdateQueue; //Field offset: 0x70
	[Token(Token = "0x4000138")]
	private static HashSet<Int32> k_FontAssets_FontFeaturesUpdateQueueLookup; //Field offset: 0x78
	[Token(Token = "0x4000139")]
	private static List<FontAsset> k_FontAssets_KerningUpdateQueue; //Field offset: 0x80
	[Token(Token = "0x400013A")]
	private static HashSet<Int32> k_FontAssets_KerningUpdateQueueLookup; //Field offset: 0x88
	[Token(Token = "0x400013B")]
	private static List<Texture2D> k_FontAssets_AtlasTexturesUpdateQueue; //Field offset: 0x90
	[Token(Token = "0x400013C")]
	private static HashSet<Int32> k_FontAssets_AtlasTexturesUpdateQueueLookup; //Field offset: 0x98
	[Token(Token = "0x400013D")]
	internal static UInt32[] k_GlyphIndexArray; //Field offset: 0xA0
	[Token(Token = "0x400013E")]
	private static HashSet<Int32> visitedFontAssets; //Field offset: 0xA8
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x40000F8")]
	internal string m_SourceFontFileGUID; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x40000F9")]
	internal FontAssetCreationEditorSettings m_fontAssetCreationEditorSettings; //Field offset: 0x40
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	[Token(Token = "0x40000FA")]
	private Font m_SourceFontFile; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	[Token(Token = "0x40000FB")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal string m_SourceFontFilePath; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	[Token(Token = "0x40000FC")]
	private AtlasPopulationMode m_AtlasPopulationMode; //Field offset: 0xA8
	[FieldOffset(Offset = "0xAC")]
	[SerializeField]
	[Token(Token = "0x40000FD")]
	internal bool InternalDynamicOS; //Field offset: 0xAC
	[FieldOffset(Offset = "0xAD")]
	[SerializeField]
	[Token(Token = "0x40000FE")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal bool IsEditorFont; //Field offset: 0xAD
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	[Token(Token = "0x40000FF")]
	internal FaceInfo m_FaceInfo; //Field offset: 0xB0
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000100")]
	private int m_FamilyNameHashCode; //Field offset: 0x110
	[FieldOffset(Offset = "0x114")]
	[Token(Token = "0x4000101")]
	private int m_StyleNameHashCode; //Field offset: 0x114
	[FieldOffset(Offset = "0x118")]
	[Nullable(1)]
	[SerializeField]
	[Token(Token = "0x4000102")]
	internal List<Glyph> m_GlyphTable; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000103")]
	internal Dictionary<UInt32, Glyph> m_GlyphLookupDictionary; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	[Token(Token = "0x4000104")]
	internal List<Character> m_CharacterTable; //Field offset: 0x128
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4000105")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal Dictionary<UInt32, Character> m_CharacterLookupDictionary; //Field offset: 0x130
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4000106")]
	internal Texture2D m_AtlasTexture; //Field offset: 0x138
	[FieldOffset(Offset = "0x140")]
	[SerializeField]
	[Token(Token = "0x4000107")]
	internal Texture2D[] m_AtlasTextures; //Field offset: 0x140
	[FieldOffset(Offset = "0x148")]
	[SerializeField]
	[Token(Token = "0x4000108")]
	internal int m_AtlasTextureIndex; //Field offset: 0x148
	[FieldOffset(Offset = "0x14C")]
	[SerializeField]
	[Token(Token = "0x4000109")]
	private bool m_IsMultiAtlasTexturesEnabled; //Field offset: 0x14C
	[FieldOffset(Offset = "0x14D")]
	[SerializeField]
	[Token(Token = "0x400010A")]
	private bool m_GetFontFeatures; //Field offset: 0x14D
	[FieldOffset(Offset = "0x14E")]
	[SerializeField]
	[Token(Token = "0x400010B")]
	private bool m_ClearDynamicDataOnBuild; //Field offset: 0x14E
	[FieldOffset(Offset = "0x150")]
	[SerializeField]
	[Token(Token = "0x400010C")]
	internal int m_AtlasWidth; //Field offset: 0x150
	[FieldOffset(Offset = "0x154")]
	[SerializeField]
	[Token(Token = "0x400010D")]
	internal int m_AtlasHeight; //Field offset: 0x154
	[FieldOffset(Offset = "0x158")]
	[SerializeField]
	[Token(Token = "0x400010E")]
	internal int m_AtlasPadding; //Field offset: 0x158
	[FieldOffset(Offset = "0x15C")]
	[SerializeField]
	[Token(Token = "0x400010F")]
	internal GlyphRenderMode m_AtlasRenderMode; //Field offset: 0x15C
	[FieldOffset(Offset = "0x160")]
	[SerializeField]
	[Token(Token = "0x4000110")]
	private List<GlyphRect> m_UsedGlyphRects; //Field offset: 0x160
	[FieldOffset(Offset = "0x168")]
	[SerializeField]
	[Token(Token = "0x4000111")]
	private List<GlyphRect> m_FreeGlyphRects; //Field offset: 0x168
	[FieldOffset(Offset = "0x170")]
	[SerializeField]
	[Token(Token = "0x4000112")]
	internal FontFeatureTable m_FontFeatureTable; //Field offset: 0x170
	[FieldOffset(Offset = "0x178")]
	[SerializeField]
	[Token(Token = "0x4000113")]
	internal bool m_ShouldReimportFontFeatures; //Field offset: 0x178
	[FieldOffset(Offset = "0x180")]
	[SerializeField]
	[Token(Token = "0x4000114")]
	internal List<FontAsset> m_FallbackFontAssetTable; //Field offset: 0x180
	[FieldOffset(Offset = "0x188")]
	[SerializeField]
	[Token(Token = "0x4000115")]
	private FontWeightPair[] m_FontWeightTable; //Field offset: 0x188
	[FieldOffset(Offset = "0x190")]
	[FormerlySerializedAs("normalStyle")]
	[SerializeField]
	[Token(Token = "0x4000116")]
	internal float m_RegularStyleWeight; //Field offset: 0x190
	[FieldOffset(Offset = "0x194")]
	[FormerlySerializedAs("normalSpacingOffset")]
	[SerializeField]
	[Token(Token = "0x4000117")]
	internal float m_RegularStyleSpacing; //Field offset: 0x194
	[FieldOffset(Offset = "0x198")]
	[FormerlySerializedAs("boldStyle")]
	[SerializeField]
	[Token(Token = "0x4000118")]
	internal float m_BoldStyleWeight; //Field offset: 0x198
	[FieldOffset(Offset = "0x19C")]
	[FormerlySerializedAs("boldSpacing")]
	[SerializeField]
	[Token(Token = "0x4000119")]
	internal float m_BoldStyleSpacing; //Field offset: 0x19C
	[FieldOffset(Offset = "0x1A0")]
	[FormerlySerializedAs("italicStyle")]
	[SerializeField]
	[Token(Token = "0x400011A")]
	internal byte m_ItalicStyleSlant; //Field offset: 0x1A0
	[FieldOffset(Offset = "0x1A1")]
	[FormerlySerializedAs("tabSize")]
	[SerializeField]
	[Token(Token = "0x400011B")]
	internal byte m_TabMultiple; //Field offset: 0x1A1
	[FieldOffset(Offset = "0x1A2")]
	[Token(Token = "0x400011C")]
	internal bool IsFontAssetLookupTablesDirty; //Field offset: 0x1A2
	[FieldOffset(Offset = "0x1A8")]
	[Token(Token = "0x400011D")]
	private IntPtr m_NativeFontAsset; //Field offset: 0x1A8
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x400011E")]
	private List<Glyph> m_GlyphsToRender; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1B8")]
	[Token(Token = "0x400011F")]
	private List<Glyph> m_GlyphsRendered; //Field offset: 0x1B8
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x4000120")]
	private List<UInt32> m_GlyphIndexList; //Field offset: 0x1C0
	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x4000121")]
	private List<UInt32> m_GlyphIndexListNewlyAdded; //Field offset: 0x1C8
	[FieldOffset(Offset = "0x1D0")]
	[Token(Token = "0x4000122")]
	internal List<UInt32> m_GlyphsToAdd; //Field offset: 0x1D0
	[FieldOffset(Offset = "0x1D8")]
	[Token(Token = "0x4000123")]
	internal HashSet<UInt32> m_GlyphsToAddLookup; //Field offset: 0x1D8
	[FieldOffset(Offset = "0x1E0")]
	[Token(Token = "0x4000124")]
	internal List<Character> m_CharactersToAdd; //Field offset: 0x1E0
	[FieldOffset(Offset = "0x1E8")]
	[Token(Token = "0x4000125")]
	internal HashSet<UInt32> m_CharactersToAddLookup; //Field offset: 0x1E8
	[FieldOffset(Offset = "0x1F0")]
	[Token(Token = "0x4000126")]
	internal List<UInt32> s_MissingCharacterList; //Field offset: 0x1F0
	[FieldOffset(Offset = "0x1F8")]
	[Token(Token = "0x4000127")]
	internal HashSet<UInt32> m_MissingUnicodesFromFontFile; //Field offset: 0x1F8
	[FieldOffset(Offset = "0x200")]
	[Token(Token = "0x4000128")]
	internal Dictionary<ValueTuple`2<UInt32, UInt32>, UInt32> m_VariantGlyphIndexes; //Field offset: 0x200
	[FieldOffset(Offset = "0x208")]
	[Token(Token = "0x4000129")]
	internal bool m_IsClone; //Field offset: 0x208

	[Token(Token = "0x1700001D")]
	public internal int atlasHeight
	{
		[Address(RVA = "0x1A32670", Offset = "0x1A31870", Length = "0x9")]
		[CalledBy(Type = typeof(TextGenerator), Member = "SaveGlyphVertexInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(Color32), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextGenerator), Member = "DrawUnderlineMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Color32), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextGenerator), Member = "DrawTextHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Color32), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextLib), Member = "ProcessMeshInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeTextInfo), typeof(NativeTextGenerationSettings)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Token(Token = "0x600008A")]
		 get { } //Length: 9
		[Address(RVA = "0x1A32C30", Offset = "0x1A31E30", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600008B")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x1700001E")]
	public internal int atlasPadding
	{
		[Address(RVA = "0x1A32680", Offset = "0x1A31880", Length = "0x9")]
		[CallerCount(Count = 61)]
		[DeduplicatedMethod]
		[Token(Token = "0x600008C")]
		 get { } //Length: 9
		[Address(RVA = "0x189D970", Offset = "0x189CB70", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600008D")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x1700000E")]
	public AtlasPopulationMode atlasPopulationMode
	{
		[Address(RVA = "0x1A32690", Offset = "0x1A31890", Length = "0x9")]
		[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ConvertUssToNativeTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Nullable`1<Single>"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(FontAssetUtilities), Member = "GetCharacterFromFontAsset_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontAsset), typeof(bool), typeof(FontStyles), typeof(TextFontWeight), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(Character))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextSettings+<>c__DisplayClass96_0", Member = "<GetGlobalFallbacks>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextSettings+<>c__DisplayClass96_0", Member = "<GetGlobalFallbacks>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextSettings+<>c__DisplayClass96_0", Member = "<GetGlobalFallbacks>b__2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAsset)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextGenerator), Member = "GetTextElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(uint), typeof(FontAsset), typeof(FontStyles), typeof(TextFontWeight), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(TextElement))]
		[CallerCount(Count = 10)]
		[Token(Token = "0x6000070")]
		 get { } //Length: 9
		[Address(RVA = "0x165F430", Offset = "0x165E630", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000071")]
		 set { } //Length: 7
	}

	[Token(Token = "0x1700001F")]
	public internal GlyphRenderMode atlasRenderMode
	{
		[Address(RVA = "0x1A326A0", Offset = "0x1A318A0", Length = "0x9")]
		[CalledBy(Type = "UnityEngine.UIElements.ATGTextJobSystem", Member = "ConvertMeshInfoToUIRVertex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.ATGMeshInfo[]", "UnityEngine.UIElements.TempMeshAllocator", "UnityEngine.UIElements.TextElement", "System.Collections.Generic.List`1<Texture2D>", "System.Collections.Generic.List`1<NativeSlice`1<Vertex>>", "System.Collections.Generic.List`1<NativeSlice`1<UInt16>>", "System.Collections.Generic.List`1<GlyphRenderMode>", "System.Collections.Generic.List`1<Single>"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextGenerator), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(int))]
		[CallerCount(Count = 8)]
		[Token(Token = "0x600008E")]
		 get { } //Length: 9
		[Address(RVA = "0x189D920", Offset = "0x189CB20", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600008F")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000016")]
	public Texture2D atlasTexture
	{
		[Address(RVA = "0x1A326C0", Offset = "0x1A318C0", Length = "0x9C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x600007E")]
		 get { } //Length: 156
	}

	[Token(Token = "0x17000018")]
	public int atlasTextureCount
	{
		[Address(RVA = "0x1A326B0", Offset = "0x1A318B0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000081")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000017")]
	public Texture2D[] atlasTextures
	{
		[Address(RVA = "0x3FE880", Offset = "0x3FDA80", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600007F")]
		 get { } //Length: 8
		[Address(RVA = "0x1890C00", Offset = "0x188FE00", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000080")]
		 set { } //Length: 19
	}

	[Token(Token = "0x1700001C")]
	public internal int atlasWidth
	{
		[Address(RVA = "0x1A32760", Offset = "0x1A31960", Length = "0x9")]
		[CalledBy(Type = typeof(TextGenerator), Member = "SaveGlyphVertexInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(Color32), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextGenerator), Member = "DrawUnderlineMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Color32), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextGenerator), Member = "DrawTextHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Color32), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextLib), Member = "ProcessMeshInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeTextInfo), typeof(NativeTextGenerationSettings)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Token(Token = "0x6000088")]
		 get { } //Length: 9
		[Address(RVA = "0x1A32C40", Offset = "0x1A31E40", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000089")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000028")]
	public float boldStyleSpacing
	{
		[Address(RVA = "0x1A32770", Offset = "0x1A31970", Length = "0xB")]
		[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
		[CallerCount(Count = 2)]
		[Token(Token = "0x60000A2")]
		 get { } //Length: 11
		[Address(RVA = "0x1A32C50", Offset = "0x1A31E50", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A3")]
		 set { } //Length: 9
	}

	[Token(Token = "0x17000027")]
	public float boldStyleWeight
	{
		[Address(RVA = "0x1A32780", Offset = "0x1A31980", Length = "0xB")]
		[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Token(Token = "0x60000A0")]
		 get { } //Length: 11
		[Address(RVA = "0x1A32C60", Offset = "0x1A31E60", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A1")]
		 set { } //Length: 9
	}

	[Token(Token = "0x17000015")]
	public Dictionary<UInt32, Character> characterLookupTable
	{
		[Address(RVA = "0x1A32790", Offset = "0x1A31990", Length = "0x34")]
		[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextGenerator), Member = "GetPreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
		[Token(Token = "0x600007D")]
		 get { } //Length: 52
	}

	[Token(Token = "0x17000014")]
	public internal List<Character> characterTable
	{
		[Address(RVA = "0x1A327D0", Offset = "0x1A319D0", Length = "0xA")]
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextSettings+<>c__DisplayClass96_0", Member = "<GetGlobalFallbacks>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextSettings+<>c__DisplayClass96_0", Member = "<GetGlobalFallbacks>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextSettings+<>c__DisplayClass96_0", Member = "<GetGlobalFallbacks>b__2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAsset)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Token(Token = "0x600007B")]
		 get { } //Length: 10
		[Address(RVA = "0x4F7830", Offset = "0x4F6A30", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600007C")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x1700001B")]
	internal bool clearDynamicDataOnBuild
	{
		[Address(RVA = "0x1A327E0", Offset = "0x1A319E0", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000086")]
		internal get { } //Length: 10
		[Address(RVA = "0x1A32C70", Offset = "0x1A31E70", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000087")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x1700000F")]
	public FaceInfo faceInfo
	{
		[Address(RVA = "0x1A327F0", Offset = "0x1A319F0", Length = "0x45")]
		[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ConvertUssToNativeTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Nullable`1<Single>"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TextGenerator), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&), typeof(TextGenerationSettings), typeof(TextInfo), typeof(Boolean&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TextGenerator), Member = "DrawUnderlineMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Color32), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextGenerator), Member = "LayoutPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(TextHandle), Member = "UpdateWithHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TextInfo))]
		[CalledBy(Type = typeof(TextHandle), Member = "ConvertPixelUnitsToTextCoreRelativeUnits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(FontAsset)}, ReturnType = typeof(float))]
		[CalledBy(Type = typeof(TextHandle), Member = "GetLineHeightDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(float))]
		[CallerCount(Count = 40)]
		[Token(Token = "0x6000072")]
		 get { } //Length: 69
		[Address(RVA = "0x1A32C80", Offset = "0x1A31E80", Length = "0x1B3")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(FontAsset), Member = "get_nativeFontAsset", ReturnType = typeof(IntPtr))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000073")]
		 set { } //Length: 435
	}

	[Token(Token = "0x17000023")]
	public List<FontAsset> fallbackFontAssetTable
	{
		[Address(RVA = "0x1A32840", Offset = "0x1A31A40", Length = "0xA")]
		[CalledBy(Type = typeof(FontAssetUtilities), Member = "GetCharacterFromFontAsset_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontAsset), typeof(bool), typeof(FontStyles), typeof(TextFontWeight), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(Character))]
		[CallerCount(Count = 2)]
		[Token(Token = "0x6000098")]
		 get { } //Length: 10
		[Address(RVA = "0x1A32E40", Offset = "0x1A32040", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000099")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000010")]
	internal int familyNameHashCode
	{
		[Address(RVA = "0x1A32850", Offset = "0x1A31A50", Length = "0x42")]
		[CalledBy(Type = typeof(TextResourceManager), Member = "AddFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(TextUtilities), Member = "GetHashCodeCaseInSensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000074")]
		internal get { } //Length: 66
		[Address(RVA = "0x40DA90", Offset = "0x40CC90", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000075")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x1700000C")]
	public FontAssetCreationEditorSettings fontAssetCreationEditorSettings
	{
		[Address(RVA = "0x1A328A0", Offset = "0x1A31AA0", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600006C")]
		 get { } //Length: 59
		[Address(RVA = "0x1A32E60", Offset = "0x1A32060", Length = "0x42")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600006D")]
		 set { } //Length: 66
	}

	[Token(Token = "0x17000022")]
	public internal FontFeatureTable fontFeatureTable
	{
		[Address(RVA = "0x1A328E0", Offset = "0x1A31AE0", Length = "0xA")]
		[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = typeof(TextGenerator), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(TextGenerator), Member = "PopulateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextProcessingElement[])}, ReturnType = typeof(bool))]
		[CallerCount(Count = 8)]
		[Token(Token = "0x6000096")]
		 get { } //Length: 10
		[Address(RVA = "0x189DA50", Offset = "0x189CC50", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000097")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x17000024")]
	public internal FontWeightPair[] fontWeightTable
	{
		[Address(RVA = "0x1A328F0", Offset = "0x1A31AF0", Length = "0xA")]
		[CalledBy(Type = typeof(FontAssetUtilities), Member = "GetCharacterFromFontAsset_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontAsset), typeof(bool), typeof(FontStyles), typeof(TextFontWeight), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(Character))]
		[CallerCount(Count = 1)]
		[Token(Token = "0x600009A")]
		 get { } //Length: 10
		[Address(RVA = "0x189DA00", Offset = "0x189CC00", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600009B")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x17000021")]
	internal List<GlyphRect> freeGlyphRects
	{
		[Address(RVA = "0x1A32900", Offset = "0x1A31B00", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000094")]
		internal get { } //Length: 10
		[Address(RVA = "0x189DAA0", Offset = "0x189CCA0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000095")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x1700001A")]
	public bool getFontFeatures
	{
		[Address(RVA = "0x1A32910", Offset = "0x1A31B10", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000084")]
		 get { } //Length: 10
		[Address(RVA = "0x1A32EB0", Offset = "0x1A320B0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000085")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000013")]
	public Dictionary<UInt32, Glyph> glyphLookupTable
	{
		[Address(RVA = "0x1A32920", Offset = "0x1A31B20", Length = "0x34")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
		[Token(Token = "0x600007A")]
		 get { } //Length: 52
	}

	[Nullable(1)]
	[Token(Token = "0x17000012")]
	public internal List<Glyph> glyphTable
	{
		[Address(RVA = "0x1A32960", Offset = "0x1A31B60", Length = "0xA")]
		[CallerCount(Count = 0)]
		[NullableContext(1)]
		[Token(Token = "0x6000078")]
		 get { } //Length: 10
		[Address(RVA = "0x1673E10", Offset = "0x1673010", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[NullableContext(1)]
		[Token(Token = "0x6000079")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x17000019")]
	public bool isMultiAtlasTexturesEnabled
	{
		[Address(RVA = "0x1A32970", Offset = "0x1A31B70", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000082")]
		 get { } //Length: 10
		[Address(RVA = "0x1A32EC0", Offset = "0x1A320C0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000083")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000029")]
	public byte italicStyleSlant
	{
		[Address(RVA = "0x1A32980", Offset = "0x1A31B80", Length = "0xA")]
		[CalledBy(Type = typeof(TextGenerator), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&), typeof(TextGenerationSettings), typeof(TextInfo), typeof(Boolean&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Token(Token = "0x60000A4")]
		 get { } //Length: 10
		[Address(RVA = "0x1A32ED0", Offset = "0x1A320D0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60000A5")]
		 set { } //Length: 7
	}

	[Token(Token = "0x1700002B")]
	internal IntPtr nativeFontAsset
	{
		[Address(RVA = "0x1A32990", Offset = "0x1A31B90", Length = "0x20D")]
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextSettings+<>c__DisplayClass96_0", Member = "<GetGlobalFallbacks>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextSettings+<>c__DisplayClass96_0", Member = "<GetGlobalFallbacks>b__2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAsset)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextSettings+<>c__DisplayClass96_0", Member = "<GetGlobalFallbacks>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FontAsset), Member = "UpdateFaceInfo", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FontAsset), Member = "UpdateFallbacks", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FontAsset), Member = "UpdateWeightFallbacks", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(FontAsset), Member = "set_faceInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FaceInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ConvertUssToNativeTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Nullable`1<Single>"}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(FontAsset), Member = "CreateFontAssetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(FontAsset))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(FontAsset), Member = "GetWeightFallbacks", ReturnType = typeof(System.ValueTuple`2<IntPtr[], IntPtr[]>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(FontAsset), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FaceInfo), typeof(Font), typeof(Font), typeof(string), typeof(int), typeof(IntPtr[]), typeof(IntPtr[]), typeof(IntPtr[])}, ReturnType = typeof(IntPtr))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(FontAsset), Member = "GetFallbacks", ReturnType = typeof(IntPtr[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CallsDeduplicatedMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000103")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
		internal get { } //Length: 525
	}

	[Token(Token = "0x17000026")]
	public float regularStyleSpacing
	{
		[Address(RVA = "0x1A32BA0", Offset = "0x1A31DA0", Length = "0xB")]
		[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextGenerator), Member = "InsertNewLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Boolean&), typeof(Single&), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
		[CallerCount(Count = 7)]
		[Token(Token = "0x600009E")]
		 get { } //Length: 11
		[Address(RVA = "0x1A32EE0", Offset = "0x1A320E0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600009F")]
		 set { } //Length: 9
	}

	[Token(Token = "0x17000025")]
	public float regularStyleWeight
	{
		[Address(RVA = "0x1A32BB0", Offset = "0x1A31DB0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600009C")]
		 get { } //Length: 11
		[Address(RVA = "0x1A32EF0", Offset = "0x1A320F0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600009D")]
		 set { } //Length: 9
	}

	[Token(Token = "0x1700000D")]
	public internal Font sourceFontFile
	{
		[Address(RVA = "0x19AA7F0", Offset = "0x19A99F0", Length = "0xA")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600006E")]
		 get { } //Length: 10
		[Address(RVA = "0x2DD580", Offset = "0x2DC780", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600006F")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x17000011")]
	internal int styleNameHashCode
	{
		[Address(RVA = "0x1A32BC0", Offset = "0x1A31DC0", Length = "0x42")]
		[CalledBy(Type = typeof(TextResourceManager), Member = "AddFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(TextUtilities), Member = "GetHashCodeCaseInSensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000076")]
		internal get { } //Length: 66
		[Address(RVA = "0x1A32F00", Offset = "0x1A32100", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000077")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x1700002A")]
	public byte tabMultiple
	{
		[Address(RVA = "0x1A32C10", Offset = "0x1A31E10", Length = "0xA")]
		[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
		[CallerCount(Count = 2)]
		[Token(Token = "0x60000A6")]
		 get { } //Length: 10
		[Address(RVA = "0x1A32F10", Offset = "0x1A32110", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60000A7")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000020")]
	internal List<GlyphRect> usedGlyphRects
	{
		[Address(RVA = "0x1A32C20", Offset = "0x1A31E20", Length = "0xA")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000092")]
		internal get { } //Length: 10
		[Address(RVA = "0x1A32F20", Offset = "0x1A32120", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000093")]
		internal set { } //Length: 19
	}

	[Address(RVA = "0x1A31C80", Offset = "0x1A30E80", Length = "0x5DC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Int32>), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000113")]
	private static FontAsset() { }

	[Address(RVA = "0x1A32260", Offset = "0x1A31460", Length = "0x403")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(FontFeatureTable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.UInt32>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.ValueTuple`2<System.UInt32, System.UInt32>, System.UInt32>), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[Token(Token = "0x6000112")]
	public FontAsset() { }

	[Address(RVA = "0x1A24540", Offset = "0x1A23740", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000C4")]
	internal void AddCharacterToLookupCache(uint unicode, Character character) { }

	[Address(RVA = "0x1A24460", Offset = "0x1A23660", Length = "0xD7")]
	[CalledBy(Type = typeof(FontAsset), Member = "CreateCharacterAndAddToCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Glyph), typeof(FontStyles), typeof(TextFontWeight)}, ReturnType = typeof(Character))]
	[CalledBy(Type = typeof(TextGenerator), Member = "GetTextElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(uint), typeof(FontAsset), typeof(FontStyles), typeof(TextFontWeight), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(TextElement))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextUtilities), Member = "GetTextFontWeightIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextFontWeight)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000C5")]
	internal void AddCharacterToLookupCache(uint unicode, Character character, FontStyles fontStyle, TextFontWeight fontWeight) { }

	[Address(RVA = "0x1A245C0", Offset = "0x1A237C0", Length = "0x464")]
	[CalledBy(Type = typeof(FontAsset), Member = "ImportFontFeatures", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "InitializeDictionaryLookupTables", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FontAsset), Member = "TryAddGlyphToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Glyph&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FontAsset), Member = "UpdateFontFeaturesForNewlyAddedGlyphs", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "UpdateGSUBFontFeaturesForNewGlyphIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "UpdateLigatureSubstitutionRecords", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800D3450")]
	[Calls(Type = "UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord", Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord", "UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FontAsset), Member = "EnsureAdditionalCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "EnsureAdditionalCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 11)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000FD")]
	private void AddLigatureSubstitutionRecords(LigatureSubstitutionRecord[] records) { }

	[Address(RVA = "0x1A24A30", Offset = "0x1A23C30", Length = "0x36E")]
	[CalledBy(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "InitializeDictionaryLookupTables", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "ImportFontFeatures", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "UpdateDiacriticalMarkAdjustmentRecords", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180015380")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), "UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 24)]
	[Token(Token = "0x6000101")]
	private void AddMarkToBaseAdjustmentRecords(MarkToBaseAdjustmentRecord[] records) { }

	[Address(RVA = "0x1A24DA0", Offset = "0x1A23FA0", Length = "0x38D")]
	[CalledBy(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "InitializeDictionaryLookupTables", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "ImportFontFeatures", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "UpdateDiacriticalMarkAdjustmentRecords", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180015380")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), "UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 24)]
	[Token(Token = "0x6000102")]
	private void AddMarkToMarkAdjustmentRecords(MarkToMarkAdjustmentRecord[] records) { }

	[Address(RVA = "0x1A25130", Offset = "0x1A24330", Length = "0x37F")]
	[CalledBy(Type = typeof(FontAsset), Member = "UpdateGlyphAdjustmentRecords", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "InitializeDictionaryLookupTables", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "UpdateFontFeaturesForFontAssetsInQueue", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FontAsset), Member = "UpdateFontFeaturesForNewlyAddedGlyphs", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "UpdateGlyphAdjustmentRecordsForNewGlyphs", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "UpdateGPOSFontFeaturesForNewlyAddedGlyphs", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "ImportFontFeatures", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontAsset), Member = "EnsureAdditionalCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.Dictionary`2<TKey, TValue>", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "EnsureAdditionalCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GlyphPairAdjustmentRecord), Member = "get_firstAdjustmentRecord", ReturnType = typeof(GlyphAdjustmentRecord))]
	[Calls(Type = typeof(GlyphAdjustmentRecord), Member = "get_glyphValueRecord", ReturnType = typeof(GlyphValueRecord))]
	[Calls(Type = typeof(GlyphPairAdjustmentRecord), Member = "set_firstAdjustmentRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphAdjustmentRecord)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord>), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(GlyphPairAdjustmentRecord)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800D2AD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Token(Token = "0x60000FF")]
	private void AddPairAdjustmentRecords(GlyphPairAdjustmentRecord[] records) { }

	[Address(RVA = "0x1A254B0", Offset = "0x1A246B0", Length = "0x7BE")]
	[CalledBy(Type = typeof(FontAsset), Member = "AddSynthesizedCharactersAndFaceMetrics", ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(Glyph), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(GlyphMetrics), typeof(GlyphRect), typeof(float), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GlyphRect), Member = "get_zero", ReturnType = typeof(GlyphRect))]
	[Calls(Type = typeof(GlyphMetrics), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextUtilities), Member = "GetTextFontWeightIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextFontWeight)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(Array), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(Enum), Member = "GetValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Array))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(FontEngine), Member = "TryGetGlyphWithUnicodeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(GlyphLoadFlags), typeof(Glyph&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontEngine), Member = "GetGlyphIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000C3")]
	private void AddSynthesizedCharacter(uint unicode, bool isFontFaceLoaded, bool addImmediately = false) { }

	[Address(RVA = "0x1A25C70", Offset = "0x1A24E70", Length = "0x1FF")]
	[CalledBy(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FontAsset), Member = "LoadFontFace", ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "AddSynthesizedCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000C2")]
	internal void AddSynthesizedCharactersAndFaceMetrics() { }

	[Address(RVA = "0x1A25E70", Offset = "0x1A25070", Length = "0x24D")]
	[CalledBy(Type = typeof(FontAsset), Member = "UpdateFontAssetData", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "ClearFontAssetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "ClearCharacterAndGlyphTablesInternal", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(FontEngine), Member = "ResetAtlasTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = "Apply", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60000E1")]
	internal void ClearAtlasTextures(bool setAtlasSizeToZero = false) { }

	[Address(RVA = "0x1A260F0", Offset = "0x1A252F0", Length = "0x209")]
	[CalledBy(Type = typeof(FontAsset), Member = "UpdateFontAssetData", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "ClearFontAssetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "ClearCharacterAndGlyphTablesInternal", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000DF")]
	private void ClearCharacterAndGlyphTables() { }

	[Address(RVA = "0x1A260C0", Offset = "0x1A252C0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontAsset), Member = "ClearCharacterAndGlyphTables", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "ClearAtlasTextures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Token(Token = "0x60000DE")]
	internal void ClearCharacterAndGlyphTablesInternal() { }

	[Address(RVA = "0x1A26300", Offset = "0x1A25500", Length = "0x316")]
	[CalledBy(Type = typeof(FontAsset), Member = "ClearFontAssetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800303A0")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000BD")]
	internal void ClearFallbackCharacterTable() { }

	[Address(RVA = "0x1A26620", Offset = "0x1A25820", Length = "0x25A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontAsset), Member = "ClearAtlasTextures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "ClearCharacterAndGlyphTables", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "ClearFontFeaturesTables", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(WeakReference`1), Member = "TryGetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "ClearFallbackCharacterTable", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextEventManager), Member = "ON_FONT_PROPERTY_CHANGED", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000DD")]
	public void ClearFontAssetData(bool setAtlasSizeToZero = false) { }

	[Address(RVA = "0x1A26880", Offset = "0x1A25A80", Length = "0xF5")]
	[CalledBy(Type = typeof(FontAsset), Member = "UpdateFontAssetData", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "ClearFontAssetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x60000E0")]
	private void ClearFontFeaturesTables() { }

	[Address(RVA = "0x1A26980", Offset = "0x1A25B80", Length = "0xC4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextUtilities), Member = "GetTextFontWeightIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextFontWeight)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000C8")]
	internal bool ContainsCharacterInLookupCache(uint unicode, FontStyles fontStyle, TextFontWeight fontWeight) { }

	[Address(RVA = "0x1A287C0", Offset = "0x1A279C0", Length = "0x402")]
	[CalledBy(Type = typeof(FontAsset), Member = "get_nativeFontAsset", ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(FontAsset), Member = "EnsureNativeFontAssetIsCreated", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600010F")]
	private static IntPtr Create(FaceInfo faceInfo, Font sourceFontFile, Font sourceFont_EditorRef, string sourceFontFilePath, int fontInstanceID, IntPtr[] fallbacks, IntPtr[] weightFallbacks, IntPtr[] italicFallbacks) { }

	[Address(RVA = "0x1A28750", Offset = "0x1A27950", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000116")]
	private static IntPtr Create_Injected(in FaceInfo faceInfo, IntPtr sourceFontFile, IntPtr sourceFont_EditorRef, ref ManagedSpanWrapper sourceFontFilePath, int fontInstanceID, ref ManagedSpanWrapper fallbacks, ref ManagedSpanWrapper weightFallbacks, ref ManagedSpanWrapper italicFallbacks) { }

	[Address(RVA = "0x1A26A50", Offset = "0x1A25C50", Length = "0x1CF")]
	[CalledBy(Type = typeof(FontAsset), Member = "TryAddCharacterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontStyles), typeof(TextFontWeight), typeof(Character&), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "AddCharacterToLookupCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Character), typeof(FontStyles), typeof(TextFontWeight)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Token(Token = "0x60000F6")]
	private Character CreateCharacterAndAddToCache(uint unicode, Glyph glyph, FontStyles fontStyle, TextFontWeight fontWeight) { }

	[Address(RVA = "0x1A26C20", Offset = "0x1A25E20", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextUtilities), Member = "GetTextFontWeightIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextFontWeight)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000C9")]
	private uint CreateCompositeKey(uint unicode, FontStyles fontStyle = 0, TextFontWeight fontWeight = 400) { }

	[Address(RVA = "0x1A27C60", Offset = "0x1A26E60", Length = "0xFA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontEngine), Member = "TryGetSystemFontReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(FontReference&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(FontAsset))]
	[NullableContext(1)]
	[Token(Token = "0x60000AA")]
	internal static FontAsset CreateFontAsset(string familyName, string styleName, int pointSize, int padding, GlyphRenderMode renderMode) { }

	[Address(RVA = "0x1A27BA0", Offset = "0x1A26DA0", Length = "0xB5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontAsset), Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(int), typeof(int), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(FontAsset))]
	[Token(Token = "0x60000B0")]
	public static FontAsset CreateFontAsset(Font font) { }

	[Address(RVA = "0x1A27D60", Offset = "0x1A26F60", Length = "0xAC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontAsset), Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(FontAsset))]
	[Token(Token = "0x60000AE")]
	public static FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight) { }

	[Address(RVA = "0x1A27A00", Offset = "0x1A26C00", Length = "0x196")]
	[CalledBy(Type = typeof(FontAsset), Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(FontAsset))]
	[CalledBy(Type = typeof(FontAsset), Member = "CreateFontAssetInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(FontAsset))]
	[CalledBy(Type = typeof(FontAsset), Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(GlyphRenderMode)}, ReturnType = typeof(FontAsset))]
	[CalledBy(Type = typeof(FontAsset), Member = "CreateFontAssetFromFamilyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(FontAsset))]
	[CalledBy(Type = typeof(FontAsset), Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int)}, ReturnType = typeof(FontAsset))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(FontEngine), Member = "LoadFontFace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(int)}, ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "CreateFontAssetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(FontAsset))]
	[Token(Token = "0x60000AF")]
	private static FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport = true) { }

	[Address(RVA = "0x1A28160", Offset = "0x1A27360", Length = "0x5B9")]
	[CalledBy(Type = typeof(FontAsset), Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font)}, ReturnType = typeof(FontAsset))]
	[CalledBy(Type = typeof(FontAsset), Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(int), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(FontAsset))]
	[CalledBy(Type = typeof(FontAssetFactory), Member = "ConvertFontToFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font)}, ReturnType = typeof(FontAsset))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(FontAsset), Member = "CreateFontAssetFromFamilyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(FontAsset))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FontAsset), Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(FontAsset))]
	[Calls(Type = typeof(FontAsset), Member = "CreateFontAssetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(FontAsset))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(FontEngine), Member = "LoadFontFace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(float), typeof(int)}, ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Font), Member = "GetOSFallbacks", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60000B2")]
	private static FontAsset CreateFontAsset(Font font, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = 1, bool enableMultiAtlasSupport = true) { }

	[Address(RVA = "0x1A280B0", Offset = "0x1A272B0", Length = "0xAF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontAsset), Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(int), typeof(int), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(FontAsset))]
	[Token(Token = "0x60000B1")]
	public static FontAsset CreateFontAsset(Font font, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = 1, bool enableMultiAtlasSupport = true) { }

	[Address(RVA = "0x1A27E10", Offset = "0x1A27010", Length = "0x293")]
	[CalledBy(Type = typeof(FontAsset), Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(int), typeof(int), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(FontAsset))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontEngine), Member = "TryGetSystemFontReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(FontReference&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(FontAsset))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60000A8")]
	public static FontAsset CreateFontAsset(string familyName, string styleName, int pointSize = 90) { }

	[Address(RVA = "0x1A26C90", Offset = "0x1A25E90", Length = "0x165")]
	[CalledBy(Type = typeof(FontAsset), Member = "CreateFontAssetOSFallbackList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(int)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.FontAsset>))]
	[CalledBy(Type = typeof(FontAsset), Member = "CreateFontAssetWithOSFallbackList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(int)}, ReturnType = typeof(FontAsset))]
	[CalledBy(Type = typeof(FontAsset), Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(int), typeof(int), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(FontAsset))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontEngine), Member = "TryGetSystemFontReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(FontReference&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(FontAsset))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAssetFactory), Member = "SetHideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000AD")]
	private static FontAsset CreateFontAssetFromFamilyName(string familyName, int pointSize = 90) { }

	[Address(RVA = "0x1A26E00", Offset = "0x1A26000", Length = "0x80D")]
	[CalledBy(Type = typeof(FontAsset), Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(FontAsset))]
	[CalledBy(Type = typeof(FontAsset), Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(int), typeof(int), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(FontAsset))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextShaderUtilities), Member = "get_ShaderRef_MobileBitmap", ReturnType = typeof(Shader))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextShaderUtilities), Member = "get_ShaderRef_Sprite", ReturnType = typeof(Shader))]
	[Calls(Type = typeof(Material), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "SetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Texture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextShaderUtilities), Member = "get_ShaderRef_MobileSDF", ReturnType = typeof(Shader))]
	[Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontEngine), Member = "IsColorFontFace", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(FontAsset), Member = "get_nativeFontAsset", ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(FontEngine), Member = "GetFaceInfo", ReturnType = typeof(FaceInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ScriptableObject), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000B3")]
	private static FontAsset CreateFontAssetInstance(Font font, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport) { }

	[Address(RVA = "0x1A27610", Offset = "0x1A26810", Length = "0xFE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontEngine), Member = "TryGetSystemFontReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(FontReference&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(FontAsset))]
	[NullableContext(1)]
	[Token(Token = "0x60000A9")]
	internal static FontAsset CreateFontAssetInternal(string familyName, string styleName, int pointSize = 90) { }

	[Address(RVA = "0x1A27710", Offset = "0x1A26910", Length = "0x13C")]
	[CalledBy(Type = typeof(TextSettings), Member = "get_fallbackOSFontAssets", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.FontAsset>))]
	[CalledBy(Type = typeof(TextSettings), Member = "GetOSFontAssetList", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.FontAsset>))]
	[CalledBy(Type = typeof(TextSettings), Member = "GetGlobalFallbacks", ReturnType = typeof(IntPtr[]))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontAsset), Member = "CreateFontAssetFromFamilyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(FontAsset))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000AB")]
	internal static List<FontAsset> CreateFontAssetOSFallbackList(String[] fallbacksFamilyNames, int pointSize = 90) { }

	[Address(RVA = "0x1A27850", Offset = "0x1A26A50", Length = "0x1A8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontAsset), Member = "CreateFontAssetFromFamilyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(FontAsset))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000AC")]
	internal static FontAsset CreateFontAssetWithOSFallbackList(String[] fallbacksFamilyNames, int pointSize = 90) { }

	[Address(RVA = "0x1A28720", Offset = "0x1A27920", Length = "0x2A")]
	[CalledBy(Type = "UnityEngine.UIElements.ATGTextJobSystem", Member = "GenerateTextJobified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext", typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600010C")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static void CreateHbFaceIfNeeded() { }

	[Address(RVA = "0x1A28CF0", Offset = "0x1A27EF0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("FontAsset::Destroy")]
	[Token(Token = "0x6000111")]
	private static void Destroy(IntPtr ptr) { }

	[Address(RVA = "0x1A28BD0", Offset = "0x1A27DD0", Length = "0x119")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60000E2")]
	private void DestroyAtlasTextures() { }

	[Address(RVA = "0x6B3820", Offset = "0x6B2A20", Length = "0x69")]
	[CalledBy(Type = typeof(FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FontAsset), Member = "AddLigatureSubstitutionRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LigatureSubstitutionRecord[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "AddPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphPairAdjustmentRecord[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(List`1), Member = "set_Capacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600006A")]
	private static void EnsureAdditionalCapacity(List<T> container, int additionalCapacity) { }

	[Address(RVA = "0x6B3980", Offset = "0x6B2B80", Length = "0x62")]
	[CalledBy(Type = typeof(FontAsset), Member = "AddPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphPairAdjustmentRecord[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord>), Member = "EnsureCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600006B")]
	private static void EnsureAdditionalCapacity(Dictionary<TKey, TValue> container, int additionalCapacity) { }

	[Address(RVA = "0x1A28D30", Offset = "0x1A27F30", Length = "0x206")]
	[CalledBy(Type = "UnityEngine.UIElements.ATGTextJobSystem", Member = "GenerateTextJobified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext", typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "GetFallbacks", ReturnType = typeof(IntPtr[]))]
	[CalledBy(Type = typeof(FontAsset), Member = "GetWeightFallbacks", ReturnType = typeof(System.ValueTuple`2<IntPtr[], IntPtr[]>))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FontAsset), Member = "GetFallbacks", ReturnType = typeof(IntPtr[]))]
	[Calls(Type = typeof(FontAsset), Member = "GetWeightFallbacks", ReturnType = typeof(System.ValueTuple`2<IntPtr[], IntPtr[]>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FaceInfo), typeof(Font), typeof(Font), typeof(string), typeof(int), typeof(IntPtr[]), typeof(IntPtr[]), typeof(IntPtr[])}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000104")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal void EnsureNativeFontAssetIsCreated() { }

	[Address(RVA = "0x1A32670", Offset = "0x1A31870", Length = "0x9")]
	[CalledBy(Type = typeof(TextGenerator), Member = "SaveGlyphVertexInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(Color32), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "DrawUnderlineMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Color32), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "DrawTextHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Color32), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextLib), Member = "ProcessMeshInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeTextInfo), typeof(NativeTextGenerationSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Token(Token = "0x600008A")]
	public int get_atlasHeight() { }

	[Address(RVA = "0x1A32680", Offset = "0x1A31880", Length = "0x9")]
	[CallerCount(Count = 61)]
	[DeduplicatedMethod]
	[Token(Token = "0x600008C")]
	public int get_atlasPadding() { }

	[Address(RVA = "0x1A32690", Offset = "0x1A31890", Length = "0x9")]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ConvertUssToNativeTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Nullable`1<Single>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FontAssetUtilities), Member = "GetCharacterFromFontAsset_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontAsset), typeof(bool), typeof(FontStyles), typeof(TextFontWeight), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(Character))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextSettings+<>c__DisplayClass96_0", Member = "<GetGlobalFallbacks>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextSettings+<>c__DisplayClass96_0", Member = "<GetGlobalFallbacks>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextSettings+<>c__DisplayClass96_0", Member = "<GetGlobalFallbacks>b__2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "GetTextElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(uint), typeof(FontAsset), typeof(FontStyles), typeof(TextFontWeight), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(TextElement))]
	[CallerCount(Count = 10)]
	[Token(Token = "0x6000070")]
	public AtlasPopulationMode get_atlasPopulationMode() { }

	[Address(RVA = "0x1A326A0", Offset = "0x1A318A0", Length = "0x9")]
	[CalledBy(Type = "UnityEngine.UIElements.ATGTextJobSystem", Member = "ConvertMeshInfoToUIRVertex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.ATGMeshInfo[]", "UnityEngine.UIElements.TempMeshAllocator", "UnityEngine.UIElements.TextElement", "System.Collections.Generic.List`1<Texture2D>", "System.Collections.Generic.List`1<NativeSlice`1<Vertex>>", "System.Collections.Generic.List`1<NativeSlice`1<UInt16>>", "System.Collections.Generic.List`1<GlyphRenderMode>", "System.Collections.Generic.List`1<Single>"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(int))]
	[CallerCount(Count = 8)]
	[Token(Token = "0x600008E")]
	public GlyphRenderMode get_atlasRenderMode() { }

	[Address(RVA = "0x1A326C0", Offset = "0x1A318C0", Length = "0x9C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600007E")]
	public Texture2D get_atlasTexture() { }

	[Address(RVA = "0x1A326B0", Offset = "0x1A318B0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000081")]
	public int get_atlasTextureCount() { }

	[Address(RVA = "0x3FE880", Offset = "0x3FDA80", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600007F")]
	public Texture2D[] get_atlasTextures() { }

	[Address(RVA = "0x1A32760", Offset = "0x1A31960", Length = "0x9")]
	[CalledBy(Type = typeof(TextGenerator), Member = "SaveGlyphVertexInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(Color32), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "DrawUnderlineMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Color32), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "DrawTextHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Color32), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextLib), Member = "ProcessMeshInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeTextInfo), typeof(NativeTextGenerationSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Token(Token = "0x6000088")]
	public int get_atlasWidth() { }

	[Address(RVA = "0x1A32770", Offset = "0x1A31970", Length = "0xB")]
	[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x60000A2")]
	public float get_boldStyleSpacing() { }

	[Address(RVA = "0x1A32780", Offset = "0x1A31980", Length = "0xB")]
	[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x60000A0")]
	public float get_boldStyleWeight() { }

	[Address(RVA = "0x1A32790", Offset = "0x1A31990", Length = "0x34")]
	[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "GetPreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Token(Token = "0x600007D")]
	public Dictionary<UInt32, Character> get_characterLookupTable() { }

	[Address(RVA = "0x1A327D0", Offset = "0x1A319D0", Length = "0xA")]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextSettings+<>c__DisplayClass96_0", Member = "<GetGlobalFallbacks>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextSettings+<>c__DisplayClass96_0", Member = "<GetGlobalFallbacks>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextSettings+<>c__DisplayClass96_0", Member = "<GetGlobalFallbacks>b__2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAsset)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Token(Token = "0x600007B")]
	public List<Character> get_characterTable() { }

	[Address(RVA = "0x1A327E0", Offset = "0x1A319E0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000086")]
	internal bool get_clearDynamicDataOnBuild() { }

	[Address(RVA = "0x1A327F0", Offset = "0x1A319F0", Length = "0x45")]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ConvertUssToNativeTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Nullable`1<Single>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextGenerator), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&), typeof(TextGenerationSettings), typeof(TextInfo), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextGenerator), Member = "DrawUnderlineMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Color32), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "LayoutPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(TextHandle), Member = "UpdateWithHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TextInfo))]
	[CalledBy(Type = typeof(TextHandle), Member = "ConvertPixelUnitsToTextCoreRelativeUnits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(FontAsset)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(TextHandle), Member = "GetLineHeightDefault", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(float))]
	[CallerCount(Count = 40)]
	[Token(Token = "0x6000072")]
	public FaceInfo get_faceInfo() { }

	[Address(RVA = "0x1A32840", Offset = "0x1A31A40", Length = "0xA")]
	[CalledBy(Type = typeof(FontAssetUtilities), Member = "GetCharacterFromFontAsset_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontAsset), typeof(bool), typeof(FontStyles), typeof(TextFontWeight), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(Character))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x6000098")]
	public List<FontAsset> get_fallbackFontAssetTable() { }

	[Address(RVA = "0x1A32850", Offset = "0x1A31A50", Length = "0x42")]
	[CalledBy(Type = typeof(TextResourceManager), Member = "AddFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(TextUtilities), Member = "GetHashCodeCaseInSensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000074")]
	internal int get_familyNameHashCode() { }

	[Address(RVA = "0x1A328A0", Offset = "0x1A31AA0", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600006C")]
	public FontAssetCreationEditorSettings get_fontAssetCreationEditorSettings() { }

	[Address(RVA = "0x1A328E0", Offset = "0x1A31AE0", Length = "0xA")]
	[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(TextGenerator), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextProcessingElement[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 8)]
	[Token(Token = "0x6000096")]
	public FontFeatureTable get_fontFeatureTable() { }

	[Address(RVA = "0x1A328F0", Offset = "0x1A31AF0", Length = "0xA")]
	[CalledBy(Type = typeof(FontAssetUtilities), Member = "GetCharacterFromFontAsset_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontAsset), typeof(bool), typeof(FontStyles), typeof(TextFontWeight), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(Character))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x600009A")]
	public FontWeightPair[] get_fontWeightTable() { }

	[Address(RVA = "0x1A32900", Offset = "0x1A31B00", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000094")]
	internal List<GlyphRect> get_freeGlyphRects() { }

	[Address(RVA = "0x1A32910", Offset = "0x1A31B10", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000084")]
	public bool get_getFontFeatures() { }

	[Address(RVA = "0x1A32920", Offset = "0x1A31B20", Length = "0x34")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Token(Token = "0x600007A")]
	public Dictionary<UInt32, Glyph> get_glyphLookupTable() { }

	[Address(RVA = "0x1A32960", Offset = "0x1A31B60", Length = "0xA")]
	[CallerCount(Count = 0)]
	[NullableContext(1)]
	[Token(Token = "0x6000078")]
	public List<Glyph> get_glyphTable() { }

	[Address(RVA = "0x1A32970", Offset = "0x1A31B70", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000082")]
	public bool get_isMultiAtlasTexturesEnabled() { }

	[Address(RVA = "0x1A32980", Offset = "0x1A31B80", Length = "0xA")]
	[CalledBy(Type = typeof(TextGenerator), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&), typeof(TextGenerationSettings), typeof(TextInfo), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x60000A4")]
	public byte get_italicStyleSlant() { }

	[Address(RVA = "0x1A32990", Offset = "0x1A31B90", Length = "0x20D")]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextSettings+<>c__DisplayClass96_0", Member = "<GetGlobalFallbacks>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextSettings+<>c__DisplayClass96_0", Member = "<GetGlobalFallbacks>b__2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextSettings+<>c__DisplayClass96_0", Member = "<GetGlobalFallbacks>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "UpdateFaceInfo", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "UpdateFallbacks", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "UpdateWeightFallbacks", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "set_faceInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FaceInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ConvertUssToNativeTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Nullable`1<Single>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FontAsset), Member = "CreateFontAssetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(FontAsset))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(FontAsset), Member = "GetWeightFallbacks", ReturnType = typeof(System.ValueTuple`2<IntPtr[], IntPtr[]>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FaceInfo), typeof(Font), typeof(Font), typeof(string), typeof(int), typeof(IntPtr[]), typeof(IntPtr[]), typeof(IntPtr[])}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FontAsset), Member = "GetFallbacks", ReturnType = typeof(IntPtr[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000103")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal IntPtr get_nativeFontAsset() { }

	[Address(RVA = "0x1A32BA0", Offset = "0x1A31DA0", Length = "0xB")]
	[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "InsertNewLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Boolean&), typeof(Single&), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 7)]
	[Token(Token = "0x600009E")]
	public float get_regularStyleSpacing() { }

	[Address(RVA = "0x1A32BB0", Offset = "0x1A31DB0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600009C")]
	public float get_regularStyleWeight() { }

	[Address(RVA = "0x19AA7F0", Offset = "0x19A99F0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600006E")]
	public Font get_sourceFontFile() { }

	[Address(RVA = "0x1A32BC0", Offset = "0x1A31DC0", Length = "0x42")]
	[CalledBy(Type = typeof(TextResourceManager), Member = "AddFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(TextUtilities), Member = "GetHashCodeCaseInSensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000076")]
	internal int get_styleNameHashCode() { }

	[Address(RVA = "0x1A32C10", Offset = "0x1A31E10", Length = "0xA")]
	[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x60000A6")]
	public byte get_tabMultiple() { }

	[Address(RVA = "0x1A32C20", Offset = "0x1A31E20", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000092")]
	internal List<GlyphRect> get_usedGlyphRects() { }

	[Address(RVA = "0x1A28F40", Offset = "0x1A28140", Length = "0xC9")]
	[CalledBy(Type = typeof(FontAssetUtilities), Member = "GetCharacterFromFontAsset_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontAsset), typeof(bool), typeof(FontStyles), typeof(TextFontWeight), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(Character))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextUtilities), Member = "GetTextFontWeightIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextFontWeight)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000C6")]
	internal bool GetCharacterInLookupCache(uint unicode, FontStyles fontStyle, TextFontWeight fontWeight, out Character character) { }

	[Address(RVA = "0x1A29100", Offset = "0x1A28300", Length = "0xE6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60000D7")]
	public static string GetCharacters(FontAsset fontAsset) { }

	[Address(RVA = "0x1A29010", Offset = "0x1A28210", Length = "0xE3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60000D8")]
	public static Int32[] GetCharactersArray(FontAsset fontAsset) { }

	[Address(RVA = "0x1A291F0", Offset = "0x1A283F0", Length = "0x2FC")]
	[CalledBy(Type = typeof(FontAsset), Member = "get_nativeFontAsset", ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(FontAsset), Member = "EnsureNativeFontAssetIsCreated", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "UpdateFallbacks", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002D410")]
	[Calls(Type = typeof(FontAsset), Member = "EnsureNativeFontAssetIsCreated", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "HasRecursion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000108")]
	internal IntPtr[] GetFallbacks() { }

	[Address(RVA = "0x1A294F0", Offset = "0x1A286F0", Length = "0x76")]
	[CalledBy(Type = typeof(TextLib), Member = "ProcessMeshInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeTextInfo), typeof(NativeTextGenerationSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = "TValue")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000B4")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal static FontAsset GetFontAssetByID(int id) { }

	[Address(RVA = "0x1A29570", Offset = "0x1A28770", Length = "0x116")]
	[CalledBy(Type = typeof(TextGenerator), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextProcessingElement[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "LoadFontFace", ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontEngine), Member = "GetGlyphIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000DA")]
	internal uint GetGlyphIndex(uint unicode, out bool success) { }

	[Address(RVA = "0x1A29690", Offset = "0x1A28890", Length = "0x102")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "LoadFontFace", ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontEngine), Member = "GetGlyphIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000D9")]
	internal uint GetGlyphIndex(uint unicode) { }

	[Address(RVA = "0x1A297A0", Offset = "0x1A289A0", Length = "0x83")]
	[CalledBy(Type = typeof(TextGenerator), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextProcessingElement[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FontAsset), Member = "LoadFontFace", ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontEngine), Member = "GetVariantGlyphIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
	[Token(Token = "0x60000DB")]
	internal uint GetGlyphVariantIndex(uint unicode, uint variantSelectorUnicode) { }

	[Address(RVA = "0x1A29830", Offset = "0x1A28A30", Length = "0x325")]
	[CalledBy(Type = typeof(FontAsset), Member = "get_nativeFontAsset", ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(FontAsset), Member = "EnsureNativeFontAssetIsCreated", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "UpdateWeightFallbacks", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(FontAsset), Member = "HasRecursion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "EnsureNativeFontAssetIsCreated", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600010B")]
	private ValueTuple<IntPtr[], IntPtr[]> GetWeightFallbacks() { }

	[Address(RVA = "0x1A29E90", Offset = "0x1A29090", Length = "0x397")]
	[CalledBy(Type = typeof(FontAsset), Member = "HasCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "TryAddCharacterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontStyles), typeof(TextFontWeight), typeof(Character&), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Int32>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "HasCharacter_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontStyles), typeof(TextFontWeight), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x60000D1")]
	public bool HasCharacter(uint character, bool searchFallbacks = false, bool tryAddCharacter = false) { }

	[Address(RVA = "0x1A2A230", Offset = "0x1A29430", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60000CF")]
	public bool HasCharacter(int character) { }

	[Address(RVA = "0x1A2A2B0", Offset = "0x1A294B0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontAsset), Member = "HasCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60000D0")]
	public bool HasCharacter(char character, bool searchFallbacks = false, bool tryAddCharacter = false) { }

	[Address(RVA = "0x1A29B90", Offset = "0x1A28D90", Length = "0x2F0")]
	[CalledBy(Type = typeof(FontAsset), Member = "HasCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FontAsset), Member = "HasCharacter_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontStyles), typeof(TextFontWeight), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FontAsset), Member = "HasCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UInt32[]&), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "HasCharacter_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontStyles), typeof(TextFontWeight), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(TextUtilities), Member = "GetTextFontWeightIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextFontWeight)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "TryAddCharacterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontStyles), typeof(TextFontWeight), typeof(Character&), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000D3")]
	private bool HasCharacter_Internal(uint character, FontStyles fontStyle = 0, TextFontWeight fontWeight = 400, bool searchFallbacks = false, bool tryAddCharacter = false) { }

	[Address(RVA = "0x1A2A850", Offset = "0x1A29A50", Length = "0x15A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(FontAssetUtilities), Member = "GetCodePoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800304C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000D4")]
	public bool HasCharacters(string text, out List<Char>& missingCharacters) { }

	[Address(RVA = "0x1A2A390", Offset = "0x1A29590", Length = "0x4B8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontAsset), Member = "HasCharacter_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontStyles), typeof(TextFontWeight), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Int32>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "TryAddCharacterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontStyles), typeof(TextFontWeight), typeof(Character&), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800303A0")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAssetUtilities), Member = "GetCodePoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x60000D5")]
	public bool HasCharacters(string text, out UInt32[] missingCharacters, bool searchFallbacks = false, bool tryAddCharacter = false) { }

	[Address(RVA = "0x1A2A2D0", Offset = "0x1A294D0", Length = "0xB3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAssetUtilities), Member = "GetCodePoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000D6")]
	public bool HasCharacters(string text) { }

	[Address(RVA = "0x1A29B60", Offset = "0x1A28D60", Length = "0x22")]
	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60000D2")]
	private bool HasCharacterWithStyle_Internal(uint character, FontStyles fontStyle, TextFontWeight fontWeight, bool searchFallbacks = false, bool tryAddCharacter = false) { }

	[Address(RVA = "0x1A2AD60", Offset = "0x1A29F60", Length = "0x93")]
	[CalledBy(Type = typeof(FontAsset), Member = "GetFallbacks", ReturnType = typeof(IntPtr[]))]
	[CalledBy(Type = typeof(FontAsset), Member = "GetWeightFallbacks", ReturnType = typeof(System.ValueTuple`2<IntPtr[], IntPtr[]>))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "HasRecursionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000109")]
	private bool HasRecursion(FontAsset fontAsset) { }

	[Address(RVA = "0x1A2A9B0", Offset = "0x1A29BB0", Length = "0x3AB")]
	[CalledBy(Type = typeof(FontAsset), Member = "HasRecursion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FontAsset), Member = "HasRecursionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(HashSet`1), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "HasRecursionInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HashSet`1), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600010A")]
	private bool HasRecursionInternal(FontAsset fontAsset) { }

	[Address(RVA = "0x1A2AE00", Offset = "0x1A2A000", Length = "0xFF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FontAsset), Member = "LoadFontFace", ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontEngine), Member = "GetAllPairAdjustmentRecords", ReturnType = typeof(GlyphPairAdjustmentRecord[]))]
	[Calls(Type = typeof(FontAsset), Member = "AddPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphPairAdjustmentRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetAllMarkToBaseAdjustmentRecords", ReturnType = typeof(MarkToBaseAdjustmentRecord[]))]
	[Calls(Type = typeof(FontAsset), Member = "AddMarkToBaseAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarkToBaseAdjustmentRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetAllMarkToMarkAdjustmentRecords", ReturnType = typeof(MarkToMarkAdjustmentRecord[]))]
	[Calls(Type = typeof(FontAsset), Member = "AddMarkToMarkAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarkToMarkAdjustmentRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetAllLigatureSubstitutionRecords", ReturnType = typeof(LigatureSubstitutionRecord[]))]
	[Calls(Type = typeof(FontAsset), Member = "AddLigatureSubstitutionRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LigatureSubstitutionRecord[])}, ReturnType = typeof(void))]
	[Token(Token = "0x60000FA")]
	internal void ImportFontFeatures() { }

	[Address(RVA = "0x1A2AF00", Offset = "0x1A2A100", Length = "0x245")]
	[CalledBy(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "InitializeDictionaryLookupTables", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontAsset), Member = "InitializeLookup", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICollection), typeof(Dictionary`2<UInt32, Object>&), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Token(Token = "0x60000BC")]
	internal void InitializeCharacterLookupDictionary() { }

	[Address(RVA = "0x1A2B150", Offset = "0x1A2A350", Length = "0x15A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontAsset), Member = "AddPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphPairAdjustmentRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "InitializeGlyphPairAdjustmentRecordsLookupDictionary", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "InitializeLigatureSubstitutionLookupDictionary", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "AddLigatureSubstitutionRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LigatureSubstitutionRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetAllLigatureSubstitutionRecords", ReturnType = typeof(LigatureSubstitutionRecord[]))]
	[Calls(Type = typeof(FontAsset), Member = "AddMarkToMarkAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarkToMarkAdjustmentRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetAllMarkToMarkAdjustmentRecords", ReturnType = typeof(MarkToMarkAdjustmentRecord[]))]
	[Calls(Type = typeof(FontAsset), Member = "AddMarkToBaseAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarkToBaseAdjustmentRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "InitializeMarkToMarkAdjustmentRecordsLookupDictionary", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "InitializeMarkToBaseAdjustmentRecordsLookupDictionary", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetAllPairAdjustmentRecords", ReturnType = typeof(GlyphPairAdjustmentRecord[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontAsset), Member = "LoadFontFace", ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FontAsset), Member = "InitializeCharacterLookupDictionary", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "InitializeGlyphLookupDictionary", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetAllMarkToBaseAdjustmentRecords", ReturnType = typeof(MarkToBaseAdjustmentRecord[]))]
	[Token(Token = "0x60000B8")]
	internal void InitializeDictionaryLookupTables() { }

	[Address(RVA = "0x1A2B2B0", Offset = "0x1A2A4B0", Length = "0x224")]
	[CalledBy(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "InitializeDictionaryLookupTables", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontAsset), Member = "InitializeLookup", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICollection), typeof(Dictionary`2<UInt32, Object>&), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "InitializeList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICollection), "System.Collections.Generic.List`1<T>&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800303A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60000BB")]
	internal void InitializeGlyphLookupDictionary() { }

	[Address(RVA = "0x1A2B4E0", Offset = "0x1A2A6E0", Length = "0x2DA")]
	[CalledBy(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "InitializeDictionaryLookupTables", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontAsset), Member = "InitializeLookup", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICollection), "System.Collections.Generic.Dictionary`2<UInt32, T>&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(GlyphPairAdjustmentRecord), Member = "get_firstAdjustmentRecord", ReturnType = typeof(GlyphAdjustmentRecord))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord>), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(GlyphPairAdjustmentRecord)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000BF")]
	internal void InitializeGlyphPairAdjustmentRecordsLookupDictionary() { }

	[Address(RVA = "0x1A2B7C0", Offset = "0x1A2A9C0", Length = "0x347")]
	[CalledBy(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "InitializeDictionaryLookupTables", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontAsset), Member = "InitializeLookup", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICollection), typeof(Dictionary`2<UInt32, Object>&), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800D3450")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000BE")]
	internal void InitializeLigatureSubstitutionLookupDictionary() { }

	[Address(RVA = "0x6B3B50", Offset = "0x6B2D50", Length = "0xE7")]
	[CalledBy(Type = typeof(FontAsset), Member = "InitializeGlyphLookupDictionary", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(List`1), Member = "set_Capacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000BA")]
	private static void InitializeList(ICollection source, ref List<T>& list, int defaultCapacity = 16) { }

	[Address(RVA = "0x6B3C40", Offset = "0x6B2E40", Length = "0xEA")]
	[CalledBy(Type = typeof(FontAsset), Member = "InitializeGlyphPairAdjustmentRecordsLookupDictionary", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord>), Member = "EnsureCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000B9")]
	private static void InitializeLookup(ICollection source, ref Dictionary<UInt32, T>& lookup, int defaultCapacity = 16) { }

	[Address(RVA = "0x1A2BB10", Offset = "0x1A2AD10", Length = "0x21E")]
	[CalledBy(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "InitializeDictionaryLookupTables", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontAsset), Member = "InitializeLookup", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICollection), typeof(Dictionary`2<UInt32, MarkToBaseAdjustmentRecord>&), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord>), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), "UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x60000C0")]
	internal void InitializeMarkToBaseAdjustmentRecordsLookupDictionary() { }

	[Address(RVA = "0x1A2BD30", Offset = "0x1A2AF30", Length = "0x21E")]
	[CalledBy(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "InitializeDictionaryLookupTables", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontAsset), Member = "InitializeLookup", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICollection), typeof(Dictionary`2<UInt32, MarkToMarkAdjustmentRecord>&), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord>), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), "UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x60000C1")]
	internal void InitializeMarkToMarkAdjustmentRecordsLookupDictionary() { }

	[Address(RVA = "0x1A2BF50", Offset = "0x1A2B150", Length = "0x19")]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextHandle", Member = "ConvertUssToTextGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "System.Nullable`1<Single>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextGenerator), Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextInfo), typeof(TextGenerationSettings), typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = typeof(TextGenerator), Member = "Prepare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.IMGUITextHandle", Member = "ConvertGUIStyleToGenerationSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), "UnityEngine.GUIStyle", typeof(Color), typeof(string), typeof(Rect)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Token(Token = "0x6000090")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal bool IsBitmap() { }

	[Address(RVA = "0x1A2BF70", Offset = "0x1A2B170", Length = "0xE")]
	[CalledBy(Type = typeof(TextGenerator), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextGenerator), Member = "GetTextElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(uint), typeof(FontAsset), typeof(FontStyles), typeof(TextFontWeight), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(TextElement))]
	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextProcessingElement[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextGenerator), Member = "GetEllipsisSpecialCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000091")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal bool IsRaster() { }

	[Address(RVA = "0x1A2BF80", Offset = "0x1A2B180", Length = "0x163")]
	[CalledBy(Type = typeof(FontAsset), Member = "TryAddGlyphInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Glyph&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FontAsset), Member = "ImportFontFeatures", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "TryAddCharacterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontStyles), typeof(TextFontWeight), typeof(Character&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FontAsset), Member = "GetGlyphVariantIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(FontAsset), Member = "GetGlyphIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Boolean&)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FontAsset), Member = "AddSynthesizedCharactersAndFaceMetrics", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "InitializeDictionaryLookupTables", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "GetGlyphIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(FontEngine), Member = "LoadFontFace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(float), typeof(int)}, ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(FontEngine), Member = "LoadFontFace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(int)}, ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontEngine), Member = "LoadFontFace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(float)}, ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 7)]
	[Token(Token = "0x60000CA")]
	internal FontEngineError LoadFontFace() { }

	[Address(RVA = "0x1A2C0F0", Offset = "0x1A2B2F0", Length = "0x24E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000B6")]
	private void OnDestroy() { }

	[Address(RVA = "0x1A2C340", Offset = "0x1A2B540", Length = "0x879")]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(FontAsset), Member = "InitializeMarkToMarkAdjustmentRecordsLookupDictionary", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(FaceInfo), Member = "get_strikethroughOffset", ReturnType = typeof(float))]
	[Calls(Type = typeof(Material), Member = "HasProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(JobsUtility), Member = "get_IsExecutingJob", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(FontAsset), Member = "AddSynthesizedCharactersAndFaceMetrics", ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextUtilities), Member = "GetHashCodeCaseInSensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TextResourceManager), Member = "AddFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "RegisterCallbackInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FontAsset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetFaceInfo", ReturnType = typeof(FaceInfo))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(FontAsset), Member = "InitializeMarkToBaseAdjustmentRecordsLookupDictionary", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "InitializeGlyphPairAdjustmentRecordsLookupDictionary", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FontAsset), Member = "InitializeGlyphLookupDictionary", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "InitializeCharacterLookupDictionary", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "LoadFontFace", ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontEngine), Member = "GetAllPairAdjustmentRecords", ReturnType = typeof(GlyphPairAdjustmentRecord[]))]
	[Calls(Type = typeof(FontAsset), Member = "AddPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphPairAdjustmentRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetAllMarkToBaseAdjustmentRecords", ReturnType = typeof(MarkToBaseAdjustmentRecord[]))]
	[Calls(Type = typeof(FontAsset), Member = "AddMarkToBaseAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarkToBaseAdjustmentRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetAllMarkToMarkAdjustmentRecords", ReturnType = typeof(MarkToMarkAdjustmentRecord[]))]
	[Calls(Type = typeof(FontAsset), Member = "AddMarkToMarkAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarkToMarkAdjustmentRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetAllLigatureSubstitutionRecords", ReturnType = typeof(LigatureSubstitutionRecord[]))]
	[Calls(Type = typeof(FontAsset), Member = "AddLigatureSubstitutionRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LigatureSubstitutionRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "InitializeLigatureSubstitutionLookupDictionary", ReturnType = typeof(void))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 21)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000B7")]
	public void ReadFontAssetDefinition() { }

	[Address(RVA = "0x1A2CBC0", Offset = "0x1A2BDC0", Length = "0x143")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000E6")]
	internal static void RegisterAtlasTextureForApply(Texture2D texture) { }

	[Address(RVA = "0x1A2CD10", Offset = "0x1A2BF10", Length = "0x346")]
	[CalledBy(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(WeakReference`1), Member = "TryGetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(WeakReference`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60000B5")]
	private void RegisterCallbackInstance(FontAsset instance) { }

	[Address(RVA = "0x1A2D060", Offset = "0x1A2C260", Length = "0xE3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60000E3")]
	internal static void RegisterFontAssetForFontFeatureUpdate(FontAsset fontAsset) { }

	[Address(RVA = "0x1A2D150", Offset = "0x1A2C350", Length = "0xE9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60000E4")]
	internal static void RegisterFontAssetForKerningUpdate(FontAsset fontAsset) { }

	[Address(RVA = "0x1A2D240", Offset = "0x1A2C440", Length = "0xC6")]
	[CalledBy(Type = typeof(FontAssetUtilities), Member = "GetCharacterFromFontAsset_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontAsset), typeof(bool), typeof(FontStyles), typeof(TextFontWeight), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(Character))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextUtilities), Member = "GetTextFontWeightIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextFontWeight)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000C7")]
	internal void RemoveCharacterInLookupCache(uint unicode, FontStyles fontStyle, TextFontWeight fontWeight) { }

	[Address(RVA = "0x1A32C30", Offset = "0x1A31E30", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600008B")]
	internal void set_atlasHeight(int value) { }

	[Address(RVA = "0x189D970", Offset = "0x189CB70", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600008D")]
	internal void set_atlasPadding(int value) { }

	[Address(RVA = "0x165F430", Offset = "0x165E630", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000071")]
	public void set_atlasPopulationMode(AtlasPopulationMode value) { }

	[Address(RVA = "0x189D920", Offset = "0x189CB20", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600008F")]
	internal void set_atlasRenderMode(GlyphRenderMode value) { }

	[Address(RVA = "0x1890C00", Offset = "0x188FE00", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000080")]
	public void set_atlasTextures(Texture2D[] value) { }

	[Address(RVA = "0x1A32C40", Offset = "0x1A31E40", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000089")]
	internal void set_atlasWidth(int value) { }

	[Address(RVA = "0x1A32C50", Offset = "0x1A31E50", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000A3")]
	public void set_boldStyleSpacing(float value) { }

	[Address(RVA = "0x1A32C60", Offset = "0x1A31E60", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000A1")]
	public void set_boldStyleWeight(float value) { }

	[Address(RVA = "0x4F7830", Offset = "0x4F6A30", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600007C")]
	internal void set_characterTable(List<Character> value) { }

	[Address(RVA = "0x1A32C70", Offset = "0x1A31E70", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000087")]
	internal void set_clearDynamicDataOnBuild(bool value) { }

	[Address(RVA = "0x1A32C80", Offset = "0x1A31E80", Length = "0x1B3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FontAsset), Member = "get_nativeFontAsset", ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000073")]
	public void set_faceInfo(FaceInfo value) { }

	[Address(RVA = "0x1A32E40", Offset = "0x1A32040", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000099")]
	public void set_fallbackFontAssetTable(List<FontAsset> value) { }

	[Address(RVA = "0x40DA90", Offset = "0x40CC90", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000075")]
	internal void set_familyNameHashCode(int value) { }

	[Address(RVA = "0x1A32E60", Offset = "0x1A32060", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600006D")]
	public void set_fontAssetCreationEditorSettings(FontAssetCreationEditorSettings value) { }

	[Address(RVA = "0x189DA50", Offset = "0x189CC50", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000097")]
	internal void set_fontFeatureTable(FontFeatureTable value) { }

	[Address(RVA = "0x189DA00", Offset = "0x189CC00", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600009B")]
	internal void set_fontWeightTable(FontWeightPair[] value) { }

	[Address(RVA = "0x189DAA0", Offset = "0x189CCA0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000095")]
	internal void set_freeGlyphRects(List<GlyphRect> value) { }

	[Address(RVA = "0x1A32EB0", Offset = "0x1A320B0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000085")]
	public void set_getFontFeatures(bool value) { }

	[Address(RVA = "0x1673E10", Offset = "0x1673010", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[NullableContext(1)]
	[Token(Token = "0x6000079")]
	internal void set_glyphTable(List<Glyph> value) { }

	[Address(RVA = "0x1A32EC0", Offset = "0x1A320C0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000083")]
	public void set_isMultiAtlasTexturesEnabled(bool value) { }

	[Address(RVA = "0x1A32ED0", Offset = "0x1A320D0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60000A5")]
	public void set_italicStyleSlant(byte value) { }

	[Address(RVA = "0x1A32EE0", Offset = "0x1A320E0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600009F")]
	public void set_regularStyleSpacing(float value) { }

	[Address(RVA = "0x1A32EF0", Offset = "0x1A320F0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600009D")]
	public void set_regularStyleWeight(float value) { }

	[Address(RVA = "0x2DD580", Offset = "0x2DC780", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600006F")]
	internal void set_sourceFontFile(Font value) { }

	[Address(RVA = "0x1A32F00", Offset = "0x1A32100", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000077")]
	internal void set_styleNameHashCode(int value) { }

	[Address(RVA = "0x1A32F10", Offset = "0x1A32110", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60000A7")]
	public void set_tabMultiple(byte value) { }

	[Address(RVA = "0x1A32F20", Offset = "0x1A32120", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000093")]
	internal void set_usedGlyphRects(List<GlyphRect> value) { }

	[Address(RVA = "0x1A2D310", Offset = "0x1A2C510", Length = "0x300")]
	[CalledBy(Type = typeof(FontAsset), Member = "TryAddGlyphToAtlas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Glyph&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FontAsset), Member = "TryAddGlyphsToNewAtlasTexture", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Object), Member = "get_hideFlags", ReturnType = typeof(HideFlags))]
	[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontEngine), Member = "ResetAtlasTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000F5")]
	private void SetupNewAtlasTexture() { }

	[Address(RVA = "0x1A2D620", Offset = "0x1A2C820", Length = "0x300")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[Calls(Type = typeof(FontFeatureTable), Member = "SortGlyphPairAdjustmentRecords", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontFeatureTable), Member = "SortMarkToBaseAdjustmentRecords", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontFeatureTable), Member = "SortMarkToMarkAdjustmentRecords", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60000CE")]
	internal void SortAllTables() { }

	[Address(RVA = "0x1A2D930", Offset = "0x1A2CB30", Length = "0x178")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000CB")]
	internal void SortCharacterTable() { }

	[Address(RVA = "0x1A2DAB0", Offset = "0x1A2CCB0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontFeatureTable), Member = "SortGlyphPairAdjustmentRecords", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontFeatureTable), Member = "SortMarkToBaseAdjustmentRecords", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontFeatureTable), Member = "SortMarkToMarkAdjustmentRecords", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000CD")]
	internal void SortFontFeatureTable() { }

	[Address(RVA = "0x1A2DB00", Offset = "0x1A2CD00", Length = "0x178")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000CC")]
	internal void SortGlyphTable() { }

	[Address(RVA = "0x1A2DC80", Offset = "0x1A2CE80", Length = "0x3A0")]
	[CalledBy(Type = typeof(FontAsset), Member = "HasCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FontAsset), Member = "HasCharacter_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontStyles), typeof(TextFontWeight), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FontAsset), Member = "HasCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UInt32[]&), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FontAsset), Member = "TryAddCharacterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Character&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FontAssetUtilities), Member = "GetCharacterFromFontAsset_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontAsset), typeof(bool), typeof(FontStyles), typeof(TextFontWeight), typeof(Boolean&), typeof(bool)}, ReturnType = typeof(Character))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(FontAsset), Member = "CreateCharacterAndAddToCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Glyph), typeof(FontStyles), typeof(TextFontWeight)}, ReturnType = typeof(Character))]
	[Calls(Type = typeof(FontAsset), Member = "TryAddGlyphToAtlas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Glyph&), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetGlyphIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.UInt32>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FontAsset), Member = "LoadFontFace", ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000F1")]
	internal bool TryAddCharacterInternal(uint unicode, FontStyles fontStyle, TextFontWeight fontWeight, out Character character, bool populateLigatures = true) { }

	[Address(RVA = "0x1A2E030", Offset = "0x1A2D230", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontAsset), Member = "TryAddCharacterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontStyles), typeof(TextFontWeight), typeof(Character&), typeof(bool)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60000F0")]
	internal bool TryAddCharacterInternal(uint unicode, out Character character) { }

	[Address(RVA = "0x1A2E060", Offset = "0x1A2D260", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&), typeof(bool)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60000EB")]
	public bool TryAddCharacters(string characters, bool includeFontFeatures = false) { }

	[Address(RVA = "0x1A2E0C0", Offset = "0x1A2D2C0", Length = "0x1270")]
	[CalledBy(Type = typeof(FontAsset), Member = "UpdateFontAssetData", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(FontAsset), Member = "EnsureAdditionalCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.UInt32>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetLigatureSubstitutionRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.UInt32>)}, ReturnType = typeof(LigatureSubstitutionRecord[]))]
	[Calls(Type = typeof(FontAsset), Member = "AddLigatureSubstitutionRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LigatureSubstitutionRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.UInt32>)}, ReturnType = typeof(GlyphPairAdjustmentRecord[]))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(FontAsset), Member = "UpdateDiacriticalMarkAdjustmentRecords", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "TryAddGlyphsToNewAtlasTexture", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "AddPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphPairAdjustmentRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "EnsureAdditionalCapacity", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "ResetAtlasTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "TryAddGlyphsToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.UInt32>), typeof(int), typeof(GlyphPackingMode), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.GlyphRect>), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.GlyphRect>), typeof(GlyphRenderMode), typeof(Texture2D), typeof(Glyph[]&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "LoadFontFace", ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAssetUtilities), Member = "GetCodePoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(Int32&)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontEngine), Member = "GetGlyphIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800303A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Character), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = "Reinitialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000EA")]
	public bool TryAddCharacters(UInt32[] unicodes, out UInt32[] missingUnicodes, bool includeFontFeatures = false) { }

	[Address(RVA = "0x1A2E090", Offset = "0x1A2D290", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]&), typeof(bool)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60000E9")]
	public bool TryAddCharacters(UInt32[] unicodes, bool includeFontFeatures = false) { }

	[Address(RVA = "0x1A2F340", Offset = "0x1A2E540", Length = "0x195")]
	[CalledBy(Type = typeof(FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]&), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000EC")]
	public bool TryAddCharacters(string characters, out string missingCharacters, bool includeFontFeatures = false) { }

	[Address(RVA = "0x1A2F4E0", Offset = "0x1A2E6E0", Length = "0x194")]
	[CalledBy(Type = typeof(TextGenerator), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextProcessingElement[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextLib), Member = "ProcessMeshInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeTextInfo), typeof(NativeTextGenerationSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "TryAddGlyphToAtlas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Glyph&), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontAsset), Member = "LoadFontFace", ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Token(Token = "0x60000EF")]
	internal bool TryAddGlyphInternal(uint glyphIndex, out Glyph glyph) { }

	[Address(RVA = "0x1A30170", Offset = "0x1A2F370", Length = "0x4B0")]
	[CalledBy(Type = typeof(FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]&), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.UInt32>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800303A0")]
	[Calls(Type = typeof(FontEngine), Member = "TryAddGlyphsToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.UInt32>), typeof(int), typeof(GlyphPackingMode), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.GlyphRect>), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.GlyphRect>), typeof(GlyphRenderMode), typeof(Texture2D), typeof(Glyph[]&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontAsset), Member = "SetupNewAtlasTexture", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Token(Token = "0x60000F4")]
	private bool TryAddGlyphsToNewAtlasTexture() { }

	[Address(RVA = "0x1A2F680", Offset = "0x1A2E880", Length = "0x46C")]
	[CalledBy(Type = typeof(FontAsset), Member = "TryAddGlyphInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Glyph&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FontAsset), Member = "TryAddCharacterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(FontStyles), typeof(TextFontWeight), typeof(Character&), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FontEngine), Member = "SetTextureUploadMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(FontAsset), Member = "SetupNewAtlasTexture", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "ResetAtlasTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Texture2D), Member = "Reinitialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FontAsset), Member = "TryAddGlyphToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Glyph&), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60000F2")]
	private bool TryAddGlyphToAtlas(uint glyphIndex, out Glyph glyph, bool populateLigatures = true) { }

	[Address(RVA = "0x1A2FAF0", Offset = "0x1A2ECF0", Length = "0x5CE")]
	[CalledBy(Type = typeof(FontAsset), Member = "TryAddGlyphToAtlas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Glyph&), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.UInt32>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(FontAsset), Member = "AddLigatureSubstitutionRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LigatureSubstitutionRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetLigatureSubstitutionRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(LigatureSubstitutionRecord[]))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "SetTextureUploadMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(FontEngine), Member = "TryAddGlyphToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(int), typeof(GlyphPackingMode), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.GlyphRect>), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.GlyphRect>), typeof(GlyphRenderMode), typeof(Texture2D), typeof(Glyph&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Token(Token = "0x60000F3")]
	private bool TryAddGlyphToTexture(uint glyphIndex, out Glyph glyph, bool populateLigatures = true) { }

	[Address(RVA = "0x1A300C0", Offset = "0x1A2F2C0", Length = "0xA3")]
	[CalledBy(Type = typeof(TextGenerator), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextProcessingElement[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.ValueTuple`2<System.UInt32, System.UInt32>, System.UInt32>), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`2<System.UInt32, System.UInt32>), typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000ED")]
	internal bool TryAddGlyphVariantIndexInternal(uint unicode, uint nextCharacter, uint variantGlyphIndex) { }

	[Address(RVA = "0x1A30630", Offset = "0x1A2F830", Length = "0xA3")]
	[CalledBy(Type = typeof(TextGenerator), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextProcessingElement[])}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.ValueTuple`2<System.UInt32, System.UInt32>, System.UInt32>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ValueTuple`2<System.UInt32, System.UInt32>), typeof(UInt32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000EE")]
	internal bool TryGetGlyphVariantIndexInternal(uint unicode, uint nextCharacter, out uint variantGlyphIndex) { }

	[Address(RVA = "0x1A306E0", Offset = "0x1A2F8E0", Length = "0x18F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Texture2D), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000E7")]
	internal static void UpdateAtlasTexturesInQueue() { }

	[Address(RVA = "0x1A30870", Offset = "0x1A2FA70", Length = "0x137")]
	[CalledBy(Type = typeof(FontAsset), Member = "UpdateFontFeaturesForFontAssetsInQueue", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(FontAsset), Member = "UpdateFontFeaturesForNewlyAddedGlyphs", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FontAsset), Member = "UpdateGPOSFontFeaturesForNewlyAddedGlyphs", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetMarkToBaseAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.UInt32>)}, ReturnType = typeof(MarkToBaseAdjustmentRecord[]))]
	[Calls(Type = typeof(FontAsset), Member = "AddMarkToBaseAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarkToBaseAdjustmentRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetMarkToMarkAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.UInt32>)}, ReturnType = typeof(MarkToMarkAdjustmentRecord[]))]
	[Calls(Type = typeof(FontAsset), Member = "AddMarkToMarkAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarkToMarkAdjustmentRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6000100")]
	internal void UpdateDiacriticalMarkAdjustmentRecords() { }

	[Address(RVA = "0x1A30A00", Offset = "0x1A2FC00", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000110")]
	private static void UpdateFaceInfo(IntPtr ptr, FaceInfo faceInfo) { }

	[Address(RVA = "0x1A30A80", Offset = "0x1A2FC80", Length = "0x152")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FontAsset), Member = "get_nativeFontAsset", ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000107")]
	internal void UpdateFaceInfo() { }

	[Address(RVA = "0x1A309B0", Offset = "0x1A2FBB0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000117")]
	private static void UpdateFaceInfo_Injected(IntPtr ptr, in FaceInfo faceInfo) { }

	[Address(RVA = "0x1A30C30", Offset = "0x1A2FE30", Length = "0x134")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FontAsset), Member = "get_nativeFontAsset", ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(FontAsset), Member = "GetFallbacks", ReturnType = typeof(IntPtr[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000105")]
	internal void UpdateFallbacks() { }

	[Address(RVA = "0x1A30D70", Offset = "0x1A2FF70", Length = "0xEC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600010D")]
	private static void UpdateFallbacks(IntPtr ptr, IntPtr[] fallbacks) { }

	[Address(RVA = "0x1A30BE0", Offset = "0x1A2FDE0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000114")]
	private static void UpdateFallbacks_Injected(IntPtr ptr, ref ManagedSpanWrapper fallbacks) { }

	[Address(RVA = "0x1A30E60", Offset = "0x1A30060", Length = "0x167")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(FontAsset), Member = "ClearCharacterAndGlyphTables", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "ClearFontFeaturesTables", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "ClearAtlasTextures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]&), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60000DC")]
	internal void UpdateFontAssetData() { }

	[Address(RVA = "0x1A30FD0", Offset = "0x1A301D0", Length = "0x1BF")]
	[CalledBy(Type = "UnityEngine.UIElements.ATGTextJobSystem", Member = "AddDrawEntries", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext", typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UITKTextJobSystem", Member = "GenerateTextJobified", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext", typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextGenerator), Member = "GenerateText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Texture2D), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60000E8")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
	internal static void UpdateFontAssetsInUpdateQueue() { }

	[Address(RVA = "0x1A31190", Offset = "0x1A30390", Length = "0x3C9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontEngine), Member = "GetPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.UInt32>)}, ReturnType = typeof(GlyphPairAdjustmentRecord[]))]
	[Calls(Type = typeof(FontAsset), Member = "AddPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphPairAdjustmentRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "UpdateDiacriticalMarkAdjustmentRecords", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60000E5")]
	internal static void UpdateFontFeaturesForFontAssetsInQueue() { }

	[Address(RVA = "0x1A31560", Offset = "0x1A30760", Length = "0x103")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontEngine), Member = "GetLigatureSubstitutionRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.UInt32>)}, ReturnType = typeof(LigatureSubstitutionRecord[]))]
	[Calls(Type = typeof(FontAsset), Member = "AddLigatureSubstitutionRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LigatureSubstitutionRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.UInt32>)}, ReturnType = typeof(GlyphPairAdjustmentRecord[]))]
	[Calls(Type = typeof(FontAsset), Member = "AddPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphPairAdjustmentRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "UpdateDiacriticalMarkAdjustmentRecords", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000F7")]
	private void UpdateFontFeaturesForNewlyAddedGlyphs() { }

	[Address(RVA = "0x1A31840", Offset = "0x1A30A40", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontEngine), Member = "GetPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.UInt32>)}, ReturnType = typeof(GlyphPairAdjustmentRecord[]))]
	[Calls(Type = typeof(FontAsset), Member = "AddPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphPairAdjustmentRecord[])}, ReturnType = typeof(void))]
	[Token(Token = "0x60000FE")]
	internal void UpdateGlyphAdjustmentRecords() { }

	[Address(RVA = "0x1A31790", Offset = "0x1A30990", Length = "0xA4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontEngine), Member = "GetPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.UInt32>)}, ReturnType = typeof(GlyphPairAdjustmentRecord[]))]
	[Calls(Type = typeof(FontAsset), Member = "AddPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphPairAdjustmentRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000F8")]
	private void UpdateGlyphAdjustmentRecordsForNewGlyphs() { }

	[Address(RVA = "0x1A31670", Offset = "0x1A30870", Length = "0xAE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontEngine), Member = "GetPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.UInt32>)}, ReturnType = typeof(GlyphPairAdjustmentRecord[]))]
	[Calls(Type = typeof(FontAsset), Member = "AddPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphPairAdjustmentRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontAsset), Member = "UpdateDiacriticalMarkAdjustmentRecords", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000F9")]
	private void UpdateGPOSFontFeaturesForNewlyAddedGlyphs() { }

	[Address(RVA = "0x1A31720", Offset = "0x1A30920", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontEngine), Member = "GetLigatureSubstitutionRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(LigatureSubstitutionRecord[]))]
	[Calls(Type = typeof(FontAsset), Member = "AddLigatureSubstitutionRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LigatureSubstitutionRecord[])}, ReturnType = typeof(void))]
	[Token(Token = "0x60000FB")]
	private void UpdateGSUBFontFeaturesForNewGlyphIndex(uint glyphIndex) { }

	[Address(RVA = "0x1A318B0", Offset = "0x1A30AB0", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontEngine), Member = "GetLigatureSubstitutionRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.UInt32>)}, ReturnType = typeof(LigatureSubstitutionRecord[]))]
	[Calls(Type = typeof(FontAsset), Member = "AddLigatureSubstitutionRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LigatureSubstitutionRecord[])}, ReturnType = typeof(void))]
	[Token(Token = "0x60000FC")]
	internal void UpdateLigatureSubstitutionRecords() { }

	[Address(RVA = "0x1A31980", Offset = "0x1A30B80", Length = "0x1A2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(FontAsset), Member = "GetWeightFallbacks", ReturnType = typeof(System.ValueTuple`2<IntPtr[], IntPtr[]>))]
	[Calls(Type = typeof(FontAsset), Member = "get_nativeFontAsset", ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000106")]
	internal void UpdateWeightFallbacks() { }

	[Address(RVA = "0x1A31B30", Offset = "0x1A30D30", Length = "0x14E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600010E")]
	private static void UpdateWeightFallbacks(IntPtr ptr, IntPtr[] regularFallbacks, IntPtr[] italicFallbacks) { }

	[Address(RVA = "0x1A31920", Offset = "0x1A30B20", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000115")]
	private static void UpdateWeightFallbacks_Injected(IntPtr ptr, ref ManagedSpanWrapper regularFallbacks, ref ManagedSpanWrapper italicFallbacks) { }

}

