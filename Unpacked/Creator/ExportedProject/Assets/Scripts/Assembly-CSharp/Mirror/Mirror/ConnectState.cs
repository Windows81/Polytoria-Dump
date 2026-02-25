namespace Mirror;

[Token(Token = "0x200003C")]
public enum ConnectState
{
	None = 0,
	Connecting = 1,
	Connected = 2,
	Disconnecting = 3,
	Disconnected = 4,
}

