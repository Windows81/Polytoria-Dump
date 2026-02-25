namespace RLD;

[Token(Token = "0x200019A")]
public static class CylinderMath
{

	[Address(RVA = "0x55DF30", Offset = "0x55D130", Length = "0x46E")]
	[CalledBy(Type = typeof(CylinderShape3D), Member = "RenderWire", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CylinderShape3D), Member = "GetBottomCapExtentPoints", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>))]
	[CalledBy(Type = typeof(CylinderShape3D), Member = "GetTopCapExtentPoints", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600116D")]
	public static List<Vector3> CalcExtentPoints(Vector3 center, float cylinderRadius, Quaternion cylinderRotation) { }

	[Address(RVA = "0x55E3A0", Offset = "0x55D5A0", Length = "0xF7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC4C0")]
	[Calls(Type = typeof(CylinderMath), Member = "ContainsPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(float), typeof(float), typeof(CylinderEpsilon)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001172")]
	public static bool ContainsPoint(Vector3 point, Vector3 cylinderAxisPt0, Vector3 cylinderAxisPt1, float cylinderRadius, CylinderEpsilon epsilon = null) { }

	[Address(RVA = "0x55E4A0", Offset = "0x55D6A0", Length = "0x1A5")]
	[CalledBy(Type = typeof(CylinderMath), Member = "ContainsPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(float), typeof(CylinderEpsilon)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CylinderShape3D), Member = "ContainsPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC4C0")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001173")]
	public static bool ContainsPoint(Vector3 point, Vector3 cylinderAxisPt0, Vector3 cylinderAxisPt1, float cylinderRadius, float cylinderHeight, CylinderEpsilon epsilon = null) { }

	[Address(RVA = "0x55EB50", Offset = "0x55DD50", Length = "0x109")]
	[CalledBy(Type = typeof(SegmentMath), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(Vector3), typeof(SegmentEpsilon)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TorusMath), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(float), typeof(float), typeof(Quaternion), typeof(TorusEpsilon)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TorusMath), Member = "RaycastCylindrical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(Quaternion), typeof(TorusEpsilon)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC4C0")]
	[Calls(Type = typeof(CylinderMath), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(Vector3), typeof(float), typeof(float), typeof(CylinderEpsilon)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600116E")]
	public static bool Raycast(Ray ray, out float t, Vector3 cylinderAxisPt0, Vector3 cylinderAxisPt1, float cylinderRadius, CylinderEpsilon epsilon = null) { }

	[Address(RVA = "0x55EC60", Offset = "0x55DE60", Length = "0x821")]
	[CalledBy(Type = typeof(CircleMath), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(float), typeof(Vector3), typeof(CircleEpsilon)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CircleMath), Member = "RaycastWire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(float), typeof(Vector3), typeof(CircleEpsilon)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CylinderMath), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(Vector3), typeof(float), typeof(CylinderEpsilon)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CylinderShape3D), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Ray), Member = "GetPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(MathEx), Member = "SolveQuadratic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(Single&), typeof(Single&)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600116F")]
	public static bool Raycast(Ray ray, out float t, Vector3 cylinderAxisPt0, Vector3 cylinderAxisPt1, float cylinderRadius, float cylinderHeight, CylinderEpsilon epsilon = null) { }

	[Address(RVA = "0x55E650", Offset = "0x55D850", Length = "0x109")]
	[CalledBy(Type = typeof(TorusMath), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(float), typeof(float), typeof(Quaternion), typeof(TorusEpsilon)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TorusMath), Member = "RaycastCylindrical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(Quaternion), typeof(TorusEpsilon)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC4C0")]
	[Calls(Type = typeof(CylinderMath), Member = "RaycastNoCaps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(Vector3), typeof(float), typeof(float), typeof(CylinderEpsilon)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001170")]
	public static bool RaycastNoCaps(Ray ray, out float t, Vector3 cylinderAxisPt0, Vector3 cylinderAxisPt1, float cylinderRadius, CylinderEpsilon epsilon = null) { }

	[Address(RVA = "0x55E760", Offset = "0x55D960", Length = "0x3E3")]
	[CalledBy(Type = typeof(CylinderMath), Member = "RaycastNoCaps", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(Vector3), typeof(float), typeof(CylinderEpsilon)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(MathEx), Member = "SolveQuadratic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(Single&), typeof(Single&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001171")]
	public static bool RaycastNoCaps(Ray ray, out float t, Vector3 cylinderAxisPt0, Vector3 cylinderAxisPt1, float cylinderRadius, float cylinderHeight, CylinderEpsilon epsilon = null) { }

}

