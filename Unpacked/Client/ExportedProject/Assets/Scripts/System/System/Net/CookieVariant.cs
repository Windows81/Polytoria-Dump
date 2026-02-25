namespace System.Net;

[Token(Token = "0x200025A")]
internal enum CookieVariant
{
	Unknown = 0,
	Plain = 1,
	Rfc2109 = 2,
	Rfc2965 = 3,
	Default = 2,
}

