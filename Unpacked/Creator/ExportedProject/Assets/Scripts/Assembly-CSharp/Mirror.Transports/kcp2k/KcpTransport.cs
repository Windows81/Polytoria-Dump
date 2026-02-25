namespace kcp2k;

[DisallowMultipleComponent]
[HelpURL("https://mirror-networking.gitbook.io/docs/transports/kcp-transport")]
[Token(Token = "0x2000004")]
public class KcpTransport : Transport, PortTransport
{
	[CompilerGenerated]
	[Token(Token = "0x2000005")]
	private sealed class <>c
	{
		[Token(Token = "0x400001D")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400001E")]
		public static Action<String> <>9__29_0; //Field offset: 0x8
		[Token(Token = "0x400001F")]
		public static Func<KcpServerConnection, Int64> <>9__51_0; //Field offset: 0x10
		[Token(Token = "0x4000020")]
		public static Func<KcpServerConnection, Int64> <>9__52_0; //Field offset: 0x18
		[Token(Token = "0x4000021")]
		public static Func<KcpServerConnection, Int32> <>9__53_0; //Field offset: 0x20
		[Token(Token = "0x4000022")]
		public static Func<KcpServerConnection, Int32> <>9__54_0; //Field offset: 0x28
		[Token(Token = "0x4000023")]
		public static Func<KcpServerConnection, Int32> <>9__55_0; //Field offset: 0x30
		[Token(Token = "0x4000024")]
		public static Func<KcpServerConnection, Int32> <>9__56_0; //Field offset: 0x38

		[Address(RVA = "0x1286A30", Offset = "0x1285C30", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000031")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000032")]
		public <>c() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000033")]
		internal void <Awake>b__29_0(string _) { }

		[Address(RVA = "0x12849D0", Offset = "0x1283BD0", Length = "0x22")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(KcpPeer), Member = "get_MaxReceiveRate", ReturnType = typeof(uint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000035")]
		internal long <GetAverageMaxReceiveRate>b__52_0(KcpServerConnection conn) { }

		[Address(RVA = "0x1284A00", Offset = "0x1283C00", Length = "0x22")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(KcpPeer), Member = "get_MaxSendRate", ReturnType = typeof(uint))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000034")]
		internal long <GetAverageMaxSendRate>b__51_0(KcpServerConnection conn) { }

		[Address(RVA = "0x1284A30", Offset = "0x1283C30", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(KcpPeer), Member = "get_ReceiveBufferCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000039")]
		internal int <GetTotalReceiveBuffer>b__56_0(KcpServerConnection conn) { }

		[Address(RVA = "0x1284A50", Offset = "0x1283C50", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(KcpPeer), Member = "get_ReceiveQueueCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000037")]
		internal int <GetTotalReceiveQueue>b__54_0(KcpServerConnection conn) { }

		[Address(RVA = "0x1284A70", Offset = "0x1283C70", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(KcpPeer), Member = "get_SendBufferCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000038")]
		internal int <GetTotalSendBuffer>b__55_0(KcpServerConnection conn) { }

		[Address(RVA = "0x1284A90", Offset = "0x1283C90", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(KcpPeer), Member = "get_SendQueueCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000036")]
		internal int <GetTotalSendQueue>b__53_0(KcpServerConnection conn) { }

	}

	[Token(Token = "0x4000006")]
	public const string Scheme = "kcp"; //Field offset: 0x0
	[Token(Token = "0x4000017")]
	private const int MTU = 1200; //Field offset: 0x0
	[FieldOffset(Offset = "0x88")]
	[FormerlySerializedAs("Port")]
	[Header("Transport Configuration")]
	[Token(Token = "0x4000007")]
	public ushort port; //Field offset: 0x88
	[FieldOffset(Offset = "0x8A")]
	[Token(Token = "0x4000008")]
	[Tooltip("DualMode listens to IPv6 and IPv4 simultaneously. Disable if the platform only supports IPv4.")]
	public bool DualMode; //Field offset: 0x8A
	[FieldOffset(Offset = "0x8B")]
	[Token(Token = "0x4000009")]
	[Tooltip("NoDelay is recommended to reduce latency. This also scales better without buffers getting full.")]
	public bool NoDelay; //Field offset: 0x8B
	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x400000A")]
	[Tooltip("KCP internal update interval. 100ms is KCP default, but a lower interval is recommended to minimize latency and to scale to more networked entities.")]
	public uint Interval; //Field offset: 0x8C
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400000B")]
	[Tooltip("KCP timeout in milliseconds. Note that KCP sends a ping automatically.")]
	public int Timeout; //Field offset: 0x90
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x400000C")]
	[Tooltip("Socket receive buffer size. Large buffer helps support more connections. Increase operating system socket buffer size limits if needed.")]
	public int RecvBufferSize; //Field offset: 0x94
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400000D")]
	[Tooltip("Socket send buffer size. Large buffer helps support more connections. Increase operating system socket buffer size limits if needed.")]
	public int SendBufferSize; //Field offset: 0x98
	[FieldOffset(Offset = "0x9C")]
	[Header("Advanced")]
	[Token(Token = "0x400000E")]
	[Tooltip("KCP fastresend parameter. Faster resend for the cost of higher bandwidth. 0 in normal mode, 2 in turbo mode.")]
	public int FastResend; //Field offset: 0x9C
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400000F")]
	[Tooltip("KCP congestion window. Restricts window size to reduce congestion. Results in only 2-3 MTU messages per Flush even on loopback. Best to keept his disabled.")]
	private bool CongestionWindow; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x4000010")]
	[Tooltip("KCP window size can be modified to support higher loads. This also increases max message size.")]
	public uint ReceiveWindowSize; //Field offset: 0xA4
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000011")]
	[Tooltip("KCP window size can be modified to support higher loads.")]
	public uint SendWindowSize; //Field offset: 0xA8
	[FieldOffset(Offset = "0xAC")]
	[Token(Token = "0x4000012")]
	[Tooltip("KCP will try to retransmit lost messages up to MaxRetransmit (aka dead_link) before disconnecting.")]
	public uint MaxRetransmit; //Field offset: 0xAC
	[FieldOffset(Offset = "0xB0")]
	[FormerlySerializedAs("MaximizeSendReceiveBuffersToOSLimit")]
	[Token(Token = "0x4000013")]
	[Tooltip("Enable to automatically set client & server send/recv buffers to OS limit. Avoids issues with too small buffers under heavy load, potentially dropping connections. Increase the OS limit if this is still too small.")]
	public bool MaximizeSocketBuffers; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB4")]
	[Header("Allowed Max Message Sizes\nBased on Receive Window Size")]
	[ReadOnly]
	[Token(Token = "0x4000014")]
	[Tooltip("KCP reliable max message size shown for convenience. Can be changed via ReceiveWindowSize.")]
	public int ReliableMaxMessageSize; //Field offset: 0xB4
	[FieldOffset(Offset = "0xB8")]
	[ReadOnly]
	[Token(Token = "0x4000015")]
	[Tooltip("KCP unreliable channel max message size for convenience. Not changeable.")]
	public int UnreliableMaxMessageSize; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000016")]
	protected KcpConfig config; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000018")]
	protected KcpServer server; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000019")]
	protected KcpClient client; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Header("Debug")]
	[Token(Token = "0x400001A")]
	public bool debugLog; //Field offset: 0xD8
	[FieldOffset(Offset = "0xD9")]
	[Token(Token = "0x400001B")]
	public bool statisticsGUI; //Field offset: 0xD9
	[FieldOffset(Offset = "0xDA")]
	[Token(Token = "0x400001C")]
	public bool statisticsLog; //Field offset: 0xDA

	[Token(Token = "0x17000001")]
	public override ushort Port
	{
		[Address(RVA = "0x127B1D0", Offset = "0x127A3D0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000003")]
		 get { } //Length: 8
		[Address(RVA = "0x127B1E0", Offset = "0x127A3E0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000004")]
		 set { } //Length: 8
	}

	[Address(RVA = "0x127B160", Offset = "0x127A360", Length = "0x68")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000028")]
	public KcpTransport() { }

	[Address(RVA = "0x12725F0", Offset = "0x12717F0", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000029")]
	private void <Awake>b__29_1() { }

	[Address(RVA = "0x1272620", Offset = "0x1271820", Length = "0x3F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600002A")]
	private void <Awake>b__29_2(ArraySegment<Byte> message, KcpChannel channel) { }

	[Address(RVA = "0x1272660", Offset = "0x1271860", Length = "0x19")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600002B")]
	private void <Awake>b__29_3() { }

	[Address(RVA = "0x127B110", Offset = "0x127A310", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KcpTransport), Member = "ToTransportError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ErrorCode)}, ReturnType = typeof(TransportError))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[Token(Token = "0x600002C")]
	private void <Awake>b__29_4(ErrorCode error, string reason) { }

	[Address(RVA = "0x12726D0", Offset = "0x12718D0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Extensions), Member = "PrettyAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPEndPoint)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600002D")]
	private void <Awake>b__29_5(int connectionId, IPEndPoint endPoint) { }

	[Address(RVA = "0x1272720", Offset = "0x1271920", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600002E")]
	private void <Awake>b__29_6(int connectionId, ArraySegment<Byte> message, KcpChannel channel) { }

	[Address(RVA = "0x1272770", Offset = "0x1271970", Length = "0x28")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600002F")]
	private void <Awake>b__29_7(int connectionId) { }

	[Address(RVA = "0x12727A0", Offset = "0x12719A0", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KcpTransport), Member = "ToTransportError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ErrorCode)}, ReturnType = typeof(TransportError))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000030")]
	private void <Awake>b__29_8(int connectionId, ErrorCode error, string reason) { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000A")]
	public virtual bool Available() { }

	[Address(RVA = "0x1278BE0", Offset = "0x1277DE0", Length = "0x675")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(KcpConfig), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(uint), typeof(int), typeof(bool), typeof(uint), typeof(uint), typeof(int), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(KcpClient), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(System.Action`2<System.ArraySegment`1<System.Byte>, kcp2k.KcpChannel>), typeof(Action), typeof(System.Action`2<kcp2k.ErrorCode, System.String>), typeof(KcpConfig)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Action`3<System.Int32, System.ArraySegment`1<System.Byte>, System.ByteEnum>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Action`3<System.Int32, System.ByteEnum, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(KcpServer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<System.Int32, System.Net.IPEndPoint>), typeof(System.Action`3<System.Int32, System.ArraySegment`1<System.Byte>, kcp2k.KcpChannel>), typeof(System.Action`1<System.Int32>), typeof(System.Action`3<System.Int32, kcp2k.ErrorCode, System.String>), typeof(KcpConfig)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBehaviour), Member = "InvokeRepeating", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000008")]
	protected override void Awake() { }

	[Address(RVA = "0x1279260", Offset = "0x1278460", Length = "0x130")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Uri), Member = "get_Scheme", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "get_IsDefaultPort", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "get_Port", ReturnType = typeof(int))]
	[Calls(Type = typeof(Uri), Member = "get_Host", ReturnType = typeof(string))]
	[Calls(Type = typeof(KcpClient), Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600000D")]
	public virtual void ClientConnect(Uri uri) { }

	[Address(RVA = "0x12793A0", Offset = "0x12785A0", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KcpClient), Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600000C")]
	public virtual void ClientConnect(string address) { }

	[Address(RVA = "0x12793D0", Offset = "0x12785D0", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600000B")]
	public virtual bool ClientConnected() { }

	[Address(RVA = "0x1279400", Offset = "0x1278600", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000F")]
	public virtual void ClientDisconnect() { }

	[Address(RVA = "0x1279430", Offset = "0x1278630", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Behaviour), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000010")]
	public virtual void ClientEarlyUpdate() { }

	[Address(RVA = "0x1279480", Offset = "0x1278680", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000011")]
	public virtual void ClientLateUpdate() { }

	[Address(RVA = "0x12794B0", Offset = "0x12786B0", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KcpClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(KcpChannel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600000E")]
	public virtual void ClientSend(ArraySegment<Byte> segment, int channelId) { }

	[Address(RVA = "0x1279530", Offset = "0x1278730", Length = "0x9")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000005")]
	public static int FromKcpChannel(KcpChannel channel) { }

	[Address(RVA = "0x127B1D0", Offset = "0x127A3D0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000003")]
	public override ushort get_Port() { }

	[Address(RVA = "0x1279540", Offset = "0x1278740", Length = "0x1D5")]
	[CalledBy(Type = typeof(KcpTransport), Member = "OnGUIStatistics", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KcpTransport), Member = "OnLogStatistics", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Enumerable), Member = "Sum", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Int64>"}, ReturnType = typeof(long))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600001F")]
	public long GetAverageMaxReceiveRate() { }

	[Address(RVA = "0x1279720", Offset = "0x1278920", Length = "0x1D5")]
	[CalledBy(Type = typeof(KcpTransport), Member = "OnGUIStatistics", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KcpTransport), Member = "OnLogStatistics", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Enumerable), Member = "Sum", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Int64>"}, ReturnType = typeof(long))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600001E")]
	public long GetAverageMaxSendRate() { }

	[Address(RVA = "0x1279900", Offset = "0x1278B00", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KcpPeer), Member = "UnreliableMaxMessageSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600001D")]
	public virtual int GetBatchThreshold(int channelId) { }

	[Address(RVA = "0x1279930", Offset = "0x1278B30", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KcpPeer), Member = "ReliableMaxMessageSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(KcpPeer), Member = "UnreliableMaxMessageSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600001C")]
	public virtual int GetMaxPacketSize(int channelId = 0) { }

	[Address(RVA = "0x1279970", Offset = "0x1278B70", Length = "0x154")]
	[CalledBy(Type = typeof(KcpTransport), Member = "OnGUIStatistics", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KcpTransport), Member = "OnLogStatistics", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Enumerable), Member = "Sum", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Int32>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000023")]
	private long GetTotalReceiveBuffer() { }

	[Address(RVA = "0x1279AD0", Offset = "0x1278CD0", Length = "0x154")]
	[CalledBy(Type = typeof(KcpTransport), Member = "OnGUIStatistics", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KcpTransport), Member = "OnLogStatistics", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Enumerable), Member = "Sum", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Int32>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000021")]
	private long GetTotalReceiveQueue() { }

	[Address(RVA = "0x1279C30", Offset = "0x1278E30", Length = "0x154")]
	[CalledBy(Type = typeof(KcpTransport), Member = "OnGUIStatistics", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KcpTransport), Member = "OnLogStatistics", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Enumerable), Member = "Sum", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Int32>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000022")]
	private long GetTotalSendBuffer() { }

	[Address(RVA = "0x1279D90", Offset = "0x1278F90", Length = "0x154")]
	[CalledBy(Type = typeof(KcpTransport), Member = "OnGUIStatistics", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KcpTransport), Member = "OnLogStatistics", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Enumerable), Member = "Sum", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Int32>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000020")]
	private long GetTotalSendQueue() { }

	[Address(RVA = "0x1279EF0", Offset = "0x12790F0", Length = "0x66E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(KcpPeer), Member = "get_SendBufferCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(KcpPeer), Member = "get_ReceiveQueueCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(KcpPeer), Member = "get_SendQueueCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(KcpPeer), Member = "get_MaxReceiveRate", ReturnType = typeof(uint))]
	[Calls(Type = typeof(KcpPeer), Member = "get_MaxSendRate", ReturnType = typeof(uint))]
	[Calls(Type = typeof(GUILayout), Member = "EndVertical", ReturnType = typeof(void))]
	[Calls(Type = typeof(KcpTransport), Member = "GetTotalReceiveBuffer", ReturnType = typeof(long))]
	[Calls(Type = typeof(KcpTransport), Member = "GetTotalSendBuffer", ReturnType = typeof(long))]
	[Calls(Type = typeof(KcpTransport), Member = "GetTotalReceiveQueue", ReturnType = typeof(long))]
	[Calls(Type = typeof(KcpTransport), Member = "GetTotalSendQueue", ReturnType = typeof(long))]
	[Calls(Type = typeof(KcpTransport), Member = "GetAverageMaxReceiveRate", ReturnType = typeof(long))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(KcpTransport), Member = "PrettyBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(KcpTransport), Member = "GetAverageMaxSendRate", ReturnType = typeof(long))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(GUILayout), Member = "Label", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(GUILayoutOption[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GUILayout), Member = "BeginVertical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GUIStyle), typeof(GUILayoutOption[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180029B10")]
	[Calls(Type = typeof(GUIStyle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(GUIStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GUILayout), Member = "BeginArea", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(KcpPeer), Member = "get_ReceiveBufferCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(GUILayout), Member = "EndArea", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000025")]
	protected override void OnGUIStatistics() { }

	[Address(RVA = "0x127A560", Offset = "0x1279760", Length = "0x5FA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KcpTransport), Member = "PrettyBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(KcpPeer), Member = "get_ReceiveQueueCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(KcpPeer), Member = "get_SendQueueCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(KcpPeer), Member = "get_MaxReceiveRate", ReturnType = typeof(uint))]
	[Calls(Type = typeof(KcpPeer), Member = "get_MaxSendRate", ReturnType = typeof(uint))]
	[Calls(Type = typeof(KcpTransport), Member = "GetTotalReceiveBuffer", ReturnType = typeof(long))]
	[Calls(Type = typeof(KcpTransport), Member = "GetTotalSendBuffer", ReturnType = typeof(long))]
	[Calls(Type = typeof(KcpTransport), Member = "GetTotalReceiveQueue", ReturnType = typeof(long))]
	[Calls(Type = typeof(KcpTransport), Member = "GetTotalSendQueue", ReturnType = typeof(long))]
	[Calls(Type = typeof(KcpTransport), Member = "GetAverageMaxReceiveRate", ReturnType = typeof(long))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(KcpTransport), Member = "GetAverageMaxSendRate", ReturnType = typeof(long))]
	[Calls(Type = typeof(KcpPeer), Member = "get_SendBufferCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(double), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Time), Member = "get_unscaledTimeAsDouble", ReturnType = typeof(double))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(KcpPeer), Member = "get_ReceiveBufferCount", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000026")]
	protected override void OnLogStatistics() { }

	[Address(RVA = "0x127AB60", Offset = "0x1279D60", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KcpPeer), Member = "ReliableMaxMessageSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(KcpPeer), Member = "UnreliableMaxMessageSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Token(Token = "0x6000009")]
	protected override void OnValidate() { }

	[Address(RVA = "0x127ABA0", Offset = "0x1279DA0", Length = "0x12B")]
	[CalledBy(Type = typeof(KcpTransport), Member = "OnGUIStatistics", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KcpTransport), Member = "OnLogStatistics", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000024")]
	public static string PrettyBytes(long bytes) { }

	[Address(RVA = "0x127ACD0", Offset = "0x1279ED0", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000013")]
	public virtual bool ServerActive() { }

	[Address(RVA = "0x127AD00", Offset = "0x1279F00", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KcpServer), Member = "Disconnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000016")]
	public virtual void ServerDisconnect(int connectionId) { }

	[Address(RVA = "0x127AD30", Offset = "0x1279F30", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Behaviour), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000019")]
	public virtual void ServerEarlyUpdate() { }

	[Address(RVA = "0x127AD80", Offset = "0x1279F80", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KcpServer), Member = "GetClientEndPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IPEndPoint))]
	[Calls(Type = typeof(Extensions), Member = "PrettyAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPEndPoint)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000017")]
	public virtual string ServerGetClientAddress(int connectionId) { }

	[Address(RVA = "0x127ADB0", Offset = "0x1279FB0", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600001A")]
	public virtual void ServerLateUpdate() { }

	[Address(RVA = "0x127ADE0", Offset = "0x1279FE0", Length = "0x9A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KcpServer), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ArraySegment`1<System.Byte>), typeof(KcpChannel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000015")]
	public virtual void ServerSend(int connectionId, ArraySegment<Byte> segment, int channelId) { }

	[Address(RVA = "0x127AE80", Offset = "0x127A080", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000014")]
	public virtual void ServerStart() { }

	[Address(RVA = "0x127AEC0", Offset = "0x127A0C0", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000018")]
	public virtual void ServerStop() { }

	[Address(RVA = "0x127AEF0", Offset = "0x127A0F0", Length = "0xA5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UriBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UriBuilder), Member = "set_Scheme", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dns), Member = "GetHostName", ReturnType = typeof(string))]
	[Calls(Type = typeof(UriBuilder), Member = "set_Host", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UriBuilder), Member = "set_Port", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UriBuilder), Member = "get_Uri", ReturnType = typeof(Uri))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000012")]
	public virtual Uri ServerUri() { }

	[Address(RVA = "0x127B1E0", Offset = "0x127A3E0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000004")]
	public override void set_Port(ushort value) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600001B")]
	public virtual void Shutdown() { }

	[Address(RVA = "0x127AFA0", Offset = "0x127A1A0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000006")]
	public static KcpChannel ToKcpChannel(int channel) { }

	[Address(RVA = "0x127AFB0", Offset = "0x127A1B0", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000027")]
	public virtual string ToString() { }

	[Address(RVA = "0x127B010", Offset = "0x127A210", Length = "0xE0")]
	[CalledBy(Type = typeof(EdgegapKcpTransport), Member = "<Awake>b__8_4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ErrorCode), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KcpTransport), Member = "<Awake>b__29_4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ErrorCode), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KcpTransport), Member = "<Awake>b__29_8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ErrorCode), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadedKcpTransport), Member = "<Awake>b__27_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ErrorCode), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadedKcpTransport), Member = "<Awake>b__27_4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ErrorCode), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadedEncryptionKcpTransport), Member = "<Awake>b__28_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ErrorCode), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadedEncryptionKcpTransport), Member = "<Awake>b__28_3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ErrorCode), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EdgegapKcpTransport), Member = "<Awake>b__8_8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ErrorCode), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000007")]
	public static TransportError ToTransportError(ErrorCode error) { }

}

