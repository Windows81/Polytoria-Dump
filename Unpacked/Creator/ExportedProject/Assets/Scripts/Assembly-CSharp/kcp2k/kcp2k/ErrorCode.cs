namespace kcp2k;

[Token(Token = "0x2000005")]
public enum ErrorCode
{
	DnsResolve = 0,
	Timeout = 1,
	Congestion = 2,
	InvalidReceive = 3,
	InvalidSend = 4,
	ConnectionClosed = 5,
	Unexpected = 6,
}

