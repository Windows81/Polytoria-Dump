namespace System.Security.Cryptography.X509Certificates;

[Token(Token = "0x200012C")]
internal class X509Certificate2ImplMono : X509Certificate2ImplUnix
{
	[Token(Token = "0x400058A")]
	private static string empty_error; //Field offset: 0x0
	[Token(Token = "0x400058B")]
	private static Byte[] signedData; //Field offset: 0x8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000588")]
	private X509CertificateImplCollection intermediateCerts; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000589")]
	private X509Certificate _cert; //Field offset: 0xB8

	[Token(Token = "0x17000132")]
	private X509Certificate Cert
	{
		[Address(RVA = "0x174C320", Offset = "0x174B520", Length = "0x1D")]
		[CallerCount(Count = 1)]
		[Calls(Type = "System.Security.Cryptography.X509Certificates.X509CertificateImpl", Member = "ThrowIfContextInvalid", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6000719")]
		private get { } //Length: 29
	}

	[Token(Token = "0x17000133")]
	public virtual bool HasPrivateKey
	{
		[Address(RVA = "0x1785CA0", Offset = "0x1784EA0", Length = "0x22")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600071B")]
		 get { } //Length: 34
	}

	[Token(Token = "0x17000135")]
	internal virtual X509CertificateImplCollection IntermediateCertificates
	{
		[Address(RVA = "0x2DD1F0", Offset = "0x2DC3F0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000723")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000131")]
	public virtual bool IsValid
	{
		[Address(RVA = "0x174C2F0", Offset = "0x174B4F0", Length = "0xC")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x6000714")]
		 get { } //Length: 12
	}

	[Token(Token = "0x17000136")]
	internal X509Certificate MonoCertificate
	{
		[Address(RVA = "0x2DD1E0", Offset = "0x2DC3E0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000724")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000134")]
	public virtual AsymmetricAlgorithm PrivateKey
	{
		[Address(RVA = "0x1785CD0", Offset = "0x1784ED0", Length = "0x43F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(X509Certificate), Member = "get_DSA", ReturnType = typeof(DSA))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_class_get_static_field_data")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(DSACryptoServiceProvider), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(DSACryptoServiceProvider), Member = "get_PublicOnly", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(RSAManaged), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(RSAManaged), Member = "get_PublicOnly", ReturnType = typeof(bool))]
		[Calls(Type = typeof(RSACryptoServiceProvider), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(RSACryptoServiceProvider), Member = "get_PublicOnly", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsUnknownMethods(Count = 10)]
		[Token(Token = "0x600071C")]
		 get { } //Length: 1087
		[Address(RVA = "0x1786120", Offset = "0x1785320", Length = "0x25F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(X509Certificate), Member = "set_DSA", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DSA)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_class_get_static_field_data")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x600071D")]
		 set { } //Length: 607
	}

	[Address(RVA = "0x1785870", Offset = "0x1784A70", Length = "0xD2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000725")]
	private static X509Certificate2ImplMono() { }

	[Address(RVA = "0x1785BA0", Offset = "0x1784DA0", Length = "0x37")]
	[CalledBy(Type = typeof(X509Certificate2ImplMono), Member = "ImportPkcs12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(string)}, ReturnType = typeof(X509Certificate))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000715")]
	public X509Certificate2ImplMono(X509Certificate cert) { }

	[Address(RVA = "0x1785BE0", Offset = "0x1784DE0", Length = "0xB4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(X509CertificateImplCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateImplCollection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000716")]
	private X509Certificate2ImplMono(X509Certificate2ImplMono other) { }

	[Address(RVA = "0x1785950", Offset = "0x1784B50", Length = "0x234")]
	[CalledBy(Type = typeof(X509PalImpl), Member = "ImportFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(X509Certificate2Impl))]
	[CalledBy(Type = typeof(X509PalImpl), Member = "ImportFallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle", typeof(X509KeyStorageFlags)}, ReturnType = typeof(X509Certificate2Impl))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(AuthenticodeDeformatter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(X509Certificate2ImplMono), Member = "ImportPkcs12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(string)}, ReturnType = typeof(X509Certificate))]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = "Microsoft.Win32.SafeHandles.SafePasswordHandle", Member = "Mono_DangerousGetString", ReturnType = typeof(string))]
	[Calls(Type = typeof(X509PalImpl), Member = "GetCertContentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(X509ContentType))]
	[Calls(Type = typeof(X509Pal), Member = "get_Instance", ReturnType = typeof(X509PalImpl))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000717")]
	public X509Certificate2ImplMono(Byte[] rawData, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	[Address(RVA = "0x1784D10", Offset = "0x1783F10", Length = "0xEC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "System.Security.Cryptography.X509Certificates.X509CertificateImpl", Member = "ThrowIfContextInvalid", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(X509CertificateImplCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateImplCollection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000718")]
	public virtual X509CertificateImpl Clone() { }

	[Address(RVA = "0x174C320", Offset = "0x174B520", Length = "0x1D")]
	[CallerCount(Count = 1)]
	[Calls(Type = "System.Security.Cryptography.X509Certificates.X509CertificateImpl", Member = "ThrowIfContextInvalid", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000719")]
	private X509Certificate get_Cert() { }

	[Address(RVA = "0x1785CA0", Offset = "0x1784EA0", Length = "0x22")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600071B")]
	public virtual bool get_HasPrivateKey() { }

	[Address(RVA = "0x2DD1F0", Offset = "0x2DC3F0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000723")]
	internal virtual X509CertificateImplCollection get_IntermediateCertificates() { }

	[Address(RVA = "0x174C2F0", Offset = "0x174B4F0", Length = "0xC")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000714")]
	public virtual bool get_IsValid() { }

	[Address(RVA = "0x2DD1E0", Offset = "0x2DC3E0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000724")]
	internal X509Certificate get_MonoCertificate() { }

	[Address(RVA = "0x1785CD0", Offset = "0x1784ED0", Length = "0x43F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RSACryptoServiceProvider), Member = "get_PublicOnly", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RSACryptoServiceProvider), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(RSAManaged), Member = "get_PublicOnly", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RSAManaged), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(DSACryptoServiceProvider), Member = "get_PublicOnly", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DSACryptoServiceProvider), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_class_get_static_field_data")]
	[Calls(Type = typeof(X509Certificate), Member = "get_DSA", ReturnType = typeof(DSA))]
	[CallsUnknownMethods(Count = 10)]
	[Token(Token = "0x600071C")]
	public virtual AsymmetricAlgorithm get_PrivateKey() { }

	[Address(RVA = "0x1784E00", Offset = "0x1784000", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600071F")]
	public virtual DSA GetDSAPrivateKey() { }

	[Address(RVA = "0x1784F20", Offset = "0x1784120", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = "System.Security.Cryptography.X509Certificates.X509CertificateImpl", Member = "ThrowIfContextInvalid", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600071A")]
	protected virtual Byte[] GetRawCertData() { }

	[Address(RVA = "0x1784E90", Offset = "0x1784090", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600071E")]
	public virtual RSA GetRSAPrivateKey() { }

	[Address(RVA = "0x1785670", Offset = "0x1784870", Length = "0x66")]
	[CallerCount(Count = 0)]
	[Calls(Type = "Microsoft.Win32.SafeHandles.SafePasswordHandle", Member = "Mono_DangerousGetString", ReturnType = typeof(string))]
	[Calls(Type = typeof(X509Certificate2ImplMono), Member = "ImportPkcs12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(string)}, ReturnType = typeof(X509Certificate))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000720")]
	private X509Certificate ImportPkcs12(Byte[] rawData, SafePasswordHandle password) { }

	[Address(RVA = "0x1784F70", Offset = "0x1784170", Length = "0x6F0")]
	[CalledBy(Type = typeof(X509Certificate2ImplMono), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle", typeof(X509KeyStorageFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509Certificate2ImplMono), Member = "ImportPkcs12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle"}, ReturnType = typeof(X509Certificate))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(X509CertificateEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(X509CertificateImplCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509CertificateImpl", typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509Certificate2ImplMono), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(X509CertificateCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(X509Certificate))]
	[Calls(Type = typeof(X509Certificate), Member = "set_DSA", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DSA)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
	[Calls(Type = typeof(X509Certificate), Member = "get_DSA", ReturnType = typeof(DSA))]
	[Calls(Type = typeof(X509CertificateCollection), Member = "GetEnumerator", ReturnType = typeof(X509CertificateEnumerator))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(PKCS12), Member = "get_Keys", ReturnType = typeof(ArrayList))]
	[Calls(Type = typeof(PKCS12), Member = "get_Certificates", ReturnType = typeof(X509CertificateCollection))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(PKCS12), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(X509CertificateEnumerator), Member = "get_Current", ReturnType = typeof(X509Certificate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 8)]
	[Token(Token = "0x6000721")]
	private X509Certificate ImportPkcs12(Byte[] rawData, string password) { }

	[Address(RVA = "0x1786120", Offset = "0x1785320", Length = "0x25F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(X509Certificate), Member = "set_DSA", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DSA)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_class_get_static_field_data")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600071D")]
	public virtual void set_PrivateKey(AsymmetricAlgorithm value) { }

	[Address(RVA = "0x17856E0", Offset = "0x17848E0", Length = "0x18C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(X509Helper2), Member = "GetInvalidChainContextException", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(X509ChainImplMono), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002030")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_class_get_static_field_data")]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[MonoTODO("by default this depends on the incomplete X509Chain")]
	[Token(Token = "0x6000722")]
	public virtual bool Verify(X509Certificate2 thisCertificate) { }

}

