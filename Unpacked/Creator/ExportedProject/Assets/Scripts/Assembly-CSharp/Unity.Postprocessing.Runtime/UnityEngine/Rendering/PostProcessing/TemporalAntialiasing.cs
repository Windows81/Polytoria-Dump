namespace UnityEngine.Rendering.PostProcessing;

[Preserve]
[Token(Token = "0x2000042")]
public sealed class TemporalAntialiasing
{
	[Token(Token = "0x2000043")]
	private enum Pass
	{
		SolverDilate = 0,
		SolverNoDilate = 1,
	}

	[Token(Token = "0x4000122")]
	private const int k_SampleCount = 8; //Field offset: 0x0
	[Token(Token = "0x4000124")]
	private const int k_NumEyes = 2; //Field offset: 0x0
	[Token(Token = "0x4000125")]
	private const int k_NumHistoryTextures = 2; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Range(0.1, 1)]
	[Token(Token = "0x400011A")]
	[Tooltip("The diameter (in texels) inside which jitter samples are spread. Smaller values result in crisper but more aliased output, while larger values result in more stable, but blurrier, output.")]
	public float jitterSpread; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Range(0, 3)]
	[Token(Token = "0x400011B")]
	[Tooltip("Controls the amount of sharpening applied to the color buffer. High values may introduce dark-border artifacts.")]
	public float sharpness; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Range(0, 0.99)]
	[Token(Token = "0x400011C")]
	[Tooltip("The blend coefficient for a stationary fragment. Controls the percentage of history sample blended into the final color.")]
	public float stationaryBlending; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Range(0, 0.99)]
	[Token(Token = "0x400011D")]
	[Tooltip("The blend coefficient for a fragment with significant motion. Controls the percentage of history sample blended into the final color.")]
	public float motionBlending; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400011E")]
	public Func<Camera, Vector2, Matrix4x4> jitteredMatrixFunc; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400011F")]
	private Vector2 <jitter>k__BackingField; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000120")]
	private readonly RenderTargetIdentifier[] m_Mrt; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000121")]
	private bool m_ResetHistory; //Field offset: 0x38
	[CompilerGenerated]
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000123")]
	private int <sampleIndex>k__BackingField; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000126")]
	private readonly RenderTexture[][] m_HistoryTextures; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000127")]
	private readonly Int32[] m_HistoryPingPong; //Field offset: 0x48

	[Token(Token = "0x17000001")]
	public private Vector2 jitter
	{
		[Address(RVA = "0x53E790", Offset = "0x53D990", Length = "0x13")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600008B")]
		 get { } //Length: 19
		[Address(RVA = "0x183DB40", Offset = "0x183CD40", Length = "0x5")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600008C")]
		private set { } //Length: 5
	}

	[Token(Token = "0x17000002")]
	public private int sampleIndex
	{
		[Address(RVA = "0x3DCA70", Offset = "0x3DBC70", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600008D")]
		 get { } //Length: 4
		[Address(RVA = "0x5AABF0", Offset = "0x5A9DF0", Length = "0x4")]
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600008E")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x183DA70", Offset = "0x183CC70", Length = "0xCF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600009A")]
	public TemporalAntialiasing() { }

	[Address(RVA = "0x183C630", Offset = "0x183B830", Length = "0x5A0")]
	[CalledBy(Type = typeof(TemporalAntialiasing), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderTexture), Member = "IsCreated", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(RenderTexture), Member = "ReleaseTemporary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(bool), typeof(System.Nullable`1<UnityEngine.Rect>), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(Texture), Member = "set_filterMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FilterMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "GenerateHistoryName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture), typeof(int), typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite), typeof(int), typeof(int)}, ReturnType = typeof(RenderTexture))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000097")]
	private RenderTexture CheckHistory(int id, PostProcessRenderContext context) { }

	[Address(RVA = "0x183CBE0", Offset = "0x183BDE0", Length = "0x251")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Camera), Member = "get_orthographic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "get_projectionMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Camera), Member = "set_nonJitteredProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "GenerateRandomOffset", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "GetJitteredOrthographicProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector2)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(RuntimeUtilities), Member = "GetJitteredPerspectiveProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector2)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Camera), Member = "get_pixelWidth", ReturnType = typeof(int))]
	[Calls(Type = typeof(Camera), Member = "get_pixelHeight", ReturnType = typeof(int))]
	[Calls(Type = typeof(Camera), Member = "set_projectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Camera), Member = "set_useJitteredProjectionMatrixForTransparentRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000094")]
	public void ConfigureJitteredProjectionMatrix(PostProcessRenderContext context) { }

	[Address(RVA = "0x183CE40", Offset = "0x183C040", Length = "0x249")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "GenerateRandomOffset", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Camera), Member = "CopyStereoDeviceProjectionMatrixToNonJittered", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StereoscopicEye)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Camera), Member = "GetStereoNonJitteredProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StereoscopicEye)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "GenerateJitteredProjectionMatrixFromOriginal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext), typeof(Matrix4x4), typeof(Vector2)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Camera), Member = "SetStereoProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StereoscopicEye), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Camera), Member = "set_useJitteredProjectionMatrixForTransparentRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000095")]
	public void ConfigureStereoJitteredProjectionMatrices(PostProcessRenderContext context) { }

	[Address(RVA = "0x183D090", Offset = "0x183C290", Length = "0xDC")]
	[CalledBy(Type = typeof(TemporalAntialiasing), Member = "CheckHistory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(PostProcessRenderContext)}, ReturnType = typeof(RenderTexture))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000096")]
	private void GenerateHistoryName(RenderTexture rt, int id, PostProcessRenderContext context) { }

	[Address(RVA = "0x183D170", Offset = "0x183C370", Length = "0x94")]
	[CalledBy(Type = typeof(TemporalAntialiasing), Member = "GetJitteredProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(Matrix4x4))]
	[CalledBy(Type = typeof(TemporalAntialiasing), Member = "ConfigureJitteredProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TemporalAntialiasing), Member = "ConfigureStereoJitteredProjectionMatrices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(HaltonSeq), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(float))]
	[Token(Token = "0x6000092")]
	private Vector2 GenerateRandomOffset() { }

	[Address(RVA = "0x53E790", Offset = "0x53D990", Length = "0x13")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600008B")]
	public Vector2 get_jitter() { }

	[Address(RVA = "0x3DCA70", Offset = "0x3DBC70", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600008D")]
	public int get_sampleIndex() { }

	[Address(RVA = "0x2FF950", Offset = "0x2FEB50", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000090")]
	internal DepthTextureMode GetCameraFlags() { }

	[Address(RVA = "0x183D210", Offset = "0x183C410", Length = "0x206")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "GenerateRandomOffset", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Camera), Member = "get_orthographic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "GetJitteredOrthographicProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector2)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(RuntimeUtilities), Member = "GetJitteredPerspectiveProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector2)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Camera), Member = "get_pixelWidth", ReturnType = typeof(int))]
	[Calls(Type = typeof(Camera), Member = "get_pixelHeight", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000093")]
	public Matrix4x4 GetJitteredProjectionMatrix(Camera camera) { }

	[Address(RVA = "0x183D420", Offset = "0x183C620", Length = "0x22")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnPreCull", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnPostRender", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "SetLegacyCameraFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessRenderContext), Member = "IsTemporalAntialiasingActive", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RuntimeUtilities), Member = "IsTemporalAntialiasingActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessLayer)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600008F")]
	public bool IsSupported() { }

	[Address(RVA = "0x183D450", Offset = "0x183C650", Length = "0x172")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "OnDisable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderTexture), Member = "ReleaseTemporary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTexture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000099")]
	internal void Release() { }

	[Address(RVA = "0x183D5D0", Offset = "0x183C7D0", Length = "0x496")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(PropertySheet))]
	[Calls(Type = typeof(CommandBuffer), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TemporalAntialiasing), Member = "CheckHistory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(PostProcessRenderContext)}, ReturnType = typeof(RenderTexture))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Camera), Member = "get_orthographic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier[]), typeof(RenderTargetIdentifier), typeof(PropertySheet), typeof(int), typeof(bool), typeof(System.Nullable`1<UnityEngine.Rect>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000098")]
	internal void Render(PostProcessRenderContext context) { }

	[Address(RVA = "0x17658B0", Offset = "0x1764AB0", Length = "0x5")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000091")]
	internal void ResetHistory() { }

	[Address(RVA = "0x183DB40", Offset = "0x183CD40", Length = "0x5")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600008C")]
	private void set_jitter(Vector2 value) { }

	[Address(RVA = "0x5AABF0", Offset = "0x5A9DF0", Length = "0x4")]
	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600008E")]
	private void set_sampleIndex(int value) { }

}

