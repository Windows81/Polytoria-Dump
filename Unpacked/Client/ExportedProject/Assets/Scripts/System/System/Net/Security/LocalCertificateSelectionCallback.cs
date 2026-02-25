namespace System.Net.Security;

[Token(Token = "0x2000315")]
public sealed class LocalCertificateSelectionCallback : MulticastDelegate
{

	[Address(RVA = "0x1718D40", Offset = "0x1717F40", Length = "0x125")]
	[CalledBy(Type = "System.Net.Http.HttpClientHandler", Member = "set_ClientCertificateOptions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Net.Http.ClientCertificateOption"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x60013E8")]
	public LocalCertificateSelectionCallback(object object, IntPtr method) { }

	[Address(RVA = "0x335810", Offset = "0x334A10", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013E9")]
	public override X509Certificate Invoke(object sender, string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, String[] acceptableIssuers) { }

}

