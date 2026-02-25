namespace Mirror.BouncyCastle.Crypto.Parameters;

[Token(Token = "0x2000128")]
public class DsaParameters : ICipherParameters
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000256")]
	private readonly BigInteger p; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000257")]
	private readonly BigInteger q; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000258")]
	private readonly BigInteger g; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000259")]
	private readonly DsaValidationParameters validation; //Field offset: 0x28

	[Token(Token = "0x17000154")]
	public BigInteger G
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B9A")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000152")]
	public BigInteger P
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B98")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000153")]
	public BigInteger Q
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B99")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x11E1F80", Offset = "0x11E1180", Length = "0x16F")]
	[CalledBy(Type = typeof(PrivateKeyFactory), Member = "CreateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PrivateKeyInfo)}, ReturnType = typeof(AsymmetricKeyParameter))]
	[CalledBy(Type = typeof(PublicKeyFactory), Member = "CreateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SubjectPublicKeyInfo)}, ReturnType = typeof(AsymmetricKeyParameter))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B96")]
	public DsaParameters(BigInteger p, BigInteger q, BigInteger g) { }

	[Address(RVA = "0x11E1E10", Offset = "0x11E1010", Length = "0x16E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B97")]
	public DsaParameters(BigInteger p, BigInteger q, BigInteger g, DsaValidationParameters parameters) { }

	[Address(RVA = "0x11E1CA0", Offset = "0x11E0EA0", Length = "0xD5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BigInteger), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000B9B")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x11E1C20", Offset = "0x11E0E20", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigInteger), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B9C")]
	protected bool Equals(DsaParameters other) { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B9A")]
	public BigInteger get_G() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B98")]
	public BigInteger get_P() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B99")]
	public BigInteger get_Q() { }

	[Address(RVA = "0x11E1D80", Offset = "0x11E0F80", Length = "0x85")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B9D")]
	public virtual int GetHashCode() { }

}

