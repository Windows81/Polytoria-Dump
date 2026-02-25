namespace TMPro;

[ExcludeFromPreset]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.ugui@2.0/manual/TextMeshPro/Sprites.html")]
[Token(Token = "0x200008C")]
public class TMP_SpriteAsset : TMP_Asset
{
	[CompilerGenerated]
	[Token(Token = "0x200008D")]
	private sealed class <>c
	{
		[Token(Token = "0x400049F")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40004A0")]
		public static Func<TMP_SpriteGlyph, UInt32> <>9__32_0; //Field offset: 0x8
		[Token(Token = "0x40004A1")]
		public static Func<TMP_SpriteCharacter, UInt32> <>9__33_0; //Field offset: 0x10

		[Address(RVA = "0x18F34F0", Offset = "0x18F26F0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60004BB")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004BC")]
		public <>c() { }

		[Address(RVA = "0x18B39B0", Offset = "0x18B2BB0", Length = "0x16")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60004BE")]
		internal uint <SortCharacterTable>b__33_0(TMP_SpriteCharacter c) { }

		[Address(RVA = "0x18B3A50", Offset = "0x18B2C50", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004BD")]
		internal uint <SortGlyphTable>b__32_0(TMP_SpriteGlyph item) { }

	}

	[Token(Token = "0x400049E")]
	private static HashSet<Int32> k_searchedSpriteAssets; //Field offset: 0x0
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000494")]
	internal Dictionary<Int32, Int32> m_NameLookup; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000495")]
	internal Dictionary<UInt32, Int32> m_GlyphIndexLookup; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000496")]
	public Texture spriteSheet; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	[Token(Token = "0x4000497")]
	private List<TMP_SpriteCharacter> m_SpriteCharacterTable; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000498")]
	internal Dictionary<UInt32, TMP_SpriteCharacter> m_SpriteCharacterLookup; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[FormerlySerializedAs("m_SpriteGlyphTable")]
	[SerializeField]
	[Token(Token = "0x4000499")]
	private List<TMP_SpriteGlyph> m_GlyphTable; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x400049A")]
	internal Dictionary<UInt32, TMP_SpriteGlyph> m_SpriteGlyphLookup; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x400049B")]
	public List<TMP_Sprite> spriteInfoList; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	[Token(Token = "0x400049C")]
	public List<TMP_SpriteAsset> fallbackSpriteAssets; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x400049D")]
	internal bool m_IsSpriteAssetLookupTablesDirty; //Field offset: 0xE0

	[Token(Token = "0x17000107")]
	public internal Dictionary<UInt32, TMP_SpriteCharacter> spriteCharacterLookupTable
	{
		[Address(RVA = "0x18ECEB0", Offset = "0x18EC0B0", Length = "0x34")]
		[CalledBy(Type = typeof(TMP_FontAssetUtilities), Member = "GetSpriteCharacterFromSpriteAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_SpriteAsset), typeof(bool)}, ReturnType = typeof(TMP_SpriteCharacter))]
		[CalledBy(Type = typeof(TMP_FontAssetUtilities), Member = "GetSpriteCharacterFromSpriteAsset_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_SpriteAsset), typeof(bool)}, ReturnType = typeof(TMP_SpriteCharacter))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(TMP_SpriteAsset), Member = "UpdateLookupTables", ReturnType = typeof(void))]
		[Token(Token = "0x60004A6")]
		 get { } //Length: 52
		[Address(RVA = "0x2DD4D0", Offset = "0x2DC6D0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60004A7")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x17000106")]
	public internal List<TMP_SpriteCharacter> spriteCharacterTable
	{
		[Address(RVA = "0x18ECEF0", Offset = "0x18EC0F0", Length = "0x34")]
		[CalledBy(Type = typeof(TextMeshPro), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(TextMeshProUGUI), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(TMP_Text), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(TMP_SpriteAsset), Member = "UpdateLookupTables", ReturnType = typeof(void))]
		[Token(Token = "0x60004A4")]
		 get { } //Length: 52
		[Address(RVA = "0x2DD4F0", Offset = "0x2DC6F0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60004A5")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x17000108")]
	public internal List<TMP_SpriteGlyph> spriteGlyphTable
	{
		[Address(RVA = "0x2DD1C0", Offset = "0x2DC3C0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004A8")]
		 get { } //Length: 8
		[Address(RVA = "0x2DD490", Offset = "0x2DC690", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60004A9")]
		internal set { } //Length: 19
	}

	[Address(RVA = "0x18ECDE0", Offset = "0x18EBFE0", Length = "0xC9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60004BA")]
	public TMP_SpriteAsset() { }

	[Address(RVA = "0x18EADF0", Offset = "0x18E9FF0", Length = "0x7A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_SpriteAsset), Member = "UpgradeSpriteAsset", ReturnType = typeof(void))]
	[Token(Token = "0x60004AA")]
	private void Awake() { }

	[Address(RVA = "0x18ECEB0", Offset = "0x18EC0B0", Length = "0x34")]
	[CalledBy(Type = typeof(TMP_FontAssetUtilities), Member = "GetSpriteCharacterFromSpriteAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_SpriteAsset), typeof(bool)}, ReturnType = typeof(TMP_SpriteCharacter))]
	[CalledBy(Type = typeof(TMP_FontAssetUtilities), Member = "GetSpriteCharacterFromSpriteAsset_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(TMP_SpriteAsset), typeof(bool)}, ReturnType = typeof(TMP_SpriteCharacter))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TMP_SpriteAsset), Member = "UpdateLookupTables", ReturnType = typeof(void))]
	[Token(Token = "0x60004A6")]
	public Dictionary<UInt32, TMP_SpriteCharacter> get_spriteCharacterLookupTable() { }

	[Address(RVA = "0x18ECEF0", Offset = "0x18EC0F0", Length = "0x34")]
	[CalledBy(Type = typeof(TextMeshPro), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TMP_Text), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TMP_SpriteAsset), Member = "UpdateLookupTables", ReturnType = typeof(void))]
	[Token(Token = "0x60004A4")]
	public List<TMP_SpriteCharacter> get_spriteCharacterTable() { }

	[Address(RVA = "0x2DD1C0", Offset = "0x2DC3C0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004A8")]
	public List<TMP_SpriteGlyph> get_spriteGlyphTable() { }

	[Address(RVA = "0x18EAE70", Offset = "0x18EA070", Length = "0xCF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ShaderUtilities), Member = "GetShaderPropertyIDs", ReturnType = typeof(void))]
	[Calls(Type = typeof(Shader), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Shader))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "SetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Texture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004AB")]
	private Material GetDefaultSpriteMaterial() { }

	[Address(RVA = "0x18EAF40", Offset = "0x18EA140", Length = "0x86")]
	[CalledBy(Type = typeof(TMP_SpriteAsset), Member = "GetSpriteIndexFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TMP_SpriteAsset), Member = "SearchForSpriteByHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_SpriteAsset), typeof(int), typeof(bool), typeof(Int32&)}, ReturnType = typeof(TMP_SpriteAsset))]
	[CalledBy(Type = typeof(TMP_SpriteAsset), Member = "SearchForSpriteByHashCodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_SpriteAsset), typeof(int), typeof(bool), typeof(Int32&)}, ReturnType = typeof(TMP_SpriteAsset))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TMP_SpriteAsset), Member = "UpdateLookupTables", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004AD")]
	public int GetSpriteIndexFromHashcode(int hashCode) { }

	[Address(RVA = "0x18EAFD0", Offset = "0x18EA1D0", Length = "0x76")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TMP_SpriteAsset), Member = "UpdateLookupTables", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_TextUtilities), Member = "GetHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TMP_SpriteAsset), Member = "GetSpriteIndexFromHashcode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Token(Token = "0x60004AF")]
	public int GetSpriteIndexFromName(string name) { }

	[Address(RVA = "0x18EB050", Offset = "0x18EA250", Length = "0x98")]
	[CalledBy(Type = typeof(TMP_SpriteAsset), Member = "SearchForSpriteByUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_SpriteAsset), typeof(uint), typeof(bool), typeof(Int32&)}, ReturnType = typeof(TMP_SpriteAsset))]
	[CalledBy(Type = typeof(TMP_SpriteAsset), Member = "SearchForSpriteByUnicodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_SpriteAsset), typeof(uint), typeof(bool), typeof(Int32&)}, ReturnType = typeof(TMP_SpriteAsset))]
	[CalledBy(Type = typeof(TMP_SpriteAsset), Member = "SearchForSpriteByHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_SpriteAsset), typeof(int), typeof(bool), typeof(Int32&)}, ReturnType = typeof(TMP_SpriteAsset))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TMP_SpriteAsset), Member = "UpdateLookupTables", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004AE")]
	public int GetSpriteIndexFromUnicode(uint unicode) { }

	[Address(RVA = "0x18EB340", Offset = "0x18EA540", Length = "0x4BD")]
	[CalledBy(Type = typeof(TMP_Text), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_defaultSpriteAsset", ReturnType = typeof(TMP_SpriteAsset))]
	[Calls(Type = typeof(TMP_SpriteAsset), Member = "SearchForSpriteByHashCodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<TMPro.TMP_SpriteAsset>), typeof(int), typeof(bool), typeof(Int32&)}, ReturnType = typeof(TMP_SpriteAsset))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Int32>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_SpriteAsset), Member = "GetSpriteIndexFromUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TMP_SpriteAsset), Member = "GetSpriteIndexFromHashcode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(TMP_SpriteAsset), Member = "SearchForSpriteByUnicodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<TMPro.TMP_SpriteAsset>), typeof(uint), typeof(bool), typeof(Int32&)}, ReturnType = typeof(TMP_SpriteAsset))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60004B3")]
	public static TMP_SpriteAsset SearchForSpriteByHashCode(TMP_SpriteAsset spriteAsset, int hashCode, bool includeFallbacks, out int spriteIndex) { }

	[Address(RVA = "0x18EB1B0", Offset = "0x18EA3B0", Length = "0x18D")]
	[CalledBy(Type = typeof(TMP_SpriteAsset), Member = "SearchForSpriteByHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_SpriteAsset), typeof(int), typeof(bool), typeof(Int32&)}, ReturnType = typeof(TMP_SpriteAsset))]
	[CalledBy(Type = typeof(TMP_SpriteAsset), Member = "SearchForSpriteByHashCodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_SpriteAsset), typeof(int), typeof(bool), typeof(Int32&)}, ReturnType = typeof(TMP_SpriteAsset))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_SpriteAsset), Member = "SearchForSpriteByHashCodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_SpriteAsset), typeof(int), typeof(bool), typeof(Int32&)}, ReturnType = typeof(TMP_SpriteAsset))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60004B4")]
	private static TMP_SpriteAsset SearchForSpriteByHashCodeInternal(List<TMP_SpriteAsset> spriteAssets, int hashCode, bool searchFallbacks, out int spriteIndex) { }

	[Address(RVA = "0x18EB0F0", Offset = "0x18EA2F0", Length = "0xB3")]
	[CalledBy(Type = typeof(TMP_SpriteAsset), Member = "SearchForSpriteByHashCodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<TMPro.TMP_SpriteAsset>), typeof(int), typeof(bool), typeof(Int32&)}, ReturnType = typeof(TMP_SpriteAsset))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TMP_SpriteAsset), Member = "GetSpriteIndexFromHashcode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TMP_SpriteAsset), Member = "SearchForSpriteByHashCodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<TMPro.TMP_SpriteAsset>), typeof(int), typeof(bool), typeof(Int32&)}, ReturnType = typeof(TMP_SpriteAsset))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004B5")]
	private static TMP_SpriteAsset SearchForSpriteByHashCodeInternal(TMP_SpriteAsset spriteAsset, int hashCode, bool searchFallbacks, out int spriteIndex) { }

	[Address(RVA = "0x18EBA50", Offset = "0x18EAC50", Length = "0x2C0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_SpriteAsset), Member = "GetSpriteIndexFromUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Int32>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(TMP_SpriteAsset), Member = "SearchForSpriteByUnicodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<TMPro.TMP_SpriteAsset>), typeof(uint), typeof(bool), typeof(Int32&)}, ReturnType = typeof(TMP_SpriteAsset))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_defaultSpriteAsset", ReturnType = typeof(TMP_SpriteAsset))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60004B0")]
	public static TMP_SpriteAsset SearchForSpriteByUnicode(TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex) { }

	[Address(RVA = "0x18EB990", Offset = "0x18EAB90", Length = "0xB3")]
	[CalledBy(Type = typeof(TMP_SpriteAsset), Member = "SearchForSpriteByUnicodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<TMPro.TMP_SpriteAsset>), typeof(uint), typeof(bool), typeof(Int32&)}, ReturnType = typeof(TMP_SpriteAsset))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TMP_SpriteAsset), Member = "GetSpriteIndexFromUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TMP_SpriteAsset), Member = "SearchForSpriteByUnicodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<TMPro.TMP_SpriteAsset>), typeof(uint), typeof(bool), typeof(Int32&)}, ReturnType = typeof(TMP_SpriteAsset))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004B2")]
	private static TMP_SpriteAsset SearchForSpriteByUnicodeInternal(TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex) { }

	[Address(RVA = "0x18EB800", Offset = "0x18EAA00", Length = "0x18D")]
	[CalledBy(Type = typeof(TMP_SpriteAsset), Member = "SearchForSpriteByUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_SpriteAsset), typeof(uint), typeof(bool), typeof(Int32&)}, ReturnType = typeof(TMP_SpriteAsset))]
	[CalledBy(Type = typeof(TMP_SpriteAsset), Member = "SearchForSpriteByUnicodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_SpriteAsset), typeof(uint), typeof(bool), typeof(Int32&)}, ReturnType = typeof(TMP_SpriteAsset))]
	[CalledBy(Type = typeof(TMP_SpriteAsset), Member = "SearchForSpriteByHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_SpriteAsset), typeof(int), typeof(bool), typeof(Int32&)}, ReturnType = typeof(TMP_SpriteAsset))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(TMP_SpriteAsset), Member = "SearchForSpriteByUnicodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_SpriteAsset), typeof(uint), typeof(bool), typeof(Int32&)}, ReturnType = typeof(TMP_SpriteAsset))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60004B1")]
	private static TMP_SpriteAsset SearchForSpriteByUnicodeInternal(List<TMP_SpriteAsset> spriteAssets, uint unicode, bool includeFallbacks, out int spriteIndex) { }

	[Address(RVA = "0x2DD4D0", Offset = "0x2DC6D0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60004A7")]
	internal void set_spriteCharacterLookupTable(Dictionary<UInt32, TMP_SpriteCharacter> value) { }

	[Address(RVA = "0x2DD4F0", Offset = "0x2DC6F0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60004A5")]
	internal void set_spriteCharacterTable(List<TMP_SpriteCharacter> value) { }

	[Address(RVA = "0x2DD490", Offset = "0x2DC690", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60004A9")]
	internal void set_spriteGlyphTable(List<TMP_SpriteGlyph> value) { }

	[Address(RVA = "0x18EBD20", Offset = "0x18EAF20", Length = "0x178")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60004B7")]
	internal void SortCharacterTable() { }

	[Address(RVA = "0x18EBEA0", Offset = "0x18EB0A0", Length = "0x2C3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60004B8")]
	internal void SortGlyphAndCharacterTables() { }

	[Address(RVA = "0x18EC170", Offset = "0x18EB370", Length = "0x178")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60004B6")]
	public void SortGlyphTable() { }

	[Address(RVA = "0x18EC2F0", Offset = "0x18EB4F0", Length = "0x5DE")]
	[CalledBy(Type = typeof(TMP_SpriteAsset), Member = "UpgradeSpriteAsset", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_SpriteAnimator+<DoSpriteAnimationInternal>d__7", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TMP_SpriteAsset), Member = "get_spriteCharacterTable", ReturnType = typeof(System.Collections.Generic.List`1<TMPro.TMP_SpriteCharacter>))]
	[CalledBy(Type = typeof(TMP_SpriteAsset), Member = "get_spriteCharacterLookupTable", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, TMPro.TMP_SpriteCharacter>))]
	[CalledBy(Type = typeof(TMP_SpriteAsset), Member = "GetSpriteIndexFromHashcode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TMP_SpriteAsset), Member = "GetSpriteIndexFromUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TMP_SpriteAsset), Member = "GetSpriteIndexFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Int32>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_SpriteAsset), Member = "UpgradeSpriteAsset", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_TextUtilities), Member = "GetHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Int32>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x60004AC")]
	public void UpdateLookupTables() { }

	[Address(RVA = "0x18EC8D0", Offset = "0x18EBAD0", Length = "0x50E")]
	[CalledBy(Type = typeof(TMP_SpriteAsset), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_SpriteAsset), Member = "UpdateLookupTables", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Glyph), Member = "set_metrics", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphMetrics)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GlyphMetrics), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Glyph), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(TMP_SpriteAsset), Member = "UpdateLookupTables", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60004B9")]
	private void UpgradeSpriteAsset() { }

}

