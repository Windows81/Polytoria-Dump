namespace System.Runtime.CompilerServices;

[Token(Token = "0x200048C")]
public struct AsyncVoidMethodBuilder
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001267")]
	private SynchronizationContext m_synchronizationContext; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4001268")]
	private AsyncMethodBuilderCore m_coreState; //Field offset: 0x8
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001269")]
	private Task m_task; //Field offset: 0x18

	[Token(Token = "0x17000408")]
	internal Task Task
	{
		[Address(RVA = "0x13B63C0", Offset = "0x13B55C0", Length = "0x69")]
		[CalledBy(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Task), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6002072")]
		internal get { } //Length: 105
	}

	[Address(RVA = "0x653EC0", Offset = "0x6530C0", Length = "0x230")]
	[CalledBy(Type = "System.Net.WebOperation+<Run>d__58", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Task), Member = "get_Id", ReturnType = typeof(int))]
	[Calls(Type = typeof(AsyncMethodBuilderCore), Member = "PostBoxInitialization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine), typeof(MoveNextRunner), typeof(Task)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(AsyncMethodBuilderCore), Member = "GetCompletionAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(MoveNextRunner&)}, ReturnType = typeof(Action))]
	[Calls(Type = typeof(ConfiguredTaskAwaiter), Member = "UnsafeOnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(AsyncMethodBuilderCore), Member = "ThrowAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(SynchronizationContext)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600206E")]
	public void AwaitUnsafeOnCompleted(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }

	[Address(RVA = "0x13B60B0", Offset = "0x13B52B0", Length = "0x67")]
	[CalledBy(Type = "System.Net.FtpWebRequest", Member = "SubmitRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.FtpWebRequest", Member = "CreateConnectionAsync", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebOperation", Member = "Run", ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.GltfAsset", Member = "Start", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SynchronizationContext), Member = "get_CurrentNoFlow", ReturnType = typeof(SynchronizationContext))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600206B")]
	public static AsyncVoidMethodBuilder Create() { }

	[Address(RVA = "0x13B63C0", Offset = "0x13B55C0", Length = "0x69")]
	[CalledBy(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Task), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6002072")]
	internal Task get_Task() { }

	[Address(RVA = "0x13B6120", Offset = "0x13B5320", Length = "0x40")]
	[CalledBy(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AsyncMethodBuilderCore), Member = "ThrowAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(SynchronizationContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002071")]
	private void NotifySynchronizationContextOfCompletion() { }

	[Address(RVA = "0x13B6170", Offset = "0x13B5370", Length = "0x119")]
	[CalledBy(Type = "System.Net.FtpWebRequest+<CreateConnectionAsync>d__86", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebOperation+<Run>d__58", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.GltfAsset+<Start>d__28", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AsyncMethodBuilderCore), Member = "ThrowAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(SynchronizationContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[Calls(Type = typeof(Task), Member = "get_Id", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "NotifySynchronizationContextOfCompletion", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6002070")]
	public void SetException(Exception exception) { }

	[Address(RVA = "0x13B6290", Offset = "0x13B5490", Length = "0x5F")]
	[CalledBy(Type = "System.Net.FtpWebRequest+<CreateConnectionAsync>d__86", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebOperation+<Run>d__58", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.GltfAsset+<Start>d__28", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[Calls(Type = typeof(Task), Member = "get_Id", ReturnType = typeof(int))]
	[Calls(Type = typeof(AsyncVoidMethodBuilder), Member = "NotifySynchronizationContextOfCompletion", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600206F")]
	public void SetResult() { }

	[Address(RVA = "0x13B62F0", Offset = "0x13B54F0", Length = "0xCA")]
	[CalledBy(Type = "System.Net.FtpWebRequest+<CreateConnectionAsync>d__86", Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebOperation+<Run>d__58", Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.GltfAsset+<Start>d__28", Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600206D")]
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	[Address(RVA = "0x6017D0", Offset = "0x6009D0", Length = "0x1CB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEC10")]
	[Calls(Type = typeof(ExecutionContextSwitcher), Member = "Undo", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEB00")]
	[Calls(Type = typeof(ExecutionContext), Member = "EstablishCopyOnWriteScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContextSwitcher&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DebuggerStepThrough]
	[DeduplicatedMethod]
	[Token(Token = "0x600206C")]
	public void Start(ref TStateMachine stateMachine) { }

}

