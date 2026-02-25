namespace Edgegap;

[Token(Token = "0x2000044")]
public class EdgegapKcpServer : KcpServer
{
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000176")]
	private readonly Byte[] relayReceiveBuffer; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000177")]
	public uint userId; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4000178")]
	public uint sessionId; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000179")]
	public ConnectionState state; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400017A")]
	protected Socket relaySocket; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400017B")]
	public EndPoint remoteEndPoint; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400017C")]
	private double lastPingTime; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400017D")]
	private bool relayActive; //Field offset: 0x90

	[Address(RVA = "0x1271660", Offset = "0x1270860", Length = "0xB6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(KcpServer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`2<System.Int32, System.Net.IPEndPoint>), typeof(System.Action`3<System.Int32, System.ArraySegment`1<System.Byte>, kcp2k.KcpChannel>), typeof(System.Action`1<System.Int32>), typeof(System.Action`3<System.Int32, kcp2k.ErrorCode, System.String>), typeof(KcpConfig)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60001C3")]
	public EdgegapKcpServer(Action<Int32, IPEndPoint> OnConnected, Action<Int32, ArraySegment`1<Byte>, KcpChannel> OnData, Action<Int32> OnDisconnected, Action<Int32, ErrorCode, String> OnError, KcpConfig config) { }

	[Address(RVA = "0xE6C540", Offset = "0xE6B740", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001C4")]
	public virtual bool IsActive() { }

	[Address(RVA = "0x12709D0", Offset = "0x126FBD0", Length = "0x501")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NetworkReader), Member = "ReadBytesSegment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(System.ArraySegment`1<System.Byte>))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(NetworkReader), Member = "ReadByte", ReturnType = typeof(byte))]
	[Calls(Type = typeof(NetworkReader), Member = "get_Remaining", ReturnType = typeof(int))]
	[Calls(Type = typeof(NetworkReaderPool), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(NetworkReaderPooled))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Extensions), Member = "ReceiveNonBlocking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Socket), typeof(Byte[]), typeof(ArraySegment`1<Byte>&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001C7")]
	protected virtual bool RawReceiveFrom(out ArraySegment<Byte>& segment, out int connectionId) { }

	[Address(RVA = "0x1270EE0", Offset = "0x12700E0", Length = "0x2A9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriter), Member = "WriteByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(NetworkWriter), Member = "WriteBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArraySegment`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Extensions), Member = "SendNonBlocking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Socket), typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60001C8")]
	protected virtual void RawSend(int connectionId, ArraySegment<Byte> data) { }

	[Address(RVA = "0x1271190", Offset = "0x1270390", Length = "0x1EF")]
	[CalledBy(Type = typeof(EdgegapKcpServer), Member = "TickOutgoing", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NetworkWriter), Member = "WriteByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(Extensions), Member = "SendNonBlocking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Socket), typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteUInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterPool), Member = "Get", ReturnType = typeof(NetworkWriterPooled))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArraySegment`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x60001C9")]
	private void SendPing() { }

	[Address(RVA = "0x1271380", Offset = "0x1270580", Length = "0x225")]
	[CalledBy(Type = "Edgegap.EdgegapLobbyKcpTransport+<>c__DisplayClass16_1", Member = "<WaitForLobbyRelay>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Lobby)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EdgegapLobbyKcpTransport), Member = "<>n__0", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EdgegapKcpTransport), Member = "ServerStart", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Socket), Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EndPoint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Common), Member = "ConfigureSocketBuffers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Socket), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "set_Blocking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AddressFamily), typeof(SocketType), typeof(ProtocolType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Common), Member = "ResolveHostname", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IPAddress[]&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(IPEndPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60001C5")]
	public void Start(string relayAddress, ushort relayPort, uint userId, uint sessionId) { }

	[Address(RVA = "0x12715B0", Offset = "0x12707B0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60001C6")]
	public virtual void Stop() { }

	[Address(RVA = "0x12715C0", Offset = "0x12707C0", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Time), Member = "get_unscaledTimeAsDouble", ReturnType = typeof(double))]
	[Calls(Type = typeof(EdgegapKcpServer), Member = "SendPing", ReturnType = typeof(void))]
	[Calls(Type = typeof(KcpServer), Member = "TickOutgoing", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001CA")]
	public virtual void TickOutgoing() { }

}

