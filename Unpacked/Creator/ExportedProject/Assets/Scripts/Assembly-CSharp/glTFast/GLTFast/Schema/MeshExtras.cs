namespace GLTFast.Schema;

[Token(Token = "0x20000AF")]
public class MeshExtras
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400027F")]
	public String[] targetNames; //Field offset: 0x10

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000214")]
	public MeshExtras() { }

}

