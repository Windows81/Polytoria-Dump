namespace System;

[Token(Token = "0x20000BA")]
public class ArrayTypeMismatchException : SystemException
{

	[Address(RVA = "0x140B070", Offset = "0x140A270", Length = "0x44")]
	[CalledBy(Type = typeof(ThrowHelper), Member = "CreateArrayTypeMismatchException", ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(Array), Member = "CreateArrayTypeMismatchException", ReturnType = typeof(ArrayTypeMismatchException))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000435")]
	public ArrayTypeMismatchException() { }

	[Address(RVA = "0x13225B0", Offset = "0x13217B0", Length = "0x1F")]
	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000436")]
	protected ArrayTypeMismatchException(SerializationInfo info, StreamingContext context) { }

}

