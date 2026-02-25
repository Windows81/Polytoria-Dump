namespace GLTFast.FakeSchema;

[Token(Token = "0x2000073")]
internal class Mesh : NamedObject
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001FE")]
	public MeshPrimitive[] primitives; //Field offset: 0x10

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001A3")]
	public Mesh() { }

}

