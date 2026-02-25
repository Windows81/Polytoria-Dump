namespace System.Threading;

[Token(Token = "0x200023C")]
public static class Interlocked
{

	[Address(RVA = "0x152A070", Offset = "0x1529270", Length = "0x5")]
	[CalledBy(Type = typeof(SpinLock), Member = "ContinueTryEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8A70")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x60012D8")]
	public static int Add(ref int location1, int value) { }

	[Address(RVA = "0x152A0B0", Offset = "0x15292B0", Length = "0x5")]
	[CallerCount(Count = 57)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8A90")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x60012C3")]
	public static int CompareExchange(ref int location1, int value, int comparand) { }

	[Address(RVA = "0x152A090", Offset = "0x1529290", Length = "0x5")]
	[CalledBy(Type = typeof(SpinLock), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SpinLock), Member = "TryEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SpinLock), Member = "ContinueTryEnter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SpinLock), Member = "ContinueTryEnterWithThreadTracking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint), typeof(Boolean&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WorkStealingQueue), Member = "LocalPop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(WorkStealingQueue), Member = "TrySteal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IThreadPoolWorkItem&), typeof(Boolean&), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8AA0")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x60012C4")]
	internal static int CompareExchange(ref int location1, int value, int comparand, ref bool succeeded) { }

	[Address(RVA = "0x152A080", Offset = "0x1529280", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8AF0")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x60012C5")]
	private static void CompareExchange(ref object location1, ref object value, ref object comparand, ref object result) { }

	[Address(RVA = "0x152A0C0", Offset = "0x15292C0", Length = "0x35")]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8AF0")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x60012C6")]
	public static object CompareExchange(ref object location1, object value, object comparand) { }

	[Address(RVA = "0x152A100", Offset = "0x1529300", Length = "0x5")]
	[CalledBy(Type = "UnityEngineInternal.MathfInternal", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B10")]
	[Token(Token = "0x60012C7")]
	public static float CompareExchange(ref float location1, float value, float comparand) { }

	[ComVisible(False)]
	[Intrinsic]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x60012D2")]
	public static T CompareExchange(ref T location1, T value, T comparand) { }

	[Address(RVA = "0x152A0A0", Offset = "0x15292A0", Length = "0x5")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8A80")]
	[DeduplicatedMethod]
	[Token(Token = "0x60012CF")]
	public static long CompareExchange(ref long location1, long value, long comparand) { }

	[Address(RVA = "0x152A0A0", Offset = "0x15292A0", Length = "0x5")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8A80")]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x60012D0")]
	public static IntPtr CompareExchange(ref IntPtr location1, IntPtr value, IntPtr comparand) { }

	[Address(RVA = "0x152A110", Offset = "0x1529310", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8AC0")]
	[Token(Token = "0x60012D1")]
	public static double CompareExchange(ref double location1, double value, double comparand) { }

	[Address(RVA = "0x152A120", Offset = "0x1529320", Length = "0x5")]
	[CalledBy(Type = typeof(SpinLock), Member = "Exit", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SpinLock), Member = "ExitSlowPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.ServicePointScheduler+ConnectionGroup", Member = "RemoveConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.WebConnection"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.ServicePointScheduler+ConnectionGroup", Member = "Cleanup", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.ServicePointScheduler+ConnectionGroup", Member = "Close", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.ServicePointScheduler", Member = "OnConnectionClosed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.WebConnection"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UnitySynchronizationContext", Member = "OperationCompleted", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.ArrayBuffer", Member = "Release", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.BufferBucket", Member = "DecrementCreated", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B70")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x60012C8")]
	public static int Decrement(ref int location) { }

	[ComVisible(False)]
	[Intrinsic]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x60012D6")]
	public static T Exchange(ref T location1, T value) { }

	[Address(RVA = "0x152A1A0", Offset = "0x15293A0", Length = "0x5")]
	[CalledBy(Type = "Mirror.TimeSample", Member = "End", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8BA0")]
	[Token(Token = "0x60012D5")]
	public static double Exchange(ref double location1, double value) { }

	[Address(RVA = "0x152A140", Offset = "0x1529340", Length = "0x5")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B80")]
	[DeduplicatedMethod]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x60012D4")]
	public static IntPtr Exchange(ref IntPtr location1, IntPtr value) { }

	[Address(RVA = "0x152A140", Offset = "0x1529340", Length = "0x5")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B80")]
	[DeduplicatedMethod]
	[Token(Token = "0x60012D3")]
	public static long Exchange(ref long location1, long value) { }

	[Address(RVA = "0x152A190", Offset = "0x1529390", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8BF0")]
	[Token(Token = "0x60012CE")]
	public static float Exchange(ref float location1, float value) { }

	[Address(RVA = "0x152A130", Offset = "0x1529330", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8BC0")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x60012CC")]
	private static void Exchange(ref object location1, ref object value, ref object result) { }

	[Address(RVA = "0x152A150", Offset = "0x1529350", Length = "0x5")]
	[CallerCount(Count = 32)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B90")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x60012CB")]
	public static int Exchange(ref int location1, int value) { }

	[Address(RVA = "0x152A160", Offset = "0x1529360", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8BC0")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x60012CD")]
	public static object Exchange(ref object location1, object value) { }

	[Address(RVA = "0x152A1B0", Offset = "0x15293B0", Length = "0x5")]
	[CalledBy(Type = "System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue", Member = "LocalPush", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(Int64&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.BouncyCastle.Security.SecureRandom", Member = "NextCounterValue", ReturnType = typeof(long))]
	[CalledBy(Type = "Mirror.BouncyCastle.Security.SecureRandom", Member = "AutoSeed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.BouncyCastle.Crypto.Prng.IRandomGenerator", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.ReaderWriterLockSlim", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Threading.ReaderWriterLockSlim", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Threading.LockRecursionPolicy"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Http.HttpClientHandler", Member = "CreateDefaultHandler", ReturnType = "System.Net.Http.IMonoHttpClientHandler")]
	[CalledBy(Type = "System.Net.Http.HttpClientHandler", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Http.MonoWebRequestHandler", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8C10")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x60012CA")]
	public static long Increment(ref long location) { }

	[Address(RVA = "0x152A1C0", Offset = "0x15293C0", Length = "0x5")]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8C20")]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	[Token(Token = "0x60012C9")]
	public static int Increment(ref int location) { }

	[Address(RVA = "0x152A1D0", Offset = "0x15293D0", Length = "0x7")]
	[CalledBy(Type = "System.Console+WindowsConsole", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CancellationTokenSource), Member = "ExecuteCallbackHandlers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Collections.Concurrent.ConcurrentBag`1", Member = "FreezeBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Thread), Member = "MemoryBarrier", ReturnType = typeof(void))]
	[Token(Token = "0x60012D9")]
	public static void MemoryBarrier() { }

	[Address(RVA = "0x152A1E0", Offset = "0x15293E0", Length = "0x5")]
	[CalledBy(Type = typeof(Buffer), Member = "Memcpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "get_Length", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "get_Position", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "get_PositionPointer", ReturnType = typeof(Byte*))]
	[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "ReadCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "ReadByte", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "Seek", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(SeekOrigin)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "SetLength", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "WriteCore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "WriteByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Collections.Concurrent.ConcurrentBag`1", Member = "TrySteal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8C30")]
	[Token(Token = "0x60012D7")]
	public static long Read(ref long location) { }

}

