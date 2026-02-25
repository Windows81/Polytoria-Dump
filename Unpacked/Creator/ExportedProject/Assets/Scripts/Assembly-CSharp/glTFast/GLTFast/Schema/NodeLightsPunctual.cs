namespace GLTFast.Schema;

[Token(Token = "0x20000BE")]
public class NodeLightsPunctual
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002B1")]
	public int light; //Field offset: 0x10

	[Address(RVA = "0x10787E0", Offset = "0x10779E0", Length = "0xE")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000230")]
	public NodeLightsPunctual() { }

}

