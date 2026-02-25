namespace Mirror.BouncyCastle.Crypto;

[Token(Token = "0x200010C")]
public static class AesUtilities
{

	[Token(Token = "0x17000141")]
	public static bool IsHardwareAccelerated
	{
		[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
		[CallerCount(Count = 137)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B0B")]
		 get { } //Length: 3
	}

	[Address(RVA = "0x11DDA20", Offset = "0x11DCC20", Length = "0x44")]
	[CalledBy(Type = "Mirror.Transports.Encryption.EncryptedConnection+<>c", Member = "<.cctor>b__47_0", ReturnType = typeof(GcmBlockCipher))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B0A")]
	public static IBlockCipher CreateEngine() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B0B")]
	public static bool get_IsHardwareAccelerated() { }

}

