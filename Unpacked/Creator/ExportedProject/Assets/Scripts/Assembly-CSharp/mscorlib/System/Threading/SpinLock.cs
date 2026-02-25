namespace System.Threading;

[ComVisible(False)]
[DebuggerDisplay("IsHeld = {IsHeld}")]
[DebuggerTypeProxy(typeof(SystemThreading_SpinLockDebugView))]
[Token(Token = "0x2000213")]
public struct SpinLock
{
	[Token(Token = "0x2000214")]
	public class SystemThreading_SpinLockDebugView
	{

	}

	[Token(Token = "0x40009F1")]
	private static int MAXIMUM_WAITERS; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40009F0")]
	private int m_owner; //Field offset: 0x0

	[Token(Token = "0x170001A4")]
	public bool IsHeldByCurrentThread
	{
		[Address(RVA = "0x1518C00", Offset = "0x1517E00", Length = "0x12D")]
		[CalledBy(Type = typeof(SpinLock), Member = "ExitSlowPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D6A0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D550")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
		[Token(Token = "0x60011B3")]
		 get { } //Length: 301
	}

	[Token(Token = "0x170001A5")]
	public bool IsThreadOwnerTrackingEnabled
	{
		[Address(RVA = "0x1518D30", Offset = "0x1517F30", Length = "0x1C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
		[Token(Token = "0x60011B4")]
		 get { } //Length: 28
	}

	[Address(RVA = "0x1518B80", Offset = "0x1517D80", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60011B5")]
	private static SpinLock() { }

	[Address(RVA = "0x1518BC0", Offset = "0x1517DC0", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Token(Token = "0x60011AA")]
	public SpinLock(bool enableThreadOwnerTracking) { }

	[Address(RVA = "0x1518210", Offset = "0x1517410", Length = "0x4A3")]
	[CalledBy(Type = typeof(SpinLock), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SpinLock), Member = "TryEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WorkStealingQueue), Member = "LocalPop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(WorkStealingQueue), Member = "TrySteal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem&), typeof(Boolean&), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Thread), Member = "BeginCriticalRegion", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(SpinLock), Member = "ContinueTryEnterWithThreadTracking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SpinLock), Member = "DecrementWaiters", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021DBA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021E160")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_custom_attrs_free")]
	[Calls(Type = typeof(PlatformHelper), Member = "get_ProcessorCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(TimeoutHelper), Member = "UpdateTimeOut", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Interlocked), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Thread), Member = "EndCriticalRegion", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int), typeof(Boolean&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60011AD")]
	private void ContinueTryEnter(int millisecondsTimeout, ref bool lockTaken) { }

	[Address(RVA = "0x1517F90", Offset = "0x1517190", Length = "0x274")]
	[CalledBy(Type = typeof(SpinLock), Member = "ContinueTryEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SpinWait), Member = "SpinOnceCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Thread), Member = "EndCriticalRegion", ReturnType = typeof(void))]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int), typeof(Boolean&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Thread), Member = "BeginCriticalRegion", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(LockRecursionException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D550")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D6A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60011AF")]
	private void ContinueTryEnterWithThreadTracking(int millisecondsTimeout, uint startTime, ref bool lockTaken) { }

	[Address(RVA = "0x15186C0", Offset = "0x15178C0", Length = "0xD4")]
	[CalledBy(Type = typeof(SpinLock), Member = "ContinueTryEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SpinWait), Member = "SpinOnceCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x60011AE")]
	private void DecrementWaiters() { }

	[Address(RVA = "0x15187A0", Offset = "0x15179A0", Length = "0xAF")]
	[CalledBy(Type = "UnityEngine.Awaitable", Member = "PropagateExceptionAndRelease", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WorkStealingQueue), Member = "LocalPush", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WorkStealingQueue), Member = "LocalFindAndPop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Vector3", Member = "op_UnaryNegation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Vector3"}, ReturnType = "UnityEngine.Vector3")]
	[CalledBy(Type = "UnityEngine.Awaitable", Member = "SetExceptionFromNative", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Awaitable", Member = "RunContinuation", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Awaitable", Member = "RaiseManagedCompletion", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Awaitable", Member = "get_IsCompleted", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Awaitable", Member = "get_IsDettachedOrCompleted", ReturnType = typeof(bool))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int), typeof(Boolean&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(SpinLock), Member = "ContinueTryEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Thread), Member = "BeginCriticalRegion", ReturnType = typeof(void))]
	[Token(Token = "0x60011AB")]
	public void Enter(ref bool lockTaken) { }

	[Address(RVA = "0x1518A20", Offset = "0x1517C20", Length = "0x87")]
	[CalledBy(Type = "UnityEngine.Vector3", Member = "op_UnaryNegation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Vector3"}, ReturnType = "UnityEngine.Vector3")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Interlocked), Member = "Decrement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Thread), Member = "EndCriticalRegion", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SpinLock), Member = "ExitSlowPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x60011B0")]
	public void Exit() { }

	[Address(RVA = "0x1518990", Offset = "0x1517B90", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SpinLock), Member = "ExitSlowPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Thread), Member = "EndCriticalRegion", ReturnType = typeof(void))]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x60011B1")]
	public void Exit(bool useMemoryBarrier) { }

	[Address(RVA = "0x1518850", Offset = "0x1517A50", Length = "0x13B")]
	[CalledBy(Type = "System.Console+WindowsConsole", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SpinLock), Member = "Exit", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SpinLock), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(SpinLock), Member = "get_IsHeldByCurrentThread", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Interlocked), Member = "Decrement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SynchronizationLockException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60011B2")]
	private void ExitSlowPath(bool useMemoryBarrier) { }

	[Address(RVA = "0x1518C00", Offset = "0x1517E00", Length = "0x12D")]
	[CalledBy(Type = typeof(SpinLock), Member = "ExitSlowPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D550")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D6A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE610")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x60011B3")]
	public bool get_IsHeldByCurrentThread() { }

	[Address(RVA = "0x1518D30", Offset = "0x1517F30", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x60011B4")]
	public bool get_IsThreadOwnerTrackingEnabled() { }

	[Address(RVA = "0x1518AB0", Offset = "0x1517CB0", Length = "0xC2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Thread), Member = "BeginCriticalRegion", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int), typeof(int), typeof(Boolean&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SpinLock), Member = "ContinueTryEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Boolean&)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60011AC")]
	public void TryEnter(int millisecondsTimeout, ref bool lockTaken) { }

}

