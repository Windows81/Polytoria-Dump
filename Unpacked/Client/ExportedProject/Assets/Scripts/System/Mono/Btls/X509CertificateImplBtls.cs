namespace Mono.Btls;

[Token(Token = "0x20000A8")]
internal class X509CertificateImplBtls : X509Certificate2ImplUnix
{
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40001F5")]
	private MonoBtlsX509 x509; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40001F6")]
	private MonoBtlsKey nativePrivateKey; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40001F7")]
	private X509CertificateImplCollection intermediateCerts; //Field offset: 0xC0

	[Token(Token = "0x17000085")]
	public virtual bool HasPrivateKey
	{
		[Address(RVA = "0x174C2F0", Offset = "0x174B4F0", Length = "0xC")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x600032B")]
		 get { } //Length: 12
	}

	[Token(Token = "0x17000084")]
	internal virtual X509CertificateImplCollection IntermediateCertificates
	{
		[Address(RVA = "0x2DD1C0", Offset = "0x2DC3C0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000329")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000081")]
	public virtual bool IsValid
	{
		[Address(RVA = "0x174C300", Offset = "0x174B500", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MonoBtlsObject), Member = "get_IsValid", ReturnType = typeof(bool))]
		[Token(Token = "0x6000324")]
		 get { } //Length: 27
	}

	[Token(Token = "0x17000083")]
	internal MonoBtlsKey NativePrivateKey
	{
		[Address(RVA = "0x174C320", Offset = "0x174B520", Length = "0x1D")]
		[CallerCount(Count = 1)]
		[Calls(Type = "System.Security.Cryptography.X509Certificates.X509CertificateImpl", Member = "ThrowIfContextInvalid", ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6000326")]
		internal get { } //Length: 29
	}

	[Token(Token = "0x17000086")]
	public virtual AsymmetricAlgorithm PrivateKey
	{
		[Address(RVA = "0x174B5D0", Offset = "0x174A7D0", Length = "0x34")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MonoBtlsKey), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(PrivateKeyInfo), Member = "DecodeRSA", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(RSA))]
		[DeduplicatedMethod]
		[Token(Token = "0x600032C")]
		 get { } //Length: 52
		[Address(RVA = "0x174C360", Offset = "0x174B560", Length = "0xCE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(MonoBtlsObject), Member = "Dispose", ReturnType = typeof(void))]
		[Calls(Type = typeof(MonoBtlsKey), Member = "CreateFromRSAPrivateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RSA)}, ReturnType = typeof(MonoBtlsKey))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Token(Token = "0x600032D")]
		 set { } //Length: 206
	}

	[Token(Token = "0x17000082")]
	internal MonoBtlsX509 X509
	{
		[Address(RVA = "0x174C340", Offset = "0x174B540", Length = "0x1D")]
		[CalledBy(Type = typeof(MonoBtlsContext), Member = "SetPrivateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateImplBtls)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MonoBtlsProvider), Member = "GetBtlsCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(MonoBtlsX509))]
		[CalledBy(Type = typeof(MonoBtlsProvider), Member = "GetNativeChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateCollection)}, ReturnType = typeof(MonoBtlsX509Chain))]
		[CallerCount(Count = 5)]
		[Calls(Type = "System.Security.Cryptography.X509Certificates.X509CertificateImpl", Member = "ThrowIfContextInvalid", ReturnType = typeof(void))]
		[Token(Token = "0x6000325")]
		internal get { } //Length: 29
	}

	[Address(RVA = "0x174BED0", Offset = "0x174B0D0", Length = "0x4B")]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "CreateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509)}, ReturnType = typeof(X509Certificate2))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBtlsX509), Member = "Copy", ReturnType = typeof(MonoBtlsX509))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000320")]
	internal X509CertificateImplBtls(MonoBtlsX509 x509) { }

	[Address(RVA = "0x174BF20", Offset = "0x174B120", Length = "0xD5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsX509), Member = "Copy", ReturnType = typeof(MonoBtlsX509))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MonoBtlsKey), Member = "Copy", ReturnType = typeof(MonoBtlsKey))]
	[Calls(Type = typeof(X509CertificateImplCollection), Member = "Clone", ReturnType = typeof(X509CertificateImplCollection))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000321")]
	private X509CertificateImplBtls(X509CertificateImplBtls other) { }

	[Address(RVA = "0x174C000", Offset = "0x174B200", Length = "0x51")]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "GetNativeCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(X509Certificate2Impl))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBtlsX509), Member = "LoadFromData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(MonoBtlsX509Format)}, ReturnType = typeof(MonoBtlsX509))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000322")]
	internal X509CertificateImplBtls(Byte[] data, MonoBtlsX509Format format) { }

	[Address(RVA = "0x174C060", Offset = "0x174B260", Length = "0x280")]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "GetPrivateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(X509CertificateImplBtls))]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "GetNativeCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(string), typeof(X509KeyStorageFlags)}, ReturnType = typeof(X509Certificate2Impl))]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "GetNativeCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle", typeof(X509KeyStorageFlags)}, ReturnType = typeof(X509Certificate2Impl))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(X509CertificateImplBtls), Member = "ImportPkcs12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsX509), Member = "LoadFromData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(MonoBtlsX509Format)}, ReturnType = typeof(MonoBtlsX509))]
	[Calls(Type = typeof(X509CertificateImplBtls), Member = "ImportAuthenticode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CryptographicException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000323")]
	internal X509CertificateImplBtls(Byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	[Address(RVA = "0x174B430", Offset = "0x174A630", Length = "0x10D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "System.Security.Cryptography.X509Certificates.X509CertificateImpl", Member = "ThrowIfContextInvalid", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MonoBtlsX509), Member = "Copy", ReturnType = typeof(MonoBtlsX509))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MonoBtlsKey), Member = "Copy", ReturnType = typeof(MonoBtlsKey))]
	[Calls(Type = typeof(X509CertificateImplCollection), Member = "Clone", ReturnType = typeof(X509CertificateImplCollection))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000327")]
	public virtual X509CertificateImpl Clone() { }

	[Address(RVA = "0x174B540", Offset = "0x174A740", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600032A")]
	protected virtual void Dispose(bool disposing) { }

	[Address(RVA = "0x174C2F0", Offset = "0x174B4F0", Length = "0xC")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600032B")]
	public virtual bool get_HasPrivateKey() { }

	[Address(RVA = "0x2DD1C0", Offset = "0x2DC3C0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000329")]
	internal virtual X509CertificateImplCollection get_IntermediateCertificates() { }

	[Address(RVA = "0x174C300", Offset = "0x174B500", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "get_IsValid", ReturnType = typeof(bool))]
	[Token(Token = "0x6000324")]
	public virtual bool get_IsValid() { }

	[Address(RVA = "0x174C320", Offset = "0x174B520", Length = "0x1D")]
	[CallerCount(Count = 1)]
	[Calls(Type = "System.Security.Cryptography.X509Certificates.X509CertificateImpl", Member = "ThrowIfContextInvalid", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000326")]
	internal MonoBtlsKey get_NativePrivateKey() { }

	[Address(RVA = "0x174B5D0", Offset = "0x174A7D0", Length = "0x34")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsKey), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(PrivateKeyInfo), Member = "DecodeRSA", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(RSA))]
	[DeduplicatedMethod]
	[Token(Token = "0x600032C")]
	public virtual AsymmetricAlgorithm get_PrivateKey() { }

	[Address(RVA = "0x174C340", Offset = "0x174B540", Length = "0x1D")]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "SetPrivateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateImplBtls)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "GetBtlsCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(MonoBtlsX509))]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "GetNativeChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateCollection)}, ReturnType = typeof(MonoBtlsX509Chain))]
	[CallerCount(Count = 5)]
	[Calls(Type = "System.Security.Cryptography.X509Certificates.X509CertificateImpl", Member = "ThrowIfContextInvalid", ReturnType = typeof(void))]
	[Token(Token = "0x6000325")]
	internal MonoBtlsX509 get_X509() { }

	[Address(RVA = "0x174B590", Offset = "0x174A790", Length = "0x3E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600032F")]
	public virtual DSA GetDSAPrivateKey() { }

	[Address(RVA = "0x174B610", Offset = "0x174A810", Length = "0x3D")]
	[CallerCount(Count = 0)]
	[Calls(Type = "System.Security.Cryptography.X509Certificates.X509CertificateImpl", Member = "ThrowIfContextInvalid", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsX509), Member = "GetRawData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Format)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000328")]
	protected virtual Byte[] GetRawCertData() { }

	[Address(RVA = "0x174B5D0", Offset = "0x174A7D0", Length = "0x34")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsKey), Member = "GetBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(PrivateKeyInfo), Member = "DecodeRSA", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(RSA))]
	[DeduplicatedMethod]
	[Token(Token = "0x600032E")]
	public virtual RSA GetRSAPrivateKey() { }

	[Address(RVA = "0x174BB90", Offset = "0x174AD90", Length = "0x59")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsX509), Member = "LoadFromData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(MonoBtlsX509Format)}, ReturnType = typeof(MonoBtlsX509))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000330")]
	private void Import(Byte[] data) { }

	[Address(RVA = "0x174B650", Offset = "0x174A850", Length = "0xD6")]
	[CalledBy(Type = typeof(X509CertificateImplBtls), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle", typeof(X509KeyStorageFlags)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(AuthenticodeDeformatter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsX509), Member = "LoadFromData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(MonoBtlsX509Format)}, ReturnType = typeof(MonoBtlsX509))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000332")]
	private void ImportAuthenticode(Byte[] data) { }

	[Address(RVA = "0x174B730", Offset = "0x174A930", Length = "0x452")]
	[CalledBy(Type = typeof(X509CertificateImplBtls), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle", typeof(X509KeyStorageFlags)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(X509CertificateImplCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509CertificateImpl", typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsX509), Member = "Copy", ReturnType = typeof(MonoBtlsX509))]
	[Calls(Type = typeof(MonoBtlsX509), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509), typeof(MonoBtlsX509)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(X509CertificateImplCollection), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsPkcs12), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(MonoBtlsPkcs12), Member = "GetPrivateKey", ReturnType = typeof(MonoBtlsKey))]
	[Calls(Type = typeof(MonoBtlsPkcs12), Member = "get_HasPrivateKey", ReturnType = typeof(bool))]
	[Calls(Type = typeof(MonoBtlsPkcs12), Member = "GetCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(MonoBtlsX509))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181732080")]
	[Calls(Type = "Microsoft.Win32.SafeHandles.SafePasswordHandle", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(MonoBtlsPkcs12), Member = "Import", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), "Microsoft.Win32.SafeHandles.SafePasswordHandle"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsPkcs12), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000331")]
	private void ImportPkcs12(Byte[] data, SafePasswordHandle password) { }

	[Address(RVA = "0x174C360", Offset = "0x174B560", Length = "0xCE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MonoBtlsObject), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsKey), Member = "CreateFromRSAPrivateKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RSA)}, ReturnType = typeof(MonoBtlsKey))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x600032D")]
	public virtual void set_PrivateKey(AsymmetricAlgorithm value) { }

	[Address(RVA = "0x174BBF0", Offset = "0x174ADF0", Length = "0x2D4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsX509Chain), Member = "AddCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAA0")]
	[Calls(Type = typeof(MonoBtlsHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsX509), Member = "Copy", ReturnType = typeof(MonoBtlsX509))]
	[Calls(Type = typeof(X509CertificateImplCollection), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(X509CertificateImplCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "System.Security.Cryptography.X509Certificates.X509CertificateImpl")]
	[Calls(Type = typeof(MonoBtlsProvider), Member = "ValidateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Chain), typeof(MonoBtlsX509VerifyParam)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000333")]
	public virtual bool Verify(X509Certificate2 thisCertificate) { }

}

