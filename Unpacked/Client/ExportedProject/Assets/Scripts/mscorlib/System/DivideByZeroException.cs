namespace System;

[Token(Token = "0x20000CF")]
public class DivideByZeroException : ArithmeticException
{

	[Address(RVA = "0x1498C30", Offset = "0x1497E30", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArithmeticException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600066E")]
	public DivideByZeroException() { }

	[Address(RVA = "0x1498C10", Offset = "0x1497E10", Length = "0x1E")]
	[CalledBy(Type = "Mirror.Compression", Member = "ScaleToLong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(Int64&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Mirror.Compression", Member = "ScaleToFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(float)}, ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArithmeticException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600066F")]
	public DivideByZeroException(string message) { }

	[Address(RVA = "0x10BD4F0", Offset = "0x10BC6F0", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000670")]
	protected DivideByZeroException(SerializationInfo info, StreamingContext context) { }

}

