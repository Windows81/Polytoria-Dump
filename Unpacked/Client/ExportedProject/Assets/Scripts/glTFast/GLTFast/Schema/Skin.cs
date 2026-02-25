namespace GLTFast.Schema;

[Token(Token = "0x20000CF")]
public class Skin : NamedObject
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002E4")]
	public int inverseBindMatrices; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40002E5")]
	public int skeleton; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002E6")]
	public UInt32[] joints; //Field offset: 0x20

	[Address(RVA = "0x107A5D0", Offset = "0x10797D0", Length = "0xF")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600026B")]
	public Skin() { }

}

