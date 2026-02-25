namespace MoonSharp.Interpreter.Diagnostics.PerformanceCounters;

[Token(Token = "0x200015B")]
internal class GlobalPerformanceStopwatch : IPerformanceStopwatch
{
	[Token(Token = "0x200015C")]
	private class GlobalPerformanceStopwatch_StopwatchObject : IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400058C")]
		private Stopwatch m_Stopwatch; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400058D")]
		private GlobalPerformanceStopwatch m_Parent; //Field offset: 0x18

		[Address(RVA = "0x379B00", Offset = "0x378D00", Length = "0x7C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Stopwatch), Member = "StartNew", ReturnType = typeof(Stopwatch))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000CE0")]
		public GlobalPerformanceStopwatch_StopwatchObject(GlobalPerformanceStopwatch parent) { }

		[Address(RVA = "0x379AA0", Offset = "0x378CA0", Length = "0x5E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Stopwatch), Member = "Stop", ReturnType = typeof(void))]
		[Calls(Type = typeof(Stopwatch), Member = "get_ElapsedMilliseconds", ReturnType = typeof(long))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000CE1")]
		public override void Dispose() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000589")]
	private int m_Count; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400058A")]
	private long m_Elapsed; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400058B")]
	private PerformanceCounter m_Counter; //Field offset: 0x20

	[Address(RVA = "0x379B80", Offset = "0x378D80", Length = "0x24")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000CDC")]
	public GlobalPerformanceStopwatch(PerformanceCounter perfcounter) { }

	[Address(RVA = "0x3798F0", Offset = "0x378AF0", Length = "0xB7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000CDF")]
	public override PerformanceResult GetResult() { }

	[Address(RVA = "0x3799B0", Offset = "0x378BB0", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Stopwatch), Member = "get_ElapsedMilliseconds", ReturnType = typeof(long))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CDD")]
	private void SignalStopwatchTerminated(Stopwatch sw) { }

	[Address(RVA = "0x3799F0", Offset = "0x378BF0", Length = "0xA8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Stopwatch), Member = "StartNew", ReturnType = typeof(Stopwatch))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000CDE")]
	public override IDisposable Start() { }

}

