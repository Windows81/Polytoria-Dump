namespace UnityEngine.Rendering.PostProcessing;

[PostProcess(typeof(AutoExposureRenderer), "Unity/Auto Exposure", True)]
[Token(Token = "0x2000014")]
public sealed class AutoExposure : PostProcessEffectSettings
{
	[DisplayName("Filtering (%)")]
	[FieldOffset(Offset = "0x30")]
	[MinMax(1, 99)]
	[Token(Token = "0x400002F")]
	[Tooltip("Filters the bright and dark parts of the histogram when computing the average luminance. This is to avoid very dark pixels and very bright pixels from contributing to the auto exposure. Unit is in percent.")]
	public Vector2Parameter filtering; //Field offset: 0x30
	[DisplayName("Minimum (EV)")]
	[FieldOffset(Offset = "0x38")]
	[Range(-9, 9)]
	[Token(Token = "0x4000030")]
	[Tooltip("Minimum average luminance to consider for auto exposure. Unit is EV.")]
	public FloatParameter minLuminance; //Field offset: 0x38
	[DisplayName("Maximum (EV)")]
	[FieldOffset(Offset = "0x40")]
	[Range(-9, 9)]
	[Token(Token = "0x4000031")]
	[Tooltip("Maximum average luminance to consider for auto exposure. Unit is EV.")]
	public FloatParameter maxLuminance; //Field offset: 0x40
	[DisplayName("Exposure Compensation")]
	[FieldOffset(Offset = "0x48")]
	[Min(0)]
	[Token(Token = "0x4000032")]
	[Tooltip("Use this to scale the global exposure of the scene.")]
	public FloatParameter keyValue; //Field offset: 0x48
	[DisplayName("Type")]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000033")]
	[Tooltip("Use \"Progressive\" if you want auto exposure to be animated. Use \"Fixed\" otherwise.")]
	public EyeAdaptationParameter eyeAdaptation; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Min(0)]
	[Token(Token = "0x4000034")]
	[Tooltip("Adaptation speed from a dark to a light environment.")]
	public FloatParameter speedUp; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Min(0)]
	[Token(Token = "0x4000035")]
	[Tooltip("Adaptation speed from a light to a dark environment.")]
	public FloatParameter speedDown; //Field offset: 0x60

	[Address(RVA = "0x182A610", Offset = "0x1829810", Length = "0x209")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Vector2Parameter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ParameterOverride`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600001E")]
	public AutoExposure() { }

	[Address(RVA = "0x182A4A0", Offset = "0x18296A0", Length = "0x16E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_isOpenGLES", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeUtilities), Member = "get_isWebNonWebGPU", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextureFormatUtilities), Member = "IsSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600001D")]
	public virtual bool IsEnabledAndSupported(PostProcessRenderContext context) { }

}

