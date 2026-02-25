namespace GLTFast.Schema;

[Token(Token = "0x20000AA")]
public class Transmission
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400027A")]
	public float transmissionFactor; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400027B")]
	public TextureInfo transmissionTexture; //Field offset: 0x18

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600020A")]
	public Transmission() { }

}

