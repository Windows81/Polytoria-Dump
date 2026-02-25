namespace GLTFast.Schema;

[Token(Token = "0x20000CE")]
public class Scene : NamedObject
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002E3")]
	public UInt32[] nodes; //Field offset: 0x18

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600026A")]
	public Scene() { }

}

