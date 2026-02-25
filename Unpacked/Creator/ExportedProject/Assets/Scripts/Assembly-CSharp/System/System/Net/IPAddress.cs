namespace System.Net;

[Token(Token = "0x2000209")]
public class IPAddress
{
	[Token(Token = "0x200020A")]
	private sealed class ReadOnlyIPAddress : IPAddress
	{

		[Address(RVA = "0x17CB320", Offset = "0x17CA520", Length = "0x59")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(IPAddress), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000D0E")]
		public ReadOnlyIPAddress(long newAddress) { }

	}

	[Token(Token = "0x40007E8")]
	public static readonly IPAddress Any; //Field offset: 0x0
	[Token(Token = "0x40007EC")]
	internal const long LoopbackMask = 255; //Field offset: 0x0
	[Token(Token = "0x40007F4")]
	internal const int NumberOfLabels = 8; //Field offset: 0x0
	[Token(Token = "0x40007E9")]
	public static readonly IPAddress Loopback; //Field offset: 0x8
	[Token(Token = "0x40007EA")]
	public static readonly IPAddress Broadcast; //Field offset: 0x10
	[Token(Token = "0x40007EB")]
	public static readonly IPAddress None; //Field offset: 0x18
	[Token(Token = "0x40007ED")]
	public static readonly IPAddress IPv6Any; //Field offset: 0x20
	[Token(Token = "0x40007EE")]
	public static readonly IPAddress IPv6Loopback; //Field offset: 0x28
	[Token(Token = "0x40007EF")]
	public static readonly IPAddress IPv6None; //Field offset: 0x30
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007F0")]
	private uint _addressOrScopeId; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40007F1")]
	private readonly UInt16[] _numbers; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40007F2")]
	private string _toString; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40007F3")]
	private int _hashCode; //Field offset: 0x28

	[Token(Token = "0x17000277")]
	public AddressFamily AddressFamily
	{
		[Address(RVA = "0x17C3DF0", Offset = "0x17C2FF0", Length = "0x13")]
		[CalledBy(Type = typeof(SocketAddress), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Dns), Member = "hostent_to_IPHostEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(String[]), typeof(String[])}, ReturnType = typeof(IPHostEntry))]
		[CalledBy(Type = "System.Net.WebConnection+<Connect>d__16", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TcpClient), Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UdpClient), Member = "CheckForBroadcast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(UdpClient), Member = "IsBroadcast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 11)]
		[Token(Token = "0x6000D02")]
		 get { } //Length: 19
	}

	[Token(Token = "0x17000273")]
	private bool IsIPv4
	{
		[Address(RVA = "0xAE5DD0", Offset = "0xAE4FD0", Length = "0x9")]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CF1")]
		private get { } //Length: 9
	}

