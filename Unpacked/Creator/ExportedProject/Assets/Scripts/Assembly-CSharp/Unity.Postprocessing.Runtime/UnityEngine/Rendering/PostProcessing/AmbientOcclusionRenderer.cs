namespace UnityEngine.Rendering.PostProcessing;

[Preserve]
[Token(Token = "0x2000011")]
internal sealed class AmbientOcclusionRenderer : PostProcessEffectRenderer<AmbientOcclusion>
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400002B")]
	private IAmbientOcclusionMethod[] m_Methods; //Field offset: 0x20

	[Address(RVA = "0x1829040", Offset = "0x1828240", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(PostProcessEffectRenderer`1), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x600001B")]
	public AmbientOcclusionRenderer() { }

	[Address(RVA = "0x1828B80", Offset = "0x1827D80", Length = "0x5F")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000015")]
	public IAmbientOcclusionMethod Get() { }

	[Address(RVA = "0x1828990", Offset = "0x1827B90", Length = "0x109")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x6000016")]
	public virtual DepthTextureMode GetCameraFlags() { }

	[Address(RVA = "0x1828AA0", Offset = "0x1827CA0", Length = "0x69")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BakeMSVOMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), typeof(RenderTargetIdentifier), typeof(System.Nullable`1<UnityEngine.Rendering.RenderTargetIdentifier>), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000019")]
	public MultiScaleVO GetMultiScaleVO() { }

	[Address(RVA = "0x1828B10", Offset = "0x1827D10", Length = "0x69")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000018")]
	public ScalableAO GetScalableAO() { }

	[Address(RVA = "0x1828BE0", Offset = "0x1827DE0", Length = "0x2AB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuiltinRenderTextureType)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(MultiScaleVO), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AmbientOcclusion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000013")]
	public virtual void Init() { }

	[Address(RVA = "0x1828E90", Offset = "0x1828090", Length = "0x87")]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Camera), Member = "get_actualRenderingPath", ReturnType = typeof(RenderingPath))]
	[Calls(Type = typeof(Camera), Member = "get_allowHDR", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000014")]
	public bool IsAmbientOnly(PostProcessRenderContext context) { }

	[Address(RVA = "0x1828F20", Offset = "0x1828120", Length = "0x110")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000017")]
	public virtual void Release() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600001A")]
	public virtual void Render(PostProcessRenderContext context) { }

}

