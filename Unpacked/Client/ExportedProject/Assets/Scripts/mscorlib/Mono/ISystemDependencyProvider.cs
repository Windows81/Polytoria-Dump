namespace Mono;

[Token(Token = "0x200002F")]
internal interface ISystemDependencyProvider
{

	[Token(Token = "0x17000004")]
	public ISystemCertificateProvider CertificateProvider
	{
		[Token(Token = "0x6000052")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000052")]
	public ISystemCertificateProvider get_CertificateProvider() { }

}

