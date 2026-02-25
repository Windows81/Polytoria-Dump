namespace UnityEngine.Rendering.PostProcessing;

[Preserve]
[Token(Token = "0x2000026")]
internal sealed class DepthOfFieldRenderer : PostProcessEffectRenderer<DepthOfField>
{
	[Token(Token = "0x2000027")]
	private enum Pass
	{
		CoCCalculation = 0,
		CoCTemporalFilter = 1,
		DownsampleAndPrefilter = 2,
		BokehSmallKernel = 3,
		BokehMediumKernel = 4,
		BokehLargeKernel = 5,
		BokehVeryLargeKernel = 6,
		PostFilter = 7,
		Combine = 8,
		DebugOverlay = 9,
	}

	[Token(Token = "0x400009B")]
	private const int k_NumEyes = 2; //Field offset: 0x0
	[Token(Token = "0x400009C")]
	private const int k_NumCoCHistoryTextures = 2; //Field offset: 0x0
	[Token(Token = "0x400009F")]
	private const float k_FilmHeight = 0.024; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400009D")]
	private readonly RenderTexture[][] m_CoCHistoryTextures; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400009E")]
	private Int32[] m_HistoryPingPong; //Field offset: 0x28

	[Address(RVA = "0x1831F60", Offset = "0x1831160", Length = "0x17D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(PostProcessEffectRenderer`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000041")]
	public DepthOfFieldRenderer() { }

	[Address(RVA = "0x1830DE0", Offset = "0x182FFE0", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000044")]
	private float CalculateMaxCoCRadius(int screenHeight) { }

	[Address(RVA = "0x1830E60", Offset = "0x1830060", Length = "0x24A")]
	[CalledBy(Type = typeof(DepthOfFieldRenderer), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(RenderTexture), Member = "Create", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Texture), Member = "set_filterMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FilterMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite), typeof(int), typeof(int)}, ReturnType = typeof(RenderTexture))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(RenderTexture), Member = "ReleaseTemporary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTexture), Member = "IsCreated", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000045")]
	private RenderTexture CheckHistory(int eye, int id, PostProcessRenderContext context, RenderTextureFormat format) { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000042")]
	public virtual DepthTextureMode GetCameraFlags() { }

	[Address(RVA = "0x18310B0", Offset = "0x18302B0", Length = "0x120")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTexture), Member = "ReleaseTemporary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000047")]
	public virtual void Release() { }

	[Address(RVA = "0x18311E0", Offset = "0x18303E0", Length = "0xCE7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "IsDebugOverlayEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugOverlay)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "ReleaseTemporaryRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(DepthOfFieldRenderer), Member = "CheckHistory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(PostProcessRenderContext), typeof(RenderTextureFormat)}, ReturnType = typeof(RenderTexture))]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "IsTemporalAntialiasingActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(PropertySheet), typeof(int), typeof(bool), typeof(System.Nullable`1<UnityEngine.Rect>), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(int), typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite), typeof(FilterMode), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "PushDebugOverlay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(PropertySheet), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(PropertySheet))]
	[Calls(Type = typeof(TextureFormatUtilities), Member = "IsSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Camera), Member = "get_allowHDR", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuiltinRenderTextureType)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(CommandBuffer), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000046")]
	public virtual void Render(PostProcessRenderContext context) { }

	[Address(RVA = "0x1831ED0", Offset = "0x18310D0", Length = "0x8F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextureFormatUtilities), Member = "IsSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000043")]
	private RenderTextureFormat SelectFormat(RenderTextureFormat primary, RenderTextureFormat secondary) { }

}

