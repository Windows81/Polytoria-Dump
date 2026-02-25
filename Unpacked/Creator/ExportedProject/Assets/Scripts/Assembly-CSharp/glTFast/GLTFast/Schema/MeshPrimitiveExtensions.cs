namespace GLTFast.Schema;

[Token(Token = "0x20000B7")]
public class MeshPrimitiveExtensions
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002A1")]
	public MaterialsVariantsMeshPrimitiveExtension KHR_materials_variants; //Field offset: 0x10

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000222")]
	public MeshPrimitiveExtensions() { }

}

