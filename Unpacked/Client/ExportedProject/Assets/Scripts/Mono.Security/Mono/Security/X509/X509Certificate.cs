namespace Mono.Security.X509;

[Token(Token = "0x2000011")]
public class X509Certificate : ISerializable
{
	[Token(Token = "0x4000060")]
	private static string encoding_error; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400004A")]
	private ASN1 decoder; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400004B")]
	private Byte[] m_encodedcert; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400004C")]
	private DateTime m_from; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400004D")]
	private DateTime m_until; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400004E")]
	private ASN1 issuer; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400004F")]
	private string m_issuername; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000050")]
	private string m_keyalgo; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000051")]
	private Byte[] m_keyalgoparams; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000052")]
	private ASN1 subject; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000053")]
	private string m_subject; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000054")]
	private Byte[] m_publickey; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000055")]
	private Byte[] signature; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000056")]
	private string m_signaturealgo; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000057")]
	private Byte[] m_signaturealgoparams; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000058")]
	private Byte[] certhash; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000059")]
	private RSA _rsa; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400005A")]
	private DSA _dsa; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400005B")]
	private int version; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400005C")]
	private Byte[] serialnumber; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400005D")]
	private Byte[] issuerUniqueID; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400005E")]
	private Byte[] subjectUniqueID; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400005F")]
	private X509ExtensionCollection extensions; //Field offset: 0xB8

