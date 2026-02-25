namespace RLD;

[Token(Token = "0x200019C")]
public static class PolygonMath
{

	[Address(RVA = "0x564BB0", Offset = "0x563DB0", Length = "0x243")]
	[CalledBy(Type = typeof(PolygonMath), Member = "Is2DPointOnThickBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), typeof(bool), typeof(PolygonEpsilon)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PolygonShape2D), Member = "ContainsPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Vector2), Member = "get_normalized", ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001177")]
	public static bool Contains2DPoint(Vector2 point, List<Vector2> polyPoints, bool isClosed, PolygonEpsilon epsilon = null) { }

	[Address(RVA = "0x564E00", Offset = "0x564000", Length = "0x429")]
	[CalledBy(Type = typeof(PolygonMath), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>), typeof(bool), typeof(Vector3), typeof(PolygonEpsilon)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001176")]
	public static bool Contains3DPoint(Vector3 point, bool checkOnPlane, List<Vector3> cwPolyPoints, bool isClosed, Vector3 polyNormal, PolygonEpsilon epsilon = null) { }

	[Address(RVA = "0x565230", Offset = "0x564430", Length = "0x14D")]
	[CalledBy(Type = typeof(PolygonShape2D), Member = "ContainsPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Vector2Ex), Member = "GetDistanceToSegment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001179")]
	public static bool Is2DPointOnBorder(Vector2 point, List<Vector2> polyPoints, bool isClosed, PolygonEpsilon epsilon = null) { }

	[Address(RVA = "0x565380", Offset = "0x564580", Length = "0x236")]
	[CalledBy(Type = typeof(PolygonShape2D), Member = "ContainsPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001F260")]
	[Calls(Type = typeof(PolygonMath), Member = "Contains2DPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), typeof(bool), typeof(PolygonEpsilon)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600117A")]
	public static bool Is2DPointOnThickBorder(Vector2 point, List<Vector2> polyPoints, List<Vector2> thickBorderPoints, bool isClosed, PolygonEpsilon epsilon = null) { }

	[Address(RVA = "0x5655C0", Offset = "0x5647C0", Length = "0x2EB")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(PlaneEx), Member = "ProjectPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Plane), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Vector3Ex), Member = "GetDistanceToSegment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001178")]
	public static bool Is3DPointOnBorder(Vector3 point, bool checkOnPlane, List<Vector3> cwPolyPoints, bool isClosed, Vector3 polyNormal, PolygonEpsilon epsilon = null) { }

	[Address(RVA = "0x5658B0", Offset = "0x564AB0", Length = "0x2C3")]
	[CalledBy(Type = typeof(PrismMath), Member = "RaycastTriangular", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Quaternion)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Ray), Member = "GetPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(PolygonMath), Member = "Contains3DPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(bool), typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>), typeof(bool), typeof(Vector3), typeof(PolygonEpsilon)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001175")]
	public static bool Raycast(Ray ray, out float t, List<Vector3> cwPolyPoints, bool isClosed, Vector3 polyNormal, PolygonEpsilon epsilon = null) { }

}

