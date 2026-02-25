namespace Telepathy;

[Token(Token = "0x2000013")]
public class Server : Common
{
	[CompilerGenerated]
	[Token(Token = "0x2000014")]
	private sealed class <>c__DisplayClass16_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000037")]
		public int connectionId; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000038")]
		public TcpClient client; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000039")]
		public ConnectionState connection; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400003A")]
		public Thread sendThread; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400003B")]
		public Server <>4__this; //Field offset: 0x30

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600003B")]
		public <>c__DisplayClass16_0() { }

		[Address(RVA = "0x1806060", Offset = "0x1805260", Length = "0xFA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThreadFunctions), Member = "SendLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TcpClient), typeof(MagnificentSendPipe), typeof(ManualResetEvent)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x600003C")]
		internal void <Listen>b__0() { }

		[Address(RVA = "0x1806160", Offset = "0x1805360", Length = "0x112")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThreadFunctions), Member = "ReceiveLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TcpClient), typeof(int), typeof(MagnificentReceivePipe), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x600003D")]
		internal void <Listen>b__1() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000015")]
	private sealed class <>c__DisplayClass17_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400003C")]
		public Server <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400003D")]
		public int port; //Field offset: 0x18

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600003E")]
		public <>c__DisplayClass17_0() { }

		[Address(RVA = "0x1806280", Offset = "0x1805480", Length = "0x24")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Server), Member = "Listen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600003F")]
		internal void <Start>b__0() { }

	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400002D")]
	public Action<Int32, String> OnConnected; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400002E")]
	public Action<Int32, ArraySegment`1<Byte>> OnData; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400002F")]
	public Action<Int32> OnDisconnected; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000030")]
	public TcpListener listener; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000031")]
	private Thread listenerThread; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000032")]
	public int SendQueueLimit; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000033")]
	public int ReceiveQueueLimit; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000034")]
	protected MagnificentReceivePipe receivePipe; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000035")]
	private readonly ConcurrentDictionary<Int32, ConnectionState> clients; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000036")]
	private int counter; //Field offset: 0x60

	[Token(Token = "0x1700000A")]
	public bool Active
	{
		[Address(RVA = "0x1805530", Offset = "0x1804730", Length = "0x15")]
		[CalledBy(Type = "Mirror.TelepathyTransport", Member = "ServerActive", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Thread), Member = "get_IsAlive", ReturnType = typeof(bool))]
		[Token(Token = "0x6000032")]
		 get { } //Length: 21
	}

	[Token(Token = "0x17000009")]
	public int ReceivePipeTotalCount
	{
		[Address(RVA = "0x1805550", Offset = "0x1804750", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MagnificentReceivePipe), Member = "get_TotalCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000030")]
		 get { } //Length: 29
	}

	[Address(RVA = "0x1805490", Offset = "0x1804690", Length = "0xA0")]
	[CalledBy(Type = "Mirror.TelepathyTransport", Member = "ServerStart", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000033")]
	public Server(int MaxMessageSize) { }

	[Address(RVA = "0x18041A0", Offset = "0x18033A0", Length = "0xFA")]
	[CalledBy(Type = "Mirror.TelepathyTransport", Member = "ServerDisconnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TcpClient), Member = "Close", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000039")]
	public bool Disconnect(int connectionId) { }

	[Address(RVA = "0x1805530", Offset = "0x1804730", Length = "0x15")]
	[CalledBy(Type = "Mirror.TelepathyTransport", Member = "ServerActive", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Thread), Member = "get_IsAlive", ReturnType = typeof(bool))]
	[Token(Token = "0x6000032")]
	public bool get_Active() { }

	[Address(RVA = "0x1805550", Offset = "0x1804750", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MagnificentReceivePipe), Member = "get_TotalCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000030")]
	public int get_ReceivePipeTotalCount() { }

	[Address(RVA = "0x18042A0", Offset = "0x18034A0", Length = "0x16C")]
	[CalledBy(Type = "Mirror.TelepathyTransport", Member = "ServerGetClientAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Server), Member = "Tick", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Func`1<System.Boolean>)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Socket), Member = "get_RemoteEndPoint", ReturnType = typeof(EndPoint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000038")]
	public string GetClientAddress(int connectionId) { }

	[Address(RVA = "0x1804410", Offset = "0x1803610", Length = "0x5AC")]
	[CalledBy(Type = typeof(<>c__DisplayClass17_0), Member = "<Start>b__0", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TcpClient), Member = "set_NoDelay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(Thread), Member = "Start", ReturnType = typeof(void))]
	[Calls(Type = typeof(Thread), Member = "set_IsBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Thread), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ThreadStart)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ConnectionState), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TcpClient), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TcpClient), Member = "set_ReceiveTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TcpClient), Member = "set_SendTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TcpListener), Member = "AcceptTcpClient", ReturnType = typeof(TcpClient))]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TcpListener), Member = "Start", ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "set_NoDelay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TcpListener), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TcpListener))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6000034")]
	private void Listen(int port) { }

	[Address(RVA = "0x18049C0", Offset = "0x1803BC0", Length = "0x9B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Interlocked), Member = "Increment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000031")]
	public int NextConnectionId() { }

	[Address(RVA = "0x1804A60", Offset = "0x1803C60", Length = "0x2B3")]
	[CalledBy(Type = "Mirror.TelepathyTransport", Member = "ServerSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.ArraySegment`1<Byte>", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(MagnificentSendPipe), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TcpClient), Member = "Close", ReturnType = typeof(void))]
	[Calls(Type = typeof(MagnificentSendPipe), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000037")]
	public bool Send(int connectionId, ArraySegment<Byte> message) { }

	[Address(RVA = "0x1804D20", Offset = "0x1803F20", Length = "0x205")]
	[CalledBy(Type = "Mirror.TelepathyTransport", Member = "ServerStart", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MagnificentReceivePipe), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Thread), Member = "get_IsAlive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Thread), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ThreadStart)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Thread), Member = "set_IsBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Thread), Member = "Start", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000035")]
	public bool Start(int port) { }

	[Address(RVA = "0x1804F30", Offset = "0x1804130", Length = "0x361")]
	[CalledBy(Type = "Mirror.TelepathyTransport", Member = "ServerStop", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.TelepathyTransport", Member = "Shutdown", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180739630")]
	[Calls(Type = typeof(TcpClient), Member = "Close", ReturnType = typeof(void))]
	[Calls(Type = typeof(TcpClient), Member = "GetStream", ReturnType = typeof(NetworkStream))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(TcpListener), Member = "Stop", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Thread), Member = "get_IsAlive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<KeyValuePair`2<TKey, TValue>>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000036")]
	public void Stop() { }

	[Address(RVA = "0x18052A0", Offset = "0x18044A0", Length = "0x1E2")]
	[CalledBy(Type = "Mirror.TelepathyTransport", Member = "ServerEarlyUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MagnificentReceivePipe), Member = "TryPeek", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(EventType&), typeof(ArraySegment`1<Byte>&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ConcurrentDictionary`2), Member = "TryRemove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Server), Member = "GetClientAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(MagnificentReceivePipe), Member = "TryDequeue", ReturnType = typeof(bool))]
	[Calls(Type = typeof(MagnificentReceivePipe), Member = "get_TotalCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x600003A")]
	public int Tick(int processLimit, Func<Boolean> checkEnabled = null) { }

}

