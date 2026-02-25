namespace System.Threading;

[Token(Token = "0x2000239")]
public static class ThreadPool
{
	[CompilerGenerated]
	[Token(Token = "0x200023A")]
	private sealed class <>c__DisplayClass17_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A55")]
		public Action<TState> callBack; //Field offset: 0x0

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60012AC")]
		public <>c__DisplayClass17_0`1() { }

		[Address(RVA = "0x7FD920", Offset = "0x7FCB20", Length = "0x89")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60012AD")]
		internal void <QueueUserWorkItem>b__0(object x) { }

	}


	[Token(Token = "0x170001C5")]
	internal static bool IsThreadPoolThread
	{
		[Address(RVA = "0x1539C40", Offset = "0x1538E40", Length = "0x23")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60012AB")]
		internal get { } //Length: 35
	}

	[Address(RVA = "0x1539350", Offset = "0x1538550", Length = "0x9E")]
	[CalledBy(Type = typeof(ThreadPool), Member = "QueueUserWorkItemHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitCallback), typeof(object), typeof(StackCrawlMark&), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ThreadPool), Member = "UnsafeQueueCustomWorkItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadPool), Member = "NotifyWorkItemProgress", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadPoolTaskScheduler), Member = "NotifyWorkItemProgress", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180221F40")]
	[Token(Token = "0x60012A4")]
	private static void EnsureVMInitialized() { }

	[Address(RVA = "0x1539C40", Offset = "0x1538E40", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60012AB")]
	internal static bool get_IsThreadPoolThread() { }

	[Address(RVA = "0x15393F0", Offset = "0x15385F0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180221F40")]
	[Token(Token = "0x60012AA")]
	private static void InitializeVMTp(ref bool enableWorkerTracking) { }

	[Address(RVA = "0x1539400", Offset = "0x1538600", Length = "0x5")]
	[CalledBy(Type = typeof(ThreadPoolWorkQueue), Member = "Dispatch", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180221F60")]
	[Token(Token = "0x60012A5")]
	internal static bool NotifyWorkItemComplete() { }

	[Address(RVA = "0x1538BC0", Offset = "0x1537DC0", Length = "0x14")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThreadPool), Member = "EnsureVMInitialized", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180222000")]
	[DeduplicatedMethod]
	[Token(Token = "0x60012A7")]
	internal static void NotifyWorkItemProgress() { }

	[Address(RVA = "0x1539410", Offset = "0x1538610", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180222000")]
	[Token(Token = "0x60012A8")]
	internal static void NotifyWorkItemProgressNative() { }

	[Address(RVA = "0x13EA210", Offset = "0x13E9410", Length = "0x5")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_custom_attrs_free")]
	[DeduplicatedMethod]
	[Token(Token = "0x60012A9")]
	internal static void NotifyWorkItemQueued() { }

	[Address(RVA = "0x15395B0", Offset = "0x15387B0", Length = "0x2C")]
	[CalledBy(Type = typeof(SynchronizationContext), Member = "Post", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SendOrPostCallback), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadPool), Member = "RegisterWaitForSingleObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitHandle), typeof(WaitOrTimerCallback), typeof(object), typeof(uint), typeof(bool), typeof(StackCrawlMark&), typeof(bool)}, ReturnType = typeof(RegisteredWaitHandle))]
	[CalledBy(Type = typeof(RegisteredWaitHandle), Member = "Wait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CrossAppDomainSink), Member = "AsyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage), typeof(IMessageSink)}, ReturnType = typeof(IMessageCtrl))]
	[CalledBy(Type = typeof(StackBuilderSink), Member = "AsyncProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMessage), typeof(IMessageSink)}, ReturnType = typeof(IMessageCtrl))]
	[CalledBy(Type = typeof(AsyncMethodBuilderCore), Member = "ThrowAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(SynchronizationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(YieldAwaiter), Member = "QueueContinuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.FileWebRequest", Member = "BeginGetRequestStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = "System.Net.FileWebRequest", Member = "BeginGetResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(ThreadPool), Member = "QueueUserWorkItemHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitCallback), typeof(object), typeof(StackCrawlMark&), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600129C")]
	public static bool QueueUserWorkItem(WaitCallback callBack, object state) { }

	[Address(RVA = "0x1539580", Offset = "0x1538780", Length = "0x2E")]
	[CalledBy(Type = "System.Net.LazyAsyncResult", Member = "Complete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.Interop.UserDataRegistries.TypeDescriptorRegistry", Member = "RegisterType_Impl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), "MoonSharp.Interpreter.InteropAccessMode", typeof(string), "MoonSharp.Interpreter.Interop.IUserDataDescriptor"}, ReturnType = "MoonSharp.Interpreter.Interop.IUserDataDescriptor")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThreadPool), Member = "QueueUserWorkItemHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitCallback), typeof(object), typeof(StackCrawlMark&), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600129D")]
	public static bool QueueUserWorkItem(WaitCallback callBack) { }

	[Address(RVA = "0x76D470", Offset = "0x76C670", Length = "0x137")]
	[CalledBy(Type = "System.Net.Sockets.Socket+AwaitableSocketAsyncEventArgs", Member = "InvokeContinuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<Object>", typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ThreadPool), Member = "QueueUserWorkItemHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitCallback), typeof(object), typeof(StackCrawlMark&), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600129F")]
	public static bool QueueUserWorkItem(Action<TState> callBack, TState state, bool preferLocal) { }

	[Address(RVA = "0x1539420", Offset = "0x1538620", Length = "0x15F")]
	[CalledBy(Type = typeof(ThreadPool), Member = "QueueUserWorkItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitCallback), typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ThreadPool), Member = "QueueUserWorkItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitCallback)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ThreadPool), Member = "UnsafeQueueUserWorkItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitCallback), typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ThreadPool), Member = "QueueUserWorkItem", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TState"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<TState>", "TState", typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThreadPool), Member = "EnsureVMInitialized", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181521000")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18019E930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60012A0")]
	private static bool QueueUserWorkItemHelper(WaitCallback callBack, object state, ref StackCrawlMark stackMark, bool compressStack, bool forceGlobal = true) { }

	[Address(RVA = "0x1539820", Offset = "0x1538A20", Length = "0x294")]
	[CalledBy(Type = typeof(ThreadPool), Member = "RegisterWaitForSingleObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitHandle), typeof(WaitOrTimerCallback), typeof(object), typeof(int), typeof(bool)}, ReturnType = typeof(RegisteredWaitHandle))]
	[CalledBy(Type = typeof(ThreadPool), Member = "RegisterWaitForSingleObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitHandle), typeof(WaitOrTimerCallback), typeof(object), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(RegisteredWaitHandle))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TimeSpan), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ManualResetEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThreadPool), Member = "UnsafeQueueUserWorkItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitCallback), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ThreadPool), Member = "QueueUserWorkItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitCallback), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001299")]
	private static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, uint millisecondsTimeOutInterval, bool executeOnlyOnce, ref StackCrawlMark stackMark, bool compressStack) { }

	[Address(RVA = "0x15395E0", Offset = "0x15387E0", Length = "0x17D")]
	[CalledBy(Type = typeof(Lease), Member = "CheckNextSponsor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Lease), Member = "ProcessSponsorResponse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeSpan), Member = "get_TotalMilliseconds", ReturnType = typeof(double))]
	[Calls(Type = typeof(ThreadPool), Member = "RegisterWaitForSingleObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitHandle), typeof(WaitOrTimerCallback), typeof(object), typeof(uint), typeof(bool), typeof(StackCrawlMark&), typeof(bool)}, ReturnType = typeof(RegisteredWaitHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600129B")]
	public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, TimeSpan timeout, bool executeOnlyOnce) { }

	[Address(RVA = "0x1539760", Offset = "0x1538960", Length = "0xBA")]
	[CalledBy(Type = "System.Diagnostics.Process", Member = "EnsureWatchingForExit", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThreadPool), Member = "RegisterWaitForSingleObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitHandle), typeof(WaitOrTimerCallback), typeof(object), typeof(uint), typeof(bool), typeof(StackCrawlMark&), typeof(bool)}, ReturnType = typeof(RegisteredWaitHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600129A")]
	public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, int millisecondsTimeOutInterval, bool executeOnlyOnce) { }

	[Address(RVA = "0x13E7660", Offset = "0x13E6860", Length = "0x5")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9F0")]
	[DeduplicatedMethod]
	[Token(Token = "0x60012A6")]
	internal static void ReportThreadStatus(bool isWorking) { }

	[Address(RVA = "0x1539AC0", Offset = "0x1538CC0", Length = "0x5")]
	[CalledBy(Type = typeof(ThreadPoolWorkQueue), Member = "EnsureThreadRequested", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180222070")]
	[Token(Token = "0x60012A3")]
	internal static bool RequestWorkerThread() { }

	[Address(RVA = "0x1539AD0", Offset = "0x1538CD0", Length = "0xB2")]
	[CalledBy(Type = typeof(ThreadPoolTaskScheduler), Member = "TryExecuteTaskInline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ThreadPoolTaskScheduler), Member = "TryDequeue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(ThreadPoolWorkQueue), Member = "LocalFindAndPop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60012A2")]
	internal static bool TryPopCustomWorkItem(IThreadPoolWorkItem workItem) { }

	[Address(RVA = "0x1539B90", Offset = "0x1538D90", Length = "0x77")]
	[CalledBy(Type = typeof(SemaphoreSlim), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(SemaphoreSlim), Member = "QueueWaiterTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Threading.SemaphoreSlim+TaskNode"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Task), Member = "FinishContinuations", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TaskSchedulerAwaitTaskContinuation), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AwaitTaskContinuation), Member = "Run", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AwaitTaskContinuation), Member = "UnsafeScheduleAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadPoolTaskScheduler), Member = "QueueTask", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThreadPool), Member = "EnsureVMInitialized", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181520F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x60012A1")]
	internal static void UnsafeQueueCustomWorkItem(IThreadPoolWorkItem workItem, bool forceGlobal) { }

	[Address(RVA = "0x1539C10", Offset = "0x1538E10", Length = "0x2C")]
	[CalledBy(Type = typeof(ThreadPool), Member = "RegisterWaitForSingleObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitHandle), typeof(WaitOrTimerCallback), typeof(object), typeof(uint), typeof(bool), typeof(StackCrawlMark&), typeof(bool)}, ReturnType = typeof(RegisteredWaitHandle))]
	[CalledBy(Type = "System.Threading.Timer+Scheduler", Member = "FireTimer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Timer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnwrapPromise`1), Member = "InvokeCoreAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Task)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(YieldAwaiter), Member = "QueueContinuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Sockets.SocketAsyncResult", Member = "Complete", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ThreadPool), Member = "QueueUserWorkItemHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitCallback), typeof(object), typeof(StackCrawlMark&), typeof(bool), typeof(bool)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600129E")]
	public static bool UnsafeQueueUserWorkItem(WaitCallback callBack, object state) { }

}

