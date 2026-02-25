namespace UnityEngine.Rendering.PostProcessing;

[PostProcess(typeof(ScreenSpaceReflectionsRenderer), "Unity/Screen-space reflections", True)]
[Token(Token = "0x200003B")]
public sealed class ScreenSpaceReflections : PostProcessEffectSettings
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000FE")]
	[Tooltip("Choose a quality preset, or use \"Custom\" to create your own custom preset. Don't use a preset higher than \"Medium\" if you desire good performance on consoles.")]
	public ScreenSpaceReflectionPresetParameter preset; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Range(0, 256)]
	[Token(Token = "0x40000FF")]
	[Tooltip("Maximum number of steps in the raymarching pass. Higher values mean more reflections.")]
	public IntParameter maximumIterationCount; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000100")]
	[Tooltip("Changes the size of the SSR buffer. Downsample it to maximize performances or supersample it for higher quality results with reduced performance.")]
	public ScreenSpaceReflectionResolutionParameter resolution; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Range(1, 64)]
	[Token(Token = "0x4000101")]
	[Tooltip("Ray thickness. Lower values are more expensive but allow the effect to detect smaller details.")]
	public FloatParameter thickness; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000102")]
	[Tooltip("Maximum distance to traverse after which it will stop drawing reflections.")]
	public FloatParameter maximumMarchDistance; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Range(0, 1)]
	[Token(Token = "0x4000103")]
	[Tooltip("Fades reflections close to the near planes.")]
	public FloatParameter distanceFade; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Range(0, 1)]
	[Token(Token = "0x4000104")]
	[Tooltip("Fades reflections close to the screen edges.")]
	public FloatParameter vignette; //Field offset: 0x60

	[Address(RVA = "0x183BE50", Offset = "0x183B050", Length = "0x22F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ParameterOverride`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(IntParameter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000081")]
	public ScreenSpaceReflections() { }

	[Address(RVA = "0x183BCE0", Offset = "0x183AEE0", Length = "0x160")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Camera), Member = "get_actualRenderingPath", ReturnType = typeof(RenderingPath))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Shader), Member = "get_isSupported", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000080")]
	public virtual bool IsEnabledAndSupported(PostProcessRenderContext context) { }

}

