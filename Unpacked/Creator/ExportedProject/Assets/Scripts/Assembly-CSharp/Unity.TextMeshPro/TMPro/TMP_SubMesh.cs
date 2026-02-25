namespace TMPro;

[ExecuteAlways]
[RequireComponent(typeof(MeshRenderer))]
[Token(Token = "0x2000092")]
public class TMP_SubMesh : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40004AD")]
	private TMP_FontAsset m_fontAsset; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40004AE")]
	private TMP_SpriteAsset m_spriteAsset; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x40004AF")]
	private Material m_material; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x40004B0")]
	private Material m_sharedMaterial; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40004B1")]
	private Material m_fallbackMaterial; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40004B2")]
	private Material m_fallbackSourceMaterial; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x40004B3")]
	private bool m_isDefaultMaterial; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	[Token(Token = "0x40004B4")]
	private float m_padding; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x40004B5")]
	private Renderer m_renderer; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40004B6")]
	private MeshFilter m_meshFilter; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40004B7")]
	private Mesh m_mesh; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x40004B8")]
	private TextMeshPro m_TextComponent; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40004B9")]
	private bool m_isRegisteredForEvents; //Field offset: 0x78

	[Token(Token = "0x17000116")]
	public Material fallbackMaterial
	{
		[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004E2")]
		 get { } //Length: 5
		[Address(RVA = "0x18F03C0", Offset = "0x18EF5C0", Length = "0x151")]
		[CalledBy(Type = typeof(TextMeshPro), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TMP_MaterialManager), Member = "ReleaseFallbackMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(TMP_MaterialManager), Member = "AddFallbackMaterialReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TMP_SubMesh), Member = "GetPaddingForMaterial", ReturnType = typeof(float))]
		[Calls(Type = typeof(TMP_SubMesh), Member = "UpdateMaterial", ReturnType = typeof(void))]
		[Token(Token = "0x60004E3")]
		 set { } //Length: 337
	}

	[Token(Token = "0x17000117")]
	public Material fallbackSourceMaterial
	{
		[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004E4")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD5F0", Offset = "0x2DC7F0", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60004E5")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000112")]
	public TMP_FontAsset fontAsset
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004DA")]
		 get { } //Length: 5
		[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60004DB")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000118")]
	public bool isDefaultMaterial
	{
		[Address(RVA = "0x3EB920", Offset = "0x3EAB20", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004E6")]
		 get { } //Length: 5
		[Address(RVA = "0x3EB960", Offset = "0x3EAB60", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004E7")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000114")]
	public Material material
	{
		[Address(RVA = "0x18F00B0", Offset = "0x18EF2B0", Length = "0xC")]
		[CalledBy(Type = typeof(TextMeshPro), Member = "GetMaterials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material[])}, ReturnType = typeof(Material[]))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(TMP_SubMesh), Member = "GetMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(Material))]
		[Token(Token = "0x60004DE")]
		 get { } //Length: 12
		[Address(RVA = "0x18F0520", Offset = "0x18EF720", Length = "0x88")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(TMP_SubMesh), Member = "GetPaddingForMaterial", ReturnType = typeof(float))]
		[Calls(Type = typeof(TMP_SubMesh), Member = "UpdateMaterial", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60004DF")]
		 set { } //Length: 136
	}

	[Token(Token = "0x1700011C")]
	public Mesh mesh
	{
		[Address(RVA = "0x18F01E0", Offset = "0x18EF3E0", Length = "0xB2")]
		[CalledBy(Type = typeof(TextMeshPro), Member = "UpdateVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_VertexDataUpdateFlags)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextMeshPro), Member = "UpdateVertexData", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextMeshPro), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(TextMeshPro), Member = "SetMeshFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextMeshPro), Member = "GetCompoundBounds", ReturnType = typeof(Bounds))]
		[CalledBy(Type = typeof(TextMeshPro), Member = "UpdateSDFScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Mesh), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Token(Token = "0x60004EC")]
		 get { } //Length: 178
		[Address(RVA = "0x3692A0", Offset = "0x3684A0", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60004ED")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700011B")]
	public MeshFilter meshFilter
	{
		[Address(RVA = "0x18F00C0", Offset = "0x18EF2C0", Length = "0x110")]
		[CalledBy(Type = typeof(TextMeshPro), Member = "SetMeshFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60004EB")]
		 get { } //Length: 272
	}

	[Token(Token = "0x17000119")]
	public float padding
	{
		[Address(RVA = "0x1813FD0", Offset = "0x18131D0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004E8")]
		 get { } //Length: 6
		[Address(RVA = "0x18F05B0", Offset = "0x18EF7B0", Length = "0x6")]
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004E9")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700011A")]
	public Renderer renderer
	{
		[Address(RVA = "0x18F02A0", Offset = "0x18EF4A0", Length = "0x8D")]
		[CalledBy(Type = typeof(TextMeshPro), Member = "UpdateSubMeshSortingOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextMeshPro), Member = "set_sortingLayerID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextMeshPro), Member = "set_sortingOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextMeshPro), Member = "SetCulling", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextMeshPro), Member = "OnPreRenderObject", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextMeshPro), Member = "SetActiveSubTextObjectRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextMeshPro), Member = "UpdateSubMeshSortingLayerID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TMP_SubMesh), Member = "AddSubTextObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextMeshPro), typeof(MaterialReference)}, ReturnType = typeof(TMP_SubMesh))]
		[CalledBy(Type = typeof(TMP_SubMesh), Member = "UpdateMaterial", ReturnType = typeof(void))]
		[CallerCount(Count = 15)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x60004EA")]
		 get { } //Length: 141
	}

	[Token(Token = "0x17000115")]
	public Material sharedMaterial
	{
		[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004E0")]
		 get { } //Length: 5
		[Address(RVA = "0x18EFDF0", Offset = "0x18EEFF0", Length = "0x34")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(TMP_SubMesh), Member = "GetPaddingForMaterial", ReturnType = typeof(float))]
		[ContainsInvalidInstructions]
		[DeduplicatedMethod]
		[Token(Token = "0x60004E1")]
		 set { } //Length: 52
	}

	[Token(Token = "0x17000113")]
	public TMP_SpriteAsset spriteAsset
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004DC")]
		 get { } //Length: 5
		[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60004DD")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700011D")]
	public TMP_Text textComponent
	{
		[Address(RVA = "0x18F0330", Offset = "0x18EF530", Length = "0x8D")]
		[CalledBy(Type = typeof(TMP_SubMesh), Member = "UpdateMaterial", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "GetComponentInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60004EE")]
		 get { } //Length: 141
	}

	[Address(RVA = "0x2C7050", Offset = "0x2C6250", Length = "0x7")]
	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004FD")]
	public TMP_SubMesh() { }

	[Address(RVA = "0x18EF190", Offset = "0x18EE390", Length = "0x373")]
	[CalledBy(Type = typeof(TextMeshPro), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "set_localRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Renderer), Member = "get_sortingOrder", ReturnType = typeof(int))]
	[Calls(Type = typeof(Renderer), Member = "set_sortingLayerID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Renderer), Member = "get_sortingLayerID", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextMeshPro), Member = "get_renderer", ReturnType = typeof(Renderer))]
	[Calls(Type = typeof(TMP_SubMesh), Member = "get_renderer", ReturnType = typeof(Renderer))]
	[Calls(Type = typeof(TMP_SubMesh), Member = "UpdateMaterial", ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_SubMesh), Member = "GetPaddingForMaterial", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(GameObject), Member = "set_layer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "get_layer", ReturnType = typeof(int))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Renderer), Member = "set_sortingOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_localPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "SetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TextMeshPro), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GameObject), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Token(Token = "0x60004EF")]
	public static TMP_SubMesh AddSubTextObject(TextMeshPro textComponent, MaterialReference materialReference) { }

	[Address(RVA = "0x18EF510", Offset = "0x18EE710", Length = "0xB1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60004F5")]
	private Material CreateMaterialInstance(Material source) { }

	[Address(RVA = "0x18EF5D0", Offset = "0x18EE7D0", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(float)}, ReturnType = typeof(void))]
	[Token(Token = "0x60004F3")]
	public void DestroySelf() { }

	[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004E2")]
	public Material get_fallbackMaterial() { }

	[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004E4")]
	public Material get_fallbackSourceMaterial() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004DA")]
	public TMP_FontAsset get_fontAsset() { }

	[Address(RVA = "0x3EB920", Offset = "0x3EAB20", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004E6")]
	public bool get_isDefaultMaterial() { }

	[Address(RVA = "0x18F00B0", Offset = "0x18EF2B0", Length = "0xC")]
	[CalledBy(Type = typeof(TextMeshPro), Member = "GetMaterials", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material[])}, ReturnType = typeof(Material[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_SubMesh), Member = "GetMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(Material))]
	[Token(Token = "0x60004DE")]
	public Material get_material() { }

	[Address(RVA = "0x18F01E0", Offset = "0x18EF3E0", Length = "0xB2")]
	[CalledBy(Type = typeof(TextMeshPro), Member = "UpdateVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_VertexDataUpdateFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "UpdateVertexData", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "SetMeshFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "GetCompoundBounds", ReturnType = typeof(Bounds))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "UpdateSDFScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Mesh), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004EC")]
	public Mesh get_mesh() { }

	[Address(RVA = "0x18F00C0", Offset = "0x18EF2C0", Length = "0x110")]
	[CalledBy(Type = typeof(TextMeshPro), Member = "SetMeshFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004EB")]
	public MeshFilter get_meshFilter() { }

	[Address(RVA = "0x1813FD0", Offset = "0x18131D0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004E8")]
	public float get_padding() { }

	[Address(RVA = "0x18F02A0", Offset = "0x18EF4A0", Length = "0x8D")]
	[CalledBy(Type = typeof(TMP_SubMesh), Member = "UpdateMaterial", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "UpdateSubMeshSortingLayerID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "SetActiveSubTextObjectRenderers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "OnPreRenderObject", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_SubMesh), Member = "AddSubTextObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextMeshPro), typeof(MaterialReference)}, ReturnType = typeof(TMP_SubMesh))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "set_sortingOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "set_sortingLayerID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "UpdateSubMeshSortingOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "SetCulling", ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Token(Token = "0x60004EA")]
	public Renderer get_renderer() { }

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004E0")]
	public Material get_sharedMaterial() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004DC")]
	public TMP_SpriteAsset get_spriteAsset() { }

	[Address(RVA = "0x18F0330", Offset = "0x18EF530", Length = "0x8D")]
	[CalledBy(Type = typeof(TMP_SubMesh), Member = "UpdateMaterial", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponentInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60004EE")]
	public TMP_Text get_textComponent() { }

	[Address(RVA = "0x18EF630", Offset = "0x18EE830", Length = "0x1CD")]
	[CalledBy(Type = typeof(TMP_SubMesh), Member = "get_material", ReturnType = typeof(Material))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TMP_SubMesh), Member = "GetPaddingForMaterial", ReturnType = typeof(float))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(TMP_SubMesh), Member = "UpdateMaterial", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60004F4")]
	private Material GetMaterial(Material mat) { }

	[Address(RVA = "0x18EF800", Offset = "0x18EEA00", Length = "0x85")]
	[CalledBy(Type = typeof(TMP_SubMesh), Member = "set_material", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_SubMesh), Member = "set_sharedMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_SubMesh), Member = "set_fallbackMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_SubMesh), Member = "AddSubTextObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextMeshPro), typeof(MaterialReference)}, ReturnType = typeof(TMP_SubMesh))]
	[CalledBy(Type = typeof(TMP_SubMesh), Member = "GetMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(Material))]
	[CalledBy(Type = typeof(TMP_SubMesh), Member = "SetSharedMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ShaderUtilities), Member = "GetPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(bool), typeof(bool)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004F8")]
	public float GetPaddingForMaterial() { }

	[Address(RVA = "0x18EF890", Offset = "0x18EEA90", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60004F6")]
	private Material GetSharedMaterial() { }

	[Address(RVA = "0x18EF930", Offset = "0x18EEB30", Length = "0x14F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_MaterialManager), Member = "ReleaseFallbackMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TMP_Text), Member = "set_havePropertiesChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60004F2")]
	private void OnDestroy() { }

	[Address(RVA = "0x18EFA80", Offset = "0x18EEC80", Length = "0xB9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MeshFilter), Member = "set_sharedMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_MaterialManager), Member = "ReleaseFallbackMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004F1")]
	private void OnDisable() { }

	[Address(RVA = "0x18EFB40", Offset = "0x18EED40", Length = "0x29C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MeshFilter), Member = "set_sharedMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Material), Member = "SetVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "get_hideFlags", ReturnType = typeof(HideFlags))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60004F0")]
	private void OnEnable() { }

	[Address(RVA = "0x18F03C0", Offset = "0x18EF5C0", Length = "0x151")]
	[CalledBy(Type = typeof(TextMeshPro), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_MaterialManager), Member = "ReleaseFallbackMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TMP_MaterialManager), Member = "AddFallbackMaterialReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_SubMesh), Member = "GetPaddingForMaterial", ReturnType = typeof(float))]
	[Calls(Type = typeof(TMP_SubMesh), Member = "UpdateMaterial", ReturnType = typeof(void))]
	[Token(Token = "0x60004E3")]
	public void set_fallbackMaterial(Material value) { }

	[Address(RVA = "0x2DD5F0", Offset = "0x2DC7F0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60004E5")]
	public void set_fallbackSourceMaterial(Material value) { }

	[Address(RVA = "0x2F7320", Offset = "0x2F6520", Length = "0xD")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60004DB")]
	public void set_fontAsset(TMP_FontAsset value) { }

	[Address(RVA = "0x3EB960", Offset = "0x3EAB60", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004E7")]
	public void set_isDefaultMaterial(bool value) { }

	[Address(RVA = "0x18F0520", Offset = "0x18EF720", Length = "0x88")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TMP_SubMesh), Member = "GetPaddingForMaterial", ReturnType = typeof(float))]
	[Calls(Type = typeof(TMP_SubMesh), Member = "UpdateMaterial", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60004DF")]
	public void set_material(Material value) { }

	[Address(RVA = "0x3692A0", Offset = "0x3684A0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60004ED")]
	public void set_mesh(Mesh value) { }

	[Address(RVA = "0x18F05B0", Offset = "0x18EF7B0", Length = "0x6")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004E9")]
	public void set_padding(float value) { }

	[Address(RVA = "0x18EFDF0", Offset = "0x18EEFF0", Length = "0x34")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TMP_SubMesh), Member = "GetPaddingForMaterial", ReturnType = typeof(float))]
	[ContainsInvalidInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60004E1")]
	public void set_sharedMaterial(Material value) { }

	[Address(RVA = "0x2F7310", Offset = "0x2F6510", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60004DD")]
	public void set_spriteAsset(TMP_SpriteAsset value) { }

	[Address(RVA = "0x18EFDE0", Offset = "0x18EEFE0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_SubMesh), Member = "UpdateMaterial", ReturnType = typeof(void))]
	[Token(Token = "0x60004FB")]
	public void SetMaterialDirty() { }

	[Address(RVA = "0x18EFDF0", Offset = "0x18EEFF0", Length = "0x34")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TMP_SubMesh), Member = "GetPaddingForMaterial", ReturnType = typeof(float))]
	[ContainsInvalidInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x60004F7")]
	private void SetSharedMaterial(Material mat) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004FA")]
	public void SetVerticesDirty() { }

	[Address(RVA = "0x18EFE30", Offset = "0x18EF030", Length = "0x1F7")]
	[CalledBy(Type = typeof(TMP_SubMesh), Member = "set_material", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_SubMesh), Member = "set_fallbackMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_SubMesh), Member = "AddSubTextObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextMeshPro), typeof(MaterialReference)}, ReturnType = typeof(TMP_SubMesh))]
	[CalledBy(Type = typeof(TMP_SubMesh), Member = "GetMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(Material))]
	[CalledBy(Type = typeof(TMP_SubMesh), Member = "SetMaterialDirty", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(TMP_SubMesh), Member = "get_renderer", ReturnType = typeof(Renderer))]
	[Calls(Type = typeof(Material), Member = "GetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_SubMesh), Member = "get_textComponent", ReturnType = typeof(TMP_Text))]
	[Calls(Type = typeof(Material), Member = "HasProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Material), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60004FC")]
	protected void UpdateMaterial() { }

	[Address(RVA = "0x18F0030", Offset = "0x18EF230", Length = "0x80")]
	[CalledBy(Type = typeof(TextMeshPro), Member = "UpdateMeshPadding", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ShaderUtilities), Member = "GetPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(bool), typeof(bool)}, ReturnType = typeof(float))]
	[Token(Token = "0x60004F9")]
	public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold) { }

}

