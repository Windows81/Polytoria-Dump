namespace Mirror;

[Token(Token = "0x20000A1")]
public enum TransportError
{
	DnsResolve = 0,
	Refused = 1,
	Timeout = 2,
	Congestion = 3,
	InvalidReceive = 4,
	InvalidSend = 5,
	ConnectionClosed = 6,
	Unexpected = 7,
}

