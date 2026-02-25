namespace System;

[Token(Token = "0x2000111")]
public class MethodAccessException : MemberAccessException
{

	[Address(RVA = "0x14A42B0", Offset = "0x14A34B0", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000894")]
	public MethodAccessException() { }

	[Address(RVA = "0x14A4300", Offset = "0x14A3500", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000895")]
	public MethodAccessException(string message) { }

	[Address(RVA = "0x13225B0", Offset = "0x13217B0", Length = "0x1F")]
	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000896")]
	protected MethodAccessException(SerializationInfo info, StreamingContext context) { }

}

