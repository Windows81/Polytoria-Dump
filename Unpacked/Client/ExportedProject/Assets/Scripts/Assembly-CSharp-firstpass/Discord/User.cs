namespace Discord;

[Token(Token = "0x20001CF")]
public struct User
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006C4")]
	public long Id; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40006C5")]
	public string Username; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006C6")]
	public string Discriminator; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40006C7")]
	public string Avatar; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40006C8")]
	public bool Bot; //Field offset: 0x20

}

