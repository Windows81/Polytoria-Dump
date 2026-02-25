namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000056")]
public sealed class Vector3Parameter : ParameterOverride<Vector3>
{

	[Address(RVA = "0x1856540", Offset = "0x1855740", Length = "0x39")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.Rendering.PostProcessing.ParameterOverride`1<UnityEngine.Vector3>), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x60000DB")]
	public Vector3Parameter() { }

	[Address(RVA = "0x18564F0", Offset = "0x18556F0", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60000D8")]
	public virtual void Interp(Vector3 from, Vector3 to, float t) { }

	[Address(RVA = "0x18565E0", Offset = "0x18557E0", Length = "0x27")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000D9")]
	public static Vector2 op_Implicit(Vector3Parameter prop) { }

	[Address(RVA = "0x1856580", Offset = "0x1855780", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000DA")]
	public static Vector4 op_Implicit(Vector3Parameter prop) { }

}

