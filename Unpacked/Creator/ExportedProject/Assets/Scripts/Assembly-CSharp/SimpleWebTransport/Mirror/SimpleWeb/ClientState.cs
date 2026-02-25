namespace Mirror.SimpleWeb;

[Token(Token = "0x2000006")]
public enum ClientState
{
	NotConnected = 0,
	Connecting = 1,
	Connected = 2,
	Disconnecting = 3,
}

