namespace System.Threading.Tasks;

[DebuggerDisplay("Id = {Id}, Status = {Status}, Method = {DebuggerDisplayMethodDescription}")]
[DebuggerTypeProxy(typeof(SystemThreadingTasks_TaskDebugView))]
[Token(Token = "0x2000261")]
public class Task : IThreadPoolWorkItem, IAsyncResult, IDisposable
{
	[CompilerGenerated]
	[Token(Token = "0x2000266")]
	private sealed class <>c
	{
		[Token(Token = "0x4000AFF")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000B00")]
		public static Action<Object> <>9__247_0; //Field offset: 0x8
		[Token(Token = "0x4000B01")]
		public static TimerCallback <>9__247_1; //Field offset: 0x10

		[Address(RVA = "0x153AA60", Offset = "0x1539C60", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600141C")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600141D")]
		public <>c() { }

		[Address(RVA = "0x153A670", Offset = "0x1539870", Length = "0x50")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001420")]
		internal ContingentProperties <.cctor>b__271_0() { }

		[Address(RVA = "0x153A6C0", Offset = "0x15398C0", Length = "0x2E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001421")]
		internal bool <.cctor>b__271_1(Task t) { }

		[Address(RVA = "0x153A6F0", Offset = "0x15398F0", Length = "0x7")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6001422")]
		internal bool <.cctor>b__271_2(object tc) { }

		[Address(RVA = "0x153A490", Offset = "0x1539690", Length = "0x62")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "System.Threading.Tasks.Task+DelayPromise", Member = "Complete", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x600141E")]
		internal void <Delay>b__247_0(object state) { }

		[Address(RVA = "0x153A500", Offset = "0x1539700", Length = "0x62")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "System.Threading.Tasks.Task+DelayPromise", Member = "Complete", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x600141F")]
		internal void <Delay>b__247_1(object state) { }

	}

	[Token(Token = "0x2000262")]
	public class ContingentProperties
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000AF2")]
		internal ExecutionContext m_capturedContext; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000AF3")]
		internal ManualResetEventSlim m_completionEvent; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000AF4")]
		internal TaskExceptionHolder m_exceptionsHolder; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000AF5")]
		internal CancellationToken m_cancellationToken; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000AF6")]
		internal object m_cancellationRegistration; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000AF7")]
		internal int m_internalCancellationRequested; //Field offset: 0x38
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x4000AF8")]
		internal int m_completionCountdown; //Field offset: 0x3C
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000AF9")]
		internal LowLevelListWithIList<Task> m_exceptionalChildren; //Field offset: 0x40

		[Address(RVA = "0x15246A0", Offset = "0x15238A0", Length = "0x24")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001412")]
		public ContingentProperties() { }

		[Address(RVA = "0x15245C0", Offset = "0x15237C0", Length = "0x29")]
		[CalledBy(Type = typeof(Task`1), Member = "TrySetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(ManualResetEventSlim), Member = "Set", ReturnType = typeof(void))]
		[Token(Token = "0x6001410")]
		internal void SetCompleted() { }

		[Address(RVA = "0x15245F0", Offset = "0x15237F0", Length = "0xAD")]
		[CalledBy(Type = typeof(Task), Member = "FinishStageTwo", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Task), Member = "CancellationCleanupLogic", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
		[Calls(Type = typeof(CancellationTokenRegistration), Member = "Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001411")]
		internal void UnregisterCancellationCallback() { }

	}

	[Token(Token = "0x2000264")]
	private sealed class DelayPromise : Task<VoidTaskResult>
	{
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000AFA")]
		internal readonly CancellationToken Token; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000AFB")]
		internal CancellationTokenRegistration Registration; //Field offset: 0x60
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4000AFC")]
		internal Timer Timer; //Field offset: 0x78

		[Address(RVA = "0x1527B50", Offset = "0x1526D50", Length = "0xA0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult>), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1805F76D0")]
		[Token(Token = "0x6001416")]
		internal DelayPromise(CancellationToken token) { }

		[Address(RVA = "0x1527A40", Offset = "0x1526C40", Length = "0x10D")]
		[CalledBy(Type = "System.Threading.Tasks.Task+<>c", Member = "<Delay>b__247_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Threading.Tasks.Task+<>c", Member = "<Delay>b__247_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1805F7760")]
		[Calls(Type = typeof(Task`1), Member = "TrySetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Task), Member = "TrySetCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Timer), Member = "get_scheduler", ReturnType = "System.Threading.Timer+Scheduler")]
		[Calls(Type = "System.Threading.Timer+Scheduler", Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Timer)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CancellationTokenRegistration), Member = "Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001417")]
		internal void Complete() { }

	}

	[Token(Token = "0x2000263")]
	private sealed class SetOnInvokeMres : ManualResetEventSlim, ITaskCompletionAction
	{

		[Token(Token = "0x170001F5")]
		public override bool InvokeMayRunArbitraryCode
		{
			[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
			[CallerCount(Count = 137)]
			[DeduplicatedMethod]
			[Token(Token = "0x6001415")]
			 get { } //Length: 3
		}

		[Address(RVA = "0x152D060", Offset = "0x152C260", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(ManualResetEventSlim), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int)}, ReturnType = typeof(void))]
		[Token(Token = "0x6001413")]
		internal SetOnInvokeMres() { }

		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001415")]
		public override bool get_InvokeMayRunArbitraryCode() { }

		[Address(RVA = "0x152D050", Offset = "0x152C250", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ManualResetEventSlim), Member = "Set", ReturnType = typeof(void))]
		[Token(Token = "0x6001414")]
		public override void Invoke(Task completingTask) { }

	}

	[Token(Token = "0x2000265")]
	private sealed class WhenAllPromise : Task<VoidTaskResult>, ITaskCompletionAction
	{
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000AFD")]
		private readonly Task[] m_tasks; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000AFE")]
		private int m_count; //Field offset: 0x60

