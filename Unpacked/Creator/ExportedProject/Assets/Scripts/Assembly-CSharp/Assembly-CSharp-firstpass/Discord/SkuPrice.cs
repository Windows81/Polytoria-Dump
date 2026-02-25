namespace Discord;

[Token(Token = "0x20001E0")]
public struct SkuPrice
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000703")]
	public uint Amount; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000704")]
	public string Currency; //Field offset: 0x8

}

