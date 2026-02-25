namespace Mirror.SimpleWeb;

[DisallowMultipleComponent]
[HelpURL("https://mirror-networking.gitbook.io/docs/manual/transports/websockets-transport")]
[Token(Token = "0x2000012")]
public class SimpleWebTransport : Transport, PortTransport
{
	[Token(Token = "0x400008A")]
	public const string NormalScheme = "ws"; //Field offset: 0x0
	[Token(Token = "0x400008B")]
	public const string SecureScheme = "wss"; //Field offset: 0x0
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400008C")]
	[Tooltip("Protect against allocation attacks by keeping the max message size small. Otherwise an attacker might send multiple fake packets with 2GB headers, causing the server to run out of memory after allocating multiple large packets.")]
	public int maxMessageSize; //Field offset: 0x88
	[FieldOffset(Offset = "0x8C")]
	[FormerlySerializedAs("handshakeMaxSize")]
	[Token(Token = "0x400008D")]
	[Tooltip("Max size for http header send as handshake for websockets")]
	public int maxHandshakeSize; //Field offset: 0x8C
	[FieldOffset(Offset = "0x90")]
	[FormerlySerializedAs("serverMaxMessagesPerTick")]
	[Token(Token = "0x400008E")]
	[Tooltip("Caps the number of messages the server will process per tick. Allows LateUpdate to finish to let the reset of unity continue in case more messages arrive before they are processed")]
	public int serverMaxMsgsPerTick; //Field offset: 0x90
	[FieldOffset(Offset = "0x94")]
	[FormerlySerializedAs("clientMaxMessagesPerTick")]
	[Token(Token = "0x400008F")]
	[Tooltip("Caps the number of messages the client will process per tick. Allows LateUpdate to finish to let the reset of unity continue in case more messages arrive before they are processed")]
	public int clientMaxMsgsPerTick; //Field offset: 0x94
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000090")]
	[Tooltip("Send would stall forever if the network is cut off during a send, so we need a timeout (in milliseconds)")]
	public int sendTimeout; //Field offset: 0x98
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x4000091")]
	[Tooltip("How long without a message before disconnecting (in milliseconds)")]
	public int receiveTimeout; //Field offset: 0x9C
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000092")]
	[Tooltip("disables nagle algorithm. lowers CPU% and latency but increases bandwidth")]
	public bool noDelay; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA1")]
	[Header("Obsolete SSL settings")]
	[Token(Token = "0x4000093")]
	[Tooltip("Requires wss connections on server, only to be used with SSL cert.json, never with reverse proxy.\nNOTE: if sslEnabled is true clientUseWss is forced true, even if not checked.")]
	public bool sslEnabled; //Field offset: 0xA1
	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x4000094")]
	[Tooltip("Protocols that SSL certificate is created to support.")]
	public SslProtocols sslProtocols; //Field offset: 0xA4
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000095")]
	[Tooltip("Path to json file that contains path to cert and its password\nUse Json file so that cert password is not included in client builds\nSee Assets/Mirror/Transports/.cert.example.Json")]
	public string sslCertJson; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Header("Server settings")]
	[Token(Token = "0x4000096")]
	[Tooltip("Port to use for server")]
	public ushort port; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB2")]
	[Token(Token = "0x4000097")]
	[Tooltip("Groups messages in queue before calling Stream.Send")]
	public bool batchSend; //Field offset: 0xB2
	[FieldOffset(Offset = "0xB3")]
	[Token(Token = "0x4000098")]
	[Tooltip("Waits for 1ms before grouping and sending messages.\nThis gives time for mirror to finish adding message to queue so that less groups need to be made.\nIf WaitBeforeSend is true then BatchSend Will also be set to true")]
	public bool waitBeforeSend; //Field offset: 0xB3
	[FieldOffset(Offset = "0xB4")]
	[Header("Client settings")]
	[Token(Token = "0x4000099")]
	[Tooltip("Sets connect scheme to wss. Useful when client needs to connect using wss when TLS is outside of transport.\nNOTE: if sslEnabled is true clientUseWss is also true")]
	public bool clientUseWss; //Field offset: 0xB4
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400009A")]
	public ClientWebsocketSettings clientWebsocketSettings; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Header("Logging")]
	[SerializeField]
	[Token(Token = "0x400009B")]
	[Tooltip("Choose minimum severity level for logging\nFlood level requires Debug build")]
	private Levels minimumLogLevel; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x400009C")]
	private SimpleWebClient client; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x400009D")]
	private SimpleWebServer server; //Field offset: 0xD0

	[Token(Token = "0x17000009")]
	public virtual string EncryptionCipher
	{
		[Address(RVA = "0x127EF10", Offset = "0x127E110", Length = "0x2C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60000D9")]
		 get { } //Length: 44
	}

	[Token(Token = "0x17000008")]
	public virtual bool IsEncrypted
	{
		[Address(RVA = "0x127EF40", Offset = "0x127E140", Length = "0x67")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60000D8")]
		 get { } //Length: 103
	}

	[Token(Token = "0x17000006")]
	public Levels LogLevels
	{
		[Address(RVA = "0x3D6650", Offset = "0x3D5850", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000CE")]
		 get { } //Length: 7
		[Address(RVA = "0x127F000", Offset = "0x127E200", Length = "0x65")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60000CF")]
		 set { } //Length: 101
	}

	[Token(Token = "0x17000005")]
	public override ushort Port
	{
		[Address(RVA = "0x127EFB0", Offset = "0x127E1B0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60000CC")]
		 get { } //Length: 8
		[Address(RVA = "0x127F070", Offset = "0x127E270", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60000CD")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000007")]
	private TcpConfig TcpConfig
	{
		[Address(RVA = "0x127EFC0", Offset = "0x127E1C0", Length = "0x3F")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60000D0")]
		private get { } //Length: 63
	}

	[Address(RVA = "0x127EE30", Offset = "0x127E030", Length = "0xD5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000EA")]
	public SimpleWebTransport() { }

	[Address(RVA = "0x127EB60", Offset = "0x127DD60", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[Token(Token = "0x60000EB")]
	private void <ClientConnect>b__41_0() { }

	[Address(RVA = "0x127EBB0", Offset = "0x127DDB0", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60000EC")]
	private void <ClientConnect>b__41_1(ArraySegment<Byte> data) { }

	[Address(RVA = "0x127EBF0", Offset = "0x127DDF0", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	[Token(Token = "0x60000ED")]
	private void <ClientConnect>b__41_2(Exception e) { }

	[Address(RVA = "0x127EC60", Offset = "0x127DE60", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	[Token(Token = "0x60000EE")]
	private void <ClientConnect>b__41_3(Exception e) { }

	[Address(RVA = "0x127ECD0", Offset = "0x127DED0", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60000EF")]
	private void <ServerStart>b__48_0(int connId, ArraySegment<Byte> data) { }

	[Address(RVA = "0x127ED10", Offset = "0x127DF10", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	[Token(Token = "0x60000F0")]
	private void <ServerStart>b__48_1(int connId, Exception exception) { }

	[Address(RVA = "0x127EDA0", Offset = "0x127DFA0", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	[Token(Token = "0x60000F1")]
	private void <ServerStart>b__48_2(int connId, Exception exception) { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000D4")]
	public virtual bool Available() { }

	[Address(RVA = "0x127DAD0", Offset = "0x127CCD0", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60000D1")]
	private void Awake() { }

	[Address(RVA = "0x127DC50", Offset = "0x127CE50", Length = "0x30E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SimpleWebClient), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TcpConfig)}, ReturnType = typeof(SimpleWebClient))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SimpleWebClient), Member = "add_onConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SimpleWebClient), Member = "add_onDisconnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SimpleWebClient), Member = "add_onData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.ArraySegment`1<System.Byte>>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SimpleWebClient), Member = "add_onError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Exception>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Log), Member = "Warn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60000DC")]
	public virtual void ClientConnect(Uri uri) { }

	[Address(RVA = "0x127DB30", Offset = "0x127CD30", Length = "0x113")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(UriBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(UriBuilder), Member = "set_Scheme", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UriBuilder), Member = "set_Host", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UriBuilder), Member = "set_Port", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UriBuilder), Member = "get_Uri", ReturnType = typeof(Uri))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000DB")]
	public virtual void ClientConnect(string hostname) { }

	[Address(RVA = "0x127DF60", Offset = "0x127D160", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000DA")]
	public virtual bool ClientConnected() { }

	[Address(RVA = "0x127DF80", Offset = "0x127D180", Length = "0x21")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000DD")]
	public virtual void ClientDisconnect() { }

	[Address(RVA = "0x127DFB0", Offset = "0x127D1B0", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SimpleWebClient), Member = "ProcessMessageQueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBehaviour)}, ReturnType = typeof(void))]
	[Token(Token = "0x60000DF")]
	public virtual void ClientEarlyUpdate() { }

	[Address(RVA = "0x127DFD0", Offset = "0x127D1D0", Length = "0x1B8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Log), Member = "Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60000DE")]
	public virtual void ClientSend(ArraySegment<Byte> segment, int channelId) { }

	[Address(RVA = "0x127EF10", Offset = "0x127E110", Length = "0x2C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60000D9")]
	public virtual string get_EncryptionCipher() { }

	[Address(RVA = "0x127EF40", Offset = "0x127E140", Length = "0x67")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60000D8")]
	public virtual bool get_IsEncrypted() { }

	[Address(RVA = "0x3D6650", Offset = "0x3D5850", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000CE")]
	public Levels get_LogLevels() { }

	[Address(RVA = "0x127EFB0", Offset = "0x127E1B0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60000CC")]
	public override ushort get_Port() { }

	[Address(RVA = "0x127EFC0", Offset = "0x127E1C0", Length = "0x3F")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000D0")]
	private TcpConfig get_TcpConfig() { }

	[Address(RVA = "0x127E190", Offset = "0x127D390", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60000D7")]
	private string GetClientScheme() { }

	[Address(RVA = "0x504490", Offset = "0x503690", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000D5")]
	public virtual int GetMaxPacketSize(int channelId = 0) { }

	[Address(RVA = "0x127E1F0", Offset = "0x127D3F0", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60000E0")]
	private string GetServerScheme() { }

	[Address(RVA = "0x127E240", Offset = "0x127D440", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60000D3")]
	private void OnValidate() { }

	[Address(RVA = "0x127E2A0", Offset = "0x127D4A0", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60000E2")]
	public virtual bool ServerActive() { }

	[Address(RVA = "0x127E2C0", Offset = "0x127D4C0", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SimpleWebServer), Member = "KickClient", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000E5")]
	public virtual void ServerDisconnect(int connectionId) { }

	[Address(RVA = "0x127E310", Offset = "0x127D510", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SimpleWebServer), Member = "ProcessMessageQueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBehaviour)}, ReturnType = typeof(void))]
	[Token(Token = "0x60000E9")]
	public virtual void ServerEarlyUpdate() { }

	[Address(RVA = "0x127E330", Offset = "0x127D530", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SimpleWebServer), Member = "GetClientAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000E7")]
	public virtual string ServerGetClientAddress(int connectionId) { }

	[Address(RVA = "0x127E360", Offset = "0x127D560", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SimpleWebServer), Member = "GetClientRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Request))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000E8")]
	public Request ServerGetClientRequest(int connectionId) { }

	[Address(RVA = "0x127E390", Offset = "0x127D590", Length = "0x1AA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(SimpleWebServer), Member = "SendOne", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Log), Member = "Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60000E6")]
	public virtual void ServerSend(int connectionId, ArraySegment<Byte> segment, int channelId) { }

	[Address(RVA = "0x127E540", Offset = "0x127D740", Length = "0x3F7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SimpleWebServer), Member = "add_onError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<System.Int32, System.Exception>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SimpleWebServer), Member = "add_onData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<System.Int32, System.ArraySegment`1<System.Byte>>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Action`2<System.Int32, System.ArraySegment`1<System.Byte>>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SimpleWebServer), Member = "add_onDisconnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SimpleWebServer), Member = "add_onConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<System.Int32, System.String>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SimpleWebServer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TcpConfig), typeof(int), typeof(int), typeof(SslConfig)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SslConfigLoader), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string), typeof(SslProtocols)}, ReturnType = typeof(SslConfig))]
	[Calls(Type = typeof(Log), Member = "Warn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(SimpleWebServer), Member = "Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000E3")]
	public virtual void ServerStart() { }

	[Address(RVA = "0x127E940", Offset = "0x127DB40", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SimpleWebServer), Member = "Stop", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000E4")]
	public virtual void ServerStop() { }

	[Address(RVA = "0x127E9A0", Offset = "0x127DBA0", Length = "0xD0")]
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
	[Token(Token = "0x60000E1")]
	public virtual Uri ServerUri() { }

	[Address(RVA = "0x127F000", Offset = "0x127E200", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60000CF")]
	public void set_LogLevels(Levels value) { }

	[Address(RVA = "0x127F070", Offset = "0x127E270", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60000CD")]
	public override void set_Port(ushort value) { }

	[Address(RVA = "0x127EA80", Offset = "0x127DC80", Length = "0x72")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(SimpleWebServer), Member = "Stop", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000D6")]
	public virtual void Shutdown() { }

	[Address(RVA = "0x127EB00", Offset = "0x127DD00", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x60000D2")]
	public virtual string ToString() { }

}

