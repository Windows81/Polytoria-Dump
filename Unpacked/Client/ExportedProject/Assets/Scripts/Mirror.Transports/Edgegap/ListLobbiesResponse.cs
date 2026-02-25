namespace Edgegap;

[Token(Token = "0x2000036")]
public struct ListLobbiesResponse
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000144")]
	public int count; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000145")]
	public LobbyBrief[] data; //Field offset: 0x8

}

