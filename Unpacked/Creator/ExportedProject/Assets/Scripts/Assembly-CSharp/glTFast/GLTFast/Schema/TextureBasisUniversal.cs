namespace GLTFast.Schema;

[Token(Token = "0x20000D5")]
public class TextureBasisUniversal
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002ED")]
	public int source; //Field offset: 0x10

	[Address(RVA = "0x10787E0", Offset = "0x10779E0", Length = "0xE")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000277")]
	public TextureBasisUniversal() { }

}

