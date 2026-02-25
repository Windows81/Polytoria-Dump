namespace UnityEngine.UI.ProceduralImage;

[AddComponentMenu("UI/Procedural Image")]
[ExecuteInEditMode]
[Token(Token = "0x2000448")]
public class ProceduralImage : Image
{
	[Token(Token = "0x4001239")]
	private static Material materialInstance; //Field offset: 0x0
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	[Token(Token = "0x4001237")]
	private float borderWidth; //Field offset: 0x120
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4001238")]
	private ProceduralImageModifier modifier; //Field offset: 0x128
	[FieldOffset(Offset = "0x130")]
	[SerializeField]
	[Token(Token = "0x400123A")]
	private float falloffDistance; //Field offset: 0x130

	[Token(Token = "0x17000D2B")]
	public float BorderWidth
	{
		[Address(RVA = "0x4601D0", Offset = "0x45F3D0", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002D20")]
		 get { } //Length: 9
		[Address(RVA = "0x4F75D0", Offset = "0x4F67D0", Length = "0x1C")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6002D21")]
		 set { } //Length: 28
	}

	[Token(Token = "0x17000D2A")]
	private static Material DefaultProceduralImageMaterial
	{
		[Address(RVA = "0x4F7240", Offset = "0x4F6440", Length = "0xF3")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Shader), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Shader))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6002D1E")]
		private get { } //Length: 243
		[Address(RVA = "0x4F75F0", Offset = "0x4F67F0", Length = "0x51")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6002D1F")]
		private set { } //Length: 81
	}

	[Token(Token = "0x17000D2C")]
	public float FalloffDistance
	{
		[Address(RVA = "0x460160", Offset = "0x45F360", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002D22")]
		 get { } //Length: 9
		[Address(RVA = "0x4F7650", Offset = "0x4F6850", Length = "0x1C")]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6002D23")]
		 set { } //Length: 28
	}

	[Token(Token = "0x17000D2F")]
	public virtual Material material
	{
		[Address(RVA = "0x4F7480", Offset = "0x4F6680", Length = "0x14F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Image), Member = "get_material", ReturnType = typeof(Material))]
		[Calls(Type = typeof(Shader), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Shader))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6002D34")]
		 get { } //Length: 335
		[Address(RVA = "0x4F7850", Offset = "0x4F6A50", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002D35")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000D2D")]
	protected ProceduralImageModifier Modifier
	{
		[Address(RVA = "0x4F7370", Offset = "0x4F6570", Length = "0x10A")]
		[CalledBy(Type = typeof(ProceduralImage), Member = "get_ModifierType", ReturnType = typeof(Type))]
		[CalledBy(Type = typeof(ProceduralImage), Member = "CalculateInfo", ReturnType = typeof(ProceduralImageInfo))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(ProceduralImage), Member = "set_ModifierType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
		[Token(Token = "0x6002D24")]
		 get { } //Length: 266
		[Address(RVA = "0x4F7830", Offset = "0x4F6A30", Length = "0x13")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6002D25")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000D2E")]
	public Type ModifierType
	{
		[Address(RVA = "0x4F7340", Offset = "0x4F6540", Length = "0x23")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ProceduralImage), Member = "get_Modifier", ReturnType = typeof(ProceduralImageModifier))]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002D26")]
		 get { } //Length: 35
		[Address(RVA = "0x4F7670", Offset = "0x4F6870", Length = "0x1BF")]
		[CalledBy(Type = typeof(ProceduralImage), Member = "get_Modifier", ReturnType = typeof(ProceduralImageModifier))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(Object), Member = "DestroyImmediate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6002D27")]
		 set { } //Length: 447
	}

	[Address(RVA = "0x4F71E0", Offset = "0x4F63E0", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Image), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6002D36")]
	public ProceduralImage() { }

	[Address(RVA = "0x4F6490", Offset = "0x4F5690", Length = "0x2B8")]
	[CalledBy(Type = typeof(ProceduralImage), Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Graphic), Member = "GetPixelAdjustedRect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(ProceduralImage), Member = "get_Modifier", ReturnType = typeof(ProceduralImageModifier))]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002D31")]
	private ProceduralImageInfo CalculateInfo() { }

	[Address(RVA = "0x4F6750", Offset = "0x4F5950", Length = "0x32C")]
	[CalledBy(Type = typeof(ProceduralImage), Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802898A0")]
	[Calls(Type = typeof(VertexHelper), Member = "get_currentVertCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(VertexHelper), Member = "PopulateUIVertex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIVertex&), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VertexHelper), Member = "SetUIVertex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIVertex), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002D32")]
	private void EncodeAllInfoIntoVertices(VertexHelper vh, ProceduralImageInfo info) { }

	[Address(RVA = "0x4F6A80", Offset = "0x4F5C80", Length = "0x6E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802898A0")]
	[Token(Token = "0x6002D33")]
	private float EncodeFloats_0_1_16_16(float a, float b) { }

	[Address(RVA = "0x4F6AF0", Offset = "0x4F5CF0", Length = "0x13D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002D2E")]
	private Vector4 FixRadius(Vector4 vec) { }

	[Address(RVA = "0x4F6C30", Offset = "0x4F5E30", Length = "0x32")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Canvas), Member = "get_additionalShaderChannels", ReturnType = typeof(AdditionalCanvasShaderChannels))]
	[Calls(Type = typeof(Canvas), Member = "set_additionalShaderChannels", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AdditionalCanvasShaderChannels)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002D2D")]
	protected void FixTexCoordsInCanvas(Canvas c) { }

	[Address(RVA = "0x4F6C70", Offset = "0x4F5E70", Length = "0x98")]
	[CalledBy(Type = typeof(ProceduralImage), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProceduralImage), Member = "Init", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ProceduralImage), Member = "OnTransformParentChanged", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "GetComponentInParent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Canvas), Member = "get_additionalShaderChannels", ReturnType = typeof(AdditionalCanvasShaderChannels))]
	[Calls(Type = typeof(Canvas), Member = "set_additionalShaderChannels", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AdditionalCanvasShaderChannels)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002D2C")]
	protected void FixTexCoordsInCanvas() { }

	[Address(RVA = "0x4601D0", Offset = "0x45F3D0", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D20")]
	public float get_BorderWidth() { }

	[Address(RVA = "0x4F7240", Offset = "0x4F6440", Length = "0xF3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Shader), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Shader))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6002D1E")]
	private static Material get_DefaultProceduralImageMaterial() { }

	[Address(RVA = "0x460160", Offset = "0x45F360", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D22")]
	public float get_FalloffDistance() { }

	[Address(RVA = "0x4F7480", Offset = "0x4F6680", Length = "0x14F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Image), Member = "get_material", ReturnType = typeof(Material))]
	[Calls(Type = typeof(Shader), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Shader))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6002D34")]
	public virtual Material get_material() { }

	[Address(RVA = "0x4F7370", Offset = "0x4F6570", Length = "0x10A")]
	[CalledBy(Type = typeof(ProceduralImage), Member = "get_ModifierType", ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(ProceduralImage), Member = "CalculateInfo", ReturnType = typeof(ProceduralImageInfo))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ProceduralImage), Member = "set_ModifierType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002D24")]
	protected ProceduralImageModifier get_Modifier() { }

	[Address(RVA = "0x4F7340", Offset = "0x4F6540", Length = "0x23")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProceduralImage), Member = "get_Modifier", ReturnType = typeof(ProceduralImageModifier))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002D26")]
	public Type get_ModifierType() { }

	[Address(RVA = "0x4F6D10", Offset = "0x4F5F10", Length = "0x15F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ProceduralImage), Member = "FixTexCoordsInCanvas", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Image), Member = "set_preserveAspect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EmptySprite), Member = "Get", ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002D2A")]
	private void Init() { }

	[Address(RVA = "0x4F6E70", Offset = "0x4F6070", Length = "0xE3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Image), Member = "OnDisable", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002D29")]
	protected virtual void OnDisable() { }

	[Address(RVA = "0x4F6F60", Offset = "0x4F6160", Length = "0x166")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Image), Member = "OnEnable", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ProceduralImage), Member = "FixTexCoordsInCanvas", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(Image), Member = "set_preserveAspect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EmptySprite), Member = "Get", ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002D28")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x4F70D0", Offset = "0x4F62D0", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Image), Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProceduralImage), Member = "CalculateInfo", ReturnType = typeof(ProceduralImageInfo))]
	[Calls(Type = typeof(ProceduralImage), Member = "EncodeAllInfoIntoVertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(ProceduralImageInfo)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002D2F")]
	protected virtual void OnPopulateMesh(VertexHelper toFill) { }

	[Address(RVA = "0x4F7140", Offset = "0x4F6340", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MaskableGraphic), Member = "OnTransformParentChanged", ReturnType = typeof(void))]
	[Calls(Type = typeof(ProceduralImage), Member = "FixTexCoordsInCanvas", ReturnType = typeof(void))]
	[Token(Token = "0x6002D30")]
	protected virtual void OnTransformParentChanged() { }

	[Address(RVA = "0x4F7160", Offset = "0x4F6360", Length = "0x76")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(EmptySprite), Member = "Get", ReturnType = typeof(Sprite))]
	[Calls(Type = typeof(Image), Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002D2B")]
	protected void OnVerticesDirty() { }

	[Address(RVA = "0x4F75D0", Offset = "0x4F67D0", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002D21")]
	public void set_BorderWidth(float value) { }

	[Address(RVA = "0x4F75F0", Offset = "0x4F67F0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6002D1F")]
	private static void set_DefaultProceduralImageMaterial(Material value) { }

	[Address(RVA = "0x4F7650", Offset = "0x4F6850", Length = "0x1C")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002D23")]
	public void set_FalloffDistance(float value) { }

	[Address(RVA = "0x4F7850", Offset = "0x4F6A50", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002D35")]
	public virtual void set_material(Material value) { }

	[Address(RVA = "0x4F7830", Offset = "0x4F6A30", Length = "0x13")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002D25")]
	protected void set_Modifier(ProceduralImageModifier value) { }

	[Address(RVA = "0x4F7670", Offset = "0x4F6870", Length = "0x1BF")]
	[CalledBy(Type = typeof(ProceduralImage), Member = "get_Modifier", ReturnType = typeof(ProceduralImageModifier))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6002D27")]
	public void set_ModifierType(Type value) { }

}

