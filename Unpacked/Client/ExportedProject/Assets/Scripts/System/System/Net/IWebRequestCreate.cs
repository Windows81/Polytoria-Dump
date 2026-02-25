namespace System.Net;

[Token(Token = "0x200022E")]
public interface IWebRequestCreate
{

	[Token(Token = "0x6000E0A")]
	public WebRequest Create(Uri uri) { }

}

