namespace System.Net;

[Flags]
[Token(Token = "0x200027E")]
public enum DecompressionMethods
{
	None = 0,
	GZip = 1,
	Deflate = 2,
}

