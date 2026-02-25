namespace RLD;

[Token(Token = "0x20001B5")]
public static class SegmentMath
{

	[Address(RVA = "0x586740", Offset = "0x585940", Length = "0x22")]
	[CalledBy(Type = typeof(SegmentShape2D), Member = "ContainsPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector2Ex), Member = "GetDistanceToSegment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(float))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60011E4")]
	public static bool Is2DPointOnSegment(Vector2 point, Vector2 startPoint, Vector2 endPoint, SegmentEpsilon epsilon = null) { }

	[Address(RVA = "0x586770", Offset = "0x585970", Length = "0x66")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3Ex), Member = "GetDistanceToSegment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(float))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60011E3")]
	public static bool Is3DPointOnSegment(Vector3 point, Vector3 startPoint, Vector3 endPoint, SegmentEpsilon epsilon = null) { }

	[Address(RVA = "0x56F5A0", Offset = "0x56E7A0", Length = "0x10B")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[DeduplicatedMethod]
	[Token(Token = "0x60011E5")]
	public static Vector3 ProjectPtOnSegment(Vector3 point, Vector3 startPoint, Vector3 endPoint) { }

	[Address(RVA = "0x5867E0", Offset = "0x5859E0", Length = "0x157")]
	[CalledBy(Type = typeof(SegmentShape3D), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CylinderMath), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(Vector3), typeof(float), typeof(CylinderEpsilon)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SphereMath), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(float), typeof(SphereEpsilon)}, ReturnType = typeof(bool))]
	[Token(Token = "0x60011E2")]
	public static bool Raycast(Ray ray, out float t, Vector3 startPoint, Vector3 endPoint, SegmentEpsilon epsilon = null) { }

}

