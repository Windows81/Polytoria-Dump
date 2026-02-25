namespace System.Security.Cryptography.X509Certificates;

[Token(Token = "0x2000131")]
public class X509Chain : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000590")]
	private X509ChainImpl impl; //Field offset: 0x10

	[Token(Token = "0x1700014C")]
	public X509ChainElementCollection ChainElements
	{
		[Address(RVA = "0x178FAD0", Offset = "0x178ECD0", Length = "0x72")]
		[CalledBy(Type = typeof(UnityTlsContext), Member = "VerifyCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(unitytls_x509list_ref), typeof(unitytls_errorstate*)}, ReturnType = typeof(unitytls_x509verify_result))]
		[CalledBy(Type = typeof(MobileTlsContext), Member = "SelectClientCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(X509Certificate))]
		[CalledBy(Type = typeof(MonoBtlsContext), Member = "VerifyCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509StoreCtx)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(MonoBtlsContext), Member = "SetPrivateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateImplBtls)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(X509Helper2), Member = "GetInvalidChainContextException", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000758")]
		 get { } //Length: 114
	}

	[Token(Token = "0x1700014D")]
	public X509ChainPolicy ChainPolicy
	{
		[Address(RVA = "0x178FB50", Offset = "0x178ED50", Length = "0x72")]
		[CalledBy(Type = typeof(MobileTlsContext), Member = "SelectClientCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(X509Certificate))]
		[CalledBy(Type = typeof(MonoBtlsContext), Member = "SetPrivateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateImplBtls)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(X509Helper2), Member = "GetInvalidChainContextException", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000759")]
		 get { } //Length: 114
	}

	[Token(Token = "0x1700014B")]
	internal X509ChainImpl Impl
	{
		[Address(RVA = "0x178FBD0", Offset = "0x178EDD0", Length = "0x54")]
		[CalledBy(Type = typeof(UnityTlsProvider), Member = "ValidateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainValidationHelper), typeof(string), typeof(bool), typeof(X509CertificateCollection), typeof(bool), typeof(X509Chain&), typeof(SslPolicyErrors&), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(MonoBtlsProvider), Member = "ValidateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainValidationHelper), typeof(string), typeof(bool), typeof(X509CertificateCollection), typeof(bool), typeof(X509Chain&), typeof(SslPolicyErrors&), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(MonoBtlsProvider), Member = "CheckValidationResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainValidationHelper), typeof(string), typeof(bool), typeof(X509CertificateCollection), typeof(bool), typeof(X509Chain), typeof(MonoBtlsX509StoreCtx), typeof(bool), typeof(SslPolicyErrors&), typeof(Int32&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(X509Helper2), Member = "GetInvalidChainContextException", ReturnType = typeof(Exception))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000753")]
		internal get { } //Length: 84
	}

	[Address(RVA = "0x178F9E0", Offset = "0x178EBE0", Length = "0x66")]
	[CalledBy(Type = typeof(MobileTlsContext), Member = "SelectClientCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(X509Certificate))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(X509ChainImplMono), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000754")]
	public X509Chain() { }

	[Address(RVA = "0x178FA50", Offset = "0x178EC50", Length = "0x75")]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "SetPrivateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateImplBtls)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(X509ChainImplMono), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000755")]
	public X509Chain(bool useMachineContext) { }

	[Address(RVA = "0x178F960", Offset = "0x178EB60", Length = "0x71")]
	[CalledBy(Type = typeof(UnityTlsContext), Member = "VerifyCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(unitytls_x509list_ref), typeof(unitytls_errorstate*)}, ReturnType = typeof(unitytls_x509verify_result))]
	[CalledBy(Type = typeof(UnityTlsProvider), Member = "ValidateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainValidationHelper), typeof(string), typeof(bool), typeof(X509CertificateCollection), typeof(bool), typeof(X509Chain&), typeof(SslPolicyErrors&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "VerifyCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509StoreCtx)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "ValidateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainValidationHelper), typeof(string), typeof(bool), typeof(X509CertificateCollection), typeof(bool), typeof(X509Chain&), typeof(SslPolicyErrors&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "GetManagedChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Chain)}, ReturnType = typeof(X509Chain))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(X509Helper2), Member = "GetInvalidChainContextException", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000756")]
	internal X509Chain(X509ChainImpl impl) { }

	[Address(RVA = "0x178F910", Offset = "0x178EB10", Length = "0x45")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[MonoTODO("Mono's X509Chain is fully managed. All handles are invalid.")]
	[Token(Token = "0x6000757")]
	public X509Chain(IntPtr chainContext) { }

	[Address(RVA = "0x178F660", Offset = "0x178E860", Length = "0x81")]
	[CalledBy(Type = typeof(MobileTlsContext), Member = "SelectClientCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(X509Certificate))]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "SetPrivateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateImplBtls)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(X509Helper2), Member = "GetInvalidChainContextException", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[MonoTODO("Not totally RFC3280 compliant, but neither is MS implementation...")]
	[Token(Token = "0x600075A")]
	public bool Build(X509Certificate2 certificate) { }

	[Address(RVA = "0x178F6F0", Offset = "0x178E8F0", Length = "0x95")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(X509ChainImplMono), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600075C")]
	public static X509Chain Create() { }

	[Address(RVA = "0x178F820", Offset = "0x178EA20", Length = "0x61")]
	[CalledBy(Type = typeof(UnityTlsProvider), Member = "ValidateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainValidationHelper), typeof(string), typeof(bool), typeof(X509CertificateCollection), typeof(bool), typeof(X509Chain&), typeof(SslPolicyErrors&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ChainValidationHelper), Member = "ValidateChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(X509Certificate), typeof(X509Chain), typeof(X509CertificateCollection), typeof(SslPolicyErrors)}, ReturnType = typeof(ValidationResult))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600075D")]
	public override void Dispose() { }

	[Address(RVA = "0x178F790", Offset = "0x178E990", Length = "0x8A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600075E")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x12D1B30", Offset = "0x12D0D30", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600075F")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x178FAD0", Offset = "0x178ECD0", Length = "0x72")]
	[CalledBy(Type = typeof(UnityTlsContext), Member = "VerifyCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(unitytls_x509list_ref), typeof(unitytls_errorstate*)}, ReturnType = typeof(unitytls_x509verify_result))]
	[CalledBy(Type = typeof(MobileTlsContext), Member = "SelectClientCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(X509Certificate))]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "VerifyCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509StoreCtx)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "SetPrivateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateImplBtls)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(X509Helper2), Member = "GetInvalidChainContextException", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000758")]
	public X509ChainElementCollection get_ChainElements() { }

	[Address(RVA = "0x178FB50", Offset = "0x178ED50", Length = "0x72")]
	[CalledBy(Type = typeof(MobileTlsContext), Member = "SelectClientCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(X509Certificate))]
	[CalledBy(Type = typeof(MonoBtlsContext), Member = "SetPrivateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateImplBtls)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(X509Helper2), Member = "GetInvalidChainContextException", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000759")]
	public X509ChainPolicy get_ChainPolicy() { }

	[Address(RVA = "0x178FBD0", Offset = "0x178EDD0", Length = "0x54")]
	[CalledBy(Type = typeof(UnityTlsProvider), Member = "ValidateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainValidationHelper), typeof(string), typeof(bool), typeof(X509CertificateCollection), typeof(bool), typeof(X509Chain&), typeof(SslPolicyErrors&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "ValidateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainValidationHelper), typeof(string), typeof(bool), typeof(X509CertificateCollection), typeof(bool), typeof(X509Chain&), typeof(SslPolicyErrors&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "CheckValidationResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainValidationHelper), typeof(string), typeof(bool), typeof(X509CertificateCollection), typeof(bool), typeof(X509Chain), typeof(MonoBtlsX509StoreCtx), typeof(bool), typeof(SslPolicyErrors&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(X509Helper2), Member = "GetInvalidChainContextException", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000753")]
	internal X509ChainImpl get_Impl() { }

	[Address(RVA = "0x178F890", Offset = "0x178EA90", Length = "0x72")]
	[CalledBy(Type = typeof(MobileTlsContext), Member = "SelectClientCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(X509Certificate))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(X509Helper2), Member = "GetInvalidChainContextException", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600075B")]
	public void Reset() { }

}

