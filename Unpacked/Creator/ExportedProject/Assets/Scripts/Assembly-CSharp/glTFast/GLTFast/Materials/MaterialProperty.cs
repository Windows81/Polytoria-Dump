namespace GLTFast.Materials;

[Token(Token = "0x20000DE")]
public static class MaterialProperty
{
	[Token(Token = "0x400032A")]
	public static readonly int AlphaCutoff; //Field offset: 0x0
	[Token(Token = "0x400032B")]
	public static readonly int BaseColor; //Field offset: 0x4
	[Token(Token = "0x400032C")]
	public static readonly int BaseColorTexture; //Field offset: 0x8
	[Token(Token = "0x400032D")]
	public static readonly int BaseColorTextureRotation; //Field offset: 0xC
	[Token(Token = "0x400032E")]
	public static readonly int BaseColorTextureScaleTransform; //Field offset: 0x10
	[Token(Token = "0x400032F")]
	public static readonly int BaseColorTextureTexCoord; //Field offset: 0x14
	[Token(Token = "0x4000330")]
	public static readonly int Cull; //Field offset: 0x18
	[Token(Token = "0x4000331")]
	public static readonly int CullMode; //Field offset: 0x1C
	[Token(Token = "0x4000332")]
	public static readonly int DstBlend; //Field offset: 0x20
	[Token(Token = "0x4000333")]
	public static readonly int DiffuseFactor; //Field offset: 0x24
	[Token(Token = "0x4000334")]
	public static readonly int DiffuseTexture; //Field offset: 0x28
	[Token(Token = "0x4000335")]
	public static readonly int DiffuseTextureScaleTransform; //Field offset: 0x2C
	[Token(Token = "0x4000336")]
	public static readonly int DiffuseTextureRotation; //Field offset: 0x30
	[Token(Token = "0x4000337")]
	public static readonly int DiffuseTextureTexCoord; //Field offset: 0x34
	[Token(Token = "0x4000338")]
	public static readonly int EmissiveFactor; //Field offset: 0x38
	[Token(Token = "0x4000339")]
	public static readonly int EmissiveTexture; //Field offset: 0x3C
	[Token(Token = "0x400033A")]
	public static readonly int EmissiveTextureRotation; //Field offset: 0x40
	[Token(Token = "0x400033B")]
	public static readonly int EmissiveTextureScaleTransform; //Field offset: 0x44
	[Token(Token = "0x400033C")]
	public static readonly int EmissiveTextureTexCoord; //Field offset: 0x48
	[Token(Token = "0x400033D")]
	public static readonly int GlossinessFactor; //Field offset: 0x4C
	[Token(Token = "0x400033E")]
	public static readonly int NormalTexture; //Field offset: 0x50
	[Token(Token = "0x400033F")]
	public static readonly int NormalTextureRotation; //Field offset: 0x54
	[Token(Token = "0x4000340")]
	public static readonly int NormalTextureScaleTransform; //Field offset: 0x58
	[Token(Token = "0x4000341")]
	public static readonly int NormalTextureTexCoord; //Field offset: 0x5C
	[Token(Token = "0x4000342")]
	public static readonly int NormalTextureScale; //Field offset: 0x60
	[Token(Token = "0x4000343")]
	public static readonly int Metallic; //Field offset: 0x64
	[Token(Token = "0x4000344")]
	public static readonly int MetallicRoughnessMap; //Field offset: 0x68
	[Token(Token = "0x4000345")]
	public static readonly int MetallicRoughnessMapScaleTransform; //Field offset: 0x6C
	[Token(Token = "0x4000346")]
	public static readonly int MetallicRoughnessMapRotation; //Field offset: 0x70
	[Token(Token = "0x4000347")]
	public static readonly int MetallicRoughnessMapTexCoord; //Field offset: 0x74
	[Token(Token = "0x4000348")]
	public static readonly int Mode; //Field offset: 0x78
	[Token(Token = "0x4000349")]
	public static readonly int OcclusionTexture; //Field offset: 0x7C
	[Token(Token = "0x400034A")]
	public static readonly int OcclusionTextureStrength; //Field offset: 0x80
	[Token(Token = "0x400034B")]
	public static readonly int OcclusionTextureRotation; //Field offset: 0x84
	[Token(Token = "0x400034C")]
	public static readonly int OcclusionTextureScaleTransform; //Field offset: 0x88
	[Token(Token = "0x400034D")]
	public static readonly int OcclusionTextureTexCoord; //Field offset: 0x8C
	[Token(Token = "0x400034E")]
	public static readonly int RoughnessFactor; //Field offset: 0x90
	[Token(Token = "0x400034F")]
	public static readonly int SpecularFactor; //Field offset: 0x94
	[Token(Token = "0x4000350")]
	public static readonly int SpecularGlossinessTexture; //Field offset: 0x98
	[Token(Token = "0x4000351")]
	public static readonly int SpecularGlossinessTextureScaleTransform; //Field offset: 0x9C
	[Token(Token = "0x4000352")]
	public static readonly int SpecularGlossinessTextureRotation; //Field offset: 0xA0
	[Token(Token = "0x4000353")]
	public static readonly int SpecularGlossinessTextureTexCoord; //Field offset: 0xA4
	[Token(Token = "0x4000354")]
	public static readonly int SrcBlend; //Field offset: 0xA8
	[Token(Token = "0x4000355")]
	public static readonly int ZWrite; //Field offset: 0xAC

	[Address(RVA = "0x1092790", Offset = "0x1091990", Length = "0x7B0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Token(Token = "0x600029D")]
	private static MaterialProperty() { }

}

