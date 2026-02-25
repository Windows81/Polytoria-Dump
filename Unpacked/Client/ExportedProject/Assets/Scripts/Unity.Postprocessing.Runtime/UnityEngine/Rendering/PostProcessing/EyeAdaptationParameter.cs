namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000013")]
public sealed class EyeAdaptationParameter : ParameterOverride<EyeAdaptation>
{

	[Address(RVA = "0x1832530", Offset = "0x1831730", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ParameterOverride`1), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x600001C")]
	public EyeAdaptationParameter() { }

}

