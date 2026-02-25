namespace Mirror;

[Token(Token = "0x2000011")]
public abstract class ThreadedTransport : Transport
{
	[Token(Token = "0x4000086")]
	private const int MaxProcessingPerTick = 10000000; //Field offset: 0x0
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000080")]
	private WorkerThread thread; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000081")]
	private readonly ConcurrentQueue<ClientMainEvent> clientMainQueue; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000082")]
	private readonly ConcurrentQueue<ServerMainEvent> serverMainQueue; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000083")]
	private readonly ConcurrentQueue<ThreadEvent> threadQueue; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000084")]
	private bool serverActive; //Field offset: 0xA8
	[FieldOffset(Offset = "0xA9")]
	[Token(Token = "0x4000085")]
	private bool clientConnected; //Field offset: 0xA9
	[FieldOffset(Offset = "0xAA")]
	[Token(Token = "0x4000087")]
	[Tooltip("Detect device sleep mode and automatically disconnect + hibernate the thread after 'sleepTimeout' seconds.\nFor example: on mobile / VR, we don't want to drain the battery after putting down the device.")]
	public bool sleepDetection; //Field offset: 0xAA
	[FieldOffset(Offset = "0xAC")]
	[Token(Token = "0x4000088")]
	public float sleepTimeoutInSeconds; //Field offset: 0xAC
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000089")]
	private Stopwatch sleepTimer; //Field offset: 0xB0

