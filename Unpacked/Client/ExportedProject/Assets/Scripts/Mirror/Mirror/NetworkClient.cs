namespace Mirror;

[Token(Token = "0x200003D")]
public static class NetworkClient
{
	[CompilerGenerated]
	[Token(Token = "0x200003E")]
	private sealed class <>c
	{
		[Token(Token = "0x40000C0")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40000C1")]
		public static Action<ObjectDestroyMessage> <>9__60_0; //Field offset: 0x8
		[Token(Token = "0x40000C2")]
		public static Action<NetworkPongMessage> <>9__60_1; //Field offset: 0x10
		[Token(Token = "0x40000C3")]
		public static Action<ObjectSpawnStartedMessage> <>9__60_2; //Field offset: 0x18
		[Token(Token = "0x40000C4")]
		public static Action<ObjectSpawnFinishedMessage> <>9__60_3; //Field offset: 0x20
		[Token(Token = "0x40000C5")]
		public static Action<EntityStateMessage> <>9__60_4; //Field offset: 0x28
		[Token(Token = "0x40000C6")]
		public static Func<NetworkIdentity, UInt32> <>9__92_0; //Field offset: 0x30

		[Address(RVA = "0x126F760", Offset = "0x126E960", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60001A4")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001A5")]
		public <>c() { }

		[Address(RVA = "0x126F400", Offset = "0x126E600", Length = "0x16")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60001AB")]
		internal uint <OnObjectSpawnFinished>b__92_0(NetworkIdentity uv) { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001A6")]
		internal void <RegisterMessageHandlers>b__60_0(ObjectDestroyMessage _) { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001A7")]
		internal void <RegisterMessageHandlers>b__60_1(NetworkPongMessage _) { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001A8")]
		internal void <RegisterMessageHandlers>b__60_2(ObjectSpawnStartedMessage _) { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001A9")]
		internal void <RegisterMessageHandlers>b__60_3(ObjectSpawnFinishedMessage _) { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001AA")]
		internal void <RegisterMessageHandlers>b__60_4(EntityStateMessage _) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200003F")]
	private sealed class <>c__DisplayClass61_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000C7")]
		public Action<T> handler; //Field offset: 0x0

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001AC")]
		public <>c__DisplayClass61_0`1() { }

		[Address(RVA = "0x800D60", Offset = "0x7FFF60", Length = "0x2B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001AD")]
		internal void <RegisterHandler>g__HandlerWrapped|0(NetworkConnection _, T value) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000040")]
	private sealed class <>c__DisplayClass62_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000C8")]
		public Action<T, Int32> handler; //Field offset: 0x0

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001AE")]
		public <>c__DisplayClass62_0`1() { }

		[Address(RVA = "0x800D90", Offset = "0x7FFF90", Length = "0xD5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001AF")]
		internal void <RegisterHandler>g__HandlerWrapped|0(NetworkConnection _, T value, int channelId) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000041")]
	private sealed class <>c__DisplayClass63_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000C9")]
		public Action<T> handler; //Field offset: 0x0

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001B0")]
		public <>c__DisplayClass63_0`1() { }

		[Address(RVA = "0x800C80", Offset = "0x7FFE80", Length = "0xA9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001B1")]
		internal void <ReplaceHandler>g__HandlerWrapped|0(NetworkConnection _, T value) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000042")]
	private sealed class <>c__DisplayClass64_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40000CA")]
		public Action<T, Int32> handler; //Field offset: 0x0

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001B2")]
		public <>c__DisplayClass64_0`1() { }

		[Address(RVA = "0x800D90", Offset = "0x7FFF90", Length = "0xD5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180282E20")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B72C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001B3")]
		internal void <ReplaceHandler>g__HandlerWrapped|0(NetworkConnection _, T value, int channelId) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000043")]
	private sealed class <>c__DisplayClass70_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000CB")]
		public SpawnDelegate spawnHandler; //Field offset: 0x10

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001B4")]
		public <>c__DisplayClass70_0() { }

		[Address(RVA = "0x126F710", Offset = "0x126E910", Length = "0x40")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001B5")]
		internal GameObject <RegisterPrefab>b__0(SpawnMessage msg) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000044")]
	private sealed class <>c__DisplayClass71_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000CC")]
		public SpawnDelegate spawnHandler; //Field offset: 0x10

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001B6")]
		public <>c__DisplayClass71_0() { }

		[Address(RVA = "0x126F710", Offset = "0x126E910", Length = "0x40")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001B7")]
		internal GameObject <RegisterPrefab>b__0(SpawnMessage msg) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000045")]
	private sealed class <>c__DisplayClass75_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000CD")]
		public SpawnDelegate spawnHandler; //Field offset: 0x10

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001B8")]
		public <>c__DisplayClass75_0() { }

		[Address(RVA = "0x126F710", Offset = "0x126E910", Length = "0x40")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001B9")]
		internal GameObject <RegisterSpawnHandler>b__0(SpawnMessage msg) { }

	}

	[Token(Token = "0x400009E")]
	private static double lastSendTime; //Field offset: 0x0
	[Token(Token = "0x400009F")]
	public static bool exceptionsDisconnect; //Field offset: 0x8
	[Token(Token = "0x40000A0")]
	internal static readonly Dictionary<UInt16, NetworkMessageDelegate> handlers; //Field offset: 0x10
	[Token(Token = "0x40000A1")]
	public static readonly Dictionary<UInt32, NetworkIdentity> spawned; //Field offset: 0x18
	[CompilerGenerated]
	[Token(Token = "0x40000A2")]
	private static NetworkConnectionToServer <connection>k__BackingField; //Field offset: 0x20
	[Token(Token = "0x40000A3")]
	public static bool ready; //Field offset: 0x28
	[CompilerGenerated]
	[Token(Token = "0x40000A4")]
	private static NetworkIdentity <localPlayer>k__BackingField; //Field offset: 0x30
	[Token(Token = "0x40000A5")]
	internal static ConnectState connectState; //Field offset: 0x38
	[Token(Token = "0x40000A6")]
	public static Action OnConnectedEvent; //Field offset: 0x40
	[Token(Token = "0x40000A7")]
	public static Action OnDisconnectedEvent; //Field offset: 0x48
	[Token(Token = "0x40000A8")]
	public static Action<TransportError, String> OnErrorEvent; //Field offset: 0x50
	[Token(Token = "0x40000A9")]
	public static Action<Exception> OnTransportExceptionEvent; //Field offset: 0x58
	[Token(Token = "0x40000AA")]
	public static readonly Dictionary<UInt32, GameObject> prefabs; //Field offset: 0x60
	[Token(Token = "0x40000AB")]
	internal static readonly Dictionary<UInt32, SpawnHandlerDelegate> spawnHandlers; //Field offset: 0x68
	[Token(Token = "0x40000AC")]
	internal static readonly Dictionary<UInt32, UnSpawnDelegate> unspawnHandlers; //Field offset: 0x70
	[Token(Token = "0x40000AD")]
	internal static bool isSpawnFinished; //Field offset: 0x78
	[Token(Token = "0x40000AE")]
	internal static readonly Dictionary<UInt64, NetworkIdentity> spawnableObjects; //Field offset: 0x80
	[Token(Token = "0x40000AF")]
	internal static Unbatcher unbatcher; //Field offset: 0x88
	[Token(Token = "0x40000B0")]
	public static InterestManagementBase aoi; //Field offset: 0x90
	[Token(Token = "0x40000B1")]
	public static bool isLoadingScene; //Field offset: 0x98
	[Token(Token = "0x40000B2")]
	public static ConnectionQuality connectionQuality; //Field offset: 0x99
	[Token(Token = "0x40000B3")]
	public static ConnectionQuality lastConnectionQuality; //Field offset: 0x9A
	[Token(Token = "0x40000B4")]
	public static ConnectionQualityMethod connectionQualityMethod; //Field offset: 0x9B
	[Token(Token = "0x40000B5")]
	public static float connectionQualityInterval; //Field offset: 0x9C
	[Token(Token = "0x40000B6")]
	private static double lastConnectionQualityUpdate; //Field offset: 0xA0
	[CompilerGenerated]
	[Token(Token = "0x40000B7")]
	private static Action<ConnectionQuality, ConnectionQuality> onConnectionQualityChanged; //Field offset: 0xA8
	[Token(Token = "0x40000B8")]
	private static readonly Dictionary<NetworkIdentity, SpawnMessage> pendingSpawns; //Field offset: 0xB0
	[Token(Token = "0x40000B9")]
	public static SnapshotInterpolationSettings snapshotSettings; //Field offset: 0xB8
	[Token(Token = "0x40000BA")]
	public static double bufferTimeMultiplier; //Field offset: 0xC0
	[Token(Token = "0x40000BB")]
	public static SortedList<Double, TimeSnapshot> snapshots; //Field offset: 0xC8
	[Token(Token = "0x40000BC")]
	internal static double localTimeline; //Field offset: 0xD0
	[Token(Token = "0x40000BD")]
	internal static double localTimescale; //Field offset: 0xD8
	[Token(Token = "0x40000BE")]
	private static ExponentialMovingAverage driftEma; //Field offset: 0xE0
	[Token(Token = "0x40000BF")]
	private static ExponentialMovingAverage deliveryTimeEma; //Field offset: 0x108

	[Token(Token = "0x14000001")]
	public static event Action<ConnectionQuality, ConnectionQuality> onConnectionQualityChanged
	{
		[Address(RVA = "0x1263790", Offset = "0x1262990", Length = "0x108")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000155")]
		 add { } //Length: 264
		[Address(RVA = "0x1263ED0", Offset = "0x12630D0", Length = "0x108")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000156")]
		 remove { } //Length: 264
	}

	[Token(Token = "0x1700002D")]
	public static bool active
	{
		[Address(RVA = "0x1263970", Offset = "0x1262B70", Length = "0x78")]
		[CallerCount(Count = 154)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000151")]
		 get { } //Length: 120
	}

	[Token(Token = "0x1700002E")]
	public static bool activeHost
	{
		[Address(RVA = "0x12638A0", Offset = "0x1262AA0", Length = "0xCF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000152")]
		 get { } //Length: 207
	}

	[Token(Token = "0x17000032")]
	public static double bufferTime
	{
		[Address(RVA = "0x12639F0", Offset = "0x1262BF0", Length = "0x8F")]
		[CalledBy(Type = typeof(NetworkClient), Member = "OnTimeSnapshot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSnapshot)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkClient), Member = "<NetworkLateUpdate>g__UpdateConnectionQuality|106_0", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.LagCompensator", Member = "Sample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient), "Mirror.Capture3D&"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(NetworkServer), Member = "get_sendInterval", ReturnType = typeof(float))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600019A")]
		 get { } //Length: 143
	}

	[Token(Token = "0x1700002B")]
	public internal static NetworkConnectionToServer connection
	{
		[Address(RVA = "0x1263A80", Offset = "0x1262C80", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[Token(Token = "0x600014D")]
		 get { } //Length: 79
		[Address(RVA = "0x1263FE0", Offset = "0x12631E0", Length = "0x6E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[Token(Token = "0x600014E")]
		internal set { } //Length: 110
	}

	[Obsolete("NeworkClient.dynamicAdjustment was moved to NetworkClient.snapshotSettings.dynamicAdjustment")]
	[Token(Token = "0x17000035")]
	public static int deliveryTimeEmaDuration
	{
		[Address(RVA = "0x1263AD0", Offset = "0x1262CD0", Length = "0x5F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600019D")]
		 get { } //Length: 95
	}

	[Obsolete("NeworkClient.dynamicAdjustment was moved to NetworkClient.snapshotSettings.dynamicAdjustment")]
	[Token(Token = "0x17000033")]
	public static bool dynamicAdjustment
	{
		[Address(RVA = "0x1263BA0", Offset = "0x1262DA0", Length = "0x60")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600019B")]
		 get { } //Length: 96
	}

	[Obsolete("NeworkClient.dynamicAdjustmentTolerance was moved to NetworkClient.snapshotSettings.dynamicAdjustmentTolerance")]
	[Token(Token = "0x17000034")]
	public static float dynamicAdjustmentTolerance
	{
		[Address(RVA = "0x1263B30", Offset = "0x1262D30", Length = "0x61")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600019C")]
		 get { } //Length: 97
	}

	[Token(Token = "0x17000031")]
	public static double initialBufferTime
	{
		[Address(RVA = "0x1263C10", Offset = "0x1262E10", Length = "0x9D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(NetworkServer), Member = "get_sendInterval", ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000199")]
		 get { } //Length: 157
	}

	[Token(Token = "0x17000030")]
	public static bool isConnected
	{
		[Address(RVA = "0x1263CB0", Offset = "0x1262EB0", Length = "0x52")]
		[CalledBy(Type = typeof(NetworkManagerHUD), Member = "OnGUI", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkManagerHUD), Member = "StatusLabels", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NetworkManagerHUD), Member = "StopButtons", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkRoomManager", Member = "OnClientSceneChanged", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.Discovery.NetworkDiscoveryBase`2", Member = "BroadcastDiscoveryRequest", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.Discovery.NetworkDiscoveryHUD", Member = "OnGUI", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.Discovery.NetworkDiscoveryHUD", Member = "StopButtons", ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000154")]
		 get { } //Length: 82
	}

	[Token(Token = "0x1700002F")]
	public static bool isConnecting
	{
		[Address(RVA = "0x1263D10", Offset = "0x1262F10", Length = "0x52")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000153")]
		 get { } //Length: 82
	}

	[Token(Token = "0x1700002C")]
	public internal static NetworkIdentity localPlayer
	{
		[Address(RVA = "0x1263D70", Offset = "0x1262F70", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[Token(Token = "0x600014F")]
		 get { } //Length: 79
		[Address(RVA = "0x1264050", Offset = "0x1263250", Length = "0x6E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[Token(Token = "0x6000150")]
		internal set { } //Length: 110
	}

	[Token(Token = "0x1700002A")]
	public static float sendInterval
	{
		[Address(RVA = "0x1263DC0", Offset = "0x1262FC0", Length = "0x7F")]
		[CalledBy(Type = "Mirror.NetworkTransformUnreliable", Member = "OnClientToServerSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.SyncData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkTransformReliable", Member = "OnServerToClientSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Nullable`1<Vector3>", "System.Nullable`1<Quaternion>", "System.Nullable`1<Vector3>"}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(NetworkClient), Member = "get_sendRate", ReturnType = typeof(int))]
		[Token(Token = "0x600014C")]
		 get { } //Length: 127
	}

	[Token(Token = "0x17000029")]
	public static int sendRate
	{
		[Address(RVA = "0x1263E40", Offset = "0x1263040", Length = "0x89")]
		[CalledBy(Type = typeof(NetworkClient), Member = "get_sendInterval", ReturnType = typeof(float))]
		[CalledBy(Type = typeof(NetworkClient), Member = "NetworkLateUpdate", ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x600014B")]
		 get { } //Length: 137
	}

	[Address(RVA = "0x12632F0", Offset = "0x12624F0", Length = "0x496")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt16, System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unbatcher), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(SnapshotInterpolationSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(SortedList`2), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x60001A2")]
	private static NetworkClient() { }

	[Address(RVA = "0x1262890", Offset = "0x1261A90", Length = "0x3C6")]
	[CalledBy(Type = typeof(NetworkClient), Member = "NetworkLateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18120AE80")]
	[Calls(Type = typeof(NetworkTime), Member = "get_rtt", ReturnType = typeof(double))]
	[Calls(Type = typeof(NetworkTime), Member = "get_rttVariance", ReturnType = typeof(double))]
	[Calls(Type = typeof(NetworkServer), Member = "get_sendInterval", ReturnType = typeof(float))]
	[Calls(Type = typeof(NetworkClient), Member = "get_bufferTime", ReturnType = typeof(double))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001A3")]
	internal static void <NetworkLateUpdate>g__UpdateConnectionQuality|106_0() { }

	[Address(RVA = "0x1263790", Offset = "0x1262990", Length = "0x108")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000155")]
	public static void add_onConnectionQualityChanged(Action<ConnectionQuality, ConnectionQuality> value) { }

	[Address(RVA = "0x1258AB0", Offset = "0x1257CB0", Length = "0x24C")]
	[CalledBy(Type = typeof(NetworkManager), Member = "OnClientConnect", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkManager), Member = "OnClientSceneChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkManagerHUD), Member = "OnGUI", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180701270")]
	[Calls(Type = typeof(NetworkConnection), Member = "Send", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600017B")]
	public static bool AddPlayer() { }

	[Address(RVA = "0x1258D00", Offset = "0x1257F00", Length = "0x472")]
	[CalledBy(Type = typeof(NetworkClient), Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkClient), Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkManager), Member = "StartClient", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkManager), Member = "StartClient", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(NetworkClient), Member = "RemoveTransportHandlers", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(System.Action`2<System.ArraySegment`1<System.Byte>, System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000157")]
	private static void AddTransportHandlers() { }

	[Address(RVA = "0x1259180", Offset = "0x1258380", Length = "0x447")]
	[CalledBy(Type = typeof(NetworkClient), Member = "OnObjectSpawnFinished", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectSpawnFinishedMessage)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkClient), Member = "OnSpawn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpawnMessage)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "set_localPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkIdentity), Member = "OnStartAuthority", ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkIdentity), Member = "OnStartClient", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(NetworkIdentity), Member = "DeserializeClient", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkReaderPool), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(NetworkReaderPooled))]
	[Calls(Type = typeof(NetworkClient), Member = "InitializeIdentityFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkClient), Member = "InternalAddPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(NetworkIdentity), Member = "OnStopAuthority", ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "get_activeSelf", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(NetworkIdentity), Member = "set_assetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(NetworkIdentity), Member = "OnStartLocalPlayer", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600017C")]
	internal static void ApplySpawnPayload(NetworkIdentity identity, SpawnMessage message) { }

	[Address(RVA = "0x12595D0", Offset = "0x12587D0", Length = "0xAF")]
	[CalledBy(Type = typeof(NetworkClient), Member = "OnObjectSpawnFinished", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectSpawnFinishedMessage)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkClient), Member = "InitializeIdentityFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkIdentity), Member = "OnStartClient", ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkIdentity), Member = "OnStartAuthority", ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkIdentity), Member = "OnStopAuthority", ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkIdentity), Member = "OnStartLocalPlayer", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000187")]
	private static void BootstrapIdentity(NetworkIdentity identity) { }

	[Address(RVA = "0x1259A90", Offset = "0x1258C90", Length = "0x13A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkClient), Member = "Send", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSnapshotMessage)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSnapshotMessage), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkClient), Member = "BroadcastToServer", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000193")]
	private static void Broadcast() { }

	[Address(RVA = "0x1259680", Offset = "0x1258880", Length = "0x405")]
	[CalledBy(Type = typeof(NetworkClient), Member = "NetworkLateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkClient), Member = "Broadcast", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(NetworkClient), Member = "Send", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ArraySegment`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkIdentity), Member = "SerializeClient", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000194")]
	private static void BroadcastToServer() { }

	[Address(RVA = "0x1259BD0", Offset = "0x1258DD0", Length = "0x2EB")]
	[CalledBy(Type = typeof(NetworkClient), Member = "OnChangeOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChangeOwnerMessage)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkIdentity), Member = "OnStopLocalPlayer", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkIdentity), Member = "OnStartAuthority", ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkIdentity), Member = "OnStopAuthority", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18124C7B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NetworkIdentity), Member = "OnStartLocalPlayer", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000190")]
	internal static void ChangeOwner(NetworkIdentity identity, ChangeOwnerMessage message) { }

	[Address(RVA = "0x1259EC0", Offset = "0x12590C0", Length = "0xCE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000177")]
	public static void ClearSpawners() { }

	[Address(RVA = "0x125A200", Offset = "0x1259400", Length = "0x12A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkClient), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkClient), Member = "AddTransportHandlers", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NetworkConnection), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600015A")]
	public static void Connect(string address) { }

	[Address(RVA = "0x125A0D0", Offset = "0x12592D0", Length = "0x12A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkClient), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkClient), Member = "AddTransportHandlers", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NetworkConnection), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600015B")]
	public static void Connect(Uri uri) { }

	[Address(RVA = "0x1259F90", Offset = "0x1259190", Length = "0x13C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkClient), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Utils), Member = "CreateLocalConnections", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalConnectionToClient&), typeof(LocalConnectionToServer&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NetworkServer), Member = "SetLocalConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalConnectionToClient)}, ReturnType = typeof(void))]
	[Token(Token = "0x600015C")]
	public static void ConnectHost() { }

	[Address(RVA = "0x125A330", Offset = "0x1259530", Length = "0x43B")]
	[CalledBy(Type = typeof(NetworkClient), Member = "Shutdown", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NetworkIdentity), Member = "OnStopClient", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkIdentity), Member = "ResetState", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkClient), Member = "InvokeUnSpawnHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(GameObject)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkIdentity), Member = "OnStopLocalPlayer", ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000195")]
	public static void DestroyAllClientObjects() { }

	[Address(RVA = "0x125A770", Offset = "0x1259970", Length = "0x2E3")]
	[CalledBy(Type = typeof(NetworkClient), Member = "OnObjectHide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectHideMessage)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkClient), Member = "OnObjectDestroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectDestroyMessage)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NetworkIdentity), Member = "OnStopLocalPlayer", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkIdentity), Member = "ResetState", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt64, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkClient), Member = "InvokeUnSpawnHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(GameObject)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(NetworkIdentity), Member = "OnStopClient", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Token(Token = "0x6000196")]
	private static void DestroyObject(uint netId) { }

	[Address(RVA = "0x125AA60", Offset = "0x1259C60", Length = "0x10C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600015D")]
	public static void Disconnect() { }

	[Address(RVA = "0x125AB70", Offset = "0x1259D70", Length = "0x4A9")]
	[CalledBy(Type = typeof(NetworkClient), Member = "OnSpawn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpawnMessage)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt64, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt64, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkClient), Member = "SpawnPrefab", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpawnMessage)}, ReturnType = typeof(NetworkIdentity))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NetworkClient), Member = "GetExistingObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(NetworkIdentity))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Token(Token = "0x600017D")]
	internal static bool FindOrSpawnObject(SpawnMessage message, out NetworkIdentity identity) { }

	[Address(RVA = "0x1263970", Offset = "0x1262B70", Length = "0x78")]
	[CallerCount(Count = 154)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000151")]
	public static bool get_active() { }

	[Address(RVA = "0x12638A0", Offset = "0x1262AA0", Length = "0xCF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000152")]
	public static bool get_activeHost() { }

	[Address(RVA = "0x12639F0", Offset = "0x1262BF0", Length = "0x8F")]
	[CalledBy(Type = typeof(NetworkClient), Member = "OnTimeSnapshot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSnapshot)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkClient), Member = "<NetworkLateUpdate>g__UpdateConnectionQuality|106_0", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.LagCompensator", Member = "Sample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient), "Mirror.Capture3D&"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkServer), Member = "get_sendInterval", ReturnType = typeof(float))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600019A")]
	public static double get_bufferTime() { }

	[Address(RVA = "0x1263A80", Offset = "0x1262C80", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[Token(Token = "0x600014D")]
	public static NetworkConnectionToServer get_connection() { }

	[Address(RVA = "0x1263AD0", Offset = "0x1262CD0", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600019D")]
	public static int get_deliveryTimeEmaDuration() { }

	[Address(RVA = "0x1263BA0", Offset = "0x1262DA0", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600019B")]
	public static bool get_dynamicAdjustment() { }

	[Address(RVA = "0x1263B30", Offset = "0x1262D30", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600019C")]
	public static float get_dynamicAdjustmentTolerance() { }

	[Address(RVA = "0x1263C10", Offset = "0x1262E10", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkServer), Member = "get_sendInterval", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000199")]
	public static double get_initialBufferTime() { }

	[Address(RVA = "0x1263CB0", Offset = "0x1262EB0", Length = "0x52")]
	[CalledBy(Type = typeof(NetworkManagerHUD), Member = "OnGUI", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkManagerHUD), Member = "StatusLabels", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkManagerHUD), Member = "StopButtons", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkRoomManager", Member = "OnClientSceneChanged", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Discovery.NetworkDiscoveryBase`2", Member = "BroadcastDiscoveryRequest", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Discovery.NetworkDiscoveryHUD", Member = "OnGUI", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Discovery.NetworkDiscoveryHUD", Member = "StopButtons", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000154")]
	public static bool get_isConnected() { }

	[Address(RVA = "0x1263D10", Offset = "0x1262F10", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000153")]
	public static bool get_isConnecting() { }

	[Address(RVA = "0x1263D70", Offset = "0x1262F70", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[Token(Token = "0x600014F")]
	public static NetworkIdentity get_localPlayer() { }

	[Address(RVA = "0x1263DC0", Offset = "0x1262FC0", Length = "0x7F")]
	[CalledBy(Type = "Mirror.NetworkTransformUnreliable", Member = "OnClientToServerSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.SyncData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkTransformReliable", Member = "OnServerToClientSync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Nullable`1<Vector3>", "System.Nullable`1<Quaternion>", "System.Nullable`1<Vector3>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkClient), Member = "get_sendRate", ReturnType = typeof(int))]
	[Token(Token = "0x600014C")]
	public static float get_sendInterval() { }

	[Address(RVA = "0x1263E40", Offset = "0x1263040", Length = "0x89")]
	[CalledBy(Type = typeof(NetworkClient), Member = "get_sendInterval", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(NetworkClient), Member = "NetworkLateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600014B")]
	public static int get_sendRate() { }

	[Address(RVA = "0x125B020", Offset = "0x125A220", Length = "0xE9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt64, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt64, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000181")]
	private static NetworkIdentity GetAndRemoveSceneObject(ulong sceneId) { }

	[Address(RVA = "0x125B110", Offset = "0x125A310", Length = "0x8B")]
	[CalledBy(Type = typeof(NetworkClient), Member = "FindOrSpawnObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpawnMessage), typeof(NetworkIdentity&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NetworkClient), Member = "OnChangeOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChangeOwnerMessage)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600017E")]
	private static NetworkIdentity GetExistingObject(uint netid) { }

	[Address(RVA = "0x125B1A0", Offset = "0x125A3A0", Length = "0xDD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600016B")]
	public static bool GetPrefab(uint assetId, out GameObject prefab) { }

	[Address(RVA = "0x125B640", Offset = "0x125A840", Length = "0x13B")]
	[CalledBy(Type = typeof(NetworkClient), Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkClient), Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkClient), Member = "ConnectHost", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkManager), Member = "StartClient", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkManager), Member = "StartClient", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkManager), Member = "FinishStartHost", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkClient), Member = "RegisterMessageHandlers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkClient), Member = "InitTimeInterpolation", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Unbatcher), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000159")]
	private static void Initialize(bool hostMode) { }

	[Address(RVA = "0x125B500", Offset = "0x125A700", Length = "0x13F")]
	[CalledBy(Type = typeof(NetworkClient), Member = "ApplySpawnPayload", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity), typeof(SpawnMessage)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkClient), Member = "BootstrapIdentity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000188")]
	private static void InitializeIdentityFlags(NetworkIdentity identity) { }

	[Address(RVA = "0x125B280", Offset = "0x125A480", Length = "0x277")]
	[CalledBy(Type = typeof(NetworkClient), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SortedList`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(ExponentialMovingAverage), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600019E")]
	private static void InitTimeInterpolation() { }

	[Address(RVA = "0x125B780", Offset = "0x125A980", Length = "0x1C1")]
	[CalledBy(Type = typeof(NetworkClient), Member = "ApplySpawnPayload", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity), typeof(SpawnMessage)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkClient), Member = "OnHostClientSpawn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpawnMessage)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkServer), Member = "AddPlayerForConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient), typeof(GameObject)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NetworkServer), Member = "ReplacePlayerForConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkConnectionToClient), typeof(GameObject), typeof(ReplacePlayerOptions)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600017A")]
	internal static void InternalAddPlayer(NetworkIdentity identity) { }

	[Address(RVA = "0x125B950", Offset = "0x125AB50", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkIdentity), Member = "OnStartClient", ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkIdentity), Member = "OnStartAuthority", ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkIdentity), Member = "OnStopAuthority", ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkIdentity), Member = "OnStartLocalPlayer", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000189")]
	private static void InvokeIdentityCallbacks(NetworkIdentity identity) { }

	[Address(RVA = "0x125B9D0", Offset = "0x125ABD0", Length = "0xC0")]
	[CalledBy(Type = typeof(NetworkClient), Member = "DestroyAllClientObjects", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkClient), Member = "DestroyObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkServer), Member = "UnSpawnInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000178")]
	internal static bool InvokeUnSpawnHandler(uint assetId, GameObject obj) { }

	[Address(RVA = "0x125BAA0", Offset = "0x125ACA0", Length = "0x1ED")]
	[CalledBy(Type = typeof(NetworkLoop), Member = "NetworkEarlyUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Time), Member = "get_unscaledDeltaTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(SnapshotInterpolation), Member = "StepInterpolation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedList`2<Double, T>", typeof(double), "T&", "T&", typeof(Double&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000191")]
	internal static void NetworkEarlyUpdate() { }

	[Address(RVA = "0x125BC90", Offset = "0x125AE90", Length = "0x4F1")]
	[CalledBy(Type = typeof(NetworkLoop), Member = "NetworkLateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Time), Member = "get_unscaledTimeAsDouble", ReturnType = typeof(double))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkClient), Member = "get_active", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(NetworkClient), Member = "get_sendRate", ReturnType = typeof(int))]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkClient), Member = "Send", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSnapshotMessage)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSnapshotMessage), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkClient), Member = "BroadcastToServer", ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkClient), Member = "<NetworkLateUpdate>g__UpdateConnectionQuality|106_0", ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkTime), Member = "UpdateClient", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000192")]
	internal static void NetworkLateUpdate() { }

	[Address(RVA = "0x125C190", Offset = "0x125B390", Length = "0x115")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkClient), Member = "GetExistingObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(NetworkIdentity))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkClient), Member = "ChangeOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity), typeof(ChangeOwnerMessage)}, ReturnType = typeof(void))]
	[Token(Token = "0x600018F")]
	internal static void OnChangeOwner(ChangeOwnerMessage message) { }

	[Address(RVA = "0x125C2B0", Offset = "0x125B4B0", Length = "0x235")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkReaderPool), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(NetworkReaderPooled))]
	[Calls(Type = typeof(NetworkIdentity), Member = "DeserializeClient", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x600018A")]
	private static void OnEntityStateMessage(EntityStateMessage message) { }

	[Address(RVA = "0x125C4F0", Offset = "0x125B6F0", Length = "0x5EF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GUILayout), Member = "BeginHorizontal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle), typeof(GUILayoutOption[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUILayout), Member = "EndHorizontal", ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkTime), Member = "get_predictionErrorUnadjusted", ReturnType = typeof(double))]
	[Calls(Type = typeof(NetworkTime), Member = "get_rtt", ReturnType = typeof(double))]
	[Calls(Type = typeof(GUILayout), Member = "Box", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(GUILayoutOption[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(GUI), Member = "set_color", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(GUILayout), Member = "EndArea", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180029B10")]
	[Calls(Type = typeof(GUIStyle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(GUIStyle))]
	[Calls(Type = typeof(GUILayout), Member = "BeginArea", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(GUILayout), Member = "Label", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(GUILayoutOption[])}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000198")]
	public static void OnGUI() { }

	[Address(RVA = "0x125CAE0", Offset = "0x125BCE0", Length = "0x16D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000185")]
	private static void OnHostClientObjectHide(ObjectHideMessage message) { }

	[Address(RVA = "0x125CC50", Offset = "0x125BE50", Length = "0x458")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkClient), Member = "InternalAddPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkIdentity), Member = "OnStopAuthority", ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkIdentity), Member = "OnStartAuthority", ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkIdentity), Member = "OnStartClient", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180701270")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkIdentity), Member = "OnStartLocalPlayer", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000186")]
	internal static void OnHostClientSpawn(SpawnMessage message) { }

	[Address(RVA = "0x125D0B0", Offset = "0x125C2B0", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkClient), Member = "DestroyObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Token(Token = "0x600018D")]
	internal static void OnObjectDestroy(ObjectDestroyMessage message) { }

	[Address(RVA = "0x125D100", Offset = "0x125C300", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkClient), Member = "DestroyObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Token(Token = "0x600018C")]
	private static void OnObjectHide(ObjectHideMessage message) { }

	[Address(RVA = "0x125D150", Offset = "0x125C350", Length = "0x50C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkClient), Member = "BootstrapIdentity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkClient), Member = "ApplySpawnPayload", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity), typeof(SpawnMessage)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, Mirror.SpawnMessage>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(SpawnMessage&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000184")]
	internal static void OnObjectSpawnFinished(ObjectSpawnFinishedMessage _) { }

	[Address(RVA = "0x125D660", Offset = "0x125C860", Length = "0x8A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkClient), Member = "PrepareToSpawnSceneObjects", ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000183")]
	internal static void OnObjectSpawnStarted(ObjectSpawnStartedMessage _) { }

	[Address(RVA = "0x125D6F0", Offset = "0x125C8F0", Length = "0x1BE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkReaderPool), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(NetworkReaderPooled))]
	[Calls(Type = typeof(NetworkIdentity), Member = "HandleRemoteCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(ushort), typeof(RemoteCallType), typeof(NetworkReader), typeof(NetworkConnectionToClient)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x600018B")]
	private static void OnRPCMessage(RpcMessage message) { }

	[Address(RVA = "0x125D8B0", Offset = "0x125CAB0", Length = "0x4AE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkClient), Member = "FindOrSpawnObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpawnMessage), typeof(NetworkIdentity&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArraySegment`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, Mirror.SpawnMessage>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(SpawnMessage)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkClient), Member = "ApplySpawnPayload", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity), typeof(SpawnMessage)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600018E")]
	internal static void OnSpawn(SpawnMessage message) { }

	[Address(RVA = "0x125DE60", Offset = "0x125D060", Length = "0x261")]
	[CalledBy(Type = typeof(NetworkClient), Member = "OnTimeSnapshotMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSnapshotMessage)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkServer), Member = "get_sendInterval", ReturnType = typeof(float))]
	[Calls(Type = typeof(SnapshotInterpolation), Member = "DynamicAdjustment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(NetworkClient), Member = "get_bufferTime", ReturnType = typeof(double))]
	[Calls(Type = typeof(SnapshotInterpolation), Member = "InsertAndAdjust", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedList`2<Double, T>", typeof(int), "T", typeof(Double&), typeof(Double&), typeof(float), typeof(double), typeof(double), typeof(double), typeof(ExponentialMovingAverage&), typeof(float), typeof(float), typeof(ExponentialMovingAverage&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001A0")]
	public static void OnTimeSnapshot(TimeSnapshot snap) { }

	[Address(RVA = "0x125DD60", Offset = "0x125CF60", Length = "0xF0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Time), Member = "get_unscaledTimeAsDouble", ReturnType = typeof(double))]
	[Calls(Type = typeof(NetworkClient), Member = "OnTimeSnapshot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSnapshot)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600019F")]
	private static void OnTimeSnapshotMessage(TimeSnapshotMessage _) { }

	[Address(RVA = "0x125E0D0", Offset = "0x125D2D0", Length = "0x145")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkTime), Member = "ResetStatics", ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkTime), Member = "SendPing", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600015E")]
	private static void OnTransportConnected() { }

	[Address(RVA = "0x125E220", Offset = "0x125D420", Length = "0x80A")]
	[CalledBy(Type = typeof(LocalConnectionToServer), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Unbatcher), Member = "GetNextMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArraySegment`1<Byte>&), typeof(Double&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Unbatcher), Member = "get_BatchesCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(NetworkClient), Member = "UnpackAndInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180701270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkReader), Member = "get_Remaining", ReturnType = typeof(int))]
	[Calls(Type = typeof(NetworkReaderPool), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(NetworkReaderPooled))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(Unbatcher), Member = "StartReadingBatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriterPooled)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(NetworkWriter), Member = "WriteBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<System.Object>), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000160")]
	internal static void OnTransportData(ArraySegment<Byte> data, int channelId) { }

	[Address(RVA = "0x125EA30", Offset = "0x125DC30", Length = "0x1F0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SortedList`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NetworkClient), Member = "RemoveTransportHandlers", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000161")]
	internal static void OnTransportDisconnected() { }

	[Address(RVA = "0x125EC30", Offset = "0x125DE30", Length = "0xF6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000162")]
	private static void OnTransportError(TransportError error, string reason) { }

	[Address(RVA = "0x125ED30", Offset = "0x125DF30", Length = "0xC0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000163")]
	private static void OnTransportException(Exception exception) { }

	[Address(RVA = "0x125EDF0", Offset = "0x125DFF0", Length = "0x35C")]
	[CalledBy(Type = typeof(NetworkClient), Member = "OnObjectSpawnStarted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjectSpawnStartedMessage)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkManager), Member = "OnSceneLoaded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Scene), typeof(LoadSceneMode)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt64, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(GameObject), Member = "get_scene", ReturnType = typeof(Scene))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt64, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Utils), Member = "IsSceneObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Resources), Member = "FindObjectsOfTypeAll", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Token(Token = "0x6000182")]
	public static void PrepareToSpawnSceneObjects() { }

	[Address(RVA = "0x125F150", Offset = "0x125E350", Length = "0x20B")]
	[CalledBy(Type = typeof(NetworkManager), Member = "OnClientConnect", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkManager), Member = "OnClientSceneChanged", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkManagerHUD), Member = "OnGUI", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkConnection), Member = "Send", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000179")]
	public static bool Ready() { }

	[Address(RVA = "0x70CC20", Offset = "0x70BE20", Length = "0x417")]
	[CalledBy(Type = "Polytoria.Networking.PTAuthenticator", Member = "OnStartClient", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkClient), Member = "RegisterMessageHandlers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkManager), Member = "RegisterClientMessages", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Authenticators.BasicAuthenticator", Member = "OnStartClient", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Authenticators.DeviceAuthenticator", Member = "OnStartClient", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt16, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt16, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Action`3), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002C190")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000166")]
	public static void RegisterHandler(Action<T> handler, bool requireAuthentication = true) { }

	[Address(RVA = "0x70D040", Offset = "0x70C240", Length = "0x340")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt16, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt16, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000167")]
	public static void RegisterHandler(Action<T, Int32> handler, bool requireAuthentication = true) { }

	[Address(RVA = "0x125F360", Offset = "0x125E560", Length = "0x8BF")]
	[CalledBy(Type = typeof(NetworkClient), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkClient), Member = "RegisterHandler", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`1<T>", typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Action`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkClient), Member = "RegisterHandler", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpawnMessage)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<Mirror.SpawnMessage>), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 11)]
	[Token(Token = "0x6000165")]
	internal static void RegisterMessageHandlers(bool hostMode) { }

	[Address(RVA = "0x1260E80", Offset = "0x1260080", Length = "0x59A")]
	[CalledBy(Type = typeof(NetworkClient), Member = "RegisterPrefab", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(SpawnDelegate), typeof(UnSpawnDelegate)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Token(Token = "0x6000172")]
	public static void RegisterPrefab(GameObject prefab, SpawnHandlerDelegate spawnHandler, UnSpawnDelegate unspawnHandler) { }

	[Address(RVA = "0x1260860", Offset = "0x125FA60", Length = "0x61C")]
	[CalledBy(Type = typeof(NetworkClient), Member = "RegisterPrefab", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(uint), typeof(SpawnDelegate), typeof(UnSpawnDelegate)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NetworkIdentity), Member = "set_assetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000171")]
	public static void RegisterPrefab(GameObject prefab, uint newAssetId, SpawnHandlerDelegate spawnHandler, UnSpawnDelegate unspawnHandler) { }

	[Address(RVA = "0x1260420", Offset = "0x125F620", Length = "0x2C7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(SpawnHandlerDelegate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkClient), Member = "RegisterPrefab", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(SpawnHandlerDelegate), typeof(UnSpawnDelegate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000170")]
	public static void RegisterPrefab(GameObject prefab, SpawnDelegate spawnHandler, UnSpawnDelegate unspawnHandler) { }

	[Address(RVA = "0x12606F0", Offset = "0x125F8F0", Length = "0x163")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SpawnHandlerDelegate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkClient), Member = "RegisterPrefab", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(uint), typeof(SpawnHandlerDelegate), typeof(UnSpawnDelegate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600016F")]
	public static void RegisterPrefab(GameObject prefab, uint newAssetId, SpawnDelegate spawnHandler, UnSpawnDelegate unspawnHandler) { }

	[Address(RVA = "0x1260040", Offset = "0x125F240", Length = "0x164")]
	[CalledBy(Type = typeof(NetworkManager), Member = "RegisterClientMessages", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkRoomManager", Member = "OnStartClient", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkClient), Member = "RegisterPrefabIdentity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600016E")]
	public static void RegisterPrefab(GameObject prefab) { }

	[Address(RVA = "0x12601B0", Offset = "0x125F3B0", Length = "0x261")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkIdentity), Member = "set_assetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkClient), Member = "RegisterPrefabIdentity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600016D")]
	public static void RegisterPrefab(GameObject prefab, uint newAssetId) { }

	[Address(RVA = "0x125FC20", Offset = "0x125EE20", Length = "0x41D")]
	[CalledBy(Type = typeof(NetworkClient), Member = "RegisterPrefab", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkClient), Member = "RegisterPrefab", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(Component), Member = "GetComponentsInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600016C")]
	private static void RegisterPrefabIdentity(NetworkIdentity prefab) { }

	[Address(RVA = "0x1261800", Offset = "0x1260A00", Length = "0x15B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SpawnHandlerDelegate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkClient), Member = "RegisterSpawnHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(SpawnHandlerDelegate), typeof(UnSpawnDelegate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000174")]
	public static void RegisterSpawnHandler(uint assetId, SpawnDelegate spawnHandler, UnSpawnDelegate unspawnHandler) { }

	[Address(RVA = "0x1261420", Offset = "0x1260620", Length = "0x3DA")]
	[CalledBy(Type = typeof(NetworkClient), Member = "RegisterSpawnHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(SpawnDelegate), typeof(UnSpawnDelegate)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000175")]
	public static void RegisterSpawnHandler(uint assetId, SpawnHandlerDelegate spawnHandler, UnSpawnDelegate unspawnHandler) { }

	[Address(RVA = "0x1263ED0", Offset = "0x12630D0", Length = "0x108")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000156")]
	public static void remove_onConnectionQualityChanged(Action<ConnectionQuality, ConnectionQuality> value) { }

	[Address(RVA = "0x1261960", Offset = "0x1260B60", Length = "0x446")]
	[CalledBy(Type = typeof(LocalConnectionToServer), Member = "Disconnect", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkClient), Member = "AddTransportHandlers", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkClient), Member = "OnTransportDisconnected", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Action`2<System.ArraySegment`1<System.Byte>, System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000158")]
	private static void RemoveTransportHandlers() { }

	[Address(RVA = "0x70DBD0", Offset = "0x70CDD0", Length = "0x238")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt16, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000169")]
	public static void ReplaceHandler(Action<T, Int32> handler, bool requireAuthentication = true) { }

	[Address(RVA = "0x70DBD0", Offset = "0x70CDD0", Length = "0x238")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt16, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000168")]
	public static void ReplaceHandler(Action<T> handler, bool requireAuthentication = true) { }

	[Address(RVA = "0x70E1A0", Offset = "0x70D3A0", Length = "0x1CD")]
	[CalledBy(Type = "Polytoria.Networking.PTAuthenticator", Member = "OnClientAuthenticate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkClient), Member = "BroadcastToServer", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkTime), Member = "UpdateClient", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkTime), Member = "SendPing", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkTime), Member = "OnClientPing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkPingMessage)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Authenticators.BasicAuthenticator", Member = "OnClientAuthenticate", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkConnection), Member = "Send", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000164")]
	public static void Send(T message, int channelId = 0) { }

	[Address(RVA = "0x1263FE0", Offset = "0x12631E0", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[Token(Token = "0x600014E")]
	internal static void set_connection(NetworkConnectionToServer value) { }

	[Address(RVA = "0x1264050", Offset = "0x1263250", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[Token(Token = "0x6000150")]
	internal static void set_localPlayer(NetworkIdentity value) { }

	[Address(RVA = "0x1261DB0", Offset = "0x1260FB0", Length = "0x51C")]
	[CalledBy(Type = typeof(NetworkManager), Member = "OnClientDisconnectInternal", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unbatcher), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkClient), Member = "DestroyAllClientObjects", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkIdentity), Member = "ResetClientStatics", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsUnknownMethods(Count = 1)]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	[Token(Token = "0x6000197")]
	public static void Shutdown() { }

	[Address(RVA = "0x12622D0", Offset = "0x12614D0", Length = "0x3FB")]
	[CalledBy(Type = typeof(NetworkClient), Member = "FindOrSpawnObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpawnMessage), typeof(NetworkIdentity&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(Vector3), typeof(Quaternion)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600017F")]
	private static NetworkIdentity SpawnPrefab(SpawnMessage message) { }

	[Address(RVA = "0x12626D0", Offset = "0x12618D0", Length = "0x1B3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt64, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt64, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000180")]
	private static NetworkIdentity SpawnSceneObject(ulong sceneId) { }

	[Address(RVA = "0x1262C60", Offset = "0x1261E60", Length = "0x284")]
	[CalledBy(Type = typeof(NetworkClient), Member = "OnTransportData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkMessages), Member = "UnpackId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader), typeof(UInt16&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt16, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180701270")]
	[Calls(Type = typeof(Time), Member = "get_time", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600015F")]
	private static bool UnpackAndInvoke(NetworkReader reader, int channelId) { }

	[Address(RVA = "0x70E760", Offset = "0x70D960", Length = "0xCC")]
	[CalledBy(Type = "Mirror.Authenticators.BasicAuthenticator", Member = "OnStopClient", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Authenticators.DeviceAuthenticator", Member = "OnStopClient", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt16, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600016A")]
	public static bool UnregisterHandler() { }

	[Address(RVA = "0x1262EF0", Offset = "0x12620F0", Length = "0x20C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000173")]
	public static void UnregisterPrefab(GameObject prefab) { }

	[Address(RVA = "0x1263100", Offset = "0x1262300", Length = "0xA8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.UInt32, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000176")]
	public static void UnregisterSpawnHandler(uint assetId) { }

	[Address(RVA = "0x12631B0", Offset = "0x12623B0", Length = "0x133")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Time), Member = "get_unscaledDeltaTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(SnapshotInterpolation), Member = "StepInterpolation", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.SortedList`2<Double, T>", typeof(double), "T&", "T&", typeof(Double&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001A1")]
	private static void UpdateTimeInterpolation() { }

}

