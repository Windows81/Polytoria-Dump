namespace Mono.Security.Interface;

[Token(Token = "0x2000041")]
public sealed class MonoLocalCertificateSelectionCallback : MulticastDelegate
{

	[Address(RVA = "0x12CD4C0", Offset = "0x12CC6C0", Length = "0xB5")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000150")]
	public MonoLocalCertificateSelectionCallback(object object, IntPtr method) { }

	[Address(RVA = "0x335660", Offset = "0x334860", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000151")]
	public override X509Certificate Invoke(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, String[] acceptableIssuers) { }

}

