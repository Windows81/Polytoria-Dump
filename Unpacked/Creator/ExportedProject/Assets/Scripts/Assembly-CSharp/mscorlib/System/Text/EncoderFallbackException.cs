namespace System.Text;

[Token(Token = "0x200029E")]
public sealed class EncoderFallbackException : ArgumentException
{
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000B8A")]
	private char _charUnknown; //Field offset: 0x98
	[FieldOffset(Offset = "0x9A")]
	[Token(Token = "0x4000B8B")]
	private char _charUnknownHigh; //Field offset: 0x9A
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x4000B8C")]
	private char _charUnknownLow; //Field offset: 0x9C
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000B8D")]
	private int _index; //Field offset: 0xA0

	[Address(RVA = "0x15282D0", Offset = "0x15274D0", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001529")]
	public EncoderFallbackException() { }

	[Address(RVA = "0x1528500", Offset = "0x1527700", Length = "0x3E")]
	[CalledBy(Type = typeof(EncoderExceptionFallbackBuffer), Member = "Fallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600152A")]
	internal EncoderFallbackException(string message, char charUnknown, int index) { }

	[Address(RVA = "0x1528320", Offset = "0x1527520", Length = "0x1DB")]
	[CalledBy(Type = typeof(EncoderExceptionFallbackBuffer), Member = "Fallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(char), Member = "IsHighSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "IsLowSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600152B")]
	internal EncoderFallbackException(string message, char charUnknownHigh, char charUnknownLow, int index) { }

	[Address(RVA = "0x1525720", Offset = "0x1524920", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600152C")]
	private EncoderFallbackException(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

