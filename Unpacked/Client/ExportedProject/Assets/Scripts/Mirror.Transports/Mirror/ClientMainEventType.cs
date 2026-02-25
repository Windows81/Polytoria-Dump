namespace Mirror;

[Token(Token = "0x200000B")]
internal enum ClientMainEventType
{
	OnClientConnected = 0,
	OnClientSent = 1,
	OnClientReceived = 2,
	OnClientError = 3,
	OnClientDisconnected = 4,
}

