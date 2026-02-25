namespace TMPro;

[ExcludeFromPreset]
[Token(Token = "0x200004A")]
public class TMP_FontAsset : TMP_Asset
{
	[CompilerGenerated]
	[Token(Token = "0x200004B")]
	private sealed class <>c
	{
		[Token(Token = "0x400021F")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000220")]
		public static Func<TMP_Character, UInt32> <>9__145_0; //Field offset: 0x8
		[Token(Token = "0x4000221")]
		public static Func<Glyph, UInt32> <>9__146_0; //Field offset: 0x10

		[Address(RVA = "0x18B3B30", Offset = "0x18B2D30", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000294")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000295")]
		public <>c() { }

		[Address(RVA = "0x18B39B0", Offset = "0x18B2BB0", Length = "0x16")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000296")]
		internal uint <SortCharacterTable>b__145_0(TMP_Character c) { }

		[Address(RVA = "0x18B3A50", Offset = "0x18B2C50", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000297")]
		internal uint <SortGlyphTable>b__146_0(Glyph c) { }

	}

	[Token(Token = "0x4000203")]
	private static readonly List<WeakReference`1<TMP_FontAsset>> s_CallbackInstances; //Field offset: 0x0
	[Token(Token = "0x4000204")]
	private static ProfilerMarker k_ReadFontAssetDefinitionMarker; //Field offset: 0x8
	[Token(Token = "0x4000205")]
	private static ProfilerMarker k_AddSynthesizedCharactersMarker; //Field offset: 0x10
	[Token(Token = "0x4000206")]
	private static ProfilerMarker k_TryAddGlyphMarker; //Field offset: 0x18
	[Token(Token = "0x4000207")]
	private static ProfilerMarker k_TryAddCharacterMarker; //Field offset: 0x20
	[Token(Token = "0x4000208")]
	private static ProfilerMarker k_TryAddCharactersMarker; //Field offset: 0x28
	[Token(Token = "0x4000209")]
	private static ProfilerMarker k_UpdateLigatureSubstitutionRecordsMarker; //Field offset: 0x30
	[Token(Token = "0x400020A")]
	private static ProfilerMarker k_UpdateGlyphAdjustmentRecordsMarker; //Field offset: 0x38
	[Token(Token = "0x400020B")]
	private static ProfilerMarker k_UpdateDiacriticalMarkAdjustmentRecordsMarker; //Field offset: 0x40
	[Token(Token = "0x400020C")]
	private static ProfilerMarker k_ClearFontAssetDataMarker; //Field offset: 0x48
	[Token(Token = "0x400020D")]
	private static ProfilerMarker k_UpdateFontAssetDataMarker; //Field offset: 0x50
	[Token(Token = "0x400020E")]
	private static string s_DefaultMaterialSuffix; //Field offset: 0x58
	[Token(Token = "0x400020F")]
	private static HashSet<Int32> k_SearchedFontAssetLookup; //Field offset: 0x60
	[Token(Token = "0x4000210")]
	private static List<TMP_FontAsset> k_FontAssets_FontFeaturesUpdateQueue; //Field offset: 0x68
	[Token(Token = "0x4000211")]
	private static HashSet<Int32> k_FontAssets_FontFeaturesUpdateQueueLookup; //Field offset: 0x70
	[Token(Token = "0x4000212")]
	private static List<Texture2D> k_FontAssets_AtlasTexturesUpdateQueue; //Field offset: 0x78
	[Token(Token = "0x4000213")]
	private static HashSet<Int32> k_FontAssets_AtlasTexturesUpdateQueueLookup; //Field offset: 0x80
	[Token(Token = "0x400021E")]
	internal static UInt32[] k_GlyphIndexArray; //Field offset: 0x88
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	[Token(Token = "0x40001DA")]
	internal string m_SourceFontFileGUID; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	[Token(Token = "0x40001DB")]
	internal FontAssetCreationSettings m_CreationSettings; //Field offset: 0xA0
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	[Token(Token = "0x40001DC")]
	private Font m_SourceFontFile; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	[Token(Token = "0x40001DD")]
	private string m_SourceFontFilePath; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	[Token(Token = "0x40001DE")]
	private AtlasPopulationMode m_AtlasPopulationMode; //Field offset: 0x110
	[FieldOffset(Offset = "0x114")]
	[SerializeField]
	[Token(Token = "0x40001DF")]
	internal bool InternalDynamicOS; //Field offset: 0x114
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x40001E0")]
	private int m_FamilyNameHashCode; //Field offset: 0x118
	[FieldOffset(Offset = "0x11C")]
	[Token(Token = "0x40001E1")]
	private int m_StyleNameHashCode; //Field offset: 0x11C
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	[Token(Token = "0x40001E2")]
	internal List<Glyph> m_GlyphTable; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x40001E3")]
	internal Dictionary<UInt32, Glyph> m_GlyphLookupDictionary; //Field offset: 0x128
	[FieldOffset(Offset = "0x130")]
	[SerializeField]
	[Token(Token = "0x40001E4")]
	internal List<TMP_Character> m_CharacterTable; //Field offset: 0x130
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x40001E5")]
	internal Dictionary<UInt32, TMP_Character> m_CharacterLookupDictionary; //Field offset: 0x138
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x40001E6")]
	internal Texture2D m_AtlasTexture; //Field offset: 0x140
	[FieldOffset(Offset = "0x148")]
	[SerializeField]
	[Token(Token = "0x40001E7")]
	internal Texture2D[] m_AtlasTextures; //Field offset: 0x148
	[FieldOffset(Offset = "0x150")]
	[SerializeField]
	[Token(Token = "0x40001E8")]
	internal int m_AtlasTextureIndex; //Field offset: 0x150
	[FieldOffset(Offset = "0x154")]
	[SerializeField]
	[Token(Token = "0x40001E9")]
	private bool m_IsMultiAtlasTexturesEnabled; //Field offset: 0x154
	[FieldOffset(Offset = "0x155")]
	[SerializeField]
	[Token(Token = "0x40001EA")]
	private bool m_GetFontFeatures; //Field offset: 0x155
	[FieldOffset(Offset = "0x156")]
	[SerializeField]
	[Token(Token = "0x40001EB")]
	private bool m_ClearDynamicDataOnBuild; //Field offset: 0x156
	[FieldOffset(Offset = "0x158")]
	[SerializeField]
	[Token(Token = "0x40001EC")]
	internal int m_AtlasWidth; //Field offset: 0x158
	[FieldOffset(Offset = "0x15C")]
	[SerializeField]
	[Token(Token = "0x40001ED")]
	internal int m_AtlasHeight; //Field offset: 0x15C
	[FieldOffset(Offset = "0x160")]
	[SerializeField]
	[Token(Token = "0x40001EE")]
	internal int m_AtlasPadding; //Field offset: 0x160
	[FieldOffset(Offset = "0x164")]
	[SerializeField]
	[Token(Token = "0x40001EF")]
	internal GlyphRenderMode m_AtlasRenderMode; //Field offset: 0x164
	[FieldOffset(Offset = "0x168")]
	[SerializeField]
	[Token(Token = "0x40001F0")]
	private List<GlyphRect> m_UsedGlyphRects; //Field offset: 0x168
	[FieldOffset(Offset = "0x170")]
	[SerializeField]
	[Token(Token = "0x40001F1")]
	private List<GlyphRect> m_FreeGlyphRects; //Field offset: 0x170
	[FieldOffset(Offset = "0x178")]
	[SerializeField]
	[Token(Token = "0x40001F2")]
	internal TMP_FontFeatureTable m_FontFeatureTable; //Field offset: 0x178
	[FieldOffset(Offset = "0x180")]
	[SerializeField]
	[Token(Token = "0x40001F3")]
	internal bool m_ShouldReimportFontFeatures; //Field offset: 0x180
	[FieldOffset(Offset = "0x188")]
	[SerializeField]
	[Token(Token = "0x40001F4")]
	internal List<TMP_FontAsset> m_FallbackFontAssetTable; //Field offset: 0x188
	[FieldOffset(Offset = "0x190")]
	[SerializeField]
	[Token(Token = "0x40001F5")]
	private TMP_FontWeightPair[] m_FontWeightTable; //Field offset: 0x190
	[FieldOffset(Offset = "0x198")]
	[SerializeField]
	[Token(Token = "0x40001F6")]
	private TMP_FontWeightPair[] fontWeights; //Field offset: 0x198
	[FieldOffset(Offset = "0x1A0")]
	[Token(Token = "0x40001F7")]
	public float normalStyle; //Field offset: 0x1A0
	[FieldOffset(Offset = "0x1A4")]
	[Token(Token = "0x40001F8")]
	public float normalSpacingOffset; //Field offset: 0x1A4
	[FieldOffset(Offset = "0x1A8")]
	[Token(Token = "0x40001F9")]
	public float boldStyle; //Field offset: 0x1A8
	[FieldOffset(Offset = "0x1AC")]
	[Token(Token = "0x40001FA")]
	public float boldSpacing; //Field offset: 0x1AC
	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x40001FB")]
	public byte italicStyle; //Field offset: 0x1B0
	[FieldOffset(Offset = "0x1B1")]
	[Token(Token = "0x40001FC")]
	public byte tabSize; //Field offset: 0x1B1
	[FieldOffset(Offset = "0x1B2")]
	[Token(Token = "0x40001FD")]
	internal bool IsFontAssetLookupTablesDirty; //Field offset: 0x1B2
	[FieldOffset(Offset = "0x1B8")]
	[SerializeField]
	[Token(Token = "0x40001FE")]
	private FaceInfo_Legacy m_fontInfo; //Field offset: 0x1B8
	[FieldOffset(Offset = "0x1C0")]
	[SerializeField]
	[Token(Token = "0x40001FF")]
	internal List<TMP_Glyph> m_glyphInfoList; //Field offset: 0x1C0
	[FieldOffset(Offset = "0x1C8")]
	[FormerlySerializedAs("m_kerningInfo")]
	[SerializeField]
	[Token(Token = "0x4000200")]
	internal KerningTable m_KerningTable; //Field offset: 0x1C8
	[FieldOffset(Offset = "0x1D0")]
	[SerializeField]
	[Token(Token = "0x4000201")]
	private List<TMP_FontAsset> fallbackFontAssets; //Field offset: 0x1D0
	[FieldOffset(Offset = "0x1D8")]
	[SerializeField]
	[Token(Token = "0x4000202")]
	public Texture2D atlas; //Field offset: 0x1D8
	[FieldOffset(Offset = "0x1E0")]
	[Token(Token = "0x4000214")]
	private List<Glyph> m_GlyphsToRender; //Field offset: 0x1E0
	[FieldOffset(Offset = "0x1E8")]
	[Token(Token = "0x4000215")]
	private List<Glyph> m_GlyphsRendered; //Field offset: 0x1E8
	[FieldOffset(Offset = "0x1F0")]
	[Token(Token = "0x4000216")]
	private List<UInt32> m_GlyphIndexList; //Field offset: 0x1F0
	[FieldOffset(Offset = "0x1F8")]
	[Token(Token = "0x4000217")]
	private List<UInt32> m_GlyphIndexListNewlyAdded; //Field offset: 0x1F8
	[FieldOffset(Offset = "0x200")]
	[Token(Token = "0x4000218")]
	internal List<UInt32> m_GlyphsToAdd; //Field offset: 0x200
	[FieldOffset(Offset = "0x208")]
	[Token(Token = "0x4000219")]
	internal HashSet<UInt32> m_GlyphsToAddLookup; //Field offset: 0x208
	[FieldOffset(Offset = "0x210")]
	[Token(Token = "0x400021A")]
	internal List<TMP_Character> m_CharactersToAdd; //Field offset: 0x210
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x400021B")]
	internal HashSet<UInt32> m_CharactersToAddLookup; //Field offset: 0x218
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x400021C")]
	internal List<UInt32> s_MissingCharacterList; //Field offset: 0x220
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x400021D")]
	internal HashSet<UInt32> m_MissingUnicodesFromFontFile; //Field offset: 0x228

	[Token(Token = "0x17000074")]
	public internal int atlasHeight
	{
		[Address(RVA = "0x189D630", Offset = "0x189C830", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000236")]
		 get { } //Length: 7
		[Address(RVA = "0x189D920", Offset = "0x189CB20", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000237")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000075")]
	public internal int atlasPadding
	{
		[Address(RVA = "0x189D640", Offset = "0x189C840", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000238")]
		 get { } //Length: 7
		[Address(RVA = "0x189D930", Offset = "0x189CB30", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000239")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000066")]
	public AtlasPopulationMode atlasPopulationMode
	{
		[Address(RVA = "0x40D470", Offset = "0x40C670", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600021E")]
		 get { } //Length: 7
		[Address(RVA = "0x40DA90", Offset = "0x40CC90", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600021F")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000076")]
	public internal GlyphRenderMode atlasRenderMode
	{
		[Address(RVA = "0x189D650", Offset = "0x189C850", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600023A")]
		 get { } //Length: 7
		[Address(RVA = "0x189D940", Offset = "0x189CB40", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600023B")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x1700006D")]
	public Texture2D atlasTexture
	{
		[Address(RVA = "0x189D660", Offset = "0x189C860", Length = "0x9C")]
		[CalledBy(Type = typeof(TextMeshPro), Member = "LoadFontAsset", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextMeshProUGUI), Member = "LoadFontAsset", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x600022A")]
		 get { } //Length: 156
	}

	[Token(Token = "0x1700006F")]
	public int atlasTextureCount
	{
		[Address(RVA = "0x1656450", Offset = "0x1655650", Length = "0x9")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600022D")]
		 get { } //Length: 9
	}

	[Token(Token = "0x1700006E")]
	public Texture2D[] atlasTextures
	{
		[Address(RVA = "0x3D6640", Offset = "0x3D5840", Length = "0x8")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600022B")]
		 get { } //Length: 8
		[Address(RVA = "0x189D950", Offset = "0x189CB50", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600022C")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000073")]
	public internal int atlasWidth
	{
		[Address(RVA = "0x189D700", Offset = "0x189C900", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000234")]
		 get { } //Length: 7
		[Address(RVA = "0x189D970", Offset = "0x189CB70", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000235")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x1700006C")]
	public Dictionary<UInt32, TMP_Character> characterLookupTable
	{
		[Address(RVA = "0x189D710", Offset = "0x189C910", Length = "0x34")]
		[CalledBy(Type = typeof(TextMeshPro), Member = "LoadFontAsset", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextMeshPro), Member = "GenerateTextMesh", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextMeshProUGUI), Member = "LoadFontAsset", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextMeshProUGUI), Member = "GenerateTextMesh", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_FontUtilities), Member = "SearchForCharacterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset), typeof(uint), typeof(TMP_Character&)}, ReturnType = typeof(TMP_FontAsset))]
		[CalledBy(Type = typeof(TMP_FontAssetUtilities), Member = "GetCharacterFromFontAsset_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_FontAsset), typeof(bool), typeof(FontStyles), typeof(FontWeight), typeof(Boolean&)}, ReturnType = typeof(TMP_Character))]
		[CalledBy(Type = typeof(TMP_Text), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextWrappingModes)}, ReturnType = typeof(Vector2))]
		[CallerCount(Count = 18)]
		[Calls(Type = typeof(TMP_FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
		[Token(Token = "0x6000229")]
		 get { } //Length: 52
	}

	[Token(Token = "0x1700006B")]
	public internal List<TMP_Character> characterTable
	{
		[Address(RVA = "0x3F5870", Offset = "0x3F4A70", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000227")]
		 get { } //Length: 8
		[Address(RVA = "0x189D980", Offset = "0x189CB80", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000228")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x17000072")]
	internal bool clearDynamicDataOnBuild
	{
		[Address(RVA = "0x189D750", Offset = "0x189C950", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000232")]
		internal get { } //Length: 8
		[Address(RVA = "0x189D9A0", Offset = "0x189CBA0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000233")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000064")]
	public FontAssetCreationSettings creationSettings
	{
		[Address(RVA = "0x189D760", Offset = "0x189C960", Length = "0x45")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600021A")]
		 get { } //Length: 69
		[Address(RVA = "0x189D9B0", Offset = "0x189CBB0", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600021B")]
		 set { } //Length: 79
	}

	[Token(Token = "0x1700007A")]
	public List<TMP_FontAsset> fallbackFontAssetTable
	{
		[Address(RVA = "0x3D6850", Offset = "0x3D5A50", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000242")]
		 get { } //Length: 8
		[Address(RVA = "0x189DA00", Offset = "0x189CC00", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000243")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000067")]
	internal int familyNameHashCode
	{
		[Address(RVA = "0x189D7B0", Offset = "0x189C9B0", Length = "0x77")]
		[CalledBy(Type = typeof(TMP_ResourceManager), Member = "AddFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TMP_TextUtilities), Member = "GetHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000220")]
		internal get { } //Length: 119
		[Address(RVA = "0x189DA20", Offset = "0x189CC20", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000221")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000079")]
	public internal TMP_FontFeatureTable fontFeatureTable
	{
		[Address(RVA = "0x3D67C0", Offset = "0x3D59C0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000240")]
		 get { } //Length: 8
		[Address(RVA = "0x538A60", Offset = "0x537C60", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000241")]
		internal set { } //Length: 19
	}

	[Obsolete("The fontInfo property and underlying type is now obsolete. Please use the faceInfo property and FaceInfo type instead.")]
	[Token(Token = "0x1700007C")]
	public FaceInfo_Legacy fontInfo
	{
		[Address(RVA = "0x189D830", Offset = "0x189CA30", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000246")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700007B")]
	public internal TMP_FontWeightPair[] fontWeightTable
	{
		[Address(RVA = "0x3D6760", Offset = "0x3D5960", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000244")]
		 get { } //Length: 8
		[Address(RVA = "0x189DA30", Offset = "0x189CC30", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000245")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x17000078")]
	internal List<GlyphRect> freeGlyphRects
	{
		[Address(RVA = "0x3D66F0", Offset = "0x3D58F0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600023E")]
		internal get { } //Length: 8
		[Address(RVA = "0x189DA50", Offset = "0x189CC50", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600023F")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x17000071")]
	public bool getFontFeatures
	{
		[Address(RVA = "0x189D840", Offset = "0x189CA40", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000230")]
		 get { } //Length: 8
		[Address(RVA = "0x189DA70", Offset = "0x189CC70", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000231")]
		 set { } //Length: 7
	}

	[Token(Token = "0x1700006A")]
	public Dictionary<UInt32, Glyph> glyphLookupTable
	{
		[Address(RVA = "0x189D850", Offset = "0x189CA50", Length = "0x34")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
		[Token(Token = "0x6000226")]
		 get { } //Length: 52
	}

	[Token(Token = "0x17000069")]
	public internal List<Glyph> glyphTable
	{
		[Address(RVA = "0x3F5850", Offset = "0x3F4A50", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000224")]
		 get { } //Length: 8
		[Address(RVA = "0x537670", Offset = "0x536870", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000225")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x17000070")]
	public bool isMultiAtlasTexturesEnabled
	{
		[Address(RVA = "0x189D890", Offset = "0x189CA90", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600022E")]
		 get { } //Length: 8
		[Address(RVA = "0x189DA80", Offset = "0x189CC80", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600022F")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000065")]
	public internal Font sourceFontFile
	{
		[Address(RVA = "0x3F58D0", Offset = "0x3F4AD0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600021C")]
		 get { } //Length: 8
		[Address(RVA = "0x507950", Offset = "0x506B50", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600021D")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x17000068")]
	internal int styleNameHashCode
	{
		[Address(RVA = "0x189D8A0", Offset = "0x189CAA0", Length = "0x77")]
		[CalledBy(Type = typeof(TMP_ResourceManager), Member = "AddFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TMP_TextUtilities), Member = "GetHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000222")]
		internal get { } //Length: 119
		[Address(RVA = "0x189DA90", Offset = "0x189CC90", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000223")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000077")]
	internal List<GlyphRect> usedGlyphRects
	{
		[Address(RVA = "0x3D6840", Offset = "0x3D5A40", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600023C")]
		internal get { } //Length: 8
		[Address(RVA = "0x189DAA0", Offset = "0x189CCA0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600023D")]
		internal set { } //Length: 19
	}

	[Address(RVA = "0x189CDC0", Offset = "0x189BFC0", Length = "0x484")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Int32>), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000293")]
	private static TMP_FontAsset() { }

	[Address(RVA = "0x189D250", Offset = "0x189C450", Length = "0x3D2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TMP_FontFeatureTable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(KerningTable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.UInt32>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[Token(Token = "0x6000292")]
	public TMP_FontAsset() { }

	[Address(RVA = "0x18917F0", Offset = "0x18909F0", Length = "0x9F")]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetTextElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_FontAsset), typeof(FontStyles), typeof(FontWeight), typeof(Boolean&)}, ReturnType = typeof(TMP_TextElement))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600025B")]
	internal void AddCharacterToLookupCache(uint unicode, TMP_Character character, FontStyles fontStyle = 0, FontWeight fontWeight = 400, bool isAlternativeTypeface = false) { }

	[Address(RVA = "0x1891890", Offset = "0x1890A90", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_FontAsset), Member = "TryAddGlyphInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Glyph&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000274")]
	internal bool AddGlyphInternal(uint glyphIndex) { }

	[Address(RVA = "0x18918B0", Offset = "0x1890AB0", Length = "0x430")]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "InitializeDictionaryLookupTables", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "UpdateFontFeaturesForNewlyAddedGlyphs", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "ImportFontFeatures", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "UpdateGSUBFontFeaturesForNewGlyphIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "UpdateLigatureSubstitutionRecords", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(LigatureSubstitutionRecord), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LigatureSubstitutionRecord), typeof(LigatureSubstitutionRecord)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001ED30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Token(Token = "0x6000281")]
	private void AddLigatureSubstitutionRecords(LigatureSubstitutionRecord[] records) { }

	[Address(RVA = "0x1891CF0", Offset = "0x1890EF0", Length = "0x2FB")]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "InitializeDictionaryLookupTables", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "ImportFontFeatures", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "UpdateDiacriticalMarkAdjustmentRecords", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180015380")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, TMPro.MarkToBaseAdjustmentRecord>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(MarkToBaseAdjustmentRecord)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 16)]
	[Token(Token = "0x6000286")]
	private void AddMarkToBaseAdjustmentRecords(MarkToBaseAdjustmentRecord[] records) { }

	[Address(RVA = "0x1891FF0", Offset = "0x18911F0", Length = "0x2FB")]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "InitializeDictionaryLookupTables", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "ImportFontFeatures", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "UpdateDiacriticalMarkAdjustmentRecords", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180015380")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, TMPro.MarkToMarkAdjustmentRecord>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(MarkToMarkAdjustmentRecord)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 16)]
	[Token(Token = "0x6000287")]
	private void AddMarkToMarkAdjustmentRecords(MarkToMarkAdjustmentRecord[] records) { }

	[Address(RVA = "0x18922F0", Offset = "0x18914F0", Length = "0x323")]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "InitializeDictionaryLookupTables", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "UpdateFontFeaturesForFontAssetsInQueue", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "UpdateFontFeaturesForNewlyAddedGlyphs", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "UpdateGPOSFontFeaturesForNewlyAddedGlyphs", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "ImportFontFeatures", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "UpdateGlyphAdjustmentRecords", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800D2AD0")]
	[Calls(Type = typeof(GlyphPairAdjustmentRecord), Member = "set_firstAdjustmentRecord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphAdjustmentRecord)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GlyphAdjustmentRecord), Member = "get_glyphValueRecord", ReturnType = typeof(GlyphValueRecord))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GlyphPairAdjustmentRecord), Member = "get_firstAdjustmentRecord", ReturnType = typeof(GlyphAdjustmentRecord))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(GlyphPairAdjustmentRecord)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Token(Token = "0x6000283")]
	private void AddPairAdjustmentRecords(GlyphPairAdjustmentRecord[] records) { }

	[Address(RVA = "0x1892620", Offset = "0x1891820", Length = "0x31A")]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "AddSynthesizedCharactersAndFaceMetrics", ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(FontEngine), Member = "TryGetGlyphWithUnicodeValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(GlyphLoadFlags), typeof(Glyph&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontEngine), Member = "GetGlyphIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GlyphMetrics), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GlyphRect), Member = "get_zero", ReturnType = typeof(GlyphRect))]
	[Calls(Type = typeof(Glyph), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(GlyphMetrics), typeof(GlyphRect), typeof(float), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x600025A")]
	private void AddSynthesizedCharacter(uint unicode, bool isFontFaceLoaded, bool addImmediately = false) { }

	[Address(RVA = "0x1892940", Offset = "0x1891B40", Length = "0x22F")]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_ResourceManager), Member = "RebuildFontAssetCache", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TMP_FontAsset), Member = "LoadFontFace", ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_warningsDisabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "AddSynthesizedCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000259")]
	internal void AddSynthesizedCharactersAndFaceMetrics() { }

	[Address(RVA = "0x1892B70", Offset = "0x1891D70", Length = "0x25D")]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "UpdateFontAssetData", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "ClearFontAssetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "ClearCharacterAndGlyphTablesInternal", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(FontEngine), Member = "ResetAtlasTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = "Apply", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600028F")]
	internal void ClearAtlasTextures(bool setAtlasSizeToZero = false) { }

	[Address(RVA = "0x1892E00", Offset = "0x1892000", Length = "0x209")]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "UpdateFontAssetData", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "ClearFontAssetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "ClearCharacterAndGlyphTablesInternal", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600028D")]
	private void ClearCharacterAndGlyphTables() { }

	[Address(RVA = "0x1892DD0", Offset = "0x1891FD0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ClearCharacterAndGlyphTables", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ClearAtlasTextures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Token(Token = "0x600028B")]
	internal void ClearCharacterAndGlyphTablesInternal() { }

	[Address(RVA = "0x1893010", Offset = "0x1892210", Length = "0x30A")]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "ClearFontAssetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
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
	[CallsDeduplicatedMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000254")]
	internal void ClearFallbackCharacterTable() { }

	[Address(RVA = "0x1893320", Offset = "0x1892520", Length = "0x21C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ClearCharacterAndGlyphTables", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ClearFontFeaturesTables", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ClearAtlasTextures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(WeakReference`1), Member = "TryGetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ClearFallbackCharacterTable", ReturnType = typeof(void))]
	[Calls(Type = typeof(FastAction`2), Member = "Call", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"A", "B"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600028A")]
	public void ClearFontAssetData(bool setAtlasSizeToZero = false) { }

	[Address(RVA = "0x1893540", Offset = "0x1892740", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ClearFontFeaturesTables", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Token(Token = "0x600028C")]
	internal void ClearFontFeaturesInternal() { }

	[Address(RVA = "0x1893560", Offset = "0x1892760", Length = "0xF5")]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "UpdateFontAssetData", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "ClearFontAssetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "ClearFontFeaturesInternal", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x600028E")]
	private void ClearFontFeaturesTables() { }

	[Address(RVA = "0x768500", Offset = "0x767700", Length = "0x1C5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED940")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000288")]
	private void CopyListDataToArray(List<T> srcList, ref T[] dstArray) { }

	[Address(RVA = "0x1894340", Offset = "0x1893540", Length = "0x165")]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(TMP_FontAsset))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int)}, ReturnType = typeof(TMP_FontAsset))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontEngine), Member = "LoadFontFace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(int)}, ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "CreateFontAssetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(TMP_FontAsset))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000249")]
	private static TMP_FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport = true) { }

	[Address(RVA = "0x1893EB0", Offset = "0x18930B0", Length = "0x19A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontEngine), Member = "LoadFontFace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(float), typeof(int)}, ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "CreateFontAssetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(TMP_FontAsset))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600024A")]
	public static TMP_FontAsset CreateFontAsset(Font font) { }

	[Address(RVA = "0x18941B0", Offset = "0x18933B0", Length = "0x182")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontEngine), Member = "LoadFontFace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(float), typeof(int)}, ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "CreateFontAssetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(TMP_FontAsset))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600024B")]
	public static TMP_FontAsset CreateFontAsset(Font font, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = 1, bool enableMultiAtlasSupport = true) { }

	[Address(RVA = "0x1894050", Offset = "0x1893250", Length = "0x158")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontEngine), Member = "LoadFontFace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(float), typeof(int)}, ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "CreateFontAssetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(TMP_FontAsset))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600024C")]
	private static TMP_FontAsset CreateFontAsset(Font font, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = 1, bool enableMultiAtlasSupport = true) { }

	[Address(RVA = "0x1893C80", Offset = "0x1892E80", Length = "0x220")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontEngine), Member = "TryGetSystemFontReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(FontReference&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(TMP_FontAsset))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000247")]
	public static TMP_FontAsset CreateFontAsset(string familyName, string styleName, int pointSize = 90) { }

	[Address(RVA = "0x18944B0", Offset = "0x18936B0", Length = "0xAC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_FontAsset), Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(TMP_FontAsset))]
	[Token(Token = "0x6000248")]
	public static TMP_FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight) { }

	[Address(RVA = "0x1893660", Offset = "0x1892860", Length = "0x619")]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(TMP_FontAsset))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font)}, ReturnType = typeof(TMP_FontAsset))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(int), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(TMP_FontAsset))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(int), typeof(int), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(TMP_FontAsset))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ShaderUtilities), Member = "get_ShaderRef_MobileBitmap", ReturnType = typeof(Shader))]
	[Calls(Type = typeof(Shader), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Shader))]
	[Calls(Type = typeof(Material), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "SetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Texture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ShaderUtilities), Member = "get_ShaderRef_MobileSDF", ReturnType = typeof(Shader))]
	[Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_clearDynamicDataOnBuild", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontEngine), Member = "GetFaceInfo", ReturnType = typeof(FaceInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ScriptableObject), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600024D")]
	private static TMP_FontAsset CreateFontAssetInstance(Font font, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport) { }

	[Address(RVA = "0x1894560", Offset = "0x1893760", Length = "0xE7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000290")]
	private void DestroyAtlasTextures() { }

	[Address(RVA = "0x189D630", Offset = "0x189C830", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000236")]
	public int get_atlasHeight() { }

	[Address(RVA = "0x189D640", Offset = "0x189C840", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000238")]
	public int get_atlasPadding() { }

	[Address(RVA = "0x40D470", Offset = "0x40C670", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600021E")]
	public AtlasPopulationMode get_atlasPopulationMode() { }

	[Address(RVA = "0x189D650", Offset = "0x189C850", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600023A")]
	public GlyphRenderMode get_atlasRenderMode() { }

	[Address(RVA = "0x189D660", Offset = "0x189C860", Length = "0x9C")]
	[CalledBy(Type = typeof(TextMeshPro), Member = "LoadFontAsset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "LoadFontAsset", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600022A")]
	public Texture2D get_atlasTexture() { }

	[Address(RVA = "0x1656450", Offset = "0x1655650", Length = "0x9")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600022D")]
	public int get_atlasTextureCount() { }

	[Address(RVA = "0x3D6640", Offset = "0x3D5840", Length = "0x8")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600022B")]
	public Texture2D[] get_atlasTextures() { }

	[Address(RVA = "0x189D700", Offset = "0x189C900", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000234")]
	public int get_atlasWidth() { }

	[Address(RVA = "0x189D710", Offset = "0x189C910", Length = "0x34")]
	[CalledBy(Type = typeof(TextMeshPro), Member = "LoadFontAsset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "LoadFontAsset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontUtilities), Member = "SearchForCharacterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset), typeof(uint), typeof(TMP_Character&)}, ReturnType = typeof(TMP_FontAsset))]
	[CalledBy(Type = typeof(TMP_FontAssetUtilities), Member = "GetCharacterFromFontAsset_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_FontAsset), typeof(bool), typeof(FontStyles), typeof(FontWeight), typeof(Boolean&)}, ReturnType = typeof(TMP_Character))]
	[CalledBy(Type = typeof(TMP_Text), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextWrappingModes)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Token(Token = "0x6000229")]
	public Dictionary<UInt32, TMP_Character> get_characterLookupTable() { }

	[Address(RVA = "0x3F5870", Offset = "0x3F4A70", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000227")]
	public List<TMP_Character> get_characterTable() { }

	[Address(RVA = "0x189D750", Offset = "0x189C950", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000232")]
	internal bool get_clearDynamicDataOnBuild() { }

	[Address(RVA = "0x189D760", Offset = "0x189C960", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600021A")]
	public FontAssetCreationSettings get_creationSettings() { }

	[Address(RVA = "0x3D6850", Offset = "0x3D5A50", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000242")]
	public List<TMP_FontAsset> get_fallbackFontAssetTable() { }

	[Address(RVA = "0x189D7B0", Offset = "0x189C9B0", Length = "0x77")]
	[CalledBy(Type = typeof(TMP_ResourceManager), Member = "AddFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_TextUtilities), Member = "GetHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000220")]
	internal int get_familyNameHashCode() { }

	[Address(RVA = "0x3D67C0", Offset = "0x3D59C0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000240")]
	public TMP_FontFeatureTable get_fontFeatureTable() { }

	[Address(RVA = "0x189D830", Offset = "0x189CA30", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000246")]
	public FaceInfo_Legacy get_fontInfo() { }

	[Address(RVA = "0x3D6760", Offset = "0x3D5960", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000244")]
	public TMP_FontWeightPair[] get_fontWeightTable() { }

	[Address(RVA = "0x3D66F0", Offset = "0x3D58F0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600023E")]
	internal List<GlyphRect> get_freeGlyphRects() { }

	[Address(RVA = "0x189D840", Offset = "0x189CA40", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000230")]
	public bool get_getFontFeatures() { }

	[Address(RVA = "0x189D850", Offset = "0x189CA50", Length = "0x34")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Token(Token = "0x6000226")]
	public Dictionary<UInt32, Glyph> get_glyphLookupTable() { }

	[Address(RVA = "0x3F5850", Offset = "0x3F4A50", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000224")]
	public List<Glyph> get_glyphTable() { }

	[Address(RVA = "0x189D890", Offset = "0x189CA90", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600022E")]
	public bool get_isMultiAtlasTexturesEnabled() { }

	[Address(RVA = "0x3F58D0", Offset = "0x3F4AD0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600021C")]
	public Font get_sourceFontFile() { }

	[Address(RVA = "0x189D8A0", Offset = "0x189CAA0", Length = "0x77")]
	[CalledBy(Type = typeof(TMP_ResourceManager), Member = "AddFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_TextUtilities), Member = "GetHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000222")]
	internal int get_styleNameHashCode() { }

	[Address(RVA = "0x3D6840", Offset = "0x3D5A40", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600023C")]
	internal List<GlyphRect> get_usedGlyphRects() { }

	[Address(RVA = "0x1894730", Offset = "0x1893930", Length = "0xE0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000267")]
	public static string GetCharacters(TMP_FontAsset fontAsset) { }

	[Address(RVA = "0x1894650", Offset = "0x1893850", Length = "0xDE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000268")]
	public static Int32[] GetCharactersArray(TMP_FontAsset fontAsset) { }

	[Address(RVA = "0x1894820", Offset = "0x1893A20", Length = "0xD9")]
	[CalledBy(Type = typeof(TextMeshPro), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "LoadFontFace", ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontEngine), Member = "GetGlyphIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000269")]
	internal uint GetGlyphIndex(uint unicode) { }

	[Address(RVA = "0x1894900", Offset = "0x1893B00", Length = "0x82")]
	[CalledBy(Type = typeof(TextMeshPro), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TMP_FontAsset), Member = "LoadFontFace", ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontEngine), Member = "GetVariantGlyphIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
	[Token(Token = "0x600026A")]
	internal uint GetGlyphVariantIndex(uint unicode, uint variantSelectorUnicode) { }

	[Address(RVA = "0x1894BE0", Offset = "0x1893DE0", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000261")]
	public bool HasCharacter(int character) { }

	[Address(RVA = "0x1894C60", Offset = "0x1893E60", Length = "0x604")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TMP_FontAsset), Member = "HasCharacter_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Int32>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_FontAsset), Member = "TryAddCharacterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_Character&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_fallbackFontAssets", ReturnType = typeof(System.Collections.Generic.List`1<TMPro.TMP_FontAsset>))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_defaultFontAsset", ReturnType = typeof(TMP_FontAsset))]
	[CallsDeduplicatedMethods(Count = 8)]
	[Token(Token = "0x6000262")]
	public bool HasCharacter(char character, bool searchFallbacks = false, bool tryAddCharacter = false) { }

	[Address(RVA = "0x1894990", Offset = "0x1893B90", Length = "0x24E")]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "HasCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "HasCharacter_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "HasCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UInt32[]&), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "TryAddCharacterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_Character&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "HasCharacter_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000263")]
	private bool HasCharacter_Internal(uint character, bool searchFallbacks = false, bool tryAddCharacter = false) { }

