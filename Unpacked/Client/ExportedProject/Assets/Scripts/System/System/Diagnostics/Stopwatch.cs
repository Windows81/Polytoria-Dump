namespace System.Diagnostics;

[Token(Token = "0x200010C")]
public class Stopwatch
{
	[Token(Token = "0x40004B5")]
	public static readonly long Frequency; //Field offset: 0x0
	[Token(Token = "0x40004B6")]
	public static readonly bool IsHighResolution; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004B7")]
	private long elapsed; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004B8")]
	private long started; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40004B9")]
	private bool is_running; //Field offset: 0x20

	[Token(Token = "0x17000103")]
	public TimeSpan Elapsed
	{
		[Address(RVA = "0x17815F0", Offset = "0x17807F0", Length = "0x198")]
		[CalledBy(Type = "Mirror.WorkerThread", Member = "StopBlocking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "Mirror.TimeSample", Member = "Begin", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.TimeSample", Member = "End", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.ThreadedTransport", Member = "ThreadTick", ReturnType = typeof(bool))]
		[CalledBy(Type = "Mirror.Transports.Encryption.ThreadedEncryptionKcpTransport", Member = "ThreadedClientLateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.Transports.Encryption.ThreadedEncryptionKcpTransport", Member = "ThreadedServerLateUpdate", ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D7E0")]
		[CallsDeduplicatedMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000666")]
		 get { } //Length: 408
	}

	[Token(Token = "0x17000104")]
	public long ElapsedMilliseconds
	{
		[Address(RVA = "0x1781290", Offset = "0x1780490", Length = "0x2E3")]
		[CalledBy(Type = "kcp2k.KcpPeer", Member = "TickOutgoing", ReturnType = typeof(void))]
		[CalledBy(Type = "MoonSharp.Interpreter.Diagnostics.PerformanceCounters.GlobalPerformanceStopwatch+GlobalPerformanceStopwatch_StopwatchObject", Member = "Dispose", ReturnType = typeof(void))]
		[CalledBy(Type = "MoonSharp.Interpreter.Diagnostics.PerformanceCounters.GlobalPerformanceStopwatch", Member = "SignalStopwatchTerminated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stopwatch)}, ReturnType = typeof(void))]
		[CalledBy(Type = "MoonSharp.Interpreter.Diagnostics.PerformanceCounters.PerformanceStopwatch", Member = "GetResult", ReturnType = "MoonSharp.Interpreter.Diagnostics.PerformanceResult")]
		[CalledBy(Type = "UnityEngine.UnitySynchronizationContext", Member = "ExecutePendingTasks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "kcp2k.KcpPeer", Member = "ReceiveNextReliable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"kcp2k.KcpHeaderReliable&", "System.ArraySegment`1<Byte>&"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "kcp2k.KcpPeer", Member = "TickIncoming", ReturnType = typeof(void))]
		[CalledBy(Type = "kcp2k.KcpPeer", Member = "OnRawInputUnreliable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ArraySegment`1<Byte>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE5F0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D7E0")]
		[Calls(Type = typeof(TimeSpan), Member = "get_TotalMilliseconds", ReturnType = typeof(double))]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000667")]
		 get { } //Length: 739
	}

	[Token(Token = "0x17000105")]
	public long ElapsedTicks
	{
		[Address(RVA = "0x1781580", Offset = "0x1780780", Length = "0x63")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D7E0")]
		[Token(Token = "0x6000668")]
		 get { } //Length: 99
	}

	[Address(RVA = "0x1781240", Offset = "0x1780440", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600066C")]
	private static Stopwatch() { }

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000665")]
	public Stopwatch() { }

	[Address(RVA = "0x17815F0", Offset = "0x17807F0", Length = "0x198")]
	[CalledBy(Type = "Mirror.WorkerThread", Member = "StopBlocking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Mirror.TimeSample", Member = "Begin", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.TimeSample", Member = "End", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.ThreadedTransport", Member = "ThreadTick", ReturnType = typeof(bool))]
	[CalledBy(Type = "Mirror.Transports.Encryption.ThreadedEncryptionKcpTransport", Member = "ThreadedClientLateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Transports.Encryption.ThreadedEncryptionKcpTransport", Member = "ThreadedServerLateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D7E0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000666")]
	public TimeSpan get_Elapsed() { }

	[Address(RVA = "0x1781290", Offset = "0x1780490", Length = "0x2E3")]
	[CalledBy(Type = "kcp2k.KcpPeer", Member = "TickOutgoing", ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.Diagnostics.PerformanceCounters.GlobalPerformanceStopwatch+GlobalPerformanceStopwatch_StopwatchObject", Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.Diagnostics.PerformanceCounters.GlobalPerformanceStopwatch", Member = "SignalStopwatchTerminated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stopwatch)}, ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.Diagnostics.PerformanceCounters.PerformanceStopwatch", Member = "GetResult", ReturnType = "MoonSharp.Interpreter.Diagnostics.PerformanceResult")]
	[CalledBy(Type = "UnityEngine.UnitySynchronizationContext", Member = "ExecutePendingTasks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "kcp2k.KcpPeer", Member = "ReceiveNextReliable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"kcp2k.KcpHeaderReliable&", "System.ArraySegment`1<Byte>&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "kcp2k.KcpPeer", Member = "TickIncoming", ReturnType = typeof(void))]
	[CalledBy(Type = "kcp2k.KcpPeer", Member = "OnRawInputUnreliable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ArraySegment`1<Byte>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE5F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D7E0")]
	[Calls(Type = typeof(TimeSpan), Member = "get_TotalMilliseconds", ReturnType = typeof(double))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000667")]
	public long get_ElapsedMilliseconds() { }

	[Address(RVA = "0x1781580", Offset = "0x1780780", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D7E0")]
	[Token(Token = "0x6000668")]
	public long get_ElapsedTicks() { }

	[Address(RVA = "0x153A130", Offset = "0x1539330", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D7E0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000663")]
	public static long GetTimestamp() { }

	[Address(RVA = "0x1781060", Offset = "0x1780260", Length = "0x55")]
	[CalledBy(Type = "Mirror.WorkerThread", Member = "StopBlocking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "kcp2k.KcpPeer", Member = "Reset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"kcp2k.KcpConfig"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D7E0")]
	[Token(Token = "0x600066B")]
	public void Restart() { }

	[Address(RVA = "0x1781160", Offset = "0x1780360", Length = "0x53")]
	[CalledBy(Type = "MoonSharp.Interpreter.Diagnostics.PerformanceCounters.PerformanceStopwatch", Member = "Start", ReturnType = typeof(IDisposable))]
	[CalledBy(Type = "UnityEngine.UnitySynchronizationContext", Member = "ExecutePendingTasks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Mirror.TimeSample", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D7E0")]
	[Token(Token = "0x6000669")]
	public void Start() { }

	[Address(RVA = "0x17810C0", Offset = "0x17802C0", Length = "0x92")]
	[CalledBy(Type = "MoonSharp.Interpreter.Diagnostics.PerformanceCounters.GlobalPerformanceStopwatch+GlobalPerformanceStopwatch_StopwatchObject", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"MoonSharp.Interpreter.Diagnostics.PerformanceCounters.GlobalPerformanceStopwatch"}, ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.Diagnostics.PerformanceCounters.GlobalPerformanceStopwatch", Member = "Start", ReturnType = typeof(IDisposable))]
	[CalledBy(Type = "Mirror.Transports.Encryption.ThreadedEncryptionKcpTransport", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D7E0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000664")]
	public static Stopwatch StartNew() { }

	[Address(RVA = "0x17811C0", Offset = "0x17803C0", Length = "0x72")]
	[CalledBy(Type = "MoonSharp.Interpreter.Diagnostics.PerformanceCounters.GlobalPerformanceStopwatch+GlobalPerformanceStopwatch_StopwatchObject", Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = "MoonSharp.Interpreter.Diagnostics.PerformanceCounters.PerformanceStopwatch", Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18021D7E0")]
	[Token(Token = "0x600066A")]
	public void Stop() { }

}

