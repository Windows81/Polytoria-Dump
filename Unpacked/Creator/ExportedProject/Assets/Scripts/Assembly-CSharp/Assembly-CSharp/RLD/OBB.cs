namespace RLD;

[Token(Token = "0x2000183")]
public struct OBB
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000681")]
	private Vector3 _size; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000682")]
	private Vector3 _center; //Field offset: 0xC
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000683")]
	private Quaternion _rotation; //Field offset: 0x18
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000684")]
	private bool _isValid; //Field offset: 0x28

	[Token(Token = "0x1700057F")]
	public Vector3 Center
	{
		[Address(RVA = "0x3B9440", Offset = "0x3B8640", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001102")]
		 get { } //Length: 19
		[Address(RVA = "0x3B9470", Offset = "0x3B8670", Length = "0x10")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001103")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000581")]
	public Vector3 Extents
	{
		[Address(RVA = "0x553770", Offset = "0x552970", Length = "0x3A")]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001106")]
		 get { } //Length: 58
	}

	[Token(Token = "0x1700057E")]
	public bool IsValid
	{
		[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001101")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000586")]
	public Vector3 Look
	{
		[Address(RVA = "0x562DC0", Offset = "0x561FC0", Length = "0x87")]
		[CalledBy(Type = typeof(TriangleMath), Member = "Calc3DTriangleOBB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(TriangleEpsilon)}, ReturnType = typeof(OBB))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Token(Token = "0x600110C")]
		 get { } //Length: 135
	}

	[Token(Token = "0x17000584")]
	public Vector3 Right
	{
		[Address(RVA = "0x562E50", Offset = "0x562050", Length = "0x87")]
		[CalledBy(Type = typeof(TriangleMath), Member = "Calc3DTriangleOBB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(TriangleEpsilon)}, ReturnType = typeof(OBB))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Token(Token = "0x600110A")]
		 get { } //Length: 135
	}

	[Token(Token = "0x17000582")]
	public Quaternion Rotation
	{
		[Address(RVA = "0x5131D0", Offset = "0x5123D0", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001107")]
		 get { } //Length: 11
		[Address(RVA = "0x5131E0", Offset = "0x5123E0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001108")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000583")]
	public Matrix4x4 RotationMatrix
	{
		[Address(RVA = "0x562EE0", Offset = "0x5620E0", Length = "0x104")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Matrix4x4), Member = "TRS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
		[Token(Token = "0x6001109")]
		 get { } //Length: 260
	}

	[Token(Token = "0x17000580")]
	public Vector3 Size
	{
		[Address(RVA = "0x43C320", Offset = "0x43B520", Length = "0x12")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001104")]
		 get { } //Length: 18
		[Address(RVA = "0x43C340", Offset = "0x43B540", Length = "0xF")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001105")]
		 set { } //Length: 15
	}

	[Token(Token = "0x17000585")]
	public Vector3 Up
	{
		[Address(RVA = "0x562FF0", Offset = "0x5621F0", Length = "0x87")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[Token(Token = "0x600110B")]
		 get { } //Length: 135
	}

	[Address(RVA = "0x562D20", Offset = "0x561F20", Length = "0x99")]
	[CalledBy(Type = typeof(TriangleMath), Member = "Calc3DTriangleOBB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(TriangleEpsilon)}, ReturnType = typeof(OBB))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6001110")]
	public OBB(Quaternion rotation) { }

	[Address(RVA = "0x562B00", Offset = "0x561D00", Length = "0x2E")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001115")]
	public OBB(OBB copy) { }

	[Address(RVA = "0x562C40", Offset = "0x561E40", Length = "0xDA")]
	[CalledBy(Type = typeof(Object2ObjectSnap), Member = "CalculateSnapResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Config)}, ReturnType = typeof(SnapResult))]
	[CalledBy(Type = typeof(Object2ObjectSnapData), Member = "GetAllWorldSnapAreaBounds", ReturnType = typeof(System.Collections.Generic.List`1<RLD.OBB>))]
	[CalledBy(Type = typeof(Object2ObjectSnapData), Member = "GetWorldSnapAreaBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BoxFace)}, ReturnType = typeof(OBB))]
	[CalledBy(Type = typeof(ObjectAlign), Member = "AlignRootsToPlane", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(Plane)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectBounds), Member = "CalcSpriteWorldOBB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(OBB))]
	[CalledBy(Type = typeof(ObjectBounds), Member = "GetMeshWorldOBB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(OBB))]
	[CalledBy(Type = typeof(ObjectBounds), Member = "CalcHierarchyWorldOBB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(QueryConfig)}, ReturnType = typeof(OBB))]
	[CalledBy(Type = typeof(ObjectBounds), Member = "CalcWorldOBB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(QueryConfig)}, ReturnType = typeof(OBB))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Transform), Member = "get_lossyScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "TransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001114")]
	public OBB(AABB modelSpaceAABB, Transform worldTransform) { }

	[Address(RVA = "0x562BA0", Offset = "0x561DA0", Length = "0x2B")]
	[CalledBy(Type = typeof(BoxShape3D), Member = "RenderWire", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoxShape3D), Member = "GetOBB", ReturnType = typeof(OBB))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x6001113")]
	public OBB(AABB aabb, Quaternion rotation) { }

	[Address(RVA = "0x562BD0", Offset = "0x561DD0", Length = "0x62")]
	[CalledBy(Type = typeof(RTMesh), Member = "OverlapModelVerts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AABB), typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "Render_SystemCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6001112")]
	public OBB(AABB aabb) { }

	[Address(RVA = "0x562A40", Offset = "0x561C40", Length = "0x4F")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6001111")]
	public OBB(Bounds bounds, Quaternion rotation) { }

	[Address(RVA = "0x562A90", Offset = "0x561C90", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600110F")]
	public OBB(Vector3 center, Quaternion rotation) { }

	[Address(RVA = "0x562A10", Offset = "0x561C10", Length = "0x2C")]
	[CalledBy(Type = typeof(ObjectExtrudeGizmo), Member = "get_OBB", ReturnType = typeof(OBB))]
	[CalledBy(Type = typeof(ObjectExtrudeGizmo), Member = "OnGizmoRender", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BoxGizmo), Member = "OnGizmoRender", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CameraViewVolume), Member = "FromCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(QuadMath), Member = "Calc3DQuadOBB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector2), typeof(Quaternion), typeof(QuadEpsilon)}, ReturnType = typeof(OBB))]
	[CalledBy(Type = typeof(QuadMath), Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(float), typeof(float), typeof(Vector3), typeof(Vector3), typeof(QuadEpsilon)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(QuadMath), Member = "RaycastWire", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(Single&), typeof(Vector3), typeof(float), typeof(float), typeof(Vector3), typeof(Vector3), typeof(QuadEpsilon)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Token(Token = "0x600110E")]
	public OBB(Vector3 center, Vector3 size, Quaternion rotation) { }

	[Address(RVA = "0x562B30", Offset = "0x561D30", Length = "0x63")]
	[CalledBy(Type = typeof(MeshTransform), Member = "InverseTransformOBB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OBB)}, ReturnType = typeof(OBB))]
	[CalledBy(Type = typeof(ObjectVertexCollect), Member = "CollectHierarchyVerts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BoxFace), typeof(float), typeof(float)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600110D")]
	public OBB(Vector3 center, Vector3 size) { }

	[Address(RVA = "0x561EB0", Offset = "0x5610B0", Length = "0x298")]
	[CalledBy(Type = typeof(ObjectExtrudeGizmo), Member = "FitBoxToTargets", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BoxMath), Member = "CalcBoxCornerPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Quaternion)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>))]
	[Calls(Type = typeof(Matrix4x4), Member = "TRS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "get_inverse", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4Ex), Member = "TransformPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>))]
	[Calls(Type = typeof(AABB), Member = "Encapsulate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x600111B")]
	public void Encapsulate(OBB otherOBB) { }

	[Address(RVA = "0x3B9440", Offset = "0x3B8640", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001102")]
	public Vector3 get_Center() { }

	[Address(RVA = "0x553770", Offset = "0x552970", Length = "0x3A")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001106")]
	public Vector3 get_Extents() { }

	[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001101")]
	public bool get_IsValid() { }

	[Address(RVA = "0x562DC0", Offset = "0x561FC0", Length = "0x87")]
	[CalledBy(Type = typeof(TriangleMath), Member = "Calc3DTriangleOBB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(TriangleEpsilon)}, ReturnType = typeof(OBB))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x600110C")]
	public Vector3 get_Look() { }

	[Address(RVA = "0x562E50", Offset = "0x562050", Length = "0x87")]
	[CalledBy(Type = typeof(TriangleMath), Member = "Calc3DTriangleOBB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(TriangleEpsilon)}, ReturnType = typeof(OBB))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x600110A")]
	public Vector3 get_Right() { }

	[Address(RVA = "0x5131D0", Offset = "0x5123D0", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001107")]
	public Quaternion get_Rotation() { }

	[Address(RVA = "0x562EE0", Offset = "0x5620E0", Length = "0x104")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Matrix4x4), Member = "TRS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Token(Token = "0x6001109")]
	public Matrix4x4 get_RotationMatrix() { }

	[Address(RVA = "0x43C320", Offset = "0x43B520", Length = "0x12")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001104")]
	public Vector3 get_Size() { }

	[Address(RVA = "0x562FF0", Offset = "0x5621F0", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x600110B")]
	public Vector3 get_Up() { }

	[Address(RVA = "0x562150", Offset = "0x561350", Length = "0xCC")]
	[CalledBy(Type = typeof(GizmoObjectVertexSnapDrag3D), Member = "GetWorldPointClosestToInputDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>), typeof(Vector3&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ObjectGridSnapSession), Member = "SelectPivot", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Object2ObjectSnap), Member = "CalculateSnapResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Config)}, ReturnType = typeof(SnapResult))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(OBB), Member = "GetCornerPoints", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600111A")]
	public List<Vector3> GetCenterAndCornerPoints() { }

	[Address(RVA = "0x562220", Offset = "0x561420", Length = "0x10F")]
	[CalledBy(Type = typeof(SphereTree`1), Member = "OverlapBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OBB), "System.Collections.Generic.List`1<SphereTreeNode`1<T>>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(OBB), Member = "IntersectsSphere", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sphere)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BoxMath), Member = "CalcBoxPtClosestToPt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Vector3), typeof(Quaternion)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x600111E")]
	public Vector3 GetClosestPoint(Vector3 point) { }

	[Address(RVA = "0x562330", Offset = "0x561530", Length = "0xC0")]
	[CalledBy(Type = typeof(GraphicsEx), Member = "DrawWireCornerBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OBB), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(OBB), Member = "GetCenterAndCornerPoints", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>))]
	[CalledBy(Type = typeof(RTScene), Member = "OverlapBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OBB), typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ObjectSurfaceSnap), Member = "CalculateSitOnSurfaceOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OBB), typeof(Plane), typeof(float)}, ReturnType = typeof(Vector3))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BoxMath), Member = "CalcBoxCornerPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Quaternion)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>))]
	[Token(Token = "0x6001119")]
	public List<Vector3> GetCornerPoints() { }

	[Address(RVA = "0x5623F0", Offset = "0x5615F0", Length = "0x17")]
	[CalledBy(Type = typeof(ObjectExtrudeGizmo), Member = "FitBoxToTargets", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Object2ObjectSnap), Member = "CalculateSnapResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Config)}, ReturnType = typeof(SnapResult))]
	[CalledBy(Type = typeof(Object2ObjectSnapData), Member = "GetWorldSnapAreaBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BoxFace)}, ReturnType = typeof(OBB))]
	[CalledBy(Type = typeof(ObjectAlign), Member = "AlignRootsToPlane", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(Plane)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectBounds), Member = "CalcSpriteWorldOBB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(OBB))]
	[CalledBy(Type = typeof(ObjectBounds), Member = "GetMeshWorldOBB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(OBB))]
	[CalledBy(Type = typeof(ObjectBounds), Member = "CalcHierarchyWorldOBB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(QueryConfig)}, ReturnType = typeof(OBB))]
	[CalledBy(Type = typeof(ObjectBounds), Member = "CalcWorldOBB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(QueryConfig)}, ReturnType = typeof(OBB))]
	[CallerCount(Count = 8)]
	[Token(Token = "0x6001116")]
	public static OBB GetInvalid() { }

	[Address(RVA = "0x562410", Offset = "0x561610", Length = "0x3A9")]
	[CalledBy(Type = typeof(SceneTree), Member = "RaycastSpriteObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(GameObject)}, ReturnType = typeof(GameObjectRayHit))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Matrix4x4), Member = "TRS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4Ex), Member = "GetNormalizedAxes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(Vector3[]))]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x600111C")]
	public Vector3 GetPointFaceNormal(Vector3 pointOnFace) { }

	[Address(RVA = "0x5627C0", Offset = "0x5619C0", Length = "0xCD")]
	[CalledBy(Type = typeof(GraphicsEx), Member = "DrawWireBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OBB)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Matrix4x4), Member = "TRS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6001118")]
	public Matrix4x4 GetUnitBoxTransform() { }

	[Address(RVA = "0x552E50", Offset = "0x552050", Length = "0x2F")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001117")]
	public void Inflate(float amount) { }

	[Address(RVA = "0x562890", Offset = "0x561A90", Length = "0x120")]
	[CalledBy(Type = typeof(SceneTree), Member = "OverlapBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OBB), typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BoxMath), Member = "BoxIntersectsBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Quaternion), typeof(Vector3), typeof(Vector3), typeof(Quaternion)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600111D")]
	public bool IntersectsOBB(OBB otherOBB) { }

	[Address(RVA = "0x5629B0", Offset = "0x561BB0", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OBB), Member = "GetClosestPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Sphere), Member = "ContainsPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600111F")]
	public bool IntersectsSphere(Sphere sphere) { }

	[Address(RVA = "0x3B9470", Offset = "0x3B8670", Length = "0x10")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001103")]
	public void set_Center(Vector3 value) { }

	[Address(RVA = "0x5131E0", Offset = "0x5123E0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001108")]
	public void set_Rotation(Quaternion value) { }

	[Address(RVA = "0x43C340", Offset = "0x43B540", Length = "0xF")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001105")]
	public void set_Size(Vector3 value) { }

}

