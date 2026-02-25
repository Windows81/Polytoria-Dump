namespace System.Net.Sockets;

[Token(Token = "0x20002EB")]
public class SocketException : Win32Exception
{
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000CE7")]
	private EndPoint m_EndPoint; //Field offset: 0x98

	[Token(Token = "0x170003FF")]
	public virtual string Message
	{
		[Address(RVA = "0x171D490", Offset = "0x171C690", Length = "0x8E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Exception), Member = "get_Message", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6001330")]
		 get { } //Length: 142
	}

	[Token(Token = "0x17000400")]
	public SocketError SocketErrorCode
	{
		[Address(RVA = "0x2FDE20", Offset = "0x2FD020", Length = "0x7")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001331")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x171D470", Offset = "0x171C670", Length = "0x20")]
	[CalledBy(Type = typeof(Socket), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AddressFamily), typeof(SocketType), typeof(ProtocolType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802250D0")]
	[Calls(Type = typeof(Win32Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x600132B")]
	public SocketException() { }

	[Address(RVA = "0x171D430", Offset = "0x171C630", Length = "0x8")]
	[CalledBy(Type = typeof(Dns), Member = "Error_11001", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Win32Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600132C")]
	internal SocketException(int error, string message) { }

	[Address(RVA = "0x171D440", Offset = "0x171C640", Length = "0x8")]
	[CallerCount(Count = 50)]
	[Calls(Type = typeof(Win32Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600132D")]
	public SocketException(int errorCode) { }

	[Address(RVA = "0x171D440", Offset = "0x171C640", Length = "0x8")]
	[CallerCount(Count = 50)]
	[Calls(Type = typeof(Win32Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600132E")]
	internal SocketException(SocketError socketError) { }

	[Address(RVA = "0x171D450", Offset = "0x171C650", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Win32Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[Token(Token = "0x600132F")]
	protected SocketException(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	[Address(RVA = "0x171D490", Offset = "0x171C690", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Exception), Member = "get_Message", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001330")]
	public virtual string get_Message() { }

	[Address(RVA = "0x2FDE20", Offset = "0x2FD020", Length = "0x7")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001331")]
	public SocketError get_SocketErrorCode() { }

	[Address(RVA = "0x171D420", Offset = "0x171C620", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802250D0")]
	[Token(Token = "0x600132A")]
	private static int WSAGetLastError_icall() { }

}

