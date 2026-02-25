namespace System.Net.Sockets;

[Token(Token = "0x20002FC")]
public class TcpClient : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000DDD")]
	private Socket m_ClientSocket; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000DDE")]
	private bool m_Active; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000DDF")]
	private NetworkStream m_DataStream; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000DE0")]
	private AddressFamily m_Family; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000DE1")]
	private bool m_CleanedUp; //Field offset: 0x2C

	[Token(Token = "0x17000403")]
	public Socket Client
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x600133B")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600133C")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000404")]
	public bool Connected
	{
		[Address(RVA = "0x172C230", Offset = "0x172B430", Length = "0x1B")]
		[CalledBy(Type = "Mirror.SimpleWeb.ReceiveLoop", Member = "Loop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.SimpleWeb.ReceiveLoop+Config"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.SimpleWeb.SendLoop", Member = "Loop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.SimpleWeb.SendLoop+Config"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Telepathy.ThreadFunctions", Member = "SendLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TcpClient), "Telepathy.MagnificentSendPipe", typeof(ManualResetEvent)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600133D")]
		 get { } //Length: 27
	}

	[Token(Token = "0x17000407")]
	public bool NoDelay
	{
		[Address(RVA = "0x172C2E0", Offset = "0x172B4E0", Length = "0x34")]
		[CalledBy(Type = "Mirror.SimpleWeb.WebSocketClientStandAlone", Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.SimpleWeb.TcpConfig", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TcpClient)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.SimpleWeb.WebSocketServer", Member = "acceptLoop", ReturnType = typeof(void))]
		[CalledBy(Type = "Telepathy.Client", Member = "ReceiveThreadFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Telepathy.ClientConnectionState", typeof(string), typeof(int), typeof(int), typeof(bool), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Telepathy.Server", Member = "Listen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Socket), Member = "SetSocketOption", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketOptionLevel), typeof(SocketOptionName), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600134A")]
		 set { } //Length: 52
	}

	[Token(Token = "0x17000405")]
	public int ReceiveTimeout
	{
		[Address(RVA = "0x172C320", Offset = "0x172B520", Length = "0x33")]
		[CalledBy(Type = "Mirror.SimpleWeb.WebSocketClientStandAlone", Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.SimpleWeb.TcpConfig", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TcpClient)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.SimpleWeb.WebSocketServer", Member = "acceptLoop", ReturnType = typeof(void))]
		[CalledBy(Type = "Telepathy.Client", Member = "ReceiveThreadFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Telepathy.ClientConnectionState", typeof(string), typeof(int), typeof(int), typeof(bool), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Telepathy.Server", Member = "Listen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Socket), Member = "SetSocketOption", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketOptionLevel), typeof(SocketOptionName), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001348")]
		 set { } //Length: 51
	}

	[Token(Token = "0x17000406")]
	public int SendTimeout
	{
		[Address(RVA = "0x172C360", Offset = "0x172B560", Length = "0x33")]
		[CalledBy(Type = "Mirror.SimpleWeb.WebSocketClientStandAlone", Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.SimpleWeb.TcpConfig", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TcpClient)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.SimpleWeb.WebSocketServer", Member = "acceptLoop", ReturnType = typeof(void))]
		[CalledBy(Type = "Telepathy.Client", Member = "ReceiveThreadFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Telepathy.ClientConnectionState", typeof(string), typeof(int), typeof(int), typeof(bool), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Telepathy.Server", Member = "Listen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Socket), Member = "SetSocketOption", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketOptionLevel), typeof(SocketOptionName), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001349")]
		 set { } //Length: 51
	}

	[Address(RVA = "0x172BFB0", Offset = "0x172B1B0", Length = "0xB3")]
	[CalledBy(Type = "System.Net.FtpWebRequest+<CreateConnectionAsync>d__86", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "CreateConnection", ReturnType = typeof(FtpControlStream))]
	[CalledBy(Type = "Mirror.SimpleWeb.WebSocketClientStandAlone", Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Telepathy.ClientConnectionState", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Telepathy.Client", Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Socket), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AddressFamily), typeof(SocketType), typeof(ProtocolType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x6001338")]
	public TcpClient() { }

	[Address(RVA = "0x172C0C0", Offset = "0x172B2C0", Length = "0x169")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Socket), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AddressFamily), typeof(SocketType), typeof(ProtocolType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = "SR", Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6001339")]
	public TcpClient(AddressFamily family) { }

	[Address(RVA = "0x172C070", Offset = "0x172B270", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x600133A")]
	internal TcpClient(Socket acceptedSocket) { }

	[Address(RVA = "0x172B320", Offset = "0x172A520", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Socket), Member = "BeginConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(AsyncCallback), typeof(object)}, ReturnType = typeof(IAsyncResult))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001340")]
	public IAsyncResult BeginConnect(string host, int port, AsyncCallback requestCallback, object state) { }

	[Address(RVA = "0x172B3A0", Offset = "0x172A5A0", Length = "0x49")]
	[CalledBy(Type = typeof(WebProxy), Member = "set_UseDefaultCredentials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Telepathy.ClientConnectionState", Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = "Telepathy.Client", Member = "ReceiveThreadFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Telepathy.ClientConnectionState", typeof(string), typeof(int), typeof(int), typeof(bool), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Telepathy.Client", Member = "Disconnect", ReturnType = typeof(void))]
	[CalledBy(Type = "Telepathy.Client", Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ArraySegment`1<Byte>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Telepathy.Server", Member = "Stop", ReturnType = typeof(void))]
	[CalledBy(Type = "Telepathy.Server", Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.ArraySegment`1<Byte>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Telepathy.Server", Member = "Disconnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Telepathy.ThreadFunctions", Member = "SendLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TcpClient), "Telepathy.MagnificentSendPipe", typeof(ManualResetEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001344")]
	public void Close() { }

	[Address(RVA = "0x172B670", Offset = "0x172A870", Length = "0x656")]
	[CalledBy(Type = typeof(FtpWebRequest), Member = "CreateConnection", ReturnType = typeof(FtpControlStream))]
	[CalledBy(Type = "Mirror.SimpleWeb.WebSocketClientStandAlone", Member = "ConnectAndReceiveLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Telepathy.Client", Member = "ReceiveThreadFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Telepathy.ClientConnectionState", typeof(string), typeof(int), typeof(int), typeof(bool), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Socket), Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181716980")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001E080")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "Close", ReturnType = typeof(void))]
	[Calls(Type = typeof(TcpClient), Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPEndPoint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(IPEndPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IPAddress), Member = "get_AddressFamily", ReturnType = typeof(AddressFamily))]
	[Calls(Type = typeof(Socket), Member = "get_OSSupportsIPv6", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Socket), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AddressFamily), typeof(SocketType), typeof(ProtocolType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Socket), Member = "get_OSSupportsIPv4", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dns), Member = "GetHostAddresses", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IPAddress[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x600133E")]
	public void Connect(string hostname, int port) { }

	[Address(RVA = "0x172B560", Offset = "0x172A760", Length = "0x103")]
	[CalledBy(Type = typeof(TcpClient), Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Socket), Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EndPoint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600133F")]
	public void Connect(IPEndPoint remoteEP) { }

	[Address(RVA = "0x172B3F0", Offset = "0x172A5F0", Length = "0x166")]
	[CalledBy(Type = "System.Net.FtpWebRequest+<CreateConnectionAsync>d__86", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Func`5), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TaskFactory), Member = "FromAsync", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TArg1", "TArg2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Func`5<TArg1, TArg2, AsyncCallback, Object, IAsyncResult>", typeof(System.Action`1<System.IAsyncResult>), "TArg1", "TArg2", typeof(object)}, ReturnType = typeof(Task))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001342")]
	public Task ConnectAsync(string host, int port) { }

	[Address(RVA = "0x146EBB0", Offset = "0x146DDB0", Length = "0x16")]
	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001346")]
	public override void Dispose() { }

	[Address(RVA = "0x172BCD0", Offset = "0x172AED0", Length = "0x113")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Socket), Member = "InternalShutdown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketShutdown)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181716A30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001345")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x172BDF0", Offset = "0x172AFF0", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Socket), Member = "EndConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncResult)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001341")]
	public void EndConnect(IAsyncResult asyncResult) { }

	[Address(RVA = "0x12D1B30", Offset = "0x12D0D30", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001347")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x600133B")]
	public Socket get_Client() { }

	[Address(RVA = "0x172C230", Offset = "0x172B430", Length = "0x1B")]
	[CalledBy(Type = "Mirror.SimpleWeb.ReceiveLoop", Member = "Loop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.SimpleWeb.ReceiveLoop+Config"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.SendLoop", Member = "Loop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.SimpleWeb.SendLoop+Config"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Telepathy.ThreadFunctions", Member = "SendLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TcpClient), "Telepathy.MagnificentSendPipe", typeof(ManualResetEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600133D")]
	public bool get_Connected() { }

	[Address(RVA = "0x172BE40", Offset = "0x172B040", Length = "0x165")]
	[CalledBy(Type = typeof(NetworkStreamWrapper), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TcpClient)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.ClientSslHelper", Member = "TryCreateStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.SimpleWeb.Connection", typeof(Uri)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Mirror.SimpleWeb.ServerSslHelper", Member = "TryCreateStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.SimpleWeb.Connection"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Telepathy.Server", Member = "Stop", ReturnType = typeof(void))]
	[CalledBy(Type = "Telepathy.ThreadFunctions", Member = "ReceiveLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TcpClient), typeof(int), "Telepathy.MagnificentReceivePipe", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Telepathy.ThreadFunctions", Member = "SendLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TcpClient), "Telepathy.MagnificentSendPipe", typeof(ManualResetEvent)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NetworkStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Socket), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6001343")]
	public NetworkStream GetStream() { }

	[Address(RVA = "0x172C250", Offset = "0x172B450", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Socket), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AddressFamily), typeof(SocketType), typeof(ProtocolType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600134B")]
	private void initialize() { }

	[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600133C")]
	public void set_Client(Socket value) { }

	[Address(RVA = "0x172C2E0", Offset = "0x172B4E0", Length = "0x34")]
	[CalledBy(Type = "Mirror.SimpleWeb.WebSocketClientStandAlone", Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.TcpConfig", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TcpClient)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.WebSocketServer", Member = "acceptLoop", ReturnType = typeof(void))]
	[CalledBy(Type = "Telepathy.Client", Member = "ReceiveThreadFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Telepathy.ClientConnectionState", typeof(string), typeof(int), typeof(int), typeof(bool), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Telepathy.Server", Member = "Listen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Socket), Member = "SetSocketOption", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketOptionLevel), typeof(SocketOptionName), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600134A")]
	public void set_NoDelay(bool value) { }

	[Address(RVA = "0x172C320", Offset = "0x172B520", Length = "0x33")]
	[CalledBy(Type = "Mirror.SimpleWeb.WebSocketClientStandAlone", Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.TcpConfig", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TcpClient)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.WebSocketServer", Member = "acceptLoop", ReturnType = typeof(void))]
	[CalledBy(Type = "Telepathy.Client", Member = "ReceiveThreadFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Telepathy.ClientConnectionState", typeof(string), typeof(int), typeof(int), typeof(bool), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Telepathy.Server", Member = "Listen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Socket), Member = "SetSocketOption", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketOptionLevel), typeof(SocketOptionName), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001348")]
	public void set_ReceiveTimeout(int value) { }

	[Address(RVA = "0x172C360", Offset = "0x172B560", Length = "0x33")]
	[CalledBy(Type = "Mirror.SimpleWeb.WebSocketClientStandAlone", Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.TcpConfig", Member = "ApplyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TcpClient)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.WebSocketServer", Member = "acceptLoop", ReturnType = typeof(void))]
	[CalledBy(Type = "Telepathy.Client", Member = "ReceiveThreadFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Telepathy.ClientConnectionState", typeof(string), typeof(int), typeof(int), typeof(bool), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Telepathy.Server", Member = "Listen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Socket), Member = "SetSocketOption", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketOptionLevel), typeof(SocketOptionName), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001349")]
	public void set_SendTimeout(int value) { }

}

