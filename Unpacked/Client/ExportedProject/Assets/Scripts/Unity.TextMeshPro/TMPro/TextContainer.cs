namespace TMPro;

[RequireComponent(typeof(RectTransform))]
[Token(Token = "0x2000016")]
public class TextContainer : UIBehaviour
{
	[Token(Token = "0x4000049")]
	private static Vector2 k_defaultSize; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400003E")]
	private bool m_hasChanged; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x400003F")]
	private Vector2 m_pivot; //Field offset: 0x24
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x4000040")]
	private TextContainerAnchors m_anchorPosition; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000041")]
	private Rect m_rect; //Field offset: 0x30
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000042")]
	private bool m_isDefaultWidth; //Field offset: 0x40
	[FieldOffset(Offset = "0x41")]
	[Token(Token = "0x4000043")]
	private bool m_isDefaultHeight; //Field offset: 0x41
	[FieldOffset(Offset = "0x42")]
	[Token(Token = "0x4000044")]
	private bool m_isAutoFitting; //Field offset: 0x42
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000045")]
	private Vector3[] m_corners; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000046")]
	private Vector3[] m_worldCorners; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x4000047")]
	private Vector4 m_margins; //Field offset: 0x58
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000048")]
	private RectTransform m_rectTransform; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400004A")]
	private TextMeshPro m_textMeshPro; //Field offset: 0x70

