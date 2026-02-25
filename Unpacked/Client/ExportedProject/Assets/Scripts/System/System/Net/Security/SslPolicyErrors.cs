namespace System.Net.Security;

[Flags]
[Token(Token = "0x2000317")]
public enum SslPolicyErrors
{
	None = 0,
	RemoteCertificateNotAvailable = 1,
	RemoteCertificateNameMismatch = 2,
	RemoteCertificateChainErrors = 4,
}

