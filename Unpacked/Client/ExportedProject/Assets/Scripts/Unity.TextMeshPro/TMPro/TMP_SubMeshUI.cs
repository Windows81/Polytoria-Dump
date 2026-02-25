namespace TMPro;

[ExecuteAlways]
[RequireComponent(typeof(CanvasRenderer))]
[Token(Token = "0x2000093")]
public class TMP_SubMeshUI : MaskableGraphic
{
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	[Token(Token = "0x40004BA")]
	private TMP_FontAsset m_fontAsset; //Field offset: 0xE0
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	[Token(Token = "0x40004BB")]
	private TMP_SpriteAsset m_spriteAsset; //Field offset: 0xE8
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	[Token(Token = "0x40004BC")]
	private Material m_material; //Field offset: 0xF0
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	[Token(Token = "0x40004BD")]
	private Material m_sharedMaterial; //Field offset: 0xF8
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x40004BE")]
	private Material m_fallbackMaterial; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x40004BF")]
	private Material m_fallbackSourceMaterial; //Field offset: 0x108
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	[Token(Token = "0x40004C0")]
	private bool m_isDefaultMaterial; //Field offset: 0x110
	[FieldOffset(Offset = "0x114")]
	[SerializeField]
	[Token(Token = "0x40004C1")]
	private float m_padding; //Field offset: 0x114
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x40004C2")]
	private Mesh m_mesh; //Field offset: 0x118
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	[Token(Token = "0x40004C3")]
	private TextMeshProUGUI m_TextComponent; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x40004C4")]
	private bool m_isRegisteredForEvents; //Field offset: 0x128
	[FieldOffset(Offset = "0x129")]
	[Token(Token = "0x40004C5")]
	private bool m_materialDirty; //Field offset: 0x129
	[FieldOffset(Offset = "0x12C")]
	[SerializeField]
	[Token(Token = "0x40004C6")]
	private int m_materialReferenceIndex; //Field offset: 0x12C
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x40004C7")]
	private Transform m_RootCanvasTransform; //Field offset: 0x130

	[Token(Token = "0x17000123")]
	public Material fallbackMaterial
	{
		[Address(RVA = "0x3F58D0", Offset = "0x3F4AD0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000507")]
		 get { } //Length: 8
		[Address(RVA = "0x18EEEC0", Offset = "0x18EE0C0", Length = "0x192")]
		[CalledBy(Type = typeof(TextMeshProUGUI), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(TMP_MaterialManager), Member = "ReleaseFallbackMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(TMP_MaterialManager), Member = "AddFallbackMaterialReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TMP_SubMeshUI), Member = "GetPaddingForMaterial", ReturnType = typeof(float))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000508")]
		 set { } //Length: 402
	}

	[Token(Token = "0x17000124")]
	public Material fallbackSourceMaterial
	{
		[Address(RVA = "0x3F58B0", Offset = "0x3F4AB0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000509")]
		 get { } //Length: 8
		[Address(RVA = "0x466DE0", Offset = "0x465FE0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x600050A")]
		 set { } //Length: 19
	}

