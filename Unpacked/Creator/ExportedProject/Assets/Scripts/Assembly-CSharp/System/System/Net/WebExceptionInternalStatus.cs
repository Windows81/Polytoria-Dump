namespace System.Net;

[Token(Token = "0x200023C")]
internal enum WebExceptionInternalStatus
{
	RequestFatal = 0,
	ServicePointFatal = 1,
	Recoverable = 2,
	Isolated = 3,
}

