namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000054")]
public sealed class ColorParameter : ParameterOverride<Color>
{

	[Address(RVA = "0x183E4D0", Offset = "0x183D6D0", Length = "0x39")]
	[CalledBy(Type = typeof(AmbientOcclusion), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Bloom), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ColorGrading), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Vignette), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ParameterOverride`1), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x60000D3")]
	public ColorParameter() { }

	[Address(RVA = "0x183E460", Offset = "0x183D660", Length = "0x62")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000D1")]
	public virtual void Interp(Color from, Color to, float t) { }

	[Address(RVA = "0x183E510", Offset = "0x183D710", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000D2")]
	public static Vector4 op_Implicit(ColorParameter prop) { }

}

