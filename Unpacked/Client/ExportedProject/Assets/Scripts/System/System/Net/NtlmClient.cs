namespace System.Net;

[Token(Token = "0x2000298")]
internal class NtlmClient : IAuthenticationModule
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000AF4")]
	private IAuthenticationModule authObject; //Field offset: 0x10

	[Token(Token = "0x1700037D")]
	public override string AuthenticationType
	{
		[Address(RVA = "0x17FB830", Offset = "0x17FAA30", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60010B5")]
		 get { } //Length: 44
	}

	[Address(RVA = "0x17FB7C0", Offset = "0x17FA9C0", Length = "0x66")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60010B2")]
	public NtlmClient() { }

	[Address(RVA = "0x17FB740", Offset = "0x17FA940", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180009410")]
	[Token(Token = "0x60010B3")]
	public override Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	[Address(RVA = "0x17FB830", Offset = "0x17FAA30", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60010B5")]
	public override string get_AuthenticationType() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010B4")]
	public override Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

}

