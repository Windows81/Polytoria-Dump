namespace GLTFast.Schema;

[Token(Token = "0x20000C4")]
public abstract class OcclusionTextureInfoBase : TextureInfoBase
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002B5")]
	public float strength; //Field offset: 0x18

	[Address(RVA = "0x1078830", Offset = "0x1077A30", Length = "0x15")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000238")]
	protected OcclusionTextureInfoBase() { }

}

