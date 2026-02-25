namespace GLTFast.Schema;

[Token(Token = "0x20000C0")]
public abstract class NormalTextureInfoBase : NormalTextureInfoBase
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002B2")]
	public TExtensions extensions; //Field offset: 0x0

	[Token(Token = "0x17000061")]
	public virtual TextureInfoExtensions Extensions
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000232")]
		 get { } //Length: 5
	}

	[Address(RVA = "0xE2B3E0", Offset = "0xE2A5E0", Length = "0x7")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000233")]
	protected NormalTextureInfoBase`1() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000232")]
	public virtual TextureInfoExtensions get_Extensions() { }

}

