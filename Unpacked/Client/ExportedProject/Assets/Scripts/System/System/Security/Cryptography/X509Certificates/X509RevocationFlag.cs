namespace System.Security.Cryptography.X509Certificates;

[Token(Token = "0x2000121")]
public enum X509RevocationFlag
{
	EndCertificateOnly = 0,
	EntireChain = 1,
	ExcludeRoot = 2,
}

