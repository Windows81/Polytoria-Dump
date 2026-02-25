namespace System.Net;

[Token(Token = "0x2000224")]
public class Authorization
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40008A9")]
	private string m_Message; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40008AA")]
	private bool m_Complete; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40008AB")]
	internal string ModuleAuthenticationType; //Field offset: 0x20

	[Token(Token = "0x170002BE")]
	public bool Complete
	{
		[Address(RVA = "0x2FBD80", Offset = "0x2FAF80", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DF6")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170002BD")]
	public string Message
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000DF5")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x17CD360", Offset = "0x17CC560", Length = "0x77")]
	[CalledBy(Type = typeof(BasicClient), Member = "InternalAuthenticate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebRequest), typeof(ICredentials)}, ReturnType = typeof(Authorization))]
	[CalledBy(Type = typeof(DigestSession), Member = "Authenticate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WebRequest), typeof(ICredentials)}, ReturnType = typeof(Authorization))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000DF3")]
	public Authorization(string token) { }

	[Address(RVA = "0x17CD3E0", Offset = "0x17CC5E0", Length = "0x85")]
	[CalledBy(Type = typeof(NtlmSession), Member = "Authenticate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(WebRequest), typeof(ICredentials)}, ReturnType = typeof(Authorization))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000DF4")]
	public Authorization(string token, bool finished) { }

	[Address(RVA = "0x2FBD80", Offset = "0x2FAF80", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DF6")]
	public bool get_Complete() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000DF5")]
	public string get_Message() { }

}

