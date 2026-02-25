namespace Mirror.Transports.Encryption;

[HelpURL("https://mirror-networking.gitbook.io/docs/manual/transports/encryption-transport")]
[Token(Token = "0x200001D")]
public class ThreadedEncryptionKcpTransport : ThreadedKcpTransport
{
	[CompilerGenerated]
	[Token(Token = "0x200001F")]
	private sealed class <>c__DisplayClass23_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000EF")]
		public ThreadedEncryptionKcpTransport <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000F0")]
		public int connId; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40000F1")]
		public EncryptedConnection ec; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40000F2")]
		public IPEndPoint clientRemoteAddress; //Field offset: 0x28

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000165")]
		public <>c__DisplayClass23_0() { }

		[Address(RVA = "0x1285DA0", Offset = "0x1284FA0", Length = "0x94")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(KcpServer), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ArraySegment`1<System.Byte>), typeof(KcpChannel)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ThreadedTransport), Member = "OnThreadedServerSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000166")]
		internal void <HandleInnerServerConnected>b__0(ArraySegment<Byte> segment, int channel) { }

		[Address(RVA = "0x1285E40", Offset = "0x1285040", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThreadedTransport), Member = "OnThreadedServerReceive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000167")]
		internal void <HandleInnerServerConnected>b__1(ArraySegment<Byte> segment, int channel) { }

		[Address(RVA = "0x1285E80", Offset = "0x1285080", Length = "0x12B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ThreadedEncryptionKcpTransport), Member = "ServerRemoveFromPending", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EncryptedConnection)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Extensions), Member = "PrettyAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPEndPoint)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18126FF80")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000168")]
		internal void <HandleInnerServerConnected>b__2() { }

		[Address(RVA = "0x1285FB0", Offset = "0x12851B0", Length = "0x54")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThreadedTransport), Member = "OnThreadedServerError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TransportError), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000169")]
		internal void <HandleInnerServerConnected>b__3(TransportError type, string msg) { }

	}

	[Token(Token = "0x200001E")]
	internal enum ValidationMode
	{
		Off = 0,
		List = 1,
		Callback = 2,
	}

	[FieldOffset(Offset = "0x110")]
	[HideInInspector]
	[Token(Token = "0x40000E1")]
	public ValidationMode ClientValidateServerPubKey; //Field offset: 0x110
	[FieldOffset(Offset = "0x118")]
	[HideInInspector]
	[Token(Token = "0x40000E2")]
	[Tooltip("List of public key fingerprints the client will accept")]
	public String[] ClientTrustedPubKeySignatures; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x40000E3")]
	public Func<PubKeyInfo, Boolean> OnClientValidateServerPubKey; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[FormerlySerializedAs("serverLoadKeyPairFromFile")]
	[HideInInspector]
	[Token(Token = "0x40000E4")]
	public bool ServerLoadKeyPairFromFile; //Field offset: 0x128
	[FieldOffset(Offset = "0x130")]
	[FormerlySerializedAs("serverKeypairPath")]
	[HideInInspector]
	[Token(Token = "0x40000E5")]
	public string ServerKeypairPath; //Field offset: 0x130
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x40000E6")]
	private EncryptedConnection encryptedClient; //Field offset: 0x138
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x40000E7")]
	private readonly Dictionary<Int32, EncryptedConnection> serverConnections; //Field offset: 0x140
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x40000E8")]
	private readonly List<EncryptedConnection> serverPendingConnections; //Field offset: 0x148
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x40000E9")]
	private EncryptionCredentials credentials; //Field offset: 0x150
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x40000EA")]
	private Stopwatch stopwatch; //Field offset: 0x158

	[Token(Token = "0x17000011")]
	public virtual string EncryptionCipher
	{
		[Address(RVA = "0x1281620", Offset = "0x1280820", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000145")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000013")]
	public Byte[] EncryptionPublicKey
	{
		[Address(RVA = "0x1281670", Offset = "0x1280870", Length = "0x12")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000148")]
		 get { } //Length: 18
	}

	[Token(Token = "0x17000012")]
	public string EncryptionPublicKeyFingerprint
	{
		[Address(RVA = "0x1281650", Offset = "0x1280850", Length = "0x12")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000147")]
		 get { } //Length: 18
	}

	[Token(Token = "0x17000010")]
	public virtual bool IsEncrypted
	{
		[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000144")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x1281370", Offset = "0x1280570", Length = "0x2A6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Stopwatch), Member = "StartNew", ReturnType = typeof(Stopwatch))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(ConcurrentQueue`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentQueue`1<Mirror.ServerMainEvent>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentQueue`1<Mirror.ThreadEvent>), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600015C")]
	public ThreadedEncryptionKcpTransport() { }

