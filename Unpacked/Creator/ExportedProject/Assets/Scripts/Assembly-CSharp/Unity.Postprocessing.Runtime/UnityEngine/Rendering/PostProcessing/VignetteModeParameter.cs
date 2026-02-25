namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000045")]
public sealed class VignetteModeParameter : ParameterOverride<VignetteMode>
{

	[Address(RVA = "0x183DC70", Offset = "0x183CE70", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ParameterOverride`1), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x600009B")]
	public VignetteModeParameter() { }

}

