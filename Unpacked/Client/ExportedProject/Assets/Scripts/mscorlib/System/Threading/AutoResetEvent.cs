namespace System.Threading;

[Token(Token = "0x20001EB")]
public sealed class AutoResetEvent : EventWaitHandle
{

	[Address(RVA = "0x1508C30", Offset = "0x1507E30", Length = "0x10B")]
	[CalledBy(Type = "System.Net.TimerThread", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.ReaderWriterLockSlim", Member = "LazyCreateEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EventWaitHandle&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(WaitHandle), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeEventCalls), Member = "CreateEvent_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(string), typeof(Int32&)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SafeHandle), Member = "SetHandleAsInvalid", ReturnType = typeof(void))]
	[Calls(Type = typeof(__Error), Member = "WinIOError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WaitHandle), Member = "SetHandleInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeWaitHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001100")]
	public AutoResetEvent(bool initialState) { }

}

