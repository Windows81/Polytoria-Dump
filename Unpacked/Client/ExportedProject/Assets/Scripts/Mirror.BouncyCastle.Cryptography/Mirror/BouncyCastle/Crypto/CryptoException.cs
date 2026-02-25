namespace Mirror.BouncyCastle.Crypto;

[Token(Token = "0x2000110")]
public class CryptoException : Exception
{

	[Address(RVA = "0x11DE210", Offset = "0x11DD410", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B18")]
	public CryptoException() { }

	[Address(RVA = "0x11DE2E0", Offset = "0x11DD4E0", Length = "0x59")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B19")]
	public CryptoException(string message) { }

	[Address(RVA = "0x11DE260", Offset = "0x11DD460", Length = "0x74")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B1A")]
	protected CryptoException(SerializationInfo info, StreamingContext context) { }

}

