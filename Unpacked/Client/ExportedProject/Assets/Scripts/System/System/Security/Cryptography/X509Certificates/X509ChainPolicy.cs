namespace System.Security.Cryptography.X509Certificates;

[Token(Token = "0x2000137")]
public sealed class X509ChainPolicy
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005A7")]
	private OidCollection apps; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40005A8")]
	private OidCollection cert; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40005A9")]
	private X509CertificateCollection store; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40005AA")]
	private X509Certificate2Collection store2; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40005AB")]
	private X509RevocationFlag rflag; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40005AC")]
	private X509RevocationMode mode; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40005AD")]
	private TimeSpan timeout; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40005AE")]
	private X509VerificationFlags vflags; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40005AF")]
	private DateTime vtime; //Field offset: 0x48

	[Token(Token = "0x17000163")]
	public internal X509Certificate2Collection ExtraStore
	{
		[Address(RVA = "0x178F080", Offset = "0x178E280", Length = "0x34D")]
		[CalledBy(Type = typeof(X509ChainImplMono), Member = "get_CertificateCollection", ReturnType = typeof(X509Certificate2Collection))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60007A8")]
		 get { } //Length: 845
		[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60007A9")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x17000164")]
	public X509RevocationFlag RevocationFlag
	{
		[Address(RVA = "0x2F5B20", Offset = "0x2F4D20", Length = "0xAE")]
		[CallerCount(Count = 23)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x60007AA")]
		 get { } //Length: 174
	}

	[Token(Token = "0x17000165")]
	public X509RevocationMode RevocationMode
	{
		[Address(RVA = "0x3EAB00", Offset = "0x3E9D00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60007AB")]
		 get { } //Length: 4
		[Address(RVA = "0x178F3D0", Offset = "0x178E5D0", Length = "0x63")]
		[CalledBy(Type = typeof(MobileTlsContext), Member = "SelectClientCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(X509Certificate))]
		[CalledBy(Type = typeof(MonoBtlsContext), Member = "SetPrivateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateImplBtls)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x60007AC")]
		 set { } //Length: 99
	}

	[Token(Token = "0x17000166")]
	public X509VerificationFlags VerificationFlags
	{
		[Address(RVA = "0x324350", Offset = "0x323550", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60007AD")]
		 get { } //Length: 4
		[Address(RVA = "0x178F440", Offset = "0x178E640", Length = "0x6C")]
		[CalledBy(Type = typeof(MobileTlsContext), Member = "SelectClientCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(X509Certificate))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x60007AE")]
		 set { } //Length: 108
	}

	[Token(Token = "0x17000167")]
	public DateTime VerificationTime
	{
		[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x60007AF")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x178EF60", Offset = "0x178E160", Length = "0x112")]
	[CalledBy(Type = typeof(UnityTlsContext), Member = "VerifyCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(unitytls_x509list_ref), typeof(unitytls_errorstate*)}, ReturnType = typeof(unitytls_x509verify_result))]
	[CalledBy(Type = typeof(UnityTlsProvider), Member = "ValidateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainValidationHelper), typeof(string), typeof(bool), typeof(X509CertificateCollection), typeof(bool), typeof(X509Chain&), typeof(SslPolicyErrors&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(X509ChainImplUnityTls), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(unitytls_x509list_ref), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509ChainImplUnityTls), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(unitytls_x509list*), typeof(unitytls_errorstate*), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509ChainImplBtls), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Chain)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509ChainImplBtls), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509StoreCtx)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(OidCollection), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60007A7")]
	public X509ChainPolicy() { }

	[Address(RVA = "0x178F080", Offset = "0x178E280", Length = "0x34D")]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = "get_CertificateCollection", ReturnType = typeof(X509Certificate2Collection))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60007A8")]
	public X509Certificate2Collection get_ExtraStore() { }

	[Address(RVA = "0x2F5B20", Offset = "0x2F4D20", Length = "0xAE")]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x60007AA")]
	public X509RevocationFlag get_RevocationFlag() { }

	[Address(RVA = "0x3EAB00", Offset = "0x3E9D00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007AB")]
	public X509RevocationMode get_RevocationMode() { }

	[Address(RVA = "0x324350", Offset = "0x323550", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007AD")]
	public X509VerificationFlags get_VerificationFlags() { }

	[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x60007AF")]
	public DateTime get_VerificationTime() { }

	[Address(RVA = "0x178EE50", Offset = "0x178E050", Length = "0x10B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(OidCollection), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
	[Token(Token = "0x60007B0")]
	public void Reset() { }

	[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60007A9")]
	internal void set_ExtraStore(X509Certificate2Collection value) { }

	[Address(RVA = "0x178F3D0", Offset = "0x178E5D0", Length = "0x63")]
	[CalledBy(Type = typeof(MobileTlsContext), Member = "SelectClientCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(X509Certificate))]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "SetPrivateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateImplBtls)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60007AC")]
	public void set_RevocationMode(X509RevocationMode value) { }

	[Address(RVA = "0x178F440", Offset = "0x178E640", Length = "0x6C")]
	[CalledBy(Type = typeof(MobileTlsContext), Member = "SelectClientCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(X509Certificate))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60007AE")]
	public void set_VerificationFlags(X509VerificationFlags value) { }

}

