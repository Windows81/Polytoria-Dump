namespace kcp2k;

[DisallowMultipleComponent]
[HelpURL("https://mirror-networking.gitbook.io/docs/transports/kcp-transport")]
[Token(Token = "0x2000006")]
public class ThreadedKcpTransport : ThreadedTransport, PortTransport
{
	[CompilerGenerated]
	[Token(Token = "0x2000007")]
	private sealed class <>c
	{
		[Token(Token = "0x400003D")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400003E")]
		public static Action<String> <>9__27_0; //Field offset: 0x8

		[Address(RVA = "0x12869C0", Offset = "0x1285BC0", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000059")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600005A")]
		public <>c() { }

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x600005B")]
		internal void <Awake>b__27_0(string _) { }

	}

	[Token(Token = "0x4000025")]
	public const string Scheme = "kcp"; //Field offset: 0x0
	[Token(Token = "0x4000036")]
	private const int MTU = 1200; //Field offset: 0x0
	[FieldOffset(Offset = "0xB8")]
	[FormerlySerializedAs("Port")]
	[Header("Transport Configuration")]
	[Token(Token = "0x4000026")]
	public ushort port; //Field offset: 0xB8
	[FieldOffset(Offset = "0xBA")]
	[Token(Token = "0x4000027")]
	[Tooltip("DualMode listens to IPv6 and IPv4 simultaneously. Disable if the platform only supports IPv4.")]
	public bool DualMode; //Field offset: 0xBA
	[FieldOffset(Offset = "0xBB")]
	[Token(Token = "0x4000028")]
	[Tooltip("NoDelay is recommended to reduce latency. This also scales better without buffers getting full.")]
	public bool NoDelay; //Field offset: 0xBB
	[FieldOffset(Offset = "0xBC")]
	[Token(Token = "0x4000029")]
	[Tooltip("KCP internal update interval. 100ms is KCP default, but a lower interval is recommended to minimize latency and to scale to more networked entities.")]
	public uint Interval; //Field offset: 0xBC
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x400002A")]
	[Tooltip("KCP timeout in milliseconds. Note that KCP sends a ping automatically.")]
	public int Timeout; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC4")]
	[Token(Token = "0x400002B")]
	[Tooltip("Socket receive buffer size. Large buffer helps support more connections. Increase operating system socket buffer size limits if needed.")]
	public int RecvBufferSize; //Field offset: 0xC4
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x400002C")]
	[Tooltip("Socket send buffer size. Large buffer helps support more connections. Increase operating system socket buffer size limits if needed.")]
	public int SendBufferSize; //Field offset: 0xC8
	[FieldOffset(Offset = "0xCC")]
	[Header("Advanced")]
	[Token(Token = "0x400002D")]
	[Tooltip("KCP fastresend parameter. Faster resend for the cost of higher bandwidth. 0 in normal mode, 2 in turbo mode.")]
	public int FastResend; //Field offset: 0xCC
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x400002E")]
	[Tooltip("KCP congestion window. Restricts window size to reduce congestion. Results in only 2-3 MTU messages per Flush even on loopback. Best to keept his disabled.")]
	private bool CongestionWindow; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD4")]
	[Token(Token = "0x400002F")]
	[Tooltip("KCP window size can be modified to support higher loads. This also increases max message size.")]
	public uint ReceiveWindowSize; //Field offset: 0xD4
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000030")]
	[Tooltip("KCP window size can be modified to support higher loads.")]
	public uint SendWindowSize; //Field offset: 0xD8
	[FieldOffset(Offset = "0xDC")]
	[Token(Token = "0x4000031")]
	[Tooltip("KCP will try to retransmit lost messages up to MaxRetransmit (aka dead_link) before disconnecting.")]
	public uint MaxRetransmit; //Field offset: 0xDC
	[FieldOffset(Offset = "0xE0")]
	[FormerlySerializedAs("MaximizeSendReceiveBuffersToOSLimit")]
	[Token(Token = "0x4000032")]
	[Tooltip("Enable to automatically set client & server send/recv buffers to OS limit. Avoids issues with too small buffers under heavy load, potentially dropping connections. Increase the OS limit if this is still too small.")]
	public bool MaximizeSocketBuffers; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE4")]
	[Header("Allowed Max Message Sizes\nBased on Receive Window Size")]
	[ReadOnly]
	[Token(Token = "0x4000033")]
	[Tooltip("KCP reliable max message size shown for convenience. Can be changed via ReceiveWindowSize.")]
	public int ReliableMaxMessageSize; //Field offset: 0xE4
	[FieldOffset(Offset = "0xE8")]
	[ReadOnly]
	[Token(Token = "0x4000034")]
	[Tooltip("KCP unreliable channel max message size for convenience. Not changeable.")]
	public int UnreliableMaxMessageSize; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4000035")]
	protected KcpConfig config; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000037")]
	protected KcpServer server; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000038")]
	protected KcpClient client; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4000039")]
	private bool enabledCopy; //Field offset: 0x108
	[FieldOffset(Offset = "0x109")]
	[Header("Debug")]
	[Token(Token = "0x400003A")]
	public bool debugLog; //Field offset: 0x109
	[FieldOffset(Offset = "0x10A")]
	[Token(Token = "0x400003B")]
	public bool statisticsGUI; //Field offset: 0x10A
	[FieldOffset(Offset = "0x10B")]
	[Token(Token = "0x400003C")]
	public bool statisticsLog; //Field offset: 0x10B

