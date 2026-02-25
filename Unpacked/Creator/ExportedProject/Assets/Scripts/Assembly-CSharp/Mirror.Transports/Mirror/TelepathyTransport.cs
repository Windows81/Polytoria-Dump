namespace Mirror;

[DisallowMultipleComponent]
[HelpURL("https://github.com/vis2k/Telepathy/blob/master/README.md")]
[Token(Token = "0x200000A")]
public class TelepathyTransport : Transport, PortTransport
{
	[Token(Token = "0x400004C")]
	public const string Scheme = "tcp4"; //Field offset: 0x0
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400004D")]
	public ushort port; //Field offset: 0x88
	[FieldOffset(Offset = "0x8A")]
	[Header("Common")]
	[Token(Token = "0x400004E")]
	[Tooltip("Nagle Algorithm can be disabled by enabling NoDelay")]
	public bool NoDelay; //Field offset: 0x8A
	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x400004F")]
	[Tooltip("Send timeout in milliseconds.")]
	public int SendTimeout; //Field offset: 0x8C
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000050")]
	[Tooltip("Receive timeout in milliseconds. High by default so users don't time out during scene changes.")]
	public int ReceiveTimeout; //Field offset: 0x90
	[FieldOffset(Offset = "0x94")]
	[Header("Server")]
	[Token(Token = "0x4000051")]
	[Tooltip("Protect against allocation attacks by keeping the max message size small. Otherwise an attacker might send multiple fake packets with 2GB headers, causing the server to run out of memory after allocating multiple large packets.")]
	public int serverMaxMessageSize; //Field offset: 0x94
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000052")]
	[Tooltip("Server processes a limit amount of messages per tick to avoid a deadlock where it might end up processing forever if messages come in faster than we can process them.")]
	public int serverMaxReceivesPerTick; //Field offset: 0x98
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x4000053")]
	[Tooltip("Server send queue limit per connection for pending messages. Telepathy will disconnect a connection's queues reach that limit for load balancing. Better to kick one slow client than slowing down the whole server.")]
	public int serverSendQueueLimitPerConnection; //Field offset: 0x9C
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000054")]
	[Tooltip("Server receive queue limit per connection for pending messages. Telepathy will disconnect a connection's queues reach that limit for load balancing. Better to kick one slow client than slowing down the whole server.")]
	public int serverReceiveQueueLimitPerConnection; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA4")]
	[Header("Client")]
	[Token(Token = "0x4000055")]
	[Tooltip("Protect against allocation attacks by keeping the max message size small. Otherwise an attacker host might send multiple fake packets with 2GB headers, causing the connected clients to run out of memory after allocating multiple large packets.")]
	public int clientMaxMessageSize; //Field offset: 0xA4
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000056")]
	[Tooltip("Client processes a limit amount of messages per tick to avoid a deadlock where it might end up processing forever if messages come in faster than we can process them.")]
	public int clientMaxReceivesPerTick; //Field offset: 0xA8
	[FieldOffset(Offset = "0xAC")]
	[Token(Token = "0x4000057")]
	[Tooltip("Client send queue limit for pending messages. Telepathy will disconnect if the connection's queues reach that limit in order to avoid ever growing latencies.")]
	public int clientSendQueueLimit; //Field offset: 0xAC
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000058")]
	[Tooltip("Client receive queue limit for pending messages. Telepathy will disconnect if the connection's queues reach that limit in order to avoid ever growing latencies.")]
	public int clientReceiveQueueLimit; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000059")]
	private Client client; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x400005A")]
	private Server server; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x400005B")]
	private Func<Boolean> enabledCheck; //Field offset: 0xC8

	[Token(Token = "0x17000004")]
	public override ushort Port
	{
		[Address(RVA = "0x127B1D0", Offset = "0x127A3D0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600007B")]
		 get { } //Length: 8
		[Address(RVA = "0x127B1E0", Offset = "0x127A3E0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600007C")]
		 set { } //Length: 8
	}

