namespace System.Net;

[Token(Token = "0x200026D")]
public interface IWebProxy
{

	[Token(Token = "0x17000332")]
	public ICredentials Credentials
	{
		[Token(Token = "0x6000FA0")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000FA0")]
	public ICredentials get_Credentials() { }

	[Token(Token = "0x6000F9E")]
	public Uri GetProxy(Uri destination) { }

	[Token(Token = "0x6000F9F")]
	public bool IsBypassed(Uri host) { }

}

