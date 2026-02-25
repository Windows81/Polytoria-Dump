namespace RLD;

[Extension]
[Token(Token = "0x2000170")]
public static class Vector2Ex
{

	[Address(RVA = "0x56E3F0", Offset = "0x56D5F0", Length = "0x28")]
	[CalledBy(Type = typeof(QuadShape2D), Member = "set_Size", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(QuadShape3D), Member = "set_Size", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Extension]
	[Token(Token = "0x6001043")]
	public static Vector2 Abs(Vector2 v) { }

	[Address(RVA = "0x56E3B0", Offset = "0x56D5B0", Length = "0x34")]
	[CalledBy(Type = typeof(QuadMath), Member = "Contains2DPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(float), typeof(float), typeof(float), typeof(QuadEpsilon)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(QuadMath), Member = "Contains2DPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(float), typeof(float), typeof(Vector2), typeof(Vector2), typeof(QuadEpsilon)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(QuadShape2D), Member = "GetSizeAlongDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(float))]
	[CallerCount(Count = 5)]
	[Extension]
	[Token(Token = "0x6001044")]
	public static float AbsDot(Vector2 v1, Vector2 v2) { }

	[Address(RVA = "0x56E420", Offset = "0x56D620", Length = "0x139")]
	[CalledBy(Type = typeof(GizmoLineSlider2D), Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CameraEx), Member = "GetPointZDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Camera), Member = "ScreenToWorldPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001041")]
	public static Vector3 ConvertDirTo3D(Vector2 start, Vector2 end, Vector3 zPos, Camera camera) { }

	[Address(RVA = "0x56E560", Offset = "0x56D760", Length = "0x132")]
	[CalledBy(Type = typeof(GizmoPlaneSlider2D), Member = "OnGizmoAttemptHandleDragBegin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Gizmo), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CameraEx), Member = "GetPointZDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Camera), Member = "ScreenToWorldPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001042")]
	public static Vector3 ConvertDirTo3D(Vector2 dir, Vector3 zPos, Camera camera) { }

	[Address(RVA = "0x40ED20", Offset = "0x40DF20", Length = "0xC")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001047")]
	public static Vector2 FromValue(float value) { }

	[Address(RVA = "0x56E6A0", Offset = "0x56D8A0", Length = "0x22A")]
	[CalledBy(Type = typeof(PolygonMath), Member = "Is2DPointOnBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), typeof(bool), typeof(PolygonEpsilon)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(QuadMath), Member = "Is2DPointOnBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(float), typeof(float), typeof(float), typeof(QuadEpsilon)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(QuadMath), Member = "Is2DPointOnBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(float), typeof(float), typeof(Vector2), typeof(Vector2), typeof(QuadEpsilon)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SegmentMath), Member = "Is2DPointOnSegment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(Vector2), typeof(SegmentEpsilon)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1803AFC00")]
	[ContainsUnimplementedInstructions]
	[Extension]
	[Token(Token = "0x6001049")]
	public static float GetDistanceToSegment(Vector2 point, Vector2 point0, Vector2 point1) { }

	[Address(RVA = "0x56E8D0", Offset = "0x56DAD0", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Extension]
	[Token(Token = "0x6001048")]
	public static Vector2 GetInverse(Vector2 vector) { }

	[Address(RVA = "0x56E900", Offset = "0x56DB00", Length = "0x36")]
	[CalledBy(Type = typeof(GizmoSglAxisRotationDrag3D), Member = "OnSessionBegin", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PrimitiveFactory), Member = "ProjectArcPointsOnPoly2DBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Vector2), Member = "get_normalized", ReturnType = typeof(Vector2))]
	[Extension]
	[Token(Token = "0x6001046")]
	public static Vector2 GetNormal(Vector2 vec) { }

	[Address(RVA = "0x56E940", Offset = "0x56DB40", Length = "0x110")]
	[CalledBy(Type = typeof(GizmoObjectVertexSnapDrag3D), Member = "GetWorldPointClosestToInputDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>), typeof(Vector3&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600104A")]
	public static int GetPointClosestToPoint(List<Vector2> points, Vector2 pt) { }

	[Address(RVA = "0x56EA60", Offset = "0x56DC60", Length = "0x23")]
	[CalledBy(Type = typeof(ArcShape2D), Member = "CalculateEndPoint", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Extension]
	[Token(Token = "0x6001045")]
	public static Vector3 ToVector3(Vector2 vec, float z = 0) { }

}

