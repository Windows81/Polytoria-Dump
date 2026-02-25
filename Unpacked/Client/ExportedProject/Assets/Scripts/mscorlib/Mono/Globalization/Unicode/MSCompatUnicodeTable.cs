namespace Mono.Globalization.Unicode;

[Token(Token = "0x2000054")]
internal class MSCompatUnicodeTable
{
	[CompilerGenerated]
	[Token(Token = "0x2000055")]
	private sealed class <>c
	{
		[Token(Token = "0x4000179")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400017A")]
		public static Comparison<Level2Map> <>9__17_0; //Field offset: 0x8

		[Address(RVA = "0x12E7FE0", Offset = "0x12E71E0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60000D6")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000D7")]
		public <>c() { }

		[Address(RVA = "0x12E7FB0", Offset = "0x12E71B0", Length = "0x23")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60000D8")]
		internal int <BuildTailoringTables>b__17_0(Level2Map a, Level2Map b) { }

	}

	[Token(Token = "0x4000166")]
	public static int MaxExpansionLength; //Field offset: 0x0
	[Token(Token = "0x4000167")]
	private static readonly Byte* ignorableFlags; //Field offset: 0x8
	[Token(Token = "0x4000168")]
	private static readonly Byte* categories; //Field offset: 0x10
	[Token(Token = "0x4000169")]
	private static readonly Byte* level1; //Field offset: 0x18
	[Token(Token = "0x400016A")]
	private static readonly Byte* level2; //Field offset: 0x20
	[Token(Token = "0x400016B")]
	private static readonly Byte* level3; //Field offset: 0x28
	[Token(Token = "0x400016C")]
	private static Byte* cjkCHScategory; //Field offset: 0x30
	[Token(Token = "0x400016D")]
	private static Byte* cjkCHTcategory; //Field offset: 0x38
	[Token(Token = "0x400016E")]
	private static Byte* cjkJAcategory; //Field offset: 0x40
	[Token(Token = "0x400016F")]
	private static Byte* cjkKOcategory; //Field offset: 0x48
	[Token(Token = "0x4000170")]
	private static Byte* cjkCHSlv1; //Field offset: 0x50
	[Token(Token = "0x4000171")]
	private static Byte* cjkCHTlv1; //Field offset: 0x58
	[Token(Token = "0x4000172")]
	private static Byte* cjkJAlv1; //Field offset: 0x60
	[Token(Token = "0x4000173")]
	private static Byte* cjkKOlv1; //Field offset: 0x68
	[Token(Token = "0x4000174")]
	private static Byte* cjkKOlv2; //Field offset: 0x70
	[Token(Token = "0x4000175")]
	private static readonly Char[] tailoringArr; //Field offset: 0x78
	[Token(Token = "0x4000176")]
	private static readonly TailoringInfo[] tailoringInfos; //Field offset: 0x80
	[Token(Token = "0x4000177")]
	private static object forLock; //Field offset: 0x88
	[Token(Token = "0x4000178")]
	public static readonly bool isReady; //Field offset: 0x90

	[Token(Token = "0x17000016")]
	public static bool IsReady
	{
		[Address(RVA = "0x12DCC60", Offset = "0x12DBE60", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60000D0")]
		 get { } //Length: 82
	}

	[Address(RVA = "0x12DC680", Offset = "0x12DB880", Length = "0x5D6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "GetResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000D3")]
	private static MSCompatUnicodeTable() { }

	[Address(RVA = "0x12DAC00", Offset = "0x12D9E00", Length = "0x6B8")]
	[CalledBy(Type = typeof(SimpleCollator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Comparison`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Comparison`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IComparer`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(Contraction), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Char[]), typeof(string), typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char*), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Marshal), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x60000C2")]
	public static void BuildTailoringTables(CultureInfo culture, TailoringInfo t, ref Contraction[] contractions, ref Level2Map[] diacriticals) { }

	[Address(RVA = "0x12DB2C0", Offset = "0x12DA4C0", Length = "0xAE")]
	[CalledBy(Type = typeof(SimpleCollator), Member = "Category", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CodePointIndexer), Member = "ToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000C4")]
	public static byte Category(int cp) { }

	[Address(RVA = "0x12DB8E0", Offset = "0x12DAAE0", Length = "0x167")]
	[CalledBy(Type = typeof(SimpleCollator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "SetCJKTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo), typeof(CodePointIndexer&), typeof(Byte*&), typeof(Byte*&), typeof(CodePointIndexer&), typeof(Byte*&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "FillCJKCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CodePointIndexer&), typeof(Byte*&), typeof(Byte*&), typeof(CodePointIndexer&), typeof(Byte*&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "SetCJKReferences", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CodePointIndexer&), typeof(Byte*&), typeof(Byte*&), typeof(CodePointIndexer&), typeof(Byte*&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x60000D4")]
	public static void FillCJK(string culture, ref CodePointIndexer cjkIndexer, ref Byte* catTable, ref Byte* lv1Table, ref CodePointIndexer lv2Indexer, ref Byte* lv2Table) { }

	[Address(RVA = "0x12DB370", Offset = "0x12DA570", Length = "0x566")]
	[CalledBy(Type = typeof(MSCompatUnicodeTable), Member = "FillCJK", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CodePointIndexer&), typeof(Byte*&), typeof(Byte*&), typeof(CodePointIndexer&), typeof(Byte*&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(MSCompatUnicodeTable), Member = "GetResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 10)]
	[Token(Token = "0x60000D5")]
	private static void FillCJKCore(string culture, ref CodePointIndexer cjkIndexer, ref Byte* catTable, ref Byte* lv1Table, ref CodePointIndexer cjkLv2Indexer, ref Byte* lv2Table) { }

	[Address(RVA = "0x12DCC60", Offset = "0x12DBE60", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60000D0")]
	public static bool get_IsReady() { }

	[Address(RVA = "0x12DBA50", Offset = "0x12DAC50", Length = "0xB1")]
	[CalledBy(Type = typeof(MSCompatUnicodeTable), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MSCompatUnicodeTable), Member = "FillCJKCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CodePointIndexer&), typeof(Byte*&), typeof(Byte*&), typeof(CodePointIndexer&), typeof(Byte*&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE440")]
	[Calls(Type = typeof(RuntimeAssembly), Member = "GetManifestResourceInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(Module&)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x60000D1")]
	private static IntPtr GetResource(string name) { }

	[Address(RVA = "0x12DBB10", Offset = "0x12DAD10", Length = "0x11A")]
	[CalledBy(Type = typeof(SimpleCollator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60000C1")]
	public static TailoringInfo GetTailoringInfo(int lcid) { }

	[Address(RVA = "0x12DBC30", Offset = "0x12DAE30", Length = "0x67")]
	[CalledBy(Type = typeof(SimpleCollator), Member = "FillSortKeyRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "Mono.Globalization.Unicode.SimpleCollator+ExtenderType", typeof(SortKeyBuffer), typeof(CompareOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "CompareInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(Boolean&), typeof(Boolean&), typeof(bool), typeof(bool), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(Byte*), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(Byte*), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "MatchesPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompareOptions), typeof(Byte*), typeof(int), "Mono.Globalization.Unicode.SimpleCollator+ExtenderType", typeof(Byte*), typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000CC")]
	public static bool HasSpecialWeight(char c) { }

	[Address(RVA = "0x12DBCA0", Offset = "0x12DAEA0", Length = "0x19")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000CD")]
	public static bool IsHalfWidthKana(char c) { }

	[Address(RVA = "0x12DBCC0", Offset = "0x12DAEC0", Length = "0x19")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000CE")]
	public static bool IsHiragana(char c) { }

	[Address(RVA = "0x12DBD30", Offset = "0x12DAF30", Length = "0x118")]
	[CalledBy(Type = typeof(SimpleCollator), Member = "IsIgnorable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CompareOptions)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "MatchesBackwardCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(int), typeof(Byte*), typeof(bool), "Mono.Globalization.Unicode.SimpleCollator+ExtenderType", typeof(Contraction&), typeof(Context&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "GetUnicodeCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(UnicodeCategory))]
	[Calls(Type = typeof(CodePointIndexer), Member = "ToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000C8")]
	public static bool IsIgnorable(int cp, byte flag) { }

	[Address(RVA = "0x12DBCE0", Offset = "0x12DAEE0", Length = "0x4A")]
	[CalledBy(Type = typeof(SimpleCollator), Member = "GetSortKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(SortKeyBuffer), typeof(CompareOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "CompareInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(Boolean&), typeof(Boolean&), typeof(bool), typeof(bool), typeof(Context&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60000C9")]
	public static bool IsIgnorableNonSpacing(int cp) { }

	[Address(RVA = "0x12DBE50", Offset = "0x12DB050", Length = "0x120")]
	[CalledBy(Type = typeof(SimpleCollator), Member = "FillSortKeyRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "Mono.Globalization.Unicode.SimpleCollator+ExtenderType", typeof(SortKeyBuffer), typeof(CompareOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "CompareInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(Boolean&), typeof(Boolean&), typeof(bool), typeof(bool), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "MatchesPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CompareOptions), typeof(Byte*), typeof(int), "Mono.Globalization.Unicode.SimpleCollator+ExtenderType", typeof(Byte*), typeof(int), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60000CF")]
	public static bool IsJapaneseSmallLetter(char c) { }

	[Address(RVA = "0x12DBFC0", Offset = "0x12DB1C0", Length = "0xAE")]
	[CalledBy(Type = typeof(SimpleCollator), Member = "Level1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CodePointIndexer), Member = "ToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000C5")]
	public static byte Level1(int cp) { }

	[Address(RVA = "0x12DC070", Offset = "0x12DB270", Length = "0xAE")]
	[CalledBy(Type = typeof(SimpleCollator), Member = "Level2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "Mono.Globalization.Unicode.SimpleCollator+ExtenderType"}, ReturnType = typeof(byte))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CodePointIndexer), Member = "ToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000C6")]
	public static byte Level2(int cp) { }

	[Address(RVA = "0x12DC120", Offset = "0x12DB320", Length = "0xAE")]
	[CalledBy(Type = typeof(SimpleCollator), Member = "GetSortKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(SortKeyBuffer), typeof(CompareOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "FillSortKeyRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "Mono.Globalization.Unicode.SimpleCollator+ExtenderType", typeof(SortKeyBuffer), typeof(CompareOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "CompareInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(string), typeof(int), typeof(int), typeof(Boolean&), typeof(Boolean&), typeof(bool), typeof(bool), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(Byte*), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(Byte*), typeof(Context&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "MatchesForwardCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(Byte*), typeof(bool), "Mono.Globalization.Unicode.SimpleCollator+ExtenderType", typeof(Contraction&), typeof(Context&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "MatchesBackwardCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&), typeof(int), typeof(int), typeof(int), typeof(Byte*), typeof(bool), "Mono.Globalization.Unicode.SimpleCollator+ExtenderType", typeof(Contraction&), typeof(Context&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CodePointIndexer), Member = "ToIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000C7")]
	public static byte Level3(int cp) { }

	[Address(RVA = "0x12DC1D0", Offset = "0x12DB3D0", Length = "0x2CD")]
	[CalledBy(Type = typeof(MSCompatUnicodeTable), Member = "FillCJK", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CodePointIndexer&), typeof(Byte*&), typeof(Byte*&), typeof(CodePointIndexer&), typeof(Byte*&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x60000C3")]
	private static void SetCJKReferences(string name, ref CodePointIndexer cjkIndexer, ref Byte* catTable, ref Byte* lv1Table, ref CodePointIndexer lv2Indexer, ref Byte* lv2Table) { }

	[Address(RVA = "0x12DC4A0", Offset = "0x12DB6A0", Length = "0x12")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60000CA")]
	public static int ToKanaTypeInsensitive(int i) { }

	[Address(RVA = "0x12DC4C0", Offset = "0x12DB6C0", Length = "0x164")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000CB")]
	public static int ToWidthCompat(int i) { }

	[Address(RVA = "0x12DC640", Offset = "0x12DB840", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60000D2")]
	private static uint UInt32FromBytePtr(Byte* raw, uint idx) { }

}

