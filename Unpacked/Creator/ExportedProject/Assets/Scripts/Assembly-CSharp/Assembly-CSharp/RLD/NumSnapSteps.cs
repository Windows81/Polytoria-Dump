namespace RLD;

[Token(Token = "0x20001BF")]
public struct NumSnapSteps
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000719")]
	public float FltNumSteps; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400071A")]
	public float AbsFltNumSteps; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400071B")]
	public int IntNumSteps; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400071C")]
	public int AbsIntNumSteps; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400071D")]
	public float AbsFracSteps; //Field offset: 0x10

}

