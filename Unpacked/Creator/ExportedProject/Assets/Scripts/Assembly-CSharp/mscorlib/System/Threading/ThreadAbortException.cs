namespace System.Threading;

[ComVisible(True)]
[Token(Token = "0x200022C")]
public sealed class ThreadAbortException : SystemException
{

	[Address(RVA = "0x15199B0", Offset = "0x1518BB0", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = "GetMessageFromNativeResources", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionMessageKind)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600126C")]
	private ThreadAbortException() { }

	[Address(RVA = "0x13225B0", Offset = "0x13217B0", Length = "0x1F")]
	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600126D")]
	internal ThreadAbortException(SerializationInfo info, StreamingContext context) { }

}

