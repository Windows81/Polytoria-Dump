namespace TMPro;

[Token(Token = "0x20000B6")]
public struct CaretInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000680")]
	public int index; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000681")]
	public CaretPosition position; //Field offset: 0x4

	[Address(RVA = "0x3AFE70", Offset = "0x3AF070", Length = "0x7")]
	[CallerCount(Count = 47)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006DF")]
	public CaretInfo(int index, CaretPosition position) { }

}

