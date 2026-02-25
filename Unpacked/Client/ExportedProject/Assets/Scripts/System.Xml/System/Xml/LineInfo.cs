namespace System.Xml;

[Token(Token = "0x2000090")]
internal struct LineInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000356")]
	internal int lineNo; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000357")]
	internal int linePos; //Field offset: 0x4

	[Address(RVA = "0x3AFE70", Offset = "0x3AF070", Length = "0x7")]
	[CallerCount(Count = 47)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006B7")]
	public LineInfo(int lineNo, int linePos) { }

	[Address(RVA = "0x3AFE70", Offset = "0x3AF070", Length = "0x7")]
	[CallerCount(Count = 47)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006B8")]
	public void Set(int lineNo, int linePos) { }

}

