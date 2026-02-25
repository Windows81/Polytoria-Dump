namespace TMPro;

[Token(Token = "0x20000AB")]
public class TMP_TextElement_Legacy
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400063B")]
	public int id; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400063C")]
	public float x; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400063D")]
	public float y; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400063E")]
	public float width; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400063F")]
	public float height; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000640")]
	public float xOffset; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000641")]
	public float yOffset; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000642")]
	public float xAdvance; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000643")]
	public float scale; //Field offset: 0x30

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000684")]
	public TMP_TextElement_Legacy() { }

}

