namespace UnityEngine.Rendering.PostProcessing;

[Preserve]
[Token(Token = "0x200002A")]
public sealed class Fog
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40000AF")]
	[Tooltip("Enables the internal deferred fog pass. Actual fog settings should be set in the Lighting panel.")]
	public bool enabled; //Field offset: 0x10
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x40000B0")]
	[Tooltip("Mark true for the fog to ignore the skybox")]
	public bool excludeSkybox; //Field offset: 0x11

	[Address(RVA = "0x1832A30", Offset = "0x1831C30", Length = "0xD")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600004E")]
	public Fog() { }

	[Address(RVA = "0x2FE4E0", Offset = "0x2FD6E0", Length = "0x6")]
	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	[Token(Token = "0x600004B")]
	internal DepthTextureMode GetCameraFlags() { }

	[Address(RVA = "0x1832570", Offset = "0x1831770", Length = "0x11E")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "SetLegacyCameraFlags", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RenderSettings), Member = "get_fog", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Shader), Member = "get_isSupported", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "get_actualRenderingPath", ReturnType = typeof(RenderingPath))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600004C")]
	internal bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	[Address(RVA = "0x1832690", Offset = "0x1831890", Length = "0x39B")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RenderSettings), Member = "get_fogEndDistance", ReturnType = typeof(float))]
	[Calls(Type = typeof(RenderSettings), Member = "get_fogStartDistance", ReturnType = typeof(float))]
	[Calls(Type = typeof(RenderSettings), Member = "get_fogDensity", ReturnType = typeof(float))]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mathf), Member = "GammaToLinearSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(RenderSettings), Member = "get_fogColor", ReturnType = typeof(Color))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(PropertySheet), typeof(int), typeof(bool), typeof(System.Nullable`1<UnityEngine.Rect>), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertySheet), Member = "ClearKeywords", ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(PropertySheet))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_isLinearColorSpace", ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600004D")]
	internal void Render(PostProcessRenderContext context) { }

}

