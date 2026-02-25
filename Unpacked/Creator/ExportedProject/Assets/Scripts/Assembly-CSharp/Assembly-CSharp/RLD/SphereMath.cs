namespace RLD;

[Token(Token = "0x20001B7")]
public static class SphereMath
{

	[Address(RVA = "0x586A60", Offset = "0x585C60", Length = "0x395")]
	[CalledBy(Type = typeof(Sphere), Member = "GetRightUpExtents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60011E6")]
	public static List<Vector3> CalcRightUpExtents(Vector3 sphereCenter, float sphereRadius, Vector3 right, Vector3 up) { }

	[Address(RVA = "0x586E00", Offset = "0x586000", Length = "0x56")]
	[CalledBy(Type = typeof(SphereTree`1), Member = "OverlapBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OBB), "System.Collections.Generic.List`1<SphereTreeNode`1<T>>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SphereShape3D), Member = "ContainsPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60011EA")]
	public static bool ContainsPoint(Vector3 point, Vector3 sphereCenter, float sphereRadius, SphereEpsilon epsilon = null) { }

	[Address(RVA = "0x586E60", Offset = "0x586060", Length = "0x58")]
	[CalledBy(Type = typeof(SphereTree`1), Member = "RaycastAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), "System.Collections.Generic.List`1<SphereTreeNodeRayHit`1<T>>"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SphereMath), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(float), typeof(SphereEpsilon)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60011E7")]
	public static bool Raycast(Ray ray, Vector3 sphereCenter, float sphereRadius, SphereEpsilon epsilon = null) { }

	[Address(RVA = "0x587020", Offset = "0x586220", Length = "0x16B")]
	[CalledBy(Type = typeof(SphereTree`1), Member = "RaycastAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), "System.Collections.Generic.List`1<SphereTreeNodeRayHit`1<T>>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SegmentMath), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(Vector3), typeof(SegmentEpsilon)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SphereMath), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Vector3), typeof(float), typeof(SphereEpsilon)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SphereShape3D), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(MathEx), Member = "SolveQuadratic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(Single&), typeof(Single&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60011E8")]
	public static bool Raycast(Ray ray, out float t, Vector3 sphereCenter, float sphereRadius, SphereEpsilon epsilon = null) { }

	[Address(RVA = "0x586EC0", Offset = "0x5860C0", Length = "0x15E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MathEx), Member = "SolveQuadratic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float), typeof(Single&), typeof(Single&)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60011E9")]
	public static bool Raycast(Ray ray, out float t0, out float t1, Vector3 sphereCenter, float sphereRadius, SphereEpsilon epsilon = null) { }

}

