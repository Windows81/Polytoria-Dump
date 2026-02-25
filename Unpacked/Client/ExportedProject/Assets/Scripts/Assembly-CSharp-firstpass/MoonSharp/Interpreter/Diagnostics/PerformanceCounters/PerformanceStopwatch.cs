namespace MoonSharp.Interpreter.Diagnostics.PerformanceCounters;

[Token(Token = "0x200015E")]
internal class PerformanceStopwatch : IDisposable, IPerformanceStopwatch
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400058E")]
	private Stopwatch m_Stopwatch; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400058F")]
	private int m_Count; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000590")]
	private int m_Reentrant; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000591")]
	private PerformanceCounter m_Counter; //Field offset: 0x20

	[Address(RVA = "0x388200", Offset = "0x387400", Length = "0x76")]
	[CalledBy(Type = typeof(PerformanceStatistics), Member = "set_Enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000CE4")]
	public PerformanceStopwatch(PerformanceCounter perfcounter) { }

	[Address(RVA = "0x3880C0", Offset = "0x3872C0", Length = "0x28")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Stopwatch), Member = "Stop", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CE6")]
	public override void Dispose() { }

	[Address(RVA = "0x3880F0", Offset = "0x3872F0", Length = "0xC3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Stopwatch), Member = "get_ElapsedMilliseconds", ReturnType = typeof(long))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000CE7")]
	public override PerformanceResult GetResult() { }

	[Address(RVA = "0x3881C0", Offset = "0x3873C0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Stopwatch), Member = "Start", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CE5")]
	public override IDisposable Start() { }

}

