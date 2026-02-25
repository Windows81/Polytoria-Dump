namespace Discord;

[Token(Token = "0x20001D4")]
public struct ActivityAssets
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006D3")]
	public string LargeImage; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40006D4")]
	public string LargeText; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006D5")]
	public string SmallImage; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40006D6")]
	public string SmallText; //Field offset: 0x18

}

