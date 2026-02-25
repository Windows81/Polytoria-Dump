namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000057")]
public sealed class Vector4Parameter : ParameterOverride<Vector4>
{

	[Address(RVA = "0x1856610", Offset = "0x1855810", Length = "0x39")]
	[CalledBy(Type = typeof(ColorGrading), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ParameterOverride`1), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x60000DF")]
	public Vector4Parameter() { }

	[Address(RVA = "0x183E460", Offset = "0x183D660", Length = "0x62")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000DC")]
	public virtual void Interp(Vector4 from, Vector4 to, float t) { }

	[Address(RVA = "0x1856650", Offset = "0x1855850", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000DD")]
	public static Vector2 op_Implicit(Vector4Parameter prop) { }

	[Address(RVA = "0x1856680", Offset = "0x1855880", Length = "0x34")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000DE")]
	public static Vector3 op_Implicit(Vector4Parameter prop) { }

}