		[Token(Token = "0x170001F7")]
		public override bool InvokeMayRunArbitraryCode
		{
			[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			[Token(Token = "0x600141B")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170001F6")]
		internal virtual bool ShouldNotifyDebuggerOfWaitCompletion
		{
			[Address(RVA = "0x153D070", Offset = "0x153C270", Length = "0xF1")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
			[CallsUnknownMethods(Count = 1)]
			[Token(Token = "0x600141A")]
			internal get { } //Length: 241
		}

		[Address(RVA = "0x153CEB0", Offset = "0x153C0B0", Length = "0x1B0")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult>), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1805F76D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(Task), Member = "AddTaskContinuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
		[Calls(Type = typeof(WhenAllPromise), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001418")]
		internal WhenAllPromise(Task[] tasks) { }

		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x600141B")]
		public override bool get_InvokeMayRunArbitraryCode() { }

		[Address(RVA = "0x153D070", Offset = "0x153C270", Length = "0xF1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600141A")]
		internal virtual bool get_ShouldNotifyDebuggerOfWaitCompletion() { }

		[Address(RVA = "0x153CBD0", Offset = "0x153BDD0", Length = "0x2D2")]
		[CalledBy(Type = typeof(WhenAllPromise), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task[])}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Task), Member = "InternalWhenAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task[])}, ReturnType = typeof(Task))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(LowLevelListWithIList`1), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(Task), Member = "TrySetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Task), Member = "TrySetCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Task`1), Member = "TrySetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1805F7760")]
		[Calls(Type = typeof(Task), Member = "AtomicStateUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(LowLevelList`1), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B70")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Task), Member = "GetExceptionDispatchInfos", ReturnType = typeof(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Runtime.ExceptionServices.ExceptionDispatchInfo>))]
		[Token(Token = "0x6001419")]
		public override void Invoke(Task ignored) { }

	}

	[ThreadStatic]
	[Token(Token = "0x4000AE8")]
	internal static Task t_currentTask; //Field offset: 0x80000000
	[ThreadStatic]
	[Token(Token = "0x4000AE9")]
	private static StackGuard t_stackGuard; //Field offset: 0x80000008
	[Token(Token = "0x4000ADC")]
	internal static int s_taskIdCounter; //Field offset: 0x0
	[Token(Token = "0x4000AE4")]
	private static readonly object s_taskCompletionSentinel; //Field offset: 0x8
	[Token(Token = "0x4000AE5")]
	internal static bool s_asyncDebuggingEnabled; //Field offset: 0x10
	[Token(Token = "0x4000AE7")]
	private static readonly Action<Object> s_taskCancelCallback; //Field offset: 0x18
	[Token(Token = "0x4000AEA")]
	private static readonly Func<ContingentProperties> s_createContingentProperties; //Field offset: 0x20
	[CompilerGenerated]
	[Token(Token = "0x4000AEB")]
	private static readonly TaskFactory <Factory>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[Token(Token = "0x4000AEC")]
	private static readonly Task <CompletedTask>k__BackingField; //Field offset: 0x30
	[Token(Token = "0x4000AED")]
	private static readonly Predicate<Task> s_IsExceptionObservedByParentPredicate; //Field offset: 0x38
	[Token(Token = "0x4000AEE")]
	private static ContextCallback s_ecCallback; //Field offset: 0x40
	[Token(Token = "0x4000AEF")]
	private static readonly Predicate<Object> s_IsTaskContinuationNullPredicate; //Field offset: 0x48
	[Token(Token = "0x4000AF0")]
	private static readonly Dictionary<Int32, Task> s_currentActiveTasks; //Field offset: 0x50
	[Token(Token = "0x4000AF1")]
	private static readonly object s_activeTasksLock; //Field offset: 0x58
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000ADD")]
	private int m_taskId; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000ADE")]
	internal Delegate m_action; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000ADF")]
	internal object m_stateObject; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000AE0")]
	internal TaskScheduler m_taskScheduler; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000AE1")]
	internal readonly Task m_parent; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000AE2")]
	internal int m_stateFlags; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000AE3")]
	private object m_continuationObject; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000AE6")]
	internal ContingentProperties m_contingentProperties; //Field offset: 0x48

	[Token(Token = "0x170001EA")]
	public override object AsyncState
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x60013B7")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001E4")]
	internal CancellationToken CancellationToken
	{
		[Address(RVA = "0x1538290", Offset = "0x1537490", Length = "0x26")]
		[CalledBy(Type = typeof(UnwrapPromise`1), Member = "TrySetFromTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Token(Token = "0x60013B0")]
		internal get { } //Length: 38
	}

	[Token(Token = "0x170001F2")]
	internal ExecutionContext CapturedContext
	{
		[Address(RVA = "0x15382C0", Offset = "0x15374C0", Length = "0x74")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60013BF")]
		internal get { } //Length: 116
		[Address(RVA = "0x1538B30", Offset = "0x1537D30", Length = "0x8A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Task), Member = "EnsureContingentPropertiesInitialized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ContingentProperties))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60013C0")]
		internal set { } //Length: 138
	}

	[Token(Token = "0x170001EF")]
	internal ManualResetEventSlim CompletedEvent
	{
		[Address(RVA = "0x1538340", Offset = "0x1537540", Length = "0x19E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(LazyInitializer), Member = "EnsureInitialized", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "System.Func`1<T>"}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ManualResetEventSlim), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
		[Calls(Type = typeof(ManualResetEventSlim), Member = "Set", ReturnType = typeof(void))]
		[Calls(Type = typeof(ManualResetEventSlim), Member = "Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60013BC")]
		internal get { } //Length: 414
	}

	[Token(Token = "0x170001EE")]
	public static Task CompletedTask
	{
		[Address(RVA = "0x15384E0", Offset = "0x15376E0", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[Token(Token = "0x60013BB")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170001E8")]
	public TaskCreationOptions CreationOptions
	{
		[Address(RVA = "0x1538530", Offset = "0x1537730", Length = "0x4B")]
		[CalledBy(Type = typeof(Task), Member = "TaskConstructorCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(object), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(InternalTaskOptions), typeof(TaskScheduler)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UnwrapPromise`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60013B5")]
		 get { } //Length: 75
	}

	[Token(Token = "0x170001DF")]
	internal static StackGuard CurrentStackGuard
	{
		[Address(RVA = "0x1538580", Offset = "0x1537780", Length = "0xBE")]
		[CalledBy(Type = typeof(UnwrapPromise`1), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60013A9")]
		internal get { } //Length: 190
	}

	[Token(Token = "0x170001E0")]
	public AggregateException Exception
	{
		[Address(RVA = "0x15386B0", Offset = "0x15378B0", Length = "0x41")]
		[CalledBy(Type = typeof(TaskAwaiter), Member = "HandleNonSuccessAndDebuggerNotification", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TaskAwaiter), Member = "ThrowForNonSuccess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Net.HttpWebRequest+<>c__241`1", Member = "<RunWithTimeoutWorker>b__241_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Threading.Tasks.Task`1<T>"}, ReturnType = "System.Nullable`1<Int32>")]
		[CalledBy(Type = "System.Net.Sockets.Socket+<>c__DisplayClass240_0", Member = "<BeginConnect>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Threading.Tasks.Task`1<IPAddress[]>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(Task), Member = "GetExceptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(AggregateException))]
		[Token(Token = "0x60013AA")]
		 get { } //Length: 65
	}

	[Token(Token = "0x170001F0")]
	internal bool ExceptionRecorded
	{
		[Address(RVA = "0x1538640", Offset = "0x1537840", Length = "0x60")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60013BD")]
		internal get { } //Length: 96
	}

	[Token(Token = "0x170001EC")]
	internal TaskScheduler ExecutingTaskScheduler
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x60013B9")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x170001ED")]
	public static TaskFactory Factory
	{
		[Address(RVA = "0x1538700", Offset = "0x1537900", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[Token(Token = "0x60013BA")]
		 get { } //Length: 79
	}

	[Token(Token = "0x170001DD")]
	public int Id
	{
		[Address(RVA = "0x1538750", Offset = "0x1537950", Length = "0x96")]
		[CalledBy(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AsyncMethodBuilderCore), Member = "PostBoxInitialization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine), typeof(MoveNextRunner), typeof(Task)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Runtime.CompilerServices.AsyncMethodBuilderCore+<>c__DisplayClass5_0", Member = "<OutputAsyncCausalityEvents>b__0", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TaskAwaiter), Member = "OutputWaitEtwEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(Action)}, ReturnType = typeof(Action))]
		[CalledBy(Type = typeof(ThreadPoolTaskScheduler), Member = "QueueTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Task), Member = "AddToActiveTasks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Task), Member = "InternalWait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(DebuggerSupport), Member = "RemoveFromActiveTasksNonInlined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DebuggerSupport), Member = "AddToActiveTasksNonInlined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Runtime.CompilerServices.TaskAwaiter+<>c__DisplayClass11_0", Member = "<OutputWaitEtwEvents>b__0", ReturnType = typeof(void))]
		[CallerCount(Count = 22)]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8A90")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8C20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60013A6")]
		 get { } //Length: 150
	}

	[Token(Token = "0x170001DE")]
	internal static Task InternalCurrent
	{
		[Address(RVA = "0x15387F0", Offset = "0x15379F0", Length = "0x49")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
		[Token(Token = "0x60013A7")]
		internal get { } //Length: 73
	}

	[Token(Token = "0x170001E2")]
	public bool IsCanceled
	{
		[Address(RVA = "0x1538840", Offset = "0x1537A40", Length = "0x23")]
		[CalledBy(Type = "System.Net.Sockets.Socket+<>c__DisplayClass240_0", Member = "<BeginConnect>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Threading.Tasks.Task`1<IPAddress[]>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60013AC")]
		 get { } //Length: 35
	}

	[Token(Token = "0x170001E5")]
	internal bool IsCancellationAcknowledged
	{
		[Address(RVA = "0x1538870", Offset = "0x1537A70", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60013B1")]
		internal get { } //Length: 29
	}

	[Token(Token = "0x170001E3")]
	internal bool IsCancellationRequested
	{
		[Address(RVA = "0x1538890", Offset = "0x1537A90", Length = "0x7F")]
		[CalledBy(Type = typeof(Task), Member = "FinishStageTwo", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Task), Member = "ExecuteEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Task), Member = "HandleException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
		[Token(Token = "0x60013AD")]
		internal get { } //Length: 127
	}

	[Token(Token = "0x170001E6")]
	public override bool IsCompleted
	{
		[Address(RVA = "0x1538940", Offset = "0x1537B40", Length = "0x51")]
		[CallerCount(Count = 55)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60013B2")]
		 get { } //Length: 81
	}

	[Token(Token = "0x170001E7")]
	public bool IsCompletedSuccessfully
	{
		[Address(RVA = "0x1538910", Offset = "0x1537B10", Length = "0x23")]
		[CalledBy(Type = typeof(ValueTask`1), Member = "get_IsCompletedSuccessfully", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Task`1), Member = "get_Result", ReturnType = "TResult")]
		[CalledBy(Type = typeof(Task`1), Member = "GetResultCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "TResult")]
		[CalledBy(Type = typeof(TaskAwaiter), Member = "HandleNonSuccessAndDebuggerNotification", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60013B4")]
		 get { } //Length: 35
	}

	[Token(Token = "0x170001F4")]
	internal bool IsDelegateInvoked
	{
		[Address(RVA = "0x15389A0", Offset = "0x1537BA0", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60013CC")]
		internal get { } //Length: 29
	}

	[Token(Token = "0x170001F3")]
	internal bool IsExceptionObservedByParent
	{
		[Address(RVA = "0x15389C0", Offset = "0x1537BC0", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60013CB")]
		internal get { } //Length: 29
	}

	[Token(Token = "0x170001F1")]
	public bool IsFaulted
	{
		[Address(RVA = "0x15389E0", Offset = "0x1537BE0", Length = "0x1D")]
		[CalledBy(Type = "System.Net.Sockets.Socket+<>c__DisplayClass240_0", Member = "<BeginConnect>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Threading.Tasks.Task`1<IPAddress[]>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60013BE")]
		 get { } //Length: 29
	}

	[Token(Token = "0x170001DC")]
	internal bool IsWaitNotificationEnabled
	{
		[Address(RVA = "0x1538A30", Offset = "0x1537C30", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x600139E")]
		internal get { } //Length: 29
	}

	[Token(Token = "0x170001DA")]
	internal bool IsWaitNotificationEnabledOrNotRanToCompletion
	{
		[Address(RVA = "0x1538A00", Offset = "0x1537C00", Length = "0x23")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600139C")]
		internal get { } //Length: 35
	}

	[Token(Token = "0x170001D9")]
	internal TaskCreationOptions Options
	{
		[Address(RVA = "0x1538A50", Offset = "0x1537C50", Length = "0x4B")]
		[CalledBy(Type = typeof(Task), Member = "AssignCancellationToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(Task), typeof(TaskContinuation)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Task), Member = "ScheduleAndStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6001395")]
		internal get { } //Length: 75
	}

	[Token(Token = "0x170001DB")]
	internal override bool ShouldNotifyDebuggerOfWaitCompletion
	{
		[Address(RVA = "0x1538A30", Offset = "0x1537C30", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x600139D")]
		internal get { } //Length: 29
	}

	[Token(Token = "0x170001E1")]
	public TaskStatus Status
	{
		[Address(RVA = "0x1538AA0", Offset = "0x1537CA0", Length = "0x82")]
		[CalledBy(Type = typeof(UnwrapPromise`1), Member = "ProcessCompletedOuterTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UnwrapPromise`1), Member = "TrySetFromTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(TaskAwaiter), Member = "HandleNonSuccessAndDebuggerNotification", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TaskAwaiter), Member = "ThrowForNonSuccess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60013AB")]
		 get { } //Length: 130
	}

	[Token(Token = "0x170001E9")]
	private override WaitHandle System.IAsyncResult.AsyncWaitHandle
	{
		[Address(RVA = "0x15362C0", Offset = "0x15354C0", Length = "0x210")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ManualResetEventSlim), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(ManualResetEventSlim), Member = "get_WaitHandle", ReturnType = typeof(WaitHandle))]
		[Calls(Type = typeof(ManualResetEventSlim), Member = "Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(ManualResetEventSlim), Member = "Set", ReturnType = typeof(void))]
		[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(LazyInitializer), Member = "EnsureInitialized", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "System.Func`1<T>"}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60013B6")]
		private get { } //Length: 528
	}

	[Token(Token = "0x170001EB")]
	private override bool System.IAsyncResult.CompletedSynchronously
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x60013B8")]
		private get { } //Length: 3
	}

	[Address(RVA = "0x1537AB0", Offset = "0x1536CB0", Length = "0x404")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[Token(Token = "0x600140F")]
	private static Task() { }

	[Address(RVA = "0x1538030", Offset = "0x1537230", Length = "0xE7")]
	[CalledBy(Type = typeof(Task`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<Object, TResult>", typeof(object), typeof(CancellationToken), typeof(TaskCreationOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<TResult>", typeof(Task), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(InternalTaskOptions), typeof(TaskScheduler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(object), typeof(Task), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(InternalTaskOptions), typeof(TaskScheduler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task`1), Member = "StartNew", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), "System.Func`1<TResult>", typeof(CancellationToken), typeof(TaskCreationOptions), typeof(InternalTaskOptions), typeof(TaskScheduler)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[CalledBy(Type = typeof(ContinuationTaskFromResultTask`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Threading.Tasks.Task`1<TAntecedentResult>", typeof(Delegate), typeof(object), typeof(TaskCreationOptions), typeof(InternalTaskOptions)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Task), Member = "TaskConstructorCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(object), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(InternalTaskOptions), typeof(TaskScheduler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600138E")]
	internal Task(Delegate action, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	[Address(RVA = "0x1537EC0", Offset = "0x15370C0", Length = "0x94")]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "CheckDirectoryExistsWithTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Task), Member = "TaskConstructorCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(object), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(InternalTaskOptions), typeof(TaskScheduler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600138D")]
	public Task(Action action) { }

	[Address(RVA = "0x1537F60", Offset = "0x1537160", Length = "0xCC")]
	[CalledBy(Type = typeof(Task`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), "TResult", typeof(TaskCreationOptions), typeof(CancellationToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "FromCancellation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600138A")]
	internal Task(bool canceled, TaskCreationOptions creationOptions, CancellationToken ct) { }

	[Address(RVA = "0x1538120", Offset = "0x1537320", Length = "0x22")]
	[CalledBy(Type = typeof(TaskCompletionSource`1), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task`1), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AsyncVoidMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600138B")]
	internal Task() { }

	[Address(RVA = "0x1538150", Offset = "0x1537350", Length = "0x130")]
	[CalledBy(Type = typeof(Task`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(TaskCreationOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TaskFactory`1), Member = "FromAsyncImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`3<System.AsyncCallback, System.Object, System.IAsyncResult>), "System.Func`2<IAsyncResult, TResult>", typeof(System.Action`1<System.IAsyncResult>), typeof(object), typeof(TaskCreationOptions)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Task), Member = "TaskConstructorCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(object), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(InternalTaskOptions), typeof(TaskScheduler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600138C")]
	internal Task(object state, TaskCreationOptions creationOptions, bool promiseStyle) { }

	[Address(RVA = "0x1530210", Offset = "0x152F410", Length = "0x6A")]
	[CalledBy(Type = typeof(UnwrapPromise`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnwrapPromise`1), Member = "ProcessCompletedOuterTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnwrapPromise`1), Member = "ProcessInnerTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.Stream+ReadWriteTask", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(System.Func`2<System.Object, System.Int32>), typeof(object), typeof(Stream), typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Task), Member = "AddTaskContinuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60013F1")]
	internal void AddCompletionAction(ITaskCompletionAction action) { }

	[Address(RVA = "0x1530280", Offset = "0x152F480", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Task), Member = "AddTaskContinuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60013F2")]
	private void AddCompletionAction(ITaskCompletionAction action, bool addBeforeOthers) { }

	[Address(RVA = "0x1530300", Offset = "0x152F500", Length = "0x310")]
	[CalledBy(Type = typeof(Task), Member = "TrySetCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Task), Member = "TrySetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Task), Member = "AddException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "AddExceptionsFromChildren", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "HandleException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "RecordInternalCancellationRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TaskContinuation), Member = "InlineIfPossibleOrElseQueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ExceptionDispatchInfo), Member = "Capture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(ExceptionDispatchInfo))]
	[Calls(Type = typeof(TaskExceptionHolder), Member = "AddFaultException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(LazyInitializer), Member = "EnsureInitialized", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "System.Func`1<T>"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60013C5")]
	internal void AddException(object exceptionObject, bool representsCancellation) { }

	[Address(RVA = "0x1530620", Offset = "0x152F820", Length = "0xB")]
	[CalledBy(Type = typeof(Task), Member = "ScheduleAndStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Task), Member = "AddException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x60013C4")]
	internal void AddException(object exceptionObject) { }

	[Address(RVA = "0x1530630", Offset = "0x152F830", Length = "0x362")]
	[CalledBy(Type = typeof(Task), Member = "FinishStageTwo", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(TaskExceptionHolder), Member = "MarkAsHandled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(AggregateException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Runtime.ExceptionServices.ExceptionDispatchInfo>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "AddException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60013D1")]
	internal void AddExceptionsFromChildren() { }

	[Address(RVA = "0x15309A0", Offset = "0x152FBA0", Length = "0xF5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LazyInitializer), Member = "EnsureInitialized", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "System.Func`1<T>"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8C20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60013A1")]
	internal void AddNewChild() { }

	[Address(RVA = "0x1530D80", Offset = "0x152FF80", Length = "0xD1")]
	[CalledBy(Type = typeof(WhenAllPromise), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "SetContinuationForAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "SpinThenBlockingWait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Task), Member = "ContinueWithCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(TaskScheduler), typeof(CancellationToken), typeof(TaskContinuationOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "AddCompletionAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITaskCompletionAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "AddCompletionAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ITaskCompletionAction), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "InternalWhenAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task[])}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(TaskFactory), Member = "CommonCWAnyLogic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Threading.Tasks.Task>)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8AF0")]
	[Calls(Type = typeof(Task), Member = "AddTaskContinuationComplex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60013F4")]
	private bool AddTaskContinuation(object tc, bool addBeforeOthers) { }

	[Address(RVA = "0x1530AA0", Offset = "0x152FCA0", Length = "0x2D2")]
	[CalledBy(Type = typeof(Task), Member = "AddTaskContinuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LowLevelListWithIList`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(LowLevelList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8AF0")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LowLevelList`1), Member = "RemoveAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Predicate`1<T>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(LowLevelList`1), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60013F3")]
	private bool AddTaskContinuationComplex(object tc, bool addBeforeOthers) { }

	[Address(RVA = "0x1530E60", Offset = "0x1530060", Length = "0x13B")]
	[CalledBy(Type = typeof(AsyncMethodBuilderCore), Member = "PostBoxInitialization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine), typeof(MoveNextRunner), typeof(Task)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "get_Id", ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[FriendAccessAllowed]
	[Token(Token = "0x600140B")]
	internal static bool AddToActiveTasks(Task task) { }

	[Address(RVA = "0x1530FA0", Offset = "0x15301A0", Length = "0xA1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600139B")]
	internal static bool AnyTaskRequiresNotifyDebuggerOfWaitCompletion(Task[] tasks) { }

	[Address(RVA = "0x1531050", Offset = "0x1530250", Length = "0x2C8")]
	[CalledBy(Type = typeof(Task), Member = "TaskConstructorCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(object), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(InternalTaskOptions), typeof(TaskScheduler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "ContinueWithCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(TaskScheduler), typeof(CancellationToken), typeof(TaskContinuationOptions)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task), Member = "DisregardChild", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(Task), Member = "get_Options", ReturnType = typeof(TaskCreationOptions))]
	[Calls(Type = typeof(Task), Member = "InternalCancel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CancellationToken), Member = "InternalRegisterWithoutEC", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Object>), typeof(object)}, ReturnType = typeof(CancellationTokenRegistration))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Task), Member = "EnsureContingentPropertiesInitialized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ContingentProperties))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001390")]
	private void AssignCancellationToken(CancellationToken cancellationToken, Task antecedent, TaskContinuation continuation) { }

	[Address(RVA = "0x15313E0", Offset = "0x15305E0", Length = "0xB1")]
	[CalledBy(Type = typeof(Task), Member = "ScheduleAndStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task`1), Member = "TrySetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(WhenAllPromise), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "TrySetCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Task), Member = "TrySetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Task), Member = "SetNotificationForWaitCompletion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "MarkStarted", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Task), Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "InternalCancel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TaskContinuation), Member = "InlineIfPossibleOrElseQueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8A90")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(SpinWait), Member = "SpinOnce", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6001397")]
	internal bool AtomicStateUpdate(int newBits, int illegalBits) { }

	[Address(RVA = "0x1531320", Offset = "0x1530520", Length = "0xB2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8A90")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SpinWait), Member = "SpinOnce", ReturnType = typeof(void))]
	[Token(Token = "0x6001398")]
	internal bool AtomicStateUpdate(int newBits, int illegalBits, ref int oldFlags) { }

	[Address(RVA = "0x15314A0", Offset = "0x15306A0", Length = "0xC8")]
	[CalledBy(Type = typeof(Task), Member = "TrySetCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Task), Member = "ExecuteEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Task), Member = "InternalCancel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B90")]
	[Calls(Type = typeof(ManualResetEventSlim), Member = "Set", ReturnType = typeof(void))]
	[Calls(Type = typeof(ContingentProperties), Member = "UnregisterCancellationCallback", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1805F7760")]
	[Calls(Type = typeof(Task), Member = "FinishStageThree", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60013E7")]
	internal void CancellationCleanupLogic() { }

	[Address(RVA = "0x1531570", Offset = "0x1530770", Length = "0x20")]
	[CallerCount(Count = 36)]
	[Calls(Type = typeof(ConfiguredTaskAwaitable), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x60013D9")]
	public ConfiguredTaskAwaitable ConfigureAwait(bool continueOnCapturedContext) { }

	[Address(RVA = "0x1531800", Offset = "0x1530A00", Length = "0x29")]
	[CalledBy(Type = typeof(Stream), Member = "RunReadWriteTaskWhenReady", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), "System.IO.Stream+ReadWriteTask"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Task), Member = "ContinueWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<System.Threading.Tasks.Task, System.Object>), typeof(object), typeof(TaskScheduler), typeof(CancellationToken), typeof(TaskContinuationOptions)}, ReturnType = typeof(Task))]
	[Token(Token = "0x60013ED")]
	public Task ContinueWith(Action<Task, Object> continuationAction, object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }

	[Address(RVA = "0x15318A0", Offset = "0x1530AA0", Length = "0x299")]
	[CalledBy(Type = typeof(Task), Member = "ContinueWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Threading.Tasks.Task>)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Task), Member = "CreationOptionsFromContinuationOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskContinuationOptions), typeof(TaskCreationOptions&), typeof(InternalTaskOptions&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Task), Member = "TaskConstructorCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(object), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(InternalTaskOptions), typeof(TaskScheduler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "ContinueWithCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(TaskScheduler), typeof(CancellationToken), typeof(TaskContinuationOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60013EC")]
	private Task ContinueWith(Action<Task> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions) { }

	[Address(RVA = "0x1531B40", Offset = "0x1530D40", Length = "0x29B")]
	[CalledBy(Type = typeof(Task), Member = "ContinueWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<System.Threading.Tasks.Task, System.Object>), typeof(object), typeof(CancellationToken), typeof(TaskContinuationOptions), typeof(TaskScheduler)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Task), Member = "CreationOptionsFromContinuationOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskContinuationOptions), typeof(TaskCreationOptions&), typeof(InternalTaskOptions&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Task), Member = "TaskConstructorCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(object), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(InternalTaskOptions), typeof(TaskScheduler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "ContinueWithCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(TaskScheduler), typeof(CancellationToken), typeof(TaskContinuationOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60013EE")]
	private Task ContinueWith(Action<Task, Object> continuationAction, object state, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions) { }

	[Address(RVA = "0x1531830", Offset = "0x1530A30", Length = "0x6E")]
	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "QueueIOSelectorJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SemaphoreSlim), typeof(IntPtr), "System.IOSelectorJob"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TaskScheduler), Member = "get_Current", ReturnType = typeof(TaskScheduler))]
	[Calls(Type = typeof(Task), Member = "ContinueWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Threading.Tasks.Task>), typeof(TaskScheduler), typeof(CancellationToken), typeof(TaskContinuationOptions)}, ReturnType = typeof(Task))]
	[Token(Token = "0x60013EB")]
	public Task ContinueWith(Action<Task> continuationAction) { }

	[Address(RVA = "0x1531590", Offset = "0x1530790", Length = "0x261")]
	[CalledBy(Type = typeof(Task`1), Member = "ContinueWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<Task`1<TResult>>", typeof(TaskScheduler)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(Task`1), Member = "ContinueWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<Task`1<TResult>>", typeof(TaskScheduler), typeof(CancellationToken), typeof(TaskContinuationOptions)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(Task`1), Member = "ContinueWith", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TNewResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<Task`1<TResult>, TNewResult>", typeof(TaskContinuationOptions)}, ReturnType = "System.Threading.Tasks.Task`1<TNewResult>")]
	[CalledBy(Type = typeof(Task`1), Member = "ContinueWith", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TNewResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<Task`1<TResult>, TNewResult>", typeof(TaskScheduler), typeof(CancellationToken), typeof(TaskContinuationOptions)}, ReturnType = "System.Threading.Tasks.Task`1<TNewResult>")]
	[CalledBy(Type = typeof(Task), Member = "ContinueWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Threading.Tasks.Task>), typeof(TaskScheduler), typeof(CancellationToken), typeof(TaskContinuationOptions)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(Task), Member = "ContinueWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<System.Threading.Tasks.Task, System.Object>), typeof(object), typeof(TaskScheduler), typeof(CancellationToken), typeof(TaskContinuationOptions)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Task), Member = "AssignCancellationToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(Task), typeof(TaskContinuation)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1805F76D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Task), Member = "AddTaskContinuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60013F0")]
	internal void ContinueWithCore(Task continuationTask, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions options) { }

	[Address(RVA = "0x1531DE0", Offset = "0x1530FE0", Length = "0x159")]
	[CalledBy(Type = typeof(Task`1), Member = "ContinueWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<Task`1<TResult>>", typeof(TaskScheduler)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(Task`1), Member = "ContinueWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<Task`1<TResult>>", typeof(TaskScheduler), typeof(CancellationToken), typeof(TaskContinuationOptions)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(Task`1), Member = "ContinueWith", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TNewResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<Task`1<TResult>, TNewResult>", typeof(TaskContinuationOptions)}, ReturnType = "System.Threading.Tasks.Task`1<TNewResult>")]
	[CalledBy(Type = typeof(Task`1), Member = "ContinueWith", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TNewResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<Task`1<TResult>, TNewResult>", typeof(TaskScheduler), typeof(CancellationToken), typeof(TaskContinuationOptions)}, ReturnType = "System.Threading.Tasks.Task`1<TNewResult>")]
	[CalledBy(Type = typeof(Task), Member = "ContinueWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Threading.Tasks.Task>), typeof(TaskScheduler), typeof(CancellationToken), typeof(TaskContinuationOptions)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(Task), Member = "ContinueWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<System.Threading.Tasks.Task, System.Object>), typeof(object), typeof(TaskScheduler), typeof(CancellationToken), typeof(TaskContinuationOptions)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60013EF")]
	internal static void CreationOptionsFromContinuationOptions(TaskContinuationOptions continuationOptions, out TaskCreationOptions creationOptions, out InternalTaskOptions internalOptions) { }

	[Address(RVA = "0x1531F90", Offset = "0x1531190", Length = "0x5DE")]
	[CalledBy(Type = "System.Threading.SemaphoreSlim+<WaitUntilCountOrTimeoutAsync>d__32", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.ServicePointScheduler+<WaitAsync>d__46", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebRequestStream+<WriteChunkTrailer>d__40", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebResponseStream+<ReadAllAsync>d__48", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1805F76D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Task), Member = "FromCancellation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181450470")]
	[Calls(Type = typeof(Timer), Member = "Change", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(long), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CancellationToken), Member = "InternalRegisterWithoutEC", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Object>), typeof(object)}, ReturnType = typeof(CancellationTokenRegistration))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6001405")]
	public static Task Delay(int millisecondsDelay, CancellationToken cancellationToken) { }

	[Address(RVA = "0x1531F40", Offset = "0x1531140", Length = "0x4A")]
	[CalledBy(Type = "System.Net.ServicePointScheduler", Member = "OperationCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.ServicePointScheduler+ConnectionGroup", "System.Net.WebOperation"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6001404")]
	public static Task Delay(int millisecondsDelay) { }

	[Address(RVA = "0x15326E0", Offset = "0x15318E0", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60013C1")]
	public override void Dispose() { }

	[Address(RVA = "0x1532570", Offset = "0x1531770", Length = "0x169")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ManualResetEventSlim), Member = "get_IsSet", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ManualResetEventSlim), Member = "Set", ReturnType = typeof(void))]
	[Calls(Type = typeof(ManualResetEventSlim), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60013C2")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x1532750", Offset = "0x1531950", Length = "0xB2")]
	[CalledBy(Type = typeof(Task), Member = "AssignCancellationToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(Task), typeof(TaskContinuation)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LazyInitializer), Member = "EnsureInitialized", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "System.Func`1<T>"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60013A2")]
	internal void DisregardChild() { }

	[Address(RVA = "0x1532900", Offset = "0x1531B00", Length = "0xFA")]
	[CalledBy(Type = typeof(Task), Member = "TaskConstructorCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(object), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(InternalTaskOptions), typeof(TaskScheduler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "AssignCancellationToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(Task), typeof(TaskContinuation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "set_CapturedContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LazyInitializer), Member = "EnsureInitialized", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "System.Func`1<T>"}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60013AE")]
	internal ContingentProperties EnsureContingentPropertiesInitialized(bool needsProtection) { }

	[Address(RVA = "0x1532810", Offset = "0x1531A10", Length = "0xE8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LazyInitializer), Member = "EnsureInitialized", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "System.Func`1<T>"}, ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60013AF")]
	private ContingentProperties EnsureContingentPropertiesInitializedCore(bool needsProtection) { }

	[Address(RVA = "0x1532DD0", Offset = "0x1531FD0", Length = "0x3A")]
	[CalledBy(Type = typeof(Task), Member = "ExecutionContextCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "ExecuteWithThreadLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Task), Member = "HandleException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60013D2")]
	private void Execute() { }

	[Address(RVA = "0x1532A00", Offset = "0x1531C00", Length = "0x1B0")]
	[CalledBy(Type = typeof(Task), Member = "System.Threading.IThreadPoolWorkItem.ExecuteWorkItem", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.Tasks.ThreadPoolTaskScheduler+<>c", Member = "<.cctor>b__10_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadPoolTaskScheduler), Member = "TryExecuteTaskInline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(SpinWait), Member = "SpinOnce", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8A90")]
	[Calls(Type = typeof(Task), Member = "ExecuteWithThreadLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(Task), Member = "CancellationCleanupLogic", ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B90")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60013D4")]
	internal bool ExecuteEntry(bool bPreventDoubleExecution) { }

	[Address(RVA = "0x1532BB0", Offset = "0x1531DB0", Length = "0x21C")]
	[CalledBy(Type = typeof(Task), Member = "ExecuteEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ExecutionContext), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext), typeof(ContextCallback), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "Execute", ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600140E")]
	private void ExecuteWithThreadLocal(ref Task currentTaskSlot) { }

	[Address(RVA = "0x1532E10", Offset = "0x1532010", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Task), Member = "Execute", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60013D5")]
	private static void ExecutionContextCallback(object obj) { }

	[Address(RVA = "0x1533620", Offset = "0x1532820", Length = "0x175")]
	[CalledBy(Type = typeof(Task), Member = "TrySetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Task), Member = "ScheduleAndStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "ExecuteWithThreadLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TaskContinuation), Member = "InlineIfPossibleOrElseQueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(LowLevelList`1), Member = "RemoveAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Predicate`1<T>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "FinishStageTwo", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B70")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Task), Member = "AtomicStateUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60013CD")]
	internal void Finish(bool bUserDelegateExecuted) { }

	[Address(RVA = "0x1532EA0", Offset = "0x15320A0", Length = "0x583")]
	[CalledBy(Type = typeof(Task), Member = "FinishStageThree", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(ThreadPool), Member = "UnsafeQueueCustomWorkItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(LowLevelList`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LowLevelList`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1815215E0")]
	[Calls(Type = typeof(AwaitTaskContinuation), Member = "RunOrScheduleAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(bool), typeof(Task&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8BC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60013E9")]
	internal void FinishContinuations() { }

	[Address(RVA = "0x1533430", Offset = "0x1532630", Length = "0xA3")]
	[CalledBy(Type = typeof(Task`1), Member = "TrySetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Task), Member = "FinishStageTwo", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "CancellationCleanupLogic", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Task), Member = "ProcessChildCompletion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "FinishContinuations", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60013CF")]
	internal void FinishStageThree() { }

	[Address(RVA = "0x15334E0", Offset = "0x15326E0", Length = "0x13F")]
	[CalledBy(Type = typeof(Task), Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "ProcessChildCompletion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Task), Member = "AddExceptionsFromChildren", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Task), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1805F7760")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B90")]
	[Calls(Type = typeof(ManualResetEventSlim), Member = "Set", ReturnType = typeof(void))]
	[Calls(Type = typeof(ContingentProperties), Member = "UnregisterCancellationCallback", ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "FinishStageThree", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60013CE")]
	internal void FinishStageTwo() { }

	[Address(RVA = "0x15337A0", Offset = "0x15329A0", Length = "0x49")]
	[CalledBy(Type = "System.IO.Stream+NullStream", Member = "CopyToAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(MemoryStream), Member = "CopyToAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(MemoryStream), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(MemoryStream), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlyMemory`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(ValueTask))]
	[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlyMemory`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(ValueTask))]
	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "SendAsyncForNetworkStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlyMemory`1<Byte>", "System.Net.Sockets.SocketFlags", typeof(CancellationToken)}, ReturnType = typeof(ValueTask))]
	[CalledBy(Type = "System.IO.Stream+NullStream", Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = "System.IO.Stream+NullStream", Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlyMemory`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(ValueTask))]
	[CalledBy(Type = typeof(Stream), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = "System.Net.WebRequestStream", Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60013FA")]
	public static Task FromCanceled(CancellationToken cancellationToken) { }

	[Address(RVA = "0x76B060", Offset = "0x76A260", Length = "0x139")]
	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "ReceiveAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Memory`1<Byte>", "System.Net.Sockets.SocketFlags", typeof(bool), typeof(CancellationToken)}, ReturnType = "System.Threading.Tasks.ValueTask`1<Int32>")]
	[CalledBy(Type = typeof(ValueTask`1), Member = "GetTaskForValueTaskSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Threading.Tasks.Sources.IValueTaskSource`1<TResult>"}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[CalledBy(Type = typeof(MemoryStream), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[CalledBy(Type = typeof(MemoryStream), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Memory`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.ValueTask`1<System.Int32>))]
	[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Memory`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.ValueTask`1<System.Int32>))]
	[CalledBy(Type = typeof(Stream), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[CalledBy(Type = "System.Net.WebResponseStream", Member = "ProcessRead", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = "System.Threading.Tasks.Task`1<Int32>")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(System.Threading.Tasks.Task`1<System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(TaskCreationOptions), typeof(CancellationToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x60013FC")]
	public static Task<TResult> FromCanceled(CancellationToken cancellationToken) { }

	[Address(RVA = "0x76B630", Offset = "0x76A830", Length = "0xCB")]
	[CalledBy(Type = typeof(MemoryStream), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[CalledBy(Type = typeof(MemoryStream), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Memory`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.ValueTask`1<System.Int32>))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Threading.Tasks.Task`1<System.Int32>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "TrySetCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60013FD")]
	internal static Task<TResult> FromCancellation(OperationCanceledException exception) { }

	[Address(RVA = "0x76B1A0", Offset = "0x76A3A0", Length = "0xF8")]
	[CalledBy(Type = typeof(SemaphoreSlim), Member = "WaitAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Threading.Tasks.Task`1<System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(TaskCreationOptions), typeof(CancellationToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x60013FB")]
	internal static Task<TResult> FromCancellation(CancellationToken cancellationToken) { }

	[Address(RVA = "0x15337F0", Offset = "0x15329F0", Length = "0xE7")]
	[CalledBy(Type = typeof(ValueTask), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<System.Threading.Tasks.Task>), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(Task), Member = "Delay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Task), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(TaskCreationOptions), typeof(CancellationToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60013F9")]
	internal static Task FromCancellation(CancellationToken cancellationToken) { }

	[Address(RVA = "0x15338E0", Offset = "0x1532AE0", Length = "0x5A")]
	[CalledBy(Type = typeof(ValueTask), Member = "GetTaskForValueTaskSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IValueTaskSource)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(MemoryStream), Member = "CopyToAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(MemoryStream), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(MemoryStream), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlyMemory`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(ValueTask))]
	[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlyMemory`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(ValueTask))]
	[CalledBy(Type = "System.Net.WebResponseStream", Member = "WriteAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[CalledBy(Type = "System.Net.Sockets.Socket+AwaitableSocketAsyncEventArgs", Member = "SendAsyncForNetworkStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Sockets.Socket"}, ReturnType = typeof(ValueTask))]
	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "SendAsyncForNetworkStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ReadOnlyMemory`1<Byte>", "System.Net.Sockets.SocketFlags", typeof(CancellationToken)}, ReturnType = typeof(ValueTask))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Task), Member = "FromException", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VoidTaskResult)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult>))]
	[Token(Token = "0x60013F7")]
	public static Task FromException(Exception exception) { }

	[Address(RVA = "0x76B9A0", Offset = "0x76ABA0", Length = "0xC4")]
	[CalledBy(Type = "System.Net.Sockets.Socket", Member = "ReceiveAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Memory`1<Byte>", "System.Net.Sockets.SocketFlags", typeof(bool), typeof(CancellationToken)}, ReturnType = "System.Threading.Tasks.ValueTask`1<Int32>")]
	[CalledBy(Type = typeof(ValueTask`1), Member = "GetTaskForValueTaskSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Threading.Tasks.Sources.IValueTaskSource`1<TResult>"}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[CalledBy(Type = typeof(MemoryStream), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[CalledBy(Type = typeof(MemoryStream), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Memory`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.ValueTask`1<System.Int32>))]
	[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Memory`1<System.Byte>), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.ValueTask`1<System.Int32>))]
	[CalledBy(Type = "System.Net.WebRequestStream", Member = "ReadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int), typeof(CancellationToken)}, ReturnType = "System.Threading.Tasks.Task`1<Int32>")]
	[CalledBy(Type = "System.Net.Sockets.Socket+AwaitableSocketAsyncEventArgs", Member = "ReceiveAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Sockets.Socket"}, ReturnType = "System.Threading.Tasks.ValueTask`1<Int32>")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Task), Member = "TrySetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Threading.Tasks.Task`1<System.Int32>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[DeduplicatedMethod]
	[Token(Token = "0x60013F8")]
	public static Task<TResult> FromException(Exception exception) { }

	[Address(RVA = "0x76BB40", Offset = "0x76AD40", Length = "0x6F")]
	[CalledBy(Type = "System.Xml.AsyncHelper", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Threading.Tasks.Task`1<System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60013F6")]
	public static Task<TResult> FromResult(TResult result) { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013B7")]
	public override object get_AsyncState() { }

	[Address(RVA = "0x1538290", Offset = "0x1537490", Length = "0x26")]
	[CalledBy(Type = typeof(UnwrapPromise`1), Member = "TrySetFromTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Token(Token = "0x60013B0")]
	internal CancellationToken get_CancellationToken() { }

	[Address(RVA = "0x15382C0", Offset = "0x15374C0", Length = "0x74")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60013BF")]
	internal ExecutionContext get_CapturedContext() { }

	[Address(RVA = "0x1538340", Offset = "0x1537540", Length = "0x19E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LazyInitializer), Member = "EnsureInitialized", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "System.Func`1<T>"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ManualResetEventSlim), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ManualResetEventSlim), Member = "Set", ReturnType = typeof(void))]
	[Calls(Type = typeof(ManualResetEventSlim), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60013BC")]
	internal ManualResetEventSlim get_CompletedEvent() { }

	[Address(RVA = "0x15384E0", Offset = "0x15376E0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[Token(Token = "0x60013BB")]
	public static Task get_CompletedTask() { }

	[Address(RVA = "0x1538530", Offset = "0x1537730", Length = "0x4B")]
	[CalledBy(Type = typeof(Task), Member = "TaskConstructorCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(object), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(InternalTaskOptions), typeof(TaskScheduler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnwrapPromise`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60013B5")]
	public TaskCreationOptions get_CreationOptions() { }

	[Address(RVA = "0x1538580", Offset = "0x1537780", Length = "0xBE")]
	[CalledBy(Type = typeof(UnwrapPromise`1), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60013A9")]
	internal static StackGuard get_CurrentStackGuard() { }

	[Address(RVA = "0x15386B0", Offset = "0x15378B0", Length = "0x41")]
	[CalledBy(Type = typeof(TaskAwaiter), Member = "HandleNonSuccessAndDebuggerNotification", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TaskAwaiter), Member = "ThrowForNonSuccess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.HttpWebRequest+<>c__241`1", Member = "<RunWithTimeoutWorker>b__241_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Threading.Tasks.Task`1<T>"}, ReturnType = "System.Nullable`1<Int32>")]
	[CalledBy(Type = "System.Net.Sockets.Socket+<>c__DisplayClass240_0", Member = "<BeginConnect>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Threading.Tasks.Task`1<IPAddress[]>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Task), Member = "GetExceptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(AggregateException))]
	[Token(Token = "0x60013AA")]
	public AggregateException get_Exception() { }

	[Address(RVA = "0x1538640", Offset = "0x1537840", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60013BD")]
	internal bool get_ExceptionRecorded() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013B9")]
	internal TaskScheduler get_ExecutingTaskScheduler() { }

	[Address(RVA = "0x1538700", Offset = "0x1537900", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[Token(Token = "0x60013BA")]
	public static TaskFactory get_Factory() { }

	[Address(RVA = "0x1538750", Offset = "0x1537950", Length = "0x96")]
	[CalledBy(Type = "System.Runtime.CompilerServices.TaskAwaiter+<>c__DisplayClass11_0", Member = "<OutputWaitEtwEvents>b__0", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DebuggerSupport), Member = "AddToActiveTasksNonInlined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DebuggerSupport), Member = "RemoveFromActiveTasksNonInlined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "AddToActiveTasks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ThreadPoolTaskScheduler), Member = "QueueTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TaskAwaiter), Member = "OutputWaitEtwEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(Action)}, ReturnType = typeof(Action))]
	[CalledBy(Type = typeof(Task), Member = "InternalWait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(AsyncVoidMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Runtime.CompilerServices.AsyncMethodBuilderCore+<>c__DisplayClass5_0", Member = "<OutputAsyncCausalityEvents>b__0", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AsyncMethodBuilderCore), Member = "PostBoxInitialization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine), typeof(MoveNextRunner), typeof(Task)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AsyncVoidMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AsyncVoidMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 22)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8A90")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8C20")]
	[Token(Token = "0x60013A6")]
	public int get_Id() { }

	[Address(RVA = "0x15387F0", Offset = "0x15379F0", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Token(Token = "0x60013A7")]
	internal static Task get_InternalCurrent() { }

	[Address(RVA = "0x1538840", Offset = "0x1537A40", Length = "0x23")]
	[CalledBy(Type = "System.Net.Sockets.Socket+<>c__DisplayClass240_0", Member = "<BeginConnect>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Threading.Tasks.Task`1<IPAddress[]>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60013AC")]
	public bool get_IsCanceled() { }

	[Address(RVA = "0x1538870", Offset = "0x1537A70", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60013B1")]
	internal bool get_IsCancellationAcknowledged() { }

	[Address(RVA = "0x1538890", Offset = "0x1537A90", Length = "0x7F")]
	[CalledBy(Type = typeof(Task), Member = "FinishStageTwo", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "ExecuteEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Task), Member = "HandleException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Token(Token = "0x60013AD")]
	internal bool get_IsCancellationRequested() { }

	[Address(RVA = "0x1538940", Offset = "0x1537B40", Length = "0x51")]
	[CallerCount(Count = 55)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60013B2")]
	public override bool get_IsCompleted() { }

	[Address(RVA = "0x1538910", Offset = "0x1537B10", Length = "0x23")]
	[CalledBy(Type = typeof(ValueTask`1), Member = "get_IsCompletedSuccessfully", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Task`1), Member = "get_Result", ReturnType = "TResult")]
	[CalledBy(Type = typeof(Task`1), Member = "GetResultCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "TResult")]
	[CalledBy(Type = typeof(TaskAwaiter), Member = "HandleNonSuccessAndDebuggerNotification", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60013B4")]
	public bool get_IsCompletedSuccessfully() { }

	[Address(RVA = "0x15389A0", Offset = "0x1537BA0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60013CC")]
	internal bool get_IsDelegateInvoked() { }

	[Address(RVA = "0x15389C0", Offset = "0x1537BC0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60013CB")]
	internal bool get_IsExceptionObservedByParent() { }

	[Address(RVA = "0x15389E0", Offset = "0x1537BE0", Length = "0x1D")]
	[CalledBy(Type = "System.Net.Sockets.Socket+<>c__DisplayClass240_0", Member = "<BeginConnect>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Threading.Tasks.Task`1<IPAddress[]>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60013BE")]
	public bool get_IsFaulted() { }

	[Address(RVA = "0x1538A30", Offset = "0x1537C30", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600139E")]
	internal bool get_IsWaitNotificationEnabled() { }

	[Address(RVA = "0x1538A00", Offset = "0x1537C00", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600139C")]
	internal bool get_IsWaitNotificationEnabledOrNotRanToCompletion() { }

	[Address(RVA = "0x1538A50", Offset = "0x1537C50", Length = "0x4B")]
	[CalledBy(Type = typeof(Task), Member = "AssignCancellationToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(Task), typeof(TaskContinuation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "ScheduleAndStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6001395")]
	internal TaskCreationOptions get_Options() { }

	[Address(RVA = "0x1538A30", Offset = "0x1537C30", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600139D")]
	internal override bool get_ShouldNotifyDebuggerOfWaitCompletion() { }

	[Address(RVA = "0x1538AA0", Offset = "0x1537CA0", Length = "0x82")]
	[CalledBy(Type = typeof(UnwrapPromise`1), Member = "ProcessCompletedOuterTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnwrapPromise`1), Member = "TrySetFromTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TaskAwaiter), Member = "HandleNonSuccessAndDebuggerNotification", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TaskAwaiter), Member = "ThrowForNonSuccess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60013AB")]
	public TaskStatus get_Status() { }

	[Address(RVA = "0x152D750", Offset = "0x152C950", Length = "0x20")]
	[CallerCount(Count = 52)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60013D8")]
	public TaskAwaiter GetAwaiter() { }

	[Address(RVA = "0x1533940", Offset = "0x1532B40", Length = "0x34")]
	[CalledBy(Type = typeof(UnwrapPromise`1), Member = "TrySetFromTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TaskAwaiter), Member = "HandleNonSuccessAndDebuggerNotification", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TaskAwaiter), Member = "ThrowForNonSuccess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Token(Token = "0x60013C8")]
	internal ExceptionDispatchInfo GetCancellationExceptionDispatchInfo() { }

	[Address(RVA = "0x1533980", Offset = "0x1532B80", Length = "0x218")]
	[CalledBy(Type = typeof(WhenAllPromise), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnwrapPromise`1), Member = "TrySetFromTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TaskAwaiter), Member = "HandleNonSuccessAndDebuggerNotification", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TaskAwaiter), Member = "ThrowForNonSuccess", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ReadOnlyCollection`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IList`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60013C7")]
	internal ReadOnlyCollection<ExceptionDispatchInfo> GetExceptionDispatchInfos() { }

	[Address(RVA = "0x1533BA0", Offset = "0x1532DA0", Length = "0x1F7")]
	[CalledBy(Type = typeof(Task), Member = "get_Exception", ReturnType = typeof(AggregateException))]
	[CalledBy(Type = typeof(Task), Member = "ThrowIfExceptional", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "Wait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(OperationCanceledException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CancellationToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(AggregateException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TaskExceptionHolder), Member = "CreateExceptionObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Exception)}, ReturnType = typeof(AggregateException))]
	[Token(Token = "0x60013C6")]
	private AggregateException GetExceptions(bool includeTaskCanceledExceptions) { }

	[Address(RVA = "0x1533DA0", Offset = "0x1532FA0", Length = "0x10D")]
	[CalledBy(Type = typeof(Task), Member = "Execute", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Task), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CancellationToken), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task), Member = "AddException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60013D7")]
	private void HandleException(Exception unhandledException) { }

	[Address(RVA = "0x1533EB0", Offset = "0x15330B0", Length = "0x96")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60013D6")]
	internal override void InnerInvoke() { }

	[Address(RVA = "0x1533F50", Offset = "0x1533150", Length = "0x1CC")]
	[CalledBy(Type = typeof(Task), Member = "AssignCancellationToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(Task), typeof(TaskContinuation)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "TaskCancelCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StandardTaskContinuation), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TaskSchedulerException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "AtomicStateUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task), Member = "RecordInternalCancellationRequest", ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "CancellationCleanupLogic", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60013E3")]
	internal bool InternalCancel(bool bCancelNonExecutingOnly) { }

	[Address(RVA = "0x1534120", Offset = "0x1533320", Length = "0x8C")]
	[CalledBy(Type = typeof(Task`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<Object, TResult>", typeof(object), typeof(CancellationToken), typeof(TaskCreationOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "Run", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<Task`1<TResult>>", typeof(CancellationToken)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[CalledBy(Type = typeof(ContinuationTaskFromTask), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(Delegate), typeof(object), typeof(TaskCreationOptions), typeof(InternalTaskOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContinuationTaskFromResultTask`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Threading.Tasks.Task`1<TAntecedentResult>", typeof(Delegate), typeof(object), typeof(TaskCreationOptions), typeof(InternalTaskOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContinuationResultTaskFromResultTask`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Threading.Tasks.Task`1<TAntecedentResult>", typeof(Delegate), typeof(object), typeof(TaskCreationOptions), typeof(InternalTaskOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TaskFactory), Member = "StartNew", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(TaskScheduler)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(TaskFactory), Member = "StartNew", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Object>), typeof(object), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(TaskScheduler)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(TaskFactory), Member = "StartNew", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<TResult>", typeof(CancellationToken), typeof(TaskCreationOptions), typeof(TaskScheduler)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[CalledBy(Type = typeof(TaskFactory), Member = "StartNew", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`2<Object, TResult>", typeof(object), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(TaskScheduler)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Token(Token = "0x60013A8")]
	internal static Task InternalCurrentIfAttached(TaskCreationOptions creationOptions) { }

	[Address(RVA = "0x15341B0", Offset = "0x15333B0", Length = "0x193")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Task), Member = "TaskConstructorCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(object), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(InternalTaskOptions), typeof(TaskScheduler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "ScheduleAndStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60013A5")]
	internal static Task InternalStartNew(Task creatingTask, Delegate action, object state, CancellationToken cancellationToken, TaskScheduler scheduler, TaskCreationOptions options, InternalTaskOptions internalOptions) { }

	[Address(RVA = "0x1534350", Offset = "0x1533550", Length = "0x4C3")]
	[CalledBy(Type = typeof(Task`1), Member = "get_Result", ReturnType = "TResult")]
	[CalledBy(Type = typeof(Task`1), Member = "GetResultCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "TResult")]
	[CalledBy(Type = typeof(Task), Member = "Wait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TaskAwaiter), Member = "HandleNonSuccessAndDebuggerNotification", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1813B4ED0")]
	[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TaskTrace), Member = "TaskWaitBegin_Synchronous", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "get_Id", ReturnType = typeof(int))]
	[Calls(Type = typeof(TaskScheduler), Member = "get_Id", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(TaskTrace), Member = "TaskWaitEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "WrappedTryRunInline", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TaskTrace), Member = "get_Enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180756400")]
	[Calls(Type = typeof(Task), Member = "SpinThenBlockingWait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60013E0")]
	internal bool InternalWait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	[Address(RVA = "0x1534820", Offset = "0x1533A20", Length = "0x252")]
	[CalledBy(Type = typeof(Task), Member = "WhenAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task>)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(Task), Member = "WhenAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task[])}, ReturnType = typeof(Task))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(WhenAllPromise), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(Task), Member = "AddTaskContinuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1805F76D0")]
	[Token(Token = "0x6001408")]
	private static Task InternalWhenAll(Task[] tasks) { }

	[Address(RVA = "0x1534A80", Offset = "0x1533C80", Length = "0xA")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60013B3")]
	private static bool IsCompletedMethod(int flags) { }

	[Address(RVA = "0x1534A90", Offset = "0x1533C90", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60013EA")]
	private void LogFinishCompletionNotification() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600140D")]
	public override void MarkAborted(ThreadAbortException e) { }

	[Address(RVA = "0x1534AD0", Offset = "0x1533CD0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Task), Member = "AtomicStateUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60013A0")]
	internal bool MarkStarted() { }

	[Address(RVA = "0x1534B50", Offset = "0x1533D50", Length = "0x23")]
	[CalledBy(Type = typeof(Task), Member = "NotifyDebuggerOfWaitCompletionIfNecessary", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ContinuationTaskFromTask), Member = "InnerInvoke", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Task), Member = "SetNotificationForWaitCompletion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x600139F")]
	private void NotifyDebuggerOfWaitCompletion() { }

	[Address(RVA = "0x1534AF0", Offset = "0x1533CF0", Length = "0x5B")]
	[CalledBy(Type = typeof(Task`1), Member = "get_Result", ReturnType = "TResult")]
	[CalledBy(Type = typeof(Task`1), Member = "GetResultCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "TResult")]
	[CalledBy(Type = typeof(Task), Member = "Wait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ContinuationTaskFromResultTask`1), Member = "InnerInvoke", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ContinuationResultTaskFromResultTask`2), Member = "InnerInvoke", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TaskAwaiter), Member = "HandleNonSuccessAndDebuggerNotification", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Task), Member = "NotifyDebuggerOfWaitCompletion", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600139A")]
	internal bool NotifyDebuggerOfWaitCompletionIfNecessary() { }

	[Address(RVA = "0x124F2A0", Offset = "0x124E4A0", Length = "0x4")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001396")]
	internal static TaskCreationOptions OptionsMethod(int flags) { }

	[Address(RVA = "0x1534B80", Offset = "0x1533D80", Length = "0x1CA")]
	[CalledBy(Type = typeof(Task), Member = "FinishStageThree", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(LowLevelListWithIList`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LowLevelList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B70")]
	[Calls(Type = typeof(Task), Member = "FinishStageTwo", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x60013D0")]
	internal void ProcessChildCompletion(Task childTask) { }

	[Address(RVA = "0x1534E10", Offset = "0x1534010", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Task), Member = "RecordInternalCancellationRequest", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CancellationToken), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60013E5")]
	internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord) { }

	[Address(RVA = "0x1534EA0", Offset = "0x15340A0", Length = "0xB1")]
	[CalledBy(Type = typeof(Task), Member = "TrySetCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Task), Member = "InternalCancel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Task), Member = "RecordInternalCancellationRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "RecordInternalCancellationRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LazyInitializer), Member = "EnsureInitialized", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "System.Func`1<T>"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60013E4")]
	internal void RecordInternalCancellationRequest() { }

	[Address(RVA = "0x1534D50", Offset = "0x1533F50", Length = "0xB6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Task), Member = "RecordInternalCancellationRequest", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CancellationToken), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Task), Member = "AddException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60013E6")]
	internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord, object cancellationException) { }

	[Address(RVA = "0x1534F60", Offset = "0x1534160", Length = "0x255")]
	[CalledBy(Type = typeof(__ComObject), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "TaskCancelCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CompleteOnInvokePromise), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TaskFactory), Member = "CommonCWAnyLogic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Threading.Tasks.Task>)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(LowLevelList`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LowLevelList`1), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8AF0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(LowLevelListWithIList`1), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x60013F5")]
	internal void RemoveContinuation(object continuationObject) { }

	[Address(RVA = "0x15351C0", Offset = "0x15343C0", Length = "0x114")]
	[CalledBy(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[FriendAccessAllowed]
	[Token(Token = "0x600140C")]
	internal static void RemoveFromActiveTasks(int taskId) { }

	[Address(RVA = "0x76C2A0", Offset = "0x76B4A0", Length = "0x63")]
	[CalledBy(Type = "System.Net.WebRequest", Member = "GetRequestStreamAsync", ReturnType = "System.Threading.Tasks.Task`1<Stream>")]
	[CalledBy(Type = "System.Net.WebRequest", Member = "GetResponseAsync", ReturnType = "System.Threading.Tasks.Task`1<WebResponse>")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsInvalidInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6001402")]
	public static Task<TResult> Run(Func<Task`1<TResult>> function) { }

	[Address(RVA = "0x76C100", Offset = "0x76B300", Length = "0xC1")]
	[CalledBy(Type = "Mono.Net.Security.MobileAuthenticatedStream+<InnerRead>d__66", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Threading.Tasks.Task`1<System.Int32>), Member = "StartNew", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(System.Func`1<System.Int32>), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(InternalTaskOptions), typeof(TaskScheduler)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[DeduplicatedMethod]
	[Token(Token = "0x60013FF")]
	public static Task<TResult> Run(Func<TResult> function) { }

	[Address(RVA = "0x15354C0", Offset = "0x15346C0", Length = "0x4C")]
	[CalledBy(Type = "System.Net.ServicePointScheduler", Member = "Run", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6001400")]
	public static Task Run(Func<Task> function) { }

	[Address(RVA = "0x1535510", Offset = "0x1534710", Length = "0x233")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TaskFactory), Member = "StartNew", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`1<TResult>", typeof(CancellationToken), typeof(TaskCreationOptions), typeof(TaskScheduler)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Threading.Tasks.UnwrapPromise`1<System.Threading.Tasks.VoidTaskResult>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "FromCancellation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001401")]
	public static Task Run(Func<Task> function, CancellationToken cancellationToken) { }

	[Address(RVA = "0x15352E0", Offset = "0x15344E0", Length = "0x1D4")]
	[CalledBy(Type = "Mono.Net.Security.MobileAuthenticatedStream+<InnerWrite>d__67", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.FileSystemWatcher", Member = "DispatchEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.IO.FileAction", typeof(string), "System.IO.RenamedEventArgs&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Awaitable", Member = "RunOrScheduleContinuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Awaitable+AwaiterCompletionThreadAffinity", typeof(Action)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Task), Member = "TaskConstructorCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(object), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(InternalTaskOptions), typeof(TaskScheduler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "ScheduleAndStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60013FE")]
	public static Task Run(Action action) { }

	[Address(RVA = "0x76C310", Offset = "0x76B510", Length = "0x361")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Threading.Tasks.Task`1<System.Object>), Member = "StartNew", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(System.Func`1<System.Object>), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(InternalTaskOptions), typeof(TaskScheduler)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(System.Threading.Tasks.Task`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(object), typeof(TaskCreationOptions), typeof(CancellationToken)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnwrapPromise`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "InternalCurrentIfAttached", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskCreationOptions)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001403")]
	public static Task<TResult> Run(Func<Task`1<TResult>> function, CancellationToken cancellationToken) { }

	[Address(RVA = "0x1535750", Offset = "0x1534950", Length = "0x172")]
	[CalledBy(Type = typeof(TaskSchedulerAwaitTaskContinuation), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Stream), Member = "RunReadWriteTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.IO.Stream+ReadWriteTask"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task`1), Member = "StartNew", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), "System.Func`1<TResult>", typeof(CancellationToken), typeof(TaskCreationOptions), typeof(InternalTaskOptions), typeof(TaskScheduler)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[CalledBy(Type = typeof(Task`1), Member = "StartNew", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), "System.Func`2<Object, TResult>", typeof(object), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(InternalTaskOptions), typeof(TaskScheduler)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[CalledBy(Type = typeof(Task), Member = "Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskScheduler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "InternalStartNew", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(Delegate), typeof(object), typeof(CancellationToken), typeof(TaskScheduler), typeof(TaskCreationOptions), typeof(InternalTaskOptions)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(Task), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(StandardTaskContinuation), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TaskFactory), Member = "StartNew", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Object>), typeof(object), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(TaskScheduler)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(TaskFactory), Member = "StartNew", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(TaskScheduler)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Task), Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "AddException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TaskSchedulerException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Task), Member = "AtomicStateUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Task), Member = "get_Options", ReturnType = typeof(TaskCreationOptions))]
	[Calls(Type = typeof(TaskExceptionHolder), Member = "MarkAsHandled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1805F76D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60013C3")]
	internal void ScheduleAndStart(bool needsProtection) { }

	[Address(RVA = "0x1538B30", Offset = "0x1537D30", Length = "0x8A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Task), Member = "EnsureContingentPropertiesInitialized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ContingentProperties))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60013C0")]
	internal void set_CapturedContext(ExecutionContext value) { }

	[Address(RVA = "0x15358D0", Offset = "0x1534AD0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60013E8")]
	private void SetCancellationAcknowledged() { }

	[Address(RVA = "0x1535900", Offset = "0x1534B00", Length = "0x1B6")]
	[CalledBy(Type = typeof(ConfiguredValueTaskAwaiter), Member = "UnsafeOnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValueTaskAwaiter), Member = "UnsafeOnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TaskAwaiter), Member = "UnsafeOnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TaskAwaiter), Member = "OnCompletedInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(Action), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConfiguredTaskAwaiter), Member = "OnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConfiguredTaskAwaiter), Member = "UnsafeOnCompleted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AwaitTaskContinuation), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180756400")]
	[Calls(Type = typeof(TaskScheduler), Member = "get_InternalCurrent", ReturnType = typeof(TaskScheduler))]
	[Calls(Type = typeof(SynchronizationContext), Member = "get_Current", ReturnType = typeof(SynchronizationContext))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Task), Member = "AddTaskContinuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(AwaitTaskContinuation), Member = "UnsafeScheduleAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60013DA")]
	internal void SetContinuationForAwait(Action continuationAction, bool continueOnCapturedContext, bool flowExecutionContext) { }

	[Address(RVA = "0x1535AC0", Offset = "0x1534CC0", Length = "0xD0")]
	[CalledBy(Type = typeof(Task), Member = "NotifyDebuggerOfWaitCompletion", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8A90")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SpinWait), Member = "SpinOnce", ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "AtomicStateUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001399")]
	internal void SetNotificationForWaitCompletion(bool enabled) { }

	[Address(RVA = "0x1535B90", Offset = "0x1534D90", Length = "0x33A")]
	[CalledBy(Type = typeof(Task), Member = "InternalWait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SpinWait), Member = "SpinOnce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181520F80")]
	[Calls(Type = typeof(ManualResetEventSlim), Member = "Wait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002B50")]
	[Calls(Type = typeof(Task), Member = "AddTaskContinuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ManualResetEventSlim), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Token(Token = "0x60013E1")]
	private bool SpinThenBlockingWait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	[Address(RVA = "0x1535ED0", Offset = "0x15350D0", Length = "0x15C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SpinWait), Member = "SpinOnce", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x60013E2")]
	private bool SpinWait(int millisecondsTimeout) { }

	[Address(RVA = "0x1536030", Offset = "0x1535230", Length = "0x54")]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "CheckDirectoryExistsWithTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TaskScheduler), Member = "get_Current", ReturnType = typeof(TaskScheduler))]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60013A3")]
	public void Start() { }

	[Address(RVA = "0x1536090", Offset = "0x1535290", Length = "0x224")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(Task), Member = "ScheduleAndStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60013A4")]
	public void Start(TaskScheduler scheduler) { }

	[Address(RVA = "0x15362C0", Offset = "0x15354C0", Length = "0x210")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LazyInitializer), Member = "EnsureInitialized", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "System.Func`1<T>"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ManualResetEventSlim), Member = "Set", ReturnType = typeof(void))]
	[Calls(Type = typeof(ManualResetEventSlim), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(ManualResetEventSlim), Member = "get_WaitHandle", ReturnType = typeof(WaitHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ManualResetEventSlim), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60013B6")]
	private override WaitHandle System.IAsyncResult.get_AsyncWaitHandle() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013B8")]
	private override bool System.IAsyncResult.get_CompletedSynchronously() { }

	[Address(RVA = "0x15364E0", Offset = "0x15356E0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Task), Member = "ExecuteEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60013D3")]
	private override void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	[Address(RVA = "0x15364F0", Offset = "0x15356F0", Length = "0xE9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Task), Member = "RemoveContinuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "InternalCancel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001391")]
	private static void TaskCancelCallback(object o) { }

	[Address(RVA = "0x15365E0", Offset = "0x15357E0", Length = "0x2D8")]
	[CalledBy(Type = typeof(TaskFactory), Member = "StartNew", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Object>), typeof(object), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(TaskScheduler)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(TaskFactory), Member = "StartNew", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(TaskScheduler)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(Task), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(TaskCreationOptions), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(object), typeof(Task), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(InternalTaskOptions), typeof(TaskScheduler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "InternalStartNew", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(Delegate), typeof(object), typeof(CancellationToken), typeof(TaskScheduler), typeof(TaskCreationOptions), typeof(InternalTaskOptions)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(Task), Member = "ContinueWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Threading.Tasks.Task>), typeof(TaskScheduler), typeof(CancellationToken), typeof(TaskContinuationOptions)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(Task), Member = "ContinueWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<System.Threading.Tasks.Task, System.Object>), typeof(object), typeof(TaskScheduler), typeof(CancellationToken), typeof(TaskContinuationOptions)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(Task), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(Task))]
	[CalledBy(Type = typeof(ContinuationTaskFromTask), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(Delegate), typeof(object), typeof(TaskCreationOptions), typeof(InternalTaskOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TaskSchedulerAwaitTaskContinuation), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AwaitTaskContinuation), Member = "CreateTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Object>), typeof(object), typeof(TaskScheduler)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Task), Member = "get_CreationOptions", ReturnType = typeof(TaskCreationOptions))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LazyInitializer), Member = "EnsureInitialized", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "System.Func`1<T>"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8C20")]
	[Calls(Type = typeof(Task), Member = "AssignCancellationToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(Task), typeof(TaskContinuation)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ExecutionContext), Member = "Capture", ReturnType = typeof(ExecutionContext))]
	[Calls(Type = typeof(Task), Member = "EnsureContingentPropertiesInitialized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(ContingentProperties))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600138F")]
	internal void TaskConstructorCore(Delegate action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	[Address(RVA = "0x15368C0", Offset = "0x1535AC0", Length = "0x49")]
	[CalledBy(Type = typeof(Task`1), Member = "get_Result", ReturnType = "TResult")]
	[CalledBy(Type = typeof(Task`1), Member = "GetResultCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = "TResult")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Task), Member = "GetExceptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(AggregateException))]
	[Calls(Type = typeof(Task), Member = "UpdateExceptionObservedStatus", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60013C9")]
	internal void ThrowIfExceptional(bool includeTaskCanceledExceptions) { }

	[Address(RVA = "0x1536910", Offset = "0x1535B10", Length = "0xB")]
	[CalledBy(Type = typeof(TaskCompletionSource`1), Member = "TrySetCanceled", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TaskCompletionSource`1), Member = "TrySetCanceled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TaskCompletionSource`1), Member = "SetCanceled", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.Tasks.ValueTask`1+ValueTaskSourceAsTask+<>c", Member = "<.cctor>b__4_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnwrapPromise`1), Member = "ProcessCompletedOuterTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnwrapPromise`1), Member = "ProcessInnerTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x6001392")]
	internal bool TrySetCanceled(CancellationToken tokenToRecord) { }

	[Address(RVA = "0x1536920", Offset = "0x1535B20", Length = "0xE5")]
	[CalledBy(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.Tasks.ValueTask+ValueTaskSourceAsTask+<>c", Member = "<.cctor>b__4_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValueTask), Member = "GetTaskForValueTaskSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IValueTaskSource)}, ReturnType = typeof(Task))]
	[CalledBy(Type = "System.Threading.Tasks.ValueTask`1+ValueTaskSourceAsTask+<>c", Member = "<.cctor>b__4_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ValueTask`1), Member = "GetTaskForValueTaskSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Threading.Tasks.Sources.IValueTaskSource`1<TResult>"}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[CalledBy(Type = "System.Threading.Tasks.TaskFactory`1+FromAsyncTrimPromise`1", Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TInstance", "System.Func`3<TInstance, IAsyncResult, TResult>", typeof(IAsyncResult), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DelayPromise), Member = "Complete", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WhenAllPromise), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "FromCancellation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OperationCanceledException)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[CalledBy(Type = typeof(UnwrapPromise`1), Member = "TrySetFromTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Task), Member = "AddException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CancellationToken), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CancellationToken), typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Task), Member = "RecordInternalCancellationRequest", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Task), Member = "AtomicStateUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task), Member = "CancellationCleanupLogic", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6001393")]
	internal bool TrySetCanceled(CancellationToken tokenToRecord, object cancellationException) { }

	[Address(RVA = "0x1536A10", Offset = "0x1535C10", Length = "0xF1")]
	[CalledBy(Type = typeof(UnwrapPromise`1), Member = "TrySetFromTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TaskCompletionSource`1), Member = "TrySetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Threading.Tasks.ValueTask+ValueTaskSourceAsTask+<>c", Member = "<.cctor>b__4_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.Tasks.ValueTask`1+ValueTaskSourceAsTask+<>c", Member = "<.cctor>b__4_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.Tasks.TaskFactory`1+FromAsyncTrimPromise`1", Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TInstance", "System.Func`3<TInstance, IAsyncResult, TResult>", typeof(IAsyncResult), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WhenAllPromise), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "FromException", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TResult"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
	[CalledBy(Type = typeof(AsyncTaskMethodBuilder`1), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Task), Member = "AtomicStateUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LazyInitializer), Member = "EnsureInitialized", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "System.Func`1<T>"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Task), Member = "Finish", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Task), Member = "AddException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6001394")]
	internal bool TrySetException(object exceptionObject) { }

	[Address(RVA = "0x1536B10", Offset = "0x1535D10", Length = "0x100")]
	[CalledBy(Type = typeof(Task), Member = "ThrowIfExceptional", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "Wait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1813B4ED0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60013CA")]
	internal void UpdateExceptionObservedStatus() { }

	[Address(RVA = "0x1536C30", Offset = "0x1535E30", Length = "0x10")]
	[CalledBy(Type = "Mono.Net.Security.MobileAuthenticatedStream", Member = "AuthenticateAsClient", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Security.Cryptography.X509Certificates.X509CertificateCollection", "System.Security.Authentication.SslProtocols", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Net.Security.MobileAuthenticatedStream", Member = "AuthenticateAsServer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate), typeof(bool), "System.Security.Authentication.SslProtocols", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Net.Security.MobileAuthenticatedStream", Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.ServicePointScheduler+AsyncManualResetEvent", Member = "Set", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebConnectionStream", Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Byte[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebRequestStream", Member = "Close_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.XmlTextReaderImpl", Member = "FinishInitUriString", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60013DC")]
	public void Wait() { }

	[Address(RVA = "0x1536C20", Offset = "0x1535E20", Length = "0xB")]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "CheckDirectoryExistsWithTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Task), Member = "Wait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60013DD")]
	public bool Wait(int millisecondsTimeout) { }

	[Address(RVA = "0x1536C40", Offset = "0x1535E40", Length = "0x16A")]
	[CalledBy(Type = typeof(Task), Member = "Wait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Task), Member = "InternalWait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task), Member = "NotifyDebuggerOfWaitCompletionIfNecessary", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CancellationToken), Member = "ThrowIfCancellationRequested", ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "GetExceptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(AggregateException))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Task), Member = "UpdateExceptionObservedStatus", ReturnType = typeof(void))]
	[Token(Token = "0x60013DE")]
	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	[Address(RVA = "0x1536DB0", Offset = "0x1535FB0", Length = "0x518")]
	[CalledBy(Type = "GLTFast.GltfImportBase+<LoadImages>d__105", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Task), Member = "InternalWhenAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task[])}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Task), Member = "WhenAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task[])}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LowLevelList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(LowLevelListWithIList`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001406")]
	public static Task WhenAll(IEnumerable<Task> tasks) { }

	[Address(RVA = "0x15372D0", Offset = "0x15364D0", Length = "0x22B")]
	[CalledBy(Type = typeof(Task), Member = "WhenAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Threading.Tasks.Task>)}, ReturnType = typeof(Task))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Task), Member = "InternalWhenAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task[])}, ReturnType = typeof(Task))]
	[Token(Token = "0x6001407")]
	public static Task WhenAll(Task[] tasks) { }

	[Address(RVA = "0x15377C0", Offset = "0x15369C0", Length = "0x241")]
	[CalledBy(Type = "System.Threading.SemaphoreSlim+<WaitUntilCountOrTimeoutAsync>d__32", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.ServicePointScheduler+<WaitAsync>d__46", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebRequestStream+<WriteChunkTrailer>d__40", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebResponseStream+<ReadAllAsync>d__48", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(TaskFactory), Member = "CommonCWAnyLogic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Threading.Tasks.Task>)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Token(Token = "0x6001409")]
	public static Task<Task> WhenAny(Task[] tasks) { }

	[Address(RVA = "0x1537500", Offset = "0x1536700", Length = "0x2BE")]
	[CalledBy(Type = "System.Net.ServicePointScheduler+<RunScheduler>d__32", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(LowLevelListWithIList`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(LowLevelList`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TaskFactory), Member = "CommonCWAnyLogic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IList`1<System.Threading.Tasks.Task>)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Threading.Tasks.Task>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x600140A")]
	public static Task<Task> WhenAny(IEnumerable<Task> tasks) { }

	[Address(RVA = "0x1537A10", Offset = "0x1536C10", Length = "0x9B")]
	[CalledBy(Type = typeof(Task), Member = "InternalWait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TaskScheduler), Member = "TryRunInline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TaskSchedulerException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60013DF")]
	private bool WrappedTryRunInline() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013DB")]
	public static YieldAwaitable Yield() { }

}

