namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000024")]
public sealed class KernelSizeParameter : ParameterOverride<KernelSize>
{

	[Address(RVA = "0x18333F0", Offset = "0x18325F0", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ParameterOverride`1), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x600003E")]
	public KernelSizeParameter() { }

}

