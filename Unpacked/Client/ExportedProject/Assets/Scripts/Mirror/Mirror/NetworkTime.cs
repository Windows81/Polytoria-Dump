namespace Mirror;

[Token(Token = "0x200006A")]
public static class NetworkTime
{
	[Token(Token = "0x400017B")]
	private const float DefaultPingInterval = 0.1; //Field offset: 0x0
	[Token(Token = "0x400017C")]
	public static float PingInterval; //Field offset: 0x0
	[Token(Token = "0x400017D")]
	public const int PingWindowSize = 50; //Field offset: 0x0
	[Token(Token = "0x400017E")]
	private static double lastPingTime; //Field offset: 0x8
	[Token(Token = "0x400017F")]
	private static ExponentialMovingAverage _rtt; //Field offset: 0x10
	[Token(Token = "0x4000180")]
	private static int PredictionErrorWindowSize; //Field offset: 0x38
	[Token(Token = "0x4000181")]
	private static ExponentialMovingAverage _predictionErrorUnadjusted; //Field offset: 0x40
	[CompilerGenerated]
	[Token(Token = "0x4000182")]
	private static double <predictionErrorAdjusted>k__BackingField; //Field offset: 0x68

	[Token(Token = "0x17000056")]
	public static double localTime
	{
		[Address(RVA = "0x129E050", Offset = "0x129D250", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Time), Member = "get_unscaledTimeAsDouble", ReturnType = typeof(double))]
		[Token(Token = "0x600035E")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700005B")]
	public static double offset
	{
		[Address(RVA = "0x129E060", Offset = "0x129D260", Length = "0x13E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Time), Member = "get_unscaledTimeAsDouble", ReturnType = typeof(double))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000364")]
		 get { } //Length: 318
	}

	[Token(Token = "0x1700005A")]
	public static double predictedTime
	{
		[Address(RVA = "0x129E1A0", Offset = "0x129D3A0", Length = "0x117")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Time), Member = "get_unscaledTimeAsDouble", ReturnType = typeof(double))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000363")]
		 get { } //Length: 279
	}

