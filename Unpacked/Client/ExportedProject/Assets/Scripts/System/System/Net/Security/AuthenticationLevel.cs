namespace System.Net.Security;

[Token(Token = "0x2000313")]
public enum AuthenticationLevel
{
	None = 0,
	MutualAuthRequested = 1,
	MutualAuthRequired = 2,
}

