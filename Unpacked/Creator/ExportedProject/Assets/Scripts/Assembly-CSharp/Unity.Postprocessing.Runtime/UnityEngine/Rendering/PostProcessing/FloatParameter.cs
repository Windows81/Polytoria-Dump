namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000051")]
public sealed class FloatParameter : ParameterOverride<Single>
{

	[Address(RVA = "0x183EB10", Offset = "0x183DD10", Length = "0x39")]
	[CalledBy(Type = typeof(AmbientOcclusion), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AutoExposure), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Bloom), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ChromaticAberration), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColorGrading), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DepthOfField), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Grain), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LensDistortion), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MotionBlur), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScreenSpaceReflections), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Vignette), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 65)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ParameterOverride`1), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x60000CD")]
	public FloatParameter() { }

	[Address(RVA = "0x183EAF0", Offset = "0x183DCF0", Length = "0x12")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60000CC")]
	public virtual void Interp(float from, float to, float t) { }

}

