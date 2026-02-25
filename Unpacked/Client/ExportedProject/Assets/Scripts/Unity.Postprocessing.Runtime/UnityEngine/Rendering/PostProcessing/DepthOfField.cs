namespace UnityEngine.Rendering.PostProcessing;

[PostProcess(typeof(DepthOfFieldRenderer), "Unity/Depth of Field", False)]
[Token(Token = "0x2000025")]
public sealed class DepthOfField : PostProcessEffectSettings
{
	[FieldOffset(Offset = "0x30")]
	[Min(0.1)]
	[Token(Token = "0x4000097")]
	[Tooltip("Distance to the point of focus.")]
	public FloatParameter focusDistance; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Range(0.05, 32)]
	[Token(Token = "0x4000098")]
	[Tooltip("Ratio of aperture (known as f-stop or f-number). The smaller the value is, the shallower the depth of field is.")]
	public FloatParameter aperture; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Range(1, 300)]
	[Token(Token = "0x4000099")]
	[Tooltip("Distance between the lens and the film. The larger the value is, the shallower the depth of field is.")]
	public FloatParameter focalLength; //Field offset: 0x40
	[DisplayName("Max Blur Size")]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400009A")]
	[Tooltip("Convolution kernel size of the bokeh filter, which determines the maximum radius of bokeh. It also affects performances (the larger the kernel is, the longer the GPU time is required).")]
	public KernelSizeParameter kernelSize; //Field offset: 0x48

	[Address(RVA = "0x1832120", Offset = "0x1831320", Length = "0x14F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ParameterOverride`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000040")]
	public DepthOfField() { }

	[Address(RVA = "0x18320E0", Offset = "0x18312E0", Length = "0x31")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600003F")]
	public virtual bool IsEnabledAndSupported(PostProcessRenderContext context) { }

}

