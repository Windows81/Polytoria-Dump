namespace System;

[Obsolete("This type previously indicated an unspecified fatal error in the runtime. The runtime no longer raises this exception so this type is obsolete.")]
[Token(Token = "0x20000D6")]
public sealed class ExecutionEngineException : SystemException
{

	[Address(RVA = "0x149A030", Offset = "0x1499230", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006A3")]
	public ExecutionEngineException() { }

	[Address(RVA = "0x149A080", Offset = "0x1499280", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006A4")]
	public ExecutionEngineException(string message) { }

	[Address(RVA = "0x13225B0", Offset = "0x13217B0", Length = "0x1F")]
	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006A5")]
	internal ExecutionEngineException(SerializationInfo info, StreamingContext context) { }

}