	[Address(RVA = "0x12810F0", Offset = "0x12802F0", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EncryptedConnection), Member = "OnReceiveRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000161")]
	private void <Awake>b__28_0(ArraySegment<Byte> message, KcpChannel channel) { }

	[Address(RVA = "0x1281130", Offset = "0x1280330", Length = "0x38")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KcpTransport), Member = "ToTransportError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ErrorCode)}, ReturnType = typeof(TransportError))]
	[Calls(Type = typeof(ThreadedTransport), Member = "OnThreadedClientError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransportError), typeof(string)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000162")]
	private void <Awake>b__28_1(ErrorCode error, string reason) { }

	[Address(RVA = "0x1281170", Offset = "0x1280370", Length = "0xAA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EncryptedConnection), Member = "OnReceiveRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CompilerGenerated]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000163")]
	private void <Awake>b__28_2(int connectionId, ArraySegment<Byte> message, KcpChannel channel) { }

	[Address(RVA = "0x1281220", Offset = "0x1280420", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KcpTransport), Member = "ToTransportError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ErrorCode)}, ReturnType = typeof(TransportError))]
	[Calls(Type = typeof(ThreadedTransport), Member = "OnThreadedServerError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TransportError), typeof(string)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000164")]
	private void <Awake>b__28_3(int connectionId, ErrorCode error, string reason) { }

	[Address(RVA = "0x1281270", Offset = "0x1280470", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KcpClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(KcpChannel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThreadedTransport), Member = "OnThreadedClientSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CompilerGenerated]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600015D")]
	private void <HandleInnerClientConnected>b__26_0(ArraySegment<Byte> segment, int channel) { }

	[Address(RVA = "0x12812F0", Offset = "0x12804F0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThreadedTransport), Member = "OnThreadedClientReceive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[CompilerGenerated]
	[Token(Token = "0x600015E")]
	private void <HandleInnerClientConnected>b__26_1(ArraySegment<Byte> segment, int channel) { }

	[Address(RVA = "0x1281310", Offset = "0x1280510", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18126FEB0")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600015F")]
	private void <HandleInnerClientConnected>b__26_2() { }

	[Address(RVA = "0x1281340", Offset = "0x1280540", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThreadedTransport), Member = "OnThreadedClientError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransportError), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[Token(Token = "0x6000160")]
	private void <HandleInnerClientConnected>b__26_3(TransportError type, string msg) { }

	[Address(RVA = "0x127FD50", Offset = "0x127EF50", Length = "0x345")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThreadedKcpTransport), Member = "Awake", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(KcpClient), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), typeof(System.Action`2<System.ArraySegment`1<System.Byte>, kcp2k.KcpChannel>), typeof(Action), typeof(System.Action`2<kcp2k.ErrorCode, System.String>), typeof(KcpConfig)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Action`3<System.Int32, System.ArraySegment`1<System.Byte>, System.ByteEnum>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Action`3<System.Int32, System.ByteEnum, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(KcpServer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<System.Int32, System.Net.IPEndPoint>), typeof(System.Action`3<System.Int32, System.ArraySegment`1<System.Byte>, kcp2k.KcpChannel>), typeof(System.Action`1<System.Int32>), typeof(System.Action`3<System.Int32, kcp2k.ErrorCode, System.String>), typeof(KcpConfig)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x6000151")]
	protected virtual void Awake() { }

	[Address(RVA = "0x1281620", Offset = "0x1280820", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000145")]
	public virtual string get_EncryptionCipher() { }

	[Address(RVA = "0x1281670", Offset = "0x1280870", Length = "0x12")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000148")]
	public Byte[] get_EncryptionPublicKey() { }

	[Address(RVA = "0x1281650", Offset = "0x1280850", Length = "0x12")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000147")]
	public string get_EncryptionPublicKeyFingerprint() { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000144")]
	public virtual bool get_IsEncrypted() { }

	[Address(RVA = "0x12800A0", Offset = "0x127F2A0", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KcpPeer), Member = "UnreliableMaxMessageSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000159")]
	public virtual int GetBatchThreshold(int channelId) { }

	[Address(RVA = "0x12800D0", Offset = "0x127F2D0", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KcpPeer), Member = "ReliableMaxMessageSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(uint)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(KcpPeer), Member = "UnreliableMaxMessageSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000158")]
	public virtual int GetMaxPacketSize(int channelId = 0) { }

	[Address(RVA = "0x1280120", Offset = "0x127F320", Length = "0xF4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000150")]
	private bool HandleClientValidateServerPubKey(PubKeyInfo pubKeyInfo) { }

	[Address(RVA = "0x1280220", Offset = "0x127F420", Length = "0x1D2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Action`2<System.ArraySegment`1<System.Byte>, System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EncryptedConnection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EncryptionCredentials), typeof(bool), typeof(System.Action`2<System.ArraySegment`1<System.Byte>, System.Int32>), typeof(System.Action`2<System.ArraySegment`1<System.Byte>, System.Int32>), typeof(Action), typeof(System.Action`2<Mirror.TransportError, System.String>), typeof(System.Func`2<Mirror.Transports.Encryption.PubKeyInfo, System.Boolean>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600014F")]
	private void HandleInnerClientConnected() { }

	[Address(RVA = "0x1280400", Offset = "0x127F600", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EncryptedConnection), Member = "OnReceiveRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x600014E")]
	private void HandleInnerClientDataReceived(ArraySegment<Byte> data, int channel) { }

	[Address(RVA = "0x1280430", Offset = "0x127F630", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18126FEB0")]
	[Token(Token = "0x600014D")]
	private void HandleInnerClientDisconnected() { }

	[Address(RVA = "0x1280480", Offset = "0x127F680", Length = "0x331")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Action`2<System.ArraySegment`1<System.Byte>, System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EncryptedConnection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EncryptionCredentials), typeof(bool), typeof(System.Action`2<System.ArraySegment`1<System.Byte>, System.Int32>), typeof(System.Action`2<System.ArraySegment`1<System.Byte>, System.Int32>), typeof(Action), typeof(System.Action`2<Mirror.TransportError, System.String>), typeof(System.Func`2<Mirror.Transports.Encryption.PubKeyInfo, System.Boolean>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600014C")]
	private void HandleInnerServerConnected(int connId, IPEndPoint clientRemoteAddress) { }

	[Address(RVA = "0x12807C0", Offset = "0x127F9C0", Length = "0xA3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EncryptedConnection), Member = "OnReceiveRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600014B")]
	private void HandleInnerServerDataReceived(int connId, ArraySegment<Byte> data, int channel) { }

	[Address(RVA = "0x1280870", Offset = "0x127FA70", Length = "0x100")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ThreadedEncryptionKcpTransport), Member = "ServerRemoveFromPending", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EncryptedConnection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18126FF80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600014A")]
	private void HandleInnerServerDisconnected(int connId) { }

	[Address(RVA = "0x1280980", Offset = "0x127FB80", Length = "0x10A")]
	[CalledBy(Type = typeof(<>c__DisplayClass23_0), Member = "<HandleInnerServerConnected>b__2", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadedEncryptionKcpTransport), Member = "HandleInnerServerDisconnected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000149")]
	private void ServerRemoveFromPending(EncryptedConnection con) { }

	[Address(RVA = "0x1280A90", Offset = "0x127FC90", Length = "0xFC")]
	[CalledBy(Type = typeof(ThreadedEncryptionKcpTransport), Member = "ThreadedClientConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadedEncryptionKcpTransport), Member = "ThreadedClientConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThreadedTransport), Member = "OnThreadedClientError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransportError), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EncryptionCredentials), Member = "Generate", ReturnType = typeof(EncryptionCredentials))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000153")]
	private bool SetupEncryptionForClient() { }

	[Address(RVA = "0x1280CE0", Offset = "0x127FEE0", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThreadedEncryptionKcpTransport), Member = "SetupEncryptionForClient", ReturnType = typeof(bool))]
	[Calls(Type = typeof(KcpClient), Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000152")]
	protected virtual void ThreadedClientConnect(string address) { }

	[Address(RVA = "0x1280B90", Offset = "0x127FD90", Length = "0x140")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Uri), Member = "get_Port", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(KcpClient), Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "get_Host", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Uri), Member = "get_IsDefaultPort", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "get_Scheme", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThreadedEncryptionKcpTransport), Member = "SetupEncryptionForClient", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000154")]
	protected virtual void ThreadedClientConnect(Uri address) { }

	[Address(RVA = "0x1280D30", Offset = "0x127FF30", Length = "0xAC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Stopwatch), Member = "get_Elapsed", ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeSpan), Member = "get_TotalSeconds", ReturnType = typeof(double))]
	[Calls(Type = typeof(EncryptedConnection), Member = "TickNonReady", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600015A")]
	protected virtual void ThreadedClientLateUpdate() { }

	[Address(RVA = "0x1280DE0", Offset = "0x127FFE0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EncryptedConnection), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000155")]
	protected virtual void ThreadedClientSend(ArraySegment<Byte> segment, int channelId) { }

	[Address(RVA = "0x1280E10", Offset = "0x1280010", Length = "0x113")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Stopwatch), Member = "get_Elapsed", ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeSpan), Member = "get_TotalSeconds", ReturnType = typeof(double))]
	[Calls(Type = typeof(EncryptedConnection), Member = "TickNonReady", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600015B")]
	protected virtual void ThreadedServerLateUpdate() { }

	[Address(RVA = "0x1280F30", Offset = "0x1280130", Length = "0xAA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EncryptedConnection), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000157")]
	protected virtual void ThreadedServerSend(int connectionId, ArraySegment<Byte> segment, int channelId) { }

	[Address(RVA = "0x1280FE0", Offset = "0x12801E0", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(EncryptionCredentials), Member = "Generate", ReturnType = typeof(EncryptionCredentials))]
	[Calls(Type = typeof(EncryptionCredentials), Member = "LoadFromFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(EncryptionCredentials))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000156")]
	protected virtual void ThreadedServerStart() { }

	[Address(RVA = "0x1281060", Offset = "0x1280260", Length = "0x88")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000146")]
	public virtual string ToString() { }

}

