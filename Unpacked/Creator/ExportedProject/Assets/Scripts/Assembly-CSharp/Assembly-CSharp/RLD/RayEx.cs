namespace RLD;

[Extension]
[Token(Token = "0x2000169")]
public static class RayEx
{

	[Address(RVA = "0x56AFA0", Offset = "0x56A1A0", Length = "0x137")]
	[CalledBy(Type = typeof(BoxMath), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(Vector3), typeof(Quaternion), typeof(BoxEpsilon)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PrismMath), Member = "RaycastTriangular", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(float), typeof(float), typeof(Quaternion)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PyramidMath), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(Quaternion)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MeshTree), Member = "RaycastClosest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Matrix4x4)}, ReturnType = typeof(MeshRayHit))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Matrix4x4), Member = "get_inverse", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Extension]
	[Token(Token = "0x6001021")]
	public static Ray InverseTransform(Ray ray, Matrix4x4 transformMatrix) { }

	[Address(RVA = "0x56B0E0", Offset = "0x56A2E0", Length = "0x130")]
	[CalledBy(Type = typeof(TorusMath), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(float), typeof(float), typeof(Quaternion), typeof(TorusEpsilon)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TorusMath), Member = "RaycastCylindrical", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(Quaternion), typeof(TorusEpsilon)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC4C0")]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Extension]
	[Token(Token = "0x6001022")]
	public static Ray Mirror(Ray ray, Vector3 mirrorPoint) { }

}

