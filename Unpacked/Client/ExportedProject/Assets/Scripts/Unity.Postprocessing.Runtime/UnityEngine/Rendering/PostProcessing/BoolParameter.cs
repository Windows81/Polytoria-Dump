namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000053")]
public sealed class BoolParameter : ParameterOverride<Boolean>
{

	[Address(RVA = "0x183E420", Offset = "0x183D620", Length = "0x39")]
	[CalledBy(Type = typeof(AmbientOcclusion), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Bloom), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ChromaticAberration), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Grain), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Vignette), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ParameterOverride`1), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x60000D0")]
	public BoolParameter() { }

}

