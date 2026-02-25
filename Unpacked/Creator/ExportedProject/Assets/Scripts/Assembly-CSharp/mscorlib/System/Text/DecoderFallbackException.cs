namespace System.Text;

[Token(Token = "0x2000293")]
public sealed class DecoderFallbackException : ArgumentException
{
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000B73")]
	private Byte[] _bytesUnknown; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000B74")]
	private int _index; //Field offset: 0xA0

	[Address(RVA = "0x1525740", Offset = "0x1524940", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60014D7")]
	public DecoderFallbackException() { }

	[Address(RVA = "0x15256D0", Offset = "0x15248D0", Length = "0x4C")]
	[CalledBy(Type = typeof(DecoderExceptionFallbackBuffer), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60014D8")]
	public DecoderFallbackException(string message, Byte[] bytesUnknown, int index) { }

	[Address(RVA = "0x1525720", Offset = "0x1524920", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60014D9")]
	private DecoderFallbackException(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

