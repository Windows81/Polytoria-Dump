namespace System.Net.Security;

[Token(Token = "0x2000318")]
internal sealed class LocalCertSelectionCallback : MulticastDelegate
{

	[Address(RVA = "0x12CD4C0", Offset = "0x12CC6C0", Length = "0xB5")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x60013EC")]
	public LocalCertSelectionCallback(object object, IntPtr method) { }

	[Address(RVA = "0x335660", Offset = "0x334860", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013ED")]
	public override X509Certificate Invoke(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, String[] acceptableIssuers) { }

}

