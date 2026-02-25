namespace kcp2k;

[Token(Token = "0x200000E")]
public class KcpServer
{
	[CompilerGenerated]
	[Token(Token = "0x200000F")]
	private sealed class <>c__DisplayClass20_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400004C")]
		public KcpServer <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400004D")]
		public int connectionId; //Field offset: 0x18

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000051")]
		public <>c__DisplayClass20_0() { }

		[Address(RVA = "0x10A3700", Offset = "0x10A2900", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000052")]
		internal void <CreateConnection>b__0(ArraySegment<Byte> message, KcpChannel channel) { }

		[Address(RVA = "0x10A3750", Offset = "0x10A2950", Length = "0x45")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000053")]
		internal void <CreateConnection>b__1(ErrorCode error, string reason) { }

		[Address(RVA = "0x10A37A0", Offset = "0x10A29A0", Length = "0x40")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000054")]
		internal void <CreateConnection>b__2(ArraySegment<Byte> data) { }

		[Address(RVA = "0x10A37F0", Offset = "0x10A29F0", Length = "0x1D4")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 3)]
		[Token(Token = "0x6000055")]
		internal void <CreateConnection>g__OnConnectedCallback|3(KcpServerConnection conn) { }

		[Address(RVA = "0x10A39D0", Offset = "0x10A2BD0", Length = "0x108")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000056")]
		internal void <CreateConnection>g__OnDisconnectedCallback|4() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000042")]
	protected readonly Action<Int32, IPEndPoint> OnConnected; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000043")]
	protected readonly Action<Int32, ArraySegment`1<Byte>, KcpChannel> OnData; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000044")]
	protected readonly Action<Int32> OnDisconnected; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000045")]
	protected readonly Action<Int32, ErrorCode, String> OnError; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000046")]
	protected readonly KcpConfig config; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000047")]
	protected Socket socket; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000048")]
	private EndPoint newClientEP; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000049")]
	protected readonly Byte[] rawReceiveBuffer; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400004A")]
	public Dictionary<Int32, KcpServerConnection> connections; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400004B")]
	private readonly HashSet<Int32> connectionsToRemove; //Field offset: 0x58

	[Token(Token = "0x17000008")]
	public EndPoint LocalEndPoint
	{
		[Address(RVA = "0x10A0020", Offset = "0x109F220", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Socket), Member = "get_LocalEndPoint", ReturnType = typeof(EndPoint))]
		[Token(Token = "0x6000041")]
		 get { } //Length: 19
	}

	[Address(RVA = "0x109FE00", Offset = "0x109F000", Length = "0x212")]
	[CalledBy(Type = "kcp2k.KcpTransport", Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = "kcp2k.ThreadedKcpTransport", Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Transports.Encryption.ThreadedEncryptionKcpTransport", Member = "Awake", ReturnType = typeof(void))]
	[CalledBy(Type = "Edgegap.EdgegapKcpServer", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`2<Int32, IPEndPoint>", "System.Action`3<Int32, ArraySegment`1<Byte>, KcpChannel>", "System.Action`1<Int32>", "System.Action`3<Int32, ErrorCode, String>", typeof(KcpConfig)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Edgegap.EdgegapKcpTransport", Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Int32>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(IPEndPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000042")]
	public KcpServer(Action<Int32, IPEndPoint> OnConnected, Action<Int32, ArraySegment`1<Byte>, KcpChannel> OnData, Action<Int32> OnDisconnected, Action<Int32, ErrorCode, String> OnError, KcpConfig config) { }

	[Address(RVA = "0x109EB60", Offset = "0x109DD60", Length = "0x31D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(KcpPeer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KcpConfig), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600004B")]
	protected override KcpServerConnection CreateConnection(int connectionId) { }

	[Address(RVA = "0x109EE80", Offset = "0x109E080", Length = "0x2B2")]
	[CalledBy(Type = typeof(KcpServer), Member = "Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Socket), Member = "set_DualMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Socket), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AddressFamily), typeof(SocketType), typeof(ProtocolType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RuntimeInformation), Member = "IsOSPlatform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OSPlatform)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Socket), Member = "IOControl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Byte[]), typeof(Byte[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(IPEndPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "Bind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EndPoint)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000044")]
	private static Socket CreateServerSocket(bool DualMode, ushort port) { }

	[Address(RVA = "0x109F140", Offset = "0x109E340", Length = "0x81")]
	[CalledBy(Type = "kcp2k.KcpTransport", Member = "ServerDisconnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "kcp2k.ThreadedKcpTransport", Member = "ThreadedServerDisconnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000047")]
	public void Disconnect(int connectionId) { }

	[Address(RVA = "0x10A0020", Offset = "0x109F220", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Socket), Member = "get_LocalEndPoint", ReturnType = typeof(EndPoint))]
	[Token(Token = "0x6000041")]
	public EndPoint get_LocalEndPoint() { }

	[Address(RVA = "0x109F1D0", Offset = "0x109E3D0", Length = "0xDD")]
	[CalledBy(Type = "kcp2k.KcpTransport", Member = "ServerGetClientAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000048")]
	public IPEndPoint GetClientEndPoint(int connectionId) { }

	[Address(RVA = "0x109F2B0", Offset = "0x109E4B0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000043")]
	public override bool IsActive() { }

	[Address(RVA = "0x109F2C0", Offset = "0x109E4C0", Length = "0x100")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(KcpServerConnection), Member = "RawInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600004C")]
	private void ProcessMessage(ArraySegment<Byte> segment, int connectionId) { }

	[Address(RVA = "0x109F3D0", Offset = "0x109E5D0", Length = "0x13A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Extensions), Member = "ReceiveFromNonBlocking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Socket), typeof(Byte[]), typeof(ArraySegment`1<Byte>&), typeof(EndPoint&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000049")]
	protected override bool RawReceiveFrom(out ArraySegment<Byte>& segment, out int connectionId) { }

	[Address(RVA = "0x109F510", Offset = "0x109E710", Length = "0x18A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Extensions), Member = "SendToNonBlocking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Socket), typeof(System.ArraySegment`1<System.Byte>), typeof(EndPoint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600004A")]
	protected override void RawSend(int connectionId, ArraySegment<Byte> data) { }

	[Address(RVA = "0x109F6A0", Offset = "0x109E8A0", Length = "0xA2")]
	[CalledBy(Type = "kcp2k.KcpTransport", Member = "ServerSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.ArraySegment`1<Byte>", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "kcp2k.ThreadedKcpTransport", Member = "ThreadedServerSend", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.ArraySegment`1<Byte>", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Transports.Encryption.ThreadedEncryptionKcpTransport+<>c__DisplayClass23_0", Member = "<HandleInnerServerConnected>b__0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ArraySegment`1<Byte>", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(KcpPeer), Member = "SendData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(KcpChannel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000046")]
	public void Send(int connectionId, ArraySegment<Byte> segment, KcpChannel channel) { }

	[Address(RVA = "0x109F750", Offset = "0x109E950", Length = "0x13B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(KcpServer), Member = "CreateServerSocket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(ushort)}, ReturnType = typeof(Socket))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Socket), Member = "set_Blocking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Common), Member = "ConfigureSocketBuffers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Socket), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000045")]
	public override void Start(ushort port) { }

	[Address(RVA = "0x109F890", Offset = "0x109EA90", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Socket), Member = "Close", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000050")]
	public override void Stop() { }

	[Address(RVA = "0x109B8B0", Offset = "0x109AAB0", Length = "0x38")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x600004F")]
	public override void Tick() { }

	[Address(RVA = "0x109F900", Offset = "0x109EB00", Length = "0x3C7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(HashSet`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.HashSet`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(KcpServerConnection), Member = "RawInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x600004D")]
	public override void TickIncoming() { }

	[Address(RVA = "0x109FCD0", Offset = "0x109EED0", Length = "0x12B")]
	[CalledBy(Type = "Edgegap.EdgegapKcpServer", Member = "TickOutgoing", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600004E")]
	public override void TickOutgoing() { }

}