	[Token(Token = "0x17000059")]
	public private static double predictionErrorAdjusted
	{
		[Address(RVA = "0x129E2C0", Offset = "0x129D4C0", Length = "0x50")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[Token(Token = "0x6000361")]
		 get { } //Length: 80
		[Address(RVA = "0x129E4F0", Offset = "0x129D6F0", Length = "0x5D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[Token(Token = "0x6000362")]
		private set { } //Length: 93
	}

	[Token(Token = "0x17000058")]
	public static double predictionErrorUnadjusted
	{
		[Address(RVA = "0x129E310", Offset = "0x129D510", Length = "0x50")]
		[CalledBy(Type = typeof(NetworkClient), Member = "OnGUI", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.PredictedRigidbody", Member = "RecordState", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000360")]
		 get { } //Length: 80
	}

	[Token(Token = "0x1700005C")]
	public static double rtt
	{
		[Address(RVA = "0x129E3B0", Offset = "0x129D5B0", Length = "0x50")]
		[CalledBy(Type = typeof(NetworkClient), Member = "OnGUI", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkClient), Member = "<NetworkLateUpdate>g__UpdateConnectionQuality|106_0", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkPingDisplay", Member = "OnGUI", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkPingGraph", Member = "CollectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Single&), "Mirror.GraphAggregationMode&"}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000365")]
		 get { } //Length: 80
	}

	[Token(Token = "0x1700005D")]
	public static double rttVariance
	{
		[Address(RVA = "0x129E360", Offset = "0x129D560", Length = "0x50")]
		[CalledBy(Type = typeof(NetworkClient), Member = "<NetworkLateUpdate>g__UpdateConnectionQuality|106_0", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkPingGraph", Member = "CollectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Single&), "Mirror.GraphAggregationMode&"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000366")]
		 get { } //Length: 80
	}

	[Token(Token = "0x17000057")]
	public static double time
	{
		[Address(RVA = "0x129E400", Offset = "0x129D600", Length = "0xE5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Time), Member = "get_unscaledTimeAsDouble", ReturnType = typeof(double))]
		[Token(Token = "0x600035F")]
		 get { } //Length: 229
	}

	[Address(RVA = "0x129DF60", Offset = "0x129D160", Length = "0xE7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600036F")]
	private static NetworkTime() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600036E")]
	internal static void EarlyUpdate() { }

	[Address(RVA = "0x129E050", Offset = "0x129D250", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "get_unscaledTimeAsDouble", ReturnType = typeof(double))]
	[Token(Token = "0x600035E")]
	public static double get_localTime() { }

	[Address(RVA = "0x129E060", Offset = "0x129D260", Length = "0x13E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Time), Member = "get_unscaledTimeAsDouble", ReturnType = typeof(double))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000364")]
	public static double get_offset() { }

	[Address(RVA = "0x129E1A0", Offset = "0x129D3A0", Length = "0x117")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Time), Member = "get_unscaledTimeAsDouble", ReturnType = typeof(double))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000363")]
	public static double get_predictedTime() { }

	[Address(RVA = "0x129E2C0", Offset = "0x129D4C0", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[Token(Token = "0x6000361")]
	public static double get_predictionErrorAdjusted() { }

	[Address(RVA = "0x129E310", Offset = "0x129D510", Length = "0x50")]
	[CalledBy(Type = typeof(NetworkClient), Member = "OnGUI", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.PredictedRigidbody", Member = "RecordState", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000360")]
	public static double get_predictionErrorUnadjusted() { }

	[Address(RVA = "0x129E3B0", Offset = "0x129D5B0", Length = "0x50")]
	[CalledBy(Type = typeof(NetworkClient), Member = "OnGUI", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkClient), Member = "<NetworkLateUpdate>g__UpdateConnectionQuality|106_0", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkPingDisplay", Member = "OnGUI", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkPingGraph", Member = "CollectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Single&), "Mirror.GraphAggregationMode&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000365")]
	public static double get_rtt() { }

	[Address(RVA = "0x129E360", Offset = "0x129D560", Length = "0x50")]
	[CalledBy(Type = typeof(NetworkClient), Member = "<NetworkLateUpdate>g__UpdateConnectionQuality|106_0", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkPingGraph", Member = "CollectData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Single&), "Mirror.GraphAggregationMode&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000366")]
	public static double get_rttVariance() { }

	[Address(RVA = "0x129E400", Offset = "0x129D600", Length = "0xE5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Time), Member = "get_unscaledTimeAsDouble", ReturnType = typeof(double))]
	[Token(Token = "0x600035F")]
	public static double get_time() { }

	[Address(RVA = "0x129D700", Offset = "0x129C900", Length = "0xA0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkClient), Member = "Send", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600036C")]
	internal static void OnClientPing(NetworkPingMessage message) { }

	[Address(RVA = "0x129D7A0", Offset = "0x129C9A0", Length = "0x133")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Time), Member = "get_unscaledTimeAsDouble", ReturnType = typeof(double))]
	[Calls(Type = typeof(ExponentialMovingAverage), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600036B")]
	internal static void OnClientPong(NetworkPongMessage message) { }

	[Address(RVA = "0x129D8E0", Offset = "0x129CAE0", Length = "0xEA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Time), Member = "get_unscaledTimeAsDouble", ReturnType = typeof(double))]
	[Calls(Type = typeof(NetworkConnection), Member = "Send", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600036A")]
	internal static void OnServerPing(NetworkConnectionToClient conn, NetworkPingMessage message) { }

	[Address(RVA = "0x129D9D0", Offset = "0x129CBD0", Length = "0xA2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Time), Member = "get_unscaledTimeAsDouble", ReturnType = typeof(double))]
	[Calls(Type = typeof(ExponentialMovingAverage), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600036D")]
	internal static void OnServerPong(NetworkConnectionToClient conn, NetworkPongMessage message) { }

	[Address(RVA = "0x129DA80", Offset = "0x129CC80", Length = "0xA8")]
	[CalledBy(Type = typeof(NetworkClient), Member = "OnTransportConnected", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[RuntimeInitializeOnLoadMethod]
	[Token(Token = "0x6000367")]
	public static void ResetStatics() { }

	[Address(RVA = "0x129DB30", Offset = "0x129CD30", Length = "0x1DD")]
	[CalledBy(Type = typeof(NetworkClient), Member = "OnTransportConnected", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Time), Member = "get_unscaledTimeAsDouble", ReturnType = typeof(double))]
	[Calls(Type = typeof(NetworkClient), Member = "Send", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000369")]
	internal static void SendPing() { }

	[Address(RVA = "0x129E4F0", Offset = "0x129D6F0", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[Token(Token = "0x6000362")]
	private static void set_predictionErrorAdjusted(double value) { }

	[Address(RVA = "0x129DD10", Offset = "0x129CF10", Length = "0x24E")]
	[CalledBy(Type = typeof(NetworkClient), Member = "NetworkLateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Time), Member = "get_unscaledTimeAsDouble", ReturnType = typeof(double))]
	[Calls(Type = typeof(NetworkClient), Member = "Send", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000368")]
	internal static void UpdateClient() { }

}

