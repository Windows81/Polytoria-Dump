namespace Mirror.SimpleWeb;

[Token(Token = "0x2000005")]
public enum WebsocketPortOption
{
	DefaultSameAsServer = 0,
	MatchWebpageProtocol = 1,
	SpecifyPort = 2,
}

