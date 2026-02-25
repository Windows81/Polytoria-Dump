namespace System;

[Token(Token = "0x20001DC")]
internal struct InputRecord
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400094B")]
	public short EventType; //Field offset: 0x0
	[FieldOffset(Offset = "0x2")]
	[Token(Token = "0x400094C")]
	public bool KeyDown; //Field offset: 0x2
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400094D")]
	public short RepeatCount; //Field offset: 0x4
	[FieldOffset(Offset = "0x6")]
	[Token(Token = "0x400094E")]
	public short VirtualKeyCode; //Field offset: 0x6
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400094F")]
	public short VirtualScanCode; //Field offset: 0x8
	[FieldOffset(Offset = "0xA")]
	[Token(Token = "0x4000950")]
	public char Character; //Field offset: 0xA
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000951")]
	public int ControlKeyState; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000952")]
	private int pad1; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000953")]
	private bool pad2; //Field offset: 0x14

}

