namespace System;

[Token(Token = "0x20000D0")]
public class DllNotFoundException : TypeLoadException
{

	[Address(RVA = "0x1498CC0", Offset = "0x1497EC0", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TypeLoadException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000671")]
	public DllNotFoundException() { }

	[Address(RVA = "0x1498CA0", Offset = "0x1497EA0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TypeLoadException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000672")]
	public DllNotFoundException(string message) { }

	[Address(RVA = "0x1498C80", Offset = "0x1497E80", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TypeLoadException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000673")]
	protected DllNotFoundException(SerializationInfo info, StreamingContext context) { }

}

