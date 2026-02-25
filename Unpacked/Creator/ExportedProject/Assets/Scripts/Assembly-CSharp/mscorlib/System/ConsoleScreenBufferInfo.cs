namespace System;

[Token(Token = "0x20001DF")]
internal struct ConsoleScreenBufferInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400095A")]
	public Coord Size; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400095B")]
	public Coord CursorPosition; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400095C")]
	public short Attribute; //Field offset: 0x8
	[FieldOffset(Offset = "0xA")]
	[Token(Token = "0x400095D")]
	public SmallRect Window; //Field offset: 0xA
	[FieldOffset(Offset = "0x12")]
	[Token(Token = "0x400095E")]
	public Coord MaxWindowSize; //Field offset: 0x12

}

