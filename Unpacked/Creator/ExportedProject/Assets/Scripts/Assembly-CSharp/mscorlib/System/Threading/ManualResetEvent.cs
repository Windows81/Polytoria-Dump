namespace System.Threading;

[Token(Token = "0x20001F0")]
public sealed class ManualResetEvent : EventWaitHandle
{

	[Address(RVA = "0x15151E0", Offset = "0x15143E0", Length = "0x10B")]
	[CalledBy(Type = "UnityEngine.UnitySynchronizationContext", Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SendOrPostCallback), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Telepathy.ConnectionState", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Sockets.TcpClient", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.ReaderWriterLockSlim", Member = "LazyCreateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventWaitHandle&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.ReaderWriterLockSlim", Member = "TryEnterReadLockCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Threading.ReaderWriterLockSlim+TimeoutTracker"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Net.TimerThread", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.LazyAsyncResult", Member = "LazilyCreateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ManualResetEvent&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.IOAsyncResult", Member = "get_AsyncWaitHandle", ReturnType = typeof(WaitHandle))]
	[CalledBy(Type = typeof(FileStreamAsyncResult), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.FileWebRequest", Member = "GetResponseCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.Stream+SynchronousAsyncResult+<>c", Member = "<get_AsyncWaitHandle>b__12_0", ReturnType = typeof(ManualResetEvent))]
	[CalledBy(Type = typeof(AsyncResult), Member = "get_AsyncWaitHandle", ReturnType = typeof(WaitHandle))]
	[CalledBy(Type = "System.Threading.Timer+Scheduler", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.Timer+Scheduler", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FileStream), Member = "BeginWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[CalledBy(Type = typeof(ThreadPool), Member = "RegisterWaitForSingleObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitHandle), typeof(WaitOrTimerCallback), typeof(object), typeof(uint), typeof(bool), typeof(StackCrawlMark&), typeof(bool)}, ReturnType = typeof(RegisteredWaitHandle))]
	[CalledBy(Type = "System.Threading.Timer+Scheduler", Member = "InitScheduler", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegisteredWaitHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitHandle), typeof(WaitOrTimerCallback), typeof(object), typeof(TimeSpan), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(WaitHandle), Member = "SetHandleInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeWaitHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(WaitHandle), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeEventCalls), Member = "CreateEvent_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(string), typeof(Int32&)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SafeHandle), Member = "SetHandleAsInvalid", ReturnType = typeof(void))]
	[Calls(Type = typeof(__Error), Member = "WinIOError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600110B")]
	public ManualResetEvent(bool initialState) { }

}

