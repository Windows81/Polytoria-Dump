namespace kcp2k;

[Token(Token = "0x2000010")]
public class KcpServerConnection : KcpPeer
{
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400004E")]
	public readonly EndPoint remoteEndPoint; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400004F")]
	protected readonly Action<KcpServerConnection> OnConnectedCallback; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000050")]
	protected readonly Action<ArraySegment`1<Byte>, KcpChannel> OnDataCallback; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000051")]
	protected readonly Action OnDisconnectedCallback; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000052")]
	protected readonly Action<ErrorCode, String> OnErrorCallback; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000053")]
	protected readonly Action<ArraySegment`1<Byte>> RawSendCallback; //Field offset: 0x80

	[Address(RVA = "0x109EAA0", Offset = "0x109DCA0", Length = "0xB2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KcpPeer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KcpConfig), typeof(uint)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000057")]
	public KcpServerConnection(Action<KcpServerConnection> OnConnected, Action<ArraySegment`1<Byte>, KcpChannel> OnData, Action OnDisconnected, Action<ErrorCode, String> OnError, Action<ArraySegment`1<Byte>> OnRawSend, KcpConfig config, uint cookie, EndPoint remoteEndPoint) { }

	[Address(RVA = "0x109E4E0", Offset = "0x109D6E0", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(KcpPeer), Member = "SendHello", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000058")]
	protected virtual void OnAuthenticated() { }

	[Address(RVA = "0x109E520", Offset = "0x109D720", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000059")]
	protected virtual void OnData(ArraySegment<Byte> message, KcpChannel channel) { }

	[Address(RVA = "0x109E560", Offset = "0x109D760", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600005A")]
	protected virtual void OnDisconnected() { }

	[Address(RVA = "0x109E590", Offset = "0x109D790", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600005B")]
	protected virtual void OnError(ErrorCode error, string message) { }

	[Address(RVA = "0x109E5C0", Offset = "0x109D7C0", Length = "0x494")]
	[CalledBy(Type = typeof(KcpServer), Member = "ProcessMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KcpServer), Member = "TickIncoming", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(KcpPeer), Member = "OnRawInputUnreliable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(KcpPeer), Member = "OnRawInputReliable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ArraySegment`1<System.Byte>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArraySegment`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600005D")]
	public void RawInput(ArraySegment<Byte> segment) { }

	[Address(RVA = "0x109EA60", Offset = "0x109DC60", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600005C")]
	protected virtual void RawSend(ArraySegment<Byte> data) { }

}

