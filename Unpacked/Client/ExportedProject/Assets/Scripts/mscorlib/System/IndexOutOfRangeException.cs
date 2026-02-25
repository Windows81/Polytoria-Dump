namespace System;

[Token(Token = "0x20000FE")]
public sealed class IndexOutOfRangeException : SystemException
{

	[Address(RVA = "0x149E9C0", Offset = "0x149DBC0", Length = "0x44")]
	[CallerCount(Count = 32)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60007AA")]
	public IndexOutOfRangeException() { }

	[Address(RVA = "0x149EA10", Offset = "0x149DC10", Length = "0x1E")]
	[CallerCount(Count = 165)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60007AB")]
	public IndexOutOfRangeException(string message) { }

	[Address(RVA = "0x13225B0", Offset = "0x13217B0", Length = "0x1F")]
	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007AC")]
	internal IndexOutOfRangeException(SerializationInfo info, StreamingContext context) { }

}