	[Token(Token = "0x17000014")]
	public TextContainerAnchors anchorPosition
	{
		[Address(RVA = "0x3095F0", Offset = "0x3087F0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000055")]
		 get { } //Length: 4
		[Address(RVA = "0x18756B0", Offset = "0x18748B0", Length = "0x100")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(TextContainer), Member = "OnContainerChanged", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000056")]
		 set { } //Length: 256
	}

	[Token(Token = "0x1700001C")]
	public Vector3[] corners
	{
		[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000063")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000012")]
	public bool hasChanged
	{
		[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000051")]
		 get { } //Length: 5
		[Address(RVA = "0x309220", Offset = "0x308420", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000052")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000018")]
	public float height
	{
		[Address(RVA = "0x1875550", Offset = "0x1874750", Length = "0x8")]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x600005D")]
		 get { } //Length: 8
		[Address(RVA = "0x18757E0", Offset = "0x18749E0", Length = "0x46")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextContainer), Member = "OnContainerChanged", ReturnType = typeof(void))]
		[Token(Token = "0x600005E")]
		 set { } //Length: 70
	}

	[Token(Token = "0x1700001B")]
	public bool isAutoFitting
	{
		[Address(RVA = "0x16BD180", Offset = "0x16BC380", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000061")]
		 get { } //Length: 5
		[Address(RVA = "0x16BD1B0", Offset = "0x16BC3B0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000062")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700001A")]
	public bool isDefaultHeight
	{
		[Address(RVA = "0x145D760", Offset = "0x145C960", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000060")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000019")]
	public bool isDefaultWidth
	{
		[Address(RVA = "0x4C4260", Offset = "0x4C3460", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600005F")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700001E")]
	public Vector4 margins
	{
		[Address(RVA = "0x3B43B0", Offset = "0x3B35B0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000065")]
		 get { } //Length: 11
		[Address(RVA = "0x1875830", Offset = "0x1874A30", Length = "0x81")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextContainer), Member = "OnContainerChanged", ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000066")]
		 set { } //Length: 129
	}

	[Token(Token = "0x17000013")]
	public Vector2 pivot
	{
		[Address(RVA = "0x5BBCD0", Offset = "0x5BAED0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000053")]
		 get { } //Length: 19
		[Address(RVA = "0x18758C0", Offset = "0x1874AC0", Length = "0x7F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextContainer), Member = "GetAnchorPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(TextContainerAnchors))]
		[Calls(Type = typeof(TextContainer), Member = "OnContainerChanged", ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000054")]
		 set { } //Length: 127
	}

	[Token(Token = "0x17000015")]
	public Rect rect
	{
		[Address(RVA = "0x3B2180", Offset = "0x3B1380", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000057")]
		 get { } //Length: 11
		[Address(RVA = "0x1875940", Offset = "0x1874B40", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextContainer), Member = "OnContainerChanged", ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000058")]
		 set { } //Length: 90
	}

	[Token(Token = "0x1700001F")]
	public RectTransform rectTransform
	{
		[Address(RVA = "0x1875560", Offset = "0x1874760", Length = "0x8D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000067")]
		 get { } //Length: 141
	}

	[Token(Token = "0x17000016")]
	public Vector2 size
	{
		[Address(RVA = "0x18755F0", Offset = "0x18747F0", Length = "0x15")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000059")]
		 get { } //Length: 21
		[Address(RVA = "0x18759A0", Offset = "0x1874BA0", Length = "0x89")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextContainer), Member = "OnContainerChanged", ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600005A")]
		 set { } //Length: 137
	}

	[Token(Token = "0x17000020")]
	public TextMeshPro textMeshPro
	{
		[Address(RVA = "0x1875610", Offset = "0x1874810", Length = "0x8D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6000068")]
		 get { } //Length: 141
	}

	[Token(Token = "0x17000017")]
	public float width
	{
		[Address(RVA = "0x18756A0", Offset = "0x18748A0", Length = "0x8")]
		[CallerCount(Count = 41)]
		[DeduplicatedMethod]
		[Token(Token = "0x600005B")]
		 get { } //Length: 8
		[Address(RVA = "0x1875A30", Offset = "0x1874C30", Length = "0x46")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextContainer), Member = "OnContainerChanged", ReturnType = typeof(void))]
		[Token(Token = "0x600005C")]
		 set { } //Length: 70
	}

	[Token(Token = "0x1700001D")]
	public Vector3[] worldCorners
	{
		[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000064")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x1875490", Offset = "0x1874690", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000073")]
	private static TextContainer() { }

	[Address(RVA = "0x18754D0", Offset = "0x18746D0", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000072")]
	public TextContainer() { }

	[Address(RVA = "0x1874A30", Offset = "0x1873C30", Length = "0xA9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000069")]
	protected virtual void Awake() { }

	[Address(RVA = "0x3095F0", Offset = "0x3087F0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000055")]
	public TextContainerAnchors get_anchorPosition() { }

	[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000063")]
	public Vector3[] get_corners() { }

	[Address(RVA = "0x309190", Offset = "0x308390", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000051")]
	public bool get_hasChanged() { }

	[Address(RVA = "0x1875550", Offset = "0x1874750", Length = "0x8")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x600005D")]
	public float get_height() { }

	[Address(RVA = "0x16BD180", Offset = "0x16BC380", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000061")]
	public bool get_isAutoFitting() { }

	[Address(RVA = "0x145D760", Offset = "0x145C960", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000060")]
	public bool get_isDefaultHeight() { }

	[Address(RVA = "0x4C4260", Offset = "0x4C3460", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600005F")]
	public bool get_isDefaultWidth() { }

	[Address(RVA = "0x3B43B0", Offset = "0x3B35B0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000065")]
	public Vector4 get_margins() { }

	[Address(RVA = "0x5BBCD0", Offset = "0x5BAED0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000053")]
	public Vector2 get_pivot() { }

	[Address(RVA = "0x3B2180", Offset = "0x3B1380", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000057")]
	public Rect get_rect() { }

	[Address(RVA = "0x1875560", Offset = "0x1874760", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000067")]
	public RectTransform get_rectTransform() { }

	[Address(RVA = "0x18755F0", Offset = "0x18747F0", Length = "0x15")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000059")]
	public Vector2 get_size() { }

	[Address(RVA = "0x1875610", Offset = "0x1874810", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000068")]
	public TextMeshPro get_textMeshPro() { }

	[Address(RVA = "0x18756A0", Offset = "0x18748A0", Length = "0x8")]
	[CallerCount(Count = 41)]
	[DeduplicatedMethod]
	[Token(Token = "0x600005B")]
	public float get_width() { }

	[Address(RVA = "0x2DD2B0", Offset = "0x2DC4B0", Length = "0x5")]
	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000064")]
	public Vector3[] get_worldCorners() { }

	[Address(RVA = "0x1874AE0", Offset = "0x1873CE0", Length = "0x20B")]
	[CalledBy(Type = typeof(TextContainer), Member = "set_pivot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextContainer), Member = "OnRectTransformDimensionsChange", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000071")]
	private TextContainerAnchors GetAnchorPosition(Vector2 pivot) { }

	[Address(RVA = "0x1874CF0", Offset = "0x1873EF0", Length = "0x12C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000070")]
	private Vector2 GetPivot(TextContainerAnchors anchor) { }

	[Address(RVA = "0x1874E40", Offset = "0x1874040", Length = "0x18C")]
	[CalledBy(Type = typeof(TextContainer), Member = "OnRectTransformDimensionsChange", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextContainer), Member = "set_pivot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextContainer), Member = "set_anchorPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextContainerAnchors)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextContainer), Member = "set_rect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextContainer), Member = "set_size", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextContainer), Member = "set_width", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextContainer), Member = "set_height", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextContainer), Member = "set_margins", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextContainer), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TextContainer), Member = "UpdateCorners", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "set_hasChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600006C")]
	private void OnContainerChanged() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600006B")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x1874FD0", Offset = "0x18741D0", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextContainer), Member = "OnContainerChanged", ReturnType = typeof(void))]
	[Token(Token = "0x600006A")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x1874FE0", Offset = "0x18741E0", Length = "0x2B3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(TextContainer), Member = "OnContainerChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "get_pivot", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(TextContainer), Member = "GetAnchorPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(TextContainerAnchors))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600006D")]
	protected virtual void OnRectTransformDimensionsChange() { }

	[Address(RVA = "0x18756B0", Offset = "0x18748B0", Length = "0x100")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TextContainer), Member = "OnContainerChanged", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000056")]
	public void set_anchorPosition(TextContainerAnchors value) { }

	[Address(RVA = "0x309220", Offset = "0x308420", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000052")]
	public void set_hasChanged(bool value) { }

	[Address(RVA = "0x18757E0", Offset = "0x18749E0", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextContainer), Member = "OnContainerChanged", ReturnType = typeof(void))]
	[Token(Token = "0x600005E")]
	public void set_height(float value) { }

	[Address(RVA = "0x16BD1B0", Offset = "0x16BC3B0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000062")]
	public void set_isAutoFitting(bool value) { }

	[Address(RVA = "0x1875830", Offset = "0x1874A30", Length = "0x81")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextContainer), Member = "OnContainerChanged", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000066")]
	public void set_margins(Vector4 value) { }

	[Address(RVA = "0x18758C0", Offset = "0x1874AC0", Length = "0x7F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextContainer), Member = "GetAnchorPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(TextContainerAnchors))]
	[Calls(Type = typeof(TextContainer), Member = "OnContainerChanged", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000054")]
	public void set_pivot(Vector2 value) { }

	[Address(RVA = "0x1875940", Offset = "0x1874B40", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextContainer), Member = "OnContainerChanged", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000058")]
	public void set_rect(Rect value) { }

	[Address(RVA = "0x18759A0", Offset = "0x1874BA0", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextContainer), Member = "OnContainerChanged", ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600005A")]
	public void set_size(Vector2 value) { }

	[Address(RVA = "0x1875A30", Offset = "0x1874C30", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextContainer), Member = "OnContainerChanged", ReturnType = typeof(void))]
	[Token(Token = "0x600005C")]
	public void set_width(float value) { }

	[Address(RVA = "0x18752A0", Offset = "0x18744A0", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600006E")]
	private void SetRect(Vector2 size) { }

	[Address(RVA = "0x18752F0", Offset = "0x18744F0", Length = "0x192")]
	[CalledBy(Type = typeof(TextContainer), Member = "OnContainerChanged", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RectTransform), Member = "set_pivot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600006F")]
	private void UpdateCorners() { }

}

