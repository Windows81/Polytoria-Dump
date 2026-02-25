namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000052")]
public sealed class IntParameter : ParameterOverride<Int32>
{

	[Address(RVA = "0x183FE40", Offset = "0x183F040", Length = "0x39")]
	[CalledBy(Type = typeof(MotionBlur), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ScreenSpaceReflections), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ParameterOverride`1), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x60000CF")]
	public IntParameter() { }

	[Address(RVA = "0x183FE10", Offset = "0x183F010", Length = "0x22")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000CE")]
	public virtual void Interp(int from, int to, float t) { }

}

