namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x20005B3")]
internal struct BMPAlloc
{
	[Token(Token = "0x4001496")]
	public static readonly BMPAlloc Invalid; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001497")]
	public int page; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4001498")]
	public ushort pageLine; //Field offset: 0x4
	[FieldOffset(Offset = "0x6")]
	[Token(Token = "0x4001499")]
	public byte bitIndex; //Field offset: 0x6
	[FieldOffset(Offset = "0x7")]
	[Token(Token = "0x400149A")]
	public OwnedState ownedState; //Field offset: 0x7

	[Address(RVA = "0x1BA3900", Offset = "0x1BA2B00", Length = "0x4C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6002893")]
	private static BMPAlloc() { }

	[Address(RVA = "0x1BA37F0", Offset = "0x1BA29F0", Length = "0x1F")]
	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnClippingChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(RenderData), typeof(RenderData), typeof(uint), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(UIRenderDevice), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnOpacityChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(float), typeof(RenderData), typeof(uint), typeof(bool), typeof(ChainBuilderStats&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualChangesProcessor), Member = "DepthFirstOnVisualsChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(uint), typeof(bool), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002890")]
	public bool Equals(BMPAlloc other) { }

	[Address(RVA = "0x1BA3810", Offset = "0x1BA2A10", Length = "0xA")]
	[CalledBy(Type = typeof(ColorPage), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(BMPAlloc)}, ReturnType = typeof(ColorPage))]
	[CalledBy(Type = typeof(RenderData), Member = "AllocatesID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RenderData), Member = "InheritsID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RenderEvents), Member = "GetTransformIDTransformInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData)}, ReturnType = typeof(Matrix4x4))]
	[CalledBy(Type = typeof(RenderEvents), Member = "GetClipRectIDClipInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData)}, ReturnType = typeof(Vector4))]
	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnChildAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(VisualElement), typeof(VisualElement), typeof(int)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(RenderEvents), Member = "ResetRenderData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(RenderData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnClippingChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(RenderData), typeof(RenderData), typeof(uint), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(UIRenderDevice), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnOpacityChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(float), typeof(RenderData), typeof(uint), typeof(bool), typeof(ChainBuilderStats&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnTransformOrSizeChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(RenderData), typeof(uint), typeof(UIRenderDevice), typeof(bool), typeof(bool), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderEvents), Member = "UpdateTextCoreSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(VisualElement)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RenderEvents), Member = "InitColorIDs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(VisualElement)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RenderEvents), Member = "SetColorValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 39)]
	[Token(Token = "0x6002891")]
	public bool IsValid() { }

	[Address(RVA = "0x1BA3820", Offset = "0x1BA2A20", Length = "0xDB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Token(Token = "0x6002892")]
	public virtual string ToString() { }

}

