namespace System.Security.Cryptography.X509Certificates;

[Token(Token = "0x200012D")]
internal abstract class X509Certificate2ImplUnix : X509Certificate2Impl
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400058C")]
	private bool readCertData; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400058D")]
	private CertificateData certData; //Field offset: 0x18

	[Token(Token = "0x17000143")]
	public virtual IEnumerable<X509Extension> Extensions
	{
		[Address(RVA = "0x1786B50", Offset = "0x1785D50", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
		[Token(Token = "0x6000735")]
		 get { } //Length: 29
	}

	[Token(Token = "0x17000140")]
	public virtual string Issuer
	{
		[Address(RVA = "0x1786B90", Offset = "0x1785D90", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000731")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700013E")]
	public virtual X500DistinguishedName IssuerName
	{
		[Address(RVA = "0x1786B70", Offset = "0x1785D70", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
		[Token(Token = "0x600072F")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000137")]
	public virtual string KeyAlgorithm
	{
		[Address(RVA = "0x1786BE0", Offset = "0x1785DE0", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
		[Token(Token = "0x6000728")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000138")]
	public virtual Byte[] KeyAlgorithmParameters
	{
		[Address(RVA = "0x1786BC0", Offset = "0x1785DC0", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
		[Token(Token = "0x6000729")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000144")]
	public virtual DateTime NotAfter
	{
		[Address(RVA = "0x1786C00", Offset = "0x1785E00", Length = "0x54")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(DateTime), Member = "ToLocalTime", ReturnType = typeof(DateTime))]
		[Token(Token = "0x6000736")]
		 get { } //Length: 84
	}

	[Token(Token = "0x17000145")]
	public virtual DateTime NotBefore
	{
		[Address(RVA = "0x1786C60", Offset = "0x1785E60", Length = "0x54")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(DateTime), Member = "ToLocalTime", ReturnType = typeof(DateTime))]
		[Token(Token = "0x6000737")]
		 get { } //Length: 84
	}

	[Token(Token = "0x17000139")]
	public virtual Byte[] PublicKeyValue
	{
		[Address(RVA = "0x1786CC0", Offset = "0x1785EC0", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
		[Token(Token = "0x600072A")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000141")]
	public virtual Byte[] RawData
	{
		[Address(RVA = "0x1786CE0", Offset = "0x1785EE0", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
		[Token(Token = "0x6000732")]
		 get { } //Length: 26
	}

	[Token(Token = "0x1700013A")]
	public virtual Byte[] SerialNumber
	{
		[Address(RVA = "0x1786D00", Offset = "0x1785F00", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
		[Token(Token = "0x600072B")]
		 get { } //Length: 26
	}

	[Token(Token = "0x1700013B")]
	public virtual string SignatureAlgorithm
	{
		[Address(RVA = "0x1786D20", Offset = "0x1785F20", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
		[Token(Token = "0x600072C")]
		 get { } //Length: 29
	}

	[Token(Token = "0x1700013F")]
	public virtual string Subject
	{
		[Address(RVA = "0x1786D60", Offset = "0x1785F60", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000730")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700013D")]
	public virtual X500DistinguishedName SubjectName
	{
		[Address(RVA = "0x1786D40", Offset = "0x1785F40", Length = "0x1A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
		[Token(Token = "0x600072E")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000142")]
	public virtual Byte[] Thumbprint
	{
		[Address(RVA = "0x1786D90", Offset = "0x1785F90", Length = "0xCA")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
		[Calls(Type = typeof(SHA1), Member = "Create", ReturnType = typeof(SHA1))]
		[Calls(Type = typeof(HashAlgorithm), Member = "ComputeHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[Token(Token = "0x6000733")]
		 get { } //Length: 202
	}

	[Token(Token = "0x1700013C")]
	public virtual int Version
	{
		[Address(RVA = "0x1786E60", Offset = "0x1786060", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
		[Token(Token = "0x600072D")]
		 get { } //Length: 27
	}

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600073C")]
	protected X509Certificate2ImplUnix() { }

	[Address(RVA = "0x1786380", Offset = "0x1785580", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(StringBuilder), Member = "AppendLine", ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendLine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000738")]
	public virtual void AppendPrivateKeyInfo(StringBuilder sb) { }

	[Address(RVA = "0x1786410", Offset = "0x1785610", Length = "0x10F")]
	[CalledBy(Type = typeof(X509Certificate2ImplUnix), Member = "get_RawData", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(X509Certificate2ImplUnix), Member = "get_NotBefore", ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(X509Certificate2ImplUnix), Member = "get_NotAfter", ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(X509Certificate2ImplUnix), Member = "get_Extensions", ReturnType = typeof(System.Collections.Generic.IEnumerable`1<System.Security.Cryptography.X509Certificates.X509Extension>))]
	[CalledBy(Type = typeof(X509Certificate2ImplUnix), Member = "GetNameInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509NameType), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(X509Certificate2ImplUnix), Member = "get_Thumbprint", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(X509Certificate2ImplUnix), Member = "get_SubjectName", ReturnType = typeof(X500DistinguishedName))]
	[CalledBy(Type = typeof(X509Certificate2ImplUnix), Member = "get_IssuerName", ReturnType = typeof(X500DistinguishedName))]
	[CalledBy(Type = typeof(X509Certificate2ImplUnix), Member = "get_SignatureAlgorithm", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(X509Certificate2ImplUnix), Member = "get_SerialNumber", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(X509Certificate2ImplUnix), Member = "get_PublicKeyValue", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(X509Certificate2ImplUnix), Member = "get_KeyAlgorithmParameters", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(X509Certificate2ImplUnix), Member = "get_KeyAlgorithm", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(X509Certificate2ImplUnix), Member = "get_Version", ReturnType = typeof(int))]
	[CallerCount(Count = 14)]
	[Calls(Type = "System.Security.Cryptography.X509Certificates.X509CertificateImpl", Member = "ThrowIfContextInvalid", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CertificateData), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000726")]
	private void EnsureCertData() { }

	[Address(RVA = "0x1786990", Offset = "0x1785B90", Length = "0x17E")]
	[CallerCount(Count = 0)]
	[Calls(Type = "System.Security.Cryptography.X509Certificates.X509CertificateImpl", Member = "ThrowIfContextInvalid", ReturnType = typeof(void))]
	[Calls(Type = typeof(X509Certificate2ImplUnix), Member = "ExportPkcs12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = "Microsoft.Win32.SafeHandles.SafePasswordHandle", Member = "Mono_DangerousGetString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000739")]
	public virtual Byte[] Export(X509ContentType contentType, SafePasswordHandle password) { }

	[Address(RVA = "0x1786520", Offset = "0x1785720", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = "Microsoft.Win32.SafeHandles.SafePasswordHandle", Member = "Mono_DangerousGetString", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	[Token(Token = "0x600073A")]
	private Byte[] ExportPkcs12(SafePasswordHandle password) { }

	[Address(RVA = "0x1786580", Offset = "0x1785780", Length = "0x40F")]
	[CalledBy(Type = typeof(X509Certificate2ImplUnix), Member = "Export", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509ContentType), "Microsoft.Win32.SafeHandles.SafePasswordHandle"}, ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(PKCS12), Member = "set_Password", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(PKCS12), Member = "GetBytes", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(PKCS12), Member = "AddPkcs8ShroudedKeyBag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AsymmetricAlgorithm), typeof(IDictionary)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PKCS12), Member = "AddCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PKCS12), Member = "AddCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate), typeof(IDictionary)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PKCS12), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[Token(Token = "0x600073B")]
	private Byte[] ExportPkcs12(string password) { }

	[Address(RVA = "0x1786B50", Offset = "0x1785D50", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
	[Token(Token = "0x6000735")]
	public virtual IEnumerable<X509Extension> get_Extensions() { }

	[Address(RVA = "0x1786B90", Offset = "0x1785D90", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000731")]
	public virtual string get_Issuer() { }

	[Address(RVA = "0x1786B70", Offset = "0x1785D70", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
	[Token(Token = "0x600072F")]
	public virtual X500DistinguishedName get_IssuerName() { }

	[Address(RVA = "0x1786BE0", Offset = "0x1785DE0", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
	[Token(Token = "0x6000728")]
	public virtual string get_KeyAlgorithm() { }

	[Address(RVA = "0x1786BC0", Offset = "0x1785DC0", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
	[Token(Token = "0x6000729")]
	public virtual Byte[] get_KeyAlgorithmParameters() { }

	[Address(RVA = "0x1786C00", Offset = "0x1785E00", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "ToLocalTime", ReturnType = typeof(DateTime))]
	[Token(Token = "0x6000736")]
	public virtual DateTime get_NotAfter() { }

	[Address(RVA = "0x1786C60", Offset = "0x1785E60", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "ToLocalTime", ReturnType = typeof(DateTime))]
	[Token(Token = "0x6000737")]
	public virtual DateTime get_NotBefore() { }

	[Address(RVA = "0x1786CC0", Offset = "0x1785EC0", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
	[Token(Token = "0x600072A")]
	public virtual Byte[] get_PublicKeyValue() { }

	[Address(RVA = "0x1786CE0", Offset = "0x1785EE0", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
	[Token(Token = "0x6000732")]
	public virtual Byte[] get_RawData() { }

	[Address(RVA = "0x1786D00", Offset = "0x1785F00", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
	[Token(Token = "0x600072B")]
	public virtual Byte[] get_SerialNumber() { }

	[Address(RVA = "0x1786D20", Offset = "0x1785F20", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
	[Token(Token = "0x600072C")]
	public virtual string get_SignatureAlgorithm() { }

	[Address(RVA = "0x1786D60", Offset = "0x1785F60", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000730")]
	public virtual string get_Subject() { }

	[Address(RVA = "0x1786D40", Offset = "0x1785F40", Length = "0x1A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
	[Token(Token = "0x600072E")]
	public virtual X500DistinguishedName get_SubjectName() { }

	[Address(RVA = "0x1786D90", Offset = "0x1785F90", Length = "0xCA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
	[Calls(Type = typeof(SHA1), Member = "Create", ReturnType = typeof(SHA1))]
	[Calls(Type = typeof(HashAlgorithm), Member = "ComputeHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6000733")]
	public virtual Byte[] get_Thumbprint() { }

	[Address(RVA = "0x1786E60", Offset = "0x1786060", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
	[Token(Token = "0x600072D")]
	public virtual int get_Version() { }

	[Address(RVA = "0x1786B10", Offset = "0x1785D10", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509Certificate2ImplUnix), Member = "EnsureCertData", ReturnType = typeof(void))]
	[Calls(Type = typeof(CertificateData), Member = "GetNameInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509NameType), typeof(bool)}, ReturnType = typeof(string))]
	[Token(Token = "0x6000734")]
	public virtual string GetNameInfo(X509NameType nameType, bool forIssuer) { }

	[Token(Token = "0x6000727")]
	protected abstract Byte[] GetRawCertData() { }

}

