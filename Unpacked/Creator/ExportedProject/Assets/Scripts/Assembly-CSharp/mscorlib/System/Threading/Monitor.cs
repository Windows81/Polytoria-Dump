namespace System.Threading;

[Token(Token = "0x2000222")]
public static class Monitor
{

	[Address(RVA = "0x1515370", Offset = "0x1514570", Length = "0x5")]
	[CalledBy(Type = "System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1+PerCoreLockedStacks", Member = "TryPush", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1+PerCoreLockedStacks", Member = "TryPop", ReturnType = "T[]")]
	[CalledBy(Type = "System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1+LockedStack", Member = "TryPush", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1+LockedStack", Member = "TryPop", ReturnType = "T[]")]
	[CalledBy(Type = typeof(TlsOverPerCoreLockedStacksArrayPool`1), Member = "Rent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T[]")]
	[CalledBy(Type = "UnityEngine.Events.PersistentCall", Member = "get_mode", ReturnType = "UnityEngine.Events.PersistentListenerMode")]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextElement", Member = "get_glyphIndex", ReturnType = typeof(uint))]
	[CalledBy(Type = "UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord", Member = "get_featureLookupFlags", ReturnType = "UnityEngine.TextCore.LowLevel.FontFeatureLookupFlags")]
	[CalledBy(Type = "UnityEngine.Touch", Member = "get_type", ReturnType = "UnityEngine.TouchType")]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D640")]
	[Token(Token = "0x60011FF")]
	public static void Enter(object obj) { }

	[Address(RVA = "0x15152F0", Offset = "0x15144F0", Length = "0x79")]
	[CallerCount(Count = 380)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021E170")]
	[Calls(Type = typeof(Monitor), Member = "ThrowLockTakenException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6001200")]
	public static void Enter(object obj, ref bool lockTaken) { }

	[Address(RVA = "0x1515380", Offset = "0x1514580", Length = "0x5")]
	[CallerCount(Count = 963)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D670")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x6001202")]
	public static void Exit(object obj) { }

	[Address(RVA = "0x15153A0", Offset = "0x15145A0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D800")]
	[Token(Token = "0x6001208")]
	private static void Monitor_pulse(object obj) { }

	[Address(RVA = "0x1515390", Offset = "0x1514590", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D830")]
	[Token(Token = "0x600120A")]
	private static void Monitor_pulse_all(object obj) { }

	[Address(RVA = "0x15153B0", Offset = "0x15145B0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D860")]
	[Token(Token = "0x6001207")]
	private static bool Monitor_test_synchronised(object obj) { }

	[Address(RVA = "0x15153C0", Offset = "0x15145C0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D890")]
	[Token(Token = "0x600120C")]
	private static bool Monitor_wait(object obj, int ms) { }

	[Address(RVA = "0x1515440", Offset = "0x1514640", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D860")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D800")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SynchronizationLockException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6001209")]
	private static void ObjPulse(object obj) { }

	[Address(RVA = "0x15153D0", Offset = "0x15145D0", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D860")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SynchronizationLockException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600120B")]
	private static void ObjPulseAll(object obj) { }

	[Address(RVA = "0x15154B0", Offset = "0x15146B0", Length = "0xC5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D860")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D890")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(SynchronizationLockException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600120D")]
	private static bool ObjWait(bool exitContext, int millisecondsTimeout, object obj) { }

	[Address(RVA = "0x1515640", Offset = "0x1514840", Length = "0xB5")]
	[CalledBy(Type = "System.Net.Sockets.SafeSocketHandle", Member = "UnRegisterForBlockingSyscall", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D860")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D800")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(SynchronizationLockException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001205")]
	public static void Pulse(object obj) { }

	[Address(RVA = "0x1515580", Offset = "0x1514780", Length = "0xB5")]
	[CalledBy(Type = typeof(SemaphoreSlim), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.IO.DefaultWatcher", Member = "DispatchEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.IO.FileSystemWatcher", "System.IO.FileAction", typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D860")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(SynchronizationLockException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001206")]
	public static void PulseAll(object obj) { }

	[Address(RVA = "0x15157B0", Offset = "0x15149B0", Length = "0x6C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021E170")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6001210")]
	private static void ReliableEnter(object obj, ref bool lockTaken) { }

	[Address(RVA = "0x1515700", Offset = "0x1514900", Length = "0xAB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021E170")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600120F")]
	private static void ReliableEnterTimeout(object obj, int timeout, ref bool lockTaken) { }

	[Address(RVA = "0x1515820", Offset = "0x1514A20", Length = "0x6E")]
	[CalledBy(Type = typeof(SemaphoreSlim), Member = "WaitAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Boolean>))]
	[CalledBy(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SemaphoreSlim), Member = "CancellationTokenCanceledEventHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SemaphoreSlim), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ManualResetEventSlim), Member = "CancellationTokenCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.SemaphoreSlim+<WaitUntilCountOrTimeoutAsync>d__32", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ManualResetEventSlim), Member = "Wait", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(CancellationToken)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ManualResetEventSlim), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ManualResetEventSlim), Member = "LazyInitializeEvent", ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Console+WindowsConsole", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ManualResetEventSlim), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001201")]
	private static void ThrowLockTakenException() { }

	[Address(RVA = "0x15159B0", Offset = "0x1514BB0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021E170")]
	[Token(Token = "0x600120E")]
	private static void try_enter_with_atomic_var(object obj, int millisecondsTimeout, ref bool lockTaken) { }

	[Address(RVA = "0x1515890", Offset = "0x1514A90", Length = "0x114")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D860")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D890")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(SynchronizationLockException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001203")]
	public static bool Wait(object obj, int millisecondsTimeout, bool exitContext) { }

	[Address(RVA = "0x1515890", Offset = "0x1514A90", Length = "0x114")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D860")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D890")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(SynchronizationLockException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6001204")]
	public static bool Wait(object obj, int millisecondsTimeout) { }

}

