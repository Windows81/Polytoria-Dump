namespace System.Text.RegularExpressions;

[Token(Token = "0x20000E9")]
internal sealed class RegexBoyerMoore
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000391")]
	public readonly Int32[] Positive; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000392")]
	public readonly Int32[] NegativeASCII; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000393")]
	public readonly Int32[][] NegativeUnicode; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000394")]
	public readonly string Pattern; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000395")]
	public readonly int LowASCII; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000396")]
	public readonly int HighASCII; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000397")]
	public readonly bool RightToLeft; //Field offset: 0x38
	[FieldOffset(Offset = "0x39")]
	[Token(Token = "0x4000398")]
	public readonly bool CaseInsensitive; //Field offset: 0x39
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000399")]
	private readonly CultureInfo _culture; //Field offset: 0x40

	[Address(RVA = "0x1757860", Offset = "0x1756A60", Length = "0x562")]
	[CalledBy(Type = typeof(RegexWriter), Member = "RegexCodeFromRegexTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexTree)}, ReturnType = typeof(RegexCode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "System.Text.StringBuilderCache", Member = "Acquire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = "System.Text.StringBuilderCache", Member = "GetStringAndRelease", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600050B")]
	public RegexBoyerMoore(string pattern, bool caseInsensitive, bool rightToLeft, CultureInfo culture) { }

	[Address(RVA = "0x1757380", Offset = "0x1756580", Length = "0x6E")]
	[CalledBy(Type = typeof(RegexInterpreter), Member = "FindFirstChar", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x600050D")]
	public bool IsMatch(string text, int index, int beglimit, int endlimit) { }

	[Address(RVA = "0x17573F0", Offset = "0x17565F0", Length = "0x136")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600050C")]
	private bool MatchPattern(string text, int index) { }

	[Address(RVA = "0x1757530", Offset = "0x1756730", Length = "0x324")]
	[CalledBy(Type = typeof(RegexInterpreter), Member = "FindFirstChar", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600050E")]
	public int Scan(string text, int index, int beglimit, int endlimit) { }

}

