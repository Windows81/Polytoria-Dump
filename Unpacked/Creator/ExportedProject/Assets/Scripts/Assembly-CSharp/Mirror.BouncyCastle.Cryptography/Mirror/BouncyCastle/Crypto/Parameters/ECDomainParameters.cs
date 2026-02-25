namespace Mirror.BouncyCastle.Crypto.Parameters;

[Token(Token = "0x200012C")]
public class ECDomainParameters
{
	[CompilerGenerated]
	[Token(Token = "0x200012D")]
	private sealed class <>c
	{
		[Token(Token = "0x4000262")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000263")]
		public static Func<ECDomainParameters, BigInteger> <>9__19_0; //Field offset: 0x8

		[Address(RVA = "0x11F4B30", Offset = "0x11F3D30", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000BB6")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BB7")]
		public <>c() { }

		[Address(RVA = "0x11F4AC0", Offset = "0x11F3CC0", Length = "0x69")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(BigIntegers), Member = "ModOddInverseVar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger), typeof(BigInteger)}, ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000BB8")]
		internal BigInteger <get_HInv>b__19_0(ECDomainParameters self) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400025C")]
	private readonly ECCurve curve; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400025D")]
	private readonly Byte[] seed; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400025E")]
	private readonly ECPoint g; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400025F")]
	private readonly BigInteger n; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000260")]
	private readonly BigInteger h; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000261")]
	private BigInteger hInv; //Field offset: 0x38

	[Token(Token = "0x17000157")]
	public ECCurve Curve
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BAB")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000158")]
	public ECPoint G
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BAC")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700015A")]
	public BigInteger H
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BAE")]
		 get { } //Length: 95
	}

	[Token(Token = "0x1700015B")]
	public BigInteger HInv
	{
		[Address(RVA = "0x11E30C0", Offset = "0x11E22C0", Length = "0x111")]
		[CalledBy(Type = typeof(ECDHBasicAgreement), Member = "CalculateAgreement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICipherParameters)}, ReturnType = typeof(BigInteger))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Objects), Member = "EnsureSingletonInitialized", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue", "TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue&", "TArg", "System.Func`2<TArg, TValue>"}, ReturnType = "TValue")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000BAF")]
		 get { } //Length: 273
	}

	[Token(Token = "0x17000159")]
	public BigInteger N
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BAD")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x11E2CE0", Offset = "0x11E1EE0", Length = "0x1FF")]
	[CalledBy(Type = typeof(PublicKeyFactory), Member = "CreateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SubjectPublicKeyInfo)}, ReturnType = typeof(AsymmetricKeyParameter))]
	[CalledBy(Type = typeof(ECKeyParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(DerObjectIdentifier)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ECKeyParameters), Member = "LookupParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerObjectIdentifier)}, ReturnType = typeof(ECDomainParameters))]
	[CalledBy(Type = typeof(ECNamedDomainParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerObjectIdentifier), typeof(X9ECParameters)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Arrays), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(X9ECParameters), Member = "get_G", ReturnType = typeof(ECPoint))]
	[Calls(Type = typeof(ECDomainParameters), Member = "ValidatePublicPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000BA9")]
	public ECDomainParameters(X9ECParameters x9) { }

	[Address(RVA = "0x11E2EE0", Offset = "0x11E20E0", Length = "0x1D0")]
	[CalledBy(Type = typeof(PrivateKeyFactory), Member = "CreateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PrivateKeyInfo)}, ReturnType = typeof(AsymmetricKeyParameter))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ECDomainParameters), Member = "ValidatePublicPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Arrays), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000BAA")]
	public ECDomainParameters(ECCurve curve, ECPoint g, BigInteger n, BigInteger h, Byte[] seed) { }

	[Address(RVA = "0x11E27E0", Offset = "0x11E19E0", Length = "0x9F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BB1")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x11E2880", Offset = "0x11E1A80", Length = "0x8E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BigInteger), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000BB2")]
	protected override bool Equals(ECDomainParameters other) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BAB")]
	public ECCurve get_Curve() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BAC")]
	public ECPoint get_G() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BAE")]
	public BigInteger get_H() { }

	[Address(RVA = "0x11E30C0", Offset = "0x11E22C0", Length = "0x111")]
	[CalledBy(Type = typeof(ECDHBasicAgreement), Member = "CalculateAgreement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICipherParameters)}, ReturnType = typeof(BigInteger))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Objects), Member = "EnsureSingletonInitialized", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue", "TArg"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue&", "TArg", "System.Func`2<TArg, TValue>"}, ReturnType = "TValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000BAF")]
	public BigInteger get_HInv() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BAD")]
	public BigInteger get_N() { }

	[Address(RVA = "0x11E2910", Offset = "0x11E1B10", Length = "0x97")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000BB3")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x11E29B0", Offset = "0x11E1BB0", Length = "0x4D")]
	[CalledBy(Type = typeof(SubjectPublicKeyInfoFactory), Member = "CreateSubjectPublicKeyInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricKeyParameter)}, ReturnType = typeof(SubjectPublicKeyInfo))]
	[CalledBy(Type = typeof(PrivateKeyInfoFactory), Member = "CreatePrivateKeyInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricKeyParameter), typeof(Asn1Set)}, ReturnType = typeof(PrivateKeyInfo))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Arrays), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[Token(Token = "0x6000BB0")]
	public Byte[] GetSeed() { }

	[Address(RVA = "0x11E2A00", Offset = "0x11E1C00", Length = "0x140")]
	[CalledBy(Type = typeof(ECPrivateKeyParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BigInteger), typeof(ECDomainParameters)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ECPrivateKeyParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BigInteger), typeof(DerObjectIdentifier)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ECKeyPairGenerator), Member = "GenerateKeyPair", ReturnType = typeof(AsymmetricCipherKeyPair))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BigInteger), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000BB4")]
	public BigInteger ValidatePrivateScalar(BigInteger d) { }

	[Address(RVA = "0x11E2B50", Offset = "0x11E1D50", Length = "0x187")]
	[CalledBy(Type = typeof(ECKeyPairGenerator), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(KeyGenerationParameters)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ECDomainParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X9ECParameters)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ECDomainParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ECGost3410Parameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECNamedDomainParameters), typeof(DerObjectIdentifier), typeof(DerObjectIdentifier), typeof(DerObjectIdentifier)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ECNamedDomainParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerObjectIdentifier), typeof(ECCurve), typeof(ECPoint), typeof(BigInteger), typeof(BigInteger), typeof(Byte[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ECPublicKeyParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ECPoint), typeof(ECDomainParameters)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ECPublicKeyParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ECPoint), typeof(DerObjectIdentifier)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ECAlgorithms), Member = "ImportPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[Calls(Type = typeof(ECPoint), Member = "get_IsInfinity", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ECPoint), Member = "IsValid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000BB5")]
	internal static ECPoint ValidatePublicPoint(ECCurve c, ECPoint q) { }

}

