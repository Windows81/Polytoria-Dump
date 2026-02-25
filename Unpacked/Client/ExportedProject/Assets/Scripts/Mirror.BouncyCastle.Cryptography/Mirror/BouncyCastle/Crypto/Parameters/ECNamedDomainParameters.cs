namespace Mirror.BouncyCastle.Crypto.Parameters;

[Token(Token = "0x2000131")]
public class ECNamedDomainParameters : ECDomainParameters
{
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400026D")]
	private readonly DerObjectIdentifier name; //Field offset: 0x40

	[Token(Token = "0x17000164")]
	public DerObjectIdentifier Name
	{
		[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BCA")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x11E4A60", Offset = "0x11E3C60", Length = "0x38")]
	[CalledBy(Type = typeof(PrivateKeyFactory), Member = "CreateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PrivateKeyInfo)}, ReturnType = typeof(AsymmetricKeyParameter))]
	[CalledBy(Type = typeof(PublicKeyFactory), Member = "CreateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SubjectPublicKeyInfo)}, ReturnType = typeof(AsymmetricKeyParameter))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ECDomainParameters), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X9ECParameters)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000BCB")]
	public ECNamedDomainParameters(DerObjectIdentifier name, X9ECParameters x9) { }

	[Address(RVA = "0x11E4AA0", Offset = "0x11E3CA0", Length = "0x1F1")]
	[CallerCount(Count = 0)]
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
	[Token(Token = "0x6000BCC")]
	public ECNamedDomainParameters(DerObjectIdentifier name, ECCurve curve, ECPoint g, BigInteger n, BigInteger h, Byte[] seed) { }

	[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BCA")]
	public DerObjectIdentifier get_Name() { }

}

