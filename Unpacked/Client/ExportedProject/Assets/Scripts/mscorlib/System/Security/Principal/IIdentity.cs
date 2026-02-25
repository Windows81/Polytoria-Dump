namespace System.Security.Principal;

[Token(Token = "0x2000329")]
public interface IIdentity
{

	[Token(Token = "0x170002A9")]
	public string AuthenticationType
	{
		[Token(Token = "0x6001975")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002A8")]
	public string Name
	{
		[Token(Token = "0x6001974")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6001975")]
	public string get_AuthenticationType() { }

	[Token(Token = "0x6001974")]
	public string get_Name() { }

}

