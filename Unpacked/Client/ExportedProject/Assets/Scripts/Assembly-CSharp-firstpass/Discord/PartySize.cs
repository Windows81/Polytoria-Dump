namespace Discord;

[Token(Token = "0x20001D5")]
public struct PartySize
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006D7")]
	public int CurrentSize; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40006D8")]
	public int MaxSize; //Field offset: 0x4

}

