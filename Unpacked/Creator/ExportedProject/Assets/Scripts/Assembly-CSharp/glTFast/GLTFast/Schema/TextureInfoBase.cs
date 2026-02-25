namespace GLTFast.Schema;

[Token(Token = "0x20000D8")]
public abstract class TextureInfoBase
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002EF")]
	public int index; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40002F0")]
	public int texCoord; //Field offset: 0x14

	[Token(Token = "0x17000088")]
	public abstract TextureInfoExtensions Extensions
	{
		[Token(Token = "0x600027B")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x10787E0", Offset = "0x10779E0", Length = "0xE")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600027C")]
	protected TextureInfoBase() { }

	[Token(Token = "0x600027B")]
	public abstract TextureInfoExtensions get_Extensions() { }

}

