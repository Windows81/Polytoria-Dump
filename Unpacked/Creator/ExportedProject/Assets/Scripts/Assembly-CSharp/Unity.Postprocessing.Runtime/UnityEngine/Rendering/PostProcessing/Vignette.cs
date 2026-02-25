namespace UnityEngine.Rendering.PostProcessing;

[PostProcess(typeof(VignetteRenderer), "Unity/Vignette", True)]
[Token(Token = "0x2000046")]
public sealed class Vignette : PostProcessEffectSettings
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400012E")]
	[Tooltip("Use the \"Classic\" mode for parametric controls. Use the \"Masked\" mode to use your own texture mask.")]
	public VignetteModeParameter mode; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400012F")]
	[Tooltip("Vignette color.")]
	public ColorParameter color; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000130")]
	[Tooltip("Sets the vignette center point (screen center is [0.5, 0.5]).")]
	public Vector2Parameter center; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Range(0, 1)]
	[Token(Token = "0x4000131")]
	[Tooltip("Amount of vignetting on screen.")]
	public FloatParameter intensity; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Range(0.01, 1)]
	[Token(Token = "0x4000132")]
	[Tooltip("Smoothness of the vignette borders.")]
	public FloatParameter smoothness; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Range(0, 1)]
	[Token(Token = "0x4000133")]
	[Tooltip("Lower values will make a square-ish vignette.")]
	public FloatParameter roundness; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000134")]
	[Tooltip("Set to true to mark the vignette to be perfectly round. False will make its shape dependent on the current aspect ratio.")]
	public BoolParameter rounded; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000135")]
	[Tooltip("A black and white mask to use as a vignette.")]
	public TextureParameter mask; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Range(0, 1)]
	[Token(Token = "0x4000136")]
	[Tooltip("Mask opacity.")]
	public FloatParameter opacity; //Field offset: 0x70

	[Address(RVA = "0x183E170", Offset = "0x183D370", Length = "0x2AD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ParameterOverride`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ColorParameter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Vector2Parameter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BoolParameter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextureParameter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600009D")]
	public Vignette() { }

	[Address(RVA = "0x183E0A0", Offset = "0x183D2A0", Length = "0xC1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600009C")]
	public virtual bool IsEnabledAndSupported(PostProcessRenderContext context) { }

}

