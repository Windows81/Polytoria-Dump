namespace UnityEngine.TextCore.Text;

[ExcludeFromPreset]
[HelpURL("https://docs.unity3d.com/2023.3/Documentation/Manual/UIE-sprite.html")]
[Token(Token = "0x2000032")]
public class SpriteAsset : TextAsset
{
	[CompilerGenerated]
	[Token(Token = "0x2000033")]
	private sealed class <>c
	{
		[Token(Token = "0x4000150")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000151")]
		public static Func<SpriteGlyph, UInt32> <>9__44_0; //Field offset: 0x8
		[Token(Token = "0x4000152")]
		public static Func<SpriteCharacter, UInt32> <>9__45_0; //Field offset: 0x10

		[Address(RVA = "0x1A6D3F0", Offset = "0x1A6C5F0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000146")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000147")]
		public <>c() { }

		[Address(RVA = "0x18B39B0", Offset = "0x18B2BB0", Length = "0x16")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000149")]
		internal uint <SortCharacterTable>b__45_0(SpriteCharacter c) { }

		[Address(RVA = "0x18B3A50", Offset = "0x18B2C50", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000148")]
		internal uint <SortGlyphTable>b__44_0(SpriteGlyph item) { }

	}

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000144")]
	internal Dictionary<Int32, Int32> m_NameLookup; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000145")]
	internal Dictionary<UInt32, Int32> m_GlyphIndexLookup; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4000146")]
	internal FaceInfo m_FaceInfo; //Field offset: 0x48
	[FieldOffset(Offset = "0xA8")]
	[FormerlySerializedAs("spriteSheet")]
	[SerializeField]
	[Token(Token = "0x4000147")]
	internal Texture m_SpriteAtlasTexture; //Field offset: 0xA8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000148")]
	private float <width>k__BackingField; //Field offset: 0xB0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0xB4")]
	[Token(Token = "0x4000149")]
	private float <height>k__BackingField; //Field offset: 0xB4
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	[Token(Token = "0x400014A")]
	private List<SpriteCharacter> m_SpriteCharacterTable; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x400014B")]
	internal Dictionary<UInt32, SpriteCharacter> m_SpriteCharacterLookup; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	[Token(Token = "0x400014C")]
	private List<SpriteGlyph> m_SpriteGlyphTable; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x400014D")]
	internal Dictionary<UInt32, SpriteGlyph> m_SpriteGlyphLookup; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	[Token(Token = "0x400014E")]
	public List<SpriteAsset> fallbackSpriteAssets; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x400014F")]
	internal bool m_IsSpriteAssetLookupTablesDirty; //Field offset: 0xE0

	[Token(Token = "0x1700002C")]
	public internal FaceInfo faceInfo
	{
		[Address(RVA = "0x1A5C1E0", Offset = "0x1A5B3E0", Length = "0x39")]
		[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
		[CallerCount(Count = 5)]
		[Token(Token = "0x6000129")]
		 get { } //Length: 57
		[Address(RVA = "0x1A5C2C0", Offset = "0x1A5B4C0", Length = "0x40")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600012A")]
		internal set { } //Length: 64
	}

	[Token(Token = "0x1700002F")]
	internal float height
	{
		[Address(RVA = "0x1A5C220", Offset = "0x1A5B420", Length = "0x9")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x600012F")]
		internal get { } //Length: 9
		[Address(RVA = "0x1A5C300", Offset = "0x1A5B500", Length = "0x9")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6000130")]
		private set { } //Length: 9
	}

	[Token(Token = "0x17000031")]
	public internal Dictionary<UInt32, SpriteCharacter> spriteCharacterLookupTable
	{
		[Address(RVA = "0x1A5C230", Offset = "0x1A5B430", Length = "0x34")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SpriteAsset), Member = "UpdateLookupTables", ReturnType = typeof(void))]
		[Token(Token = "0x6000133")]
		 get { } //Length: 52
		[Address(RVA = "0x2DD490", Offset = "0x2DC690", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000134")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x17000030")]
	public internal List<SpriteCharacter> spriteCharacterTable
	{
		[Address(RVA = "0x1A5C270", Offset = "0x1A5B470", Length = "0x31")]
		[CalledBy(Type = typeof(TextGenerator), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&), typeof(TextGenerationSettings), typeof(TextInfo), typeof(Boolean&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TextGenerator), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(int))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(SpriteAsset), Member = "UpdateLookupTables", ReturnType = typeof(void))]
		[Token(Token = "0x6000131")]
		 get { } //Length: 49
		[Address(RVA = "0x2DD4D0", Offset = "0x2DC6D0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000132")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x17000032")]
	public internal List<SpriteGlyph> spriteGlyphTable
	{
		[Address(RVA = "0x19AA8A0", Offset = "0x19A9AA0", Length = "0xA")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000135")]
		 get { } //Length: 10
		[Address(RVA = "0x2DD450", Offset = "0x2DC650", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000136")]
		internal set { } //Length: 19
	}

	[Token(Token = "0x1700002D")]
	public internal Texture spriteSheet
	{
		[Address(RVA = "0x19AA7E0", Offset = "0x19A99E0", Length = "0xA")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600012B")]
		 get { } //Length: 10
		[Address(RVA = "0x1A5C310", Offset = "0x1A5B510", Length = "0x83")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x600012C")]
		internal set { } //Length: 131
	}

	[Token(Token = "0x1700002E")]
	internal float width
	{
		[Address(RVA = "0x1A5C2B0", Offset = "0x1A5B4B0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x600012D")]
		internal get { } //Length: 9
		[Address(RVA = "0x1A5C3A0", Offset = "0x1A5B5A0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x600012E")]
		private set { } //Length: 9
	}

	[Address(RVA = "0x1A5C110", Offset = "0x1A5B310", Length = "0xD0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000145")]
	public SpriteAsset() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000137")]
	private void Awake() { }

	[Address(RVA = "0x1A5C1E0", Offset = "0x1A5B3E0", Length = "0x39")]
	[CalledBy(Type = typeof(TextGenerator), Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 5)]
	[Token(Token = "0x6000129")]
	public FaceInfo get_faceInfo() { }

	[Address(RVA = "0x1A5C220", Offset = "0x1A5B420", Length = "0x9")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x600012F")]
	internal float get_height() { }

	[Address(RVA = "0x1A5C230", Offset = "0x1A5B430", Length = "0x34")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpriteAsset), Member = "UpdateLookupTables", ReturnType = typeof(void))]
	[Token(Token = "0x6000133")]
	public Dictionary<UInt32, SpriteCharacter> get_spriteCharacterLookupTable() { }

	[Address(RVA = "0x1A5C270", Offset = "0x1A5B470", Length = "0x31")]
	[CalledBy(Type = typeof(TextGenerator), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&), typeof(TextGenerationSettings), typeof(TextInfo), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TextGenerator), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(TextGenerationSettings), typeof(TextInfo)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SpriteAsset), Member = "UpdateLookupTables", ReturnType = typeof(void))]
	[Token(Token = "0x6000131")]
	public List<SpriteCharacter> get_spriteCharacterTable() { }

	[Address(RVA = "0x19AA8A0", Offset = "0x19A9AA0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000135")]
	public List<SpriteGlyph> get_spriteGlyphTable() { }

	[Address(RVA = "0x19AA7E0", Offset = "0x19A99E0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600012B")]
	public Texture get_spriteSheet() { }

	[Address(RVA = "0x1A5C2B0", Offset = "0x1A5B4B0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x600012D")]
	internal float get_width() { }

	[Address(RVA = "0x1A5AB10", Offset = "0x1A59D10", Length = "0x80")]
	[CalledBy(Type = typeof(SpriteAsset), Member = "GetSpriteIndexFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SpriteAsset), Member = "SearchForSpriteByHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteAsset), typeof(int), typeof(bool), typeof(Int32&), typeof(TextSettings)}, ReturnType = typeof(SpriteAsset))]
	[CalledBy(Type = typeof(SpriteAsset), Member = "SearchForSpriteByHashCodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteAsset), typeof(int), typeof(bool), typeof(System.Collections.Generic.HashSet`1<System.Int32>), typeof(Int32&)}, ReturnType = typeof(SpriteAsset))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SpriteAsset), Member = "UpdateLookupTables", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000139")]
	public int GetSpriteIndexFromHashcode(int hashCode) { }

	[Address(RVA = "0x1A5ABA0", Offset = "0x1A59DA0", Length = "0x3F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpriteAsset), Member = "UpdateLookupTables", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextUtilities), Member = "GetHashCodeCaseInSensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SpriteAsset), Member = "GetSpriteIndexFromHashcode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Token(Token = "0x600013B")]
	public int GetSpriteIndexFromName(string name) { }

	[Address(RVA = "0x1A5ABE0", Offset = "0x1A59DE0", Length = "0x98")]
	[CalledBy(Type = typeof(SpriteAsset), Member = "SearchForSpriteByUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteAsset), typeof(uint), typeof(bool), typeof(Int32&)}, ReturnType = typeof(SpriteAsset))]
	[CalledBy(Type = typeof(SpriteAsset), Member = "SearchForSpriteByUnicodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteAsset), typeof(uint), typeof(bool), typeof(System.Collections.Generic.HashSet`1<System.Int32>), typeof(Int32&)}, ReturnType = typeof(SpriteAsset))]
	[CalledBy(Type = typeof(SpriteAsset), Member = "SearchForSpriteByHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteAsset), typeof(int), typeof(bool), typeof(Int32&), typeof(TextSettings)}, ReturnType = typeof(SpriteAsset))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SpriteAsset), Member = "UpdateLookupTables", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600013A")]
	public int GetSpriteIndexFromUnicode(uint unicode) { }

	[Address(RVA = "0x1A5AED0", Offset = "0x1A5A0D0", Length = "0x308")]
	[CalledBy(Type = typeof(TextGenerator), Member = "ValidateHtmlTag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[]), typeof(int), typeof(Int32&), typeof(TextGenerationSettings), typeof(TextInfo), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Int32>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(SpriteAsset), Member = "SearchForSpriteByUnicodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.SpriteAsset>), typeof(uint), typeof(bool), typeof(System.Collections.Generic.HashSet`1<System.Int32>), typeof(Int32&)}, ReturnType = typeof(SpriteAsset))]
	[Calls(Type = typeof(SpriteAsset), Member = "GetSpriteIndexFromUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(SpriteAsset), Member = "SearchForSpriteByHashCodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteAsset), typeof(int), typeof(bool), typeof(System.Collections.Generic.HashSet`1<System.Int32>), typeof(Int32&)}, ReturnType = typeof(SpriteAsset))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SpriteAsset), Member = "SearchForSpriteByHashCodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.SpriteAsset>), typeof(int), typeof(bool), typeof(System.Collections.Generic.HashSet`1<System.Int32>), typeof(Int32&)}, ReturnType = typeof(SpriteAsset))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SpriteAsset), Member = "SearchForSpriteByUnicodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteAsset), typeof(uint), typeof(bool), typeof(System.Collections.Generic.HashSet`1<System.Int32>), typeof(Int32&)}, ReturnType = typeof(SpriteAsset))]
	[Calls(Type = typeof(SpriteAsset), Member = "GetSpriteIndexFromHashcode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600013F")]
	public static SpriteAsset SearchForSpriteByHashCode(SpriteAsset spriteAsset, int hashCode, bool includeFallbacks, out int spriteIndex, TextSettings textSettings = null) { }

	[Address(RVA = "0x1A5AC80", Offset = "0x1A59E80", Length = "0xBF")]
	[CalledBy(Type = typeof(SpriteAsset), Member = "SearchForSpriteByHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteAsset), typeof(int), typeof(bool), typeof(Int32&), typeof(TextSettings)}, ReturnType = typeof(SpriteAsset))]
	[CalledBy(Type = typeof(SpriteAsset), Member = "SearchForSpriteByHashCodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.SpriteAsset>), typeof(int), typeof(bool), typeof(System.Collections.Generic.HashSet`1<System.Int32>), typeof(Int32&)}, ReturnType = typeof(SpriteAsset))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SpriteAsset), Member = "GetSpriteIndexFromHashcode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SpriteAsset), Member = "SearchForSpriteByHashCodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.SpriteAsset>), typeof(int), typeof(bool), typeof(System.Collections.Generic.HashSet`1<System.Int32>), typeof(Int32&)}, ReturnType = typeof(SpriteAsset))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000141")]
	private static SpriteAsset SearchForSpriteByHashCodeInternal(SpriteAsset spriteAsset, int hashCode, bool searchFallbacks, HashSet<Int32> searchedSpriteAssets, out int spriteIndex) { }

	[Address(RVA = "0x1A5AD40", Offset = "0x1A59F40", Length = "0x182")]
	[CalledBy(Type = typeof(SpriteAsset), Member = "SearchForSpriteByHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteAsset), typeof(int), typeof(bool), typeof(Int32&), typeof(TextSettings)}, ReturnType = typeof(SpriteAsset))]
	[CalledBy(Type = typeof(SpriteAsset), Member = "SearchForSpriteByHashCodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteAsset), typeof(int), typeof(bool), typeof(System.Collections.Generic.HashSet`1<System.Int32>), typeof(Int32&)}, ReturnType = typeof(SpriteAsset))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SpriteAsset), Member = "SearchForSpriteByHashCodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteAsset), typeof(int), typeof(bool), typeof(System.Collections.Generic.HashSet`1<System.Int32>), typeof(Int32&)}, ReturnType = typeof(SpriteAsset))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000140")]
	private static SpriteAsset SearchForSpriteByHashCodeInternal(List<SpriteAsset> spriteAssets, int hashCode, bool searchFallbacks, HashSet<Int32> searchedSpriteAssets, out int spriteIndex) { }

