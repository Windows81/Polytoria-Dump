namespace UnityEngine.Rendering.PostProcessing;

[Preserve]
[Token(Token = "0x2000035")]
internal sealed class ScalableAO : IAmbientOcclusionMethod
{
	[Token(Token = "0x2000036")]
	private enum Pass
	{
		OcclusionEstimationForward = 0,
		OcclusionEstimationDeferred = 1,
		HorizontalBlurForward = 2,
		HorizontalBlurDeferred = 3,
		VerticalBlur = 4,
		CompositionForward = 5,
		CompositionDeferred = 6,
		DebugOverlay = 7,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000E3")]
	private RenderTexture m_Result; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000E4")]
	private PropertySheet m_PropertySheet; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40000E5")]
	private AmbientOcclusion m_Settings; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40000E6")]
	private readonly RenderTargetIdentifier[] m_MRT; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000E7")]
	private readonly Int32[] m_SampleCount; //Field offset: 0x30

	[Address(RVA = "0x183A000", Offset = "0x1839200", Length = "0x16B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuiltinRenderTextureType)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000076")]
	public ScalableAO(AmbientOcclusion settings) { }

	[Address(RVA = "0x1839080", Offset = "0x1838280", Length = "0x273")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CommandBuffer), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuiltinRenderTextureType)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier[]), typeof(RenderTargetIdentifier), typeof(PropertySheet), typeof(int), typeof(bool), typeof(System.Nullable`1<UnityEngine.Rect>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600007C")]
	public override void CompositeAmbientOnly(PostProcessRenderContext context) { }

	[Address(RVA = "0x1839300", Offset = "0x1838500", Length = "0x206")]
	[CalledBy(Type = typeof(ScalableAO), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext), typeof(CommandBuffer), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(PropertySheet))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(RenderTexture), Member = "IsCreated", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTexture), Member = "Release", ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite), typeof(int), typeof(int)}, ReturnType = typeof(RenderTexture))]
	[Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HideFlags)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "set_filterMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FilterMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTexture), Member = "Create", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x6000078")]
	private void DoLazyInitialization(PostProcessRenderContext context) { }

	[Address(RVA = "0x300CD0", Offset = "0x2FFED0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000077")]
	public override DepthTextureMode GetCameraFlags() { }

	[Address(RVA = "0x1839510", Offset = "0x1838710", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600007D")]
	public override void Release() { }

	[Address(RVA = "0x18398B0", Offset = "0x1838AB0", Length = "0x74D")]
	[CalledBy(Type = typeof(ScalableAO), Member = "RenderAfterOpaque", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScalableAO), Member = "RenderAmbientOnly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PropertySheet), Member = "EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "PushDebugOverlay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(PropertySheet), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "IsDebugOverlayEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DebugOverlay)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(CommandBuffer), Member = "ReleaseTemporaryRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(PropertySheet), typeof(int), typeof(bool), typeof(System.Nullable`1<UnityEngine.Rect>), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuiltinRenderTextureType)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(PostProcessRenderContext), Member = "GetScreenSpaceTemporaryRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(int), typeof(int), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite), typeof(FilterMode), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderSettings), Member = "get_fogEndDistance", ReturnType = typeof(float))]
	[Calls(Type = typeof(RenderSettings), Member = "get_fogStartDistance", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(RenderSettings), Member = "get_fog", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "get_actualRenderingPath", ReturnType = typeof(RenderingPath))]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(PropertySheet), Member = "ClearKeywords", ReturnType = typeof(void))]
	[Calls(Type = typeof(ScalableAO), Member = "DoLazyInitialization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RenderSettings), Member = "get_fogDensity", ReturnType = typeof(float))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000079")]
	private void Render(PostProcessRenderContext context, CommandBuffer cmd, int occlusionSource) { }

	[Address(RVA = "0x1839580", Offset = "0x1838780", Length = "0x288")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CommandBuffer), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScalableAO), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext), typeof(CommandBuffer), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuiltinRenderTextureType)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(PropertySheet), typeof(int), typeof(RenderBufferLoadAction), typeof(System.Nullable`1<UnityEngine.Rect>), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600007A")]
	public override void RenderAfterOpaque(PostProcessRenderContext context) { }

	[Address(RVA = "0x1839810", Offset = "0x1838A10", Length = "0x94")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CommandBuffer), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScalableAO), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext), typeof(CommandBuffer), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600007B")]
	public override void RenderAmbientOnly(PostProcessRenderContext context) { }

}

