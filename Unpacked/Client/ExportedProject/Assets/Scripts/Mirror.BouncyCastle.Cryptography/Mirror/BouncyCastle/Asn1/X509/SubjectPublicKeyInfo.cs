namespace Mirror.BouncyCastle.Asn1.X509;

[Token(Token = "0x2000220")]
public class SubjectPublicKeyInfo : Asn1Encodable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000531")]
	private readonly AlgorithmIdentifier m_algorithm; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000532")]
	private readonly DerBitString m_publicKey; //Field offset: 0x18

	[Token(Token = "0x170001B2")]
	public AlgorithmIdentifier Algorithm
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001266")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170001B3")]
	public DerBitString PublicKey
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001268")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1116510", Offset = "0x1115710", Length = "0xA1")]
	[CalledBy(Type = typeof(SubjectPublicKeyInfoFactory), Member = "CreateSubjectPublicKeyInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricKeyParameter)}, ReturnType = typeof(SubjectPublicKeyInfo))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Asn1Encodable), Member = "GetDerEncoded", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(DerBitString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001263")]
	public SubjectPublicKeyInfo(AlgorithmIdentifier algID, Asn1Encodable publicKey) { }

	[Address(RVA = "0x1116280", Offset = "0x1115480", Length = "0x8D")]
	[CalledBy(Type = typeof(SubjectPublicKeyInfoFactory), Member = "CreateSubjectPublicKeyInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricKeyParameter)}, ReturnType = typeof(SubjectPublicKeyInfo))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DerBitString), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001264")]
	public SubjectPublicKeyInfo(AlgorithmIdentifier algID, Byte[] publicKey) { }

	[Address(RVA = "0x1116310", Offset = "0x1115510", Length = "0x1FE")]
	[CalledBy(Type = typeof(SubjectPublicKeyInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(SubjectPublicKeyInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DerBitString), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(DerBitString))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AlgorithmIdentifier), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1Sequence)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Asn1Sequence), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Asn1Sequence))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6001265")]
	private SubjectPublicKeyInfo(Asn1Sequence seq) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001266")]
	public AlgorithmIdentifier get_Algorithm() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001268")]
	public DerBitString get_PublicKey() { }

	[Address(RVA = "0x1116120", Offset = "0x1115320", Length = "0xA3")]
	[CalledBy(Type = typeof(PublicKeyFactory), Member = "CreateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(AsymmetricKeyParameter))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Asn1Sequence), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Asn1Sequence))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SubjectPublicKeyInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1Sequence)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001262")]
	public static SubjectPublicKeyInfo GetInstance(object obj) { }

	[Address(RVA = "0x11161D0", Offset = "0x11153D0", Length = "0x33")]
	[CalledBy(Type = typeof(PublicKeyFactory), Member = "CreateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SubjectPublicKeyInfo)}, ReturnType = typeof(AsymmetricKeyParameter))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Asn1Object), Member = "FromByteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Asn1Object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001267")]
	public Asn1Object ParsePublicKey() { }

	[Address(RVA = "0x1116210", Offset = "0x1115410", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Asn1Sequence), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Asn1Encodable), typeof(Asn1Encodable)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001269")]
	public virtual Asn1Object ToAsn1Object() { }

}

