namespace System.Net.Http.Headers;

[Flags]
[Token(Token = "0x2000028")]
internal enum HttpHeaderKind
{
	None = 0,
	Request = 1,
	Response = 2,
	Content = 4,
}

