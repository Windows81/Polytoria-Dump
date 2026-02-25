namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x20005B6")]
internal class UIRVEShaderInfoAllocator
{
	[Token(Token = "0x40014AC")]
	private static readonly Vector2Int identityTransformTexel; //Field offset: 0x0
	[Token(Token = "0x40014AD")]
	private static readonly Vector2Int infiniteClipRectTexel; //Field offset: 0x8
	[Token(Token = "0x40014AE")]
	private static readonly Vector2Int fullOpacityTexel; //Field offset: 0x10
	[Token(Token = "0x40014AF")]
	private static readonly Vector2Int clearColorTexel; //Field offset: 0x18
	[Token(Token = "0x40014B0")]
	private static readonly Vector2Int defaultTextCoreSettingsTexel; //Field offset: 0x20
	[Token(Token = "0x40014B1")]
	private static readonly Matrix4x4 identityTransformValue; //Field offset: 0x28
	[Token(Token = "0x40014B2")]
	private static readonly Vector4 identityTransformRow0Value; //Field offset: 0x68
	[Token(Token = "0x40014B3")]
	private static readonly Vector4 identityTransformRow1Value; //Field offset: 0x78
	[Token(Token = "0x40014B4")]
	private static readonly Vector4 identityTransformRow2Value; //Field offset: 0x88
	[Token(Token = "0x40014B5")]
	private static readonly Vector4 infiniteClipRectValue; //Field offset: 0x98
	[Token(Token = "0x40014B6")]
	private static readonly Vector4 fullOpacityValue; //Field offset: 0xA8
	[Token(Token = "0x40014B7")]
	private static readonly Vector4 clearColorValue; //Field offset: 0xB8
	[Token(Token = "0x40014B8")]
	private static readonly TextCoreSettings defaultTextCoreSettingsValue; //Field offset: 0xC8
	[Token(Token = "0x40014B9")]
	public static readonly BMPAlloc identityTransform; //Field offset: 0x108
	[Token(Token = "0x40014BA")]
	public static readonly BMPAlloc infiniteClipRect; //Field offset: 0x110
	[Token(Token = "0x40014BB")]
	public static readonly BMPAlloc fullOpacity; //Field offset: 0x118
	[Token(Token = "0x40014BC")]
	public static readonly BMPAlloc clearColor; //Field offset: 0x120
	[Token(Token = "0x40014BD")]
	public static readonly BMPAlloc defaultTextCoreSettings; //Field offset: 0x128
	[Token(Token = "0x40014BE")]
	private static int s_DefaultShaderInfoTextureRefCount; //Field offset: 0x130
	[Token(Token = "0x40014BF")]
	private static Texture2D s_DefaultShaderInfoTexture; //Field offset: 0x138
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40014A4")]
	private BaseShaderInfoStorage m_Storage; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40014A5")]
	private BitmapAllocator32 m_TransformAllocator; //Field offset: 0x18
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40014A6")]
	private BitmapAllocator32 m_ClipRectAllocator; //Field offset: 0x38
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40014A7")]
	private BitmapAllocator32 m_OpacityAllocator; //Field offset: 0x58
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40014A8")]
	private BitmapAllocator32 m_ColorAllocator; //Field offset: 0x78
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40014A9")]
	private BitmapAllocator32 m_TextSettingsAllocator; //Field offset: 0x98
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40014AA")]
	private bool m_StorageReallyCreated; //Field offset: 0xB8
	[FieldOffset(Offset = "0xBC")]
	[Token(Token = "0x40014AB")]
	private ColorSpace m_ColorSpace; //Field offset: 0xBC

