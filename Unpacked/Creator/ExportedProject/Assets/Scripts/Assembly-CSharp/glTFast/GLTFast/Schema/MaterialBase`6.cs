namespace GLTFast.Schema;

[Token(Token = "0x200009E")]
public abstract class MaterialBase : MaterialBase
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000260")]
	public TTextureInfo emissiveTexture; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000261")]
	public TExtensions extensions; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000262")]
	public TNormalTextureInfo normalTexture; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000263")]
	public TOcclusionTextureInfo occlusionTexture; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000264")]
	public TPbrMetallicRoughness pbrMetallicRoughness; //Field offset: 0x0

	[Token(Token = "0x1700004B")]
	public virtual TextureInfoBase EmissiveTexture
	{
		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001EE")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000047")]
	public virtual MaterialExtensions Extensions
	{
		[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001E9")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000049")]
	public virtual NormalTextureInfoBase NormalTexture
	{
		[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001EC")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700004A")]
	public virtual OcclusionTextureInfoBase OcclusionTexture
	{
		[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001ED")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000048")]
	public virtual PbrMetallicRoughnessBase PbrMetallicRoughness
	{
		[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001EB")]
		 get { } //Length: 5
	}

	[Address(RVA = "0xE08810", Offset = "0xE07A10", Length = "0x7")]
	[CalledBy(Type = typeof(Material), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MaterialBase), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x60001EF")]
	protected MaterialBase`6() { }

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001EE")]
	public virtual TextureInfoBase get_EmissiveTexture() { }

	[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001E9")]
	public virtual MaterialExtensions get_Extensions() { }

	[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001EC")]
	public virtual NormalTextureInfoBase get_NormalTexture() { }

	[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001ED")]
	public virtual OcclusionTextureInfoBase get_OcclusionTexture() { }

	[Address(RVA = "0x3D0130", Offset = "0x3CF330", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001EB")]
	public virtual PbrMetallicRoughnessBase get_PbrMetallicRoughness() { }

	[Address(RVA = "0xE08800", Offset = "0xE07A00", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001EA")]
	internal virtual void UnsetExtensions() { }

}

