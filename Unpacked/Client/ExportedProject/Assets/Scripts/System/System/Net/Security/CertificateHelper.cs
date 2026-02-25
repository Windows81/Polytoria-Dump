namespace System.Net.Security;

[Token(Token = "0x200030F")]
internal static class CertificateHelper
{

	[Address(RVA = "0x1717FD0", Offset = "0x17171D0", Length = "0x100")]
	[CalledBy(Type = "System.Net.Http.HttpClientHandler", Member = "<set_ClientCertificateOptions>b__23_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(X509CertificateCollection), typeof(X509Certificate), "System.String[]"}, ReturnType = typeof(X509Certificate))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(X509CertificateCollection), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateCollection)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509Certificate2Collection), Member = "GetEnumerator", ReturnType = typeof(X509Certificate2Enumerator))]
	[Calls(Type = typeof(X509Certificate2Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(X509Certificate2Enumerator), Member = "get_Current", ReturnType = typeof(X509Certificate2))]
	[Calls(Type = typeof(X509Certificate2), Member = "get_HasPrivateKey", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CertificateHelper), Member = "IsValidClientCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60013C7")]
	internal static X509Certificate2 GetEligibleClientCertificate(X509CertificateCollection candidateCerts) { }

	[Address(RVA = "0x1717F30", Offset = "0x1717130", Length = "0x91")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509Certificate2Collection), Member = "GetEnumerator", ReturnType = typeof(X509Certificate2Enumerator))]
	[Calls(Type = typeof(X509Certificate2Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(X509Certificate2Enumerator), Member = "get_Current", ReturnType = typeof(X509Certificate2))]
	[Calls(Type = typeof(X509Certificate2), Member = "get_HasPrivateKey", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CertificateHelper), Member = "IsValidClientCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60013C8")]
	internal static X509Certificate2 GetEligibleClientCertificate(X509Certificate2Collection candidateCerts) { }

	[Address(RVA = "0x17180E0", Offset = "0x17172E0", Length = "0x195")]
	[CalledBy(Type = "System.Net.Http.HttpClientHandler+<>c", Member = "<set_ClientCertificateOptions>b__23_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string), typeof(X509CertificateCollection), typeof(X509Certificate), "System.String[]"}, ReturnType = typeof(X509Certificate))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(X509Store), Member = "get_Certificates", ReturnType = typeof(X509Certificate2Collection))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(X509Store), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StoreName), typeof(StoreLocation)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(X509Store), Member = "Open", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OpenFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(X509Certificate2Collection), Member = "GetEnumerator", ReturnType = typeof(X509Certificate2Enumerator))]
	[Calls(Type = typeof(X509Certificate2Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(X509Certificate2Enumerator), Member = "get_Current", ReturnType = typeof(X509Certificate2))]
	[Calls(Type = typeof(X509Certificate2), Member = "get_HasPrivateKey", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CertificateHelper), Member = "IsValidClientCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60013CC")]
	internal static X509Certificate2 GetEligibleClientCertificate() { }

	[Address(RVA = "0x1718280", Offset = "0x1717480", Length = "0xE4")]
	[CalledBy(Type = typeof(CertificateHelper), Member = "GetEligibleClientCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509CertificateCollection)}, ReturnType = typeof(X509Certificate2))]
	[CalledBy(Type = typeof(CertificateHelper), Member = "GetEligibleClientCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2Collection)}, ReturnType = typeof(X509Certificate2))]
	[CalledBy(Type = typeof(CertificateHelper), Member = "GetEligibleClientCertificate", ReturnType = typeof(X509Certificate2))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(X509Certificate2), Member = "get_Extensions", ReturnType = typeof(X509ExtensionCollection))]
	[Calls(Type = typeof(X509ExtensionCollection), Member = "GetEnumerator", ReturnType = typeof(X509ExtensionEnumerator))]
	[Calls(Type = typeof(X509ExtensionEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(X509ExtensionEnumerator), Member = "get_Current", ReturnType = typeof(X509Extension))]
	[Calls(Type = typeof(CertificateHelper), Member = "IsValidForClientAuthenticationEKU", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509EnhancedKeyUsageExtension)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(X509KeyUsageExtension), Member = "get_KeyUsages", ReturnType = typeof(X509KeyUsageFlags))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60013C9")]
	private static bool IsValidClientCertificate(X509Certificate2 cert) { }

	[Address(RVA = "0x1718370", Offset = "0x1717570", Length = "0x99")]
	[CalledBy(Type = typeof(CertificateHelper), Member = "IsValidClientCertificate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(X509Certificate2)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(X509EnhancedKeyUsageExtension), Member = "get_EnhancedKeyUsages", ReturnType = typeof(OidCollection))]
	[Calls(Type = typeof(OidEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x60013CA")]
	private static bool IsValidForClientAuthenticationEKU(X509EnhancedKeyUsageExtension eku) { }

	[Address(RVA = "0x1718410", Offset = "0x1717610", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(X509KeyUsageExtension), Member = "get_KeyUsages", ReturnType = typeof(X509KeyUsageFlags))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60013CB")]
	private static bool IsValidForDigitalSignatureUsage(X509KeyUsageExtension ku) { }

}

