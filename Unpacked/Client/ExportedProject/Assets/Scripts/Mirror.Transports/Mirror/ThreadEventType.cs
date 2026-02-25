namespace Mirror;

[Token(Token = "0x200000D")]
internal enum ThreadEventType
{
	DoServerStart = 0,
	DoServerSend = 1,
	DoServerDisconnect = 2,
	DoServerStop = 3,
	DoClientConnect = 4,
	DoClientSend = 5,
	DoClientDisconnect = 6,
	Sleep = 7,
	Wake = 8,
	DoShutdown = 9,
}

