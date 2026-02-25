namespace RLD;

[Token(Token = "0x20001B9")]
public static class TorusMath
{

	[Address(RVA = "0x587EF0", Offset = "0x5870F0", Length = "0x46A")]
	[CalledBy(Type = typeof(CylTorusShape3D), Member = "GetHrzExtents", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>))]
	[CalledBy(Type = typeof(TorusShape3D), Member = "GetHrzExtents", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60011EE")]
	public static List<Vector3> Calc3DHrzExtentPoints(Vector3 torusCenter, float torusCoreRadius, float torusTubeRadius, Quaternion torusRotation) { }

	[Address(RVA = "0x588360", Offset = "0x587560", Length = "0x1A4")]
	[CalledBy(Type = typeof(CylTorusShape3D), Member = "GetAABB", ReturnType = typeof(AABB))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AABB), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Matrix4x4), Member = "TRS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(AABB), Member = "Transform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Token(Token = "0x60011ED")]
	public static AABB CalcCylAABB(Vector3 torusCenter, float torusCoreRadius, float torusHrzRadius, float torusVertRadius, Quaternion torusRotation) { }

	[Address(RVA = "0x588510", Offset = "0x587710", Length = "0xA9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AABB), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[Token(Token = "0x60011EC")]
	public static AABB CalcCylModelAABB(float torusCoreRadius, float torusHrzRadius, float torusVertRadius) { }

	[Address(RVA = "0x5885C0", Offset = "0x5877C0", Length = "0x5")]
	[CalledBy(Type = typeof(TorusShape3D), Member = "GetAABB", ReturnType = typeof(AABB))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x60011EB")]
	public static float CalcSphereRadius(float torusCoreRadius, float torusTubeRadius) { }

	[Address(RVA = "0x588A60", Offset = "0x587C60", Length = "0x467")]
	[CalledBy(Type = typeof(TorusShape3D), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CylinderMath), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(Vector3), typeof(float), typeof(CylinderEpsilon)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Ray), Member = "GetPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(PlaneEx), Member = "ProjectPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Plane), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC4C0")]
	[Calls(Type = typeof(RayEx), Member = "Mirror", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Vector3)}, ReturnType = typeof(Ray))]
	[Calls(Type = typeof(CylinderMath), Member = "RaycastNoCaps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(Vector3), typeof(float), typeof(CylinderEpsilon)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60011EF")]
	public static bool Raycast(Ray ray, out float t, Vector3 torusCenter, float torusCoreRadius, float torusTubeRadius, Quaternion torusRotation, TorusEpsilon epsilon = null) { }

	[Address(RVA = "0x5885D0", Offset = "0x5877D0", Length = "0x481")]
	[CalledBy(Type = typeof(CylTorusShape3D), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CylinderMath), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(Vector3), typeof(float), typeof(CylinderEpsilon)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Ray), Member = "GetPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(PlaneEx), Member = "ProjectPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Plane), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC4C0")]
	[Calls(Type = typeof(RayEx), Member = "Mirror", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Vector3)}, ReturnType = typeof(Ray))]
	[Calls(Type = typeof(CylinderMath), Member = "RaycastNoCaps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(Vector3), typeof(float), typeof(CylinderEpsilon)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60011F0")]
	public static bool RaycastCylindrical(Ray ray, out float t, Vector3 torusCenter, float torusCoreRadius, float torusHrzRadius, float torusVertRadius, Quaternion torusRotation, TorusEpsilon epsilon = null) { }

}

