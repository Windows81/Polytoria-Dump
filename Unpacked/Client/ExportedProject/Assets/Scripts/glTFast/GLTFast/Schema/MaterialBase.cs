namespace GLTFast.Schema;

[Token(Token = "0x200009F")]
public abstract class MaterialBase : NamedObject
{
	[Token(Token = "0x20000A0")]
	internal enum AlphaMode
	{
		Opaque = 0,
		Mask = 1,
		Blend = 2,
	}

	[FieldOffset(Offset = "0x18")]
	[Obsolete("Use Emissive for access.")]
	[Token(Token = "0x4000265")]
	public Single[] emissiveFactor; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Obsolete("Use GetAlphaMode and SetAlphaMode for access.")]
	[Token(Token = "0x4000266")]
	public string alphaMode; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000267")]
	private Nullable<AlphaMode> m_AlphaModeEnum; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000268")]
	public float alphaCutoff; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000269")]
	public bool doubleSided; //Field offset: 0x34

	[Token(Token = "0x17000051")]
	public Color Emissive
	{
		[Address(RVA = "0x1075F10", Offset = "0x1075110", Length = "0x57")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x60001F6")]
		 get { } //Length: 87
	}

	[Token(Token = "0x17000050")]
	public abstract TextureInfoBase EmissiveTexture
	{
		[Token(Token = "0x60001F5")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700004C")]
	public abstract MaterialExtensions Extensions
	{
		[Token(Token = "0x60001F0")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700004E")]
	public abstract NormalTextureInfoBase NormalTexture
	{
		[Token(Token = "0x60001F3")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700004F")]
	public abstract OcclusionTextureInfoBase OcclusionTexture
	{
		[Token(Token = "0x60001F4")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700004D")]
	public abstract PbrMetallicRoughnessBase PbrMetallicRoughness
	{
		[Token(Token = "0x60001F2")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000052")]
	public bool RequiresNormals
	{
		[Address(RVA = "0x10760D0", Offset = "0x10752D0", Length = "0x36")]
		[CalledBy(Type = "GLTFast.GltfImportBase+<LoadAccessorData>d__140", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60001F8")]
		 get { } //Length: 54
	}

	[Token(Token = "0x17000053")]
	public bool RequiresTangents
	{
		[Address(RVA = "0x1076110", Offset = "0x1075310", Length = "0x55")]
		[CalledBy(Type = "GLTFast.GltfImportBase+<LoadAccessorData>d__140", Member = "MoveNext", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x60001F9")]
		 get { } //Length: 85
	}

	[Address(RVA = "0x1076070", Offset = "0x1075270", Length = "0x5C")]
	[CalledBy(Type = typeof(MaterialBase`6), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60001FA")]
	protected MaterialBase() { }

	[Address(RVA = "0x1075F10", Offset = "0x1075110", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60001F6")]
	public Color get_Emissive() { }

	[Token(Token = "0x60001F5")]
	public abstract TextureInfoBase get_EmissiveTexture() { }

	[Token(Token = "0x60001F0")]
	public abstract MaterialExtensions get_Extensions() { }

	[Token(Token = "0x60001F3")]
	public abstract NormalTextureInfoBase get_NormalTexture() { }

	[Token(Token = "0x60001F4")]
	public abstract OcclusionTextureInfoBase get_OcclusionTexture() { }

	[Token(Token = "0x60001F2")]
	public abstract PbrMetallicRoughnessBase get_PbrMetallicRoughness() { }

	[Address(RVA = "0x10760D0", Offset = "0x10752D0", Length = "0x36")]
	[CalledBy(Type = "GLTFast.GltfImportBase+<LoadAccessorData>d__140", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60001F8")]
	public bool get_RequiresNormals() { }

	[Address(RVA = "0x1076110", Offset = "0x1075310", Length = "0x55")]
	[CalledBy(Type = "GLTFast.GltfImportBase+<LoadAccessorData>d__140", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60001F9")]
	public bool get_RequiresTangents() { }

	[Address(RVA = "0x1075F70", Offset = "0x1075170", Length = "0xFF")]
	[CalledBy(Type = typeof(BuiltInMaterialGenerator), Member = "GenerateMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MaterialBase), typeof(IGltfReadable), typeof(bool)}, ReturnType = typeof(Material))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Enum), Member = "TryParse", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(Int32Enum&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Token(Token = "0x60001F7")]
	public AlphaMode GetAlphaMode() { }

	[Token(Token = "0x60001F1")]
	internal abstract void UnsetExtensions() { }

}

