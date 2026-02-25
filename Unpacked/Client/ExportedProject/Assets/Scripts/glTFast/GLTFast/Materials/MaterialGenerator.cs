namespace GLTFast.Materials;

[Token(Token = "0x20000DD")]
public abstract class MaterialGenerator : IMaterialGenerator
{
	[Obsolete("Use MaterialProperty.AlphaCutoff instead.")]
	[Token(Token = "0x40002FB")]
	public static readonly int AlphaCutoffProperty; //Field offset: 0x0
	[Obsolete("Use MaterialProperty.BaseColor instead.")]
	[Token(Token = "0x40002FC")]
	public static readonly int BaseColorProperty; //Field offset: 0x4
	[Obsolete("Use MaterialProperty.BaseColorTexture instead.")]
	[Token(Token = "0x40002FD")]
	public static readonly int BaseColorTextureProperty; //Field offset: 0x8
	[Obsolete("Use MaterialProperty.BaseColorTextureRotation instead.")]
	[Token(Token = "0x40002FE")]
	public static readonly int BaseColorTextureRotationProperty; //Field offset: 0xC
	[Obsolete("Use MaterialProperty.BaseColorTextureScaleTransform instead.")]
	[Token(Token = "0x40002FF")]
	public static readonly int BaseColorTextureScaleTransformProperty; //Field offset: 0x10
	[Obsolete("Use MaterialProperty.BaseColorTextureTexCoord instead.")]
	[Token(Token = "0x4000300")]
	public static readonly int BaseColorTextureTexCoordProperty; //Field offset: 0x14
	[Obsolete("Use MaterialProperty.CullMode instead.")]
	[Token(Token = "0x4000301")]
	public static readonly int CullModeProperty; //Field offset: 0x18
	[Obsolete("Use MaterialProperty.Cull instead.")]
	[Token(Token = "0x4000302")]
	public static readonly int CullProperty; //Field offset: 0x1C
	[Obsolete("Use MaterialProperty.DstBlend instead.")]
	[Token(Token = "0x4000303")]
	public static readonly int DstBlendProperty; //Field offset: 0x20
	[Obsolete("Use MaterialProperty.DiffuseFactor instead.")]
	[Token(Token = "0x4000304")]
	public static readonly int DiffuseFactorProperty; //Field offset: 0x24
	[Obsolete("Use MaterialProperty.DiffuseTexture instead.")]
	[Token(Token = "0x4000305")]
	public static readonly int DiffuseTextureProperty; //Field offset: 0x28
	[Obsolete("Use MaterialProperty.DiffuseTextureScaleTransform instead.")]
	[Token(Token = "0x4000306")]
	public static readonly int DiffuseTextureScaleTransformProperty; //Field offset: 0x2C
	[Obsolete("Use MaterialProperty.DiffuseTextureRotation instead.")]
	[Token(Token = "0x4000307")]
	public static readonly int DiffuseTextureRotationProperty; //Field offset: 0x30
	[Obsolete("Use MaterialProperty.DiffuseTextureTexCoord instead.")]
	[Token(Token = "0x4000308")]
	public static readonly int DiffuseTextureTexCoordProperty; //Field offset: 0x34
	[Obsolete("Use MaterialProperty.EmissiveFactor instead.")]
	[Token(Token = "0x4000309")]
	public static readonly int EmissiveFactorProperty; //Field offset: 0x38
	[Obsolete("Use MaterialProperty.EmissiveTexture instead.")]
	[Token(Token = "0x400030A")]
	public static readonly int EmissiveTextureProperty; //Field offset: 0x3C
	[Obsolete("Use MaterialProperty.EmissiveTextureRotation instead.")]
	[Token(Token = "0x400030B")]
	public static readonly int EmissiveTextureRotationProperty; //Field offset: 0x40
	[Obsolete("Use MaterialProperty.EmissiveTextureScaleTransform instead.")]
	[Token(Token = "0x400030C")]
	public static readonly int EmissiveTextureScaleTransformProperty; //Field offset: 0x44
	[Obsolete("Use MaterialProperty.EmissiveTextureTexCoord instead.")]
	[Token(Token = "0x400030D")]
	public static readonly int EmissiveTextureTexCoordProperty; //Field offset: 0x48
	[Obsolete("Use MaterialProperty.GlossinessFactor instead.")]
	[Token(Token = "0x400030E")]
	public static readonly int GlossinessFactorProperty; //Field offset: 0x4C
	[Obsolete("Use MaterialProperty.NormalTexture instead.")]
	[Token(Token = "0x400030F")]
	public static readonly int NormalTextureProperty; //Field offset: 0x50
	[Obsolete("Use MaterialProperty.NormalTextureRotation instead.")]
	[Token(Token = "0x4000310")]
	public static readonly int NormalTextureRotationProperty; //Field offset: 0x54
	[Obsolete("Use MaterialProperty.NormalTextureScaleTransform instead.")]
	[Token(Token = "0x4000311")]
	public static readonly int NormalTextureScaleTransformProperty; //Field offset: 0x58
	[Obsolete("Use MaterialProperty.NormalTextureTexCoord instead.")]
	[Token(Token = "0x4000312")]
	public static readonly int NormalTextureTexCoordProperty; //Field offset: 0x5C
	[Obsolete("Use MaterialProperty.NormalTextureScale instead.")]
	[Token(Token = "0x4000313")]
	public static readonly int NormalTextureScaleProperty; //Field offset: 0x60
	[Obsolete("Use MaterialProperty.Metallic instead.")]
	[Token(Token = "0x4000314")]
	public static readonly int MetallicProperty; //Field offset: 0x64
	[Obsolete("Use MaterialProperty.MetallicRoughnessMap instead.")]
	[Token(Token = "0x4000315")]
	public static readonly int MetallicRoughnessMapProperty; //Field offset: 0x68
	[Obsolete("Use MaterialProperty.MetallicRoughnessMapScaleTransform instead.")]
	[Token(Token = "0x4000316")]
	public static readonly int MetallicRoughnessMapScaleTransformProperty; //Field offset: 0x6C
	[Obsolete("Use MaterialProperty.MetallicRoughnessMapRotation instead.")]
	[Token(Token = "0x4000317")]
	public static readonly int MetallicRoughnessMapRotationProperty; //Field offset: 0x70
	[Obsolete("Use MaterialProperty.MetallicRoughnessMapTexCoord instead.")]
	[Token(Token = "0x4000318")]
	public static readonly int MetallicRoughnessMapUVChannelProperty; //Field offset: 0x74
	[Obsolete("Use MaterialProperty.OcclusionTexture instead.")]
	[Token(Token = "0x4000319")]
	public static readonly int OcclusionTextureProperty; //Field offset: 0x78
	[Obsolete("Use MaterialProperty.OcclusionTextureStrength instead.")]
	[Token(Token = "0x400031A")]
	public static readonly int OcclusionTextureStrengthProperty; //Field offset: 0x7C
	[Obsolete("Use MaterialProperty.OcclusionTextureRotation instead.")]
	[Token(Token = "0x400031B")]
	public static readonly int OcclusionTextureRotationProperty; //Field offset: 0x80
	[Obsolete("Use MaterialProperty.OcclusionTextureScaleTransform instead.")]
	[Token(Token = "0x400031C")]
	public static readonly int OcclusionTextureScaleTransformProperty; //Field offset: 0x84
	[Obsolete("Use MaterialProperty.OcclusionTextureTexCoord instead.")]
	[Token(Token = "0x400031D")]
	public static readonly int OcclusionTextureTexCoordProperty; //Field offset: 0x88
	[Obsolete("Use MaterialProperty.RoughnessFactor instead.")]
	[Token(Token = "0x400031E")]
	public static readonly int RoughnessFactorProperty; //Field offset: 0x8C
	[Obsolete("Use MaterialProperty.SpecularFactor instead.")]
	[Token(Token = "0x400031F")]
	public static readonly int SpecularFactorProperty; //Field offset: 0x90
	[Obsolete("Use MaterialProperty.SpecularGlossinessTexture instead.")]
	[Token(Token = "0x4000320")]
	public static readonly int SpecularGlossinessTextureProperty; //Field offset: 0x94
	[Obsolete("Use MaterialProperty.SpecularGlossinessTextureScaleTransform instead.")]
	[Token(Token = "0x4000321")]
	public static readonly int SpecularGlossinessTextureScaleTransformProperty; //Field offset: 0x98
	[Obsolete("Use MaterialProperty.SpecularGlossinessTextureRotation instead.")]
	[Token(Token = "0x4000322")]
	public static readonly int SpecularGlossinessTextureRotationProperty; //Field offset: 0x9C
	[Obsolete("Use MaterialProperty.SpecularGlossinessTextureTexCoord instead.")]
	[Token(Token = "0x4000323")]
	public static readonly int SpecularGlossinessTextureTexCoordProperty; //Field offset: 0xA0
	[Obsolete("Use MaterialProperty.SrcBlend instead.")]
	[Token(Token = "0x4000324")]
	public static readonly int SrcBlendProperty; //Field offset: 0xA4
	[Obsolete("Use MaterialProperty.ZWrite instead.")]
	[Token(Token = "0x4000325")]
	public static readonly int ZWriteProperty; //Field offset: 0xA8
	[Token(Token = "0x4000326")]
	private static IMaterialGenerator s_DefaultMaterialGenerator; //Field offset: 0xB0
	[Token(Token = "0x4000327")]
	private static bool s_DefaultMaterialGenerated; //Field offset: 0xB8
	[Token(Token = "0x4000328")]
	private static Material s_DefaultMaterial; //Field offset: 0xC0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000329")]
	private ICodeLogger <Logger>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000089")]
	protected private ICodeLogger Logger
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000291")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000292")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x1092140", Offset = "0x1091340", Length = "0x642")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600029C")]
	private static MaterialGenerator() { }

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600029B")]
	protected MaterialGenerator() { }

	[Address(RVA = "0x1091350", Offset = "0x1090550", Length = "0xF4")]
	[CalledBy(Type = typeof(BuiltInMaterialGenerator), Member = "FinderShaderMetallicRoughness", ReturnType = typeof(Shader))]
	[CalledBy(Type = typeof(BuiltInMaterialGenerator), Member = "FinderShaderSpecularGlossiness", ReturnType = typeof(Shader))]
	[CalledBy(Type = typeof(BuiltInMaterialGenerator), Member = "FinderShaderUnlit", ReturnType = typeof(Shader))]
	[CalledBy(Type = typeof(BuiltInMaterialGenerator), Member = "GetPbrMetallicRoughnessMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Material))]
	[CalledBy(Type = typeof(BuiltInMaterialGenerator), Member = "GetPbrSpecularGlossinessMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Material))]
	[CalledBy(Type = typeof(BuiltInMaterialGenerator), Member = "GetUnlitMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Material))]
	[CalledBy(Type = typeof(BuiltInMaterialGenerator), Member = "GenerateMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MaterialBase), typeof(IGltfReadable), typeof(bool)}, ReturnType = typeof(Material))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800099A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Shader), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Shader))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000295")]
	protected static Shader FindShader(string shaderName, ICodeLogger logger) { }

	[Token(Token = "0x6000294")]
	protected abstract Material GenerateDefaultMaterial(bool pointsSupport = false) { }

	[Token(Token = "0x6000296")]
	public abstract Material GenerateMaterial(MaterialBase gltfMaterial, IGltfReadable gltf, bool pointsSupport = false) { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000291")]
	protected ICodeLogger get_Logger() { }

	[Address(RVA = "0x10915F0", Offset = "0x10907F0", Length = "0x1E9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800099A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000293")]
	public override Material GetDefaultMaterial(bool pointsSupport = false) { }

	[Address(RVA = "0x1091450", Offset = "0x1090650", Length = "0x19C")]
	[CalledBy(Type = typeof(GltfImportBase), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDownloadProvider), typeof(IDeferAgent), typeof(IMaterialGenerator), typeof(ICodeLogger)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RenderPipelineUtils), Member = "get_RenderPipeline", ReturnType = typeof(RenderPipeline))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(BuiltInMaterialGenerator), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000290")]
	public static IMaterialGenerator GetDefaultMaterialGenerator() { }

	[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000292")]
	private void set_Logger(ICodeLogger value) { }

	[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000297")]
	public override void SetLogger(ICodeLogger logger) { }

	[Address(RVA = "0x10917E0", Offset = "0x10909E0", Length = "0x83")]
	[CalledBy(Type = typeof(BuiltInMaterialGenerator), Member = "GenerateMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MaterialBase), typeof(IGltfReadable), typeof(bool)}, ReturnType = typeof(Material))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600029A")]
	protected static bool TransmissionWorkaroundShaderMode(Transmission transmission, ref Color baseColorLinear) { }

	[Address(RVA = "0x1091D40", Offset = "0x1090F40", Length = "0x3F4")]
	[CalledBy(Type = typeof(BuiltInMaterialGenerator), Member = "GenerateMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MaterialBase), typeof(IGltfReadable), typeof(bool)}, ReturnType = typeof(Material))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800099A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "SetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Texture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaterialGenerator), Member = "TrySetTextureTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureInfoBase), typeof(Material), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000298")]
	protected bool TrySetTexture(TextureInfoBase textureInfo, Material material, IGltfReadable gltf, int texturePropertyId, int scaleTransformPropertyId = -1, int rotationPropertyId = -1, int uvChannelPropertyId = -1) { }

	[Address(RVA = "0x1091870", Offset = "0x1090A70", Length = "0x4C1")]
	[CalledBy(Type = typeof(MaterialGenerator), Member = "TrySetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureInfoBase), typeof(Material), typeof(IGltfReadable), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Material), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "SetTextureOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(float2), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float2)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800099A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028CBC0")]
	[Calls(Type = typeof(Material), Member = "SetTextureScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028BE30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Material), Member = "SetVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Material), Member = "EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000299")]
	private void TrySetTextureTransform(TextureInfoBase textureInfo, Material material, int texturePropertyId, int scaleTransformPropertyId = -1, int rotationPropertyId = -1, int uvChannelPropertyId = -1, bool flipY = false) { }

}

