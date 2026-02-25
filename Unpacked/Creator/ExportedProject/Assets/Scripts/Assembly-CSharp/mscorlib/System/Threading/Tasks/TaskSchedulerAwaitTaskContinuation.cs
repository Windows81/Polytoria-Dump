namespace System.Threading.Tasks;

[Token(Token = "0x2000278")]
internal sealed class TaskSchedulerAwaitTaskContinuation : AwaitTaskContinuation
{
	[CompilerGenerated]
	[Token(Token = "0x2000279")]
	private sealed class <>c
	{
		[Token(Token = "0x4000B34")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000B35")]
		public static Action<Object> <>9__2_0; //Field offset: 0x8

		[Address(RVA = "0x153A980", Offset = "0x1539B80", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600144B")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600144C")]
		public <>c() { }

		[Address(RVA = "0x153A570", Offset = "0x1539770", Length = "0x7D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(AwaitTaskContinuation), Member = "ThrowAsyncIfNecessary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600144D")]
		internal void <Run>b__2_0(object state) { }

	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B33")]
	private readonly TaskScheduler m_scheduler; //Field offset: 0x20

	[Address(RVA = "0x152D710", Offset = "0x152C910", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AwaitTaskContinuation), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001449")]
	internal TaskSchedulerAwaitTaskContinuation(TaskScheduler scheduler, Action action, bool flowExecutionContext) { }

	[Address(RVA = "0x152F0A0", Offset = "0x152E2A0", Length = "0x34C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Task), Member = "ScheduleAndStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ThreadPool), Member = "UnsafeQueueCustomWorkItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AwaitTaskContinuation), Member = "RunCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ContextCallback), typeof(object), typeof(Task&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181521530")]
	[Calls(Type = typeof(AwaitTaskContinuation), Member = "get_IsValidLocationForInlining", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TaskContinuation), Member = "InlineIfPossibleOrElseQueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Task), Member = "TaskConstructorCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(object), typeof(CancellationToken), typeof(TaskCreationOptions), typeof(InternalTaskOptions), typeof(TaskScheduler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[Calls(Type = typeof(TaskScheduler), Member = "get_InternalCurrent", ReturnType = typeof(TaskScheduler))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x600144A")]
	internal virtual void Run(Task ignored, bool canInlineContinuationTask) { }

}

