namespace Mirror.SimpleWeb;

[Token(Token = "0x2000004")]
public struct ClientWebsocketSettings
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000006")]
	public WebsocketPortOption ClientPortOption; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000007")]
	public ushort CustomClientPort; //Field offset: 0x4

}

