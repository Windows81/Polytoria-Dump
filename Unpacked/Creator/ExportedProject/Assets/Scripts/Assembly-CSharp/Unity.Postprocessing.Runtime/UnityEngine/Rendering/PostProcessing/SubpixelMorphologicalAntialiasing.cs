namespace UnityEngine.Rendering.PostProcessing;

[Preserve]
[Token(Token = "0x200003F")]
public sealed class SubpixelMorphologicalAntialiasing
{
	[Token(Token = "0x2000040")]
	private enum Pass
	{
		EdgeDetection = 0,
		BlendWeights = 3,
		NeighborhoodBlending = 6,
	}

	[Token(Token = "0x2000041")]
	internal enum Quality
	{
		Low = 0,
		Medium = 1,
		High = 2,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000111")]
	[Tooltip("Lower quality is faster at the expense of visual quality (Low = ~60%, Medium = ~80%).")]
	public Quality quality; //Field offset: 0x10

	[Address(RVA = "0x183C620", Offset = "0x183B820", Length = "0xE")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600008A")]
	public SubpixelMorphologicalAntialiasing() { }

	[Address(RVA = "0x183C080", Offset = "0x183B280", Length = "0x43")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderFinalPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000088")]
	public bool IsSupported() { }

	[Address(RVA = "0x183C0D0", Offset = "0x183B2D0", Length = "0x542")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderFinalPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CommandBuffer), Member = "ReleaseTemporaryRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeUtilities), Member = "BlitFullscreenTriangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier), typeof(PropertySheet), typeof(int), typeof(bool), typeof(System.Nullable`1<UnityEngine.Rect>), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(CommandBuffer), Member = "GetTemporaryRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(FilterMode), typeof(RenderTextureFormat), typeof(RenderTextureReadWrite), typeof(int), typeof(bool), typeof(RenderTextureMemoryless), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CommandBuffer), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MaterialPropertyBlock), Member = "SetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Texture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PropertySheetFactory), Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(PropertySheet))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "IsDynamicResolutionEnabled", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000089")]
	internal void Render(PostProcessRenderContext context) { }

}

