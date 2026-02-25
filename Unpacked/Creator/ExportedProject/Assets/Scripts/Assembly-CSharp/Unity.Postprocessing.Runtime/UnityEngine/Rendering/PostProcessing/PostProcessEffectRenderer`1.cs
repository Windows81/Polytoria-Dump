namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000062")]
public abstract class PostProcessEffectRenderer : PostProcessEffectRenderer
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400018E")]
	private T <settings>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x1700000A")]
	public internal T settings
	{
		[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
		[CallerCount(Count = 18)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000113")]
		 get { } //Length: 5
		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000114")]
		internal set { } //Length: 13
	}

	[Address(RVA = "0xE88AD0", Offset = "0xE87CD0", Length = "0x7")]
	[CalledBy(Type = typeof(AmbientOcclusionRenderer), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AutoExposureRenderer), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BloomRenderer), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ChromaticAberrationRenderer), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColorGradingRenderer), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DepthOfFieldRenderer), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GrainRenderer), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LensDistortionRenderer), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MotionBlurRenderer), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScreenSpaceReflectionsRenderer), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VignetteRenderer), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000116")]
	protected PostProcessEffectRenderer`1() { }

	[Address(RVA = "0x2D8320", Offset = "0x2D7520", Length = "0x5")]
	[CallerCount(Count = 18)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000113")]
	public T get_settings() { }

	[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000114")]
	internal void set_settings(T value) { }

	[Address(RVA = "0xE88A50", Offset = "0xE87C50", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000115")]
	internal virtual void SetSettings(PostProcessEffectSettings settings) { }

}

