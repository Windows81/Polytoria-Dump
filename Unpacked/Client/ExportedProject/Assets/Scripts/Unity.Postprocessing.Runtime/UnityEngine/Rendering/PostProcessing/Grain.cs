namespace UnityEngine.Rendering.PostProcessing;

[PostProcess(typeof(GrainRenderer), "Unity/Grain", True)]
[Token(Token = "0x200002B")]
public sealed class Grain : PostProcessEffectSettings
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40000B1")]
	[Tooltip("Enable the use of colored grain.")]
	public BoolParameter colored; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Range(0, 1)]
	[Token(Token = "0x40000B2")]
	[Tooltip("Grain strength. Higher values mean more visible grain.")]
	public FloatParameter intensity; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Range(0.3, 3)]
	[Token(Token = "0x40000B3")]
	[Tooltip("Grain particle size.")]
	public FloatParameter size; //Field offset: 0x40
	[DisplayName("Luminance Contribution")]
	[FieldOffset(Offset = "0x48")]
	[Range(0, 1)]
	[Token(Token = "0x40000B4")]
	[Tooltip("Controls the noise response curve based on scene luminance. Lower values mean less noise in dark areas.")]
	public FloatParameter lumContrib; //Field offset: 0x48

	[Address(RVA = "0x18332C0", Offset = "0x18324C0", Length = "0x127")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(BoolParameter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000050")]
	public Grain() { }

	[Address(RVA = "0x182C0C0", Offset = "0x182B2C0", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600004F")]
	public virtual bool IsEnabledAndSupported(PostProcessRenderContext context) { }

}

