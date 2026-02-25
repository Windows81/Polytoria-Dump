namespace RLD;

[Token(Token = "0x2000180")]
public static class AxisHelper
{

	[Address(RVA = "0x5571A0", Offset = "0x5563A0", Length = "0xDC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60010F8")]
	public static Vector3 GetWorldAxis(Axis axis) { }

	[Address(RVA = "0x557280", Offset = "0x556480", Length = "0x1CA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x60010F9")]
	public static Vector3 GetWorldAxis(Axis axis, AxisSign axisSign) { }

}