	[Address(RVA = "0x12848A0", Offset = "0x1283AA0", Length = "0x126")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ConcurrentQueue`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentQueue`1<Mirror.ServerMainEvent>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentQueue`1<Mirror.ThreadEvent>), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000CB")]
	protected ThreadedTransport() { }

	[Address(RVA = "0x12824F0", Offset = "0x12816F0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThreadedTransport), Member = "EnsureThread", ReturnType = typeof(void))]
	[Token(Token = "0x600009F")]
	protected override void Awake() { }

	[Address(RVA = "0x1282500", Offset = "0x1281700", Length = "0xBD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThreadedTransport), Member = "EnsureThread", ReturnType = typeof(void))]
	[Calls(Type = typeof(ThreadedTransport), Member = "EnqueueThread", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ThreadEventType), typeof(object), typeof(System.Nullable`1<System.Int32>), typeof(System.Nullable`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000BE")]
	public virtual void ClientConnect(Uri uri) { }

	[Address(RVA = "0x12825C0", Offset = "0x12817C0", Length = "0xBD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThreadedTransport), Member = "EnsureThread", ReturnType = typeof(void))]
	[Calls(Type = typeof(ThreadedTransport), Member = "EnqueueThread", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ThreadEventType), typeof(object), typeof(System.Nullable`1<System.Int32>), typeof(System.Nullable`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000BD")]
	public virtual void ClientConnect(string address) { }

	[Address(RVA = "0x1282680", Offset = "0x1281880", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Token(Token = "0x60000BC")]
	public virtual bool ClientConnected() { }

	[Address(RVA = "0x12826A0", Offset = "0x12818A0", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThreadedTransport), Member = "EnqueueThread", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ThreadEventType), typeof(object), typeof(System.Nullable`1<System.Int32>), typeof(System.Nullable`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Token(Token = "0x60000C0")]
	public virtual void ClientDisconnect() { }

	[Address(RVA = "0x12826E0", Offset = "0x12818E0", Length = "0x43A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ConcurrentQueue`1), Member = "TryDequeue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(ArraySegment`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18126FE10")]
	[Calls(Type = typeof(ConcurrentBag`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x60000BB")]
	public virtual void ClientEarlyUpdate() { }

	[Address(RVA = "0x1282B20", Offset = "0x1281D20", Length = "0x134")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ConcurrentNetworkWriterPool), Member = "Get", ReturnType = typeof(ConcurrentNetworkWriterPooled))]
	[Calls(Type = typeof(NetworkWriter), Member = "WriteBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThreadedTransport), Member = "EnqueueThread", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ThreadEventType), typeof(object), typeof(System.Nullable`1<System.Int32>), typeof(System.Nullable`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000BF")]
	public virtual void ClientSend(ArraySegment<Byte> segment, int channelId = 0) { }

	[Address(RVA = "0x1282C60", Offset = "0x1281E60", Length = "0xC3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ConcurrentQueue`1), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600009C")]
	private void EnqueueClientMain(ClientMainEventType type, object param, Nullable<Int32> channelId, Nullable<TransportError> error) { }

	[Address(RVA = "0x1282D30", Offset = "0x1281F30", Length = "0xE0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentQueue`1<Mirror.ServerMainEvent>), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ServerMainEvent)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600009D")]
	private void EnqueueServerMain(ServerMainEventType type, object param, Nullable<Int32> connectionId, Nullable<Int32> channelId, Nullable<TransportError> error) { }

	[Address(RVA = "0x1282E20", Offset = "0x1282020", Length = "0xBC")]
	[CalledBy(Type = typeof(ThreadedTransport), Member = "ServerDisconnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadedTransport), Member = "ClientConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadedTransport), Member = "ClientConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadedTransport), Member = "ClientSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadedTransport), Member = "ClientDisconnect", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadedTransport), Member = "ServerStart", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadedTransport), Member = "ServerSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadedTransport), Member = "ServerStop", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadedTransport), Member = "OnApplicationPause", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadedTransport), Member = "Shutdown", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentQueue`1<Mirror.ThreadEvent>), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ThreadEvent)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600009E")]
	private void EnqueueThread(ThreadEventType type, object param, Nullable<Int32> channelId, Nullable<Int32> connectionId) { }

	[Address(RVA = "0x1282EE0", Offset = "0x12820E0", Length = "0x1A9")]
	[CalledBy(Type = typeof(ThreadedKcpTransport), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadedTransport), Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadedTransport), Member = "ClientConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadedTransport), Member = "ClientConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadedTransport), Member = "ServerStart", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(WorkerThread), Member = "get_IsAlive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(WorkerThread), Member = "Start", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WorkerThread), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000A0")]
	private void EnsureThread() { }

	[Address(RVA = "0x1283090", Offset = "0x1282290", Length = "0xD7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThreadedTransport), Member = "EnqueueThread", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ThreadEventType), typeof(object), typeof(System.Nullable`1<System.Int32>), typeof(System.Nullable`1<System.Int32>)}, ReturnType = typeof(void))]
	[Token(Token = "0x60000C9")]
	private void OnApplicationPause(bool pauseStatus) { }

	[Address(RVA = "0x1283170", Offset = "0x1282370", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000A1")]
	protected override void OnDestroy() { }

	[Address(RVA = "0x1281310", Offset = "0x1280510", Length = "0x21")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18126FEB0")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000A4")]
	protected void OnThreadedClientConnected() { }

	[Address(RVA = "0x1283190", Offset = "0x1282390", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18126FEB0")]
	[Token(Token = "0x60000A8")]
	protected void OnThreadedClientDisconnected() { }

	[Address(RVA = "0x12831C0", Offset = "0x12823C0", Length = "0x8C")]
	[CalledBy(Type = typeof(ThreadedKcpTransport), Member = "<Awake>b__27_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ErrorCode), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadedEncryptionKcpTransport), Member = "SetupEncryptionForClient", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ThreadedEncryptionKcpTransport), Member = "<HandleInnerClientConnected>b__26_3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransportError), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadedEncryptionKcpTransport), Member = "<Awake>b__28_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ErrorCode), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18126FEB0")]
	[Token(Token = "0x60000A7")]
	protected void OnThreadedClientError(TransportError error, string reason) { }

	[Address(RVA = "0x1283250", Offset = "0x1282450", Length = "0x115")]
	[CalledBy(Type = typeof(ThreadedKcpTransport), Member = "<Awake>b__27_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(KcpChannel)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadedEncryptionKcpTransport), Member = "<HandleInnerClientConnected>b__26_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ConcurrentNetworkWriterPool), Member = "Get", ReturnType = typeof(ConcurrentNetworkWriterPooled))]
	[Calls(Type = typeof(NetworkWriter), Member = "WriteBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18126FEB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000A6")]
	protected void OnThreadedClientReceive(ArraySegment<Byte> message, int channelId) { }

	[Address(RVA = "0x1283370", Offset = "0x1282570", Length = "0x115")]
	[CalledBy(Type = typeof(ThreadedKcpTransport), Member = "ThreadedClientSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadedEncryptionKcpTransport), Member = "<HandleInnerClientConnected>b__26_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ConcurrentNetworkWriterPool), Member = "Get", ReturnType = typeof(ConcurrentNetworkWriterPooled))]
	[Calls(Type = typeof(NetworkWriter), Member = "WriteBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18126FEB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000A5")]
	protected void OnThreadedClientSend(ArraySegment<Byte> message, int channelId) { }

	[Address(RVA = "0x1283490", Offset = "0x1282690", Length = "0x95")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Extensions), Member = "PrettyAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPEndPoint)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18126FF80")]
	[Token(Token = "0x60000A9")]
	protected void OnThreadedServerConnected(int connectionId, IPEndPoint endPoint) { }

	[Address(RVA = "0x1283530", Offset = "0x1282730", Length = "0x7E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18126FF80")]
	[Token(Token = "0x60000AD")]
	protected void OnThreadedServerDisconnected(int connectionId) { }

	[Address(RVA = "0x12835B0", Offset = "0x12827B0", Length = "0xB6")]
	[CalledBy(Type = typeof(ThreadedKcpTransport), Member = "<Awake>b__27_4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ErrorCode), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Transports.Encryption.ThreadedEncryptionKcpTransport+<>c__DisplayClass23_0", Member = "<HandleInnerServerConnected>b__3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TransportError), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ThreadedEncryptionKcpTransport), Member = "<Awake>b__28_3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ErrorCode), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18126FF80")]
	[Token(Token = "0x60000AC")]
	protected void OnThreadedServerError(int connectionId, TransportError error, string reason) { }

	[Address(RVA = "0x1283670", Offset = "0x1282870", Length = "0x155")]
	[CalledBy(Type = typeof(ThreadedKcpTransport), Member = "<Awake>b__27_3", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ArraySegment`1<System.Byte>), typeof(KcpChannel)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Transports.Encryption.ThreadedEncryptionKcpTransport+<>c__DisplayClass23_0", Member = "<HandleInnerServerConnected>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ConcurrentNetworkWriterPool), Member = "Get", ReturnType = typeof(ConcurrentNetworkWriterPooled))]
	[Calls(Type = typeof(NetworkWriter), Member = "WriteBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18126FF80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000AB")]
	protected void OnThreadedServerReceive(int connectionId, ArraySegment<Byte> message, int channelId) { }

	[Address(RVA = "0x12837D0", Offset = "0x12829D0", Length = "0x155")]
	[CalledBy(Type = typeof(ThreadedKcpTransport), Member = "ThreadedServerSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Transports.Encryption.ThreadedEncryptionKcpTransport+<>c__DisplayClass23_0", Member = "<HandleInnerServerConnected>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ConcurrentNetworkWriterPool), Member = "Get", ReturnType = typeof(ConcurrentNetworkWriterPooled))]
	[Calls(Type = typeof(NetworkWriter), Member = "WriteBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18126FF80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000AA")]
	protected void OnThreadedServerSend(int connectionId, ArraySegment<Byte> message, int channelId) { }

	[Address(RVA = "0x1283930", Offset = "0x1282B30", Length = "0x10C")]
	[CalledBy(Type = typeof(ThreadedTransport), Member = "ThreadTick", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentQueue`1<Mirror.ThreadEvent>), Member = "TryDequeue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ThreadEvent&)}, ReturnType = typeof(bool))]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60000A2")]
	private void ProcessThreadQueue() { }

	[Address(RVA = "0x1283E50", Offset = "0x1283050", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Token(Token = "0x60000C3")]
	public virtual bool ServerActive() { }

	[Address(RVA = "0x1283E70", Offset = "0x1283070", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThreadedTransport), Member = "EnqueueThread", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ThreadEventType), typeof(object), typeof(System.Nullable`1<System.Int32>), typeof(System.Nullable`1<System.Int32>)}, ReturnType = typeof(void))]
	[Token(Token = "0x60000C6")]
	public virtual void ServerDisconnect(int connectionId) { }

	[Address(RVA = "0x1283EF0", Offset = "0x12830F0", Length = "0x49A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentQueue`1<Mirror.ServerMainEvent>), Member = "TryDequeue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ServerMainEvent&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(ArraySegment`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ConcurrentBag`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x60000C1")]
	public virtual void ServerEarlyUpdate() { }

	[Address(RVA = "0x1284390", Offset = "0x1283590", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60000C7")]
	public virtual string ServerGetClientAddress(int connectionId) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000C2")]
	public virtual void ServerLateUpdate() { }

	[Address(RVA = "0x12843E0", Offset = "0x12835E0", Length = "0x163")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ConcurrentNetworkWriterPool), Member = "Get", ReturnType = typeof(ConcurrentNetworkWriterPooled))]
	[Calls(Type = typeof(NetworkWriter), Member = "WriteBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThreadedTransport), Member = "EnqueueThread", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ThreadEventType), typeof(object), typeof(System.Nullable`1<System.Int32>), typeof(System.Nullable`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000C5")]
	public virtual void ServerSend(int connectionId, ArraySegment<Byte> segment, int channelId = 0) { }

	[Address(RVA = "0x1284550", Offset = "0x1283750", Length = "0xA9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThreadedTransport), Member = "EnsureThread", ReturnType = typeof(void))]
	[Calls(Type = typeof(ThreadedTransport), Member = "EnqueueThread", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ThreadEventType), typeof(object), typeof(System.Nullable`1<System.Int32>), typeof(System.Nullable`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000C4")]
	public virtual void ServerStart() { }

	[Address(RVA = "0x1284600", Offset = "0x1283800", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThreadedTransport), Member = "EnqueueThread", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ThreadEventType), typeof(object), typeof(System.Nullable`1<System.Int32>), typeof(System.Nullable`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Token(Token = "0x60000C8")]
	public virtual void ServerStop() { }

	[Address(RVA = "0x1284640", Offset = "0x1283840", Length = "0xD4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThreadedTransport), Member = "EnqueueThread", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ThreadEventType), typeof(object), typeof(System.Nullable`1<System.Int32>), typeof(System.Nullable`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Thread), Member = "Sleep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WorkerThread), Member = "StopBlocking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ConcurrentQueue`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentQueue`1<Mirror.ServerMainEvent>), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentQueue`1<Mirror.ThreadEvent>), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000CA")]
	public virtual void Shutdown() { }

	[Token(Token = "0x60000AF")]
	protected abstract void ThreadedClientConnect(Uri address) { }

	[Token(Token = "0x60000AE")]
	protected abstract void ThreadedClientConnect(string address) { }

	[Token(Token = "0x60000B1")]
	protected abstract void ThreadedClientDisconnect() { }

	[Token(Token = "0x60000B6")]
	protected abstract void ThreadedClientEarlyUpdate() { }

	[Token(Token = "0x60000B7")]
	protected abstract void ThreadedClientLateUpdate() { }

	[Token(Token = "0x60000B0")]
	protected abstract void ThreadedClientSend(ArraySegment<Byte> message, int channelId) { }

	[Token(Token = "0x60000B5")]
	protected abstract void ThreadedServerDisconnect(int connectionId) { }

	[Token(Token = "0x60000B8")]
	protected abstract void ThreadedServerEarlyUpdate() { }

	[Token(Token = "0x60000B9")]
	protected abstract void ThreadedServerLateUpdate() { }

	[Token(Token = "0x60000B4")]
	protected abstract void ThreadedServerSend(int connectionId, ArraySegment<Byte> message, int channelId) { }

	[Token(Token = "0x60000B2")]
	protected abstract void ThreadedServerStart() { }

	[Token(Token = "0x60000B3")]
	protected abstract void ThreadedServerStop() { }

	[Token(Token = "0x60000BA")]
	protected abstract void ThreadedShutdown() { }

	[Address(RVA = "0x1284720", Offset = "0x1283920", Length = "0x17F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Stopwatch), Member = "get_Elapsed", ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TimeSpan), Member = "get_TotalSeconds", ReturnType = typeof(double))]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ThreadedTransport), Member = "ProcessThreadQueue", ReturnType = typeof(void))]
	[Calls(Type = typeof(Thread), Member = "Sleep", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000A3")]
	private bool ThreadTick() { }

}

