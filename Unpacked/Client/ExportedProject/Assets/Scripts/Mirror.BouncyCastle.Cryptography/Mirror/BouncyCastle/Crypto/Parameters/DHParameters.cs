namespace Mirror.BouncyCastle.Crypto.Parameters;

[Token(Token = "0x2000123")]
public class DHParameters : ICipherParameters
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400024A")]
	private readonly BigInteger p; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400024B")]
	private readonly BigInteger g; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400024C")]
	private readonly BigInteger q; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400024D")]
	private readonly BigInteger j; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400024E")]
	private readonly int m; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400024F")]
	private readonly int l; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000250")]
	private readonly DHValidationParameters validation; //Field offset: 0x38

	[Token(Token = "0x1700014C")]
	public BigInteger G
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B7A")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700014E")]
	public int L
	{
		[Address(RVA = "0x3EAB00", Offset = "0x3E9D00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B7C")]
		 get { } //Length: 4
	}

	[Token(Token = "0x1700014B")]
	public BigInteger P
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B79")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700014D")]
	public BigInteger Q
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000B7B")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x11DFE90", Offset = "0x11DF090", Length = "0xBD")]
	[CalledBy(Type = typeof(PrivateKeyFactory), Member = "CreateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PrivateKeyInfo)}, ReturnType = typeof(AsymmetricKeyParameter))]
	[CalledBy(Type = typeof(PublicKeyFactory), Member = "ReadPkcsDHParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerObjectIdentifier), typeof(BigInteger), typeof(Asn1Sequence)}, ReturnType = typeof(DHPublicKeyParameters))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DHParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(int), typeof(int), typeof(BigInteger), typeof(DHValidationParameters)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000B76")]
	public DHParameters(BigInteger p, BigInteger g, BigInteger q, int l) { }

	[Address(RVA = "0x11DFE50", Offset = "0x11DF050", Length = "0x3D")]
	[CalledBy(Type = typeof(PublicKeyFactory), Member = "CreateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SubjectPublicKeyInfo)}, ReturnType = typeof(AsymmetricKeyParameter))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DHParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(int), typeof(int), typeof(BigInteger), typeof(DHValidationParameters)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000B77")]
	public DHParameters(BigInteger p, BigInteger g, BigInteger q, BigInteger j, DHValidationParameters validation) { }

	[Address(RVA = "0x11DFF50", Offset = "0x11DF150", Length = "0x525")]
	[CalledBy(Type = typeof(DHParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DHParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(BigInteger), typeof(DHValidationParameters)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BigInteger), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BigInteger), Member = "TestBit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BigInteger), Member = "Subtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(BigInteger), Member = "get_BitLength", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B78")]
	public DHParameters(BigInteger p, BigInteger g, BigInteger q, int m, int l, BigInteger j, DHValidationParameters validation) { }

	[Address(RVA = "0x11DFC40", Offset = "0x11DEE40", Length = "0x9F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000B7D")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x11DFCE0", Offset = "0x11DEEE0", Length = "0x73")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigInteger), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000B7E")]
	protected override bool Equals(DHParameters other) { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B7A")]
	public BigInteger get_G() { }

	[Address(RVA = "0x3EAB00", Offset = "0x3E9D00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B7C")]
	public int get_L() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B79")]
	public BigInteger get_P() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000B7B")]
	public BigInteger get_Q() { }

	[Address(RVA = "0x11DFD60", Offset = "0x11DEF60", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Token(Token = "0x6000B75")]
	private static int GetDefaultMParam(int lParam) { }

	[Address(RVA = "0x11DFDC0", Offset = "0x11DEFC0", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000B7F")]
	public virtual int GetHashCode() { }

}

