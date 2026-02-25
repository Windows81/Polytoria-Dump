namespace Mirror.BouncyCastle.Crypto.Parameters;

[Token(Token = "0x200012E")]
public class ECGost3410Parameters : ECNamedDomainParameters
{
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000264")]
	private readonly DerObjectIdentifier _publicKeyParamSet; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000265")]
	private readonly DerObjectIdentifier _digestParamSet; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000266")]
	private readonly DerObjectIdentifier _encryptionParamSet; //Field offset: 0x58

	[Token(Token = "0x1700015D")]
	public DerObjectIdentifier DigestParamSet
	{
		[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BBA")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700015E")]
	public DerObjectIdentifier EncryptionParamSet
	{
		[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BBB")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700015C")]
	public DerObjectIdentifier PublicKeyParamSet
	{
		[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BB9")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x11E31E0", Offset = "0x11E23E0", Length = "0x292")]
	[CalledBy(Type = typeof(PrivateKeyFactory), Member = "CreateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PrivateKeyInfo)}, ReturnType = typeof(AsymmetricKeyParameter))]
	[CalledBy(Type = typeof(PublicKeyFactory), Member = "CreateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SubjectPublicKeyInfo)}, ReturnType = typeof(AsymmetricKeyParameter))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Arrays), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ECDomainParameters), Member = "ValidatePublicPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ECCurve), typeof(ECPoint)}, ReturnType = typeof(ECPoint))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000BBC")]
	public ECGost3410Parameters(ECNamedDomainParameters dp, DerObjectIdentifier publicKeyParamSet, DerObjectIdentifier digestParamSet, DerObjectIdentifier encryptionParamSet) { }

	[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BBA")]
	public DerObjectIdentifier get_DigestParamSet() { }

	[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BBB")]
	public DerObjectIdentifier get_EncryptionParamSet() { }

	[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BB9")]
	public DerObjectIdentifier get_PublicKeyParamSet() { }

}

