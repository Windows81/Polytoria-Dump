namespace Mirror;

[Token(Token = "0x200000C")]
internal enum ServerMainEventType
{
	OnServerConnected = 0,
	OnServerSent = 1,
	OnServerReceived = 2,
	OnServerError = 3,
	OnServerDisconnected = 4,
}

