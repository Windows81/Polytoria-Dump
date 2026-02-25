namespace Mono.Net.Security;

[Token(Token = "0x2000065")]
internal static class SystemCertificateValidator
{
	[Token(Token = "0x400012B")]
	private static bool is_macosx; //Field offset: 0x0
	[Token(Token = "0x400012C")]
	private static X509KeyUsageFlags s_flags; //Field offset: 0x4

	[Address(RVA = "0x15FDC10", Offset = "0x15FCE10", Length = "0x4B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000186")]
	private static SystemCertificateValidator() { }

	[Address(RVA = "0x2DC110", Offset = "0x2DB310", Length = "0x3")]
	[CallerCount(Count = 137)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000187")]
	internal static bool NeedsChain(MonoTlsSettings settings) { }

}

