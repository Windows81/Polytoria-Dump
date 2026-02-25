namespace System.Net;

[Flags]
[Token(Token = "0x200024C")]
internal enum CloseExState
{
	Normal = 0,
	Abort = 1,
	Silent = 2,
}

