namespace Mono.Security.Interface;

[Token(Token = "0x2000044")]
public sealed class MonoTlsSettings
{
	[Token(Token = "0x40001FA")]
	private static MonoTlsSettings defaultSettings; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001E8")]
	private MonoRemoteCertificateValidationCallback <RemoteCertificateValidationCallback>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001E9")]
	private MonoLocalCertificateSelectionCallback <ClientCertificateSelectionCallback>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001EA")]
	private Nullable<DateTime> <CertificateValidationTime>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001EB")]
	private X509CertificateCollection <TrustAnchors>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001EC")]
	private object <UserSettings>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001ED")]
	private String[] <CertificateSearchPaths>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40001EE")]
	private bool <SendCloseNotify>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40001EF")]
	private String[] <ClientCertificateIssuers>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40001F0")]
	private bool <DisallowUnauthenticatedCertificateRequest>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x40001F1")]
	private Nullable<TlsProtocols> <EnabledProtocols>k__BackingField; //Field offset: 0x5C
	[CompilerGenerated]
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40001F2")]
	private CipherSuiteCode[] <EnabledCiphers>k__BackingField; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40001F3")]
	private bool cloned; //Field offset: 0x70
	[FieldOffset(Offset = "0x71")]
	[Token(Token = "0x40001F4")]
	private bool checkCertName; //Field offset: 0x71
	[FieldOffset(Offset = "0x72")]
	[Token(Token = "0x40001F5")]
	private bool checkCertRevocationStatus; //Field offset: 0x72
	[FieldOffset(Offset = "0x73")]
	[Token(Token = "0x40001F6")]
	private Nullable<Boolean> useServicePointManagerCallback; //Field offset: 0x73
	[FieldOffset(Offset = "0x75")]
	[Token(Token = "0x40001F7")]
	private bool skipSystemValidators; //Field offset: 0x75
	[FieldOffset(Offset = "0x76")]
	[Token(Token = "0x40001F8")]
	private bool callbackNeedsChain; //Field offset: 0x76
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40001F9")]
	private ICertificateValidator certificateValidator; //Field offset: 0x78

