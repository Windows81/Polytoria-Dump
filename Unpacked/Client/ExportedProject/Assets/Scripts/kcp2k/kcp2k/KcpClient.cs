namespace kcp2k;

[Token(Token = "0x2000008")]
public class KcpClient : KcpPeer
{
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000013")]
	protected Socket socket; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000014")]
	public EndPoint remoteEndPoint; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000015")]
	protected readonly KcpConfig config; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000016")]
	protected readonly Byte[] rawReceiveBuffer; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000017")]
	protected readonly Action OnConnectedCallback; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000018")]
	protected readonly Action<ArraySegment`1<Byte>, KcpChannel> OnDataCallback; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000019")]
	protected readonly Action OnDisconnectedCallback; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400001A")]
	protected readonly Action<ErrorCode, String> OnErrorCallback; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400001B")]
	private bool active; //Field offset: 0x98
	[FieldOffset(Offset = "0x99")]
	[Token(Token = "0x400001C")]
	public bool connected; //Field offset: 0x99

	[Token(Token = "0x17000001")]
	public EndPoint LocalEndPoint
	{
		[Address(RVA = "0x109B9F0", Offset = "0x109ABF0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Socket), Member = "get_LocalEndPoint", ReturnType = typeof(EndPoint))]
		[Token(Token = "0x600000D")]
		 get { } //Length: 19
	}

	[Address(RVA = "0x109B8F0", Offset = "0x109AAF0", Length = "0xFF")]
	[CalledBy(Type = "kcp2k.KcpTransport", Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = "kcp2k.ThreadedKcpTransport", Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Transports.Encryption.ThreadedEncryptionKcpTransport", Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = "Edgegap.EdgegapKcpClient", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Action), "System.Action`2<ArraySegment`1<Byte>, KcpChannel>", typeof(Action), "System.Action`2<ErrorCode, String>", typeof(KcpConfig)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Edgegap.EdgegapKcpTransport", Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(KcpPeer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KcpConfig), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600000E")]
	public KcpClient(Action OnConnected, Action<ArraySegment`1<Byte>, KcpChannel> OnData, Action OnDisconnected, Action<ErrorCode, String> OnError, KcpConfig config) { }

	[Address(RVA = "0x109AC80", Offset = "0x1099E80", Length = "0x33B")]
	[CalledBy(Type = "Edgegap.EdgegapKcpClient", Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = "kcp2k.KcpTransport", Member = "ClientConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "kcp2k.KcpTransport", Member = "ClientConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = "kcp2k.ThreadedKcpTransport", Member = "ThreadedClientConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "kcp2k.ThreadedKcpTransport", Member = "ThreadedClientConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Transports.Encryption.ThreadedEncryptionKcpTransport", Member = "ThreadedClientConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Transports.Encryption.ThreadedEncryptionKcpTransport", Member = "ThreadedClientConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Edgegap.EdgegapLobbyKcpTransport+<>c__DisplayClass16_1", Member = "<WaitForLobbyRelay>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Edgegap.Lobby"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Edgegap.EdgegapLobbyKcpTransport", Member = "<>n__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Edgegap.EdgegapKcpTransport", Member = "ClientConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Edgegap.EdgegapKcpTransport", Member = "ClientConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Socket), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AddressFamily), typeof(SocketType), typeof(ProtocolType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "set_Blocking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Common), Member = "ConfigureSocketBuffers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Socket), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(KcpPeer), Member = "SendHello", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Socket), Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EndPoint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IPEndPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(KcpPeer), Member = "Reset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KcpConfig)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Common), Member = "ResolveHostname", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IPAddress[]&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6000013")]
	public void Connect(string address, ushort port) { }

	[Address(RVA = "0x109B9F0", Offset = "0x109ABF0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Socket), Member = "get_LocalEndPoint", ReturnType = typeof(EndPoint))]
	[Token(Token = "0x600000D")]
	public EndPoint get_LocalEndPoint() { }

	[Address(RVA = "0x109AFC0", Offset = "0x109A1C0", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600000F")]
	protected virtual void OnAuthenticated() { }

	[Address(RVA = "0x109B060", Offset = "0x109A260", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000010")]
	protected virtual void OnData(ArraySegment<Byte> message, KcpChannel channel) { }

	[Address(RVA = "0x109B0A0", Offset = "0x109A2A0", Length = "0xDD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Socket), Member = "Close", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000012")]
	protected virtual void OnDisconnected() { }

	[Address(RVA = "0x109B180", Offset = "0x109A380", Length = "0x28")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000011")]
	protected virtual void OnError(ErrorCode error, string message) { }

	[Address(RVA = "0x109B1B0", Offset = "0x109A3B0", Length = "0x3F8")]
	[CalledBy(Type = typeof(KcpClient), Member = "TickIncoming", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArraySegment`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(KcpPeer), Member = "OnRawInputReliable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(KcpPeer), Member = "OnRawInputUnreliable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000017")]
	public void RawInput(ArraySegment<Byte> segment) { }

	[Address(RVA = "0x109B5B0", Offset = "0x109A7B0", Length = "0xB0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Extensions), Member = "ReceiveNonBlocking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Socket), typeof(Byte[]), typeof(ArraySegment`1<Byte>&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(KcpPeer), Member = "Disconnect", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000014")]
	protected override bool RawReceive(out ArraySegment<Byte>& segment) { }

	[Address(RVA = "0x109B670", Offset = "0x109A870", Length = "0xA3")]
	[CalledBy(Type = "Edgegap.EdgegapKcpClient", Member = "RawSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ArraySegment`1<Byte>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Edgegap.EdgegapKcpClient", Member = "SendPing", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Extensions), Member = "SendNonBlocking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Socket), typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000015")]
	protected virtual void RawSend(ArraySegment<Byte> data) { }

	[Address(RVA = "0x109B720", Offset = "0x109A920", Length = "0xCF")]
	[CalledBy(Type = "kcp2k.KcpTransport", Member = "ClientSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ArraySegment`1<Byte>", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "kcp2k.ThreadedKcpTransport", Member = "ThreadedClientSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ArraySegment`1<Byte>", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Transports.Encryption.ThreadedEncryptionKcpTransport", Member = "<HandleInnerClientConnected>b__26_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ArraySegment`1<Byte>", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(KcpPeer), Member = "SendData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(KcpChannel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000016")]
	public void Send(ArraySegment<Byte> segment, KcpChannel channel) { }

	[Address(RVA = "0x109B8B0", Offset = "0x109AAB0", Length = "0x38")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600001A")]
	public override void Tick() { }

	[Address(RVA = "0x109B7F0", Offset = "0x109A9F0", Length = "0x93")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KcpClient), Member = "RawInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(KcpPeer), Member = "TickIncoming", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000018")]
	public virtual void TickIncoming() { }

	[Address(RVA = "0x109B890", Offset = "0x109AA90", Length = "0x11")]
	[CalledBy(Type = "Edgegap.EdgegapKcpClient", Member = "TickOutgoing", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(KcpPeer), Member = "TickOutgoing", ReturnType = typeof(void))]
	[Token(Token = "0x6000019")]
	public virtual void TickOutgoing() { }

}

