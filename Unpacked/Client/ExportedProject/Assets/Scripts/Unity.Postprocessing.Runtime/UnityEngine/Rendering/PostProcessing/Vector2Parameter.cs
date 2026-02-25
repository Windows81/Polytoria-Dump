namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000055")]
public sealed class Vector2Parameter : ParameterOverride<Vector2>
{

	[Address(RVA = "0x1856430", Offset = "0x1855630", Length = "0x39")]
	[CalledBy(Type = typeof(AutoExposure), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Vignette), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.Rendering.PostProcessing.ParameterOverride`1<UnityEngine.Vector2>), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x60000D7")]
	public Vector2Parameter() { }

	[Address(RVA = "0x18563E0", Offset = "0x18555E0", Length = "0x46")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60000D4")]
	public virtual void Interp(Vector2 from, Vector2 to, float t) { }

	[Address(RVA = "0x1856470", Offset = "0x1855670", Length = "0x2F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000D5")]
	public static Vector3 op_Implicit(Vector2Parameter prop) { }

	[Address(RVA = "0x18564A0", Offset = "0x18556A0", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000D6")]
	public static Vector4 op_Implicit(Vector2Parameter prop) { }

}

