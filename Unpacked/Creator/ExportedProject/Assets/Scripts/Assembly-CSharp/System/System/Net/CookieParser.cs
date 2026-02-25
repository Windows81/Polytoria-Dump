namespace System.Net;

[Token(Token = "0x200025F")]
internal class CookieParser
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40009E5")]
	private CookieTokenizer m_tokenizer; //Field offset: 0x10

	[Address(RVA = "0x17CF8E0", Offset = "0x17CEAE0", Length = "0x93")]
	[CalledBy(Type = typeof(CookieContainer), Member = "CookieCutter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(CookieCollection))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000F31")]
	internal CookieParser(string cookieString) { }

	[Address(RVA = "0x17CEDF0", Offset = "0x17CDFF0", Length = "0x82")]
	[CalledBy(Type = typeof(Cookie), Member = "VerifySetDefaults", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CookieVariant), typeof(Uri), typeof(bool), typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CookieContainer), Member = "BuildCookieCollectionFromDomainMatches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(bool), typeof(int), typeof(CookieCollection), typeof(System.Collections.Generic.List`1<System.String>), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.PathList+PathListComparer", Member = "System.Collections.IComparer.Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000F33")]
	internal static string CheckQuoted(string value) { }

	[Address(RVA = "0x17CEE80", Offset = "0x17CE080", Length = "0xA24")]
	[CalledBy(Type = typeof(CookieContainer), Member = "CookieCutter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(CookieCollection))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Cookie), Member = "set_Port", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "AddSeconds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider), typeof(DateTimeStyles), typeof(DateTime&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Uri), Member = "TryCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(UriKind), typeof(Uri&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Cookie), Member = "InternalSetName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CookieTokenizer), Member = "Next", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(CookieToken))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000F32")]
	internal Cookie Get() { }

}

