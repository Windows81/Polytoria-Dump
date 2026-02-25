namespace System;

[Token(Token = "0x2000114")]
public sealed class MulticastNotSupportedException : SystemException
{

	[Address(RVA = "0x14A4500", Offset = "0x14A3700", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600089C")]
	public MulticastNotSupportedException() { }

	[Address(RVA = "0x14A4550", Offset = "0x14A3750", Length = "0x1E")]
	[CalledBy(Type = typeof(Delegate), Member = "CombineImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600089D")]
	public MulticastNotSupportedException(string message) { }

	[Address(RVA = "0x13225B0", Offset = "0x13217B0", Length = "0x1F")]
	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600089E")]
	internal MulticastNotSupportedException(SerializationInfo info, StreamingContext context) { }

}

