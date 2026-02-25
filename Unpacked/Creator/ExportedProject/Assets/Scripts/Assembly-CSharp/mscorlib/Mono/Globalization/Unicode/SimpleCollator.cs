namespace Mono.Globalization.Unicode;

[Token(Token = "0x2000058")]
internal class SimpleCollator : ISimpleCollator
{
	[Token(Token = "0x2000059")]
	public struct Context
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000193")]
		public readonly CompareOptions Option; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000194")]
		public readonly Byte* NeverMatchFlags; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000195")]
		public readonly Byte* AlwaysMatchFlags; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000196")]
		public Byte* Buffer1; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000197")]
		public Byte* Buffer2; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000198")]
		public int PrevCode; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000199")]
		public Byte* PrevSortKey; //Field offset: 0x30

		[Address(RVA = "0x12D7960", Offset = "0x12D6B60", Length = "0x2D")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600010D")]
		public Context(CompareOptions opt, Byte* alwaysMatchFlags, Byte* neverMatchFlags, Byte* buffer1, Byte* buffer2, Byte* prev1) { }

	}

	[Token(Token = "0x200005B")]
	private struct Escape
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400019C")]
		public string Source; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400019D")]
		public int Index; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x400019E")]
		public int Start; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400019F")]
		public int End; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40001A0")]
		public int Optional; //Field offset: 0x14

	}

	[Token(Token = "0x200005C")]
	private enum ExtenderType
	{
		None = 0,
		Simple = 1,
		Voiced = 2,
		Conditional = 3,
		Buggy = 4,
	}

	[Token(Token = "0x200005A")]
	private struct PreviousInfo
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400019A")]
		public int Code; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400019B")]
		public Byte* SortKey; //Field offset: 0x8

		[Address(RVA = "0x12DD6F0", Offset = "0x12DC8F0", Length = "0xF")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600010E")]
		public PreviousInfo(bool dummy) { }

	}

	[Token(Token = "0x4000187")]
	private static SimpleCollator invariant; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000188")]
	private readonly TextInfo textInfo; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000189")]
	private readonly CodePointIndexer cjkIndexer; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400018A")]
	private readonly Contraction[] contractions; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400018B")]
	private readonly Level2Map[] level2Maps; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400018C")]
	private readonly Byte[] unsafeFlags; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400018D")]
	private readonly Byte* cjkCatTable; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400018E")]
	private readonly Byte* cjkLv1Table; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400018F")]
	private readonly Byte* cjkLv2Table; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000190")]
	private readonly CodePointIndexer cjkLv2Indexer; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000191")]
	private readonly int lcid; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000192")]
	private readonly bool frenchSort; //Field offset: 0x5C

	[Address(RVA = "0x12E4130", Offset = "0x12E3330", Length = "0x9F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SimpleCollator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600010C")]
	private static SimpleCollator() { }

	[Address(RVA = "0x12E41D0", Offset = "0x12E33D0", Length = "0x4A1")]
	[CalledBy(Type = typeof(SimpleCollator), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CompareInfo), Member = "GetCollator", ReturnType = typeof(ISimpleCollator))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "FillCJK", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CodePointIndexer&), typeof(Byte*&), typeof(Byte*&), typeof(CodePointIndexer&), typeof(Byte*&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "GetTailoringInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TailoringInfo))]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "BuildTailoringTables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo), typeof(TailoringInfo), typeof(Contraction[]&), typeof(Level2Map[]&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000DD")]
	public SimpleCollator(CultureInfo culture) { }

	[Address(RVA = "0x12DEAD0", Offset = "0x12DDCD0", Length = "0x94")]
	[CalledBy(Type = typeof(SimpleCollator), Member = "FillSortKeyRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ExtenderType), typeof(SortKeyBuffer), typeof(CompareOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "CompareInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(Boolean&), typeof(Boolean&), typeof(bool), typeof(bool), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(Byte*), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(Byte*), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "MatchesForwardCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(Byte*), typeof(bool), typeof(ExtenderType), typeof(Contraction&), typeof(Context&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "MatchesBackwardCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(int), typeof(Byte*), typeof(bool), typeof(ExtenderType), typeof(Contraction&), typeof(Context&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CodePointIndexer), Member = "ToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "Category", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000E0")]
	private byte Category(int cp) { }

	[Address(RVA = "0x12DEB70", Offset = "0x12DDD70", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Token(Token = "0x60000F5")]
	private void ClearBuffer(Byte* buffer, int size) { }

	[Address(RVA = "0x12DFD20", Offset = "0x12DEF20", Length = "0xF4")]
	[CalledBy(Type = typeof(SimpleCollator), Member = "System.Globalization.ISimpleCollator.Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(CompareOptions)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "IsSuffix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(CompareOptions)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "IsSuffix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(CompareOptions)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SimpleCollator), Member = "CompareInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(Boolean&), typeof(Boolean&), typeof(bool), typeof(bool), typeof(Context&)}, ReturnType = typeof(int))]
	[Token(Token = "0x60000F4")]
	internal int Compare(string s1, int idx1, int len1, string s2, int idx2, int len2, CompareOptions options) { }

	[Address(RVA = "0x12DEB90", Offset = "0x12DDD90", Length = "0x18")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60000F7")]
	private int CompareFlagPair(bool b1, bool b2) { }

	[Address(RVA = "0x12DEBB0", Offset = "0x12DDDB0", Length = "0x116B")]
	[CalledBy(Type = typeof(SimpleCollator), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(CompareOptions)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "IsPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(CompareOptions)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "IsPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(bool), typeof(Context&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(Byte*), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(Byte*), typeof(Context&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(SimpleCollator), Member = "GetContraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(Contraction))]
	[Calls(Type = typeof(SimpleCollator), Member = "Level2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ExtenderType)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "HasSpecialWeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SimpleCollator), Member = "Category", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(SimpleCollator), Member = "IsHalfKana", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CompareOptions)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "Level3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "IsIgnorableNonSpacing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "IsJapaneseSmallLetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SimpleCollator), Member = "Level1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(SimpleCollator), Member = "FilterOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CompareOptions)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SimpleCollator), Member = "IsSafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(SimpleCollator), Member = "IsIgnorable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CompareOptions)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SimpleCollator), Member = "GetExtenderType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ExtenderType))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SimpleCollator), Member = "FilterExtender", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ExtenderType), typeof(CompareOptions)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000F6")]
	private int CompareInternal(string s1, int idx1, int len1, string s2, int idx2, int len2, out bool targetConsumed, out bool sourceConsumed, bool skipHeadingExtenders, bool immediateBreakup, ref Context ctx) { }

	[Address(RVA = "0x12DFE20", Offset = "0x12DF020", Length = "0x53A")]
	[CalledBy(Type = typeof(SimpleCollator), Member = "GetSortKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(SortKeyBuffer), typeof(CompareOptions)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SimpleCollator), Member = "Level2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ExtenderType)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(SortKeyBuffer), Member = "AppendBufferPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(Byte[]&), typeof(Int32&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SimpleCollator), Member = "IsHalfKana", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CompareOptions)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "IsJapaneseSmallLetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "Level3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(SimpleCollator), Member = "Level1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(SimpleCollator), Member = "Category", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(SortKeyBuffer), Member = "AppendNormal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(byte), typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(char), Member = "GetUnicodeCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(UnicodeCategory))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "HasSpecialWeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000F1")]
	private void FillSortKeyRaw(int i, ExtenderType ext, SortKeyBuffer buf, CompareOptions opt) { }

	[Address(RVA = "0x12E0360", Offset = "0x12DF560", Length = "0xC1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SortKeyBuffer), Member = "AppendNormal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(byte), typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000F2")]
	private void FillSurrogateSortKeyRaw(int i, SortKeyBuffer buf) { }

	[Address(RVA = "0x12E0430", Offset = "0x12DF630", Length = "0x20F")]
	[CalledBy(Type = typeof(SimpleCollator), Member = "GetSortKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(SortKeyBuffer), typeof(CompareOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "CompareInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(Boolean&), typeof(Boolean&), typeof(bool), typeof(bool), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "MatchesForwardCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(Byte*), typeof(bool), typeof(ExtenderType), typeof(Contraction&), typeof(Context&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "MatchesBackwardCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(int), typeof(Byte*), typeof(bool), typeof(ExtenderType), typeof(Contraction&), typeof(Context&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SimpleCollator), Member = "IsHalfKana", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CompareOptions)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SimpleCollator), Member = "Level1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000EB")]
	private int FilterExtender(int i, ExtenderType ext, CompareOptions opt) { }

	[Address(RVA = "0x12E0640", Offset = "0x12DF840", Length = "0x94")]
	[CalledBy(Type = typeof(SimpleCollator), Member = "GetSortKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(SortKeyBuffer), typeof(CompareOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "CompareInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(Boolean&), typeof(Boolean&), typeof(bool), typeof(bool), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(Byte*), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(Byte*), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "MatchesForwardCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(Byte*), typeof(bool), typeof(ExtenderType), typeof(Contraction&), typeof(Context&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "MatchesBackwardCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(int), typeof(Byte*), typeof(bool), typeof(ExtenderType), typeof(Contraction&), typeof(Context&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60000E8")]
	private int FilterOptions(int i, CompareOptions opt) { }

	[Address(RVA = "0x12E0A30", Offset = "0x12DFC30", Length = "0xD5")]
	[CalledBy(Type = typeof(SimpleCollator), Member = "GetSortKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(SortKeyBuffer), typeof(CompareOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "CompareInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(Boolean&), typeof(Boolean&), typeof(bool), typeof(bool), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(Byte*), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(Byte*), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "MatchesForwardCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(Byte*), typeof(bool), typeof(ExtenderType), typeof(Contraction&), typeof(Context&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SimpleCollator), Member = "GetContraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(Contraction[])}, ReturnType = typeof(Contraction))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000E4")]
	private Contraction GetContraction(string s, int start, int end) { }

	[Address(RVA = "0x12E08F0", Offset = "0x12DFAF0", Length = "0x131")]
	[CalledBy(Type = typeof(SimpleCollator), Member = "GetContraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(Contraction))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60000E5")]
	private Contraction GetContraction(string s, int start, int end, Contraction[] clist) { }

	[Address(RVA = "0x12E0B10", Offset = "0x12DFD10", Length = "0xB9")]
	[CalledBy(Type = typeof(SimpleCollator), Member = "GetSortKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(SortKeyBuffer), typeof(CompareOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "CompareInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(Boolean&), typeof(Boolean&), typeof(bool), typeof(bool), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "MatchesForward", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(Byte*), typeof(bool), typeof(Context&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "MatchesBackward", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(int), typeof(Byte*), typeof(bool), typeof(Context&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Token(Token = "0x60000E9")]
	private ExtenderType GetExtenderType(int i) { }

	[Address(RVA = "0x12E0BD0", Offset = "0x12DFDD0", Length = "0x97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x60000DF")]
	private static CultureInfo GetNeutralCulture(CultureInfo info) { }

	[Address(RVA = "0x12E10E0", Offset = "0x12E02E0", Length = "0xE5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SortKeyBuffer), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompareOptions), typeof(int), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SimpleCollator), Member = "GetSortKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(SortKeyBuffer), typeof(CompareOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SortKeyBuffer), Member = "GetResult", ReturnType = typeof(SortKey))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000EE")]
	public override SortKey GetSortKey(string s, CompareOptions options) { }

	[Address(RVA = "0x12E0C70", Offset = "0x12DFE70", Length = "0xF3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SortKeyBuffer), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompareOptions), typeof(int), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SimpleCollator), Member = "GetSortKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(SortKeyBuffer), typeof(CompareOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SortKeyBuffer), Member = "GetResult", ReturnType = typeof(SortKey))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000EF")]
	public SortKey GetSortKey(string s, int start, int length, CompareOptions options) { }

	[Address(RVA = "0x12E0D70", Offset = "0x12DFF70", Length = "0x360")]
	[CalledBy(Type = typeof(SimpleCollator), Member = "GetSortKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CompareOptions)}, ReturnType = typeof(SortKey))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "GetSortKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(CompareOptions)}, ReturnType = typeof(SortKey))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "GetSortKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(SortKeyBuffer), typeof(CompareOptions)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SimpleCollator), Member = "IsIgnorable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CompareOptions)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SimpleCollator), Member = "FillSortKeyRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ExtenderType), typeof(SortKeyBuffer), typeof(CompareOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SimpleCollator), Member = "FilterExtender", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ExtenderType), typeof(CompareOptions)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SimpleCollator), Member = "GetSortKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(SortKeyBuffer), typeof(CompareOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SortKeyBuffer), Member = "AppendNormal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(byte), typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "Level3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(SimpleCollator), Member = "Level2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ExtenderType)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "IsIgnorableNonSpacing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(SimpleCollator), Member = "FilterOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CompareOptions)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SimpleCollator), Member = "GetExtenderType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ExtenderType))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SimpleCollator), Member = "GetContraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(Contraction))]
	[Token(Token = "0x60000F0")]
	private void GetSortKey(string s, int start, int end, SortKeyBuffer buf, CompareOptions opt) { }

	[Address(RVA = "0x12E11D0", Offset = "0x12E03D0", Length = "0x1FE")]
	[CalledBy(Type = typeof(SimpleCollator), Member = "GetTailContraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(Contraction))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "MatchesBackwardCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(int), typeof(Byte*), typeof(bool), typeof(ExtenderType), typeof(Contraction&), typeof(Context&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000E7")]
	private Contraction GetTailContraction(string s, int start, int end, Contraction[] clist) { }

	[Address(RVA = "0x12E13D0", Offset = "0x12E05D0", Length = "0xD5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SimpleCollator), Member = "GetTailContraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(Contraction[])}, ReturnType = typeof(Contraction))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000E6")]
	private Contraction GetTailContraction(string s, int start, int end) { }

	[Address(RVA = "0x12E16B0", Offset = "0x12E08B0", Length = "0x503")]
	[CalledBy(Type = typeof(SimpleCollator), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(CompareOptions)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(Byte*), typeof(Context&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SimpleCollator), Member = "FilterOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CompareOptions)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SimpleCollator), Member = "CompareInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(Boolean&), typeof(Boolean&), typeof(bool), typeof(bool), typeof(Context&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SimpleCollator), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(Byte*), typeof(Context&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SimpleCollator), Member = "MatchesForward", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(Byte*), typeof(bool), typeof(Context&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "HasSpecialWeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "Level3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(SimpleCollator), Member = "Level2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ExtenderType)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(SimpleCollator), Member = "Level1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(SimpleCollator), Member = "GetContraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(Contraction))]
	[Calls(Type = typeof(SimpleCollator), Member = "IsIgnorable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CompareOptions)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SimpleCollator), Member = "Category", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[Token(Token = "0x6000102")]
	private int IndexOf(string s, string target, int start, int length, Byte* targetSortKey, ref Context ctx) { }

	[Address(RVA = "0x12E1BC0", Offset = "0x12E0DC0", Length = "0x2CE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(SimpleCollator), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(Byte*), typeof(Context&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000FE")]
	public override int IndexOf(string s, string target, int start, int length, CompareOptions opt) { }

	[Address(RVA = "0x12E1570", Offset = "0x12E0770", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000100")]
	private int IndexOfOrdinal(string s, char target, int start, int length) { }

	[Address(RVA = "0x12E14B0", Offset = "0x12E06B0", Length = "0xB9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000FF")]
	private int IndexOfOrdinal(string s, string target, int start, int length) { }

	[Address(RVA = "0x12E15F0", Offset = "0x12E07F0", Length = "0xBB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SimpleCollator), Member = "MatchesForward", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(Byte*), typeof(bool), typeof(Context&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000101")]
	private int IndexOfSortKey(string s, int start, int length, Byte* sortkey, char target, int ti, bool noLv4, ref Context ctx) { }

	[Address(RVA = "0x12E1E90", Offset = "0x12E1090", Length = "0x7F")]
	[CalledBy(Type = typeof(SimpleCollator), Member = "FilterExtender", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ExtenderType), typeof(CompareOptions)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "FillSortKeyRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ExtenderType), typeof(SortKeyBuffer), typeof(CompareOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "CompareInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(Boolean&), typeof(Boolean&), typeof(bool), typeof(bool), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "MatchesPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompareOptions), typeof(Byte*), typeof(int), typeof(ExtenderType), typeof(Byte*), typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000E3")]
	private static bool IsHalfKana(int cp, CompareOptions opt) { }

	[Address(RVA = "0x12E1F10", Offset = "0x12E1110", Length = "0x87")]
	[CalledBy(Type = typeof(SimpleCollator), Member = "GetSortKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(SortKeyBuffer), typeof(CompareOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "CompareInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(Boolean&), typeof(Boolean&), typeof(bool), typeof(bool), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(Byte*), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(Byte*), typeof(Context&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "IsIgnorable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(byte)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000EC")]
	private static bool IsIgnorable(int i, CompareOptions opt) { }

	[Address(RVA = "0x12E2020", Offset = "0x12E1220", Length = "0x30")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SimpleCollator), Member = "IsPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(CompareOptions)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000F8")]
	public override bool IsPrefix(string src, string target, CompareOptions opt) { }

	[Address(RVA = "0x12E2060", Offset = "0x12E1260", Length = "0xF1")]
	[CalledBy(Type = typeof(SimpleCollator), Member = "IsPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(CompareOptions)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SimpleCollator), Member = "CompareInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(Boolean&), typeof(Boolean&), typeof(bool), typeof(bool), typeof(Context&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000F9")]
	public bool IsPrefix(string s, string target, int start, int length, CompareOptions opt) { }

	[Address(RVA = "0x12E1FA0", Offset = "0x12E11A0", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SimpleCollator), Member = "CompareInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(Boolean&), typeof(Boolean&), typeof(bool), typeof(bool), typeof(Context&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000FA")]
	private bool IsPrefix(string s, string target, int start, int length, bool skipHeadingExtenders, ref Context ctx) { }

	[Address(RVA = "0x12E2160", Offset = "0x12E1360", Length = "0x6A")]
	[CalledBy(Type = typeof(SimpleCollator), Member = "CompareInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(Boolean&), typeof(Boolean&), typeof(bool), typeof(bool), typeof(Context&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000ED")]
	private bool IsSafe(int i) { }

	[Address(RVA = "0x12E21D0", Offset = "0x12E13D0", Length = "0xBB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SimpleCollator), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(CompareOptions)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SimpleCollator), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(CompareOptions)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000FC")]
	public bool IsSuffix(string s, string target, int start, int length, CompareOptions opt) { }

	[Address(RVA = "0x12E2290", Offset = "0x12E1490", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SimpleCollator), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(CompareOptions)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SimpleCollator), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(CompareOptions)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000FB")]
	public override bool IsSuffix(string src, string target, CompareOptions opt) { }

	[Address(RVA = "0x12E2B50", Offset = "0x12E1D50", Length = "0x1A7")]
	[CalledBy(Type = typeof(SimpleCollator), Member = "IsSuffix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(CompareOptions)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "IsSuffix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(CompareOptions)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SimpleCollator), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(Byte*), typeof(Context&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000103")]
	public override int LastIndexOf(string s, string target, int start, int length, CompareOptions opt) { }

	[Address(RVA = "0x12E2570", Offset = "0x12E1770", Length = "0x5D1")]
	[CalledBy(Type = typeof(SimpleCollator), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(CompareOptions)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(Byte*), typeof(Context&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SimpleCollator), Member = "FilterOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CompareOptions)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SimpleCollator), Member = "CompareInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(Boolean&), typeof(Boolean&), typeof(bool), typeof(bool), typeof(Context&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SimpleCollator), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(Byte*), typeof(Context&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SimpleCollator), Member = "MatchesBackward", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(int), typeof(Byte*), typeof(bool), typeof(Context&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "HasSpecialWeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "Level3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(SimpleCollator), Member = "Level2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ExtenderType)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(SimpleCollator), Member = "Level1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(SimpleCollator), Member = "GetContraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(Contraction))]
	[Calls(Type = typeof(SimpleCollator), Member = "IsIgnorable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CompareOptions)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SimpleCollator), Member = "Category", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[Token(Token = "0x6000106")]
	private int LastIndexOf(string s, string target, int start, int length, Byte* targetSortKey, ref Context ctx) { }

	[Address(RVA = "0x12E2350", Offset = "0x12E1550", Length = "0x144")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000104")]
	private int LastIndexOfOrdinal(string s, string target, int start, int length) { }

	[Address(RVA = "0x12E24A0", Offset = "0x12E16A0", Length = "0xC7")]
	[CalledBy(Type = typeof(SimpleCollator), Member = "MatchesBackwardCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(int), typeof(Byte*), typeof(bool), typeof(ExtenderType), typeof(Contraction&), typeof(Context&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SimpleCollator), Member = "MatchesBackward", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(int), typeof(Byte*), typeof(bool), typeof(Context&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000105")]
	private int LastIndexOfSortKey(string s, int start, int orgStart, int length, Byte* sortkey, int ti, bool noLv4, ref Context ctx) { }

	[Address(RVA = "0x12E2D00", Offset = "0x12E1F00", Length = "0x94")]
	[CalledBy(Type = typeof(SimpleCollator), Member = "FilterExtender", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ExtenderType), typeof(CompareOptions)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "FillSortKeyRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ExtenderType), typeof(SortKeyBuffer), typeof(CompareOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "CompareInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(Boolean&), typeof(Boolean&), typeof(bool), typeof(bool), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(Byte*), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(Byte*), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "MatchesForwardCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(Byte*), typeof(bool), typeof(ExtenderType), typeof(Contraction&), typeof(Context&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "MatchesBackwardCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(int), typeof(Byte*), typeof(bool), typeof(ExtenderType), typeof(Contraction&), typeof(Context&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CodePointIndexer), Member = "ToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "Level1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000E1")]
	private byte Level1(int cp) { }

	[Address(RVA = "0x12E2DA0", Offset = "0x12E1FA0", Length = "0x18E")]
	[CalledBy(Type = typeof(SimpleCollator), Member = "GetSortKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(SortKeyBuffer), typeof(CompareOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "FillSortKeyRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ExtenderType), typeof(SortKeyBuffer), typeof(CompareOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "CompareInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(Boolean&), typeof(Boolean&), typeof(bool), typeof(bool), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(Byte*), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(Byte*), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "MatchesForwardCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(Byte*), typeof(bool), typeof(ExtenderType), typeof(Contraction&), typeof(Context&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "MatchesBackwardCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(int), typeof(Byte*), typeof(bool), typeof(ExtenderType), typeof(Contraction&), typeof(Context&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CodePointIndexer), Member = "ToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "Level2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000E2")]
	private byte Level2(int cp, ExtenderType ext) { }

	[Address(RVA = "0x12E3500", Offset = "0x12E2700", Length = "0x1DD")]
	[CalledBy(Type = typeof(SimpleCollator), Member = "LastIndexOfSortKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(int), typeof(Byte*), typeof(int), typeof(bool), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(Byte*), typeof(Context&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(SimpleCollator), Member = "GetExtenderType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ExtenderType))]
	[Calls(Type = typeof(SimpleCollator), Member = "MatchesBackwardCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(int), typeof(Byte*), typeof(bool), typeof(ExtenderType), typeof(Contraction&), typeof(Context&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600010A")]
	private bool MatchesBackward(string s, ref int idx, int end, int orgStart, int ti, Byte* sortkey, bool noLv4, ref Context ctx) { }

	[Address(RVA = "0x12E2F30", Offset = "0x12E2130", Length = "0x5C7")]
	[CalledBy(Type = typeof(SimpleCollator), Member = "MatchesBackward", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(int), typeof(Byte*), typeof(bool), typeof(Context&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SimpleCollator), Member = "FilterOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CompareOptions)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SimpleCollator), Member = "LastIndexOfSortKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(int), typeof(Byte*), typeof(int), typeof(bool), typeof(Context&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SimpleCollator), Member = "GetTailContraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(Contraction[])}, ReturnType = typeof(Contraction))]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "Level3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(SimpleCollator), Member = "Level1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(SimpleCollator), Member = "FilterExtender", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ExtenderType), typeof(CompareOptions)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SimpleCollator), Member = "Level2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ExtenderType)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(SimpleCollator), Member = "MatchesPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompareOptions), typeof(Byte*), typeof(int), typeof(ExtenderType), typeof(Byte*), typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "IsIgnorable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(byte)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SimpleCollator), Member = "Category", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600010B")]
	private bool MatchesBackwardCore(string s, ref int idx, int end, int orgStart, int ti, Byte* sortkey, bool noLv4, ExtenderType ext, ref Contraction ct, ref Context ctx) { }

	[Address(RVA = "0x12E3AB0", Offset = "0x12E2CB0", Length = "0x1D2")]
	[CalledBy(Type = typeof(SimpleCollator), Member = "IndexOfSortKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(Byte*), typeof(char), typeof(int), typeof(bool), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(Byte*), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "MatchesForwardCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(Byte*), typeof(bool), typeof(ExtenderType), typeof(Contraction&), typeof(Context&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(SimpleCollator), Member = "GetExtenderType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ExtenderType))]
	[Calls(Type = typeof(SimpleCollator), Member = "MatchesForwardCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(Byte*), typeof(bool), typeof(ExtenderType), typeof(Contraction&), typeof(Context&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000107")]
	private bool MatchesForward(string s, ref int idx, int end, int ti, Byte* sortkey, bool noLv4, ref Context ctx) { }

	[Address(RVA = "0x12E36E0", Offset = "0x12E28E0", Length = "0x3CF")]
	[CalledBy(Type = typeof(SimpleCollator), Member = "MatchesForward", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(Byte*), typeof(bool), typeof(Context&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(SimpleCollator), Member = "MatchesForward", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(Byte*), typeof(bool), typeof(Context&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "Level3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SimpleCollator), Member = "Level2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ExtenderType)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(SimpleCollator), Member = "Level1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(SimpleCollator), Member = "Category", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(SimpleCollator), Member = "MatchesPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompareOptions), typeof(Byte*), typeof(int), typeof(ExtenderType), typeof(Byte*), typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SimpleCollator), Member = "GetContraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(Contraction))]
	[Calls(Type = typeof(SimpleCollator), Member = "FilterExtender", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ExtenderType), typeof(CompareOptions)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SimpleCollator), Member = "FilterOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CompareOptions)}, ReturnType = typeof(int))]
	[Token(Token = "0x6000108")]
	private bool MatchesForwardCore(string s, ref int idx, int end, int ti, Byte* sortkey, bool noLv4, ExtenderType ext, ref Contraction ct, ref Context ctx) { }

	[Address(RVA = "0x12E3C90", Offset = "0x12E2E90", Length = "0x1CD")]
	[CalledBy(Type = typeof(SimpleCollator), Member = "MatchesForwardCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(Byte*), typeof(bool), typeof(ExtenderType), typeof(Contraction&), typeof(Context&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "MatchesBackwardCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(int), typeof(Byte*), typeof(bool), typeof(ExtenderType), typeof(Contraction&), typeof(Context&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "HasSpecialWeight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "IsJapaneseSmallLetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SimpleCollator), Member = "IsHalfKana", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CompareOptions)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000109")]
	private bool MatchesPrimitive(CompareOptions opt, Byte* source, int si, ExtenderType ext, Byte* target, int ti, bool noLv4) { }

	[Address(RVA = "0x12E3E60", Offset = "0x12E3060", Length = "0x13A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000FD")]
	private int QuickIndexOf(string s, string target, int start, int length, out bool testWasUnable) { }

	[Address(RVA = "0x12E3FA0", Offset = "0x12E31A0", Length = "0x156")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "FillCJK", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CodePointIndexer&), typeof(Byte*&), typeof(Byte*&), typeof(CodePointIndexer&), typeof(Byte*&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x60000DE")]
	private void SetCJKTable(CultureInfo culture, ref CodePointIndexer cjkIndexer, ref Byte* catTable, ref Byte* lv1Table, ref CodePointIndexer lv2Indexer, ref Byte* lv2Table) { }

	[Address(RVA = "0x12E4100", Offset = "0x12E3300", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SimpleCollator), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(CompareOptions)}, ReturnType = typeof(int))]
	[Token(Token = "0x60000F3")]
	private override int System.Globalization.ISimpleCollator.Compare(string s1, int idx1, int len1, string s2, int idx2, int len2, CompareOptions options) { }

	[Address(RVA = "0x12E4110", Offset = "0x12E3310", Length = "0x15")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000EA")]
	private static byte ToDashTypeValue(ExtenderType ext, CompareOptions opt) { }

}

