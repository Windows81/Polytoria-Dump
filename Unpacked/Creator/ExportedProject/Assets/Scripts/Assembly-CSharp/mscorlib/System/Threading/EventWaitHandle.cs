namespace System.Threading;

[ComVisible(True)]
[Token(Token = "0x200021B")]
public class EventWaitHandle : WaitHandle
{

	[Address(RVA = "0x1511310", Offset = "0x1510510", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EventWaitHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(EventResetMode), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60011CC")]
	public EventWaitHandle(bool initialState, EventResetMode mode) { }

	[Address(RVA = "0x1511330", Offset = "0x1510530", Length = "0x31D")]
	[CalledBy(Type = typeof(EventWaitHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(EventResetMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(WaitHandle), Member = "SetHandleInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeWaitHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(__Error), Member = "WinIOError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(SafeHandle), Member = "SetHandleAsInvalid", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NativeEventCalls), Member = "CreateEvent_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(string), typeof(Int32&)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(WaitHandle), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(WaitHandleCannotBeOpenedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60011CD")]
	public EventWaitHandle(bool initialState, EventResetMode mode, string name) { }

	[Address(RVA = "0x1511250", Offset = "0x1510450", Length = "0x5B")]
	[CalledBy(Type = typeof(SemaphoreSlim), Member = "Wait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SemaphoreSlim), Member = "WaitAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CalledBy(Type = "System.Threading.Timer+Scheduler", Member = "SchedulerThread", ReturnType = typeof(void))]
	[CalledBy(Type = "System.IOAsyncResult", Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.TimerThread", Member = "ThreadProc", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.ReaderWriterLockSlim", Member = "WaitOnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventWaitHandle), typeof(UInt32&), "System.Threading.ReaderWriterLockSlim+TimeoutTracker", typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Telepathy.ThreadFunctions", Member = "SendLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.Net.Sockets.TcpClient", "Telepathy.MagnificentSendPipe", typeof(ManualResetEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(NativeEventCalls), Member = "ResetEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeWaitHandle)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(IOException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60011CE")]
	public bool Reset() { }

	[Address(RVA = "0x15112B0", Offset = "0x15104B0", Length = "0x5B")]
	[CallerCount(Count = 29)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(NativeEventCalls), Member = "SetEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeWaitHandle)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(IOException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60011CF")]
	public bool Set() { }

}

