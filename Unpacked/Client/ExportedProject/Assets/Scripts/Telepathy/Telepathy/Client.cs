namespace Telepathy;

[Token(Token = "0x2000005")]
public class Client : Common
{
	[CompilerGenerated]
	[Token(Token = "0x2000006")]
	private sealed class <>c__DisplayClass13_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400000F")]
		public ClientConnectionState state; //Field offset: 0x10

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600000F")]
		public <>c__DisplayClass13_0() { }

		[Address(RVA = "0x1805FC0", Offset = "0x18051C0", Length = "0x33")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ThreadFunctions), Member = "SendLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TcpClient), typeof(MagnificentSendPipe), typeof(ManualResetEvent)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000010")]
		internal void <ReceiveThreadFunction>b__0() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000007")]
	private sealed class <>c__DisplayClass14_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000010")]
		public Client <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000011")]
		public string ip; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000012")]
		public int port; //Field offset: 0x20

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000011")]
		public <>c__DisplayClass14_0() { }

		[Address(RVA = "0x1806000", Offset = "0x1805200", Length = "0x56")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Client), Member = "ReceiveThreadFunction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClientConnectionState), typeof(string), typeof(int), typeof(int), typeof(bool), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000012")]
		internal void <Connect>b__0() { }

	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000009")]
	public Action OnConnected; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400000A")]
	public Action<ArraySegment`1<Byte>> OnData; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400000B")]
	public Action OnDisconnected; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400000C")]
	public int SendQueueLimit; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400000D")]
	public int ReceiveQueueLimit; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400000E")]
	private ClientConnectionState state; //Field offset: 0x40

	[Token(Token = "0x17000002")]
	public bool Connected
	{
		[Address(RVA = "0x1802540", Offset = "0x1801740", Length = "0x29")]
		[CalledBy(Type = "Mirror.TelepathyTransport", Member = "ClientConnected", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Token(Token = "0x6000006")]
		 get { } //Length: 41
	}

	[Token(Token = "0x17000003")]
	public bool Connecting
	{
		[Address(RVA = "0x1802570", Offset = "0x1801770", Length = "0x31")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Token(Token = "0x6000007")]
		 get { } //Length: 49
	}

	[Token(Token = "0x17000004")]
	public int ReceivePipeCount
	{
		[Address(RVA = "0x18025B0", Offset = "0x18017B0", Length = "0x2F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MagnificentReceivePipe), Member = "get_TotalCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000008")]
		 get { } //Length: 47
	}

	[Address(RVA = "0x1802500", Offset = "0x1801700", Length = "0x3D")]
	[CalledBy(Type = "Mirror.TelepathyTransport", Member = "CreateClient", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000009")]
	public Client(int MaxMessageSize) { }

	[Address(RVA = "0x18017F0", Offset = "0x18009F0", Length = "0x2ED")]
	[CalledBy(Type = "Mirror.TelepathyTransport", Member = "ClientConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.TelepathyTransport", Member = "ClientConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Thread), Member = "set_IsBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Thread), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ThreadStart)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MagnificentReceivePipe), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ConnectionState), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TcpClient), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TcpClient), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(Thread), Member = "Start", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000B")]
	public void Connect(string ip, int port) { }

	[Address(RVA = "0x1801AE0", Offset = "0x1800CE0", Length = "0xB1")]
	[CalledBy(Type = "Mirror.TelepathyTransport", Member = "ClientDisconnect", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.TelepathyTransport", Member = "Shutdown", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(TcpClient), Member = "Close", ReturnType = typeof(void))]
	[Calls(Type = typeof(MagnificentSendPipe), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600000C")]
	public void Disconnect() { }

	[Address(RVA = "0x1802540", Offset = "0x1801740", Length = "0x29")]
	[CalledBy(Type = "Mirror.TelepathyTransport", Member = "ClientConnected", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x6000006")]
	public bool get_Connected() { }

	[Address(RVA = "0x1802570", Offset = "0x1801770", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Token(Token = "0x6000007")]
	public bool get_Connecting() { }

	[Address(RVA = "0x18025B0", Offset = "0x18017B0", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MagnificentReceivePipe), Member = "get_TotalCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000008")]
	public int get_ReceivePipeCount() { }

	[Address(RVA = "0x1801BA0", Offset = "0x1800DA0", Length = "0x4DF")]
	[CalledBy(Type = typeof(<>c__DisplayClass14_0), Member = "<Connect>b__0", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Thread), Member = "set_IsBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TcpClient), Member = "Close", ReturnType = typeof(void))]
	[Calls(Type = typeof(MagnificentReceivePipe), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(EventType), typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ThreadFunctions), Member = "ReceiveLoop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(TcpClient), typeof(int), typeof(MagnificentReceivePipe), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Thread), Member = "Start", ReturnType = typeof(void))]
	[Calls(Type = typeof(Thread), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ThreadStart)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(TcpClient), Member = "set_ReceiveTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TcpClient), Member = "set_SendTimeout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TcpClient), Member = "set_NoDelay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(TcpClient), Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600000A")]
	private static void ReceiveThreadFunction(ClientConnectionState state, string ip, int port, int MaxMessageSize, bool NoDelay, int SendTimeout, int ReceiveTimeout, int ReceiveQueueLimit) { }

	[Address(RVA = "0x1802080", Offset = "0x1801280", Length = "0x307")]
	[CalledBy(Type = "Mirror.TelepathyTransport", Member = "ClientSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ArraySegment`1<Byte>", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(MagnificentSendPipe), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TcpClient), Member = "Close", ReturnType = typeof(void))]
	[Calls(Type = typeof(MagnificentSendPipe), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(EventWaitHandle), Member = "Set", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600000D")]
	public bool Send(ArraySegment<Byte> message) { }

	[Address(RVA = "0x1802390", Offset = "0x1801590", Length = "0x163")]
	[CalledBy(Type = "Mirror.TelepathyTransport", Member = "ClientEarlyUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MagnificentReceivePipe), Member = "TryPeek", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(EventType&), typeof(ArraySegment`1<Byte>&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MagnificentReceivePipe), Member = "TryDequeue", ReturnType = typeof(bool))]
	[Calls(Type = typeof(MagnificentReceivePipe), Member = "get_TotalCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600000E")]
	public int Tick(int processLimit, Func<Boolean> checkEnabled = null) { }

}

