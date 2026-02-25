namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x200000E")]
public sealed class AmbientOcclusionQualityParameter : ParameterOverride<AmbientOcclusionQuality>
{

	[Address(RVA = "0x1828950", Offset = "0x1827B50", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ParameterOverride`1), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x600000B")]
	public AmbientOcclusionQualityParameter() { }

}

