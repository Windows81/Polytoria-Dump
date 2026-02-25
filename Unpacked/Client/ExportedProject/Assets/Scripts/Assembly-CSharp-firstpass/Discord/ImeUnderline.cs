namespace Discord;

[Token(Token = "0x20001DC")]
public struct ImeUnderline
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006F4")]
	public int From; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40006F5")]
	public int To; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40006F6")]
	public uint Color; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x40006F7")]
	public uint BackgroundColor; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006F8")]
	public bool Thick; //Field offset: 0x10

}

