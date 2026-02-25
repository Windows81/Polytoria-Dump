namespace System.Net;

[Token(Token = "0x200022A")]
public interface IAuthenticationModule
{

	[Token(Token = "0x170002C2")]
	public string AuthenticationType
	{
		[Token(Token = "0x6000E01")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000DFF")]
	public Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials) { }

	[Token(Token = "0x6000E01")]
	public string get_AuthenticationType() { }

	[Token(Token = "0x6000E00")]
	public Authorization PreAuthenticate(WebRequest request, ICredentials credentials) { }

}

