namespace System;

[Token(Token = "0x20000B7")]
public class ArithmeticException : SystemException
{

	[Address(RVA = "0x140AFE0", Offset = "0x140A1E0", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600040D")]
	public ArithmeticException() { }

	[Address(RVA = "0x140B030", Offset = "0x140A230", Length = "0x1E")]
	[CallerCount(Count = 36)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600040E")]
	public ArithmeticException(string message) { }

	[Address(RVA = "0x140B050", Offset = "0x140A250", Length = "0x1E")]
	[CalledBy(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Token(Token = "0x600040F")]
	public ArithmeticException(string message, Exception innerException) { }

	[Address(RVA = "0x13225B0", Offset = "0x13217B0", Length = "0x1F")]
	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000410")]
	protected ArithmeticException(SerializationInfo info, StreamingContext context) { }

}

