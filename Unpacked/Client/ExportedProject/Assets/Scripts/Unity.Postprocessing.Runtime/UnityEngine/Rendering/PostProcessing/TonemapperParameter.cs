namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x200001F")]
public sealed class TonemapperParameter : ParameterOverride<Tonemapper>
{

	[Address(RVA = "0x183DB50", Offset = "0x183CD50", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ParameterOverride`1), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x600002E")]
	public TonemapperParameter() { }

}

