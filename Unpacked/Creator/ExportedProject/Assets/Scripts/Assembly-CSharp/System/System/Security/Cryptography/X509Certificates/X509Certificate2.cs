namespace System.Security.Cryptography.X509Certificates;

[Token(Token = "0x2000128")]
public class X509Certificate2 : X509Certificate
{
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400057E")]
	private Byte[] lazyRawData; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400057F")]
	private Oid lazySignatureAlgorithm; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000580")]
	private int lazyVersion; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000581")]
	private X500DistinguishedName lazySubjectName; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000582")]
	private X500DistinguishedName lazyIssuerName; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000583")]
	private PublicKey lazyPublicKey; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000584")]
	private AsymmetricAlgorithm lazyPrivateKey; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000585")]
	private X509ExtensionCollection lazyExtensions; //Field offset: 0x98

	[Token(Token = "0x17000119")]
	public X509ExtensionCollection Extensions
	{
		[Address(RVA = "0x1788270", Offset = "0x1787470", Length = "0x349")]
		[CalledBy(Type = typeof(X509ChainImplMono), Member = "GetSubjectKeyIdentifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(X509Certificate2), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(X509Certificate2Collection), Member = "GetKeyIdentifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(X509Certificate2Collection), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509FindType), typeof(object), typeof(bool)}, ReturnType = typeof(X509Certificate2Collection))]
		[CalledBy(Type = typeof(X509ChainImplMono), Member = "SelectBestFromCollection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2), typeof(X509Certificate2Collection)}, ReturnType = typeof(X509Certificate2))]
		[CalledBy(Type = typeof(X509ChainImplMono), Member = "PrepareForNextCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(X509ChainImplMono), Member = "ProcessCertificateExtensions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509ChainElement)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(CertificateHelper), Member = "IsValidClientCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(X509ChainImplMono), Member = "CheckRevocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2), typeof(X509Certificate2), typeof(bool)}, ReturnType = typeof(X509ChainStatusFlags))]
		[CalledBy(Type = typeof(X509ChainImplMono), Member = "FindCrl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(X509Crl))]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(X509Certificate2), Member = "CreateCustomExtensionIfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Oid)}, ReturnType = typeof(X509Extension))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(X509Certificate2), Member = "get_Impl", ReturnType = typeof(X509Certificate2Impl))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(X509Certificate), Member = "ThrowIfInvalid", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		[Token(Token = "0x60006E4")]
		 get { } //Length: 841
	}

	[Token(Token = "0x1700011A")]
	public bool HasPrivateKey
	{
		[Address(RVA = "0x17885C0", Offset = "0x17877C0", Length = "0x40")]
		[CalledBy(Type = typeof(CertificateHelper), Member = "GetEligibleClientCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateCollection)}, ReturnType = typeof(X509Certificate2))]
		[CalledBy(Type = typeof(CertificateHelper), Member = "GetEligibleClientCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2Collection)}, ReturnType = typeof(X509Certificate2))]
		[CalledBy(Type = typeof(CertificateHelper), Member = "GetEligibleClientCertificate", ReturnType = typeof(X509Certificate2))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(X509Certificate), Member = "ThrowIfInvalid", ReturnType = typeof(void))]
		[Calls(Type = typeof(X509Certificate2), Member = "get_Impl", ReturnType = typeof(X509Certificate2Impl))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60006E5")]
		 get { } //Length: 64
	}

	[Token(Token = "0x17000126")]
	internal X509Certificate2Impl Impl
	{
		[Address(RVA = "0x1788610", Offset = "0x1787810", Length = "0x7C")]
		[CalledBy(Type = typeof(X509Certificate2), Member = "GetNameInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509NameType), typeof(bool)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(X509ChainImplMono), Member = "PrepareForNextCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(X509ChainImplMono), Member = "IsChainComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(X509ChainImplMono), Member = "BuildChainFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(X509ChainStatusFlags))]
		[CalledBy(Type = typeof(X509Certificate2Collection), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509FindType), typeof(object), typeof(bool)}, ReturnType = typeof(X509Certificate2Collection))]
		[CalledBy(Type = typeof(X509Certificate2), Member = "Verify", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(X509Certificate2), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(X509Helper2), Member = "GetMonoCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(X509Certificate))]
		[CalledBy(Type = typeof(X509Certificate2), Member = "get_Version", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(X509Certificate2), Member = "get_SignatureAlgorithm", ReturnType = typeof(Oid))]
		[CalledBy(Type = typeof(X509Certificate2), Member = "get_RawData", ReturnType = typeof(Byte[]))]
		[CalledBy(Type = typeof(X509Certificate2), Member = "get_IssuerName", ReturnType = typeof(X500DistinguishedName))]
		[CalledBy(Type = typeof(X509Certificate2), Member = "get_PrivateKey", ReturnType = typeof(AsymmetricAlgorithm))]
		[CalledBy(Type = typeof(X509Certificate2), Member = "get_HasPrivateKey", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(X509Certificate2), Member = "get_Extensions", ReturnType = typeof(X509ExtensionCollection))]
		[CalledBy(Type = typeof(X509Certificate2), Member = "get_SubjectName", ReturnType = typeof(X500DistinguishedName))]
		[CalledBy(Type = typeof(X509Store), Member = "Open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OpenFlags)}, ReturnType = typeof(void))]
		[CallerCount(Count = 28)]
		[Calls(Type = "System.Security.Cryptography.X509Certificates.X509Helper", Member = "ThrowIfContextInvalid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509CertificateImpl"}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60006F7")]
		internal get { } //Length: 124
	}

	[Token(Token = "0x1700011C")]
	public X500DistinguishedName IssuerName
	{
		[Address(RVA = "0x1788690", Offset = "0x1787890", Length = "0x7B")]
		[CalledBy(Type = typeof(MonoBtlsContext), Member = "SetPrivateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateImplBtls)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(X509Certificate2), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(X509ChainImplMono), Member = "ValidateChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509ChainStatusFlags)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(X509ChainImplMono), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(X509Certificate), Member = "ThrowIfInvalid", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(X509Certificate2), Member = "get_Impl", ReturnType = typeof(X509Certificate2Impl))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60006E7")]
		 get { } //Length: 123
	}

	[Token(Token = "0x1700011D")]
	public DateTime NotAfter
	{
		[Address(RVA = "0x1788710", Offset = "0x1787910", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(X509Certificate), Member = "GetNotAfter", ReturnType = typeof(DateTime))]
		[Token(Token = "0x60006E8")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700011E")]
	public DateTime NotBefore
	{
		[Address(RVA = "0x1788720", Offset = "0x1787920", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(X509Certificate), Member = "GetNotBefore", ReturnType = typeof(DateTime))]
		[Token(Token = "0x60006E9")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700011B")]
	public AsymmetricAlgorithm PrivateKey
	{
		[Address(RVA = "0x1788730", Offset = "0x1787930", Length = "0x1B1")]
		[CalledBy(Type = typeof(UnityTlsContext), Member = "ExtractNativeKeyAndChainFromManagedCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate), typeof(unitytls_errorstate*), typeof(unitytls_x509list*&), typeof(unitytls_key*&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(X509Certificate), Member = "ThrowIfInvalid", ReturnType = typeof(void))]
		[Calls(Type = typeof(X509Certificate2), Member = "get_Impl", ReturnType = typeof(X509Certificate2Impl))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		[Token(Token = "0x60006E6")]
		 get { } //Length: 433
	}

	[Token(Token = "0x1700011F")]
	public PublicKey PublicKey
	{
		[Address(RVA = "0x17888F0", Offset = "0x1787AF0", Length = "0x188")]
		[CalledBy(Type = typeof(RSACertificateExtensions), Member = "GetRSAPublicKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(RSA))]
		[CalledBy(Type = typeof(X509Certificate2), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(X509Certificate2Collection), Member = "GetKeyIdentifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(X509ChainImplMono), Member = "ValidateChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509ChainStatusFlags)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(X509ChainImplMono), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(X509ChainImplMono), Member = "PrepareForNextCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(X509ChainImplMono), Member = "CheckRevocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2), typeof(X509Certificate2), typeof(bool)}, ReturnType = typeof(X509ChainStatusFlags))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(X509Certificate), Member = "ThrowIfInvalid", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Oid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(AsnEncodedData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Oid), typeof(Byte[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(PublicKey), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Oid), typeof(AsnEncodedData), typeof(AsnEncodedData)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[Token(Token = "0x60006EA")]
		 get { } //Length: 392
	}

	[Token(Token = "0x17000120")]
	public Byte[] RawData
	{
		[Address(RVA = "0x1788A80", Offset = "0x1787C80", Length = "0x79")]
		[CalledBy(Type = typeof(MonoBtlsContext), Member = "SetPrivateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateImplBtls)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(X509Certificate), Member = "ThrowIfInvalid", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(X509Certificate2), Member = "get_Impl", ReturnType = typeof(X509Certificate2Impl))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = "Internal.Cryptography.Helpers", Member = "CloneByteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60006EB")]
		 get { } //Length: 121
	}

	[Token(Token = "0x17000121")]
	public string SerialNumber
	{
		[Address(RVA = "0xCF4F90", Offset = "0xCF4190", Length = "0x14")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006EC")]
		 get { } //Length: 20
	}

	[Token(Token = "0x17000122")]
	public Oid SignatureAlgorithm
	{
		[Address(RVA = "0x1788B00", Offset = "0x1787D00", Length = "0x1C0")]
		[CalledBy(Type = typeof(X509Certificate2), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(OidLookup), Member = "ToFriendlyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(OidGroup), typeof(bool)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(X509Certificate2), Member = "get_Impl", ReturnType = typeof(X509Certificate2Impl))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(X509Certificate), Member = "ThrowIfInvalid", ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60006ED")]
		 get { } //Length: 448
	}

	[Token(Token = "0x17000123")]
	public X500DistinguishedName SubjectName
	{
		[Address(RVA = "0x1788CD0", Offset = "0x1787ED0", Length = "0x72")]
		[CalledBy(Type = typeof(MonoBtlsContext), Member = "SetPrivateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateImplBtls)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(X509Certificate2), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(X509Certificate2Collection), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509FindType), typeof(object), typeof(bool)}, ReturnType = typeof(X509Certificate2Collection))]
		[CalledBy(Type = typeof(X509ChainImplMono), Member = "PrepareForNextCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(X509ChainImplMono), Member = "FindCrl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(X509Crl))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(X509Certificate), Member = "ThrowIfInvalid", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(X509Certificate2), Member = "get_Impl", ReturnType = typeof(X509Certificate2Impl))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60006EE")]
		 get { } //Length: 114
	}

	[Token(Token = "0x17000124")]
	public string Thumbprint
	{
		[Address(RVA = "0x1788D50", Offset = "0x1787F50", Length = "0x25")]
		[CallerCount(Count = 0)]
		[Calls(Type = "Internal.Cryptography.Helpers", Member = "ToHexStringUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60006EF")]
		 get { } //Length: 37
	}

	[Token(Token = "0x17000125")]
	public int Version
	{
		[Address(RVA = "0x1788D80", Offset = "0x1787F80", Length = "0x61")]
		[CalledBy(Type = typeof(X509Certificate2), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(X509Certificate), Member = "ThrowIfInvalid", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
		[Calls(Type = typeof(X509Certificate2), Member = "get_Impl", ReturnType = typeof(X509Certificate2Impl))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60006F0")]
		 get { } //Length: 97
	}

	[Address(RVA = "0x17881F0", Offset = "0x17873F0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509Certificate), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x60006DD")]
	public X509Certificate2() { }

	[Address(RVA = "0x17880D0", Offset = "0x17872D0", Length = "0x106")]
	[CalledBy(Type = typeof(X509ChainImplUnityTls), Member = "get_ChainElements", ReturnType = typeof(X509ChainElementCollection))]
	[CalledBy(Type = typeof(X509Store), Member = "Open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OpenFlags)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = "Microsoft.Win32.SafeHandles.SafePasswordHandle", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = "System.Security.Cryptography.X509Certificates.X509Helper", Member = "Import", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle", typeof(X509KeyStorageFlags)}, ReturnType = "System.Security.Cryptography.X509Certificates.X509CertificateImpl")]
	[Calls(Type = typeof(X509Certificate), Member = "ImportHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509CertificateImpl"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x60006DE")]
	public X509Certificate2(Byte[] rawData) { }

	[Address(RVA = "0x17880B0", Offset = "0x17872B0", Length = "0x8")]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "SetPrivateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateImplBtls)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006DF")]
	public X509Certificate2(Byte[] rawData, string password) { }

	[Address(RVA = "0x17881E0", Offset = "0x17873E0", Length = "0x8")]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "CreateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509)}, ReturnType = typeof(X509Certificate2))]
	[CalledBy(Type = typeof(X509ChainImplBtls), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509StoreCtx)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509ChainImplBtls), Member = "get_ChainElements", ReturnType = typeof(X509ChainElementCollection))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509CertificateImpl"}, ReturnType = typeof(void))]
	[Token(Token = "0x60006E0")]
	internal X509Certificate2(X509Certificate2Impl impl) { }

	[Address(RVA = "0x1788200", Offset = "0x1787400", Length = "0x8")]
	[CalledBy(Type = "Mirror.SimpleWeb.ServerSslHelper", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.SimpleWeb.SslConfig"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.SimpleWeb.WebSocketServer", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.SimpleWeb.TcpConfig", typeof(int), typeof(int), "Mirror.SimpleWeb.SslConfig", "Mirror.SimpleWeb.BufferPool"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006E1")]
	public X509Certificate2(string fileName, string password) { }

	[Address(RVA = "0x17880C0", Offset = "0x17872C0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(void))]
	[Token(Token = "0x60006E2")]
	public X509Certificate2(X509Certificate certificate) { }

	[Address(RVA = "0x1788210", Offset = "0x1787410", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60006E3")]
	protected X509Certificate2(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1786E80", Offset = "0x1786080", Length = "0x2F8")]
	[CalledBy(Type = typeof(X509Certificate2), Member = "get_Extensions", ReturnType = typeof(X509ExtensionCollection))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(X509Pal), Member = "get_Instance", ReturnType = typeof(X509PalImpl))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(X509BasicConstraintsExtension), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 10)]
	[Token(Token = "0x60006F6")]
	private static X509Extension CreateCustomExtensionIfAny(Oid oid) { }

	[Address(RVA = "0x1788270", Offset = "0x1787470", Length = "0x349")]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "FindCrl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(X509Crl))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "CheckRevocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2), typeof(X509Certificate2), typeof(bool)}, ReturnType = typeof(X509ChainStatusFlags))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "ProcessCertificateExtensions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509ChainElement)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "PrepareForNextCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CertificateHelper), Member = "IsValidClientCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(X509Certificate2Collection), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509FindType), typeof(object), typeof(bool)}, ReturnType = typeof(X509Certificate2Collection))]
	[CalledBy(Type = typeof(X509Certificate2Collection), Member = "GetKeyIdentifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(X509Certificate2), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "GetSubjectKeyIdentifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "SelectBestFromCollection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2), typeof(X509Certificate2Collection)}, ReturnType = typeof(X509Certificate2))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(X509Certificate), Member = "ThrowIfInvalid", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(X509Certificate2), Member = "get_Impl", ReturnType = typeof(X509Certificate2Impl))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(X509Certificate2), Member = "CreateCustomExtensionIfAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Oid)}, ReturnType = typeof(X509Extension))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x60006E4")]
	public X509ExtensionCollection get_Extensions() { }

	[Address(RVA = "0x17885C0", Offset = "0x17877C0", Length = "0x40")]
	[CalledBy(Type = typeof(CertificateHelper), Member = "GetEligibleClientCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateCollection)}, ReturnType = typeof(X509Certificate2))]
	[CalledBy(Type = typeof(CertificateHelper), Member = "GetEligibleClientCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2Collection)}, ReturnType = typeof(X509Certificate2))]
	[CalledBy(Type = typeof(CertificateHelper), Member = "GetEligibleClientCertificate", ReturnType = typeof(X509Certificate2))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(X509Certificate), Member = "ThrowIfInvalid", ReturnType = typeof(void))]
	[Calls(Type = typeof(X509Certificate2), Member = "get_Impl", ReturnType = typeof(X509Certificate2Impl))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60006E5")]
	public bool get_HasPrivateKey() { }

	[Address(RVA = "0x1788610", Offset = "0x1787810", Length = "0x7C")]
	[CalledBy(Type = typeof(X509Store), Member = "Open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OpenFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509Certificate2), Member = "get_SubjectName", ReturnType = typeof(X500DistinguishedName))]
	[CalledBy(Type = typeof(X509Certificate2), Member = "get_Extensions", ReturnType = typeof(X509ExtensionCollection))]
	[CalledBy(Type = typeof(X509Certificate2), Member = "get_HasPrivateKey", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(X509Certificate2), Member = "get_PrivateKey", ReturnType = typeof(AsymmetricAlgorithm))]
	[CalledBy(Type = typeof(X509Certificate2), Member = "get_IssuerName", ReturnType = typeof(X500DistinguishedName))]
	[CalledBy(Type = typeof(X509Certificate2), Member = "get_RawData", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(X509Certificate2), Member = "get_Version", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(X509Certificate2), Member = "get_SignatureAlgorithm", ReturnType = typeof(Oid))]
	[CalledBy(Type = typeof(X509Certificate2), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(X509Certificate2), Member = "Verify", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(X509Certificate2Collection), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509FindType), typeof(object), typeof(bool)}, ReturnType = typeof(X509Certificate2Collection))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "BuildChainFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(X509ChainStatusFlags))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "IsChainComplete", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "PrepareForNextCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509Certificate2), Member = "GetNameInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509NameType), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(X509Helper2), Member = "GetMonoCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(X509Certificate))]
	[CallerCount(Count = 28)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "System.Security.Cryptography.X509Certificates.X509Helper", Member = "ThrowIfContextInvalid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509CertificateImpl"}, ReturnType = typeof(void))]
	[Token(Token = "0x60006F7")]
	internal X509Certificate2Impl get_Impl() { }

	[Address(RVA = "0x1788690", Offset = "0x1787890", Length = "0x7B")]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "SetPrivateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateImplBtls)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509Certificate2), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "ValidateChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509ChainStatusFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(X509Certificate), Member = "ThrowIfInvalid", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(X509Certificate2), Member = "get_Impl", ReturnType = typeof(X509Certificate2Impl))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60006E7")]
	public X500DistinguishedName get_IssuerName() { }

	[Address(RVA = "0x1788710", Offset = "0x1787910", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509Certificate), Member = "GetNotAfter", ReturnType = typeof(DateTime))]
	[Token(Token = "0x60006E8")]
	public DateTime get_NotAfter() { }

	[Address(RVA = "0x1788720", Offset = "0x1787920", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509Certificate), Member = "GetNotBefore", ReturnType = typeof(DateTime))]
	[Token(Token = "0x60006E9")]
	public DateTime get_NotBefore() { }

	[Address(RVA = "0x1788730", Offset = "0x1787930", Length = "0x1B1")]
	[CalledBy(Type = typeof(UnityTlsContext), Member = "ExtractNativeKeyAndChainFromManagedCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate), typeof(unitytls_errorstate*), typeof(unitytls_x509list*&), typeof(unitytls_key*&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(X509Certificate), Member = "ThrowIfInvalid", ReturnType = typeof(void))]
	[Calls(Type = typeof(X509Certificate2), Member = "get_Impl", ReturnType = typeof(X509Certificate2Impl))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60006E6")]
	public AsymmetricAlgorithm get_PrivateKey() { }

	[Address(RVA = "0x17888F0", Offset = "0x1787AF0", Length = "0x188")]
	[CalledBy(Type = typeof(RSACertificateExtensions), Member = "GetRSAPublicKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(RSA))]
	[CalledBy(Type = typeof(X509Certificate2), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(X509Certificate2Collection), Member = "GetKeyIdentifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "ValidateChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509ChainStatusFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "PrepareForNextCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "CheckRevocation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2), typeof(X509Certificate2), typeof(bool)}, ReturnType = typeof(X509ChainStatusFlags))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(PublicKey), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Oid), typeof(AsnEncodedData), typeof(AsnEncodedData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AsnEncodedData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Oid), typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Oid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(X509Certificate), Member = "ThrowIfInvalid", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60006EA")]
	public PublicKey get_PublicKey() { }

	[Address(RVA = "0x1788A80", Offset = "0x1787C80", Length = "0x79")]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "SetPrivateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateImplBtls)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(X509Certificate), Member = "ThrowIfInvalid", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(X509Certificate2), Member = "get_Impl", ReturnType = typeof(X509Certificate2Impl))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = "Internal.Cryptography.Helpers", Member = "CloneByteArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60006EB")]
	public Byte[] get_RawData() { }

	[Address(RVA = "0xCF4F90", Offset = "0xCF4190", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006EC")]
	public string get_SerialNumber() { }

	[Address(RVA = "0x1788B00", Offset = "0x1787D00", Length = "0x1C0")]
	[CalledBy(Type = typeof(X509Certificate2), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509Certificate), Member = "ThrowIfInvalid", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(X509Certificate2), Member = "get_Impl", ReturnType = typeof(X509Certificate2Impl))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(OidLookup), Member = "ToFriendlyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(OidGroup), typeof(bool)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60006ED")]
	public Oid get_SignatureAlgorithm() { }

	[Address(RVA = "0x1788CD0", Offset = "0x1787ED0", Length = "0x72")]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "SetPrivateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateImplBtls)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509Certificate2), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(X509Certificate2Collection), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509FindType), typeof(object), typeof(bool)}, ReturnType = typeof(X509Certificate2Collection))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "PrepareForNextCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "FindCrl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(X509Crl))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(X509Certificate), Member = "ThrowIfInvalid", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(X509Certificate2), Member = "get_Impl", ReturnType = typeof(X509Certificate2Impl))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60006EE")]
	public X500DistinguishedName get_SubjectName() { }

	[Address(RVA = "0x1788D50", Offset = "0x1787F50", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Calls(Type = "Internal.Cryptography.Helpers", Member = "ToHexStringUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60006EF")]
	public string get_Thumbprint() { }

	[Address(RVA = "0x1788D80", Offset = "0x1787F80", Length = "0x61")]
	[CalledBy(Type = typeof(X509Certificate2), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(X509Certificate), Member = "ThrowIfInvalid", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(X509Certificate2), Member = "get_Impl", ReturnType = typeof(X509Certificate2Impl))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60006F0")]
	public int get_Version() { }

	[Address(RVA = "0x1787180", Offset = "0x1786380", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509Pal), Member = "get_Instance", ReturnType = typeof(X509PalImpl))]
	[Calls(Type = typeof(X509PalImpl), Member = "GetCertContentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(X509ContentType))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006F1")]
	public static X509ContentType GetCertContentType(Byte[] rawData) { }

	[Address(RVA = "0x1787220", Offset = "0x1786420", Length = "0x48")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509Certificate2), Member = "get_Impl", ReturnType = typeof(X509Certificate2Impl))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60006F2")]
	public string GetNameInfo(X509NameType nameType, bool forIssuer) { }

	[Address(RVA = "0x1787270", Offset = "0x1786470", Length = "0xCF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE990")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(X509Certificate), Member = "Reset", ReturnType = typeof(void))]
	[Token(Token = "0x60006DC")]
	public virtual void Reset() { }

	[Address(RVA = "0x1788060", Offset = "0x1787260", Length = "0xA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509Certificate), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[Token(Token = "0x60006F3")]
	public virtual string ToString() { }

	[Address(RVA = "0x1787340", Offset = "0x1786540", Length = "0xD13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509Certificate), Member = "GetNotBefore", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(X509ExtensionCollection), Member = "GetEnumerator", ReturnType = typeof(X509ExtensionEnumerator))]
	[Calls(Type = typeof(X509Certificate2), Member = "get_Extensions", ReturnType = typeof(X509ExtensionCollection))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(RSACertificateExtensions), Member = "GetRSAPublicKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(RSA))]
	[Calls(Type = typeof(X509Certificate2), Member = "get_PublicKey", ReturnType = typeof(PublicKey))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(Oid), Member = "get_FriendlyName", ReturnType = typeof(string))]
	[Calls(Type = typeof(X509Certificate2), Member = "get_SignatureAlgorithm", ReturnType = typeof(Oid))]
	[Calls(Type = "Internal.Cryptography.Helpers", Member = "ToHexStringUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(X509Certificate), Member = "GetNotAfter", ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(X509Certificate), Member = "FormatDate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(X509Certificate2), Member = "get_IssuerName", ReturnType = typeof(X500DistinguishedName))]
	[Calls(Type = typeof(X509Certificate2), Member = "get_Impl", ReturnType = typeof(X509Certificate2Impl))]
	[Calls(Type = typeof(X509Certificate2), Member = "get_SubjectName", ReturnType = typeof(X500DistinguishedName))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendLine", ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(X509Certificate2), Member = "get_Version", ReturnType = typeof(int))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(X509Certificate), Member = "get_IsValid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(X509ExtensionEnumerator), Member = "get_Current", ReturnType = typeof(X509Extension))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 17)]
	[Token(Token = "0x60006F4")]
	public virtual string ToString(bool verbose) { }

	[Address(RVA = "0x1788070", Offset = "0x1787270", Length = "0x39")]
	[CalledBy(Type = typeof(X509Certificate2Collection), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509FindType), typeof(object), typeof(bool)}, ReturnType = typeof(X509Certificate2Collection))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(X509Certificate2), Member = "get_Impl", ReturnType = typeof(X509Certificate2Impl))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60006F5")]
	public bool Verify() { }

}