	[Token(Token = "0x1700006F")]
	public bool CallbackNeedsCertificateChain
	{
		[Address(RVA = "0x12CDAE0", Offset = "0x12CCCE0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000161")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000073")]
	internal String[] CertificateSearchPaths
	{
		[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000168")]
		internal get { } //Length: 5
		[Address(RVA = "0x309660", Offset = "0x308860", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000169")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x17000070")]
	public Nullable<DateTime> CertificateValidationTime
	{
		[Address(RVA = "0x5AAB20", Offset = "0x5A9D20", Length = "0xB")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000162")]
		 get { } //Length: 11
		[Address(RVA = "0x5AAC00", Offset = "0x5A9E00", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000163")]
		 set { } //Length: 8
	}

	[Obsolete("Do not use outside System.dll!")]
	[Token(Token = "0x1700007A")]
	public ICertificateValidator CertificateValidator
	{
		[Address(RVA = "0x2DD190", Offset = "0x2DC390", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000177")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000075")]
	public String[] ClientCertificateIssuers
	{
		[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
		[CallerCount(Count = 8)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600016C")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD610", Offset = "0x2DC810", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600016D")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700006D")]
	public MonoLocalCertificateSelectionCallback ClientCertificateSelectionCallback
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600015D")]
		 get { } //Length: 5
		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600015E")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000079")]
	public static MonoTlsSettings DefaultSettings
	{
		[Address(RVA = "0x12CDAF0", Offset = "0x12CCCF0", Length = "0x87")]
		[CalledBy(Type = "Mono.Btls.MonoBtlsProvider", Member = "ValidateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Btls.MonoBtlsX509Chain", "Mono.Btls.MonoBtlsX509VerifyParam"}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000175")]
		 get { } //Length: 135
	}

	[Token(Token = "0x17000076")]
	public bool DisallowUnauthenticatedCertificateRequest
	{
		[Address(RVA = "0x3F5830", Offset = "0x3F4A30", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600016E")]
		 get { } //Length: 5
		[Address(RVA = "0x12CDBA0", Offset = "0x12CCDA0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600016F")]
		 set { } //Length: 4
	}

	[CLSCompliant(False)]
	[Token(Token = "0x17000078")]
	public CipherSuiteCode[] EnabledCiphers
	{
		[Address(RVA = "0x369270", Offset = "0x368470", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000172")]
		 get { } //Length: 5
		[Address(RVA = "0x3692A0", Offset = "0x3684A0", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000173")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000077")]
	public Nullable<TlsProtocols> EnabledProtocols
	{
		[Address(RVA = "0x12CDB80", Offset = "0x12CCD80", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6000170")]
		 get { } //Length: 5
		[Address(RVA = "0x12CDBB0", Offset = "0x12CCDB0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6000171")]
		 set { } //Length: 5
	}

	[Token(Token = "0x1700006C")]
	public MonoRemoteCertificateValidationCallback RemoteCertificateValidationCallback
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600015B")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600015C")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000074")]
	internal bool SendCloseNotify
	{
		[Address(RVA = "0x347A30", Offset = "0x346C30", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600016A")]
		internal get { } //Length: 5
		[Address(RVA = "0x347A50", Offset = "0x346C50", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600016B")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000071")]
	public X509CertificateCollection TrustAnchors
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000164")]
		 get { } //Length: 95
		[Address(RVA = "0x2F8470", Offset = "0x2F7670", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000165")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000072")]
	public object UserSettings
	{
		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000166")]
		 get { } //Length: 5
		[Address(RVA = "0x309670", Offset = "0x308870", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000167")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700006E")]
	public Nullable<Boolean> UseServicePointManagerCallback
	{
		[Address(RVA = "0x12CDB90", Offset = "0x12CCD90", Length = "0x5")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600015F")]
		 get { } //Length: 5
		[Address(RVA = "0x12CDBC0", Offset = "0x12CCDC0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000160")]
		 set { } //Length: 5
	}

	[Address(RVA = "0x12CD940", Offset = "0x12CCB40", Length = "0x18C")]
	[CalledBy(Type = typeof(MonoTlsSettings), Member = "CopyDefaultSettings", ReturnType = typeof(MonoTlsSettings))]
	[CalledBy(Type = typeof(MonoTlsSettings), Member = "CloneWithValidator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICertificateValidator)}, ReturnType = typeof(MonoTlsSettings))]
	[CalledBy(Type = typeof(MonoTlsSettings), Member = "Clone", ReturnType = typeof(MonoTlsSettings))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(X509CertificateCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateCollection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600017A")]
	private MonoTlsSettings(MonoTlsSettings other) { }

	[Address(RVA = "0x12CDAD0", Offset = "0x12CCCD0", Length = "0xF")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000174")]
	public MonoTlsSettings() { }

	[Address(RVA = "0x12CD800", Offset = "0x12CCA00", Length = "0x54")]
	[CalledBy(Type = typeof(SslStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(bool), typeof(MonoTlsProvider), typeof(MonoTlsSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MonoTlsSettings), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoTlsSettings)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000179")]
	public MonoTlsSettings Clone() { }

	[Address(RVA = "0x12CD760", Offset = "0x12CC960", Length = "0x9F")]
	[CalledBy(Type = "Mono.Net.Security.ChainValidationHelper", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SslStream), "Mono.Net.Security.MobileTlsProvider", typeof(MonoTlsSettings), typeof(bool), "Mono.Net.Security.MonoTlsStream"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MonoTlsSettings), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoTlsSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Obsolete("Do not use outside System.dll!")]
	[Token(Token = "0x6000178")]
	public MonoTlsSettings CloneWithValidator(ICertificateValidator validator) { }

	[Address(RVA = "0x12CD860", Offset = "0x12CCA60", Length = "0xD0")]
	[CalledBy(Type = "Mono.Net.Security.ChainValidationHelper", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SslStream), "Mono.Net.Security.MobileTlsProvider", typeof(MonoTlsSettings), typeof(bool), "Mono.Net.Security.MonoTlsStream"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mono.Net.Security.MonoTlsStream", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpWebRequest), typeof(NetworkStream)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SslStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(bool), typeof(RemoteCertificateValidationCallback), typeof(LocalCertificateSelectionCallback)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Net.Http.MonoWebRequestHandler", Member = "CreateWebRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Http.HttpRequestMessage"}, ReturnType = typeof(HttpWebRequest))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[Calls(Type = typeof(MonoTlsSettings), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoTlsSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000176")]
	public static MonoTlsSettings CopyDefaultSettings() { }

	[Address(RVA = "0x12CDAE0", Offset = "0x12CCCE0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000161")]
	public bool get_CallbackNeedsCertificateChain() { }

	[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000168")]
	internal String[] get_CertificateSearchPaths() { }

	[Address(RVA = "0x5AAB20", Offset = "0x5A9D20", Length = "0xB")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000162")]
	public Nullable<DateTime> get_CertificateValidationTime() { }

	[Address(RVA = "0x2DD190", Offset = "0x2DC390", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000177")]
	public ICertificateValidator get_CertificateValidator() { }

	[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
	[CallerCount(Count = 8)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600016C")]
	public String[] get_ClientCertificateIssuers() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600015D")]
	public MonoLocalCertificateSelectionCallback get_ClientCertificateSelectionCallback() { }

	[Address(RVA = "0x12CDAF0", Offset = "0x12CCCF0", Length = "0x87")]
	[CalledBy(Type = "Mono.Btls.MonoBtlsProvider", Member = "ValidateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mono.Btls.MonoBtlsX509Chain", "Mono.Btls.MonoBtlsX509VerifyParam"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F8B40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000175")]
	public static MonoTlsSettings get_DefaultSettings() { }

	[Address(RVA = "0x3F5830", Offset = "0x3F4A30", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600016E")]
	public bool get_DisallowUnauthenticatedCertificateRequest() { }

	[Address(RVA = "0x369270", Offset = "0x368470", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000172")]
	public CipherSuiteCode[] get_EnabledCiphers() { }

	[Address(RVA = "0x12CDB80", Offset = "0x12CCD80", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6000170")]
	public Nullable<TlsProtocols> get_EnabledProtocols() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600015B")]
	public MonoRemoteCertificateValidationCallback get_RemoteCertificateValidationCallback() { }

	[Address(RVA = "0x347A30", Offset = "0x346C30", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600016A")]
	internal bool get_SendCloseNotify() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000164")]
	public X509CertificateCollection get_TrustAnchors() { }

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000166")]
	public object get_UserSettings() { }

	[Address(RVA = "0x12CDB90", Offset = "0x12CCD90", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600015F")]
	public Nullable<Boolean> get_UseServicePointManagerCallback() { }

	[Address(RVA = "0x309660", Offset = "0x308860", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000169")]
	internal void set_CertificateSearchPaths(String[] value) { }

	[Address(RVA = "0x5AAC00", Offset = "0x5A9E00", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000163")]
	public void set_CertificateValidationTime(Nullable<DateTime> value) { }

	[Address(RVA = "0x2DD610", Offset = "0x2DC810", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600016D")]
	public void set_ClientCertificateIssuers(String[] value) { }

	[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600015E")]
	public void set_ClientCertificateSelectionCallback(MonoLocalCertificateSelectionCallback value) { }

	[Address(RVA = "0x12CDBA0", Offset = "0x12CCDA0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600016F")]
	public void set_DisallowUnauthenticatedCertificateRequest(bool value) { }

	[Address(RVA = "0x3692A0", Offset = "0x3684A0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000173")]
	public void set_EnabledCiphers(CipherSuiteCode[] value) { }

	[Address(RVA = "0x12CDBB0", Offset = "0x12CCDB0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6000171")]
	public void set_EnabledProtocols(Nullable<TlsProtocols> value) { }

	[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600015C")]
	public void set_RemoteCertificateValidationCallback(MonoRemoteCertificateValidationCallback value) { }

	[Address(RVA = "0x347A50", Offset = "0x346C50", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600016B")]
	internal void set_SendCloseNotify(bool value) { }

	[Address(RVA = "0x2F8470", Offset = "0x2F7670", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000165")]
	public void set_TrustAnchors(X509CertificateCollection value) { }

	[Address(RVA = "0x309670", Offset = "0x308870", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000167")]
	public void set_UserSettings(object value) { }

	[Address(RVA = "0x12CDBC0", Offset = "0x12CCDC0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000160")]
	public void set_UseServicePointManagerCallback(Nullable<Boolean> value) { }

}

