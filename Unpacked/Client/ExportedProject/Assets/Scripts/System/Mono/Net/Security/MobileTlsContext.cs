namespace Mono.Net.Security;

[Token(Token = "0x200005C")]
internal abstract class MobileTlsContext : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000107")]
	private ChainValidationHelper certificateValidator; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000108")]
	private readonly MonoSslAuthenticationOptions <Options>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000109")]
	private readonly MobileAuthenticatedStream <Parent>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400010A")]
	private readonly bool <IsServer>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400010B")]
	private readonly string <TargetHost>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400010C")]
	private readonly string <ServerName>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400010D")]
	private readonly bool <AskForClientCertificate>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x400010E")]
	private readonly SslProtocols <EnabledProtocols>k__BackingField; //Field offset: 0x44
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400010F")]
	private readonly X509CertificateCollection <ClientCertificates>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000110")]
	private X509Certificate <LocalServerCertificate>k__BackingField; //Field offset: 0x50

	[Token(Token = "0x17000039")]
	protected bool AskForClientCertificate
	{
		[Address(RVA = "0x4C4260", Offset = "0x4C3460", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000127")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700003B")]
	protected X509CertificateCollection ClientCertificates
	{
		[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
		[CallerCount(Count = 4)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000129")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700003A")]
	protected SslProtocols EnabledProtocols
	{
		[Address(RVA = "0x1060130", Offset = "0x105F330", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000128")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000035")]
	public abstract bool IsAuthenticated
	{
		[Token(Token = "0x6000123")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000036")]
	public bool IsServer
	{
		[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000124")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700003D")]
	internal abstract X509Certificate LocalClientCertificate
	{
		[Token(Token = "0x6000130")]
		internal get { } //Length: 0
	}

	[Token(Token = "0x1700003C")]
	internal X509Certificate LocalServerCertificate
	{
		[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
		[CallerCount(Count = 8)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600012E")]
		internal get { } //Length: 5
		[Address(RVA = "0x2DD610", Offset = "0x2DC810", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600012F")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000032")]
	internal MonoSslAuthenticationOptions Options
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000120")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000033")]
	internal MobileAuthenticatedStream Parent
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000121")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700003E")]
	public abstract X509Certificate2 RemoteCertificate
	{
		[Token(Token = "0x6000131")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000038")]
	protected string ServerName
	{
		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000126")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000034")]
	public MonoTlsSettings Settings
	{
		[Address(RVA = "0x15F2890", Offset = "0x15F1A90", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000122")]
		 get { } //Length: 30
	}

	[Token(Token = "0x17000037")]
	internal string TargetHost
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000125")]
		internal get { } //Length: 95
	}

	[Address(RVA = "0x15F25E0", Offset = "0x15F17E0", Length = "0x2A4")]
	[CalledBy(Type = typeof(UnityTlsContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MobileAuthenticatedStream), typeof(MonoSslAuthenticationOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MobileAuthenticatedStream), typeof(MonoSslAuthenticationOptions)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ChainValidationHelper), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SslStream), typeof(MobileTlsProvider), typeof(MonoTlsSettings), typeof(bool), typeof(MonoTlsStream)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[Token(Token = "0x600011F")]
	protected MobileTlsContext(MobileAuthenticatedStream parent, MonoSslAuthenticationOptions options) { }

	[Address(RVA = "0x15F1BC0", Offset = "0x15F0DC0", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600013B")]
	public override void Dispose() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600013C")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x15F1C30", Offset = "0x15F0E30", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600013D")]
	protected virtual void Finalize() { }

	[Token(Token = "0x600012D")]
	public abstract void FinishHandshake() { }

	[Token(Token = "0x6000132")]
	public abstract void Flush() { }

	[Address(RVA = "0x4C4260", Offset = "0x4C3460", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000127")]
	protected bool get_AskForClientCertificate() { }

	[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
	[CallerCount(Count = 4)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000129")]
	protected X509CertificateCollection get_ClientCertificates() { }

	[Address(RVA = "0x1060130", Offset = "0x105F330", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000128")]
	protected SslProtocols get_EnabledProtocols() { }

	[Token(Token = "0x6000123")]
	public abstract bool get_IsAuthenticated() { }

	[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000124")]
	public bool get_IsServer() { }

	[Token(Token = "0x6000130")]
	internal abstract X509Certificate get_LocalClientCertificate() { }

	[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
	[CallerCount(Count = 8)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600012E")]
	internal X509Certificate get_LocalServerCertificate() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000120")]
	internal MonoSslAuthenticationOptions get_Options() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000121")]
	internal MobileAuthenticatedStream get_Parent() { }

	[Token(Token = "0x6000131")]
	public abstract X509Certificate2 get_RemoteCertificate() { }

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000126")]
	protected string get_ServerName() { }

	[Address(RVA = "0x15F2890", Offset = "0x15F1A90", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000122")]
	public MonoTlsSettings get_Settings() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000125")]
	internal string get_TargetHost() { }

	[Address(RVA = "0x15F1CA0", Offset = "0x15F0EA0", Length = "0xE4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Token(Token = "0x600012A")]
	protected void GetProtocolVersions(out Nullable<TlsProtocolCode>& min, out Nullable<TlsProtocolCode>& max) { }

	[Token(Token = "0x6000136")]
	public abstract bool PendingRenegotiation() { }

	[Token(Token = "0x600012C")]
	public abstract bool ProcessHandshake() { }

	[Token(Token = "0x6000133")]
	public abstract ValueTuple<Int32, Boolean> Read(Byte[] buffer, int offset, int count) { }

	[Token(Token = "0x600013A")]
	public abstract void Renegotiate() { }

	[Address(RVA = "0x15F1D90", Offset = "0x15F0F90", Length = "0x524")]
	[CalledBy(Type = typeof(UnityTlsContext), Member = "CertificateCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(unitytls_tlsctx*), typeof(Byte*), typeof(IntPtr), typeof(unitytls_x509name*), typeof(IntPtr), typeof(unitytls_x509list_ref*), typeof(unitytls_key_ref*), typeof(unitytls_errorstate*)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "SelectCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(X509ChainPolicy), Member = "set_VerificationFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509VerificationFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(X509Chain), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(X509Certificate), Member = "get_Issuer", ReturnType = typeof(string))]
	[Calls(Type = typeof(X509ChainElementCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(X509ChainElement))]
	[Calls(Type = typeof(X509Chain), Member = "get_ChainElements", ReturnType = typeof(X509ChainElementCollection))]
	[Calls(Type = typeof(X509ChainPolicy), Member = "set_RevocationMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509RevocationMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TlsException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AlertDescription), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509Chain), Member = "get_ChainPolicy", ReturnType = typeof(X509ChainPolicy))]
	[Calls(Type = typeof(X509Chain), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(X509CertificateCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(X509Certificate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(X509Chain), Member = "Build", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	[Token(Token = "0x6000139")]
	protected X509Certificate SelectClientCertificate(String[] acceptableIssuers) { }

	[Address(RVA = "0x15F22C0", Offset = "0x15F14C0", Length = "0x2B7")]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "ServerNameCallback", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(X509CertificateCollection), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000138")]
	protected X509Certificate SelectServerCertificate(string serverIdentity) { }

	[Address(RVA = "0x2DD610", Offset = "0x2DC810", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600012F")]
	private void set_LocalServerCertificate(X509Certificate value) { }

	[Token(Token = "0x6000135")]
	public abstract void Shutdown() { }

	[Token(Token = "0x600012B")]
	public abstract void StartHandshake() { }

	[Address(RVA = "0x15F2580", Offset = "0x15F1780", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ChainValidationHelper), Member = "ValidateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(X509Certificate), typeof(X509Chain)}, ReturnType = typeof(ValidationResult))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000137")]
	protected bool ValidateCertificate(X509Certificate2 leaf, X509Chain chain) { }

	[Token(Token = "0x6000134")]
	public abstract ValueTuple<Int32, Boolean> Write(Byte[] buffer, int offset, int count) { }

}

