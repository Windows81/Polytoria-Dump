namespace GLTFast.Schema;

[Token(Token = "0x2000080")]
public class AccessorSparseIndices
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000220")]
	public uint bufferView; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000221")]
	public int byteOffset; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000222")]
	public GltfComponentType componentType; //Field offset: 0x18

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001BA")]
	public AccessorSparseIndices() { }

}

