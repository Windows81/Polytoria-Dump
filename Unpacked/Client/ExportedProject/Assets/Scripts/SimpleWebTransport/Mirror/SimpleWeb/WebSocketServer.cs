namespace Mirror.SimpleWeb;

[Token(Token = "0x200002B")]
public class WebSocketServer
{
	[CompilerGenerated]
	[Token(Token = "0x200002C")]
	private sealed class <>c__DisplayClass14_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000097")]
		public Connection conn; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000098")]
		public WebSocketServer <>4__this; //Field offset: 0x18

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000C7")]
		public <>c__DisplayClass14_0() { }

		[Address(RVA = "0x155DEB0", Offset = "0x155D0B0", Length = "0x25")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(WebSocketServer), Member = "HandshakeAndReceiveLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Connection)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60000C8")]
		internal void <acceptLoop>b__0() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200002D")]
	private sealed class <>c__DisplayClass15_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000099")]
		public Connection conn; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400009A")]
		public WebSocketServer <>4__this; //Field offset: 0x18

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000C9")]
		public <>c__DisplayClass15_0() { }

		[Address(RVA = "0x155DEE0", Offset = "0x155D0E0", Length = "0xB1")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(SendLoop), Member = "Loop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Config)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x60000CA")]
		internal void <HandshakeAndReceiveLoop>b__0() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400008C")]
	public readonly ConcurrentQueue<Message> receiveQueue; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400008D")]
	private readonly TcpConfig tcpConfig; //Field offset: 0x18
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400008E")]
	private readonly int maxMessageSize; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400008F")]
	private TcpListener listener; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000090")]
	private Thread acceptThread; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000091")]
	private bool serverStopped; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000092")]
	private readonly ServerHandshake handShake; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000093")]
	private readonly ServerSslHelper sslHelper; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000094")]
	private readonly BufferPool bufferPool; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000095")]
	private readonly ConcurrentDictionary<Int32, Connection> connections; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000096")]
	private int _idCounter; //Field offset: 0x60

	[Address(RVA = "0x1560E30", Offset = "0x1560030", Length = "0x30C")]
	[CalledBy(Type = typeof(SimpleWebServer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TcpConfig), typeof(int), typeof(int), typeof(SslConfig)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(X509Certificate2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Log), Member = "Info", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T1", "T2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T1", "T2", typeof(ConsoleColor)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(X509Certificate), Member = "get_Subject", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(SHA1), Member = "Create", ReturnType = typeof(SHA1))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentQueue`1<Mirror.SimpleWeb.Message>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000BD")]
	public WebSocketServer(TcpConfig tcpConfig, int maxMessageSize, int handshakeMaxSize, SslConfig sslConfig, BufferPool bufferPool) { }

	[Address(RVA = "0x1561140", Offset = "0x1560340", Length = "0x33E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Log), Member = "Verbose", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Log), Member = "Exception", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Log), Member = "Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Log), Member = "InfoException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Thread), Member = "Start", ReturnType = typeof(void))]
	[Calls(Type = typeof(Thread), Member = "set_IsBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Thread), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ThreadStart)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Connection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TcpClient), typeof(System.Action`1<Mirror.SimpleWeb.Connection>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TcpClient), Member = "set_NoDelay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TcpClient), Member = "set_ReceiveTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TcpClient), Member = "set_SendTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TcpListener), Member = "AcceptTcpClient", ReturnType = typeof(TcpClient))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Utils), Member = "CheckForInterupt", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001E080")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60000C0")]
	private void acceptLoop() { }

	[Address(RVA = "0x155FD40", Offset = "0x155EF40", Length = "0xBF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentQueue`1<Mirror.SimpleWeb.Message>), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Message)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "TryRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000C2")]
	private void AfterConnectionDisposed(Connection conn) { }

	[Address(RVA = "0x155FE00", Offset = "0x155F000", Length = "0x14E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Log), Member = "Warn", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Log), Member = "Info", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T", typeof(ConsoleColor)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Connection), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000C4")]
	public bool CloseConnection(int id) { }

	[Address(RVA = "0x155FF50", Offset = "0x155F150", Length = "0xCD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Log), Member = "Warn", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000C5")]
	public string GetClientAddress(int id) { }

	[Address(RVA = "0x1560020", Offset = "0x155F220", Length = "0xCD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Log), Member = "Warn", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000C6")]
	public Request GetClientRequest(int id) { }

	[Address(RVA = "0x15600F0", Offset = "0x155F2F0", Length = "0x97F")]
	[CalledBy(Type = typeof(<>c__DisplayClass14_0), Member = "<acceptLoop>b__0", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Thread), Member = "set_IsBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Thread), Member = "set_Name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Thread), Member = "Start", ReturnType = typeof(void))]
	[Calls(Type = typeof(ReceiveLoop), Member = "Loop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Config)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Console), Member = "set_ForegroundColor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConsoleColor)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(Console), Member = "ResetColor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Log), Member = "InfoException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Log), Member = "Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Log), Member = "Exception", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Console), Member = "WriteLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentQueue`1<Mirror.SimpleWeb.Message>), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Message)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "TryAdd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Log), Member = "Verbose", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Connection), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Log), Member = "Warn", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ServerHandshake), Member = "TryHandshake", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Connection)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ServerSslHelper), Member = "TryCreateStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Connection)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Thread), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ThreadStart)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000C1")]
	private void HandshakeAndReceiveLoop(Connection conn) { }

	[Address(RVA = "0x1560A70", Offset = "0x155FC70", Length = "0x14B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TcpListener), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TcpListener))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TcpListener), Member = "Start", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Log), Member = "Verbose", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Thread), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ThreadStart)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Thread), Member = "set_IsBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Thread), Member = "Start", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000BE")]
	public void Listen(int port) { }

	[Address(RVA = "0x1560BC0", Offset = "0x155FDC0", Length = "0x11B")]
	[CalledBy(Type = typeof(SimpleWebServer), Member = "SendAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>), typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SimpleWebServer), Member = "SendOne", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Log), Member = "Warn", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentQueue`1<System.Object>), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ManualResetEventSlim), Member = "Set", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000C3")]
	public void Send(int id, ArrayBuffer buffer) { }

	[Address(RVA = "0x1560CE0", Offset = "0x155FEE0", Length = "0x147")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TcpListener), Member = "Stop", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Log), Member = "Verbose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "ToArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(Connection), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60000BF")]
	public void Stop() { }

}

