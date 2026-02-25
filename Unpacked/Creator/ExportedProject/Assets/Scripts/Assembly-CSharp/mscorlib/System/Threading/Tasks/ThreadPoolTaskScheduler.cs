namespace System.Threading.Tasks;

[Token(Token = "0x2000281")]
internal sealed class ThreadPoolTaskScheduler : TaskScheduler
{
	[CompilerGenerated]
	[Token(Token = "0x2000282")]
	private sealed class <>c
	{
		[Token(Token = "0x4000B4B")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x153A9F0", Offset = "0x1539BF0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600148D")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600148E")]
		public <>c() { }

		[Address(RVA = "0x153A5F0", Offset = "0x15397F0", Length = "0x75")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Task), Member = "ExecuteEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x600148F")]
		internal void <.cctor>b__10_0(object s) { }

	}

	[Token(Token = "0x4000B4A")]
	private static readonly ParameterizedThreadStart s_longRunningThreadWork; //Field offset: 0x0

	[Token(Token = "0x17000202")]
	internal virtual bool RequiresAtomicStartTransition
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x600148B")]
		internal get { } //Length: 3
	}

	[Address(RVA = "0x1538F60", Offset = "0x1538160", Length = "0xC8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600148C")]
	private static ThreadPoolTaskScheduler() { }

	[Address(RVA = "0x1539030", Offset = "0x1538230", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001486")]
	internal ThreadPoolTaskScheduler() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x600148B")]
	internal virtual bool get_RequiresAtomicStartTransition() { }

	[Address(RVA = "0x1538BC0", Offset = "0x1537DC0", Length = "0x14")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThreadPool), Member = "EnsureVMInitialized", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180222000")]
	[DeduplicatedMethod]
	[Token(Token = "0x600148A")]
	internal virtual void NotifyWorkItemProgress() { }

	[Address(RVA = "0x1538BE0", Offset = "0x1537DE0", Length = "0x290")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TaskScheduler), Member = "get_Id", ReturnType = typeof(int))]
	[Calls(Type = typeof(RuntimeThread), Member = "set_IsBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeThread), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterizedThreadStart), typeof(int)}, ReturnType = typeof(RuntimeThread))]
	[Calls(Type = typeof(ThreadPool), Member = "UnsafeQueueCustomWorkItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TaskTrace), Member = "TaskScheduled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Task), Member = "get_Id", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TaskTrace), Member = "get_Enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RuntimeThread), Member = "Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001487")]
	protected private virtual void QueueTask(Task task) { }

	[Address(RVA = "0x1538E80", Offset = "0x1538080", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThreadPool), Member = "TryPopCustomWorkItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001489")]
	protected private virtual bool TryDequeue(Task task) { }

	[Address(RVA = "0x1538E90", Offset = "0x1538090", Length = "0xC9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThreadPool), Member = "TryPopCustomWorkItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Task), Member = "ExecuteEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6001488")]
	protected virtual bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued) { }

}

