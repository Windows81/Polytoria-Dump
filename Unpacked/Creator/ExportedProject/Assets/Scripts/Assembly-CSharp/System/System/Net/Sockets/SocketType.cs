namespace System.Net.Sockets;

[Token(Token = "0x20002FB")]
public enum SocketType
{
	Stream = 1,
	Dgram = 2,
	Raw = 3,
	Rdm = 4,
	Seqpacket = 5,
	Unknown = -1,
}

