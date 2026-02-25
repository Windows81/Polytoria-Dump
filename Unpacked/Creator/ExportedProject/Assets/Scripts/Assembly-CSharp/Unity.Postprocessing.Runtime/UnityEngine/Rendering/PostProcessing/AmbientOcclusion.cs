namespace UnityEngine.Rendering.PostProcessing;

[PostProcess(typeof(AmbientOcclusionRenderer), "Unity/Ambient Occlusion", True)]
[Token(Token = "0x200000F")]
public sealed class AmbientOcclusion : PostProcessEffectSettings
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400001F")]
	[Tooltip("The ambient occlusion method to use. \"Multi Scale Volumetric Obscurance\" is higher quality and faster on desktop & console platforms but requires compute shader support.")]
	public AmbientOcclusionModeParameter mode; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Range(0, 4)]
	[Token(Token = "0x4000020")]
	[Tooltip("The degree of darkness added by ambient occlusion. Higher values produce darker areas.")]
	public FloatParameter intensity; //Field offset: 0x38
	[ColorUsage(False)]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000021")]
	[Tooltip("The custom color to use for the ambient occlusion. The default is black.")]
	public ColorParameter color; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000022")]
	[Tooltip("Check this box to mark this Volume as to only affect ambient lighting. This mode is only available with the Deferred rendering path and HDR rendering. Objects rendered with the Forward rendering path won't get any ambient occlusion.")]
	public BoolParameter ambientOnly; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Range(-8, 0)]
	[Token(Token = "0x4000023")]
	public FloatParameter noiseFilterTolerance; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Range(-8, -1)]
	[Token(Token = "0x4000024")]
	public FloatParameter blurTolerance; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Range(-12, -1)]
	[Token(Token = "0x4000025")]
	public FloatParameter upsampleTolerance; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Range(1, 10)]
	[Token(Token = "0x4000026")]
	[Tooltip("This modifies the thickness of occluders. It increases the size of dark areas and also introduces a dark halo around objects.")]
	public FloatParameter thicknessModifier; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Range(0, 0.001)]
	[Token(Token = "0x4000027")]
	[Tooltip("Add a bias distance to sampled depth in AO to reduce self-shadowing aliasing artifacts. ")]
	public FloatParameter zBias; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Range(0, 1)]
	[Token(Token = "0x4000028")]
	[Tooltip("Modifies the influence of direct lighting on ambient occlusion.")]
	public FloatParameter directLightingStrength; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000029")]
	[Tooltip("The radius of sample points. This affects the size of darkened areas.")]
	public FloatParameter radius; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400002A")]
	[Tooltip("The number of sample points. This affects both quality and performance. For \"Lowest\", \"Low\", and \"Medium\", passes are downsampled. For \"High\" and \"Ultra\", they are not and therefore you should only \"High\" and \"Ultra\" on high-end hardware.")]
	public AmbientOcclusionQualityParameter quality; //Field offset: 0x88

	[Address(RVA = "0x18293F0", Offset = "0x18285F0", Length = "0x36A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ParameterOverride`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ColorParameter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BoolParameter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600000D")]
	public AmbientOcclusion() { }

	[Address(RVA = "0x1829080", Offset = "0x1828280", Length = "0x366")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Shader), Member = "get_isSupported", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_isOpenGLES", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_isWebNonWebGPU", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SystemInfo), Member = "IsFormatSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat), typeof(GraphicsFormatUsage)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_scriptableRenderPipelineActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600000C")]
	public virtual bool IsEnabledAndSupported(PostProcessRenderContext context) { }

}