	[Address(RVA = "0x1A5B420", Offset = "0x1A5A620", Length = "0x162")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SpriteAsset), Member = "GetSpriteIndexFromUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Int32>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(SpriteAsset), Member = "SearchForSpriteByUnicodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.SpriteAsset>), typeof(uint), typeof(bool), typeof(System.Collections.Generic.HashSet`1<System.Int32>), typeof(Int32&)}, ReturnType = typeof(SpriteAsset))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600013C")]
	public static SpriteAsset SearchForSpriteByUnicode(SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex) { }

	[Address(RVA = "0x1A5B1E0", Offset = "0x1A5A3E0", Length = "0x172")]
	[CalledBy(Type = typeof(SpriteAsset), Member = "SearchForSpriteByUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteAsset), typeof(uint), typeof(bool), typeof(Int32&)}, ReturnType = typeof(SpriteAsset))]
	[CalledBy(Type = typeof(SpriteAsset), Member = "SearchForSpriteByUnicodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteAsset), typeof(uint), typeof(bool), typeof(System.Collections.Generic.HashSet`1<System.Int32>), typeof(Int32&)}, ReturnType = typeof(SpriteAsset))]
	[CalledBy(Type = typeof(SpriteAsset), Member = "SearchForSpriteByHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteAsset), typeof(int), typeof(bool), typeof(Int32&), typeof(TextSettings)}, ReturnType = typeof(SpriteAsset))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(SpriteAsset), Member = "SearchForSpriteByUnicodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteAsset), typeof(uint), typeof(bool), typeof(System.Collections.Generic.HashSet`1<System.Int32>), typeof(Int32&)}, ReturnType = typeof(SpriteAsset))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600013D")]
	private static SpriteAsset SearchForSpriteByUnicodeInternal(List<SpriteAsset> spriteAssets, uint unicode, bool includeFallbacks, HashSet<Int32> searchedSpriteAssets, out int spriteIndex) { }

	[Address(RVA = "0x1A5B360", Offset = "0x1A5A560", Length = "0xBF")]
	[CalledBy(Type = typeof(SpriteAsset), Member = "SearchForSpriteByUnicodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.SpriteAsset>), typeof(uint), typeof(bool), typeof(System.Collections.Generic.HashSet`1<System.Int32>), typeof(Int32&)}, ReturnType = typeof(SpriteAsset))]
	[CalledBy(Type = typeof(SpriteAsset), Member = "SearchForSpriteByHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteAsset), typeof(int), typeof(bool), typeof(Int32&), typeof(TextSettings)}, ReturnType = typeof(SpriteAsset))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SpriteAsset), Member = "GetSpriteIndexFromUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SpriteAsset), Member = "SearchForSpriteByUnicodeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.SpriteAsset>), typeof(uint), typeof(bool), typeof(System.Collections.Generic.HashSet`1<System.Int32>), typeof(Int32&)}, ReturnType = typeof(SpriteAsset))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600013E")]
	private static SpriteAsset SearchForSpriteByUnicodeInternal(SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, HashSet<Int32> searchedSpriteAssets, out int spriteIndex) { }

	[Address(RVA = "0x1A5C2C0", Offset = "0x1A5B4C0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600012A")]
	internal void set_faceInfo(FaceInfo value) { }

	[Address(RVA = "0x1A5C300", Offset = "0x1A5B500", Length = "0x9")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6000130")]
	private void set_height(float value) { }

	[Address(RVA = "0x2DD490", Offset = "0x2DC690", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000134")]
	internal void set_spriteCharacterLookupTable(Dictionary<UInt32, SpriteCharacter> value) { }

	[Address(RVA = "0x2DD4D0", Offset = "0x2DC6D0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000132")]
	internal void set_spriteCharacterTable(List<SpriteCharacter> value) { }

	[Address(RVA = "0x2DD450", Offset = "0x2DC650", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000136")]
	internal void set_spriteGlyphTable(List<SpriteGlyph> value) { }

	[Address(RVA = "0x1A5C310", Offset = "0x1A5B510", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600012C")]
	internal void set_spriteSheet(Texture value) { }

	[Address(RVA = "0x1A5C3A0", Offset = "0x1A5B5A0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x600012E")]
	private void set_width(float value) { }

	[Address(RVA = "0x1A5B590", Offset = "0x1A5A790", Length = "0x178")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000143")]
	internal void SortCharacterTable() { }

	[Address(RVA = "0x1A5B710", Offset = "0x1A5A910", Length = "0x2C3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000144")]
	internal void SortGlyphAndCharacterTables() { }

	[Address(RVA = "0x1A5B9E0", Offset = "0x1A5ABE0", Length = "0x178")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000142")]
	public void SortGlyphTable() { }

	[Address(RVA = "0x1A5BB60", Offset = "0x1A5AD60", Length = "0x5A3")]
	[CalledBy(Type = typeof(FontAssetUtilities), Member = "GetSpriteCharacterFromSpriteAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(SpriteAsset), typeof(bool)}, ReturnType = typeof(SpriteCharacter))]
	[CalledBy(Type = typeof(FontAssetUtilities), Member = "GetSpriteCharacterFromSpriteAsset_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(SpriteAsset), typeof(bool)}, ReturnType = typeof(SpriteCharacter))]
	[CalledBy(Type = typeof(SpriteAsset), Member = "get_spriteCharacterTable", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.Text.SpriteCharacter>))]
	[CalledBy(Type = typeof(SpriteAsset), Member = "get_spriteCharacterLookupTable", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, UnityEngine.TextCore.Text.SpriteCharacter>))]
	[CalledBy(Type = typeof(SpriteAsset), Member = "GetSpriteIndexFromHashcode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SpriteAsset), Member = "GetSpriteIndexFromUnicode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SpriteAsset), Member = "GetSpriteIndexFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextUtilities), Member = "GetHashCodeCaseInSensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Int32>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Int32>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000138")]
	public void UpdateLookupTables() { }

}

