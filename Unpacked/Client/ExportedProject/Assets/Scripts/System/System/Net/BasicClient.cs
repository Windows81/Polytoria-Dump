namespace System.Net;

[Token(Token = "0x2000278")]
internal class BasicClient : IAuthenticationModule
{

	[Token(Token = "0x17000338")]
	public override string AuthenticationType
	{
		[Address(RVA = "0x17E9820", Offset = "0x17E8A20", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000FCE")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000FCF")]
	public BasicClient() { }

	[Address(RVA = "0x17E93A0", Offset = "0x17E85A0", Length = "0xAD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(BasicClient), Member = "InternalAuthenticate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebRequest), typeof(ICredentials)}, ReturnType = typeof(Authorization))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000FCA")]
	public override Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	[Address(RVA = "0x17E9820", Offset = "0x17E8A20", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000FCE")]
	public override string get_AuthenticationType() { }

	[Address(RVA = "0x17E9450", Offset = "0x17E8650", Length = "0xA4")]
	[CalledBy(Type = typeof(BasicClient), Member = "InternalAuthenticate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebRequest), typeof(ICredentials)}, ReturnType = typeof(Authorization))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000FCB")]
	private static Byte[] GetBytes(string str) { }

	[Address(RVA = "0x17E9500", Offset = "0x17E8700", Length = "0x2FB")]
	[CalledBy(Type = typeof(BasicClient), Member = "Authenticate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WebRequest), typeof(ICredentials)}, ReturnType = typeof(Authorization))]
	[CalledBy(Type = typeof(BasicClient), Member = "PreAuthenticate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebRequest), typeof(ICredentials)}, ReturnType = typeof(Authorization))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Convert), Member = "ToBase64String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BasicClient), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Authorization), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002C70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Token(Token = "0x6000FCC")]
	private static Authorization InternalAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	[Address(RVA = "0x17E9800", Offset = "0x17E8A00", Length = "0x11")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BasicClient), Member = "InternalAuthenticate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebRequest), typeof(ICredentials)}, ReturnType = typeof(Authorization))]
	[Token(Token = "0x6000FCD")]
	public override Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

}

