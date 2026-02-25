namespace Mirror.BouncyCastle.Crypto;

[Token(Token = "0x2000119")]
public class KeyGenerationParameters
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000237")]
	private SecureRandom random; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000238")]
	private int strength; //Field offset: 0x18

	[Token(Token = "0x17000145")]
	public SecureRandom Random
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B2D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000146")]
	public int Strength
	{
		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B2E")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x11EF320", Offset = "0x11EE520", Length = "0xEF")]
	[CalledBy(Type = "Mirror.Transports.Encryption.EncryptionCredentials", Member = "Generate", ReturnType = "Mirror.Transports.Encryption.EncryptionCredentials")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B2C")]
	public KeyGenerationParameters(SecureRandom random, int strength) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B2D")]
	public SecureRandom get_Random() { }

	[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B2E")]
	public int get_Strength() { }

}