	[Address(RVA = "0x1895270", Offset = "0x1894470", Length = "0x18D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_FontAssetUtilities), Member = "GetCodePoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800304C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000264")]
	public bool HasCharacters(string text, out List<Char>& missingCharacters) { }

	[Address(RVA = "0x1895400", Offset = "0x1894600", Length = "0x756")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_defaultFontAsset", ReturnType = typeof(TMP_FontAsset))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_fallbackFontAssets", ReturnType = typeof(System.Collections.Generic.List`1<TMPro.TMP_FontAsset>))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "HasCharacter_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Int32>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TMP_FontAsset), Member = "TryAddCharacterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_Character&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800303A0")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_FontAssetUtilities), Member = "GetCodePoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Token(Token = "0x6000265")]
	public bool HasCharacters(string text, out UInt32[] missingCharacters, bool searchFallbacks = false, bool tryAddCharacter = false) { }

	[Address(RVA = "0x1895B60", Offset = "0x1894D60", Length = "0xD4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_FontAssetUtilities), Member = "GetCodePoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000266")]
	public bool HasCharacters(string text) { }

	[Address(RVA = "0x1895C40", Offset = "0x1894E40", Length = "0xFF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TMP_FontAsset), Member = "LoadFontFace", ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontEngine), Member = "GetAllPairAdjustmentRecords", ReturnType = typeof(GlyphPairAdjustmentRecord[]))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "AddPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphPairAdjustmentRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetAllMarkToBaseAdjustmentRecords", ReturnType = typeof(MarkToBaseAdjustmentRecord[]))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "AddMarkToBaseAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarkToBaseAdjustmentRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetAllMarkToMarkAdjustmentRecords", ReturnType = typeof(MarkToMarkAdjustmentRecord[]))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "AddMarkToMarkAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarkToMarkAdjustmentRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetAllLigatureSubstitutionRecords", ReturnType = typeof(LigatureSubstitutionRecord[]))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "AddLigatureSubstitutionRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LigatureSubstitutionRecord[])}, ReturnType = typeof(void))]
	[Token(Token = "0x600027E")]
	internal void ImportFontFeatures() { }

	[Address(RVA = "0x1895D40", Offset = "0x1894F40", Length = "0x209")]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "InitializeDictionaryLookupTables", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_ResourceManager), Member = "RebuildFontAssetCache", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000253")]
	internal void InitializeCharacterLookupDictionary() { }

	[Address(RVA = "0x1895F50", Offset = "0x1895150", Length = "0x495")]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FontEngine), Member = "GetAllMarkToMarkAdjustmentRecords", ReturnType = typeof(MarkToMarkAdjustmentRecord[]))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, TMPro.MarkToBaseAdjustmentRecord>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(MarkToBaseAdjustmentRecord)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "InitializeGlyphPaidAdjustmentRecordsLookupDictionary", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "InitializeLigatureSubstitutionLookupDictionary", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "AddLigatureSubstitutionRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LigatureSubstitutionRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetAllLigatureSubstitutionRecords", ReturnType = typeof(LigatureSubstitutionRecord[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, TMPro.MarkToMarkAdjustmentRecord>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(MarkToMarkAdjustmentRecord)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "AddMarkToBaseAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarkToBaseAdjustmentRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetAllMarkToBaseAdjustmentRecords", ReturnType = typeof(MarkToBaseAdjustmentRecord[]))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "AddPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphPairAdjustmentRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetAllPairAdjustmentRecords", ReturnType = typeof(GlyphPairAdjustmentRecord[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_FontAsset), Member = "LoadFontFace", ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TMP_FontAsset), Member = "InitializeCharacterLookupDictionary", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "InitializeGlyphLookupDictionary", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "AddMarkToMarkAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarkToMarkAdjustmentRecord[])}, ReturnType = typeof(void))]
	[Token(Token = "0x6000251")]
	internal void InitializeDictionaryLookupTables() { }

	[Address(RVA = "0x18963F0", Offset = "0x18955F0", Length = "0x275")]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "InitializeDictionaryLookupTables", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800303A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000252")]
	internal void InitializeGlyphLookupDictionary() { }

	[Address(RVA = "0x1896670", Offset = "0x1895870", Length = "0x29D")]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "InitializeDictionaryLookupTables", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TMP_FontAsset), Member = "UpgradeGlyphAdjustmentTableToFontFeatureTable", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(GlyphPairAdjustmentRecord), Member = "get_firstAdjustmentRecord", ReturnType = typeof(GlyphAdjustmentRecord))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(GlyphPairAdjustmentRecord)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000256")]
	internal void InitializeGlyphPaidAdjustmentRecordsLookupDictionary() { }

	[Address(RVA = "0x1896910", Offset = "0x1895B10", Length = "0x296")]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "InitializeDictionaryLookupTables", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001ED30")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000255")]
	internal void InitializeLigatureSubstitutionLookupDictionary() { }

	[Address(RVA = "0x1896BB0", Offset = "0x1895DB0", Length = "0x1B9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, TMPro.MarkToBaseAdjustmentRecord>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(MarkToBaseAdjustmentRecord)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000257")]
	internal void InitializeMarkToBaseAdjustmentRecordsLookupDictionary() { }

	[Address(RVA = "0x1896D70", Offset = "0x1895F70", Length = "0x1B9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, TMPro.MarkToMarkAdjustmentRecord>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(MarkToMarkAdjustmentRecord)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000258")]
	internal void InitializeMarkToMarkAdjustmentRecordsLookupDictionary() { }

	[Address(RVA = "0x1896F30", Offset = "0x1896130", Length = "0x151")]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryAddCharacterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_Character&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "ImportFontFeatures", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryGetCharacter_and_QueueRenderToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_Character&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryAddGlyphInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Glyph&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "GetGlyphIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "AddSynthesizedCharactersAndFaceMetrics", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "InitializeDictionaryLookupTables", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "GetGlyphVariantIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(FontEngine), Member = "LoadFontFace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(float), typeof(int)}, ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(FontEngine), Member = "LoadFontFace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(int)}, ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontEngine), Member = "LoadFontFace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(float)}, ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 7)]
	[Token(Token = "0x600025C")]
	internal FontEngineError LoadFontFace() { }

	[Address(RVA = "0x1897090", Offset = "0x1896290", Length = "0x132")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600024F")]
	private void OnDestroy() { }

	[Address(RVA = "0x18971D0", Offset = "0x18963D0", Length = "0x763")]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "ClearCharacterAndGlyphTablesInternal", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "HasCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "HasCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UInt32[]&), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "HasCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(List`1<Char>&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "HasCharacter_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "HasCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "HasCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "CreateFontAssetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(TMP_FontAsset))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "get_characterLookupTable", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, TMPro.TMP_Character>))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "get_glyphLookupTable", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, UnityEngine.TextCore.Glyph>))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "LoadFontAsset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "LoadFontAsset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "ClearFontFeaturesInternal", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "UpdateFontAssetData", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "ClearFontAssetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(FontEngine), Member = "GetFaceInfo", ReturnType = typeof(FaceInfo))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "RegisterCallbackInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_ResourceManager), Member = "AddFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_TextUtilities), Member = "GetHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(TMP_FontAsset), Member = "InitializeDictionaryLookupTables", ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "HasProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FaceInfo), Member = "get_strikethroughOffset", ReturnType = typeof(float))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "AddSynthesizedCharactersAndFaceMetrics", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(JobsUtility), Member = "get_IsExecutingJob", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 20)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000250")]
	public void ReadFontAssetDefinition() { }

	[Address(RVA = "0x1897940", Offset = "0x1896B40", Length = "0x140")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600026D")]
	internal static void RegisterAtlasTextureForApply(Texture2D texture) { }

	[Address(RVA = "0x1897A90", Offset = "0x1896C90", Length = "0x342")]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
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
	[Token(Token = "0x600024E")]
	private void RegisterCallbackInstance(TMP_FontAsset instance) { }

	[Address(RVA = "0x1897DE0", Offset = "0x1896FE0", Length = "0x14A")]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryAddGlyphInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Glyph&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryAddCharacterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_Character&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryGetCharacter_and_QueueRenderToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_Character&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600026B")]
	internal static void RegisterFontAssetForFontFeatureUpdate(TMP_FontAsset fontAsset) { }

	[Address(RVA = "0x189D920", Offset = "0x189CB20", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000237")]
	internal void set_atlasHeight(int value) { }

	[Address(RVA = "0x189D930", Offset = "0x189CB30", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000239")]
	internal void set_atlasPadding(int value) { }

	[Address(RVA = "0x40DA90", Offset = "0x40CC90", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600021F")]
	public void set_atlasPopulationMode(AtlasPopulationMode value) { }

	[Address(RVA = "0x189D940", Offset = "0x189CB40", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600023B")]
	internal void set_atlasRenderMode(GlyphRenderMode value) { }

	[Address(RVA = "0x189D950", Offset = "0x189CB50", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600022C")]
	public void set_atlasTextures(Texture2D[] value) { }

	[Address(RVA = "0x189D970", Offset = "0x189CB70", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000235")]
	internal void set_atlasWidth(int value) { }

	[Address(RVA = "0x189D980", Offset = "0x189CB80", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000228")]
	internal void set_characterTable(List<TMP_Character> value) { }

	[Address(RVA = "0x189D9A0", Offset = "0x189CBA0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000233")]
	internal void set_clearDynamicDataOnBuild(bool value) { }

	[Address(RVA = "0x189D9B0", Offset = "0x189CBB0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600021B")]
	public void set_creationSettings(FontAssetCreationSettings value) { }

	[Address(RVA = "0x189DA00", Offset = "0x189CC00", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000243")]
	public void set_fallbackFontAssetTable(List<TMP_FontAsset> value) { }

	[Address(RVA = "0x189DA20", Offset = "0x189CC20", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000221")]
	internal void set_familyNameHashCode(int value) { }

	[Address(RVA = "0x538A60", Offset = "0x537C60", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000241")]
	internal void set_fontFeatureTable(TMP_FontFeatureTable value) { }

	[Address(RVA = "0x189DA30", Offset = "0x189CC30", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000245")]
	internal void set_fontWeightTable(TMP_FontWeightPair[] value) { }

	[Address(RVA = "0x189DA50", Offset = "0x189CC50", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600023F")]
	internal void set_freeGlyphRects(List<GlyphRect> value) { }

	[Address(RVA = "0x189DA70", Offset = "0x189CC70", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000231")]
	public void set_getFontFeatures(bool value) { }

	[Address(RVA = "0x537670", Offset = "0x536870", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000225")]
	internal void set_glyphTable(List<Glyph> value) { }

	[Address(RVA = "0x189DA80", Offset = "0x189CC80", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600022F")]
	public void set_isMultiAtlasTexturesEnabled(bool value) { }

	[Address(RVA = "0x507950", Offset = "0x506B50", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600021D")]
	internal void set_sourceFontFile(Font value) { }

	[Address(RVA = "0x189DA90", Offset = "0x189CC90", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000223")]
	internal void set_styleNameHashCode(int value) { }

	[Address(RVA = "0x189DAA0", Offset = "0x189CCA0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600023D")]
	internal void set_usedGlyphRects(List<GlyphRect> value) { }

	[Address(RVA = "0x1897F30", Offset = "0x1897130", Length = "0x2A7")]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryAddGlyphInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Glyph&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryAddCharacterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_Character&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryAddGlyphsToNewAtlasTexture", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontEngine), Member = "ResetAtlasTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600027A")]
	private void SetupNewAtlasTexture() { }

	[Address(RVA = "0x18981E0", Offset = "0x18973E0", Length = "0x300")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[Calls(Type = typeof(TMP_FontFeatureTable), Member = "SortGlyphPairAdjustmentRecords", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontFeatureTable), Member = "SortMarkToBaseAdjustmentRecords", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontFeatureTable), Member = "SortMarkToMarkAdjustmentRecords", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000260")]
	internal void SortAllTables() { }

	[Address(RVA = "0x18984F0", Offset = "0x18976F0", Length = "0x178")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600025D")]
	internal void SortCharacterTable() { }

	[Address(RVA = "0x1898670", Offset = "0x1897870", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_FontFeatureTable), Member = "SortGlyphPairAdjustmentRecords", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontFeatureTable), Member = "SortMarkToBaseAdjustmentRecords", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontFeatureTable), Member = "SortMarkToMarkAdjustmentRecords", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600025F")]
	internal void SortFontFeatureTable() { }

	[Address(RVA = "0x18986C0", Offset = "0x18978C0", Length = "0x178")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600025E")]
	internal void SortGlyphTable() { }

	[Address(RVA = "0x1898840", Offset = "0x1897A40", Length = "0x8F8")]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "HasCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "HasCharacter_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "HasCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UInt32[]&), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAssetUtilities), Member = "GetCharacterFromFontAsset_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_FontAsset), typeof(bool), typeof(FontStyles), typeof(FontWeight), typeof(Boolean&)}, ReturnType = typeof(TMP_Character))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(FontEngine), Member = "TryAddGlyphToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(int), typeof(GlyphPackingMode), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.GlyphRect>), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.GlyphRect>), typeof(GlyphRenderMode), typeof(Texture2D), typeof(Glyph&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800303A0")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_getFontFeaturesAtRuntime", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "UpdateGSUBFontFeaturesForNewGlyphIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "RegisterFontAssetForFontFeatureUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "ResetAtlasTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "SetupNewAtlasTexture", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Texture2D), Member = "Reinitialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontEngine), Member = "GetGlyphIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_FontAsset), Member = "LoadFontFace", ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.UInt32>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000276")]
	internal bool TryAddCharacterInternal(uint unicode, out TMP_Character character) { }

	[Address(RVA = "0x1899140", Offset = "0x1898340", Length = "0xC1A")]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "UpdateFontAssetData", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Texture2D), Member = "Reinitialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontEngine), Member = "ResetAtlasTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "TryAddGlyphsToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.UInt32>), typeof(int), typeof(GlyphPackingMode), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.GlyphRect>), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.GlyphRect>), typeof(GlyphRenderMode), typeof(Texture2D), typeof(Glyph[]&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.UInt32>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "UpdateFontFeaturesForNewlyAddedGlyphs", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "TryAddGlyphsToNewAtlasTexture", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.UInt32>)}, ReturnType = typeof(UInt32[]))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Character), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800303A0")]
	[Calls(Type = typeof(FontEngine), Member = "GetGlyphIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_FontAssetUtilities), Member = "GetCodePoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(Int32&)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "LoadFontFace", ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000271")]
	public bool TryAddCharacters(UInt32[] unicodes, out UInt32[] missingUnicodes, bool includeFontFeatures = false) { }

	[Address(RVA = "0x189A9E0", Offset = "0x1899BE0", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]&), typeof(bool)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000270")]
	public bool TryAddCharacters(UInt32[] unicodes, bool includeFontFeatures = false) { }

	[Address(RVA = "0x1899D60", Offset = "0x1898F60", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&), typeof(bool)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000272")]
	public bool TryAddCharacters(string characters, bool includeFontFeatures = false) { }

	[Address(RVA = "0x1899D90", Offset = "0x1898F90", Length = "0xC45")]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(FontEngine), Member = "ResetAtlasTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "TryAddGlyphsToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.UInt32>), typeof(int), typeof(GlyphPackingMode), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.GlyphRect>), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.GlyphRect>), typeof(GlyphRenderMode), typeof(Texture2D), typeof(Glyph[]&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.UInt32>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "UpdateFontFeaturesForNewlyAddedGlyphs", ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = "Reinitialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "TryAddGlyphsToNewAtlasTexture", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "LoadFontFace", ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontEngine), Member = "GetGlyphIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800303A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TMP_Character), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000273")]
	public bool TryAddCharacters(string characters, out string missingCharacters, bool includeFontFeatures = false) { }

	[Address(RVA = "0x189AA10", Offset = "0x1899C10", Length = "0x675")]
	[CalledBy(Type = typeof(TextMeshPro), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "AddGlyphInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(TMP_FontAsset), Member = "SetupNewAtlasTexture", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(TMP_FontAsset), Member = "RegisterFontAssetForFontFeatureUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "UpdateGSUBFontFeaturesForNewGlyphIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_getFontFeaturesAtRuntime", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800303A0")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "TryAddGlyphToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(int), typeof(GlyphPackingMode), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.GlyphRect>), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.GlyphRect>), typeof(GlyphRenderMode), typeof(Texture2D), typeof(Glyph&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(FontEngine), Member = "ResetAtlasTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Texture2D), Member = "Reinitialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "LoadFontFace", ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000275")]
	internal bool TryAddGlyphInternal(uint glyphIndex, out Glyph glyph) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000278")]
	internal void TryAddGlyphsToAtlasTextures() { }

	[Address(RVA = "0x189B090", Offset = "0x189A290", Length = "0x493")]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.UInt32>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "TryAddGlyphsToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.UInt32>), typeof(int), typeof(GlyphPackingMode), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.GlyphRect>), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.GlyphRect>), typeof(GlyphRenderMode), typeof(Texture2D), typeof(Glyph[]&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800303A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_FontAsset), Member = "SetupNewAtlasTexture", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000279")]
	private bool TryAddGlyphsToNewAtlasTexture() { }

	[Address(RVA = "0x189B530", Offset = "0x189A730", Length = "0x4AF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FontEngine), Member = "TryGetGlyphWithIndexValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(GlyphLoadFlags), typeof(Glyph&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "UpdateGSUBFontFeaturesForNewGlyphIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_getFontFeaturesAtRuntime", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800303A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontEngine), Member = "GetGlyphIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_FontAsset), Member = "LoadFontFace", ReturnType = typeof(FontEngineError))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.UInt32>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TMP_FontAsset), Member = "RegisterFontAssetForFontFeatureUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_FontAsset)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x6000277")]
	internal bool TryGetCharacter_and_QueueRenderToTexture(uint unicode, out TMP_Character character) { }

	[Address(RVA = "0x189B9E0", Offset = "0x189ABE0", Length = "0x1A9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Texture2D), Member = "Reinitialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontEngine), Member = "ResetAtlasTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600027B")]
	internal void UpdateAtlasTexture() { }

	[Address(RVA = "0x189BB90", Offset = "0x189AD90", Length = "0x189")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Texture2D), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600026E")]
	internal static void UpdateAtlasTexturesInQueue() { }

	[Address(RVA = "0x189BD20", Offset = "0x189AF20", Length = "0xA6")]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "UpdateFontFeaturesForFontAssetsInQueue", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "UpdateFontFeaturesForNewlyAddedGlyphs", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "UpdateGPOSFontFeaturesForNewlyAddedGlyphs", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontEngine), Member = "GetMarkToBaseAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.UInt32>)}, ReturnType = typeof(MarkToBaseAdjustmentRecord[]))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "AddMarkToBaseAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarkToBaseAdjustmentRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetMarkToMarkAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.UInt32>)}, ReturnType = typeof(MarkToMarkAdjustmentRecord[]))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "AddMarkToMarkAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarkToMarkAdjustmentRecord[])}, ReturnType = typeof(void))]
	[Token(Token = "0x6000285")]
	internal void UpdateDiacriticalMarkAdjustmentRecords() { }

	[Address(RVA = "0x189BDD0", Offset = "0x189AFD0", Length = "0x196")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ClearCharacterAndGlyphTables", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ClearFontFeaturesTables", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ClearAtlasTextures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_getFontFeaturesAtRuntime", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]&), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000289")]
	internal void UpdateFontAssetData() { }

	[Address(RVA = "0x189BF70", Offset = "0x189B170", Length = "0x1B9")]
	[CalledBy(Type = typeof(TextMeshPro), Member = "OnPreRenderObject", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "OnPreRenderCanvas", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Texture2D), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x600026F")]
	internal static void UpdateFontAssetsInUpdateQueue() { }

	[Address(RVA = "0x189C130", Offset = "0x189B330", Length = "0x22A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontEngine), Member = "GetPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.UInt32>)}, ReturnType = typeof(GlyphPairAdjustmentRecord[]))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "AddPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphPairAdjustmentRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "UpdateDiacriticalMarkAdjustmentRecords", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600026C")]
	internal static void UpdateFontFeaturesForFontAssetsInQueue() { }

	[Address(RVA = "0x189C360", Offset = "0x189B560", Length = "0x103")]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(UInt32[]&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontEngine), Member = "GetLigatureSubstitutionRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.UInt32>)}, ReturnType = typeof(LigatureSubstitutionRecord[]))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "AddLigatureSubstitutionRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LigatureSubstitutionRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.UInt32>)}, ReturnType = typeof(GlyphPairAdjustmentRecord[]))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "AddPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphPairAdjustmentRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "UpdateDiacriticalMarkAdjustmentRecords", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600027C")]
	private void UpdateFontFeaturesForNewlyAddedGlyphs() { }

	[Address(RVA = "0x189C600", Offset = "0x189B800", Length = "0x306")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontEngine), Member = "GetGlyphPairAdjustmentTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[])}, ReturnType = typeof(GlyphPairAdjustmentRecord[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TMP_FontFeatureTable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GlyphPairAdjustmentRecord), Member = "get_firstAdjustmentRecord", ReturnType = typeof(GlyphAdjustmentRecord))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800D2AD0")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(GlyphPairAdjustmentRecord)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000284")]
	internal void UpdateGlyphAdjustmentRecords(UInt32[] glyphIndexes) { }

	[Address(RVA = "0x189C590", Offset = "0x189B790", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontEngine), Member = "GetPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.UInt32>)}, ReturnType = typeof(GlyphPairAdjustmentRecord[]))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "AddPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphPairAdjustmentRecord[])}, ReturnType = typeof(void))]
	[Token(Token = "0x6000282")]
	internal void UpdateGlyphAdjustmentRecords() { }

	[Address(RVA = "0x189C470", Offset = "0x189B670", Length = "0xAE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontEngine), Member = "GetPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.UInt32>)}, ReturnType = typeof(GlyphPairAdjustmentRecord[]))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "AddPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphPairAdjustmentRecord[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "UpdateDiacriticalMarkAdjustmentRecords", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600027D")]
	private void UpdateGPOSFontFeaturesForNewlyAddedGlyphs() { }

	[Address(RVA = "0x189C520", Offset = "0x189B720", Length = "0x67")]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryAddGlyphInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Glyph&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryAddCharacterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_Character&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "TryGetCharacter_and_QueueRenderToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_Character&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontEngine), Member = "GetLigatureSubstitutionRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(LigatureSubstitutionRecord[]))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "AddLigatureSubstitutionRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LigatureSubstitutionRecord[])}, ReturnType = typeof(void))]
	[Token(Token = "0x600027F")]
	private void UpdateGSUBFontFeaturesForNewGlyphIndex(uint glyphIndex) { }

	[Address(RVA = "0x189C910", Offset = "0x189BB10", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(FontEngine), Member = "GetLigatureSubstitutionRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.UInt32>)}, ReturnType = typeof(LigatureSubstitutionRecord[]))]
	[Calls(Type = typeof(TMP_FontAsset), Member = "AddLigatureSubstitutionRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LigatureSubstitutionRecord[])}, ReturnType = typeof(void))]
	[Token(Token = "0x6000280")]
	internal void UpdateLigatureSubstitutionRecords() { }

	[Address(RVA = "0x189C980", Offset = "0x189BB80", Length = "0x433")]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "InitializeGlyphPaidAdjustmentRecordsLookupDictionary", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TMP_FontFeatureTable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GlyphPairAdjustmentRecord), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphAdjustmentRecord), typeof(GlyphAdjustmentRecord)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800D2AD0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x6000291")]
	private void UpgradeGlyphAdjustmentTableToFontFeatureTable() { }

}

