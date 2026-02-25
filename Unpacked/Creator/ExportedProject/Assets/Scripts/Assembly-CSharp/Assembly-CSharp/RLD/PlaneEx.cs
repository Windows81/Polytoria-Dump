namespace RLD;

[Extension]
[Token(Token = "0x2000167")]
public static class PlaneEx
{

	[Address(RVA = "0x544710", Offset = "0x543910", Length = "0x48")]
	[CalledBy(Type = typeof(ArcMath), Member = "ShArcContains3DPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(bool), typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(float), typeof(ArcEpsilon)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ArcMath), Member = "Is3DPointOnShArcWire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(bool), typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(float), typeof(ArcEpsilon)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ArcMath), Member = "Is3DPointOnLgArcWire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(bool), typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(float), typeof(ArcEpsilon)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(BoxMath), Member = "GetFaceClosestToPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(Quaternion)}, ReturnType = typeof(BoxFaceDesc))]
	[CalledBy(Type = typeof(BoxMath), Member = "GetFaceClosestToPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(BoxFaceDesc))]
	[CalledBy(Type = typeof(CircleMath), Member = "Contains3DPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(bool), typeof(Vector3), typeof(float), typeof(Vector3), typeof(CircleEpsilon)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(QuadMath), Member = "Contains3DPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(bool), typeof(Vector3), typeof(float), typeof(float), typeof(Vector3), typeof(Vector3), typeof(QuadEpsilon)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RTSceneGrid), Member = "Render_SystemCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTSceneGrid), Member = "CalculateCellFadeZoom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(float))]
	[CallerCount(Count = 9)]
	[Extension]
	[Token(Token = "0x6001012")]
	public static float GetAbsDistanceToPoint(Plane plane, Vector3 point) { }

	[Address(RVA = "0x544760", Offset = "0x543960", Length = "0x282")]
	[CalledBy(Type = typeof(GizmoSglAxisOffsetDrag3D), Member = "CalculateDragPlane", ReturnType = typeof(Plane))]
	[CalledBy(Type = typeof(GizmoSglAxisScaleDrag3D), Member = "CalculateDragPlane", ReturnType = typeof(Plane))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_forward", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Vector3Ex), Member = "IsAligned", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Transform), Member = "get_right", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC4C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001019")]
	public static Plane GetCameraFacingAxisSlicePlane(Vector3 axisOrigin, Vector3 axis, Camera camera) { }

	[Address(RVA = "0x544B30", Offset = "0x543D30", Length = "0x102")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x6001016")]
	public static int GetClosestPtInFront(Plane plane, List<Vector3> points) { }

	[Address(RVA = "0x5449F0", Offset = "0x543BF0", Length = "0x13C")]
	[CalledBy(Type = typeof(ObjectSurfaceSnap), Member = "CalculateSitOnSurfaceOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OBB), typeof(Plane), typeof(float)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = typeof(ObjectSurfaceSnap), Member = "CalculateSitOnSurfaceOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AABB), typeof(Plane), typeof(float)}, ReturnType = typeof(Vector3))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x6001017")]
	public static int GetClosestPtInFrontOrOnPlane(Plane plane, List<Vector3> points) { }

	[Address(RVA = "0x544C40", Offset = "0x543E40", Length = "0x102")]
	[CalledBy(Type = typeof(RTSceneGrid), Member = "SnapToObjectHitPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObjectRayHit), "RLD.RTSceneGrid+SnapToPointMode"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectSurfaceSnap), Member = "CalculateSitOnSurfaceOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OBB), typeof(Plane), typeof(float)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = typeof(ObjectSurfaceSnap), Member = "CalculateSitOnSurfaceOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AABB), typeof(Plane), typeof(float)}, ReturnType = typeof(Vector3))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x6001018")]
	public static int GetFurthestPtBehind(Plane plane, List<Vector3> points) { }

	[Address(RVA = "0x544D50", Offset = "0x543F50", Length = "0x102")]
	[CalledBy(Type = typeof(RTSceneGrid), Member = "SnapToObjectHitPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObjectRayHit), "RLD.RTSceneGrid+SnapToPointMode"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Extension]
	[Token(Token = "0x6001015")]
	public static int GetFurthestPtInFront(Plane plane, List<Vector3> points) { }

	[Address(RVA = "0x544E60", Offset = "0x544060", Length = "0x90")]
	[CalledBy(Type = typeof(Object2ObjectSnapSession), Member = "SnapTargets", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Extension]
	[Token(Token = "0x6001011")]
	public static Plane InvertNormal(Plane plane) { }

	[Address(RVA = "0x544EF0", Offset = "0x5440F0", Length = "0x2C6")]
	[CalledBy(Type = typeof(RTScene), Member = "OverlapBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OBB), typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Object2ObjectSnapData), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Extension]
	[Token(Token = "0x6001014")]
	public static List<Vector3> ProjectAllPoints(Plane plane, List<Vector3> points) { }

	[Address(RVA = "0x5451C0", Offset = "0x5443C0", Length = "0x94")]
	[CalledBy(Type = typeof(TorusMath), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(float), typeof(float), typeof(Quaternion), typeof(TorusEpsilon)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ObjectSurfaceSnap), Member = "CalculateSitOnSurfaceOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OBB), typeof(Plane), typeof(float)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = typeof(GizmoPlaneSlider3D), Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SpriteRendererEx), Member = "IsPixelFullyTransparent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteRenderer), typeof(Vector3)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CircleMath), Member = "Contains3DPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(bool), typeof(Vector3), typeof(float), typeof(Vector3), typeof(CircleEpsilon)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PolygonMath), Member = "Is3DPointOnBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(bool), typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>), typeof(bool), typeof(Vector3), typeof(PolygonEpsilon)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PrimitiveFactory), Member = "Generate3DArcBorderPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Plane), typeof(float), typeof(bool), typeof(int)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>))]
	[CalledBy(Type = typeof(ObjectSurfaceSnap), Member = "CalculateSitOnSurfaceOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AABB), typeof(Plane), typeof(float)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = typeof(TorusMath), Member = "RaycastCylindrical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(Quaternion), typeof(TorusEpsilon)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RTSceneGrid), Member = "Render_SystemCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArcShape3D), Member = "SetArcData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Plane), typeof(Vector3), typeof(Vector3), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectAlign), Member = "AlignRootsToPlane", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(Plane)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectSurfaceSnap), Member = "SnapHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(SnapConfig)}, ReturnType = typeof(SnapResult))]
	[CallerCount(Count = 18)]
	[Extension]
	[Token(Token = "0x6001013")]
	public static Vector3 ProjectPoint(Plane plane, Vector3 pt) { }

}

