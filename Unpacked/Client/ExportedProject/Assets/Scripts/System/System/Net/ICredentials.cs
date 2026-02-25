namespace System.Net;

[Token(Token = "0x200022C")]
public interface ICredentials
{

	[Token(Token = "0x6000E03")]
	public NetworkCredential GetCredential(Uri uri, string authType) { }

}

