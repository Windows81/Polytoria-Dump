namespace System.Globalization;

[Token(Token = "0x2000540")]
internal class HebrewNumber
{
	[Token(Token = "0x2000541")]
	private enum HebrewToken
	{
		Invalid = -1,
		Digit400 = 0,
		Digit200_300 = 1,
		Digit100 = 2,
		Digit10 = 3,
		Digit1 = 4,
		Digit6_7 = 5,
		Digit7 = 6,
		Digit9 = 7,
		SingleQuote = 8,
		DoubleQuote = 9,
	}

	[Token(Token = "0x2000542")]
	private struct HebrewValue
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40015C2")]
		internal HebrewToken token; //Field offset: 0x0
		[FieldOffset(Offset = "0x2")]
		[Token(Token = "0x40015C3")]
		internal short value; //Field offset: 0x2

		[Address(RVA = "0x13F6840", Offset = "0x13F5A40", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600260F")]
		internal HebrewValue(HebrewToken token, short value) { }

	}

	[Token(Token = "0x2000543")]
	public enum HS
	{
		_err = -1,
		Start = 0,
		S400 = 1,
		S400_400 = 2,
		S400_X00 = 3,
		S400_X0 = 4,
		X00_DQ = 5,
		S400_X00_X0 = 6,
		X0_DQ = 7,
		X = 8,
		X0 = 9,
		X00 = 10,
		S400_DQ = 11,
		S400_400_DQ = 12,
		S400_400_100 = 13,
		S9 = 14,
		X00_S9 = 15,
		S9_DQ = 16,
		END = 100,
	}

	[Token(Token = "0x40015B3")]
	private static readonly HebrewValue[] s_hebrewValues; //Field offset: 0x0
	[Token(Token = "0x40015B4")]
	private static char s_maxHebrewNumberCh; //Field offset: 0x8
	[Token(Token = "0x40015B5")]
	private static readonly HS[] s_numberPasingState; //Field offset: 0x10

	[Address(RVA = "0x13F6470", Offset = "0x13F5670", Length = "0x3C0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600260E")]
	private static HebrewNumber() { }

	[Address(RVA = "0x13F5F50", Offset = "0x13F5150", Length = "0xBD")]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "TryParseHebrewNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(Boolean&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "Tokenize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenType), typeof(TokenType&), typeof(Int32&), typeof(__DTString&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600260D")]
	internal static bool IsDigit(char ch) { }

	[Address(RVA = "0x13F6010", Offset = "0x13F5210", Length = "0x1AB")]
	[CalledBy(Type = typeof(DateTimeParse), Member = "MatchHebrewDigits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(int), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "TryParseHebrewNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(__DTString&), typeof(Boolean&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "Tokenize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TokenType), typeof(TokenType&), typeof(Int32&), typeof(__DTString&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600260C")]
	internal static HebrewNumberParsingState ParseByChar(char ch, ref HebrewNumberParsingContext context) { }

	[Address(RVA = "0x13F61C0", Offset = "0x13F53C0", Length = "0x27C")]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "HebrewFormatDigits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DateTimeFormat), Member = "FormatCustomized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(System.ReadOnlySpan`1<System.Char>), typeof(DateTimeFormatInfo), typeof(TimeSpan), typeof(StringBuilder)}, ReturnType = typeof(StringBuilder))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600260B")]
	internal static string ToString(int Number) { }

}

