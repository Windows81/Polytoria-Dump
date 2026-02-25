namespace GLTFast.FakeSchema;

[Token(Token = "0x2000072")]
internal class MaterialExtension
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001F9")]
	public string KHR_materials_pbrSpecularGlossiness; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001FA")]
	public string KHR_materials_unlit; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001FB")]
	public string KHR_materials_transmission; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001FC")]
	public string KHR_materials_clearcoat; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001FD")]
	public string KHR_materials_sheen; //Field offset: 0x30

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001A2")]
	public MaterialExtension() { }

}

