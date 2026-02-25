namespace UnityEngine.UIElements;

[Token(Token = "0x20002C7")]
internal struct ColorPage
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B40")]
	public bool isValid; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000B41")]
	public Color32 pageAndID; //Field offset: 0x4

	[Address(RVA = "0x1C80000", Offset = "0x1C7F200", Length = "0x8D")]
	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BMPAlloc), Member = "IsValid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "ColorAllocToVertexData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc)}, ReturnType = typeof(Color32))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001350")]
	public static ColorPage Init(RenderTreeManager renderTreeManager, BMPAlloc alloc) { }

	[Address(RVA = "0x1C80090", Offset = "0x1C7F290", Length = "0x1A")]
	[CalledBy(Type = typeof(BorderParams), Member = "ToNativeParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeBorderParams&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RectangleParams), Member = "ToNativeParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeRectParams&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001351")]
	public NativeColorPage ToNativeColorPage() { }

}

