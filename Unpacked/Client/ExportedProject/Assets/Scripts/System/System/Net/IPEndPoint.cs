namespace System.Net;

[Token(Token = "0x200020C")]
public class IPEndPoint : EndPoint
{
	[Token(Token = "0x40007F5")]
	public const int MinPort = 0; //Field offset: 0x0
	[Token(Token = "0x40007F6")]
	public const int MaxPort = 65535; //Field offset: 0x0
	[Token(Token = "0x40007F9")]
	internal const int AnyPort = 0; //Field offset: 0x0
	[Token(Token = "0x40007FA")]
	internal static IPEndPoint Any; //Field offset: 0x0
	[Token(Token = "0x40007FB")]
	internal static IPEndPoint IPv6Any; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007F7")]
	private IPAddress _address; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40007F8")]
	private int _port; //Field offset: 0x18

	[Token(Token = "0x1700027B")]
	public IPAddress Address
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D1E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700027A")]
	public virtual AddressFamily AddressFamily
	{
		[Address(RVA = "0x17C4610", Offset = "0x17C3810", Length = "0x29")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000D1C")]
		 get { } //Length: 41
	}

	[Token(Token = "0x1700027C")]
	public int Port
	{
		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D1F")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x17C4350", Offset = "0x17C3550", Length = "0x1CD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000D25")]
	private static IPEndPoint() { }

	[Address(RVA = "0x17C4520", Offset = "0x17C3720", Length = "0xE3")]
	[CalledBy(Type = "Mirror.Discovery.NetworkDiscoveryBase`2", Member = "BroadcastDiscoveryRequest", ReturnType = typeof(void))]
	[CalledBy(Type = "kcp2k.KcpServer", Member = "CreateServerSocket", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(ushort)}, ReturnType = typeof(Socket))]
	[CalledBy(Type = "kcp2k.KcpServer", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Action`2<Int32, IPEndPoint>", "System.Action`3<Int32, ArraySegment`1<Byte>, KcpChannel>", "System.Action`1<Int32>", "System.Action`3<Int32, ErrorCode, String>", "kcp2k.KcpConfig"}, ReturnType = typeof(void))]
	[CalledBy(Type = "kcp2k.KcpClient", Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Edgegap.EdgegapKcpServer", Member = "Start", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TcpListener), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TcpClient), Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UdpClient), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(AddressFamily)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Socket), Member = "BeginMConnect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAsyncResult)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Socket), Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.WebConnection+<Connect>d__16", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SocketAddress), Member = "GetIPEndPoint", ReturnType = typeof(IPEndPoint))]
	[CalledBy(Type = typeof(FtpControlStream), Member = "QueueOrCreateDataConection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PipelineEntry), typeof(ResponseDescription), typeof(bool), typeof(Stream&), typeof(Boolean&)}, ReturnType = typeof(PipelineInstruction))]
	[CalledBy(Type = typeof(Socket), Member = "RemapIPEndPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPEndPoint)}, ReturnType = typeof(IPEndPoint))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000D1D")]
	public IPEndPoint(IPAddress address, int port) { }

	[Address(RVA = "0x17C3F10", Offset = "0x17C3110", Length = "0x251")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(SocketAddress), Member = "get_Family", ReturnType = typeof(AddressFamily))]
	[Calls(Type = typeof(SocketAddress), Member = "GetIPEndPoint", ReturnType = typeof(IPEndPoint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = "SR", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002060")]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000D22")]
	public virtual EndPoint Create(SocketAddress socketAddress) { }

	[Address(RVA = "0x17C4170", Offset = "0x17C3370", Length = "0xA6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D23")]
	public virtual bool Equals(object comparand) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D1E")]
	public IPAddress get_Address() { }

	[Address(RVA = "0x17C4610", Offset = "0x17C3810", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D1C")]
	public virtual AddressFamily get_AddressFamily() { }

	[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D1F")]
	public int get_Port() { }

	[Address(RVA = "0x11D6920", Offset = "0x11D5B20", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D24")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x17C4220", Offset = "0x17C3420", Length = "0x68")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SocketAddress), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000D21")]
	public virtual SocketAddress Serialize() { }

	[Address(RVA = "0x17C4290", Offset = "0x17C3490", Length = "0xB6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000D20")]
	public virtual string ToString() { }

}