	[Token(Token = "0x17000029")]
	public DSA DSA
	{
		[Address(RVA = "0x12BBDE0", Offset = "0x12BAFE0", Length = "0x39C")]
		[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono", Member = "get_PrivateKey", ReturnType = typeof(AsymmetricAlgorithm))]
		[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono", Member = "ImportPkcs12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(string)}, ReturnType = typeof(X509Certificate))]
		[CalledBy(Type = typeof(PKCS12), Member = "GetExistingParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(DSAParameters))]
		[CalledBy(Type = typeof(X509Certificate), Member = "get_IsSelfSigned", ReturnType = typeof(bool))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(DSACryptoServiceProvider), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ASN1))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(X509Certificate), Member = "GetUnsignedBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000090")]
		 get { } //Length: 924
		[Address(RVA = "0x12BCDD0", Offset = "0x12BBFD0", Length = "0x4C")]
		[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono", Member = "set_PrivateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono", Member = "ImportPkcs12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(string)}, ReturnType = typeof(X509Certificate))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000091")]
		 set { } //Length: 76
	}

	[Token(Token = "0x1700002A")]
	public X509ExtensionCollection Extensions
	{
		[Address(RVA = "0x2DD1E0", Offset = "0x2DC3E0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000092")]
		 get { } //Length: 8
	}

	[Token(Token = "0x1700002B")]
	public Byte[] Hash
	{
		[Address(RVA = "0x12BC180", Offset = "0x12BB380", Length = "0x242")]
		[CalledBy(Type = typeof(X509Certificate), Member = "VerifySignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DSA)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(X509Certificate), Member = "VerifySignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RSA)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(X509CertificateCollection), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(int))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ASN1))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(HashAlgorithm), Member = "ComputeHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(PKCS1), Member = "HashNameFromOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(PKCS1), Member = "CreateFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(HashAlgorithm))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000093")]
		 get { } //Length: 578
	}

	[Token(Token = "0x17000038")]
	public bool IsCurrent
	{
		[Address(RVA = "0x12BC3D0", Offset = "0x12BB5D0", Length = "0x104")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
		[Calls(Type = typeof(DateTime), Member = "op_GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(DateTime), Member = "op_LessThanOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60000A2")]
		 get { } //Length: 260
	}

	[Token(Token = "0x17000039")]
	public bool IsSelfSigned
	{
		[Address(RVA = "0x12BC4E0", Offset = "0x12BB6E0", Length = "0x90")]
		[CalledBy(Type = typeof(X509Chain), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(X509Chain), Member = "FindCertificateRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(X509Certificate))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(X509Certificate), Member = "get_DSA", ReturnType = typeof(DSA))]
		[Calls(Type = typeof(X509Certificate), Member = "VerifySignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DSA)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(X509Certificate), Member = "VerifySignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RSA)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60000A7")]
		 get { } //Length: 144
	}

	[Token(Token = "0x1700002C")]
	public override string IssuerName
	{
		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000094")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700002D")]
	public override string KeyAlgorithm
	{
		[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000095")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700002E")]
	public override Byte[] KeyAlgorithmParameters
	{
		[Address(RVA = "0x12BC570", Offset = "0x12BB770", Length = "0x7B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000096")]
		 get { } //Length: 123
		[Address(RVA = "0x2DD5F0", Offset = "0x2DC7F0", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000097")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700002F")]
	public override Byte[] PublicKey
	{
		[Address(RVA = "0x12BC5F0", Offset = "0x12BB7F0", Length = "0x7B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000098")]
		 get { } //Length: 123
	}

	[Token(Token = "0x17000031")]
	public override Byte[] RawData
	{
		[Address(RVA = "0x12BC890", Offset = "0x12BBA90", Length = "0x7B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600009B")]
		 get { } //Length: 123
	}

	[Token(Token = "0x17000030")]
	public override RSA RSA
	{
		[Address(RVA = "0x12BC670", Offset = "0x12BB870", Length = "0x218")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ASN1))]
		[Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(X509Certificate), Member = "GetUnsignedBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(RSACryptoServiceProvider), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000099")]
		 get { } //Length: 536
		[Address(RVA = "0x12BCE20", Offset = "0x12BC020", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600009A")]
		 set { } //Length: 78
	}

	[Token(Token = "0x17000032")]
	public override Byte[] SerialNumber
	{
		[Address(RVA = "0x12BC910", Offset = "0x12BBB10", Length = "0x81")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600009C")]
		 get { } //Length: 129
	}

	[Token(Token = "0x17000033")]
	public override Byte[] Signature
	{
		[Address(RVA = "0x12BC9A0", Offset = "0x12BBBA0", Length = "0x422")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ASN1))]
		[Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600009D")]
		 get { } //Length: 1058
	}

	[Token(Token = "0x17000034")]
	public override string SubjectName
	{
		[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600009E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000035")]
	public override DateTime ValidFrom
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x600009F")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000036")]
	public override DateTime ValidUntil
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A0")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000037")]
	public int Version
	{
		[Address(RVA = "0x508E80", Offset = "0x508080", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A1")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x12BBB40", Offset = "0x12BAD40", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60000AA")]
	private static X509Certificate() { }

	[Address(RVA = "0x12BBBA0", Offset = "0x12BADA0", Length = "0x23F")]
	[CalledBy(Type = typeof(PKCS12), Member = "RemoveCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate), typeof(IDictionary)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle", typeof(X509KeyStorageFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplUnix", Member = "ExportPkcs12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Helper2", Member = "GetMonoCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(X509Certificate))]
	[CalledBy(Type = typeof(SignedData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PKCS12), Member = "get_Certificates", ReturnType = typeof(X509CertificateCollection))]
	[CalledBy(Type = typeof(PKCS12), Member = "ReadSafeBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PKCS12), Member = "GetBytes", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(PKCS12), Member = "AddCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate), typeof(IDictionary)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509Store), Member = "LoadCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(X509Certificate))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_class_get_static_field_data")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(X509Certificate), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Convert), Member = "FromBase64String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600008E")]
	public X509Certificate(Byte[] data) { }

	[Address(RVA = "0x12BBDE0", Offset = "0x12BAFE0", Length = "0x39C")]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono", Member = "get_PrivateKey", ReturnType = typeof(AsymmetricAlgorithm))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono", Member = "ImportPkcs12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(string)}, ReturnType = typeof(X509Certificate))]
	[CalledBy(Type = typeof(PKCS12), Member = "GetExistingParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean&)}, ReturnType = typeof(DSAParameters))]
	[CalledBy(Type = typeof(X509Certificate), Member = "get_IsSelfSigned", ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(X509Certificate), Member = "GetUnsignedBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ASN1))]
	[Calls(Type = typeof(DSACryptoServiceProvider), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000090")]
	public DSA get_DSA() { }

	[Address(RVA = "0x2DD1E0", Offset = "0x2DC3E0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000092")]
	public X509ExtensionCollection get_Extensions() { }

	[Address(RVA = "0x12BC180", Offset = "0x12BB380", Length = "0x242")]
	[CalledBy(Type = typeof(X509Certificate), Member = "VerifySignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DSA)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(X509Certificate), Member = "VerifySignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RSA)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(X509CertificateCollection), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(PKCS1), Member = "CreateFromName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(HashAlgorithm))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(PKCS1), Member = "HashNameFromOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ASN1))]
	[Calls(Type = typeof(HashAlgorithm), Member = "ComputeHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(Byte[]))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000093")]
	public Byte[] get_Hash() { }

	[Address(RVA = "0x12BC3D0", Offset = "0x12BB5D0", Length = "0x104")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(DateTime), Member = "op_GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "op_LessThanOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60000A2")]
	public bool get_IsCurrent() { }

	[Address(RVA = "0x12BC4E0", Offset = "0x12BB6E0", Length = "0x90")]
	[CalledBy(Type = typeof(X509Chain), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(X509Chain), Member = "FindCertificateRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(X509Certificate))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(X509Certificate), Member = "get_DSA", ReturnType = typeof(DSA))]
	[Calls(Type = typeof(X509Certificate), Member = "VerifySignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DSA)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(X509Certificate), Member = "VerifySignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RSA)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60000A7")]
	public bool get_IsSelfSigned() { }

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000094")]
	public override string get_IssuerName() { }

	[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000095")]
	public override string get_KeyAlgorithm() { }

	[Address(RVA = "0x12BC570", Offset = "0x12BB770", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000096")]
	public override Byte[] get_KeyAlgorithmParameters() { }

	[Address(RVA = "0x12BC5F0", Offset = "0x12BB7F0", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000098")]
	public override Byte[] get_PublicKey() { }

	[Address(RVA = "0x12BC890", Offset = "0x12BBA90", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600009B")]
	public override Byte[] get_RawData() { }

	[Address(RVA = "0x12BC670", Offset = "0x12BB870", Length = "0x218")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ASN1))]
	[Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(X509Certificate), Member = "GetUnsignedBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(RSACryptoServiceProvider), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000099")]
	public override RSA get_RSA() { }

	[Address(RVA = "0x12BC910", Offset = "0x12BBB10", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600009C")]
	public override Byte[] get_SerialNumber() { }

	[Address(RVA = "0x12BC9A0", Offset = "0x12BBBA0", Length = "0x422")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ASN1))]
	[Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600009D")]
	public override Byte[] get_Signature() { }

	[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600009E")]
	public override string get_SubjectName() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x600009F")]
	public override DateTime get_ValidFrom() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000A0")]
	public override DateTime get_ValidUntil() { }

	[Address(RVA = "0x508E80", Offset = "0x508080", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000A1")]
	public int get_Version() { }

	[Address(RVA = "0x12BAAA0", Offset = "0x12B9CA0", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000A8")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x12BAB00", Offset = "0x12B9D00", Length = "0x9D")]
	[CalledBy(Type = typeof(X509Certificate), Member = "get_DSA", ReturnType = typeof(DSA))]
	[CalledBy(Type = typeof(X509Certificate), Member = "get_RSA", ReturnType = typeof(RSA))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600008F")]
	private Byte[] GetUnsignedBigInteger(Byte[] integer) { }

	[Address(RVA = "0x12BACC0", Offset = "0x12B9EC0", Length = "0x9A5")]
	[CalledBy(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_class_get_static_field_data")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(X509ExtensionCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ASN1Convert), Member = "ToOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002FA0")]
	[Calls(Type = typeof(ASN1Convert), Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(X501), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ASN1)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ASN1), Member = "Element", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(byte)}, ReturnType = typeof(ASN1))]
	[Calls(Type = typeof(Array), Member = "Reverse", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ASN1), Member = "get_Value", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(ASN1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ASN1))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ASN1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x600008D")]
	private void Parse(Byte[] data) { }

	[Address(RVA = "0x12BABA0", Offset = "0x12B9DA0", Length = "0x116")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Convert), Member = "FromBase64String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000A9")]
	private static Byte[] PEM(string type, Byte[] data) { }

	[Address(RVA = "0x12BCDD0", Offset = "0x12BBFD0", Length = "0x4C")]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono", Member = "set_PrivateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509Certificate2ImplMono", Member = "ImportPkcs12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(string)}, ReturnType = typeof(X509Certificate))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000091")]
	public void set_DSA(DSA value) { }

	[Address(RVA = "0x2DD5F0", Offset = "0x2DC7F0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000097")]
	public override void set_KeyAlgorithmParameters(Byte[] value) { }

	[Address(RVA = "0x12BCE20", Offset = "0x12BC020", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600009A")]
	public override void set_RSA(RSA value) { }

	[Address(RVA = "0x12BB990", Offset = "0x12BAB90", Length = "0xD2")]
	[CalledBy(Type = typeof(X509Certificate), Member = "VerifySignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(X509Certificate), Member = "get_IsSelfSigned", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(DSASignatureDeformatter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509Certificate), Member = "get_Hash", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60000A4")]
	internal bool VerifySignature(DSA dsa) { }

	[Address(RVA = "0x12BB860", Offset = "0x12BAA60", Length = "0x128")]
	[CalledBy(Type = typeof(X509Certificate), Member = "get_IsSelfSigned", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(X509Chain), Member = "IsParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate), typeof(X509Certificate)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RSAPKCS1SignatureDeformatter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PKCS1), Member = "HashNameFromOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(X509Certificate), Member = "get_Hash", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60000A5")]
	internal bool VerifySignature(RSA rsa) { }

	[Address(RVA = "0x12BB670", Offset = "0x12BA870", Length = "0x1E8")]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Security.Cryptography.X509Certificates.X509ChainImplMono", Member = "IsSignedWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2), typeof(AsymmetricAlgorithm)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(X509Certificate), Member = "VerifySignature", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DSA)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[ContainsInvalidInstructions]
	[Token(Token = "0x60000A6")]
	public bool VerifySignature(AsymmetricAlgorithm aa) { }

	[Address(RVA = "0x12BBA70", Offset = "0x12BAC70", Length = "0xCC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "op_GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DateTime), Member = "op_LessThanOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(DateTime)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60000A3")]
	public bool WasCurrent(DateTime instant) { }

}

