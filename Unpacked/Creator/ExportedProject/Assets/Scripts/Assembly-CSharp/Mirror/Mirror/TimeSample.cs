namespace Mirror;

[Token(Token = "0x2000097")]
public struct TimeSample
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001EE")]
	private readonly Stopwatch watch; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40001EF")]
	private double beginTime; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001F0")]
	private ExponentialMovingAverage ema; //Field offset: 0x10
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001F1")]
	public double average; //Field offset: 0x38

	[Address(RVA = "0x12A3F20", Offset = "0x12A3120", Length = "0xC9")]
	[CalledBy(Type = typeof(NetworkServer), Member = "Initialize", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Stopwatch), Member = "Start", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60004C1")]
	public TimeSample(int n) { }

	[Address(RVA = "0x12A3E20", Offset = "0x12A3020", Length = "0x6A")]
	[CalledBy(Type = typeof(NetworkServer), Member = "NetworkEarlyUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkServer), Member = "NetworkLateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Stopwatch), Member = "get_Elapsed", ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeSpan), Member = "get_TotalSeconds", ReturnType = typeof(double))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004C2")]
	public void Begin() { }

	[Address(RVA = "0x12A3E90", Offset = "0x12A3090", Length = "0x8A")]
	[CalledBy(Type = typeof(NetworkServer), Member = "NetworkEarlyUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkServer), Member = "NetworkLateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Stopwatch), Member = "get_Elapsed", ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeSpan), Member = "get_TotalSeconds", ReturnType = typeof(double))]
	[Calls(Type = typeof(ExponentialMovingAverage), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Interlocked), Member = "Exchange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Double&), typeof(double)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60004C3")]
	public void End() { }

}

