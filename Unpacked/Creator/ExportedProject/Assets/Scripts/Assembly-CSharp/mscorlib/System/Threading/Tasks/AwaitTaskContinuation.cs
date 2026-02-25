namespace System.Threading.Tasks;

[Token(Token = "0x200027A")]
internal class AwaitTaskContinuation : TaskContinuation, IThreadPoolWorkItem
{
	[Token(Token = "0x4000B38")]
	private static ContextCallback s_invokeActionCallback; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B36")]
	private readonly ExecutionContext m_capturedContext; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000B37")]
	protected readonly Action m_action; //Field offset: 0x18

	[Token(Token = "0x170001FA")]
	internal static bool IsValidLocationForInlining
	{
		[Address(RVA = "0x15241C0", Offset = "0x15233C0", Length = "0x12C")]
		[CalledBy(Type = typeof(TaskSchedulerAwaitTaskContinuation), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AwaitTaskContinuation), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AwaitTaskContinuation), Member = "RunOrScheduleAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(bool), typeof(Task&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SynchronizationContext), Member = "get_Current", ReturnType = typeof(SynchronizationContext))]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(TaskScheduler), Member = "get_InternalCurrent", ReturnType = typeof(TaskScheduler))]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6001451")]
		internal get { } //Length: 300
	}

	[Address(RVA = "0x1524130", Offset = "0x1523330", Length = "0x90")]
	[CalledBy(Type = typeof(Task), Member = "SetContinuationForAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SynchronizationContextAwaitTaskContinuation), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SynchronizationContext), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TaskSchedulerAwaitTaskContinuation), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TaskScheduler), typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ExecutionContext), Member = "Capture", ReturnType = typeof(ExecutionContext))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600144E")]
	internal AwaitTaskContinuation(Action action, bool flowExecutionContext) { }

	[Address(RVA = "0x1523AF0", Offset = "0x1522CF0", Length = "0xDF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Task), Member = "TaskConstructorCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(object), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(InternalTaskOptions), typeof(TaskScheduler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600144F")]
	protected Task CreateTask(Action<Object> action, object state, TaskScheduler scheduler) { }

	[Address(RVA = "0x15241C0", Offset = "0x15233C0", Length = "0x12C")]
	[CalledBy(Type = typeof(TaskSchedulerAwaitTaskContinuation), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AwaitTaskContinuation), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AwaitTaskContinuation), Member = "RunOrScheduleAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(bool), typeof(Task&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SynchronizationContext), Member = "get_Current", ReturnType = typeof(SynchronizationContext))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(TaskScheduler), Member = "get_InternalCurrent", ReturnType = typeof(TaskScheduler))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001451")]
	internal static bool get_IsValidLocationForInlining() { }

	[Address(RVA = "0x1523BD0", Offset = "0x1522DD0", Length = "0xAA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001454")]
	protected static ContextCallback GetInvokeActionCallback() { }

	[Address(RVA = "0x1523C80", Offset = "0x1522E80", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001453")]
	private static void InvokeAction(object state) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001459")]
	public override void MarkAborted(ThreadAbortException e) { }

	[Address(RVA = "0x1523EF0", Offset = "0x15230F0", Length = "0xB2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AwaitTaskContinuation), Member = "get_IsValidLocationForInlining", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181521530")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(AwaitTaskContinuation), Member = "RunCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContextCallback), typeof(object), typeof(Task&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThreadPool), Member = "UnsafeQueueCustomWorkItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001450")]
	internal virtual void Run(Task ignored, bool canInlineContinuationTask) { }

	[Address(RVA = "0x1523CF0", Offset = "0x1522EF0", Length = "0xED")]
	[CalledBy(Type = typeof(SynchronizationContextAwaitTaskContinuation), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TaskSchedulerAwaitTaskContinuation), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AwaitTaskContinuation), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SynchronizationContext), Member = "get_CurrentExplicit", ReturnType = typeof(SynchronizationContext))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SynchronizationContext), Member = "SetSynchronizationContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SynchronizationContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AwaitTaskContinuation), Member = "ThrowAsyncIfNecessary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181521160")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001455")]
	protected void RunCallback(ContextCallback callback, object state, ref Task currentTask) { }

	[Address(RVA = "0x1523DE0", Offset = "0x1522FE0", Length = "0x107")]
	[CalledBy(Type = typeof(Task), Member = "FinishContinuations", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AwaitTaskContinuation), Member = "get_IsValidLocationForInlining", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AwaitTaskContinuation), Member = "ThrowAsyncIfNecessary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AwaitTaskContinuation), Member = "UnsafeScheduleAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001456")]
	internal static void RunOrScheduleAction(Action action, bool allowInlining, ref Task currentTask) { }

	[Address(RVA = "0x1523FB0", Offset = "0x15231B0", Length = "0x9F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181521530")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ExecutionContext), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExecutionContext), typeof(ContextCallback), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001452")]
	private override void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	[Address(RVA = "0x1524050", Offset = "0x1523250", Length = "0x49")]
	[CalledBy(Type = "System.Threading.Tasks.TaskSchedulerAwaitTaskContinuation+<>c", Member = "<Run>b__2_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AwaitTaskContinuation), Member = "RunCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContextCallback), typeof(object), typeof(Task&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AwaitTaskContinuation), Member = "RunOrScheduleAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(bool), typeof(Task&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RuntimeAugments), Member = "ReportUnhandledException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001458")]
	protected static void ThrowAsyncIfNecessary(Exception exc) { }

	[Address(RVA = "0x15240A0", Offset = "0x15232A0", Length = "0x85")]
	[CalledBy(Type = typeof(Task), Member = "SetContinuationForAwait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AwaitTaskContinuation), Member = "RunOrScheduleAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(bool), typeof(Task&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ThreadPool), Member = "UnsafeQueueCustomWorkItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001457")]
	internal static void UnsafeScheduleAction(Action action) { }

}

