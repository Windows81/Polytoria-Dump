namespace Discord;

[Token(Token = "0x20001E1")]
public struct Sku
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000705")]
	public long Id; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000706")]
	public SkuType Type; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000707")]
	public string Name; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000708")]
	public SkuPrice Price; //Field offset: 0x18

}

