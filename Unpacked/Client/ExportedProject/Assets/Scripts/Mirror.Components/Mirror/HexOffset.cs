namespace Mirror;

[Token(Token = "0x2000011")]
internal struct HexOffset
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400003B")]
	internal int qOffset; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400003C")]
	internal int rOffset; //Field offset: 0x4

	[Address(RVA = "0x3AFE70", Offset = "0x3AF070", Length = "0x7")]
	[CallerCount(Count = 47)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000049")]
	internal HexOffset(int q, int r) { }

}

