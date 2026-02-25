namespace GLTFast.Schema;

[Token(Token = "0x20000A4")]
public abstract class PbrMetallicRoughnessBase : PbrMetallicRoughnessBase
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000273")]
	public TTextureInfo baseColorTexture; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000274")]
	public TTextureInfo metallicRoughnessTexture; //Field offset: 0x0

	[Token(Token = "0x17000054")]
	public virtual TextureInfoBase BaseColorTexture
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001FE")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000055")]
	public virtual TextureInfoBase MetallicRoughnessTexture
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001FF")]
		 get { } //Length: 5
	}

	[Address(RVA = "0xE66C70", Offset = "0xE65E70", Length = "0x7")]
	[CalledBy(Type = typeof(PbrMetallicRoughness), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PbrMetallicRoughnessBase), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000200")]
	protected PbrMetallicRoughnessBase`1() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001FE")]
	public virtual TextureInfoBase get_BaseColorTexture() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001FF")]
	public virtual TextureInfoBase get_MetallicRoughnessTexture() { }

}

