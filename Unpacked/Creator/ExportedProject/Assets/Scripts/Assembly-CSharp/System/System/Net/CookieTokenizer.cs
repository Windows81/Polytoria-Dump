namespace System.Net;

[Token(Token = "0x200025D")]
internal class CookieTokenizer
{
	[Token(Token = "0x200025E")]
	private struct RecognizedAttribute
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009E3")]
		private string m_name; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40009E4")]
		private CookieToken m_token; //Field offset: 0x8

		[Token(Token = "0x17000319")]
		internal CookieToken Token
		{
			[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
			[CallerCount(Count = 5)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000F2F")]
			internal get { } //Length: 4
		}

		[Address(RVA = "0xC89AC0", Offset = "0xC88CC0", Length = "0x26")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F2E")]
		internal RecognizedAttribute(string name, CookieToken token) { }

		[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F2F")]
		internal CookieToken get_Token() { }

		[Address(RVA = "0x17DF7A0", Offset = "0x17DE9A0", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000F30")]
		internal bool IsEqualTo(string value) { }

	}

	[Token(Token = "0x40009E1")]
	private static RecognizedAttribute[] RecognizedAttributes; //Field offset: 0x0
	[Token(Token = "0x40009E2")]
	private static RecognizedAttribute[] RecognizedServerAttributes; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40009D7")]
	private bool m_eofCookie; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40009D8")]
	private int m_index; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40009D9")]
	private int m_length; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40009DA")]
	private string m_name; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40009DB")]
	private bool m_quoted; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40009DC")]
	private int m_start; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40009DD")]
	private CookieToken m_token; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40009DE")]
	private int m_tokenLength; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40009DF")]
	private string m_tokenStream; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40009E0")]
	private string m_value; //Field offset: 0x40

	[Token(Token = "0x17000313")]
	internal bool EndOfCookie
	{
		[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F1D")]
		internal get { } //Length: 5
		[Address(RVA = "0x2FE920", Offset = "0x2FDB20", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F1E")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000314")]
	internal bool Eof
	{
		[Address(RVA = "0x17D06F0", Offset = "0x17CF8F0", Length = "0xA")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000F1F")]
		internal get { } //Length: 10
	}

	[Token(Token = "0x17000315")]
	internal string Name
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F20")]
		internal get { } //Length: 5
		[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F21")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x17000316")]
	internal bool Quoted
	{
		[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F22")]
		internal get { } //Length: 5
		[Address(RVA = "0x309690", Offset = "0x308890", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F23")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000317")]
	internal CookieToken Token
	{
		[Address(RVA = "0x2F5B20", Offset = "0x2F4D20", Length = "0xAE")]
		[CallerCount(Count = 23)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F24")]
		internal get { } //Length: 174
		[Address(RVA = "0x388900", Offset = "0x387B00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F25")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000318")]
	internal string Value
	{
		[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F26")]
		internal get { } //Length: 5
		[Address(RVA = "0x309660", Offset = "0x308860", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000F27")]
		internal set { } //Length: 13
	}

	[Address(RVA = "0x17D00F0", Offset = "0x17CF2F0", Length = "0x5A8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000F2D")]
	private static CookieTokenizer() { }

	[Address(RVA = "0x17D06A0", Offset = "0x17CF8A0", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000F1C")]
	internal CookieTokenizer(string tokenStream) { }

	[Address(RVA = "0x17CF980", Offset = "0x17CEB80", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000F28")]
	internal string Extract() { }

	[Address(RVA = "0x17CF9E0", Offset = "0x17CEBE0", Length = "0x249")]
	[CalledBy(Type = typeof(CookieTokenizer), Member = "Next", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(CookieToken))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000F29")]
	internal CookieToken FindNext(bool ignoreComma, bool ignoreEquals) { }

	[Address(RVA = "0x2FE8D0", Offset = "0x2FDAD0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F1D")]
	internal bool get_EndOfCookie() { }

	[Address(RVA = "0x17D06F0", Offset = "0x17CF8F0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000F1F")]
	internal bool get_Eof() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F20")]
	internal string get_Name() { }

	[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F22")]
	internal bool get_Quoted() { }

	[Address(RVA = "0x2F5B20", Offset = "0x2F4D20", Length = "0xAE")]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F24")]
	internal CookieToken get_Token() { }

	[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F26")]
	internal string get_Value() { }

	[Address(RVA = "0x17CFC30", Offset = "0x17CEE30", Length = "0x256")]
	[CalledBy(Type = typeof(CookieParser), Member = "Get", ReturnType = typeof(Cookie))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CookieTokenizer), Member = "FindNext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(CookieToken))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(CookieTokenizer), Member = "TokenFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(CookieToken))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000F2A")]
	internal CookieToken Next(bool first, bool parseResponseCookies) { }

	[Address(RVA = "0x17CFE90", Offset = "0x17CF090", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000F2B")]
	internal void Reset() { }

	[Address(RVA = "0x2FE920", Offset = "0x2FDB20", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F1E")]
	internal void set_EndOfCookie(bool value) { }

	[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F21")]
	internal void set_Name(string value) { }

	[Address(RVA = "0x309690", Offset = "0x308890", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F23")]
	internal void set_Quoted(bool value) { }

	[Address(RVA = "0x388900", Offset = "0x387B00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F25")]
	internal void set_Token(CookieToken value) { }

	[Address(RVA = "0x309660", Offset = "0x308860", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000F27")]
	internal void set_Value(string value) { }

	[Address(RVA = "0x17CFEF0", Offset = "0x17CF0F0", Length = "0x1FE")]
	[CalledBy(Type = typeof(CookieTokenizer), Member = "Next", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(CookieToken))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000F2C")]
	internal CookieToken TokenFromName(bool parseResponseCookies) { }

}

