namespace System.Security.Authentication;

[Token(Token = "0x200010E")]
public class AuthenticationException : SystemException
{

	[Address(RVA = "0x177B9F0", Offset = "0x177ABF0", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600066E")]
	public AuthenticationException() { }

	[Address(RVA = "0x136EB70", Offset = "0x136DD70", Length = "0x8")]
	[CallerCount(Count = 60)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600066F")]
	public AuthenticationException(string message) { }

	[Address(RVA = "0x136EB60", Offset = "0x136DD60", Length = "0x8")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000670")]
	public AuthenticationException(string message, Exception innerException) { }

	[Address(RVA = "0x13225B0", Offset = "0x13217B0", Length = "0x1F")]
	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000671")]
	protected AuthenticationException(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

