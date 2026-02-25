namespace UnityEngine.UIElements.StyleSheets;

[Token(Token = "0x20005FE")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal struct ImageSource
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001662")]
	public Texture2D texture; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4001663")]
	public Sprite sprite; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001664")]
	public VectorImage vectorImage; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001665")]
	public RenderTexture renderTexture; //Field offset: 0x18

	[Address(RVA = "0x1BBEF90", Offset = "0x1BBE190", Length = "0xE8")]
	[CalledBy(Type = typeof(StylePropertyReader), Member = "TryGetImageSourceFromValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyValue), typeof(float), typeof(ImageSource&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6002A2C")]
	public bool IsNull() { }

}

