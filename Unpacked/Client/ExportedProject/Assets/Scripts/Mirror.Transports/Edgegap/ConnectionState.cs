namespace Edgegap;

[Token(Token = "0x2000047")]
public enum ConnectionState
{
	Disconnected = 0,
	Checking = 1,
	Valid = 2,
	Invalid = 3,
	SessionTimeout = 4,
	Error = 5,
}

