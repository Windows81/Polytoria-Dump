namespace System.Net;

[Token(Token = "0x200022B")]
public interface ICertificatePolicy
{

	[Token(Token = "0x6000E02")]
	public bool CheckValidationResult(ServicePoint srvPoint, X509Certificate certificate, WebRequest request, int certificateProblem) { }

}

