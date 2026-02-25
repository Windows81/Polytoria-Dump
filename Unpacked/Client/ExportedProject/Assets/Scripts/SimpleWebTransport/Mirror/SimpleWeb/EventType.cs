namespace Mirror.SimpleWeb;

[Token(Token = "0x2000014")]
public enum EventType
{
	Connected = 0,
	Data = 1,
	Disconnected = 2,
	Error = 3,
}

