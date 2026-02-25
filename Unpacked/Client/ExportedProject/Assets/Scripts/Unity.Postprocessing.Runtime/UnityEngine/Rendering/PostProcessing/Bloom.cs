namespace UnityEngine.Rendering.PostProcessing;

[PostProcess(typeof(BloomRenderer), "Unity/Bloom", True)]
[Token(Token = "0x2000016")]
public sealed class Bloom : PostProcessEffectSettings
{
	[FieldOffset(Offset = "0x30")]
	[Min(0)]
	[Token(Token = "0x400003B")]
	[Tooltip("Strength of the bloom filter. Values higher than 1 will make bloom contribute more energy to the final render.")]
	public FloatParameter intensity; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Min(0)]
	[Token(Token = "0x400003C")]
	[Tooltip("Filters out pixels under this level of brightness. Value is in gamma-space.")]
	public FloatParameter threshold; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Range(0, 1)]
	[Token(Token = "0x400003D")]
	[Tooltip("Makes transitions between under/over-threshold gradual. 0 for a hard threshold, 1 for a soft threshold).")]
	public FloatParameter softKnee; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400003E")]
	[Tooltip("Clamps pixels to control the bloom amount. Value is in gamma-space.")]
	public FloatParameter clamp; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Range(1, 10)]
	[Token(Token = "0x400003F")]
	[Tooltip("Changes the extent of veiling effects. For maximum quality, use integer values. Because this value changes the internal iteration count, You should not animating it as it may introduce issues with the perceived radius.")]
	public FloatParameter diffusion; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Range(-1, 1)]
	[Token(Token = "0x4000040")]
	[Tooltip("Distorts the bloom to give an anamorphic look. Negative values distort vertically, positive values distort horizontally.")]
	public FloatParameter anamorphicRatio; //Field offset: 0x58
	[ColorUsage(False, True)]
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000041")]
	[Tooltip("Global tint of the bloom filter.")]
	public ColorParameter color; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[FormerlySerializedAs("mobileOptimized")]
	[Token(Token = "0x4000042")]
	[Tooltip("Boost performance by lowering the effect quality. This settings is meant to be used on mobile and other low-end platforms but can also provide a nice performance boost on desktops and consoles.")]
	public BoolParameter fastMode; //Field offset: 0x68
	[DisplayName("Texture")]
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000043")]
	[Tooltip("The lens dirt texture used to add smudges or dust to the bloom effect.")]
	public TextureParameter dirtTexture; //Field offset: 0x70
	[DisplayName("Intensity")]
	[FieldOffset(Offset = "0x78")]
	[Min(0)]
	[Token(Token = "0x4000044")]
	[Tooltip("The intensity of the lens dirtiness.")]
	public FloatParameter dirtIntensity; //Field offset: 0x78

	[Address(RVA = "0x182BA20", Offset = "0x182AC20", Length = "0x2A2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(FloatParameter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ColorParameter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(BoolParameter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(TextureParameter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000024")]
	public Bloom() { }

	[Address(RVA = "0x182B9E0", Offset = "0x182ABE0", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000023")]
	public virtual bool IsEnabledAndSupported(PostProcessRenderContext context) { }

}

