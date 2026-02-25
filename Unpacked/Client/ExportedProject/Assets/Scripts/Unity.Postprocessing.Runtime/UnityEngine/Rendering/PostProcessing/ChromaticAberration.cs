namespace UnityEngine.Rendering.PostProcessing;

[PostProcess(typeof(ChromaticAberrationRenderer), "Unity/Chromatic Aberration", True)]
[Token(Token = "0x200001A")]
public sealed class ChromaticAberration : PostProcessEffectSettings
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000053")]
	[Tooltip("Shifts the hue of chromatic aberrations.")]
	public TextureParameter spectralLut; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Range(0, 1)]
	[Token(Token = "0x4000054")]
	[Tooltip("Amount of tangential distortion.")]
	public FloatParameter intensity; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[FormerlySerializedAs("mobileOptimized")]
	[Token(Token = "0x4000055")]
	[Tooltip("Boost performances by lowering the effect quality. This settings is meant to be used on mobile and other low-end platforms but can also provide a nice performance boost on desktops and consoles.")]
	public BoolParameter fastMode; //Field offset: 0x40

	[Address(RVA = "0x182C100", Offset = "0x182B300", Length = "0x106")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(TextureParameter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BoolParameter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000029")]
	public ChromaticAberration() { }

	[Address(RVA = "0x182C0C0", Offset = "0x182B2C0", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000028")]
	public virtual bool IsEnabledAndSupported(PostProcessRenderContext context) { }

}

