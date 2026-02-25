namespace GLTFast.Schema;

[Token(Token = "0x20000C3")]
public abstract class OcclusionTextureInfoBase : OcclusionTextureInfoBase
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40002B4")]
	public TExtensions extensions; //Field offset: 0x0

	[Token(Token = "0x17000062")]
	public virtual TextureInfoExtensions Extensions
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000236")]
		 get { } //Length: 5
	}

	[Address(RVA = "0xE2B3E0", Offset = "0xE2A5E0", Length = "0x7")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000237")]
	protected OcclusionTextureInfoBase`1() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000236")]
	public virtual TextureInfoExtensions get_Extensions() { }

}

