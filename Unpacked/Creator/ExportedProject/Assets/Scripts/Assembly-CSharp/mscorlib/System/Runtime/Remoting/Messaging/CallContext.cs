namespace System.Runtime.Remoting.Messaging;

[ComVisible(True)]
[Token(Token = "0x200038F")]
public sealed class CallContext
{

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B91")]
	private CallContext() { }

	[Address(RVA = "0x2DAD10", Offset = "0x2D9F10", Length = "0x3")]
	[CallerCount(Count = 51)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001B92")]
	internal static object SetCurrentCallContext(LogicalCallContext ctx) { }

	[Address(RVA = "0x137BEF0", Offset = "0x137B0F0", Length = "0x65")]
	[CalledBy(Type = typeof(RemotingServices), Member = "InternalExecuteMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarshalByRefObject), typeof(IMethodCallMessage)}, ReturnType = typeof(IMethodReturnMessage))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[Calls(Type = typeof(Thread), Member = "GetMutableExecutionContext", ReturnType = typeof(ExecutionContext))]
	[Calls(Type = typeof(ExecutionContext), Member = "get_LogicalCallContext", ReturnType = typeof(LogicalCallContext))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001B93")]
	internal static LogicalCallContext SetLogicalCallContext(LogicalCallContext callCtx) { }

}

