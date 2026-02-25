namespace System.Runtime.CompilerServices;

[Token(Token = "0x200048D")]
public struct AsyncTaskMethodBuilder
{
	[Token(Token = "0x400126A")]
	private static readonly Task<VoidTaskResult> s_cachedCompleted; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400126B")]
	private AsyncTaskMethodBuilder<VoidTaskResult> m_builder; //Field offset: 0x0

	[Token(Token = "0x17000409")]
	public Task Task
	{
		[Address(RVA = "0x13B6050", Offset = "0x13B5250", Length = "0x5A")]
		[CallerCount(Count = 61)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Threading.Tasks.VoidTaskResult>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult>))]
		[Token(Token = "0x6002077")]
		 get { } //Length: 90
	}

	[Address(RVA = "0x13B5FD0", Offset = "0x13B51D0", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600207A")]
	private static AsyncTaskMethodBuilder() { }

	[Address(RVA = "0x651160", Offset = "0x650360", Length = "0x81")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6002076")]
	public void AwaitUnsafeOnCompleted(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }

	[Address(RVA = "0xE7ED70", Offset = "0xE7DF70", Length = "0x10")]
	[CallerCount(Count = 140)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002073")]
	public static AsyncTaskMethodBuilder Create() { }

	[Address(RVA = "0x13B6050", Offset = "0x13B5250", Length = "0x5A")]
	[CallerCount(Count = 61)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Threading.Tasks.VoidTaskResult>), Member = "get_Task", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult>))]
	[Token(Token = "0x6002077")]
	public Task get_Task() { }

	[Address(RVA = "0x13B5E50", Offset = "0x13B5050", Length = "0x69")]
	[CallerCount(Count = 41)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Threading.Tasks.VoidTaskResult>), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002079")]
	public void SetException(Exception exception) { }

	[Address(RVA = "0x13B5EC0", Offset = "0x13B50C0", Length = "0x9B")]
	[CallerCount(Count = 41)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<System.Threading.Tasks.VoidTaskResult>), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult>)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002078")]
	public void SetResult() { }

	[Address(RVA = "0x13B5F60", Offset = "0x13B5160", Length = "0x69")]
	[CallerCount(Count = 41)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002075")]
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	[Address(RVA = "0x652480", Offset = "0x651680", Length = "0xBF")]
	[CalledBy(Type = "Mirror.Discovery.NetworkDiscoveryBase`2", Member = "StartDiscovery", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Discovery.NetworkDiscoveryBase`2", Member = "ClientListenAsync", ReturnType = typeof(Task))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ExecutionContext), Member = "EstablishCopyOnWriteScope", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContextSwitcher&)}, ReturnType = typeof(void))]
	[Calls(Type = "Mirror.Discovery.NetworkDiscoveryBase`2+<ClientListenAsync>d__30", Member = "MoveNext", ReturnType = typeof(void))]
	[Calls(Type = typeof(ExecutionContextSwitcher), Member = "Undo", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DebuggerStepThrough]
	[DeduplicatedMethod]
	[Token(Token = "0x6002074")]
	public void Start(ref TStateMachine stateMachine) { }

}

