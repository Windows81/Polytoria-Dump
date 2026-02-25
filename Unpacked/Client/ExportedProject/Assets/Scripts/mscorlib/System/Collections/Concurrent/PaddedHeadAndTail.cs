namespace System.Collections.Concurrent;

[DebuggerDisplay("Head = {Head}, Tail = {Tail}")]
[Token(Token = "0x20005C0")]
internal struct PaddedHeadAndTail
{
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400181B")]
	public int Head; //Field offset: 0x80
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x400181C")]
	public int Tail; //Field offset: 0x100

}

