namespace Mirror.Discovery;

[DisallowMultipleComponent]
[HelpURL("https://mirror-networking.gitbook.io/docs/components/network-discovery")]
[Token(Token = "0x2000056")]
public abstract class NetworkDiscoveryBase : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x2000057")]
	private struct <ClientListenAsync>d__30 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000206")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000207")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000208")]
		public NetworkDiscoveryBase<Request, Response> <>4__this; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000209")]
		private TaskAwaiter <>u__1; //Field offset: 0x0

		[Address(RVA = "0x7F4A60", Offset = "0x7F3C60", Length = "0x2B2")]
		[CalledBy(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TStateMachine&"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(NetworkDiscoveryBase`2), Member = "ReceiveGameBroadcastAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UdpClient)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x600031C")]
		private override void MoveNext() { }

		[Address(RVA = "0x7F5020", Offset = "0x7F4220", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x600031D")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000058")]
	private struct <ReceiveGameBroadcastAsync>d__33 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400020A")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400020B")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400020C")]
		public UdpClient udpClient; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400020D")]
		public NetworkDiscoveryBase<Request, Response> <>4__this; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400020E")]
		private TaskAwaiter<UdpReceiveResult> <>u__1; //Field offset: 0x0

		[Address(RVA = "0x813950", Offset = "0x812B50", Length = "0x387")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(NetworkReader), Member = "Read", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadLong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(long))]
		[Calls(Type = typeof(NetworkReaderPool), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(NetworkReaderPooled))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(UdpClient), Member = "ReceiveAsync", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Net.Sockets.UdpReceiveResult>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600031E")]
		private override void MoveNext() { }

		[Address(RVA = "0x8141A0", Offset = "0x8133A0", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x600031F")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000059")]
	private struct <ReceiveRequestAsync>d__23 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400020F")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000210")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000211")]
		public UdpClient udpClient; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000212")]
		public NetworkDiscoveryBase<Request, Response> <>4__this; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000213")]
		private TaskAwaiter<UdpReceiveResult> <>u__1; //Field offset: 0x0

		[Address(RVA = "0x814730", Offset = "0x813930", Length = "0x37D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NetworkReader), Member = "Read", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadLong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(long))]
		[Calls(Type = typeof(NetworkReaderPool), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(NetworkReaderPooled))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Task`1), Member = "GetAwaiter", ReturnType = "System.Runtime.CompilerServices.TaskAwaiter`1<TResult>")]
		[Calls(Type = typeof(UdpClient), Member = "ReceiveAsync", ReturnType = typeof(System.Threading.Tasks.Task`1<System.Net.Sockets.UdpReceiveResult>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000320")]
		private override void MoveNext() { }

		[Address(RVA = "0x814B10", Offset = "0x813D10", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000321")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200005A")]
	private struct <ServerListenAsync>d__22 : IAsyncStateMachine
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000214")]
		public int <>1__state; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000215")]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000216")]
		public NetworkDiscoveryBase<Request, Response> <>4__this; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000217")]
		private TaskAwaiter <>u__1; //Field offset: 0x0

		[Address(RVA = "0x818BB0", Offset = "0x817DB0", Length = "0x292")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(NetworkDiscoveryBase`2), Member = "ReceiveRequestAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UdpClient)}, ReturnType = typeof(Task))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter", "TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TAwaiter&", "TStateMachine&"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000322")]
		private override void MoveNext() { }

		[Address(RVA = "0x818EB0", Offset = "0x8180B0", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAsyncStateMachine)}, ReturnType = typeof(void))]
		[DebuggerHidden]
		[DeduplicatedMethod]
		[Token(Token = "0x6000323")]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x40001FC")]
	[Tooltip("If true, broadcasts a discovery request every ActiveDiscoveryInterval seconds")]
	public bool enableActiveDiscovery; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001FD")]
	[Tooltip("iOS may require LAN IP address here (e.g. 192.168.x.x), otherwise leave blank.")]
	public string BroadcastAddress; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x40001FE")]
	[Tooltip("The UDP port the server will listen for multi-cast messages")]
	protected int serverBroadcastListenPort; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Range(1, 60)]
	[SerializeField]
	[Token(Token = "0x40001FF")]
	[Tooltip("Time in seconds between multi-cast messages")]
	private float ActiveDiscoveryInterval; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000200")]
	[Tooltip("Transport to be advertised during discovery")]
	public Transport transport; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000201")]
	[Tooltip("Invoked when a server is found")]
	public ServerFoundUnityEvent<Response> OnServerFound; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[HideInInspector]
	[Token(Token = "0x4000202")]
	public long secretHandshake; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000203")]
	private long <ServerId>k__BackingField; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000204")]
	protected UdpClient serverUdpClient; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000205")]
	protected UdpClient clientUdpClient; //Field offset: 0x0

	[Token(Token = "0x1700003A")]
	public private long ServerId
	{
		[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
		[CallerCount(Count = 8)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000305")]
		 get { } //Length: 5
		[Address(RVA = "0xE282D0", Offset = "0xE274D0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000306")]
		private set { } //Length: 5
	}

	[Token(Token = "0x17000039")]
	public static bool SupportedOnThisPlatform
	{
		[Address(RVA = "0xE28230", Offset = "0xE27430", Length = "0x47")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000304")]
		 get { } //Length: 71
	}

	[Address(RVA = "0xE28150", Offset = "0xE27350", Length = "0x61")]
	[CalledBy(Type = typeof(NetworkDiscovery), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600031B")]
	protected NetworkDiscoveryBase`2() { }

	[Address(RVA = "0xE26050", Offset = "0xE25250", Length = "0x216")]
	[CalledBy(Type = typeof(NetworkDiscoveryBase`2), Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkDiscoveryHUD), Member = "DrawGUI", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.Discovery.NetworkDiscoveryBase`2<ServerRequest, ServerResponse>+<ServerListenAsync>d__22<ServerRequest, ServerResponse>"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ServerListenAsync>d__22<ServerRequest, ServerResponse>&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UdpClient), Member = "set_MulticastLoopback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UdpClient), Member = "set_EnableBroadcast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UdpClient), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkDiscoveryBase`2), Member = "Shutdown", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600030D")]
	public void AdvertiseServer() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000312")]
	private void BeginMulticastLock() { }

	[Address(RVA = "0xE26270", Offset = "0xE25470", Length = "0x386")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(UdpClient), Member = "SendAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(IPEndPoint)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Int32>))]
	[Calls(Type = typeof(ArraySegment`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriter), Member = "Write", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteLong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(string), Member = "IsNullOrWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(IPEndPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NetworkClient), Member = "get_isConnected", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(IPAddress), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IPAddress))]
	[Calls(Type = typeof(NetworkDiscoveryBase`2), Member = "Shutdown", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000317")]
	public void BroadcastDiscoveryRequest() { }

	[Address(RVA = "0xE26A80", Offset = "0xE25C80", Length = "0xD3")]
	[AsyncStateMachine(typeof(<ClientListenAsync>d__30))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TStateMachine&"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000316")]
	public Task ClientListenAsync() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000313")]
	private void EndpMulticastLock() { }

	[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
	[CallerCount(Count = 8)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000305")]
	public long get_ServerId() { }

	[Address(RVA = "0xE28230", Offset = "0xE27430", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000304")]
	public static bool get_SupportedOnThisPlatform() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000318")]
	protected override Request GetRequest() { }

	[Address(RVA = "0xE26D30", Offset = "0xE25F30", Length = "0x14")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NetworkDiscoveryBase`2), Member = "Shutdown", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000309")]
	private void OnApplicationQuit() { }

	[Address(RVA = "0xE26D30", Offset = "0xE25F30", Length = "0x14")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NetworkDiscoveryBase`2), Member = "Shutdown", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600030B")]
	private void OnDestroy() { }

	[Address(RVA = "0xE26D30", Offset = "0xE25F30", Length = "0x14")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NetworkDiscoveryBase`2), Member = "Shutdown", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600030A")]
	private void OnDisable() { }

	[Address(RVA = "0xE27160", Offset = "0xE26360", Length = "0x28C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkWriter), Member = "Write", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteLong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(ArraySegment`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UdpClient), Member = "Send", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(IPEndPoint)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Debug), Member = "LogException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(Object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000310")]
	protected override void ProcessClientRequest(Request request, IPEndPoint endpoint) { }

	[Token(Token = "0x6000311")]
	protected abstract Response ProcessRequest(Request request, IPEndPoint endpoint) { }

	[Token(Token = "0x600031A")]
	protected abstract void ProcessResponse(Response response, IPEndPoint endpoint) { }

	[Address(RVA = "0xE273F0", Offset = "0xE265F0", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000308")]
	public static long RandomLong() { }

	[Address(RVA = "0xE27530", Offset = "0xE26730", Length = "0xF7")]
	[AsyncStateMachine(typeof(<ReceiveGameBroadcastAsync>d__33))]
	[CalledBy(Type = typeof(<ClientListenAsync>d__30), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.Discovery.NetworkDiscoveryBase`2<ServerRequest, ServerResponse>+<ReceiveGameBroadcastAsync>d__33<ServerRequest, ServerResponse>"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReceiveGameBroadcastAsync>d__33<ServerRequest, ServerResponse>&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000319")]
	private Task ReceiveGameBroadcastAsync(UdpClient udpClient) { }

	[Address(RVA = "0xE27630", Offset = "0xE26830", Length = "0xF4")]
	[AsyncStateMachine(typeof(<ReceiveRequestAsync>d__23))]
	[CalledBy(Type = typeof(<ServerListenAsync>d__22), Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.Discovery.NetworkDiscoveryBase`2<ServerRequest, ServerResponse>+<ReceiveRequestAsync>d__23<ServerRequest, ServerResponse>"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ReceiveRequestAsync>d__23<ServerRequest, ServerResponse>&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600030F")]
	private Task ReceiveRequestAsync(UdpClient udpClient) { }

	[Address(RVA = "0xE27900", Offset = "0xE26B00", Length = "0xD0")]
	[AsyncStateMachine(typeof(<ServerListenAsync>d__22))]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.Discovery.NetworkDiscoveryBase`2<ServerRequest, ServerResponse>+<ServerListenAsync>d__22<ServerRequest, ServerResponse>"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<ServerListenAsync>d__22<ServerRequest, ServerResponse>&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600030E")]
	public Task ServerListenAsync() { }

	[Address(RVA = "0xE282D0", Offset = "0xE274D0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000306")]
	private void set_ServerId(long value) { }

	[Address(RVA = "0xE279D0", Offset = "0xE26BD0", Length = "0x8B")]
	[CalledBy(Type = typeof(NetworkDiscoveryBase`2), Member = "OnApplicationQuit", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkDiscoveryBase`2), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkDiscoveryBase`2), Member = "OnDestroy", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkDiscoveryBase`2), Member = "AdvertiseServer", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkDiscoveryBase`2), Member = "StartDiscovery", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkDiscoveryBase`2), Member = "StopDiscovery", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkDiscoveryBase`2), Member = "BroadcastDiscoveryRequest", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x600030C")]
	private void Shutdown() { }

	[Address(RVA = "0xE28060", Offset = "0xE27260", Length = "0xEC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Utils), Member = "IsHeadless", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NetworkDiscoveryBase`2), Member = "AdvertiseServer", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000307")]
	public override void Start() { }

	[Address(RVA = "0xE27B10", Offset = "0xE26D10", Length = "0x28E")]
	[CalledBy(Type = typeof(NetworkDiscoveryHUD), Member = "DrawGUI", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UdpClient), Member = "set_MulticastLoopback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(MonoBehaviour), Member = "InvokeRepeating", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
	[Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Start", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TStateMachine"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TStateMachine&"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UdpClient), Member = "set_EnableBroadcast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002050")]
	[Calls(Type = typeof(UdpClient), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NetworkDiscoveryBase`2), Member = "Shutdown", ReturnType = typeof(void))]
	[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800E16B0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000314")]
	public void StartDiscovery() { }

	[Address(RVA = "0xE26D30", Offset = "0xE25F30", Length = "0x14")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NetworkDiscoveryBase`2), Member = "Shutdown", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000315")]
	public void StopDiscovery() { }

}