	[Token(Token = "0x17000279")]
	public bool IsIPv4MappedToIPv6
	{
		[Address(RVA = "0x17C3E10", Offset = "0x17C3010", Length = "0x59")]
		[CalledBy(Type = "Mirror.Extensions", Member = "PrettyAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPEndPoint)}, ReturnType = typeof(string))]
		[CalledBy(Type = "Mirror.SimpleWeb.Connection", Member = "CalculateAddress", ReturnType = typeof(string))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000D06")]
		 get { } //Length: 89
	}

	[Token(Token = "0x17000274")]
	private bool IsIPv6
	{
		[Address(RVA = "0x2FC670", Offset = "0x2FB870", Length = "0x9")]
		[CallerCount(Count = 14)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CF2")]
		private get { } //Length: 9
	}

	[Token(Token = "0x17000275")]
	private uint PrivateAddress
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CF3")]
		private get { } //Length: 4
		[Address(RVA = "0x17C3ED0", Offset = "0x17C30D0", Length = "0x37")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CF4")]
		private set { } //Length: 55
	}

	[Token(Token = "0x17000276")]
	private uint PrivateScopeId
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CF5")]
		private get { } //Length: 4
		[Address(RVA = "0x17C3ED0", Offset = "0x17C30D0", Length = "0x37")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000CF6")]
		private set { } //Length: 55
	}

	[Token(Token = "0x17000278")]
	public long ScopeId
	{
		[Address(RVA = "0x17C3E70", Offset = "0x17C3070", Length = "0x5B")]
		[CalledBy(Type = typeof(SocketAddress), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000D03")]
		 get { } //Length: 91
	}

	[Address(RVA = "0x17C3520", Offset = "0x17C2720", Length = "0x47A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(IPAddress), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(IPAddress), Member = "ThrowAddressNullException", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000D0D")]
	private static IPAddress() { }

	[Address(RVA = "0x17C39A0", Offset = "0x17C2BA0", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000CFB")]
	private IPAddress(UInt16[] numbers, uint scopeid) { }

	[Address(RVA = "0x17C3AA0", Offset = "0x17C2CA0", Length = "0xC3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000CFA")]
	internal IPAddress(UInt16* numbers, int numbersLength, uint scopeid) { }

	[Address(RVA = "0x17C3B70", Offset = "0x17C2D70", Length = "0x91")]
	[CalledBy(Type = typeof(ReadOnlyIPAddress), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IPAddress), Member = "MapToIPv4", ReturnType = typeof(IPAddress))]
	[CalledBy(Type = typeof(SocketAddress), Member = "GetIPAddress", ReturnType = typeof(IPAddress))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000CF7")]
	public IPAddress(long newAddress) { }

	[Address(RVA = "0x17C3A00", Offset = "0x17C2C00", Length = "0x9E")]
	[CalledBy(Type = typeof(SocketAddress), Member = "GetIPAddress", ReturnType = typeof(IPAddress))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(IPAddress), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(IPAddress), Member = "ThrowAddressNullException", ReturnType = typeof(Byte[]))]
	[Token(Token = "0x6000CF8")]
	public IPAddress(Byte[] address, long scopeid) { }

	[Address(RVA = "0x17C3C10", Offset = "0x17C2E10", Length = "0x1DD")]
	[CalledBy(Type = typeof(IPAddress), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IPAddress), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000CF9")]
	public IPAddress(ReadOnlySpan<Byte> address, long scopeid) { }

	[Address(RVA = "0x17C26E0", Offset = "0x17C18E0", Length = "0x106")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D08")]
	public virtual bool Equals(object comparand) { }

	[Address(RVA = "0x17C27F0", Offset = "0x17C19F0", Length = "0x13F")]
	[CalledBy(Type = typeof(NclUtilities), Member = "IsAddressLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D07")]
	internal bool Equals(object comparandObj, bool compareScopeId) { }

	[Address(RVA = "0x17C3DF0", Offset = "0x17C2FF0", Length = "0x13")]
	[CalledBy(Type = typeof(SocketAddress), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Dns), Member = "hostent_to_IPHostEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(String[]), typeof(String[])}, ReturnType = typeof(IPHostEntry))]
	[CalledBy(Type = "System.Net.WebConnection+<Connect>d__16", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TcpClient), Member = "Connect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UdpClient), Member = "CheckForBroadcast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UdpClient), Member = "IsBroadcast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 11)]
	[Token(Token = "0x6000D02")]
	public AddressFamily get_AddressFamily() { }

	[Address(RVA = "0xAE5DD0", Offset = "0xAE4FD0", Length = "0x9")]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CF1")]
	private bool get_IsIPv4() { }

	[Address(RVA = "0x17C3E10", Offset = "0x17C3010", Length = "0x59")]
	[CalledBy(Type = "Mirror.Extensions", Member = "PrettyAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPEndPoint)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Mirror.SimpleWeb.Connection", Member = "CalculateAddress", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D06")]
	public bool get_IsIPv4MappedToIPv6() { }

	[Address(RVA = "0x2FC670", Offset = "0x2FB870", Length = "0x9")]
	[CallerCount(Count = 14)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CF2")]
	private bool get_IsIPv6() { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CF3")]
	private uint get_PrivateAddress() { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CF5")]
	private uint get_PrivateScopeId() { }

	[Address(RVA = "0x17C3E70", Offset = "0x17C3070", Length = "0x5B")]
	[CalledBy(Type = typeof(SocketAddress), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000D03")]
	public long get_ScopeId() { }

	[Address(RVA = "0x17C2930", Offset = "0x17C1B30", Length = "0x102")]
	[CalledBy(Type = typeof(SocketAddress), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(IPAddress), Member = "WriteIPv6Bytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000D01")]
	public Byte[] GetAddressBytes() { }

	[Address(RVA = "0x17C2A40", Offset = "0x17C1C40", Length = "0x488")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ReadOnlySpan`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(BitConverter), Member = "TryWriteBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>), typeof(uint)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Span`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = "System.ReadOnlySpan`1<T>")]
	[Calls(Type = "System.Marvin", Member = "ComputeHash32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(int), typeof(ulong)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE5F0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D09")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x17C2ED0", Offset = "0x17C20D0", Length = "0xD4")]
	[CalledBy(Type = typeof(WebProxy), Member = "IsLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(WebProxy), Member = "IsBypassedManual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(IPAddress), Member = "ThrowAddressNullException", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D05")]
	public static bool IsLoopback(IPAddress address) { }

	[Address(RVA = "0x17C2FB0", Offset = "0x17C21B0", Length = "0xE0")]
	[CalledBy(Type = "Mirror.Extensions", Member = "PrettyAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPEndPoint)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Mirror.SimpleWeb.Connection", Member = "CalculateAddress", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(IPAddress), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D0B")]
	public IPAddress MapToIPv4() { }

	[Address(RVA = "0x17C30A0", Offset = "0x17C22A0", Length = "0x101")]
	[CalledBy(Type = typeof(Socket), Member = "RemapIPEndPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPEndPoint)}, ReturnType = typeof(IPEndPoint))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000D0A")]
	public IPAddress MapToIPv6() { }

	[Address(RVA = "0x17C31B0", Offset = "0x17C23B0", Length = "0xB0")]
	[CalledBy(Type = typeof(Dns), Member = "hostent_to_IPHostEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(String[]), typeof(String[])}, ReturnType = typeof(IPHostEntry))]
	[CalledBy(Type = typeof(Dns), Member = "GetHostByAddressFromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(IPHostEntry))]
	[CalledBy(Type = typeof(ServicePoint), Member = "get_HostEntry", ReturnType = typeof(IPHostEntry))]
	[CalledBy(Type = "Mirror.Discovery.NetworkDiscoveryBase`2", Member = "BroadcastDiscoveryRequest", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(IPAddressParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(bool)}, ReturnType = typeof(IPAddress))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000CFD")]
	public static IPAddress Parse(string ipString) { }

	[Address(RVA = "0x17C3ED0", Offset = "0x17C30D0", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CF4")]
	private void set_PrivateAddress(uint value) { }

	[Address(RVA = "0x17C3ED0", Offset = "0x17C30D0", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000CF6")]
	private void set_PrivateScopeId(uint value) { }

	[Address(RVA = "0x17C3270", Offset = "0x17C2470", Length = "0x4E")]
	[CalledBy(Type = typeof(IPAddress), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IPAddress), Member = "IsLoopback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(IPAddress), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000D0C")]
	private static Byte[] ThrowAddressNullException() { }

	[Address(RVA = "0x17C32C0", Offset = "0x17C24C0", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IPAddressParser), Member = "IPv4AddressToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(IPAddressParser), Member = "IPv6AddressToStringHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt16[]), typeof(uint)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = "System.Text.StringBuilderCache", Member = "GetStringAndRelease", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000D04")]
	public virtual string ToString() { }

	[Address(RVA = "0x17C3320", Offset = "0x17C2520", Length = "0xA7")]
	[CalledBy(Type = typeof(WebProxy), Member = "IsLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(WebProxy), Member = "IsBypassedManual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Dns), Member = "GetHostEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IPHostEntry))]
	[CalledBy(Type = typeof(Dns), Member = "GetHostAddresses", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IPAddress[]))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(IPAddressParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(bool)}, ReturnType = typeof(IPAddress))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000CFC")]
	public static bool TryParse(string ipString, out IPAddress address) { }

	[Address(RVA = "0x17C33D0", Offset = "0x17C25D0", Length = "0xF6")]
	[CalledBy(Type = typeof(SocketAddress), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(IPAddress), Member = "WriteIPv6Bytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000CFE")]
	public bool TryWriteBytes(Span<Byte> destination, out int bytesWritten) { }

	[Address(RVA = "0x17C34D0", Offset = "0x17C26D0", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D00")]
	private void WriteIPv4Bytes(Span<Byte> destination) { }

	[Address(RVA = "0x17B1010", Offset = "0x17B0210", Length = "0xAD")]
	[CalledBy(Type = typeof(IPAddress), Member = "TryWriteBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(IPAddress), Member = "GetAddressBytes", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(FtpControlStream), Member = "FormatAddress", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress), typeof(int)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000CFF")]
	private void WriteIPv6Bytes(Span<Byte> destination) { }

}

