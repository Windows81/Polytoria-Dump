namespace System.Text.RegularExpressions;

[Token(Token = "0x20000EA")]
internal sealed class RegexCharClass
{
	[IsReadOnly]
	[Token(Token = "0x20000EB")]
	private struct LowerCaseMapping
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003AD")]
		public readonly char ChMin; //Field offset: 0x0
		[FieldOffset(Offset = "0x2")]
		[Token(Token = "0x40003AE")]
		public readonly char ChMax; //Field offset: 0x2
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40003AF")]
		public readonly int LcOp; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40003B0")]
		public readonly int Data; //Field offset: 0x8

		[Address(RVA = "0x17564D0", Offset = "0x17556D0", Length = "0x14")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000536")]
		internal LowerCaseMapping(char chMin, char chMax, int lcOp, int data) { }

	}

	[IsReadOnly]
	[Token(Token = "0x20000ED")]
	private struct SingleRange
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40003B2")]
		public readonly char First; //Field offset: 0x0
		[FieldOffset(Offset = "0x2")]
		[Token(Token = "0x40003B3")]
		public readonly char Last; //Field offset: 0x2

		[Address(RVA = "0x13F6840", Offset = "0x13F5A40", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600053A")]
		internal SingleRange(char first, char last) { }

	}

	[Token(Token = "0x20000EC")]
	private sealed class SingleRangeComparer : IComparer<SingleRange>
	{
		[Token(Token = "0x40003B1")]
		public static readonly SingleRangeComparer Instance; //Field offset: 0x0

		[Address(RVA = "0x1764C80", Offset = "0x1763E80", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000539")]
		private static SingleRangeComparer() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000537")]
		private SingleRangeComparer() { }

		[Address(RVA = "0x1764C40", Offset = "0x1763E40", Length = "0x37")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000538")]
		public override int Compare(SingleRange x, SingleRange y) { }

	}

	[Token(Token = "0x400039A")]
	private static readonly string s_internalRegexIgnoreCase; //Field offset: 0x0
	[Token(Token = "0x400039B")]
	private static readonly string s_space; //Field offset: 0x8
	[Token(Token = "0x400039C")]
	private static readonly string s_notSpace; //Field offset: 0x10
	[Token(Token = "0x400039D")]
	private static readonly string s_word; //Field offset: 0x18
	[Token(Token = "0x400039E")]
	private static readonly string s_notWord; //Field offset: 0x20
	[Token(Token = "0x400039F")]
	public static readonly string SpaceClass; //Field offset: 0x28
	[Token(Token = "0x40003A0")]
	public static readonly string NotSpaceClass; //Field offset: 0x30
	[Token(Token = "0x40003A1")]
	public static readonly string WordClass; //Field offset: 0x38
	[Token(Token = "0x40003A2")]
	public static readonly string NotWordClass; //Field offset: 0x40
	[Token(Token = "0x40003A3")]
	public static readonly string DigitClass; //Field offset: 0x48
	[Token(Token = "0x40003A4")]
	public static readonly string NotDigitClass; //Field offset: 0x50
	[Token(Token = "0x40003A5")]
	private static readonly Dictionary<String, String> s_definedCategories; //Field offset: 0x58
	[Token(Token = "0x40003A6")]
	private static readonly String[][] s_propTable; //Field offset: 0x60
	[Token(Token = "0x40003A7")]
	private static readonly LowerCaseMapping[] s_lcTable; //Field offset: 0x68
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003A8")]
	private List<SingleRange> _rangelist; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40003A9")]
	private StringBuilder _categories; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40003AA")]
	private bool _canonical; //Field offset: 0x20
	[FieldOffset(Offset = "0x21")]
	[Token(Token = "0x40003AB")]
	private bool _negate; //Field offset: 0x21
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40003AC")]
	private RegexCharClass _subtractor; //Field offset: 0x28

	[Token(Token = "0x170000DD")]
	public bool CanMerge
	{
		[Address(RVA = "0x175FEE0", Offset = "0x175F0E0", Length = "0x12")]
		[CalledBy(Type = typeof(RegexFC), Member = "AddFC", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexFC), typeof(bool)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000511")]
		 get { } //Length: 18
	}

	[Token(Token = "0x170000DE")]
	public bool Negate
	{
		[Address(RVA = "0x3292F0", Offset = "0x3284F0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000512")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x175A2B0", Offset = "0x17594B0", Length = "0x5AED")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000535")]
	private static RegexCharClass() { }

	[Address(RVA = "0x175FDA0", Offset = "0x175EFA0", Length = "0xB5")]
	[CalledBy(Type = typeof(RegexFC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexFC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexNode), Member = "ReduceAlternation", ReturnType = typeof(RegexNode))]
	[CalledBy(Type = typeof(RegexParser), Member = "ScanCharClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(RegexCharClass))]
	[CalledBy(Type = typeof(RegexParser), Member = "ScanBackslash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(RegexNode))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600050F")]
	public RegexCharClass() { }

	[Address(RVA = "0x175FE60", Offset = "0x175F060", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000510")]
	private RegexCharClass(bool negate, List<SingleRange> ranges, StringBuilder categories, RegexCharClass subtraction) { }

	[Address(RVA = "0x1758060", Offset = "0x1757260", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000519")]
	private void AddCategory(string category) { }

	[Address(RVA = "0x1757DD0", Offset = "0x1756FD0", Length = "0x28B")]
	[CalledBy(Type = typeof(RegexCharClass), Member = "AddDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexParser), Member = "ScanCharClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(RegexCharClass))]
	[CalledBy(Type = typeof(RegexParser), Member = "ScanBackslash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(RegexNode))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RegexCharClass), Member = "SetFromProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = "System.Text.StringBuilderCache", Member = "GetStringAndRelease", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(RegexCharClass), Member = "AddSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "System.Text.StringBuilderCache", Member = "Acquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Token(Token = "0x6000518")]
	public void AddCategoryFromName(string categoryName, bool invert, bool caseInsensitive, string pattern) { }

	[Address(RVA = "0x17582A0", Offset = "0x17574A0", Length = "0xC")]
	[CalledBy(Type = typeof(RegexNode), Member = "ReduceAlternation", ReturnType = typeof(RegexNode))]
	[CalledBy(Type = typeof(RegexParser), Member = "ScanCharClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(RegexCharClass))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RegexCharClass), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000513")]
	public void AddChar(char c) { }

	[Address(RVA = "0x1758080", Offset = "0x1757280", Length = "0x211")]
	[CalledBy(Type = typeof(RegexFC), Member = "AddFC", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexFC), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RegexNode), Member = "ReduceAlternation", ReturnType = typeof(RegexNode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RegexCharClass), Member = "GetRangeAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(SingleRange))]
	[Calls(Type = typeof(RegexCharClass), Member = "RangeCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000514")]
	public void AddCharClass(RegexCharClass cc) { }

	[Address(RVA = "0x17582B0", Offset = "0x17574B0", Length = "0xB0")]
	[CalledBy(Type = typeof(RegexParser), Member = "ScanCharClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(RegexCharClass))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RegexCharClass), Member = "AddCategoryFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RegexCharClass), Member = "AddSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600051E")]
	public void AddDigit(bool ecma, bool negate, string pattern) { }

	[Address(RVA = "0x17585C0", Offset = "0x17577C0", Length = "0x149")]
	[CalledBy(Type = typeof(RegexFC), Member = "GetFirstChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(RegexParser), Member = "ScanCharClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(RegexCharClass))]
	[CalledBy(Type = typeof(RegexParser), Member = "ScanBackslash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(RegexNode))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(RegexCharClass), Member = "AddLowercaseRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(CultureInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600051A")]
	public void AddLowercase(CultureInfo culture) { }

	[Address(RVA = "0x1758360", Offset = "0x1757560", Length = "0x258")]
	[CalledBy(Type = typeof(RegexCharClass), Member = "AddLowercase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RegexCharClass), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600051B")]
	private void AddLowercaseRange(char chMin, char chMax, CultureInfo culture) { }

	[Address(RVA = "0x1758710", Offset = "0x1757910", Length = "0x100")]
	[CalledBy(Type = typeof(RegexCharClass), Member = "AddChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexCharClass), Member = "AddLowercaseRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(CultureInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexFC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexParser), Member = "ScanCharClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(RegexCharClass))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000517")]
	public void AddRange(char first, char last) { }

	[Address(RVA = "0x1758820", Offset = "0x1757A20", Length = "0x22E")]
	[CalledBy(Type = typeof(RegexCharClass), Member = "AddCategoryFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexCharClass), Member = "AddWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexCharClass), Member = "AddSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexCharClass), Member = "AddDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(RegexCharClass), Member = "GetRangeAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(SingleRange))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000515")]
	private void AddSet(string set) { }

	[Address(RVA = "0x1758A50", Offset = "0x1757C50", Length = "0x123")]
	[CalledBy(Type = typeof(RegexParser), Member = "ScanCharClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(RegexCharClass))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(RegexCharClass), Member = "AddSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600051D")]
	public void AddSpace(bool ecma, bool negate) { }

	[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000516")]
	public void AddSubtraction(RegexCharClass sub) { }

	[Address(RVA = "0x1758B80", Offset = "0x1757D80", Length = "0x123")]
	[CalledBy(Type = typeof(RegexParser), Member = "ScanCharClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(RegexCharClass))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(RegexCharClass), Member = "AddSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600051C")]
	public void AddWord(bool ecma, bool negate) { }

	[Address(RVA = "0x1758CB0", Offset = "0x1757EB0", Length = "0x22C")]
	[CalledBy(Type = typeof(RegexCharClass), Member = "ToStringClass", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Text.RegularExpressions.RegexCharClass+SingleRange>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IComparer`1<System.Text.RegularExpressions.RegexCharClass+SingleRange>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(List`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "RemoveRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000533")]
	private void Canonicalize() { }

	[Address(RVA = "0x1758FB0", Offset = "0x17581B0", Length = "0x154")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CharUnicodeInfo), Member = "GetUnicodeCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(UnicodeCategory))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RegexCharClass), Member = "CharInCategoryGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(UnicodeCategory), typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600052B")]
	private static bool CharInCategory(char ch, string set, int start, int mySetLength, int myCategoryLength) { }

	[Address(RVA = "0x1758EE0", Offset = "0x17580E0", Length = "0xCD")]
	[CalledBy(Type = typeof(RegexCharClass), Member = "CharInClassInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(string), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RegexCharClass), Member = "CharInCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(string), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600052C")]
	private static bool CharInCategoryGroup(char ch, UnicodeCategory chcategory, string category, ref int i) { }

	[Address(RVA = "0x1759440", Offset = "0x1758640", Length = "0x5C")]
	[CalledBy(Type = typeof(RegexInterpreter), Member = "FindFirstChar", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RegexInterpreter), Member = "Go", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RegexCharClass), Member = "CharInClassRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(string), typeof(int)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000528")]
	public static bool CharInClass(char ch, string set) { }

	[Address(RVA = "0x1759110", Offset = "0x1758310", Length = "0x1FA")]
	[CalledBy(Type = typeof(RegexCharClass), Member = "CharInClassRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(string), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CharUnicodeInfo), Member = "GetUnicodeCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(UnicodeCategory))]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RegexCharClass), Member = "CharInCategoryGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(UnicodeCategory), typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600052A")]
	private static bool CharInClassInternal(char ch, string set, int start, int mySetLength, int myCategoryLength) { }

	[Address(RVA = "0x1759310", Offset = "0x1758510", Length = "0x12C")]
	[CalledBy(Type = typeof(RegexCharClass), Member = "IsECMAWordChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RegexCharClass), Member = "IsWordChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RegexCharClass), Member = "CharInClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RegexCharClass), Member = "CharInClassRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(string), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RegexCharClass), Member = "CharInClassRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(string), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RegexCharClass), Member = "CharInClassInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(string), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000529")]
	private static bool CharInClassRecursive(char ch, string set, int start) { }

	[Address(RVA = "0x175FEE0", Offset = "0x175F0E0", Length = "0x12")]
	[CalledBy(Type = typeof(RegexFC), Member = "AddFC", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexFC), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000511")]
	public bool get_CanMerge() { }

	[Address(RVA = "0x17594A0", Offset = "0x17586A0", Length = "0x51")]
	[CalledBy(Type = typeof(RegexCharClass), Member = "AddCharClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexCharClass)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexCharClass), Member = "AddSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000532")]
	private SingleRange GetRangeAt(int i) { }

	[Address(RVA = "0x1759500", Offset = "0x1758700", Length = "0x9D")]
	[CalledBy(Type = typeof(RegexRunner), Member = "IsECMABoundary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RegexCharClass), Member = "CharInClassRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(string), typeof(int)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000526")]
	public static bool IsECMAWordChar(char ch) { }

	[Address(RVA = "0x17595A0", Offset = "0x17587A0", Length = "0xDD")]
	[CalledBy(Type = typeof(RegexNode), Member = "Reduce", ReturnType = typeof(RegexNode))]
	[CalledBy(Type = typeof(RegexNode), Member = "ReduceSet", ReturnType = typeof(RegexNode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000521")]
	public static bool IsEmpty(string charClass) { }

	[Address(RVA = "0x1759680", Offset = "0x1758880", Length = "0xC6")]
	[CalledBy(Type = typeof(RegexNode), Member = "ReduceAlternation", ReturnType = typeof(RegexNode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000520")]
	public static bool IsMergeable(string charClass) { }

	[Address(RVA = "0x1759750", Offset = "0x1758950", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000525")]
	private static bool IsNegated(string set) { }

	[Address(RVA = "0x17598C0", Offset = "0x1758AC0", Length = "0x13E")]
	[CalledBy(Type = typeof(RegexInterpreter), Member = "FindFirstChar", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RegexNode), Member = "Reduce", ReturnType = typeof(RegexNode))]
	[CalledBy(Type = typeof(RegexNode), Member = "ReduceSet", ReturnType = typeof(RegexNode))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000522")]
	public static bool IsSingleton(string set) { }

	[Address(RVA = "0x1759780", Offset = "0x1758980", Length = "0x13F")]
	[CalledBy(Type = typeof(RegexNode), Member = "Reduce", ReturnType = typeof(RegexNode))]
	[CalledBy(Type = typeof(RegexNode), Member = "ReduceSet", ReturnType = typeof(RegexNode))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000523")]
	public static bool IsSingletonInverse(string set) { }

	[Address(RVA = "0x1759A00", Offset = "0x1758C00", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000524")]
	private static bool IsSubtraction(string charClass) { }

	[Address(RVA = "0x1759A60", Offset = "0x1758C60", Length = "0xC3")]
	[CalledBy(Type = typeof(RegexParser), Member = "ScanGroupOpen", ReturnType = typeof(RegexNode))]
	[CalledBy(Type = typeof(RegexParser), Member = "ScanBasicBackslash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(RegexNode))]
	[CalledBy(Type = typeof(RegexParser), Member = "ScanDollar", ReturnType = typeof(RegexNode))]
	[CalledBy(Type = typeof(RegexParser), Member = "ScanCapname", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(RegexParser), Member = "ParseProperty", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(RegexParser), Member = "CountCaptures", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexRunner), Member = "IsBoundary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RegexCharClass), Member = "CharInClassRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(string), typeof(int)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000527")]
	public static bool IsWordChar(char ch) { }

	[Address(RVA = "0x1759B30", Offset = "0x1758D30", Length = "0x82")]
	[CallerCount(Count = 0)]
	[Calls(Type = "System.Text.StringBuilderCache", Member = "Acquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = "System.Text.StringBuilderCache", Member = "GetStringAndRelease", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600052D")]
	private static string NegateCategory(string category) { }

	[Address(RVA = "0x1759E00", Offset = "0x1759000", Length = "0x4C")]
	[CalledBy(Type = typeof(RegexFC), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexNode), Member = "ReduceAlternation", ReturnType = typeof(RegexNode))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RegexCharClass), Member = "ParseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(RegexCharClass))]
	[Token(Token = "0x600052E")]
	public static RegexCharClass Parse(string charClass) { }

	[Address(RVA = "0x1759BC0", Offset = "0x1758DC0", Length = "0x23F")]
	[CalledBy(Type = typeof(RegexCharClass), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(RegexCharClass))]
	[CalledBy(Type = typeof(RegexCharClass), Member = "ParseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(RegexCharClass))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800CF040")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RegexCharClass), Member = "ParseRecursive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(RegexCharClass))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600052F")]
	private static RegexCharClass ParseRecursive(string charClass, int start) { }

	[Address(RVA = "0x1759E50", Offset = "0x1759050", Length = "0x3C")]
	[CalledBy(Type = typeof(RegexCharClass), Member = "AddCharClass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexCharClass)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000530")]
	private int RangeCount() { }

	[Address(RVA = "0x3292F0", Offset = "0x3284F0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000512")]
	public void set_Negate(bool value) { }

	[Address(RVA = "0x1759E90", Offset = "0x1759090", Length = "0x243")]
	[CalledBy(Type = typeof(RegexCharClass), Member = "AddCategoryFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000534")]
	private static string SetFromProperty(string capname, bool invert, string pattern) { }

	[Address(RVA = "0x175A0E0", Offset = "0x17592E0", Length = "0x1F")]
	[CalledBy(Type = typeof(RegexInterpreter), Member = "FindFirstChar", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RegexNode), Member = "Reduce", ReturnType = typeof(RegexNode))]
	[CalledBy(Type = typeof(RegexNode), Member = "ReduceSet", ReturnType = typeof(RegexNode))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600051F")]
	public static char SingletonChar(string set) { }

	[Address(RVA = "0x175A100", Offset = "0x1759300", Length = "0x1AF")]
	[CalledBy(Type = typeof(RegexCharClass), Member = "ToStringClass", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(RegexFC), Member = "GetFirstChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(RegexNode), Member = "ReduceAlternation", ReturnType = typeof(RegexNode))]
	[CalledBy(Type = typeof(RegexParser), Member = "ScanRegex", ReturnType = typeof(RegexNode))]
	[CalledBy(Type = typeof(RegexParser), Member = "ScanBackslash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(RegexNode))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(RegexCharClass), Member = "Canonicalize", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RegexCharClass), Member = "ToStringClass", ReturnType = typeof(string))]
	[Calls(Type = "System.Text.StringBuilderCache", Member = "GetStringAndRelease", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(string))]
	[Calls(Type = "System.Text.StringBuilderCache", Member = "Acquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000531")]
	public string ToStringClass() { }

}

