namespace RLD;

[Token(Token = "0x20001BD")]
public static class TriangleMath
{
	[Token(Token = "0x4000717")]
	private static readonly float _eqTriangleAltFactor; //Field offset: 0x0

	[Token(Token = "0x170005B6")]
	public static float EqTriangleAltFactor
	{
		[Address(RVA = "0x58C9A0", Offset = "0x58BBA0", Length = "0x4F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x60011F1")]
		 get { } //Length: 79
	}

	[Address(RVA = "0x58C940", Offset = "0x58BB40", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AF70")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001200")]
	private static TriangleMath() { }

	[Address(RVA = "0x58A380", Offset = "0x589580", Length = "0x4AB")]
	[CalledBy(Type = typeof(TriangleMath), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(TriangleEpsilon)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TriangleMath), Member = "RaycastWire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(TriangleEpsilon)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Quaternion), Member = "LookRotation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(OBB), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AF70")]
	[Calls(Type = typeof(OBB), Member = "get_Right", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(OBB), Member = "get_Look", ReturnType = typeof(Vector3))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60011FB")]
	public static OBB Calc3DTriangleOBB(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 normal, TriangleEpsilon epsilon = null) { }

	[Address(RVA = "0x58A830", Offset = "0x589A30", Length = "0x358")]
	[CalledBy(Type = typeof(EqTriangle2D), Member = "OnPointsFoundDirty", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001F260")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60011F5")]
	public static List<Vector2> CalcEqTriangle2DPoints(Vector2 centroid, float sideLength, Quaternion rotation) { }

	[Address(RVA = "0x58AB90", Offset = "0x589D90", Length = "0x56A")]
	[CalledBy(Type = typeof(TriangleMesh), Member = "CreateEqXY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(Color)}, ReturnType = typeof(Mesh))]
	[CalledBy(Type = typeof(TriangleMesh), Member = "CreateWireEqXY", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(Color)}, ReturnType = typeof(Mesh))]
	[CalledBy(Type = typeof(EqTriangle3D), Member = "OnPointsFoundDirty", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60011F4")]
	public static List<Vector3> CalcEqTriangle3DPoints(Vector3 centroid, float sideLength, Quaternion rotation) { }

	[Address(RVA = "0x58B100", Offset = "0x58A300", Length = "0x266")]
	[CalledBy(Type = typeof(RightAngTriangle2D), Member = "GetPoints", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "AngleAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(Vector3)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001F260")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60011FA")]
	public static List<Vector2> CalcRATriangle2DPoints(Vector2 rightAngleCorner, float xLength, float yLength, float degreeTriRotation) { }

	[Address(RVA = "0x58B370", Offset = "0x58A570", Length = "0x33D")]
	[CalledBy(Type = typeof(RightAngTriangle3D), Member = "GetPoints", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60011F9")]
	public static List<Vector3> CalcRATriangle3DPoints(Vector3 rightAngleCorner, float xLength, float yLength, Quaternion triangleRotation) { }

	[Address(RVA = "0x58B6B0", Offset = "0x58A8B0", Length = "0x66")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AF70")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60011F8")]
	public static float CalcRATriangleAltitude(Vector2 sides) { }

	[Address(RVA = "0x58B760", Offset = "0x58A960", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AF70")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60011F6")]
	public static float CalcRATriangleHypotenuse(float side0, float side1) { }

	[Address(RVA = "0x58B720", Offset = "0x58A920", Length = "0x35")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AF70")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60011F7")]
	public static float CalcRATriangleHypotenuse(Vector2 sides) { }

	[Address(RVA = "0x58B780", Offset = "0x58A980", Length = "0x155")]
	[CalledBy(Type = typeof(ConeShape2D), Member = "ContainsPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(EqTriangle2D), Member = "ContainsPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RightAngTriangle2D), Member = "ContainsPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TriangleMath), Member = "Contains3DPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(bool), typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(TriangleEpsilon)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60011FF")]
	public static bool Contains2DPoint(Vector2 point, Vector2 p0, Vector2 p1, Vector2 p2, TriangleEpsilon epsilon = null) { }

	[Address(RVA = "0x58B8E0", Offset = "0x58AAE0", Length = "0x4A5")]
	[CalledBy(Type = typeof(PyramidMath), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(Quaternion)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TriangleMath), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(TriangleEpsilon)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TriangleMath), Member = "Contains2DPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(Vector2), typeof(Vector2), typeof(TriangleEpsilon)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RightAngTriangle3D), Member = "ContainsPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x60011FE")]
	public static bool Contains3DPoint(Vector3 point, bool checkOnPlane, Vector3 p0, Vector3 p1, Vector3 p2, TriangleEpsilon epsilon = null) { }

	[Address(RVA = "0x58C9A0", Offset = "0x58BBA0", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60011F1")]
	public static float get_EqTriangleAltFactor() { }

	[Address(RVA = "0x58BD90", Offset = "0x58AF90", Length = "0x5F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60011F2")]
	public static float GetEqTriangleAltitude(float sideLength) { }

	[Address(RVA = "0x58BDF0", Offset = "0x58AFF0", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60011F3")]
	public static float GetEqTriangleCentroidAltitude(float sideLength) { }

	[Address(RVA = "0x58C400", Offset = "0x58B600", Length = "0x53D")]
	[CalledBy(Type = typeof(PrismMath), Member = "RaycastTriangular", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Quaternion)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MeshTree), Member = "RaycastClosest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Matrix4x4)}, ReturnType = typeof(MeshRayHit))]
	[CalledBy(Type = typeof(EqTriangle3D), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RightAngTriangle3D), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ExtrudeEpsThreshold), Member = "get_Get", ReturnType = typeof(float))]
	[Calls(Type = typeof(Vector3Ex), Member = "AbsDot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(TriangleMath), Member = "Contains3DPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(bool), typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(TriangleEpsilon)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BoxMath), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Vector3), typeof(Vector3), typeof(Quaternion), typeof(BoxEpsilon)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(TriangleMath), Member = "Calc3DTriangleOBB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(TriangleEpsilon)}, ReturnType = typeof(OBB))]
	[Calls(Type = typeof(Ray), Member = "GetPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector3))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60011FC")]
	public static bool Raycast(Ray ray, out float t, Vector3 p0, Vector3 p1, Vector3 p2, TriangleEpsilon epsilon = null) { }

	[Address(RVA = "0x58BE60", Offset = "0x58B060", Length = "0x59C")]
	[CalledBy(Type = typeof(EqTriangle3D), Member = "RaycastWire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RightAngTriangle3D), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RightAngTriangle3D), Member = "RaycastWire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Ray), Member = "GetPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Vector3Ex), Member = "GetDistanceToSegment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Vector3Ex), Member = "AbsDot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(ExtrudeEpsThreshold), Member = "get_Get", ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(TriangleMath), Member = "Calc3DTriangleOBB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(TriangleEpsilon)}, ReturnType = typeof(OBB))]
	[Calls(Type = typeof(BoxMath), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Vector3), typeof(Vector3), typeof(Quaternion), typeof(BoxEpsilon)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60011FD")]
	public static bool RaycastWire(Ray ray, out float t, Vector3 p0, Vector3 p1, Vector3 p2, TriangleEpsilon epsilon = null) { }

}