	[Token(Token = "0x17000A2D")]
	public Texture atlas
	{
		[Address(RVA = "0x1BBB730", Offset = "0x1BBA930", Length = "0x88")]
		[CalledBy(Type = typeof(RenderTreeManager), Member = "SerializeRootTreeCommands", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RenderTreeManager), Member = "RenderSingleTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTree), typeof(RenderTexture), typeof(RectInt)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60028A2")]
		 get { } //Length: 136
	}

	[Token(Token = "0x17000A2C")]
	private static int pageHeight
	{
		[Address(RVA = "0x1BBB7C0", Offset = "0x1BBA9C0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600289D")]
		private get { } //Length: 8
	}

	[Token(Token = "0x17000A2B")]
	private static int pageWidth
	{
		[Address(RVA = "0x1BBB7D0", Offset = "0x1BBA9D0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600289C")]
		private get { } //Length: 8
	}

	[Address(RVA = "0x1BBB1F0", Offset = "0x1BBA3F0", Length = "0x2FC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Matrix4x4), Member = "GetRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Vector4))]
	[Token(Token = "0x60028BB")]
	private static UIRVEShaderInfoAllocator() { }

	[Address(RVA = "0x1BBB4F0", Offset = "0x1BBA6F0", Length = "0x234")]
	[CalledBy(Type = typeof(RenderTreeManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseVisualElementPanel)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BitmapAllocator32), Member = "Construct", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitmapAllocator32), Member = "ForceFirstAlloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort), typeof(ushort)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "AcquireDefaultShaderInfoTexture", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60028A3")]
	public UIRVEShaderInfoAllocator(ColorSpace colorSpace) { }

	[Address(RVA = "0x1BB8A20", Offset = "0x1BB7C20", Length = "0x503")]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorSpace)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(TextureFormat), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "set_filterMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FilterMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = "SetPixel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Color)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = "Apply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600289E")]
	private static void AcquireDefaultShaderInfoTexture() { }

	[Address(RVA = "0x1BB8F30", Offset = "0x1BB8130", Length = "0x2E")]
	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnClippingChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(RenderData), typeof(RenderData), typeof(uint), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(UIRenderDevice), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "ReallyCreateStorage", ReturnType = typeof(void))]
	[Calls(Type = typeof(BitmapAllocator32), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseShaderInfoStorage)}, ReturnType = typeof(BMPAlloc))]
	[Token(Token = "0x60028A8")]
	public BMPAlloc AllocClipRect() { }

	[Address(RVA = "0x1BB8F60", Offset = "0x1BB8160", Length = "0x2E")]
	[CalledBy(Type = typeof(RenderEvents), Member = "InitColorIDs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(VisualElement)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "ReallyCreateStorage", ReturnType = typeof(void))]
	[Calls(Type = typeof(BitmapAllocator32), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseShaderInfoStorage)}, ReturnType = typeof(BMPAlloc))]
	[Token(Token = "0x60028AA")]
	public BMPAlloc AllocColor() { }

	[Address(RVA = "0x1BB8F90", Offset = "0x1BB8190", Length = "0x2E")]
	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnOpacityChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(float), typeof(RenderData), typeof(uint), typeof(bool), typeof(ChainBuilderStats&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "ReallyCreateStorage", ReturnType = typeof(void))]
	[Calls(Type = typeof(BitmapAllocator32), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseShaderInfoStorage)}, ReturnType = typeof(BMPAlloc))]
	[Token(Token = "0x60028A9")]
	public BMPAlloc AllocOpacity() { }

	[Address(RVA = "0x1BB8FC0", Offset = "0x1BB81C0", Length = "0x31")]
	[CalledBy(Type = typeof(RenderEvents), Member = "UpdateTextCoreSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(VisualElement)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "ReallyCreateStorage", ReturnType = typeof(void))]
	[Calls(Type = typeof(BitmapAllocator32), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseShaderInfoStorage)}, ReturnType = typeof(BMPAlloc))]
	[Token(Token = "0x60028AB")]
	public BMPAlloc AllocTextCoreSettings(TextCoreSettings settings) { }

	[Address(RVA = "0x1BB9000", Offset = "0x1BB8200", Length = "0x89")]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "ReallyCreateStorage", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "SetTransformValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "SetClipRectValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc), typeof(Vector4)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "SetOpacityValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "SetColorValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc), typeof(Color)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "SetTextCoreSettingValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc), typeof(TextCoreSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60028A0")]
	private static Vector2Int AllocToTexelCoord(ref BitmapAllocator32 allocator, BMPAlloc alloc) { }

	[Address(RVA = "0x1BB9090", Offset = "0x1BB8290", Length = "0x2E")]
	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnChildAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(VisualElement), typeof(VisualElement), typeof(int)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "ReallyCreateStorage", ReturnType = typeof(void))]
	[Calls(Type = typeof(BitmapAllocator32), Member = "Allocate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseShaderInfoStorage)}, ReturnType = typeof(BMPAlloc))]
	[Token(Token = "0x60028A7")]
	public BMPAlloc AllocTransform() { }

	[Address(RVA = "0x1BB90C0", Offset = "0x1BB82C0", Length = "0x184")]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "ReallyCreateStorage", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60028A1")]
	private static bool AtlasRectMatchesPage(ref BitmapAllocator32 allocator, BMPAlloc defAlloc, RectInt atlasRect) { }

	[Address(RVA = "0x1BB9250", Offset = "0x1BB8450", Length = "0x111")]
	[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessMeshEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(TextureId)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60028B7")]
	public Color32 ClipRectAllocToVertexData(BMPAlloc alloc) { }

	[Address(RVA = "0x1BB9370", Offset = "0x1BB8570", Length = "0x114")]
	[CalledBy(Type = typeof(ColorPage), Member = "Init", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(BMPAlloc)}, ReturnType = typeof(ColorPage))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60028B9")]
	public Color32 ColorAllocToVertexData(BMPAlloc alloc) { }

	[Address(RVA = "0x1BB9490", Offset = "0x1BB8690", Length = "0x15F")]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BaseShaderInfoStorage), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UIRUtility), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Token(Token = "0x60028A5")]
	public void Dispose() { }

	[Address(RVA = "0x1BB95F0", Offset = "0x1BB87F0", Length = "0x96")]
	[CalledBy(Type = typeof(RenderEvents), Member = "ResetRenderData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(RenderData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnClippingChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(RenderData), typeof(RenderData), typeof(uint), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(UIRenderDevice), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitmapAllocator32), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60028B2")]
	public void FreeClipRect(BMPAlloc alloc) { }

	[Address(RVA = "0x1BB9690", Offset = "0x1BB8890", Length = "0x96")]
	[CalledBy(Type = typeof(RenderEvents), Member = "ResetRenderData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(RenderData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitmapAllocator32), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60028B4")]
	public void FreeColor(BMPAlloc alloc) { }

	[Address(RVA = "0x1BB9730", Offset = "0x1BB8930", Length = "0x96")]
	[CalledBy(Type = typeof(RenderEvents), Member = "ResetRenderData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(RenderData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitmapAllocator32), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60028B3")]
	public void FreeOpacity(BMPAlloc alloc) { }

	[Address(RVA = "0x1BB97D0", Offset = "0x1BB89D0", Length = "0x99")]
	[CalledBy(Type = typeof(RenderEvents), Member = "ResetRenderData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(RenderData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitmapAllocator32), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60028B5")]
	public void FreeTextCoreSettings(BMPAlloc alloc) { }

	[Address(RVA = "0x1BB9870", Offset = "0x1BB8A70", Length = "0x96")]
	[CalledBy(Type = typeof(RenderEvents), Member = "ResetRenderData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(RenderData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BitmapAllocator32), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc)}, ReturnType = typeof(void))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60028B1")]
	public void FreeTransform(BMPAlloc alloc) { }

	[Address(RVA = "0x1BBB730", Offset = "0x1BBA930", Length = "0x88")]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "SerializeRootTreeCommands", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "RenderSingleTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTree), typeof(RenderTexture), typeof(RectInt)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60028A2")]
	public Texture get_atlas() { }

	[Address(RVA = "0x1BBB7C0", Offset = "0x1BBA9C0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600289D")]
	private static int get_pageHeight() { }

	[Address(RVA = "0x1BBB7D0", Offset = "0x1BBA9D0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600289C")]
	private static int get_pageWidth() { }

	[Address(RVA = "0x1BB9910", Offset = "0x1BB8B10", Length = "0x1E")]
	[CalledBy(Type = typeof(RenderTreeManager), Member = "ProcessChanges", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60028A6")]
	public void IssuePendingStorageChanges() { }

	[Address(RVA = "0x1BB9930", Offset = "0x1BB8B30", Length = "0x111")]
	[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessMeshEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(TextureId)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VisualChangesProcessor), Member = "DoUpdateOpacityId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderData), typeof(RenderTreeManager), typeof(MeshHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60028B8")]
	public Color32 OpacityAllocToVertexData(BMPAlloc alloc) { }

	[Address(RVA = "0x1BB9A50", Offset = "0x1BB8C50", Length = "0x98C")]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "AllocTransform", ReturnType = typeof(BMPAlloc))]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "AllocClipRect", ReturnType = typeof(BMPAlloc))]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "AllocOpacity", ReturnType = typeof(BMPAlloc))]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "AllocColor", ReturnType = typeof(BMPAlloc))]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "AllocTextCoreSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextCoreSettings)}, ReturnType = typeof(BMPAlloc))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "SetTextCoreSettingValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc), typeof(TextCoreSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mathf), Member = "GammaToLinearSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "AllocToTexelCoord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitmapAllocator32&), typeof(BMPAlloc)}, ReturnType = typeof(Vector2Int))]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "SetTransformValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BMPAlloc), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "AtlasRectMatchesPage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitmapAllocator32&), typeof(BMPAlloc), typeof(RectInt)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ShaderInfoStorageRGBAFloat), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60028A4")]
	private void ReallyCreateStorage() { }

	[Address(RVA = "0x1BBA3E0", Offset = "0x1BB95E0", Length = "0x100")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(UIRUtility), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600289F")]
	private static void ReleaseDefaultShaderInfoTexture() { }

	[Address(RVA = "0x1BBA4E0", Offset = "0x1BB96E0", Length = "0x13A")]
	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnTransformOrSizeChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(RenderData), typeof(uint), typeof(UIRenderDevice), typeof(bool), typeof(bool), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "AllocToTexelCoord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitmapAllocator32&), typeof(BMPAlloc)}, ReturnType = typeof(Vector2Int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60028AD")]
	public void SetClipRectValue(BMPAlloc alloc, Vector4 clipRect) { }

	[Address(RVA = "0x1BBA620", Offset = "0x1BB9820", Length = "0x1B1")]
	[CalledBy(Type = typeof(RenderEvents), Member = "SetColorValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(VisualElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "AllocToTexelCoord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitmapAllocator32&), typeof(BMPAlloc)}, ReturnType = typeof(Vector2Int))]
	[Calls(Type = typeof(Mathf), Member = "GammaToLinearSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60028AF")]
	public void SetColorValue(BMPAlloc alloc, Color color) { }

	[Address(RVA = "0x1BBA7E0", Offset = "0x1BB99E0", Length = "0x12E")]
	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnOpacityChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(float), typeof(RenderData), typeof(uint), typeof(bool), typeof(ChainBuilderStats&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "AllocToTexelCoord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitmapAllocator32&), typeof(BMPAlloc)}, ReturnType = typeof(Vector2Int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60028AE")]
	public void SetOpacityValue(BMPAlloc alloc, float opacity) { }

	[Address(RVA = "0x1BBA910", Offset = "0x1BB9B10", Length = "0x420")]
	[CalledBy(Type = typeof(RenderEvents), Member = "UpdateTextCoreSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(VisualElement)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "ReallyCreateStorage", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "AllocToTexelCoord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitmapAllocator32&), typeof(BMPAlloc)}, ReturnType = typeof(Vector2Int))]
	[Calls(Type = typeof(Mathf), Member = "GammaToLinearSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60028B0")]
	public void SetTextCoreSettingValue(BMPAlloc alloc, TextCoreSettings settings) { }

	[Address(RVA = "0x1BBAD40", Offset = "0x1BB9F40", Length = "0x264")]
	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnChildAdded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(VisualElement), typeof(VisualElement), typeof(int)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(RenderEvents), Member = "DepthFirstOnTransformOrSizeChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTreeManager), typeof(RenderData), typeof(uint), typeof(UIRenderDevice), typeof(bool), typeof(bool), typeof(ChainBuilderStats&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "ReallyCreateStorage", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UIRVEShaderInfoAllocator), Member = "AllocToTexelCoord", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BitmapAllocator32&), typeof(BMPAlloc)}, ReturnType = typeof(Vector2Int))]
	[Calls(Type = typeof(Matrix4x4), Member = "GetRow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60028AC")]
	public void SetTransformValue(BMPAlloc alloc, Matrix4x4 xform) { }

	[Address(RVA = "0x1BBAFB0", Offset = "0x1BBA1B0", Length = "0x114")]
	[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessMeshEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(TextureId)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60028BA")]
	public Color32 TextCoreSettingsToVertexData(BMPAlloc alloc) { }

	[Address(RVA = "0x1BBB0D0", Offset = "0x1BBA2D0", Length = "0x111")]
	[CalledBy(Type = typeof(EntryProcessor), Member = "ProcessMeshEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(TextureId)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60028B6")]
	public Color32 TransformAllocToVertexData(BMPAlloc alloc) { }

}

