namespace Mirror.BouncyCastle.Crypto;

[Token(Token = "0x200010D")]
public class AsymmetricCipherKeyPair
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000234")]
	private readonly AsymmetricKeyParameter publicParameter; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000235")]
	private readonly AsymmetricKeyParameter privateParameter; //Field offset: 0x18

	[Token(Token = "0x17000143")]
	public AsymmetricKeyParameter Private
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B0E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000142")]
	public AsymmetricKeyParameter Public
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B0D")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x11DDA70", Offset = "0x11DCC70", Length = "0x123")]
	[CalledBy(Type = typeof(ECKeyPairGenerator), Member = "GenerateKeyPair", ReturnType = typeof(AsymmetricCipherKeyPair))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B0C")]
	public AsymmetricCipherKeyPair(AsymmetricKeyParameter publicParameter, AsymmetricKeyParameter privateParameter) { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B0E")]
	public AsymmetricKeyParameter get_Private() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B0D")]
	public AsymmetricKeyParameter get_Public() { }

}

