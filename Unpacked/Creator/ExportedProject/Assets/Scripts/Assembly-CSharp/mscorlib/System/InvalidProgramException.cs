namespace System;

[Token(Token = "0x2000105")]
public sealed class InvalidProgramException : SystemException
{

	[Address(RVA = "0x14A1A00", Offset = "0x14A0C00", Length = "0x44")]
	[CalledBy(Type = "System.Linq.Expressions.Error", Member = "InvalidProgram", ReturnType = typeof(Exception))]
	[CalledBy(Type = "Unity.Properties.TypeUtility", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000815")]
	public InvalidProgramException() { }

	[Address(RVA = "0x14A1A50", Offset = "0x14A0C50", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000816")]
	public InvalidProgramException(string message) { }

	[Address(RVA = "0x13225B0", Offset = "0x13217B0", Length = "0x1F")]
	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000817")]
	internal InvalidProgramException(SerializationInfo info, StreamingContext context) { }

}

