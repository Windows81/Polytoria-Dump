namespace Mirror.BouncyCastle.Crypto;

[Token(Token = "0x2000111")]
public static class CryptoServicesRegistrar
{

	[Address(RVA = "0x11DE340", Offset = "0x11DD540", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SecureRandom), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000B1B")]
	public static SecureRandom GetSecureRandom() { }

}

