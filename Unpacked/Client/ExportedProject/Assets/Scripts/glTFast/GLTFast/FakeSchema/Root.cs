namespace GLTFast.FakeSchema;

[Token(Token = "0x2000077")]
internal class Root
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000201")]
	public Material[] materials; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000202")]
	public Mesh[] meshes; //Field offset: 0x18

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001A7")]
	public Root() { }

}

