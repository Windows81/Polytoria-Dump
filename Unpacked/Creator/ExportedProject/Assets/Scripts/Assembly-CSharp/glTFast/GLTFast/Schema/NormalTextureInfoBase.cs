namespace GLTFast.Schema;

[Token(Token = "0x20000C1")]
public abstract class NormalTextureInfoBase : TextureInfoBase
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002B3")]
	public float scale; //Field offset: 0x18

	[Address(RVA = "0x1078830", Offset = "0x1077A30", Length = "0x15")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000234")]
	protected NormalTextureInfoBase() { }

}

