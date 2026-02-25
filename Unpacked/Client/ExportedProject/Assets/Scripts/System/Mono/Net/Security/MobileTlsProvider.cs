namespace Mono.Net.Security;

[Token(Token = "0x200005D")]
internal abstract class MobileTlsProvider : MonoTlsProvider
{

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000140")]
	protected MobileTlsProvider() { }

	[Token(Token = "0x600013E")]
	internal abstract MobileAuthenticatedStream CreateSslStream(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings) { }

	[Token(Token = "0x600013F")]
	internal abstract bool ValidateCertificate(ChainValidationHelper validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, ref X509Chain chain, ref SslPolicyErrors errors, ref int status11) { }

}

