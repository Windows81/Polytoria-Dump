namespace UnityEngine.Rendering.PostProcessing;

[PostProcess(typeof(MotionBlurRenderer), "Unity/Motion Blur", False)]
[Token(Token = "0x200002F")]
public sealed class MotionBlur : PostProcessEffectSettings
{
	[FieldOffset(Offset = "0x30")]
	[Range(0, 360)]
	[Token(Token = "0x40000BE")]
	[Tooltip("The angle of rotary shutter. Larger values give longer exposure.")]
	public FloatParameter shutterAngle; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Range(4, 32)]
	[Token(Token = "0x40000BF")]
	[Tooltip("The amount of sample points. This affects quality and performance.")]
	public IntParameter sampleCount; //Field offset: 0x38

	[Address(RVA = "0x18347E0", Offset = "0x18339E0", Length = "0xB8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(IntParameter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600005A")]
	public MotionBlur() { }

	[Address(RVA = "0x1834730", Offset = "0x1833930", Length = "0xAD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TextureFormatUtilities), Member = "IsSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000059")]
	public virtual bool IsEnabledAndSupported(PostProcessRenderContext context) { }

}

