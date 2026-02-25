namespace RLD;

[Token(Token = "0x20001CE")]
public class MeshTree
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000724")]
	private RTMesh _mesh; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000725")]
	private SphereTree<MeshTriangle> _tree; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000726")]
	private List<SphereTreeNode`1<MeshTriangle>> _nodeBuffer; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000727")]
	private List<SphereTreeNodeRayHit`1<MeshTriangle>> _nodeHitBuffer; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000728")]
	private HashSet<Int32> _vertexIndexSet; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000729")]
	private bool _isBuilt; //Field offset: 0x38

	[Token(Token = "0x170005BE")]
	public bool IsBuilt
	{
		[Address(RVA = "0x3408F0", Offset = "0x33FAF0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001234")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x574D40", Offset = "0x573F40", Length = "0x166")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SphereTree`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Int32>), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6001235")]
	public MeshTree(RTMesh mesh) { }

	[Address(RVA = "0x573990", Offset = "0x572B90", Length = "0x12E")]
	[CalledBy(Type = typeof(MeshTree), Member = "OverlapVerts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OBB), typeof(MeshTransform), typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MeshTree), Member = "OverlapModelVerts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OBB), typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MeshTree), Member = "RaycastClosest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Matrix4x4)}, ReturnType = typeof(MeshRayHit))]
	[CalledBy(Type = typeof(RTMesh), Member = "BuildTree", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTMeshCompiler), Member = "CompileForObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RTMesh), Member = "GetTriangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(MeshTriangle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(Sphere), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SphereTree`1), Member = "AddNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T", typeof(Sphere)}, ReturnType = "RLD.SphereTreeNode`1<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001236")]
	public void Build() { }

	[Address(RVA = "0x573AC0", Offset = "0x572CC0", Length = "0x44")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SphereTree`1), Member = "DebugDraw", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600123A")]
	public void DebugDraw() { }

	[Address(RVA = "0x3408F0", Offset = "0x33FAF0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001234")]
	public bool get_IsBuilt() { }

	[Address(RVA = "0x573B10", Offset = "0x572D10", Length = "0x4B2")]
	[CalledBy(Type = typeof(RTMesh), Member = "OverlapModelVerts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OBB), typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RTMesh), Member = "OverlapModelVerts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AABB), typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(BoxMath), Member = "ContainsPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(Quaternion), typeof(BoxEpsilon)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HashSet`1), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(RTMesh), Member = "GetTriangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(MeshTriangle))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001EA0")]
	[Calls(Type = typeof(SphereTree`1), Member = "OverlapBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OBB), "System.Collections.Generic.List`1<SphereTreeNode`1<T>>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MeshTree), Member = "Build", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001238")]
	public bool OverlapModelVerts(OBB modelOBB, List<Vector3> verts) { }

	[Address(RVA = "0x573FD0", Offset = "0x5731D0", Length = "0x616")]
	[CalledBy(Type = typeof(RTMesh), Member = "OverlapVerts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OBB), typeof(Transform), typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(BoxMath), Member = "ContainsPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(Quaternion), typeof(BoxEpsilon)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(HashSet`1), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(RTMesh), Member = "GetTriangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(MeshTriangle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001EA0")]
	[Calls(Type = typeof(SphereTree`1), Member = "OverlapBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OBB), "System.Collections.Generic.List`1<SphereTreeNode`1<T>>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MeshTransform), Member = "InverseTransformOBB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OBB)}, ReturnType = typeof(OBB))]
	[Calls(Type = typeof(MeshTree), Member = "Build", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001237")]
	public bool OverlapVerts(OBB obb, MeshTransform meshTransform, List<Vector3> verts) { }

	[Address(RVA = "0x5745F0", Offset = "0x5737F0", Length = "0x74F")]
	[CalledBy(Type = typeof(RTMesh), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Matrix4x4)}, ReturnType = typeof(MeshRayHit))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Ray), Member = "GetPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(MeshRayHit), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(int), typeof(float), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Matrix4x4), Member = "get_transpose", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "get_inverse", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC4C0")]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(TriangleMath), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(TriangleEpsilon)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(SphereTree`1), Member = "RaycastAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), "System.Collections.Generic.List`1<SphereTreeNodeRayHit`1<T>>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RayEx), Member = "InverseTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Matrix4x4)}, ReturnType = typeof(Ray))]
	[Calls(Type = typeof(MeshTree), Member = "Build", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6001239")]
	public MeshRayHit RaycastClosest(Ray ray, Matrix4x4 meshTransform) { }

}

