namespace UnityEngine.Rendering.PostProcessing;

[PostProcess(typeof(LensDistortionRenderer), "Unity/Lens Distortion", True)]
[Token(Token = "0x200002D")]
public sealed class LensDistortion : PostProcessEffectSettings
{
	[FieldOffset(Offset = "0x30")]
	[Range(-100, 100)]
	[Token(Token = "0x40000B8")]
	[Tooltip("Total distortion amount.")]
	public FloatParameter intensity; //Field offset: 0x30
	[DisplayName("X Multiplier")]
	[FieldOffset(Offset = "0x38")]
	[Range(0, 1)]
	[Token(Token = "0x40000B9")]
	[Tooltip("Intensity multiplier on the x-axis. Set it to 0 to disable distortion on this axis.")]
	public FloatParameter intensityX; //Field offset: 0x38
	[DisplayName("Y Multiplier")]
	[FieldOffset(Offset = "0x40")]
	[Range(0, 1)]
	[Token(Token = "0x40000BA")]
	[Tooltip("Intensity multiplier on the y-axis. Set it to 0 to disable distortion on this axis.")]
	public FloatParameter intensityY; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Range(-1, 1)]
	[Space]
	[Token(Token = "0x40000BB")]
	[Tooltip("Distortion center point (x-axis).")]
	public FloatParameter centerX; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Range(-1, 1)]
	[Token(Token = "0x40000BC")]
	[Tooltip("Distortion center point (y-axis).")]
	public FloatParameter centerY; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Range(0.01, 5)]
	[Space]
	[Token(Token = "0x40000BD")]
	[Tooltip("Global screen scaling.")]
	public FloatParameter scale; //Field offset: 0x58

	[Address(RVA = "0x1833890", Offset = "0x1832A90", Length = "0x190")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000056")]
	public LensDistortion() { }

	[Address(RVA = "0x1833770", Offset = "0x1832970", Length = "0x11A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000055")]
	public virtual bool IsEnabledAndSupported(PostProcessRenderContext context) { }

}

