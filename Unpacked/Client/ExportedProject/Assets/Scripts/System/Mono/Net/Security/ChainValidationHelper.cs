namespace Mono.Net.Security;

[Token(Token = "0x2000052")]
internal class ChainValidationHelper : ICertificateValidator
{
	[CompilerGenerated]
	[Token(Token = "0x2000053")]
	private sealed class <>c__DisplayClass11_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000CA")]
		public MonoTlsSettings settings; //Field offset: 0x10

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000E0")]
		public <>c__DisplayClass11_0() { }

		[Address(RVA = "0x16010F0", Offset = "0x16002F0", Length = "0x14D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(SslStream), Member = "get_InternalTargetHost", ReturnType = typeof(string))]
		[Calls(Type = typeof(HttpWebRequest), Member = "get_Host", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60000E1")]
		internal bool <GetValidationCallback>b__0(object s, X509Certificate c, X509Chain ch, SslPolicyErrors e) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000C3")]
	private readonly WeakReference<SslStream> owner; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000C4")]
	private readonly MonoTlsSettings settings; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000C5")]
	private readonly MobileTlsProvider provider; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000C6")]
	private readonly ServerCertValidationCallback certValidationCallback; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000C7")]
	private readonly LocalCertSelectionCallback certSelectionCallback; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40000C8")]
	private readonly MonoTlsStream tlsStream; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40000C9")]
	private readonly HttpWebRequest request; //Field offset: 0x40

	[Token(Token = "0x17000022")]
	public override MonoTlsSettings Settings
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x60000DA")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x15EEDE0", Offset = "0x15EDFE0", Length = "0x412")]
	[CalledBy(Type = typeof(ChainValidationHelper), Member = "GetInternalValidator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SslStream), typeof(MobileTlsProvider), typeof(MonoTlsSettings)}, ReturnType = typeof(ChainValidationHelper))]
	[CalledBy(Type = typeof(ChainValidationHelper), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MobileTlsProvider), typeof(MonoTlsSettings&), typeof(MonoTlsStream)}, ReturnType = typeof(ChainValidationHelper))]
	[CalledBy(Type = typeof(MobileTlsContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MobileAuthenticatedStream), typeof(MonoSslAuthenticationOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoTlsStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HttpWebRequest), typeof(NetworkStream)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(MonoTlsSettings), Member = "CopyDefaultSettings", ReturnType = typeof(MonoTlsSettings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(MonoTlsProviderFactory), Member = "GetProviderInternal", ReturnType = typeof(MobileTlsProvider))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(WeakReference`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ServerCertValidationCallback), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RemoteCertificateValidationCallback)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoTlsSettings), Member = "CloneWithValidator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICertificateValidator)}, ReturnType = typeof(MonoTlsSettings))]
	[Calls(Type = typeof(RemoteCertificateValidationCallback), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000D7")]
	private ChainValidationHelper(SslStream owner, MobileTlsProvider provider, MonoTlsSettings settings, bool cloneSettings, MonoTlsStream stream) { }

	[Address(RVA = "0x15EE3E0", Offset = "0x15ED5E0", Length = "0xAB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ChainValidationHelper), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SslStream), typeof(MobileTlsProvider), typeof(MonoTlsSettings), typeof(bool), typeof(MonoTlsStream)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000D6")]
	internal static ChainValidationHelper Create(MobileTlsProvider provider, ref MonoTlsSettings settings, MonoTlsStream stream) { }

	[Address(RVA = "0x15EE490", Offset = "0x15ED690", Length = "0x36")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509CertificateCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(X509Certificate))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000D9")]
	private static X509Certificate DefaultSelectionCallback(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, String[] acceptableIssuers) { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000DA")]
	public override MonoTlsSettings get_Settings() { }

	[Address(RVA = "0x15EE4D0", Offset = "0x15ED6D0", Length = "0xE0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ChainValidationHelper), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SslStream), typeof(MobileTlsProvider), typeof(MonoTlsSettings), typeof(bool), typeof(MonoTlsStream)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x60000D5")]
	internal static ChainValidationHelper GetInternalValidator(SslStream owner, MobileTlsProvider provider, MonoTlsSettings settings) { }

	[Address(RVA = "0x15EE5C0", Offset = "0x15ED7C0", Length = "0xEC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(RemoteCertificateValidationCallback), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ServerCertValidationCallback), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RemoteCertificateValidationCallback)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60000D8")]
	private static ServerCertValidationCallback GetValidationCallback(MonoTlsSettings settings) { }

	[Address(RVA = "0x15EE6B0", Offset = "0x15ED8B0", Length = "0xB1")]
	[CalledBy(Type = typeof(ChainValidationHelper), Member = "ValidateChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(X509Certificate), typeof(X509Chain&), typeof(X509CertificateCollection), typeof(SslPolicyErrors)}, ReturnType = typeof(ValidationResult))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(WeakReference`1), Member = "TryGetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ServerCertValidationCallback), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(X509Certificate), typeof(X509Chain), typeof(SslPolicyErrors)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000DF")]
	private bool InvokeCallback(X509Certificate leaf, X509Chain chain, SslPolicyErrors errors) { }

	[Address(RVA = "0x15EE770", Offset = "0x15ED970", Length = "0x5E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60000DB")]
	public override bool SelectClientCertificate(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, String[] acceptableIssuers, out X509Certificate clientCertificate) { }

	[Address(RVA = "0x15EE7D0", Offset = "0x15ED9D0", Length = "0x99")]
	[CalledBy(Type = typeof(UnityTlsContext), Member = "ProcessHandshake", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UnityTlsContext), Member = "VerifyCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(unitytls_x509list_ref), typeof(unitytls_errorstate*)}, ReturnType = typeof(unitytls_x509verify_result))]
	[CalledBy(Type = typeof(MobileTlsContext), Member = "ValidateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2), typeof(X509Chain)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "VerifyCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509StoreCtx)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "InitializeSession", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ChainValidationHelper), Member = "ValidateChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(X509Certificate), typeof(X509Chain), typeof(X509CertificateCollection), typeof(SslPolicyErrors)}, ReturnType = typeof(ValidationResult))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000DC")]
	public ValidationResult ValidateCertificate(string host, bool serverMode, X509Certificate leaf, X509Chain chain) { }

	[Address(RVA = "0x15EE870", Offset = "0x15EDA70", Length = "0xD6")]
	[CalledBy(Type = typeof(ChainValidationHelper), Member = "ValidateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(X509Certificate), typeof(X509Chain)}, ReturnType = typeof(ValidationResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ChainValidationHelper), Member = "ValidateChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(X509Certificate), typeof(X509Chain&), typeof(X509CertificateCollection), typeof(SslPolicyErrors)}, ReturnType = typeof(ValidationResult))]
	[Calls(Type = typeof(X509Chain), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000DD")]
	private ValidationResult ValidateChain(string host, bool server, X509Certificate leaf, X509Chain chain, X509CertificateCollection certs, SslPolicyErrors errors) { }

	[Address(RVA = "0x15EE950", Offset = "0x15EDB50", Length = "0x48D")]
	[CalledBy(Type = typeof(ChainValidationHelper), Member = "ValidateChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(X509Certificate), typeof(X509Chain), typeof(X509CertificateCollection), typeof(SslPolicyErrors)}, ReturnType = typeof(ValidationResult))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ValidationResult), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(int), typeof(System.Nullable`1<Mono.Security.Interface.MonoSslPolicyErrors>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(HttpWebRequest), Member = "get_ServicePoint", ReturnType = typeof(ServicePoint))]
	[Calls(Type = typeof(ServicePoint), Member = "UpdateServerCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(ChainValidationHelper), Member = "InvokeCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate), typeof(X509Chain), typeof(SslPolicyErrors)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000DE")]
	private ValidationResult ValidateChain(string host, bool server, X509Certificate leaf, ref X509Chain chain, X509CertificateCollection certs, SslPolicyErrors errors) { }

}

