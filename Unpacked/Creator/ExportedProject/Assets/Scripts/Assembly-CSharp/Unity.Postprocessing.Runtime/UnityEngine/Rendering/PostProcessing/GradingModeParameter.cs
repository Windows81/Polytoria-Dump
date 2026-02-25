namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x200001E")]
public sealed class GradingModeParameter : ParameterOverride<GradingMode>
{

	[Address(RVA = "0x1832A40", Offset = "0x1831C40", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ParameterOverride`1), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x600002D")]
	public GradingModeParameter() { }

}

