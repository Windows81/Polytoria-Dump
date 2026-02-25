namespace System.Globalization;

[Token(Token = "0x200053A")]
internal class DateTimeFormatInfoScanner
{
	[Token(Token = "0x200053B")]
	private enum FoundDatePattern
	{
		None = 0,
		FoundYearPatternFlag = 1,
		FoundMonthPatternFlag = 2,
		FoundDayPatternFlag = 4,
		FoundYMDPatternFlag = 7,
	}

	[Token(Token = "0x4001596")]
	private static Dictionary<String, String> s_knownWords; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001595")]
	internal List<String> m_dateWords; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001597")]
	private FoundDatePattern _ymdFlags; //Field offset: 0x18

	[Token(Token = "0x1700057F")]
	private static Dictionary<String, String> KnownWords
	{
		[Address(RVA = "0x13F1F40", Offset = "0x13F1140", Length = "0x410")]
		[CalledBy(Type = typeof(DateTimeFormatInfoScanner), Member = "AddDateWordOrPostfix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60025F9")]
		private get { } //Length: 1040
	}

	[Address(RVA = "0x13F1EC0", Offset = "0x13F10C0", Length = "0x77")]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "PopulateSpecialTokenHashTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002608")]
	public DateTimeFormatInfoScanner() { }

	[Address(RVA = "0x13F0DA0", Offset = "0x13EFFA0", Length = "0x220")]
	[CalledBy(Type = typeof(DateTimeFormatInfoScanner), Member = "AddDateWords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(string)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeFormatInfoScanner), Member = "get_KnownWords", ReturnType = typeof(System.Collections.Generic.Dictionary`2<System.String, System.String>))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(DateTimeFormatInfoScanner), Member = "AddIgnorableSymbols", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60025FB")]
	internal void AddDateWordOrPostfix(string formatPostfix, string str) { }

	[Address(RVA = "0x13F0FD0", Offset = "0x13F01D0", Length = "0x202")]
	[CalledBy(Type = typeof(DateTimeFormatInfoScanner), Member = "ScanDateWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "IsLetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(DateTimeFormatInfoScanner), Member = "AddDateWordOrPostfix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60025FC")]
	internal int AddDateWords(string pattern, int index, string formatPostfix) { }

	[Address(RVA = "0x13F11E0", Offset = "0x13F03E0", Length = "0xF4")]
	[CalledBy(Type = typeof(DateTimeFormatInfoScanner), Member = "AddDateWordOrPostfix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormatInfoScanner), Member = "ScanDateWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60025FE")]
	internal void AddIgnorableSymbols(string text) { }

	[Address(RVA = "0x13F12E0", Offset = "0x13F04E0", Length = "0x248")]
	[CalledBy(Type = typeof(DateTimeFormatInfoScanner), Member = "GetFormatFlagUseSpaceInMonthNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(String[]), typeof(String[]), typeof(String[])}, ReturnType = typeof(FORMATFLAGS))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6002607")]
	private static bool ArrayElementsBeginWithDigit(String[] array) { }

	[Address(RVA = "0x13F1530", Offset = "0x13F0730", Length = "0xB8")]
	[CalledBy(Type = typeof(DateTimeFormatInfoScanner), Member = "GetFormatFlagUseSpaceInMonthNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(String[]), typeof(String[]), typeof(String[])}, ReturnType = typeof(FORMATFLAGS))]
	[CalledBy(Type = typeof(DateTimeFormatInfoScanner), Member = "GetFormatFlagUseSpaceInDayNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(String[])}, ReturnType = typeof(FORMATFLAGS))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6002606")]
	private static bool ArrayElementsHaveSpace(String[] array) { }

	[Address(RVA = "0x13F15F0", Offset = "0x13F07F0", Length = "0xA1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002605")]
	private static bool EqualStringArrays(String[] array1, String[] array2) { }

	[Address(RVA = "0x13F1F40", Offset = "0x13F1140", Length = "0x410")]
	[CalledBy(Type = typeof(DateTimeFormatInfoScanner), Member = "AddDateWordOrPostfix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60025F9")]
	private static Dictionary<String, String> get_KnownWords() { }

	[Address(RVA = "0x13F16A0", Offset = "0x13F08A0", Length = "0x2A9")]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "PopulateSpecialTokenHashTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenHashValue[]), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "GetAllDateTimePatterns", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(DateTimeFormatInfoScanner), Member = "ScanDateWord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTimeFormatInfo), Member = "get_MonthDayPattern", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002600")]
	internal String[] GetDateWordsOfDTFI(DateTimeFormatInfo dtfi) { }

	[Address(RVA = "0x13F1950", Offset = "0x13F0B50", Length = "0x124")]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002601")]
	internal static FORMATFLAGS GetFormatFlagGenitiveMonth(String[] monthNames, String[] genitveMonthNames, String[] abbrevMonthNames, String[] genetiveAbbrevMonthNames) { }

	[Address(RVA = "0x13F1A80", Offset = "0x13F0C80", Length = "0xE")]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6002604")]
	internal static FORMATFLAGS GetFormatFlagUseHebrewCalendar(int calID) { }

	[Address(RVA = "0x13F1A90", Offset = "0x13F0C90", Length = "0x36")]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTimeFormatInfoScanner), Member = "ArrayElementsHaveSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002603")]
	internal static FORMATFLAGS GetFormatFlagUseSpaceInDayNames(String[] dayNames, String[] abbrevDayNames) { }

	[Address(RVA = "0x13F1AD0", Offset = "0x13F0CD0", Length = "0xBC")]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "InitializeFormatFlags", ReturnType = typeof(DateTimeFormatFlags))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DateTimeFormatInfoScanner), Member = "ArrayElementsBeginWithDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTimeFormatInfoScanner), Member = "ArrayElementsHaveSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(bool))]
	[Token(Token = "0x6002602")]
	internal static FORMATFLAGS GetFormatFlagUseSpaceInMonthNames(String[] monthNames, String[] genitveMonthNames, String[] abbrevMonthNames, String[] genetiveAbbrevMonthNames) { }

	[Address(RVA = "0x13F1B90", Offset = "0x13F0D90", Length = "0x20C")]
	[CalledBy(Type = typeof(DateTimeFormatInfoScanner), Member = "GetDateWordsOfDTFI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeFormatInfo)}, ReturnType = typeof(String[]))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(DateTimeFormatInfoScanner), Member = "AddDateWords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DateTimeFormatInfoScanner), Member = "AddIgnorableSymbols", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60025FF")]
	internal void ScanDateWord(string pattern) { }

	[Address(RVA = "0x13F1DA0", Offset = "0x13F0FA0", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60025FD")]
	internal static int ScanRepeatChar(string pattern, char ch, int index, out int count) { }

	[Address(RVA = "0x13F1E10", Offset = "0x13F1010", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "IsLetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60025FA")]
	internal static int SkipWhiteSpacesAndNonLetter(string pattern, int currentIndex) { }

}

