namespace UnityEngine.Rendering.PostProcessing;

[Preserve]
[Token(Token = "0x2000015")]
internal sealed class AutoExposureRenderer : PostProcessEffectRenderer<AutoExposure>
{
	[Token(Token = "0x4000036")]
	private const int k_NumEyes = 2; //Field offset: 0x0
	[Token(Token = "0x4000037")]
	private const int k_NumAutoExposureTextures = 2; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000038")]
	private readonly RenderTexture[][] m_AutoExposurePool; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000039")]
	private Int32[] m_AutoExposurePingPong; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400003A")]
	private RenderTexture m_CurrentAutoExposure; //Field offset: 0x30

	[Address(RVA = "0x182A320", Offset = "0x1829520", Length = "0x17D")]
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
	[Token(Token = "0x600001F")]
	public AutoExposureRenderer() { }

	[Address(RVA = "0x1829760", Offset = "0x1828960", Length = "0x1E8")]
	[CalledBy(Type = typeof(AutoExposureRenderer), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(RenderTexture), Member = "Create", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(RenderTexture), Member = "set_enableRandomWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(RenderTexture), Member = "IsCreated", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(RenderTextureFormat)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000020")]
	private void CheckTexture(int eye, int id) { }

	[Address(RVA = "0x1829950", Offset = "0x1828B50", Length = "0xD6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000022")]
	public virtual void Release() { }

	[Address(RVA = "0x1829A30", Offset = "0x1828C30", Length = "0x8EB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Exp2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(RuntimeUtilities), Member = "CopyTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeTextureParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(string), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(LogHistogram), Member = "GetHistogramScaleOffsetRes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessRenderContext)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(Time), Member = "get_deltaTime", ReturnType = typeof(float))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeVectorParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(string), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetComputeBufferParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeShader), typeof(int), typeof(string), typeof(ComputeBuffer)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "EndSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputeShader), Member = "FindKernel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(AutoExposureRenderer), Member = "CheckTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "BeginSample", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000021")]
	public virtual void Render(PostProcessRenderContext context) { }

}

