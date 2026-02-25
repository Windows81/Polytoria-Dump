namespace System.Net.Sockets;

[Token(Token = "0x2000300")]
public struct UdpReceiveResult : IEquatable<UdpReceiveResult>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000DF4")]
	private Byte[] m_buffer; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000DF5")]
	private IPEndPoint m_remoteEndPoint; //Field offset: 0x8

	[Token(Token = "0x1700040C")]
	public Byte[] Buffer
	{
		[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
		[CallerCount(Count = 140)]
		[DeduplicatedMethod]
		[Token(Token = "0x600136C")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700040D")]
	public IPEndPoint RemoteEndPoint
	{
		[Address(RVA = "0x310530", Offset = "0x30F730", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600136D")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x17318D0", Offset = "0x1730AD0", Length = "0xCD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600136B")]
	public UdpReceiveResult(Byte[] buffer, IPEndPoint remoteEndPoint) { }

	[Address(RVA = "0x17317B0", Offset = "0x17309B0", Length = "0xAC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600136F")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1731760", Offset = "0x1730960", Length = "0x47")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001370")]
	public override bool Equals(UdpReceiveResult other) { }

	[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
	[CallerCount(Count = 140)]
	[DeduplicatedMethod]
	[Token(Token = "0x600136C")]
	public Byte[] get_Buffer() { }

	[Address(RVA = "0x310530", Offset = "0x30F730", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600136D")]
	public IPEndPoint get_RemoteEndPoint() { }

	[Address(RVA = "0x1731860", Offset = "0x1730A60", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600136E")]
	public virtual int GetHashCode() { }

}

