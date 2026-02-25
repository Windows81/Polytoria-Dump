namespace Mirror.SimpleWeb;

[Token(Token = "0x2000012")]
internal sealed class Connection : IDisposable
{
	[Token(Token = "0x400002F")]
	public const int IdNotSet = -1; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400002E")]
	private readonly object disposedLock; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000030")]
	public TcpClient client; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000031")]
	public int connId; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000032")]
	public Request request; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000033")]
	public string remoteAddress; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000034")]
	public Stream stream; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000035")]
	public Thread receiveThread; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000036")]
	public Thread sendThread; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000037")]
	public ManualResetEventSlim sendPending; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000038")]
	public ConcurrentQueue<ArrayBuffer> sendQueue; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000039")]
	public Action<Connection> onDispose; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400003A")]
	private bool hasDisposed; //Field offset: 0x68

	[Address(RVA = "0x1555D40", Offset = "0x1554F40", Length = "0x172")]
	[CalledBy(Type = typeof(WebSocketClientStandAlone), Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebSocketServer), Member = "acceptLoop", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ManualResetEventSlim), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentQueue`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000049")]
	public Connection(TcpClient client, Action<Connection> onDispose) { }

	[Address(RVA = "0x1555710", Offset = "0x1554910", Length = "0x1B9")]
	[CalledBy(Type = typeof(ServerHandshake), Member = "TryHandshake", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Connection)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Socket), Member = "get_RemoteEndPoint", ReturnType = typeof(EndPoint))]
	[Calls(Type = typeof(IPAddress), Member = "get_IsIPv4MappedToIPv6", ReturnType = typeof(bool))]
	[Calls(Type = typeof(IPAddress), Member = "MapToIPv4", ReturnType = typeof(IPAddress))]
	[Calls(Type = typeof(string), Member = "Split", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(StringSplitOptions)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(Enumerable), Member = "First", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600004C")]
	internal string CalculateAddress() { }

	[Address(RVA = "0x15558D0", Offset = "0x1554AD0", Length = "0x2F4")]
	[CalledBy(Type = typeof(SimpleWebServer), Member = "KickClient", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnitySourceGeneratedAssemblyMonoScriptTypes_v1", Member = "Get", ReturnType = "UnitySourceGeneratedAssemblyMonoScriptTypes_v1+MonoScriptData")]
	[CalledBy(Type = typeof(WebSocketClientStandAlone), Member = "ConnectAndReceiveLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebSocketClientStandAlone), Member = "Disconnect", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReceiveLoop), Member = "Loop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Config)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ReceiveLoop), Member = "HandleCloseMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Config), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SendLoop), Member = "Loop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Config)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SimpleWebServer), Member = "Stop", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebSocketServer), Member = "CloseConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(WebSocketServer), Member = "Stop", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebSocketServer), Member = "HandshakeAndReceiveLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Connection)}, ReturnType = typeof(void))]
	[CallerCount(Count = 35)]
	[Calls(Type = typeof(ArrayBuffer), Member = "Release", ReturnType = typeof(void))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentQueue`1<System.Object>), Member = "TryDequeue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ManualResetEventSlim), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Log), Member = "Exception", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Log), Member = "Verbose", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600004A")]
	public override void Dispose() { }

	[Address(RVA = "0x1555BD0", Offset = "0x1554DD0", Length = "0x164")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(string), Member = "IsNullOrWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Socket), Member = "get_RemoteEndPoint", ReturnType = typeof(EndPoint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x600004B")]
	public virtual string ToString() { }

}

