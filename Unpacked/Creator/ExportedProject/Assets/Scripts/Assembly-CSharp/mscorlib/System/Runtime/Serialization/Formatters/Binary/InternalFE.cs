namespace System.Runtime.Serialization.Formatters.Binary;

[Token(Token = "0x2000426")]
internal sealed class InternalFE
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001156")]
	internal FormatterTypeStyle FEtypeFormat; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4001157")]
	internal FormatterAssemblyStyle FEassemblyFormat; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001158")]
	internal TypeFilterLevel FEsecurityLevel; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4001159")]
	internal InternalSerializerTypeE FEserializerTypeEnum; //Field offset: 0x1C

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001F3F")]
	public InternalFE() { }

}

