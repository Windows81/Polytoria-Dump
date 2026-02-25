namespace System.Threading;

[ComVisible(True)]
[Token(Token = "0x200023F")]
public sealed class RegisteredWaitHandle : MarshalByRefObject
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A62")]
	private WaitHandle _waitObject; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A63")]
	private WaitOrTimerCallback _callback; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000A64")]
	private object _state; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000A65")]
	private WaitHandle _finalEvent; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000A66")]
	private ManualResetEvent _cancelEvent; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000A67")]
	private TimeSpan _timeout; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000A68")]
	private int _callsInProcess; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000A69")]
	private bool _executeOnlyOnce; //Field offset: 0x4C
	[FieldOffset(Offset = "0x4D")]
	[Token(Token = "0x4000A6A")]
	private bool _unregistered; //Field offset: 0x4D

	[Address(RVA = "0x152C090", Offset = "0x152B290", Length = "0xE0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ManualResetEvent), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60012E1")]
	internal RegisteredWaitHandle(WaitHandle waitObject, WaitOrTimerCallback callback, object state, TimeSpan timeout, bool executeOnlyOnce) { }

	[Address(RVA = "0x152B950", Offset = "0x152AB50", Length = "0xC0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1815211A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60012E3")]
	private void DoCallBack(object timedOut) { }

	[Address(RVA = "0x152BA20", Offset = "0x152AC20", Length = "0xE3")]
	[CalledBy(Type = "System.Diagnostics.Process", Member = "StopWatchingForExit", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[ComVisible(True)]
	[Token(Token = "0x60012E4")]
	public bool Unregister(WaitHandle waitObject) { }

	[Address(RVA = "0x152BB10", Offset = "0x152AD10", Length = "0x57D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181521320")]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeEventCalls), Member = "SetEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeWaitHandle)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ThreadPool), Member = "QueueUserWorkItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitCallback), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001E080")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WaitHandle), Member = "WaitAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WaitHandle[]), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TimeSpan), Member = "get_TotalMilliseconds", ReturnType = typeof(double))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WaitHandle), Member = "get_SafeWaitHandle", ReturnType = typeof(SafeWaitHandle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60012E2")]
	internal void Wait(object state) { }

}