	[Token(Token = "0x1700011E")]
	public TMP_FontAsset fontAsset
	{
		[Address(RVA = "0x2DD1D0", Offset = "0x2DC3D0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60004FE")]
		 get { } //Length: 8
		[Address(RVA = "0x2DD4B0", Offset = "0x2DC6B0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x60004FF")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000126")]
	public bool isDefaultMaterial
	{
		[Address(RVA = "0x4671D0", Offset = "0x4663D0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600050C")]
		 get { } //Length: 8
		[Address(RVA = "0x18EF060", Offset = "0x18EE260", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600050D")]
		 set { } //Length: 7
	}

	[Token(Token = "0x17000120")]
	public virtual Texture mainTexture
	{
		[Address(RVA = "0x18EEC20", Offset = "0x18EDE20", Length = "0xBD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Material), Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Texture))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000502")]
		 get { } //Length: 189
	}

	[Token(Token = "0x17000121")]
	public virtual Material material
	{
		[Address(RVA = "0x18EED40", Offset = "0x18EDF40", Length = "0xF")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TMP_SubMeshUI), Member = "GetMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(Material))]
		[Token(Token = "0x6000503")]
		 get { } //Length: 15
		[Address(RVA = "0x18EF070", Offset = "0x18EE270", Length = "0x10D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(TMP_SubMeshUI), Member = "GetPaddingForMaterial", ReturnType = typeof(float))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6000504")]
		 set { } //Length: 269
	}

	[Token(Token = "0x17000125")]
	public virtual Material materialForRendering
	{
		[Address(RVA = "0x18EECE0", Offset = "0x18EDEE0", Length = "0x5D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(TMP_MaterialManager), Member = "GetMaterialForRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MaskableGraphic), typeof(Material)}, ReturnType = typeof(Material))]
		[Token(Token = "0x600050B")]
		 get { } //Length: 93
	}

	[Token(Token = "0x17000128")]
	public Mesh mesh
	{
		[Address(RVA = "0x18EED50", Offset = "0x18EDF50", Length = "0xC1")]
		[CalledBy(Type = typeof(TextMeshProUGUI), Member = "UpdateVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_VertexDataUpdateFlags)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextMeshProUGUI), Member = "UpdateVertexData", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TextMeshProUGUI), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(TextMeshProUGUI), Member = "GetCompoundBounds", ReturnType = typeof(Bounds))]
		[CalledBy(Type = typeof(TextMeshProUGUI), Member = "UpdateSDFScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Mesh), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000510")]
		 get { } //Length: 193
		[Address(RVA = "0x1673E10", Offset = "0x1673010", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000511")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000127")]
	public float padding
	{
		[Address(RVA = "0x424BC0", Offset = "0x423DC0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600050E")]
		 get { } //Length: 9
		[Address(RVA = "0x18EF180", Offset = "0x18EE380", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600050F")]
		 set { } //Length: 9
	}

	[Token(Token = "0x17000122")]
	public Material sharedMaterial
	{
		[Address(RVA = "0x3F58C0", Offset = "0x3F4AC0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000505")]
		 get { } //Length: 8
		[Address(RVA = "0x18EE910", Offset = "0x18EDB10", Length = "0x5E")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(TMP_SubMeshUI), Member = "GetPaddingForMaterial", ReturnType = typeof(float))]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000506")]
		 set { } //Length: 94
	}

	[Token(Token = "0x1700011F")]
	public TMP_SpriteAsset spriteAsset
	{
		[Address(RVA = "0x2E7250", Offset = "0x2E6450", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000500")]
		 get { } //Length: 8
		[Address(RVA = "0x2F0C50", Offset = "0x2EFE50", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000501")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000129")]
	public TMP_Text textComponent
	{
		[Address(RVA = "0x18EEE20", Offset = "0x18EE020", Length = "0x99")]
		[CalledBy(Type = typeof(TMP_SubMeshUI), Member = "UpdateMaterial", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "GetComponentInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000512")]
		 get { } //Length: 153
	}

	[Address(RVA = "0x18E8E30", Offset = "0x18E8030", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MaskableGraphic), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600052D")]
	public TMP_SubMeshUI() { }

	[Address(RVA = "0x18EDAE0", Offset = "0x18ECCE0", Length = "0x3BE")]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(RectTransform), Member = "set_pivot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_pivot", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(TMP_Text), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(GameObject), Member = "set_layer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GameObject), Member = "get_layer", ReturnType = typeof(int))]
	[Calls(Type = typeof(Transform), Member = "SetAsFirstSibling", ReturnType = typeof(void))]
	[Calls(Type = typeof(MaskableGraphic), Member = "set_maskable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "SetParent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Text), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_Settings), Member = "get_instance", ReturnType = typeof(TMP_Settings))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GameObject), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(TMP_SubMeshUI), Member = "GetPaddingForMaterial", ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000513")]
	public static TMP_SubMeshUI AddSubTextObject(TextMeshProUGUI textComponent, MaterialReference materialReference) { }

	[Address(RVA = "0x18EDEA0", Offset = "0x18ED0A0", Length = "0xB1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600052A")]
	private Material CreateMaterialInstance(Material source) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000522")]
	public virtual void Cull(Rect clipRect, bool validRect) { }

	[Address(RVA = "0x3F58D0", Offset = "0x3F4AD0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000507")]
	public Material get_fallbackMaterial() { }

	[Address(RVA = "0x3F58B0", Offset = "0x3F4AB0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000509")]
	public Material get_fallbackSourceMaterial() { }

	[Address(RVA = "0x2DD1D0", Offset = "0x2DC3D0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60004FE")]
	public TMP_FontAsset get_fontAsset() { }

	[Address(RVA = "0x4671D0", Offset = "0x4663D0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600050C")]
	public bool get_isDefaultMaterial() { }

	[Address(RVA = "0x18EEC20", Offset = "0x18EDE20", Length = "0xBD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "GetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Texture))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000502")]
	public virtual Texture get_mainTexture() { }

	[Address(RVA = "0x18EED40", Offset = "0x18EDF40", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TMP_SubMeshUI), Member = "GetMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(Material))]
	[Token(Token = "0x6000503")]
	public virtual Material get_material() { }

	[Address(RVA = "0x18EECE0", Offset = "0x18EDEE0", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TMP_MaterialManager), Member = "GetMaterialForRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MaskableGraphic), typeof(Material)}, ReturnType = typeof(Material))]
	[Token(Token = "0x600050B")]
	public virtual Material get_materialForRendering() { }

	[Address(RVA = "0x18EED50", Offset = "0x18EDF50", Length = "0xC1")]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "UpdateVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_VertexDataUpdateFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "UpdateVertexData", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "GetCompoundBounds", ReturnType = typeof(Bounds))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "UpdateSDFScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Mesh), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000510")]
	public Mesh get_mesh() { }

	[Address(RVA = "0x424BC0", Offset = "0x423DC0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600050E")]
	public float get_padding() { }

	[Address(RVA = "0x3F58C0", Offset = "0x3F4AC0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000505")]
	public Material get_sharedMaterial() { }

	[Address(RVA = "0x2E7250", Offset = "0x2E6450", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000500")]
	public TMP_SpriteAsset get_spriteAsset() { }

	[Address(RVA = "0x18EEE20", Offset = "0x18EE020", Length = "0x99")]
	[CalledBy(Type = typeof(TMP_SubMeshUI), Member = "UpdateMaterial", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponentInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000512")]
	public TMP_Text get_textComponent() { }

	[Address(RVA = "0x18EDF60", Offset = "0x18ED160", Length = "0x1B5")]
	[CalledBy(Type = typeof(TMP_SubMeshUI), Member = "get_material", ReturnType = typeof(Material))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TMP_SubMeshUI), Member = "GetPaddingForMaterial", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000529")]
	private Material GetMaterial(Material mat) { }

	[Address(RVA = "0x3F58C0", Offset = "0x3F4AC0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000528")]
	private Material GetMaterial() { }

	[Address(RVA = "0x18EE120", Offset = "0x18ED320", Length = "0x153")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(MaskUtilities), Member = "FindRootSortOverrideCanvas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(Transform))]
	[Calls(Type = typeof(MaskUtilities), Member = "GetStencilDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Transform)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(StencilMaterial), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(int), typeof(StencilOp), typeof(CompareFunction), typeof(ColorWriteMask), typeof(int), typeof(int)}, ReturnType = typeof(Material))]
	[Calls(Type = typeof(StencilMaterial), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000518")]
	public virtual Material GetModifiedMaterial(Material baseMaterial) { }

	[Address(RVA = "0x18EE280", Offset = "0x18ED480", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ShaderUtilities), Member = "GetPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(bool), typeof(bool)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600051A")]
	public float GetPaddingForMaterial(Material mat) { }

	[Address(RVA = "0x18EE310", Offset = "0x18ED510", Length = "0x8B")]
	[CalledBy(Type = typeof(TMP_SubMeshUI), Member = "set_material", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_SubMeshUI), Member = "set_sharedMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_SubMeshUI), Member = "set_fallbackMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_SubMeshUI), Member = "AddSubTextObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextMeshProUGUI), typeof(MaterialReference)}, ReturnType = typeof(TMP_SubMeshUI))]
	[CalledBy(Type = typeof(TMP_SubMeshUI), Member = "GetMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(Material))]
	[CalledBy(Type = typeof(TMP_SubMeshUI), Member = "SetSharedMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ShaderUtilities), Member = "GetPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(bool), typeof(bool)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000519")]
	public float GetPaddingForMaterial() { }

	[Address(RVA = "0x18EE3A0", Offset = "0x18ED5A0", Length = "0xB4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(Canvas), Member = "get_rootCanvas", ReturnType = typeof(Canvas))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000521")]
	private Transform GetRootCanvasTransform() { }

	[Address(RVA = "0x18EE460", Offset = "0x18ED660", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
	[Calls(Type = typeof(CanvasRenderer), Member = "GetMaterial", ReturnType = typeof(Material))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600052B")]
	private Material GetSharedMaterial() { }

	[Address(RVA = "0x18EE490", Offset = "0x18ED690", Length = "0x1D6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_MaterialManager), Member = "ReleaseStencilMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_MaterialManager), Member = "ReleaseFallbackMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TMP_Text), Member = "set_havePropertiesChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000516")]
	protected virtual void OnDestroy() { }

	[Address(RVA = "0x18EE670", Offset = "0x18ED870", Length = "0xB6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(MaskableGraphic), Member = "OnDisable", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_MaterialManager), Member = "ReleaseFallbackMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000515")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x18EE730", Offset = "0x18ED930", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "get_hideFlags", ReturnType = typeof(HideFlags))]
	[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000514")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x18EE7A0", Offset = "0x18ED9A0", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000517")]
	protected virtual void OnTransformParentChanged() { }

	[Address(RVA = "0x18EE800", Offset = "0x18EDA00", Length = "0x36")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000524")]
	public virtual void Rebuild(CanvasUpdate update) { }

	[Address(RVA = "0x1878F90", Offset = "0x1878190", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MaskableGraphic), Member = "RecalculateClipping", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000527")]
	public virtual void RecalculateClipping() { }

	[Address(RVA = "0x3CAA40", Offset = "0x3C9C40", Length = "0x14")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000525")]
	public void RefreshMaterial() { }

	[Address(RVA = "0x18EEEC0", Offset = "0x18EE0C0", Length = "0x192")]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextProcessingElement[])}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_MaterialManager), Member = "ReleaseFallbackMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TMP_MaterialManager), Member = "AddFallbackMaterialReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TMP_SubMeshUI), Member = "GetPaddingForMaterial", ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000508")]
	public void set_fallbackMaterial(Material value) { }

	[Address(RVA = "0x466DE0", Offset = "0x465FE0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600050A")]
	public void set_fallbackSourceMaterial(Material value) { }

	[Address(RVA = "0x2DD4B0", Offset = "0x2DC6B0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x60004FF")]
	public void set_fontAsset(TMP_FontAsset value) { }

	[Address(RVA = "0x18EF060", Offset = "0x18EE260", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600050D")]
	public void set_isDefaultMaterial(bool value) { }

	[Address(RVA = "0x18EF070", Offset = "0x18EE270", Length = "0x10D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TMP_SubMeshUI), Member = "GetPaddingForMaterial", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000504")]
	public virtual void set_material(Material value) { }

	[Address(RVA = "0x1673E10", Offset = "0x1673010", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000511")]
	public void set_mesh(Mesh value) { }

	[Address(RVA = "0x18EF180", Offset = "0x18EE380", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600050F")]
	public void set_padding(float value) { }

	[Address(RVA = "0x18EE910", Offset = "0x18EDB10", Length = "0x5E")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TMP_SubMeshUI), Member = "GetPaddingForMaterial", ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000506")]
	public void set_sharedMaterial(Material value) { }

	[Address(RVA = "0x2F0C50", Offset = "0x2EFE50", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000501")]
	public void set_spriteAsset(TMP_SpriteAsset value) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600051C")]
	public virtual void SetAllDirty() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600051E")]
	public virtual void SetLayoutDirty() { }

	[Address(RVA = "0x18EE840", Offset = "0x18EDA40", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600051F")]
	public virtual void SetMaterialDirty() { }

	[Address(RVA = "0x18EE890", Offset = "0x18EDA90", Length = "0x77")]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "UpdateSubObjectPivot", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "OnRectTransformDimensionsChange", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(TMP_Text), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "get_pivot", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RectTransform), Member = "set_pivot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000520")]
	public void SetPivotDirty() { }

	[Address(RVA = "0x18EE910", Offset = "0x18EDB10", Length = "0x5E")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(TMP_SubMeshUI), Member = "GetPaddingForMaterial", ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600052C")]
	private void SetSharedMaterial(Material mat) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600051D")]
	public virtual void SetVerticesDirty() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000523")]
	protected virtual void UpdateGeometry() { }

	[Address(RVA = "0x18EE970", Offset = "0x18EDB70", Length = "0x211")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "HasProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TMP_SubMeshUI), Member = "get_textComponent", ReturnType = typeof(TMP_Text))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "GetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Material), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
	[Calls(Type = typeof(CanvasRenderer), Member = "set_materialCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CanvasRenderer), Member = "SetMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x6000526")]
	protected virtual void UpdateMaterial() { }

	[Address(RVA = "0x18EEB90", Offset = "0x18EDD90", Length = "0x86")]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "UpdateMeshPadding", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ShaderUtilities), Member = "GetPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(bool), typeof(bool)}, ReturnType = typeof(float))]
	[Token(Token = "0x600051B")]
	public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold) { }

}

