namespace GLTFast.Schema;

[Token(Token = "0x2000089")]
public class Buffer : NamedObject
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000236")]
	public string uri; //Field offset: 0x18

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001C6")]
	public Buffer() { }

}

