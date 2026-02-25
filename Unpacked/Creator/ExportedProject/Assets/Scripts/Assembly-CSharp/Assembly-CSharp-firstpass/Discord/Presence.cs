namespace Discord;

[Token(Token = "0x20001D9")]
public struct Presence
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006E9")]
	public Status Status; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40006EA")]
	public Activity Activity; //Field offset: 0x8

}

