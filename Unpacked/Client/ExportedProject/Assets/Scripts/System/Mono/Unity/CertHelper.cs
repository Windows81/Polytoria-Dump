namespace Mono.Unity;

[Token(Token = "0x2000008")]
internal static class CertHelper
{

	[Address(RVA = "0x15EE2B0", Offset = "0x15ED4B0", Length = "0x128")]
	[CalledBy(Type = typeof(UnityTlsProvider), Member = "ValidateCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChainValidationHelper), typeof(string), typeof(bool), typeof(X509CertificateCollection), typeof(bool), typeof(X509Chain&), typeof(SslPolicyErrors&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(X509CertificateCollection), Member = "GetEnumerator", ReturnType = typeof(X509CertificateEnumerator))]
	[Calls(Type = typeof(X509CertificateEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(X509CertificateEnumerator), Member = "get_Current", ReturnType = typeof(X509Certificate))]
	[Calls(Type = typeof(CertHelper), Member = "AddCertificateToNativeChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(unitytls_x509list*), typeof(X509Certificate), typeof(unitytls_errorstate*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Token(Token = "0x6000023")]
	public static void AddCertificatesToNativeChain(unitytls_x509list* nativeCertificateChain, X509CertificateCollection certificates, unitytls_errorstate* errorState) { }

	[Address(RVA = "0x15EE0E0", Offset = "0x15ED2E0", Length = "0x1C9")]
	[CalledBy(Type = typeof(CertHelper), Member = "AddCertificatesToNativeChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(unitytls_x509list*), typeof(X509CertificateCollection), typeof(unitytls_errorstate*)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CertHelper), Member = "AddCertificateToNativeChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(unitytls_x509list*), typeof(X509Certificate), typeof(unitytls_errorstate*)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnityTlsContext), Member = "ExtractNativeKeyAndChainFromManagedCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate), typeof(unitytls_errorstate*), typeof(unitytls_x509list*&), typeof(unitytls_key*&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(X509CertificateImplCollection), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityTls), Member = "get_NativeInterface", ReturnType = typeof(unitytls_interface_struct))]
	[Calls(Type = typeof(X509CertificateImplCollection), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "System.Security.Cryptography.X509Certificates.X509CertificateImpl")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(X509Certificate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Security.Cryptography.X509Certificates.X509CertificateImpl"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CertHelper), Member = "AddCertificateToNativeChain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(unitytls_x509list*), typeof(X509Certificate), typeof(unitytls_errorstate*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000024")]
	public static void AddCertificateToNativeChain(unitytls_x509list* nativeCertificateChain, X509Certificate certificate, unitytls_errorstate* errorState) { }

}

