namespace System.Threading.Tasks;

[DebuggerDisplay("Id={Id}")]
[DebuggerTypeProxy(typeof(SystemThreadingTasks_TaskSchedulerDebugView))]
[Token(Token = "0x200027E")]
public abstract class TaskScheduler
{
	[Token(Token = "0x200027F")]
	public sealed class SystemThreadingTasks_TaskSchedulerDebugView
	{

	}

	[Token(Token = "0x4000B43")]
	private static readonly TaskScheduler s_defaultTaskScheduler; //Field offset: 0x0
	[Token(Token = "0x4000B44")]
	internal static int s_taskSchedulerIdCounter; //Field offset: 0x8
	[Token(Token = "0x4000B46")]
	private static EventHandler<UnobservedTaskExceptionEventArgs> _unobservedTaskException; //Field offset: 0x10
	[Token(Token = "0x4000B47")]
	private static readonly Lock _unobservedTaskExceptionLockObject; //Field offset: 0x18
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B45")]
	private int m_taskSchedulerId; //Field offset: 0x10

	[Token(Token = "0x170001FF")]
	public static TaskScheduler Current
	{
		[Address(RVA = "0x152FA40", Offset = "0x152EC40", Length = "0x9C")]
		[CalledBy(Type = typeof(Task`1), Member = "ContinueWith", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TNewResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<Task`1<TResult>, TNewResult>", typeof(TaskContinuationOptions)}, ReturnType = "System.Threading.Tasks.Task`1<TNewResult>")]
		[CalledBy(Type = typeof(Task), Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Task), Member = "ContinueWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Threading.Tasks.Task>)}, ReturnType = typeof(Task))]
		[CalledBy(Type = typeof(YieldAwaiter), Member = "QueueContinuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Net.Sockets.Socket+AwaitableSocketAsyncEventArgs", Member = "OnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<Object>", typeof(object), typeof(short), typeof(ValueTaskSourceOnCompletedFlags)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TaskScheduler), Member = "get_InternalCurrent", ReturnType = typeof(TaskScheduler))]
		[Token(Token = "0x6001480")]
		 get { } //Length: 156
	}

	[Token(Token = "0x170001FE")]
	public static TaskScheduler Default
	{
		[Address(RVA = "0x152FAE0", Offset = "0x152ECE0", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x600147F")]
		 get { } //Length: 78
	}

	[Token(Token = "0x17000201")]
	public int Id
	{
		[Address(RVA = "0x152FB30", Offset = "0x152ED30", Length = "0x9D")]
		[CalledBy(Type = typeof(Task), Member = "InternalWait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(ThreadPoolTaskScheduler), Member = "QueueTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Runtime.CompilerServices.TaskAwaiter+<>c__DisplayClass11_0", Member = "<OutputWaitEtwEvents>b__0", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TaskAwaiter), Member = "OutputWaitEtwEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(Action)}, ReturnType = typeof(Action))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8C20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8A90")]
		[Token(Token = "0x6001482")]
		 get { } //Length: 157
	}

	[Token(Token = "0x17000200")]
	internal static TaskScheduler InternalCurrent
	{
		[Address(RVA = "0x152FBD0", Offset = "0x152EDD0", Length = "0xD7")]
		[CalledBy(Type = typeof(Task), Member = "SetContinuationForAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TaskSchedulerAwaitTaskContinuation), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AwaitTaskContinuation), Member = "get_IsValidLocationForInlining", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TaskScheduler), Member = "get_Current", ReturnType = typeof(TaskScheduler))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Token(Token = "0x6001481")]
		internal get { } //Length: 215
	}

	[Token(Token = "0x170001FD")]
	internal override bool RequiresAtomicStartTransition
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x600147D")]
		internal get { } //Length: 3
	}

	[Address(RVA = "0x152F940", Offset = "0x152EB40", Length = "0xF5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Lock), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001484")]
	private static TaskScheduler() { }

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600147E")]
	protected TaskScheduler() { }

	[Address(RVA = "0x152FA40", Offset = "0x152EC40", Length = "0x9C")]
	[CalledBy(Type = typeof(Task`1), Member = "ContinueWith", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TNewResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<Task`1<TResult>, TNewResult>", typeof(TaskContinuationOptions)}, ReturnType = "System.Threading.Tasks.Task`1<TNewResult>")]
	[CalledBy(Type = typeof(Task), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "ContinueWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Threading.Tasks.Task>)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(YieldAwaiter), Member = "QueueContinuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.Socket+AwaitableSocketAsyncEventArgs", Member = "OnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<Object>", typeof(object), typeof(short), typeof(ValueTaskSourceOnCompletedFlags)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TaskScheduler), Member = "get_InternalCurrent", ReturnType = typeof(TaskScheduler))]
	[Token(Token = "0x6001480")]
	public static TaskScheduler get_Current() { }

	[Address(RVA = "0x152FAE0", Offset = "0x152ECE0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600147F")]
	public static TaskScheduler get_Default() { }

	[Address(RVA = "0x152FB30", Offset = "0x152ED30", Length = "0x9D")]
	[CalledBy(Type = typeof(Task), Member = "InternalWait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ThreadPoolTaskScheduler), Member = "QueueTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Runtime.CompilerServices.TaskAwaiter+<>c__DisplayClass11_0", Member = "<OutputWaitEtwEvents>b__0", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TaskAwaiter), Member = "OutputWaitEtwEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(Action)}, ReturnType = typeof(Action))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8C20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8A90")]
	[Token(Token = "0x6001482")]
	public int get_Id() { }

	[Address(RVA = "0x152FBD0", Offset = "0x152EDD0", Length = "0xD7")]
	[CalledBy(Type = typeof(Task), Member = "SetContinuationForAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TaskSchedulerAwaitTaskContinuation), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AwaitTaskContinuation), Member = "get_IsValidLocationForInlining", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TaskScheduler), Member = "get_Current", ReturnType = typeof(TaskScheduler))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Token(Token = "0x6001481")]
	internal static TaskScheduler get_InternalCurrent() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x600147D")]
	internal override bool get_RequiresAtomicStartTransition() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600147C")]
	internal override void NotifyWorkItemProgress() { }

	[Address(RVA = "0x152F540", Offset = "0x152E740", Length = "0x135")]
	[CalledBy(Type = typeof(TaskExceptionHolder), Member = "Finalize", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Lock), Member = "Acquire", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Lock), Member = "Release", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001483")]
	internal static void PublishUnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs ueea) { }

	[Token(Token = "0x6001478")]
	protected private abstract void QueueTask(Task task) { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x600147B")]
	protected private override bool TryDequeue(Task task) { }

	[Token(Token = "0x6001479")]
	protected abstract bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued) { }

	[Address(RVA = "0x152F680", Offset = "0x152E880", Length = "0x2BE")]
	[CalledBy(Type = typeof(Task), Member = "WrappedTryRunInline", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TaskContinuation), Member = "InlineIfPossibleOrElseQueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TaskScheduler), Member = "TryRunInline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TaskScheduler), Member = "TryRunInline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600147A")]
	internal bool TryRunInline(Task task, bool taskWasPreviouslyQueued) { }

}

