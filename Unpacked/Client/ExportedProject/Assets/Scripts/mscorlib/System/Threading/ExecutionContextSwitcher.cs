namespace System.Threading;

[Token(Token = "0x200021D")]
internal struct ExecutionContextSwitcher
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000A03")]
	internal Reader outerEC; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000A04")]
	internal bool outerECBelongsToScope; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A05")]
	internal object hecsw; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A06")]
	internal Thread thread; //Field offset: 0x18

	[Address(RVA = "0x1511670", Offset = "0x1510870", Length = "0xB8")]
	[CalledBy(Type = typeof(ExecutionContextSwitcher), Member = "UndoNoThrow", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ExecutionContext), Member = "RunInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext), typeof(ContextCallback), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AsyncVoidMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TStateMachine&"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TStateMachine&"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AsyncTaskMethodBuilder`1), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TStateMachine&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ExecutionContext), Member = "OnAsyncLocalContextChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext), typeof(ExecutionContext)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	[Token(Token = "0x60011D3")]
	internal void Undo() { }

	[Address(RVA = "0x1511650", Offset = "0x1510850", Length = "0x1A")]
	[CalledBy(Type = typeof(ExecutionContext), Member = "SetExecutionContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext), typeof(bool)}, ReturnType = typeof(ExecutionContextSwitcher))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ExecutionContextSwitcher), Member = "Undo", ReturnType = typeof(void))]
	[HandleProcessCorruptedStateExceptions]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::MayFail (1))]
	[Token(Token = "0x60011D2")]
	internal bool UndoNoThrow() { }

}

