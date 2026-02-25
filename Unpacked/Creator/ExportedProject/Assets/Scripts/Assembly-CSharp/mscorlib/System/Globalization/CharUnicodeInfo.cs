namespace System.Globalization;

[Token(Token = "0x200052F")]
public static class CharUnicodeInfo
{

	[Token(Token = "0x17000544")]
	private static ReadOnlySpan<Byte> CategoriesValue
	{
		[Address(RVA = "0x13D1BF0", Offset = "0x13D0DF0", Length = "0x4C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600254F")]
		private get { } //Length: 76
	}

	[Token(Token = "0x17000541")]
	private static ReadOnlySpan<Byte> CategoryLevel1Index
	{
		[Address(RVA = "0x13D1C40", Offset = "0x13D0E40", Length = "0x4C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600254C")]
		private get { } //Length: 76
	}

	[Token(Token = "0x17000542")]
	private static ReadOnlySpan<Byte> CategoryLevel2Index
	{
		[Address(RVA = "0x13D1C90", Offset = "0x13D0E90", Length = "0x4C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600254D")]
		private get { } //Length: 76
	}

	[Token(Token = "0x17000543")]
	private static ReadOnlySpan<Byte> CategoryLevel3Index
	{
		[Address(RVA = "0x13D1CE0", Offset = "0x13D0EE0", Length = "0x4C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x600254E")]
		private get { } //Length: 76
	}

	[Address(RVA = "0x13D1BF0", Offset = "0x13D0DF0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600254F")]
	private static ReadOnlySpan<Byte> get_CategoriesValue() { }

	[Address(RVA = "0x13D1C40", Offset = "0x13D0E40", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600254C")]
	private static ReadOnlySpan<Byte> get_CategoryLevel1Index() { }

	[Address(RVA = "0x13D1C90", Offset = "0x13D0E90", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600254D")]
	private static ReadOnlySpan<Byte> get_CategoryLevel2Index() { }

	[Address(RVA = "0x13D1CE0", Offset = "0x13D0EE0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600254E")]
	private static ReadOnlySpan<Byte> get_CategoryLevel3Index() { }

	[Address(RVA = "0x13D1670", Offset = "0x13D0870", Length = "0xA")]
	[CalledBy(Type = typeof(char), Member = "IsDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(char), Member = "IsLetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(char), Member = "IsUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(char), Member = "IsLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(char), Member = "IsPunctuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(char), Member = "IsLetterOrDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(char), Member = "IsControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(char), Member = "IsNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(char), Member = "IsSeparator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Text.RegularExpressions.RegexCharClass", Member = "CharInClassInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(string), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Text.RegularExpressions.RegexCharClass", Member = "CharInCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(string), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CharUnicodeInfo), Member = "GetUnicodeCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(UnicodeCategory))]
	[Token(Token = "0x6002543")]
	public static UnicodeCategory GetUnicodeCategory(char ch) { }

	[Address(RVA = "0x13D1540", Offset = "0x13D0740", Length = "0x124")]
	[CalledBy(Type = typeof(char), Member = "IsLetterOrDigit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(char), Member = "IsNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CharUnicodeInfo), Member = "GetUnicodeCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(UnicodeCategory))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002544")]
	public static UnicodeCategory GetUnicodeCategory(string s, int index) { }

	[Address(RVA = "0x13D13E0", Offset = "0x13D05E0", Length = "0x158")]
	[CalledBy(Type = typeof(char), Member = "GetUnicodeCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(UnicodeCategory))]
	[CalledBy(Type = typeof(CharUnicodeInfo), Member = "GetUnicodeCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(UnicodeCategory))]
	[CalledBy(Type = typeof(CharUnicodeInfo), Member = "GetUnicodeCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(UnicodeCategory))]
	[CalledBy(Type = typeof(CharUnicodeInfo), Member = "InternalGetUnicodeCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(UnicodeCategory))]
	[CalledBy(Type = typeof(CharUnicodeInfo), Member = "InternalGetUnicodeCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(Int32&)}, ReturnType = typeof(UnicodeCategory))]
	[CalledBy(Type = typeof(CharUnicodeInfo), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CharUnicodeInfo), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002545")]
	public static UnicodeCategory GetUnicodeCategory(int codePoint) { }

	[Address(RVA = "0x13D1680", Offset = "0x13D0880", Length = "0x97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002541")]
	internal static int InternalConvertToUtf32(string s, int index) { }

	[Address(RVA = "0x13D1720", Offset = "0x13D0920", Length = "0x9F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002542")]
	internal static int InternalConvertToUtf32(string s, int index, out int charLength) { }

	[Address(RVA = "0x13D17C0", Offset = "0x13D09C0", Length = "0x166")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002546")]
	internal static byte InternalGetCategoryValue(int ch, int offset) { }

	[Address(RVA = "0x13D1930", Offset = "0x13D0B30", Length = "0x8F")]
	[CalledBy(Type = typeof(char), Member = "GetUnicodeCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(UnicodeCategory))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CharUnicodeInfo), Member = "GetUnicodeCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(UnicodeCategory))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002547")]
	internal static UnicodeCategory InternalGetUnicodeCategory(string value, int index) { }

	[Address(RVA = "0x13D19C0", Offset = "0x13D0BC0", Length = "0xA5")]
	[CalledBy(Type = typeof(StringInfo), Member = "GetCurrentTextElementLen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(UnicodeCategory&), typeof(Int32&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(StringInfo), Member = "ParseCombiningCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Int32[]))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CharUnicodeInfo), Member = "GetUnicodeCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(UnicodeCategory))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002548")]
	internal static UnicodeCategory InternalGetUnicodeCategory(string str, int index, out int charLength) { }

	[Address(RVA = "0x13D1A70", Offset = "0x13D0C70", Length = "0x12")]
	[CalledBy(Type = typeof(StringInfo), Member = "GetCurrentTextElementLen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(UnicodeCategory&), typeof(Int32&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(StringInfo), Member = "ParseCombiningCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Int32[]))]
	[CallerCount(Count = 6)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002549")]
	internal static bool IsCombiningCategory(UnicodeCategory uc) { }

	[Address(RVA = "0x13D1AB0", Offset = "0x13D0CB0", Length = "0x132")]
	[CalledBy(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CharUnicodeInfo), Member = "GetUnicodeCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(UnicodeCategory))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600254A")]
	internal static bool IsWhiteSpace(string s, int index) { }

	[Address(RVA = "0x13D1A90", Offset = "0x13D0C90", Length = "0x1C")]
	[CalledBy(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CharUnicodeInfo), Member = "GetUnicodeCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(UnicodeCategory))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600254B")]
	internal static bool IsWhiteSpace(char c) { }

}

