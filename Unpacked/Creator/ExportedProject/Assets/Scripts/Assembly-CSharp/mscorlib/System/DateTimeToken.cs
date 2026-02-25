namespace System;

[Token(Token = "0x20000E6")]
internal struct DateTimeToken
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400037F")]
	internal DTT dtt; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000380")]
	internal TokenType suffix; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000381")]
	internal int num; //Field offset: 0x8

}

