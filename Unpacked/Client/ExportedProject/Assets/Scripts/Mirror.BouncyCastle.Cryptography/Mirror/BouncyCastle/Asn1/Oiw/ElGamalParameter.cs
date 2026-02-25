namespace Mirror.BouncyCastle.Asn1.Oiw;

[Token(Token = "0x200025C")]
public class ElGamalParameter : Asn1Encodable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400069A")]
	internal DerInteger p; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400069B")]
	internal DerInteger g; //Field offset: 0x18

	[Token(Token = "0x170001C3")]
	public BigInteger G
	{
		[Address(RVA = "0x1121860", Offset = "0x1120A60", Length = "0x1D")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(DerInteger), Member = "get_PositiveValue", ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6001360")]
		 get { } //Length: 29
	}

	[Token(Token = "0x170001C2")]
	public BigInteger P
	{
		[Address(RVA = "0x11218A0", Offset = "0x1120AA0", Length = "0x1D")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(DerInteger), Member = "get_PositiveValue", ReturnType = typeof(BigInteger))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600135F")]
		 get { } //Length: 29
	}

	[Address(RVA = "0x1122630", Offset = "0x1121830", Length = "0xB1")]
	[CalledBy(Type = typeof(SubjectPublicKeyInfoFactory), Member = "CreateSubjectPublicKeyInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricKeyParameter)}, ReturnType = typeof(SubjectPublicKeyInfo))]
	[CalledBy(Type = typeof(PrivateKeyInfoFactory), Member = "CreatePrivateKeyInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricKeyParameter), typeof(Asn1Set)}, ReturnType = typeof(PrivateKeyInfo))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DerInteger), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BigInteger)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600135D")]
	public ElGamalParameter(BigInteger p, BigInteger g) { }

	[Address(RVA = "0x1122520", Offset = "0x1121720", Length = "0x10C")]
	[CalledBy(Type = typeof(PrivateKeyFactory), Member = "CreateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PrivateKeyInfo)}, ReturnType = typeof(AsymmetricKeyParameter))]
	[CalledBy(Type = typeof(PublicKeyFactory), Member = "CreateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SubjectPublicKeyInfo)}, ReturnType = typeof(AsymmetricKeyParameter))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DerInteger), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(DerInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x600135E")]
	public ElGamalParameter(Asn1Sequence seq) { }

	[Address(RVA = "0x1121860", Offset = "0x1120A60", Length = "0x1D")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(DerInteger), Member = "get_PositiveValue", ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001360")]
	public BigInteger get_G() { }

	[Address(RVA = "0x11218A0", Offset = "0x1120AA0", Length = "0x1D")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(DerInteger), Member = "get_PositiveValue", ReturnType = typeof(BigInteger))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600135F")]
	public BigInteger get_P() { }

	[Address(RVA = "0x11224B0", Offset = "0x11216B0", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DerSequence), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1Encodable), typeof(Asn1Encodable)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001361")]
	public virtual Asn1Object ToAsn1Object() { }

}

