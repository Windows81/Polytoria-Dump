namespace System.Net;

[DefaultMember("Item")]
[Token(Token = "0x2000239")]
public class SocketAddress
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400091D")]
	internal int m_Size; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400091E")]
	internal Byte[] m_Buffer; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400091F")]
	private bool m_changed; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000920")]
	private int m_hash; //Field offset: 0x24

	[Token(Token = "0x170002D1")]
	public AddressFamily Family
	{
		[Address(RVA = "0x17E0450", Offset = "0x17DF650", Length = "0x36")]
		[CalledBy(Type = typeof(IPEndPoint), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAddress)}, ReturnType = typeof(EndPoint))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Token(Token = "0x6000E33")]
		 get { } //Length: 54
	}

	[Token(Token = "0x170002D3")]
	public byte Item
	{
		[Address(RVA = "0x17E0490", Offset = "0x17DF690", Length = "0x75")]
		[CalledBy(Type = typeof(SocketAddress), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(SocketAddress), Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000E35")]
		 get { } //Length: 117
	}

	[Token(Token = "0x170002D2")]
	public int Size
	{
		[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000E34")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x17E0020", Offset = "0x17DF220", Length = "0x11D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000E36")]
	public SocketAddress(AddressFamily family, int size) { }

	[Address(RVA = "0x17E0140", Offset = "0x17DF340", Length = "0x30F")]
	[CalledBy(Type = typeof(SocketAddress), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(IPAddress), Member = "get_AddressFamily", ReturnType = typeof(AddressFamily))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(IPAddress), Member = "TryWriteBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(IPAddress), Member = "get_ScopeId", ReturnType = typeof(long))]
	[Calls(Type = typeof(IPAddress), Member = "GetAddressBytes", ReturnType = typeof(Byte[]))]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000E37")]
	internal SocketAddress(IPAddress ipAddress) { }

	[Address(RVA = "0x17DFFC0", Offset = "0x17DF1C0", Length = "0x57")]
	[CalledBy(Type = typeof(IPEndPoint), Member = "Serialize", ReturnType = typeof(SocketAddress))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SocketAddress), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000E38")]
	internal SocketAddress(IPAddress ipaddress, int port) { }

	[Address(RVA = "0x17DF7C0", Offset = "0x17DE9C0", Length = "0x133")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SocketAddress), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000E3B")]
	public virtual bool Equals(object comparand) { }

	[Address(RVA = "0x17E0450", Offset = "0x17DF650", Length = "0x36")]
	[CalledBy(Type = typeof(IPEndPoint), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAddress)}, ReturnType = typeof(EndPoint))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000E33")]
	public AddressFamily get_Family() { }

	[Address(RVA = "0x17E0490", Offset = "0x17DF690", Length = "0x75")]
	[CalledBy(Type = typeof(SocketAddress), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SocketAddress), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000E35")]
	public byte get_Item(int offset) { }

	[Address(RVA = "0x2BC1B0", Offset = "0x2BB3B0", Length = "0x4")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000E34")]
	public int get_Size() { }

	[Address(RVA = "0x17DF900", Offset = "0x17DEB00", Length = "0x131")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000E3C")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x17DFA40", Offset = "0x17DEC40", Length = "0x254")]
	[CalledBy(Type = typeof(SocketAddress), Member = "GetIPEndPoint", ReturnType = typeof(IPEndPoint))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(IPAddress), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(IPAddress), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000E39")]
	internal IPAddress GetIPAddress() { }

	[Address(RVA = "0x17DFCA0", Offset = "0x17DEEA0", Length = "0x9B")]
	[CalledBy(Type = typeof(IPEndPoint), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SocketAddress)}, ReturnType = typeof(EndPoint))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SocketAddress), Member = "GetIPAddress", ReturnType = typeof(IPAddress))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(IPEndPoint), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IPAddress), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000E3A")]
	internal IPEndPoint GetIPEndPoint() { }

	[Address(RVA = "0x17DFD40", Offset = "0x17DEF40", Length = "0x27C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(SocketAddress), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(byte), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000E3D")]
	public virtual string ToString() { }

}