	[Address(RVA = "0x127FCB0", Offset = "0x127EEB0", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000091")]
	public TelepathyTransport() { }

	[Address(RVA = "0x127FC70", Offset = "0x127EE70", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Behaviour), Member = "get_enabled", ReturnType = typeof(bool))]
	[CompilerGenerated]
	[Token(Token = "0x6000092")]
	private bool <Awake>b__19_0() { }

	[Address(RVA = "0x12725F0", Offset = "0x12717F0", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000093")]
	private void <CreateClient>b__21_0() { }

	[Address(RVA = "0x127EBB0", Offset = "0x127DDB0", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000094")]
	private void <CreateClient>b__21_1(ArraySegment<Byte> segment) { }

	[Address(RVA = "0x1272660", Offset = "0x1271860", Length = "0x19")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000095")]
	private void <CreateClient>b__21_2() { }

	[Address(RVA = "0x127FC80", Offset = "0x127EE80", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[Token(Token = "0x6000096")]
	private void <ServerStart>b__30_0(int connectionId, string remoteClientAddress) { }

	[Address(RVA = "0x127ECD0", Offset = "0x127DED0", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000097")]
	private void <ServerStart>b__30_1(int connectionId, ArraySegment<Byte> segment) { }

	[Address(RVA = "0x1272770", Offset = "0x1271970", Length = "0x28")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000098")]
	private void <ServerStart>b__30_2(int connectionId) { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x600007E")]
	public virtual bool Available() { }

	[Address(RVA = "0x127F080", Offset = "0x127E280", Length = "0x1F0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x600007D")]
	private void Awake() { }

	[Address(RVA = "0x127F270", Offset = "0x127E470", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TelepathyTransport), Member = "CreateClient", ReturnType = typeof(void))]
	[Calls(Type = typeof(Client), Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000081")]
	public virtual void ClientConnect(string address) { }

	[Address(RVA = "0x127F2C0", Offset = "0x127E4C0", Length = "0x139")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Uri), Member = "get_Port", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Client), Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "get_Host", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Uri), Member = "get_IsDefaultPort", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Uri), Member = "get_Scheme", ReturnType = typeof(string))]
	[Calls(Type = typeof(TelepathyTransport), Member = "CreateClient", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000082")]
	public virtual void ClientConnect(Uri uri) { }

	[Address(RVA = "0x127F400", Offset = "0x127E600", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Client), Member = "get_Connected", ReturnType = typeof(bool))]
	[Token(Token = "0x6000080")]
	public virtual bool ClientConnected() { }

	[Address(RVA = "0x127F420", Offset = "0x127E620", Length = "0x58")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Client), Member = "Disconnect", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000084")]
	public virtual void ClientDisconnect() { }

	[Address(RVA = "0x127F480", Offset = "0x127E680", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Behaviour), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Client), Member = "Tick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Func`1<System.Boolean>)}, ReturnType = typeof(int))]
	[Token(Token = "0x6000085")]
	public virtual void ClientEarlyUpdate() { }

	[Address(RVA = "0x127F4C0", Offset = "0x127E6C0", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Client), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000083")]
	public virtual void ClientSend(ArraySegment<Byte> segment, int channelId) { }

	[Address(RVA = "0x127F530", Offset = "0x127E730", Length = "0x1ED")]
	[CalledBy(Type = typeof(TelepathyTransport), Member = "ClientConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TelepathyTransport), Member = "ClientConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Client), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x600007F")]
	private void CreateClient() { }

	[Address(RVA = "0x127B1D0", Offset = "0x127A3D0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600007B")]
	public override ushort get_Port() { }

	[Address(RVA = "0x508E50", Offset = "0x508050", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600008F")]
	public virtual int GetMaxPacketSize(int channelId) { }

	[Address(RVA = "0x127F720", Offset = "0x127E920", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Server), Member = "get_Active", ReturnType = typeof(bool))]
	[Token(Token = "0x6000087")]
	public virtual bool ServerActive() { }

	[Address(RVA = "0x127F740", Offset = "0x127E940", Length = "0x15")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Server), Member = "Disconnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600008A")]
	public virtual void ServerDisconnect(int connectionId) { }

	[Address(RVA = "0x127F760", Offset = "0x127E960", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Behaviour), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Server), Member = "Tick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Func`1<System.Boolean>)}, ReturnType = typeof(int))]
	[Token(Token = "0x600008D")]
	public virtual void ServerEarlyUpdate() { }

	[Address(RVA = "0x127F7A0", Offset = "0x127E9A0", Length = "0x17")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Server), Member = "GetClientAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Token(Token = "0x600008B")]
	public virtual string ServerGetClientAddress(int connectionId) { }

	[Address(RVA = "0x127F7C0", Offset = "0x127E9C0", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Server), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000089")]
	public virtual void ServerSend(int connectionId, ArraySegment<Byte> segment, int channelId) { }

	[Address(RVA = "0x127F840", Offset = "0x127EA40", Length = "0x217")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Server), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Action`2<System.Int32, System.ArraySegment`1<System.Byte>>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Server), Member = "Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000088")]
	public virtual void ServerStart() { }

	[Address(RVA = "0x127FA60", Offset = "0x127EC60", Length = "0x3A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Server), Member = "Stop", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600008C")]
	public virtual void ServerStop() { }

	[Address(RVA = "0x127FAA0", Offset = "0x127ECA0", Length = "0xA5")]
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
	[Token(Token = "0x6000086")]
	public virtual Uri ServerUri() { }

	[Address(RVA = "0x127B1E0", Offset = "0x127A3E0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600007C")]
	public override void set_Port(ushort value) { }

	[Address(RVA = "0x127FB50", Offset = "0x127ED50", Length = "0xB1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Client), Member = "Disconnect", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Server), Member = "Stop", ReturnType = typeof(void))]
	[Token(Token = "0x600008E")]
	public virtual void Shutdown() { }

	[Address(RVA = "0x127FC10", Offset = "0x127EE10", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000090")]
	public virtual string ToString() { }

}

