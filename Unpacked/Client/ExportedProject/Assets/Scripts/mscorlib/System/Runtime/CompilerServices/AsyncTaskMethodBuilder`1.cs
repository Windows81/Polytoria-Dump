namespace System.Runtime.CompilerServices;

[Token(Token = "0x200048E")]
public struct AsyncTaskMethodBuilder
{
	[Token(Token = "0x400126C")]
	internal static readonly Task<TResult> s_defaultResultTask; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400126D")]
	private AsyncMethodBuilderCore m_coreState; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400126E")]
	private Task<TResult> m_task; //Field offset: 0x0

	[Token(Token = "0x1700040A")]
	public Task<TResult> Task
	{
		[Address(RVA = "0xE86A60", Offset = "0xE85C60", Length = "0xA9")]
		[CalledBy(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mono.Net.Security.AsyncProtocolRequest+<ProcessOperation>d__24", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Mono.Net.Security.AsyncProtocolRequest", Member = "InnerRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = "System.Threading.Tasks.Task`1<Nullable`1<Int32>>")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Task`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600207F")]
		 get { } //Length: 169
	}

	[Address(RVA = "0xE86370", Offset = "0xE85570", Length = "0xED")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(AsyncTaskCache), Member = "CreateCacheableTask", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002084")]
	private static AsyncTaskMethodBuilder`1() { }

	[Address(RVA = "0x5FB800", Offset = "0x5FAA00", Length = "0x1EA")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "get_Task", ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[Calls(Type = typeof(AsyncMethodBuilderCore), Member = "GetCompletionAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(MoveNextRunner&)}, ReturnType = typeof(Action))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(AsyncMethodBuilderCore), Member = "PostBoxInitialization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine), typeof(MoveNextRunner), typeof(Task)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ConfiguredTaskAwaiter), Member = "UnsafeOnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncMethodBuilderCore), Member = "ThrowAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(SynchronizationContext)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600207E")]
	public void AwaitUnsafeOnCompleted(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }

	[Address(RVA = "0xE7ED70", Offset = "0xE7DF70", Length = "0x10")]
	[CallerCount(Count = 140)]
	[DeduplicatedMethod]
	[Token(Token = "0x600207B")]
	public static AsyncTaskMethodBuilder<TResult> Create() { }

	[Address(RVA = "0xE86A60", Offset = "0xE85C60", Length = "0xA9")]
	[CalledBy(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Net.Security.AsyncProtocolRequest+<ProcessOperation>d__24", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Net.Security.AsyncProtocolRequest", Member = "InnerRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = "System.Threading.Tasks.Task`1<Nullable`1<Int32>>")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Task`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600207F")]
	public Task<TResult> get_Task() { }

	[Address(RVA = "0xE813F0", Offset = "0xE805F0", Length = "0x137")]
	[CalledBy(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Task`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002083")]
	internal static Task<TResult> GetTaskForResult(TResult result) { }

	[Address(RVA = "0xE83EB0", Offset = "0xE830B0", Length = "0x1AF")]
	[CalledBy(Type = "Mono.Net.Security.AsyncProtocolRequest+<InnerRead>d__25", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180022130")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "TrySetCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task), Member = "TrySetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002082")]
	public void SetException(Exception exception) { }

	[Address(RVA = "0xE850F0", Offset = "0xE842F0", Length = "0x1D0")]
	[CalledBy(Type = "Mono.Net.Security.AsyncProtocolRequest+<InnerRead>d__25", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Task), Member = "RemoveFromActiveTasks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Task), Member = "get_Id", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(Task`1), Member = "TrySetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "GetTaskForResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002080")]
	public void SetResult(TResult result) { }

	[Address(RVA = "0xE85040", Offset = "0xE84240", Length = "0xA4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[ContainsInvalidInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6002081")]
	internal void SetResult(Task<TResult> completedTask) { }

	[Address(RVA = "0xE85E30", Offset = "0xE85030", Length = "0x8")]
	[CallerCount(Count = 58)]
	[Calls(Type = typeof(AsyncMethodBuilderCore), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600207D")]
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	[Address(RVA = "0x6021E0", Offset = "0x6013E0", Length = "0xBF")]
	[CalledBy(Type = "Mono.Net.Security.AsyncProtocolRequest+<ProcessOperation>d__24", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Net.Security.AsyncProtocolRequest", Member = "InnerRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = "System.Threading.Tasks.Task`1<Nullable`1<Int32>>")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ExecutionContext), Member = "EstablishCopyOnWriteScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContextSwitcher&)}, ReturnType = typeof(void))]
	[Calls(Type = "Mono.Net.Security.AsyncProtocolRequest+<InnerRead>d__25", Member = "MoveNext", ReturnType = typeof(void))]
	[Calls(Type = typeof(ExecutionContextSwitcher), Member = "Undo", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DebuggerStepThrough]
	[DeduplicatedMethod]
	[Token(Token = "0x600207C")]
	public void Start(ref TStateMachine stateMachine) { }

}

