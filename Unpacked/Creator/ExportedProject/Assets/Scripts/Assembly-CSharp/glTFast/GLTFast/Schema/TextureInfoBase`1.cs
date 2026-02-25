namespace GLTFast.Schema;

[Token(Token = "0x20000D7")]
public abstract class TextureInfoBase : TextureInfoBase
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002EE")]
	public TExtensions extensions; //Field offset: 0x0

	[Token(Token = "0x17000087")]
	public virtual TextureInfoExtensions Extensions
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000279")]
		 get { } //Length: 5
	}

	[Address(RVA = "0xFF7F70", Offset = "0xFF7170", Length = "0x7")]
	[CalledBy(Type = typeof(TextureInfo), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600027A")]
	protected TextureInfoBase`1() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000279")]
	public virtual TextureInfoExtensions get_Extensions() { }

}

