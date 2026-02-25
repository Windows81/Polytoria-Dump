namespace System.Threading.Tasks;

[Token(Token = "0x200026F")]
internal sealed class UnwrapPromise : Task<TResult>, ITaskCompletionAction
{
	[CompilerGenerated]
	[Token(Token = "0x2000270")]
	private sealed class <>c
	{
		[Token(Token = "0x4000B27")]
		public static readonly <>c<TResult> <>9; //Field offset: 0x0
		[Token(Token = "0x4000B28")]
		public static WaitCallback <>9__8_0; //Field offset: 0x0

		[Address(RVA = "0x7FC210", Offset = "0x7FB410", Length = "0xE9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001433")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001434")]
		public <>c() { }

		[Address(RVA = "0x7F8E80", Offset = "0x7F8080", Length = "0x95")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(UnwrapPromise`1), Member = "InvokeCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001435")]
		internal void <InvokeCoreAsync>b__8_0(object state) { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B25")]
	private byte _state; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B26")]
	private readonly bool _lookForOce; //Field offset: 0x0

	[Token(Token = "0x170001F9")]
	public override bool InvokeMayRunArbitraryCode
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001432")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x847660", Offset = "0x846860", Length = "0x145")]
	[CalledBy(Type = typeof(Task), Member = "Run", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<Task`1<TResult>>", typeof(CancellationToken)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Task), Member = "get_CreationOptions", ReturnType = typeof(TaskCreationOptions))]
	[Calls(Type = typeof(System.Threading.Tasks.Task`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(TaskCreationOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1805F76D0")]
	[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task), Member = "AddCompletionAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITaskCompletionAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnwrapPromise`1), Member = "ProcessCompletedOuterTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600142B")]
	public UnwrapPromise`1(Task outerTask, bool lookForOce) { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001432")]
	public override bool get_InvokeMayRunArbitraryCode() { }

	[Address(RVA = "0x846230", Offset = "0x845430", Length = "0x151")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Task), Member = "get_CurrentStackGuard", ReturnType = typeof(StackGuard))]
	[Calls(Type = typeof(StackGuard), Member = "TryBeginInliningScope", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnwrapPromise`1), Member = "ProcessCompletedOuterTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnwrapPromise`1), Member = "TrySetFromTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StackGuard), Member = "EndInliningScope", ReturnType = typeof(void))]
	[Calls(Type = typeof(UnwrapPromise`1), Member = "InvokeCoreAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[DeduplicatedMethod]
	[Token(Token = "0x600142C")]
	public override void Invoke(Task completingTask) { }

	[Address(RVA = "0x845F90", Offset = "0x845190", Length = "0x4F")]
	[CalledBy(Type = typeof(<>c), Member = "<InvokeCoreAsync>b__8_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnwrapPromise`1), Member = "ProcessCompletedOuterTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnwrapPromise`1), Member = "TrySetFromTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(bool))]
	[DeduplicatedMethod]
	[Token(Token = "0x600142D")]
	private void InvokeCore(Task completingTask) { }

	[Address(RVA = "0x845A10", Offset = "0x844C10", Length = "0x1CB")]
	[CalledBy(Type = typeof(UnwrapPromise`1), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Tuple), Member = "Create", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, ReturnType = "System.Tuple`2<T1, T2>")]
	[Calls(Type = typeof(ThreadPool), Member = "UnsafeQueueUserWorkItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitCallback), typeof(object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600142E")]
	private void InvokeCoreAsync(Task completingTask) { }

	[Address(RVA = "0x8464F0", Offset = "0x8456F0", Length = "0x1BB")]
	[CalledBy(Type = typeof(UnwrapPromise`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnwrapPromise`1), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnwrapPromise`1), Member = "InvokeCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Task), Member = "get_Status", ReturnType = typeof(TaskStatus))]
	[Calls(Type = typeof(Task), Member = "TrySetCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnwrapPromise`1), Member = "TrySetFromTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task), Member = "AddCompletionAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITaskCompletionAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Task`1), Member = "get_Result", ReturnType = "TResult")]
	[DeduplicatedMethod]
	[Token(Token = "0x600142F")]
	private void ProcessCompletedOuterTask(Task task) { }

	[Address(RVA = "0x846A60", Offset = "0x845C60", Length = "0x8F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task), Member = "AddCompletionAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITaskCompletionAction)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnwrapPromise`1), Member = "TrySetFromTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task), Member = "TrySetCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001431")]
	private void ProcessInnerTask(Task task) { }

	[Address(RVA = "0x847060", Offset = "0x846260", Length = "0x2F5")]
	[CalledBy(Type = typeof(UnwrapPromise`1), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnwrapPromise`1), Member = "InvokeCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnwrapPromise`1), Member = "ProcessCompletedOuterTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnwrapPromise`1), Member = "ProcessInnerTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Task), Member = "GetExceptionDispatchInfos", ReturnType = typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Runtime.ExceptionServices.ExceptionDispatchInfo>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(Task), Member = "GetCancellationExceptionDispatchInfo", ReturnType = typeof(ExceptionDispatchInfo))]
	[Calls(Type = typeof(Task), Member = "get_CancellationToken", ReturnType = typeof(CancellationToken))]
	[Calls(Type = typeof(Task), Member = "TrySetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task), Member = "TrySetCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Task), Member = "get_Status", ReturnType = typeof(TaskStatus))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1805F7760")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Threading.Tasks.Task`1<System.Object>), Member = "TrySetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReadOnlyCollection`1), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(Task`1), Member = "get_Result", ReturnType = "TResult")]
	[CallsDeduplicatedMethods(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001430")]
	private bool TrySetFromTask(Task task, bool lookForOce) { }

}

