namespace System;

[Token(Token = "0x2000117")]
public class NotSupportedException : SystemException
{

	[Address(RVA = "0x14A45E0", Offset = "0x14A37E0", Length = "0x44")]
	[CallerCount(Count = 253)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60008A3")]
	public NotSupportedException() { }

	[Address(RVA = "0x14A4650", Offset = "0x14A3850", Length = "0x1E")]
	[CallerCount(Count = 318)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60008A4")]
	public NotSupportedException(string message) { }

	[Address(RVA = "0x14A4630", Offset = "0x14A3830", Length = "0x1E")]
	[CalledBy(Type = "Mono.Net.Security.MonoTlsProviderFactory", Member = "InitializeInternal", ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Net.Security.MonoTlsProviderFactory", Member = "LookupProvider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = "Mono.Net.Security.MobileTlsProvider")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Token(Token = "0x60008A5")]
	public NotSupportedException(string message, Exception innerException) { }

	[Address(RVA = "0x13225B0", Offset = "0x13217B0", Length = "0x1F")]
	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60008A6")]
	protected NotSupportedException(SerializationInfo info, StreamingContext context) { }

}

