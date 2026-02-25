namespace RLD;

[Token(Token = "0x2000198")]
public static class ConeMath
{

	[Address(RVA = "0x55D020", Offset = "0x55C220", Length = "0x46E")]
	[CalledBy(Type = typeof(ConeShape3D), Member = "RenderWire", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConeShape3D), Member = "GetBaseExtents", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>))]
	[CalledBy(Type = typeof(ConeShape3D), Member = "GetAABB", ReturnType = typeof(AABB))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600116A")]
	public static List<Vector3> CalcConeBaseExtentPoints(Vector3 coneBaseCenter, float coneBaseRadius, Quaternion coneRotation) { }

	[Address(RVA = "0x55D490", Offset = "0x55C690", Length = "0x301")]
	[CalledBy(Type = typeof(ConeShape3D), Member = "ContainsPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Matrix4x4), Member = "TRS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "get_inverse", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Vector3Ex), Member = "GetDistanceToSegment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(float))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600116C")]
	public static bool ContainsPoint(Vector3 point, Vector3 coneBaseCenter, float coneBaseRadius, float coneHeight, Quaternion coneRotation, ConeEpsilon epsilon = null) { }

	[Address(RVA = "0x55D7A0", Offset = "0x55C9A0", Length = "0x78F")]
	[CalledBy(Type = typeof(ConeShape3D), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Matrix4x4), Member = "TRS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "get_inverse", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BoxMath), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(Vector3), typeof(Quaternion), typeof(BoxEpsilon)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC4C0")]
	[Calls(Type = typeof(MathEx), Member = "SolveQuadratic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(Single&), typeof(Single&)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600116B")]
	public static bool Raycast(Ray ray, out float t, Vector3 coneBaseCenter, float coneBaseRadius, float coneHeight, Quaternion coneRotation, ConeEpsilon epsilon = null) { }

}

