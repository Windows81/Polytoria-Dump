namespace Discord;

[Token(Token = "0x20001D3")]
public struct ActivityTimestamps
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006D1")]
	public long Start; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40006D2")]
	public long End; //Field offset: 0x8

}

