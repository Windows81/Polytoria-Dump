namespace RLD;

[Token(Token = "0x20001D4")]
public class RTMesh
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000738")]
	private Mesh _unityMesh; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000739")]
	private Vector3[] _vertices; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400073A")]
	private Int32[] _vertIndices; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400073B")]
	private int _numTriangles; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400073C")]
	private AABB _aabb; //Field offset: 0x2C
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400073D")]
	private MeshTree _meshTree; //Field offset: 0x48

	[Token(Token = "0x170005D7")]
	public AABB AABB
	{
		[Address(RVA = "0x581FC0", Offset = "0x5811C0", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6001265")]
		 get { } //Length: 27
	}

	[Token(Token = "0x170005D8")]
	public bool IsTreeBuilt
	{
		[Address(RVA = "0x581FE0", Offset = "0x5811E0", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001266")]
		 get { } //Length: 27
	}

	[Token(Token = "0x170005D5")]
	public int NumTriangles
	{
		[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001263")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170005D6")]
	public Mesh UnityMesh
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001264")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x581D20", Offset = "0x580F20", Length = "0x297")]
	[CalledBy(Type = typeof(RTMesh), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(RTMesh))]
	[CalledBy(Type = typeof(RTMeshDb), Member = "GetRTMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(RTMesh))]
	[CalledBy(Type = typeof(RTMeshDb), Member = "CreateRTMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(RTMesh))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(AABB), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bounds)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Mesh), Member = "get_vertices", ReturnType = typeof(Vector3[]))]
	[Calls(Type = typeof(Mesh), Member = "get_triangles", ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(SphereTree`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Int32>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "get_bounds", ReturnType = typeof(Bounds))]
	[CallsDeduplicatedMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001267")]
	public RTMesh(Mesh unityMesh) { }

	[Address(RVA = "0x581760", Offset = "0x580960", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MeshTree), Member = "Build", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001269")]
	public void BuildTree() { }

	[Address(RVA = "0x581780", Offset = "0x580980", Length = "0xEE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Mesh), Member = "get_isReadable", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Mesh), Member = "get_subMeshCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Mesh), Member = "GetTopology", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(MeshTopology))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(RTMesh), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001268")]
	public static RTMesh Create(Mesh unityMesh) { }

	[Address(RVA = "0x581870", Offset = "0x580A70", Length = "0x4A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(SphereTree`1), Member = "DebugDraw", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600126F")]
	public void DebugDrawTree() { }

	[Address(RVA = "0x581FC0", Offset = "0x5811C0", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001265")]
	public AABB get_AABB() { }

	[Address(RVA = "0x581FE0", Offset = "0x5811E0", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001266")]
	public bool get_IsTreeBuilt() { }

	[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001263")]
	public int get_NumTriangles() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001264")]
	public Mesh get_UnityMesh() { }

	[Address(RVA = "0x5818C0", Offset = "0x580AC0", Length = "0x1B2")]
	[CalledBy(Type = typeof(MeshTree), Member = "Build", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshTree), Member = "OverlapVerts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OBB), typeof(MeshTransform), typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MeshTree), Member = "OverlapModelVerts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OBB), typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(MeshTriangle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3[]), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600126A")]
	public MeshTriangle GetTriangle(int triangleIndex) { }

	[Address(RVA = "0x581A80", Offset = "0x580C80", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MeshTree), Member = "OverlapModelVerts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OBB), typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600126D")]
	public bool OverlapModelVerts(OBB modelOBB, List<Vector3> verts) { }

	[Address(RVA = "0x581AD0", Offset = "0x580CD0", Length = "0xAE")]
	[CalledBy(Type = typeof(Object2ObjectSnapData), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(OBB), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AABB)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshTree), Member = "OverlapModelVerts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OBB), typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600126E")]
	public bool OverlapModelVerts(AABB modelAABB, List<Vector3> verts) { }

	[Address(RVA = "0x581B80", Offset = "0x580D80", Length = "0x121")]
	[CalledBy(Type = typeof(ObjectVertexCollect), Member = "CollectHierarchyVerts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BoxFace), typeof(float), typeof(float)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Transform), Member = "get_lossyScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(MeshTree), Member = "OverlapVerts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OBB), typeof(MeshTransform), typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600126C")]
	public bool OverlapVerts(OBB obb, Transform meshObjectTransform, List<Vector3> verts) { }

	[Address(RVA = "0x581CB0", Offset = "0x580EB0", Length = "0x64")]
	[CalledBy(Type = typeof(SceneTree), Member = "RaycastMeshObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(GameObject)}, ReturnType = typeof(GameObjectRayHit))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MeshTree), Member = "RaycastClosest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Matrix4x4)}, ReturnType = typeof(MeshRayHit))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600126B")]
	public MeshRayHit Raycast(Ray ray, Matrix4x4 meshTransform) { }

}

