namespace RLD;

[Extension]
[Token(Token = "0x2000171")]
public static class Vector3Ex
{

	[Address(RVA = "0x56EAE0", Offset = "0x56DCE0", Length = "0x31")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x600104D")]
	public static Vector3 Abs(Vector3 v) { }

	[Address(RVA = "0x56EA90", Offset = "0x56DC90", Length = "0x43")]
	[CalledBy(Type = typeof(SceneGizmoAxisCap), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SceneGizmoAxisCap), Member = "UpdateColor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoBoxLineSlider3DController), Member = "GetRealSizeAlongDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(GizmoCylinderLineSlider3DController), Member = "GetRealSizeAlongDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(GizmoThinLineSlider3DController), Member = "GetRealSizeAlongDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(QuadMath), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(float), typeof(float), typeof(Vector3), typeof(Vector3), typeof(QuadEpsilon)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(QuadMath), Member = "RaycastWire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(float), typeof(float), typeof(Vector3), typeof(Vector3), typeof(QuadEpsilon)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(QuadMath), Member = "Contains3DPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(bool), typeof(Vector3), typeof(float), typeof(float), typeof(Vector3), typeof(Vector3), typeof(QuadEpsilon)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TriangleMath), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(TriangleEpsilon)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TriangleMath), Member = "RaycastWire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(TriangleEpsilon)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BoxShape3D), Member = "GetSizeAlongDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(float))]
	[CallerCount(Count = 12)]
	[Extension]
	[Token(Token = "0x6001051")]
	public static float AbsDot(Vector3 v1, Vector3 v2) { }

	[Address(RVA = "0x56EB20", Offset = "0x56DD20", Length = "0xAA")]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = "GetRealLength", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = "GetRealQuadWidth", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = "GetRealQuadHeight", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = "GetRealCircleRadius", ReturnType = typeof(float))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Camera), Member = "WorldToScreenPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600104C")]
	public static Vector2 ConvertDirTo2D(Vector3 start, Vector3 end, Camera camera) { }

	[Address(RVA = "0x40F040", Offset = "0x40E240", Length = "0x39")]
	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x6001050")]
	public static float Dot(Vector3 v1, Vector3 v2) { }

	[Address(RVA = "0x40F340", Offset = "0x40E540", Length = "0x12")]
	[CallerCount(Count = 28)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001052")]
	public static Vector3 FromValue(float value) { }

	[Address(RVA = "0x56EBD0", Offset = "0x56DDD0", Length = "0x1B5")]
	[CalledBy(Type = typeof(ArcMath), Member = "ShArcContains3DPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(bool), typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(float), typeof(ArcEpsilon)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ArcMath), Member = "Is3DPointOnShArcWire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(bool), typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(float), typeof(ArcEpsilon)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ArcMath), Member = "LgArcContains3DPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(bool), typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(float), typeof(ArcEpsilon)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ArcMath), Member = "Is3DPointOnLgArcWire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(bool), typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(float), typeof(ArcEpsilon)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ConeMath), Member = "ContainsPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(float), typeof(Quaternion), typeof(ConeEpsilon)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PolygonMath), Member = "Is3DPointOnBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(bool), typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>), typeof(bool), typeof(Vector3), typeof(PolygonEpsilon)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(QuadMath), Member = "RaycastWire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(float), typeof(float), typeof(Vector3), typeof(Vector3), typeof(QuadEpsilon)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SegmentMath), Member = "Is3DPointOnSegment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(SegmentEpsilon)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TriangleMath), Member = "RaycastWire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(TriangleEpsilon)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 19)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC4C0")]
	[Calls(Type = typeof(Vector3), Member = "Normalize", ReturnType = typeof(void))]
	[Extension]
	[Token(Token = "0x6001054")]
	public static float GetDistanceToSegment(Vector3 point, Vector3 point0, Vector3 point1) { }

	[Address(RVA = "0x56ED90", Offset = "0x56DF90", Length = "0x2E")]
	[CalledBy(Type = typeof(GameObjectEx), Member = "SetHierarchyWorldScaleByPivot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshTransform), Member = "InverseTransformOBB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OBB)}, ReturnType = typeof(OBB))]
	[CalledBy(Type = typeof(MeshTransform), Member = "InverseTransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CallerCount(Count = 4)]
	[Extension]
	[Token(Token = "0x6001058")]
	public static Vector3 GetInverse(Vector3 vector) { }

	[Address(RVA = "0x56EDC0", Offset = "0x56DFC0", Length = "0x2A")]
	[CalledBy(Type = typeof(ObjectSurfaceSnap), Member = "SnapHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(SnapConfig)}, ReturnType = typeof(SnapResult))]
	[CallerCount(Count = 2)]
	[Extension]
	[Token(Token = "0x600104F")]
	public static float GetMaxAbsComp(Vector3 v) { }

	[Address(RVA = "0x56EDF0", Offset = "0x56DFF0", Length = "0x132")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600105B")]
	public static int GetMostAligned(Vector3[] vectors, Vector3 dir, bool checkSameDirection) { }

	[Address(RVA = "0x56EF30", Offset = "0x56E130", Length = "0x105")]
	[CalledBy(Type = typeof(GizmoObjectVertexSnapDrag3D), Member = "CalculateDragValues", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectGridSnapSession), Member = "Snap", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001056")]
	public static int GetPointClosestToPoint(List<Vector3> points, Vector3 pt) { }

	[Address(RVA = "0x56F040", Offset = "0x56E240", Length = "0x343")]
	[CalledBy(Type = typeof(ObjectSurfaceSnap), Member = "SnapHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(SnapConfig)}, ReturnType = typeof(SnapResult))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001057")]
	public static Vector3 GetPointCloudCenter(IEnumerable<Vector3> ptCloud) { }

	[Address(RVA = "0x56F390", Offset = "0x56E590", Length = "0x55")]
	[CallerCount(Count = 0)]
	[Extension]
	[Token(Token = "0x600104E")]
	public static Vector3 GetSignVector(Vector3 v) { }

	[Address(RVA = "0x56F3F0", Offset = "0x56E5F0", Length = "0x71")]
	[CalledBy(Type = typeof(PlaneEx), Member = "GetCameraFacingAxisSlicePlane", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Camera)}, ReturnType = typeof(Plane))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Extension]
	[Token(Token = "0x6001059")]
	public static bool IsAligned(Vector3 vector, Vector3 other, bool checkSameDirection) { }

	[Address(RVA = "0x56F470", Offset = "0x56E670", Length = "0xDC")]
	[CalledBy(Type = typeof(ObjectSurfaceSnap), Member = "SnapHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(SnapConfig)}, ReturnType = typeof(SnapResult))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(List`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600104B")]
	public static void OffsetPoints(List<Vector3> points, Vector3 offset) { }

	[Address(RVA = "0x56F550", Offset = "0x56E750", Length = "0x42")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Extension]
	[Token(Token = "0x600105A")]
	public static bool PointsSameDir(Vector3 vector, Vector3 other) { }

	[Address(RVA = "0x56F5A0", Offset = "0x56E7A0", Length = "0x10B")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[DeduplicatedMethod]
	[Extension]
	[Token(Token = "0x6001055")]
	public static Vector3 ProjectOnSegment(Vector3 point, Vector3 point0, Vector3 point1) { }

	[Address(RVA = "0x56F6B0", Offset = "0x56E8B0", Length = "0x1F8")]
	[CalledBy(Type = typeof(TransformEx), Member = "Align", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(TransformAxis)}, ReturnType = typeof(Quaternion))]
	[CalledBy(Type = typeof(ArcMath), Member = "ConvertToSh3DArcAngle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(ArcMath), Member = "ConvertToSh2DArcAngle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(float)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(ArcMath), Member = "ShArcContains3DPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(bool), typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(float), typeof(ArcEpsilon)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ArcMath), Member = "Is3DPointOnShArcWire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(bool), typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(float), typeof(ArcEpsilon)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ArcMath), Member = "LgArcContains3DPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(bool), typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(float), typeof(ArcEpsilon)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ArcMath), Member = "Is3DPointOnLgArcWire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(bool), typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(float), typeof(ArcEpsilon)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(MathEx), Member = "SafeAcos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Token(Token = "0x6001053")]
	public static float SignedAngle(Vector3 from, Vector3 to, Vector3 axis) { }

}

