namespace Mirror.BouncyCastle.Asn1.Pkcs;

[Token(Token = "0x2000258")]
public class DHParameter : Asn1Encodable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400060A")]
	internal DerInteger p; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400060B")]
	internal DerInteger g; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400060C")]
	internal DerInteger l; //Field offset: 0x20

	[Token(Token = "0x170001B5")]
	public BigInteger G
	{
		[Address(RVA = "0x1121860", Offset = "0x1120A60", Length = "0x1D")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(DerInteger), Member = "get_PositiveValue", ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001342")]
		 get { } //Length: 29
	}

	[Token(Token = "0x170001B6")]
	public BigInteger L
	{
		[Address(RVA = "0x1121880", Offset = "0x1120A80", Length = "0x15")]
		[CalledBy(Type = typeof(PrivateKeyFactory), Member = "CreateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PrivateKeyInfo)}, ReturnType = typeof(AsymmetricKeyParameter))]
		[CalledBy(Type = typeof(PublicKeyFactory), Member = "ReadPkcsDHParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerObjectIdentifier), typeof(BigInteger), typeof(Asn1Sequence)}, ReturnType = typeof(DHPublicKeyParameters))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(DerInteger), Member = "get_PositiveValue", ReturnType = typeof(BigInteger))]
		[Token(Token = "0x6001343")]
		 get { } //Length: 21
	}

	[Token(Token = "0x170001B4")]
	public BigInteger P
	{
		[Address(RVA = "0x11218A0", Offset = "0x1120AA0", Length = "0x1D")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(DerInteger), Member = "get_PositiveValue", ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001341")]
		 get { } //Length: 29
	}

	[Address(RVA = "0x1121760", Offset = "0x1120960", Length = "0xF1")]
	[CalledBy(Type = typeof(SubjectPublicKeyInfoFactory), Member = "CreateSubjectPublicKeyInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricKeyParameter)}, ReturnType = typeof(SubjectPublicKeyInfo))]
	[CalledBy(Type = typeof(PrivateKeyInfoFactory), Member = "CreatePrivateKeyInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricKeyParameter), typeof(Asn1Set)}, ReturnType = typeof(PrivateKeyInfo))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DerInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(DerInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600133F")]
	public DHParameter(BigInteger p, BigInteger g, int l) { }

	[Address(RVA = "0x11214A0", Offset = "0x11206A0", Length = "0x2BE")]
	[CalledBy(Type = typeof(PrivateKeyFactory), Member = "CreateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PrivateKeyInfo)}, ReturnType = typeof(AsymmetricKeyParameter))]
	[CalledBy(Type = typeof(PublicKeyFactory), Member = "ReadPkcsDHParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerObjectIdentifier), typeof(BigInteger), typeof(Asn1Sequence)}, ReturnType = typeof(DHPublicKeyParameters))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001340")]
	public DHParameter(Asn1Sequence seq) { }

	[Address(RVA = "0x1121860", Offset = "0x1120A60", Length = "0x1D")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(DerInteger), Member = "get_PositiveValue", ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001342")]
	public BigInteger get_G() { }

	[Address(RVA = "0x1121880", Offset = "0x1120A80", Length = "0x15")]
	[CalledBy(Type = typeof(PrivateKeyFactory), Member = "CreateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PrivateKeyInfo)}, ReturnType = typeof(AsymmetricKeyParameter))]
	[CalledBy(Type = typeof(PublicKeyFactory), Member = "ReadPkcsDHParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DerObjectIdentifier), typeof(BigInteger), typeof(Asn1Sequence)}, ReturnType = typeof(DHPublicKeyParameters))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DerInteger), Member = "get_PositiveValue", ReturnType = typeof(BigInteger))]
	[Token(Token = "0x6001343")]
	public BigInteger get_L() { }

	[Address(RVA = "0x11218A0", Offset = "0x1120AA0", Length = "0x1D")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DerInteger), Member = "get_PositiveValue", ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001341")]
	public BigInteger get_P() { }

	[Address(RVA = "0x11213E0", Offset = "0x11205E0", Length = "0xB5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Asn1EncodableVector), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1Encodable), typeof(Asn1Encodable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Asn1EncodableVector), Member = "AddOptional", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1Encodable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DerSequence), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1EncodableVector)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001344")]
	public virtual Asn1Object ToAsn1Object() { }

}

