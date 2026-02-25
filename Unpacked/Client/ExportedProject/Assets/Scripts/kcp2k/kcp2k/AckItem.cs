namespace kcp2k;

[Token(Token = "0x2000013")]
internal struct AckItem
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400005B")]
	internal uint serialNumber; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400005C")]
	internal uint timestamp; //Field offset: 0x4

}

