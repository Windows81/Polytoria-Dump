namespace Mirror;

[Token(Token = "0x2000093")]
public struct ExponentialMovingAverage
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001E7")]
	private readonly double alpha; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40001E8")]
	private bool initialized; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001E9")]
	public double Value; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001EA")]
	public double Variance; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001EB")]
	public double StandardDeviation; //Field offset: 0x20

	[Address(RVA = "0x1289170", Offset = "0x1288370", Length = "0x2E")]
	[CalledBy(Type = typeof(NetworkClient), Member = "InitTimeInterpolation", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkConnectionToClient), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkConnectionToClient), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60004AE")]
	public ExponentialMovingAverage(int n) { }

	[Address(RVA = "0x1289080", Offset = "0x1288280", Length = "0xCB")]
	[CalledBy(Type = typeof(NetworkTime), Member = "OnClientPong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkPongMessage)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkTime), Member = "OnServerPong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient), typeof(NetworkPongMessage)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SnapshotInterpolation), Member = "InsertAndAdjust", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedList`2<Double, T>", typeof(int), "T", typeof(Double&), typeof(Double&), typeof(float), typeof(double), typeof(double), typeof(double), typeof(ExponentialMovingAverage&), typeof(float), typeof(float), typeof(ExponentialMovingAverage&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TimeSample), Member = "End", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60004AF")]
	public void Add(double newValue) { }

	[Address(RVA = "0x1289150", Offset = "0x1288350", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60004B0")]
	public void Reset() { }

}

