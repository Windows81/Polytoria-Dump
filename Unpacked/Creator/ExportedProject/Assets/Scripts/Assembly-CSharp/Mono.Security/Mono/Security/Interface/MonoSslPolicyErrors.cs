namespace Mono.Security.Interface;

[Flags]
[Token(Token = "0x200003F")]
public enum MonoSslPolicyErrors
{
	None = 0,
	RemoteCertificateNotAvailable = 1,
	RemoteCertificateNameMismatch = 2,
	RemoteCertificateChainErrors = 4,
}