	[Token(Token = "0x17000002")]
	public override ushort Port
	{
		[Address(RVA = "0x12824D0", Offset = "0x12816D0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600003A")]
		 get { } //Length: 8
		[Address(RVA = "0x12824E0", Offset = "0x12816E0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600003B")]
		 set { } //Length: 8
	}

	[Address(RVA = "0x1282330", Offset = "0x1281530", Length = "0x193")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ConcurrentQueue`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentQueue`1<Mirror.ServerMainEvent>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentQueue`1<Mirror.ThreadEvent>), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000054")]
	public ThreadedKcpTransport() { }

	[Address(RVA = "0x12822C0", Offset = "0x12814C0", Length = "0x2B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThreadedTransport), Member = "OnThreadedClientReceive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000055")]
	private void <Awake>b__27_1(ArraySegment<Byte> message, KcpChannel channel) { }

	[Address(RVA = "0x1281130", Offset = "0x1280330", Length = "0x38")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KcpTransport), Member = "ToTransportError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ErrorCode)}, ReturnType = typeof(TransportError))]
	[Calls(Type = typeof(ThreadedTransport), Member = "OnThreadedClientError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransportError), typeof(string)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000056")]
	private void <Awake>b__27_2(ErrorCode error, string reason) { }

	[Address(RVA = "0x12822F0", Offset = "0x12814F0", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThreadedTransport), Member = "OnThreadedServerReceive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000057")]
	private void <Awake>b__27_3(int connectionId, ArraySegment<Byte> message, KcpChannel channel) { }

	[Address(RVA = "0x1281220", Offset = "0x1280420", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KcpTransport), Member = "ToTransportError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ErrorCode)}, ReturnType = typeof(TransportError))]
	[Calls(Type = typeof(ThreadedTransport), Member = "OnThreadedServerError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TransportError), typeof(string)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000058")]
	private void <Awake>b__27_4(int connectionId, ErrorCode error, string reason) { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000040")]
	public virtual bool Available() { }

	[Address(RVA = "0x1281690", Offset = "0x1280890", Length = "0x67F")]
	[CalledBy(Type = typeof(ThreadedEncryptionKcpTransport), Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBehaviour), Member = "InvokeRepeating", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(KcpServer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<System.Int32, System.Net.IPEndPoint>), typeof(System.Action`3<System.Int32, System.ArraySegment`1<System.Byte>, kcp2k.KcpChannel>), typeof(System.Action`1<System.Int32>), typeof(System.Action`3<System.Int32, kcp2k.ErrorCode, System.String>), typeof(KcpConfig)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Action`3<System.Int32, System.ByteEnum, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Action`3<System.Int32, System.ArraySegment`1<System.Byte>, System.ByteEnum>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(KcpClient), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(System.Action`2<System.ArraySegment`1<System.Byte>, kcp2k.KcpChannel>), typeof(Action), typeof(System.Action`2<kcp2k.ErrorCode, System.String>), typeof(KcpConfig)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(KcpConfig), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(uint), typeof(int), typeof(bool), typeof(uint), typeof(uint), typeof(int), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThreadedTransport), Member = "EnsureThread", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600003C")]
	protected virtual void Awake() { }

	[Address(RVA = "0x12824D0", Offset = "0x12816D0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600003A")]
	public override ushort get_Port() { }

	[Address(RVA = "0x1281D10", Offset = "0x1280F10", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KcpPeer), Member = "UnreliableMaxMessageSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000050")]
	public virtual int GetBatchThreshold(int channelId) { }

	[Address(RVA = "0x1281D40", Offset = "0x1280F40", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KcpPeer), Member = "ReliableMaxMessageSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(KcpPeer), Member = "UnreliableMaxMessageSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600004F")]
	public virtual int GetMaxPacketSize(int channelId = 0) { }

	[Address(RVA = "0x1281D80", Offset = "0x1280F80", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[DeduplicatedMethod]
	[Token(Token = "0x600003F")]
	private void OnDisable() { }

	[Address(RVA = "0x1281D80", Offset = "0x1280F80", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[DeduplicatedMethod]
	[Token(Token = "0x600003E")]
	private void OnEnable() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000051")]
	protected override void OnGUIStatistics() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000052")]
	protected override void OnLogStatistics() { }

	[Address(RVA = "0x1281DA0", Offset = "0x1280FA0", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KcpPeer), Member = "ReliableMaxMessageSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(KcpPeer), Member = "UnreliableMaxMessageSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Token(Token = "0x600003D")]
	protected override void OnValidate() { }

	[Address(RVA = "0x1281DE0", Offset = "0x1280FE0", Length = "0xA5")]
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
	[Token(Token = "0x6000047")]
	public virtual Uri ServerUri() { }

	[Address(RVA = "0x12824E0", Offset = "0x12816E0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600003B")]
	public override void set_Port(ushort value) { }

	[Address(RVA = "0x1281E90", Offset = "0x1281090", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KcpClient), Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000041")]
	protected virtual void ThreadedClientConnect(string address) { }

	[Address(RVA = "0x1281EC0", Offset = "0x12810C0", Length = "0x130")]
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
	[Token(Token = "0x6000042")]
	protected virtual void ThreadedClientConnect(Uri uri) { }

	[Address(RVA = "0x1282000", Offset = "0x1281200", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000044")]
	protected virtual void ThreadedClientDisconnect() { }

	[Address(RVA = "0x1282030", Offset = "0x1281230", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000045")]
	protected virtual void ThreadedClientEarlyUpdate() { }

	[Address(RVA = "0x1282080", Offset = "0x1281280", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000046")]
	protected virtual void ThreadedClientLateUpdate() { }

	[Address(RVA = "0x1281270", Offset = "0x1280470", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KcpClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(KcpChannel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThreadedTransport), Member = "OnThreadedClientSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000043")]
	protected virtual void ThreadedClientSend(ArraySegment<Byte> segment, int channelId) { }

	[Address(RVA = "0x12820B0", Offset = "0x12812B0", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KcpServer), Member = "Disconnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600004A")]
	protected virtual void ThreadedServerDisconnect(int connectionId) { }

	[Address(RVA = "0x12820E0", Offset = "0x12812E0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600004C")]
	protected virtual void ThreadedServerEarlyUpdate() { }

	[Address(RVA = "0x1282130", Offset = "0x1281330", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600004D")]
	protected virtual void ThreadedServerLateUpdate() { }

	[Address(RVA = "0x1282160", Offset = "0x1281360", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KcpServer), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ArraySegment`1<System.Byte>), typeof(KcpChannel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThreadedTransport), Member = "OnThreadedServerSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000049")]
	protected virtual void ThreadedServerSend(int connectionId, ArraySegment<Byte> segment, int channelId) { }

	[Address(RVA = "0x12821F0", Offset = "0x12813F0", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000048")]
	protected virtual void ThreadedServerStart() { }

	[Address(RVA = "0x1282230", Offset = "0x1281430", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600004B")]
	protected virtual void ThreadedServerStop() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600004E")]
	protected virtual void ThreadedShutdown() { }

	[Address(RVA = "0x1282260", Offset = "0x1281460", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000053")]
	public virtual string ToString() { }

}

