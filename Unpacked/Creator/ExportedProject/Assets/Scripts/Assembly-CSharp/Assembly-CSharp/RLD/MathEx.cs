namespace RLD;

[Token(Token = "0x2000165")]
public static class MathEx
{

	[Address(RVA = "0x5430A0", Offset = "0x5422A0", Length = "0x12")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001004")]
	public static bool AlmostEqual(float v1, float v2, float epsilon) { }

	[Address(RVA = "0x5430C0", Offset = "0x5422C0", Length = "0xB7")]
	[CalledBy(Type = typeof(RTSceneGrid), Member = "Render_SystemCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028F2B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802897E0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001005")]
	public static int GetNumDigits(int number) { }

	[Address(RVA = "0x543180", Offset = "0x542380", Length = "0x1F")]
	[CalledBy(Type = typeof(QuaternionEx), Member = "FromToRotation3D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[CalledBy(Type = typeof(QuaternionEx), Member = "FromToRotation2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(Quaternion))]
	[CalledBy(Type = typeof(Vector3Ex), Member = "SignedAngle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(PrimitiveFactory), Member = "GenerateSphereBorderPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3), typeof(float), typeof(int)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028E3A0")]
	[Token(Token = "0x6001006")]
	public static float SafeAcos(float cosine) { }

	[Address(RVA = "0x5431A0", Offset = "0x5423A0", Length = "0xEC")]
	[CalledBy(Type = typeof(ConeMath), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(float), typeof(float), typeof(Quaternion), typeof(ConeEpsilon)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CylinderMath), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(Vector3), typeof(float), typeof(float), typeof(CylinderEpsilon)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CylinderMath), Member = "RaycastNoCaps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(Vector3), typeof(float), typeof(float), typeof(CylinderEpsilon)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SphereMath), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(float), typeof(SphereEpsilon)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SphereMath), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Single&), typeof(Vector3), typeof(float), typeof(SphereEpsilon)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AF70")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001007")]
	public static bool SolveQuadratic(float a, float b, float c, out float t1, out float t2) { }

}

