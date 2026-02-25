namespace System.Net;

[Token(Token = "0x20002A7")]
internal enum ReadState
{
	None = 0,
	Status = 1,
	Headers = 2,
	Content = 3,
	Aborted = 4,
}

