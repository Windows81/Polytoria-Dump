namespace Mirror.SimpleWeb;

[Token(Token = "0x2000007")]
public abstract class SimpleWebClient
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000011")]
	private readonly int maxMessagesPerTick; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000012")]
	protected ClientState state; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000013")]
	protected readonly int maxMessageSize; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000014")]
	protected readonly BufferPool bufferPool; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000015")]
	public readonly ConcurrentQueue<Message> receiveQueue; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000016")]
	private Action onConnect; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000017")]
	private Action onDisconnect; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000018")]
	private Action<ArraySegment`1<Byte>> onData; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000019")]
	private Action<Exception> onError; //Field offset: 0x48

	[Token(Token = "0x14000001")]
	public event Action onConnect
	{
		[Address(RVA = "0x155C060", Offset = "0x155B260", Length = "0x9E")]
		[CalledBy(Type = "Mirror.SimpleWeb.SimpleWebTransport", Member = "ClientConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000004")]
		 add { } //Length: 158
		[Address(RVA = "0x155C300", Offset = "0x155B500", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000005")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x14000003")]
	public event Action<ArraySegment`1<Byte>> onData
	{
		[Address(RVA = "0x155C100", Offset = "0x155B300", Length = "0xAC")]
		[CalledBy(Type = "Mirror.SimpleWeb.SimpleWebTransport", Member = "ClientConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000008")]
		 add { } //Length: 172
		[Address(RVA = "0x155C3A0", Offset = "0x155B5A0", Length = "0xAC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000009")]
		 remove { } //Length: 172
	}

	[Token(Token = "0x14000002")]
	public event Action onDisconnect
	{
		[Address(RVA = "0x155C1B0", Offset = "0x155B3B0", Length = "0x9E")]
		[CalledBy(Type = "Mirror.SimpleWeb.SimpleWebTransport", Member = "ClientConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000006")]
		 add { } //Length: 158
		[Address(RVA = "0x155C450", Offset = "0x155B650", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x6000007")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x14000004")]
	public event Action<Exception> onError
	{
		[Address(RVA = "0x155C250", Offset = "0x155B450", Length = "0xAC")]
		[CalledBy(Type = "Mirror.SimpleWeb.SimpleWebTransport", Member = "ClientConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600000A")]
		 add { } //Length: 172
		[Address(RVA = "0x155C4F0", Offset = "0x155B6F0", Length = "0xAC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CompilerGenerated]
		[Token(Token = "0x600000B")]
		 remove { } //Length: 172
	}

	[Token(Token = "0x17000001")]
	public ClientState ConnectionState
	{
		[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000003")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x155BF80", Offset = "0x155B180", Length = "0xE0")]
	[CalledBy(Type = typeof(SimpleWebClient), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TcpConfig)}, ReturnType = typeof(SimpleWebClient))]
	[CalledBy(Type = typeof(WebSocketClientStandAlone), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TcpConfig)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WebSocketClientWebGl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentQueue`1<Mirror.SimpleWeb.Message>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BufferPool), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000010")]
	protected SimpleWebClient(int maxMessageSize, int maxMessagesPerTick) { }

	[Address(RVA = "0x155C060", Offset = "0x155B260", Length = "0x9E")]
	[CalledBy(Type = "Mirror.SimpleWeb.SimpleWebTransport", Member = "ClientConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000004")]
	public void add_onConnect(Action value) { }

	[Address(RVA = "0x155C100", Offset = "0x155B300", Length = "0xAC")]
	[CalledBy(Type = "Mirror.SimpleWeb.SimpleWebTransport", Member = "ClientConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000008")]
	public void add_onData(Action<ArraySegment`1<Byte>> value) { }

	[Address(RVA = "0x155C1B0", Offset = "0x155B3B0", Length = "0x9E")]
	[CalledBy(Type = "Mirror.SimpleWeb.SimpleWebTransport", Member = "ClientConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000006")]
	public void add_onDisconnect(Action value) { }

	[Address(RVA = "0x155C250", Offset = "0x155B450", Length = "0xAC")]
	[CalledBy(Type = "Mirror.SimpleWeb.SimpleWebTransport", Member = "ClientConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600000A")]
	public void add_onError(Action<Exception> value) { }

	[Token(Token = "0x600000C")]
	public abstract void Connect(Uri serverAddress) { }

	[Address(RVA = "0x155BBE0", Offset = "0x155ADE0", Length = "0xF7")]
	[CalledBy(Type = "Mirror.SimpleWeb.SimpleWebTransport", Member = "ClientConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SimpleWebClient), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600000F")]
	public static SimpleWebClient Create(int maxMessageSize, int maxMessagesPerTick, TcpConfig tcpConfig) { }

	[Token(Token = "0x600000D")]
	public abstract void Disconnect() { }

	[Address(RVA = "0x369370", Offset = "0x368570", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000003")]
	public ClientState get_ConnectionState() { }

	[Address(RVA = "0x155BCE0", Offset = "0x155AEE0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SimpleWebClient), Member = "ProcessMessageQueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBehaviour)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000011")]
	public void ProcessMessageQueue() { }

	[Address(RVA = "0x155BCF0", Offset = "0x155AEF0", Length = "0x282")]
	[CalledBy(Type = "Mirror.SimpleWeb.SimpleWebTransport", Member = "ClientEarlyUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SimpleWebClient), Member = "ProcessMessageQueue", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Behaviour), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentQueue`1<Mirror.SimpleWeb.Message>), Member = "TryDequeue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Message&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArraySegment`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArrayBuffer), Member = "Release", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Concurrent.ConcurrentQueue`1<Mirror.SimpleWeb.Message>), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(Log), Member = "Warn", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000012")]
	public void ProcessMessageQueue(MonoBehaviour behaviour) { }

	[Address(RVA = "0x155C300", Offset = "0x155B500", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000005")]
	public void remove_onConnect(Action value) { }

	[Address(RVA = "0x155C3A0", Offset = "0x155B5A0", Length = "0xAC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000009")]
	public void remove_onData(Action<ArraySegment`1<Byte>> value) { }

	[Address(RVA = "0x155C450", Offset = "0x155B650", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x6000007")]
	public void remove_onDisconnect(Action value) { }

	[Address(RVA = "0x155C4F0", Offset = "0x155B6F0", Length = "0xAC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CompilerGenerated]
	[Token(Token = "0x600000B")]
	public void remove_onError(Action<Exception> value) { }

	[Token(Token = "0x600000E")]
	public abstract void Send(ArraySegment<Byte> segment) { }

}

