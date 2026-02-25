namespace RLD;

[Token(Token = "0x200017E")]
public struct AABB
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000675")]
	private Vector3 _size; //Field offset: 0x0
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000676")]
	private Vector3 _center; //Field offset: 0xC
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000677")]
	private bool _isValid; //Field offset: 0x18

	[Token(Token = "0x17000575")]
	public Vector3 Center
	{
		[Address(RVA = "0x3B9440", Offset = "0x3B8640", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010DB")]
		 get { } //Length: 19
		[Address(RVA = "0x3B9470", Offset = "0x3B8670", Length = "0x10")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010DC")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000577")]
	public Vector3 Extents
	{
		[Address(RVA = "0x553770", Offset = "0x552970", Length = "0x3A")]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010DF")]
		 get { } //Length: 58
	}

	[Token(Token = "0x17000574")]
	public bool IsValid
	{
		[Address(RVA = "0x2FBD80", Offset = "0x2FAF80", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010DA")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000579")]
	public Vector3 Max
	{
		[Address(RVA = "0x5537B0", Offset = "0x5529B0", Length = "0x53")]
		[CalledBy(Type = typeof(RTScene), Member = "OverlapBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OBB), typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Token(Token = "0x60010E2")]
		 get { } //Length: 83
		[Address(RVA = "0x553870", Offset = "0x552A70", Length = "0x121")]
		[CalledBy(Type = typeof(AABB), Member = "Encapsulate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AABB), Member = "Encapsulate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AABB)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Token(Token = "0x60010E3")]
		 set { } //Length: 289
	}

	[Token(Token = "0x17000578")]
	public Vector3 Min
	{
		[Address(RVA = "0x553810", Offset = "0x552A10", Length = "0x5F")]
		[CalledBy(Type = typeof(RTScene), Member = "OverlapBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OBB), typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Token(Token = "0x60010E0")]
		 get { } //Length: 95
		[Address(RVA = "0x5539A0", Offset = "0x552BA0", Length = "0x117")]
		[CalledBy(Type = typeof(AABB), Member = "Encapsulate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(AABB), Member = "Encapsulate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AABB)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Token(Token = "0x60010E1")]
		 set { } //Length: 279
	}

	[Token(Token = "0x17000576")]
	public Vector3 Size
	{
		[Address(RVA = "0x43C320", Offset = "0x43B520", Length = "0x12")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010DD")]
		 get { } //Length: 18
		[Address(RVA = "0x43C340", Offset = "0x43B540", Length = "0xF")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60010DE")]
		 set { } //Length: 15
	}

	[Address(RVA = "0x553450", Offset = "0x552650", Length = "0x24")]
	[CalledBy(Type = typeof(TorusMath), Member = "CalcCylModelAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(AABB))]
	[CalledBy(Type = typeof(TorusMath), Member = "CalcCylAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(Quaternion)}, ReturnType = typeof(AABB))]
	[CalledBy(Type = typeof(BoxShape3D), Member = "GetAABB", ReturnType = typeof(AABB))]
	[CalledBy(Type = typeof(CylinderShape3D), Member = "GetModelAABB", ReturnType = typeof(AABB))]
	[CalledBy(Type = typeof(CylinderShape3D), Member = "GetAABB", ReturnType = typeof(AABB))]
	[CalledBy(Type = typeof(SphereShape3D), Member = "GetAABB", ReturnType = typeof(AABB))]
	[CalledBy(Type = typeof(TorusShape3D), Member = "GetAABB", ReturnType = typeof(AABB))]
	[CalledBy(Type = typeof(Object2ObjectSnapData), Member = "BuildVertOverlapAABBs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Sprite), typeof(RTMesh)}, ReturnType = typeof(System.Collections.Generic.List`1<RLD.AABB>))]
	[CalledBy(Type = typeof(ObjectBounds), Member = "CalcModelAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(QueryConfig), typeof(GameObjectType)}, ReturnType = typeof(AABB))]
	[CallerCount(Count = 9)]
	[Token(Token = "0x60010E4")]
	public AABB(Vector3 center, Vector3 size) { }

	[Address(RVA = "0x553090", Offset = "0x552290", Length = "0x47")]
	[CalledBy(Type = typeof(RTMesh), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectBounds), Member = "CalcMeshModelAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(AABB))]
	[CalledBy(Type = typeof(ObjectBounds), Member = "CalcModelAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(QueryConfig), typeof(GameObjectType)}, ReturnType = typeof(AABB))]
	[CallerCount(Count = 3)]
	[Token(Token = "0x60010E5")]
	public AABB(Bounds bounds) { }

	[Address(RVA = "0x5530E0", Offset = "0x5522E0", Length = "0x36F")]
	[CalledBy(Type = typeof(PyramidShape3D), Member = "GetAABB", ReturnType = typeof(AABB))]
	[CalledBy(Type = typeof(Object2ObjectSnapData), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(TriangPrismShape3D), Member = "GetAABB", ReturnType = typeof(AABB))]
	[CalledBy(Type = typeof(SegmentShape3D), Member = "GetAABB", ReturnType = typeof(AABB))]
	[CalledBy(Type = typeof(RightAngTriangle3D), Member = "GetAABB", ReturnType = typeof(AABB))]
	[CalledBy(Type = typeof(QuadShape3D), Member = "GetAABB", ReturnType = typeof(AABB))]
	[CalledBy(Type = typeof(ConeShape3D), Member = "GetAABB", ReturnType = typeof(AABB))]
	[CalledBy(Type = typeof(EqTriangle3D), Member = "GetAABB", ReturnType = typeof(AABB))]
	[CalledBy(Type = typeof(ArcShape3D), Member = "OnBorderPointsFoundDirty", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTScene), Member = "OverlapBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OBB), typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MeshVertexChunk), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>), typeof(Mesh)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CameraEx), Member = "CalculateOrthoAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(AABB))]
	[CalledBy(Type = typeof(CameraEx), Member = "CalculateFrustumAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(AABB))]
	[CalledBy(Type = typeof(CameraViewVolume), Member = "FromCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CircleShape3D), Member = "GetAABB", ReturnType = typeof(AABB))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60010E6")]
	public AABB(IEnumerable<Vector3> pointCloud) { }

	[Address(RVA = "0x553480", Offset = "0x552680", Length = "0x2E3")]
	[CalledBy(Type = typeof(SpriteRendererEx), Member = "GetModelSpaceAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteRenderer)}, ReturnType = typeof(AABB))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60010E7")]
	public AABB(IEnumerable<Vector2> pointCloud) { }

	[Address(RVA = "0x551D90", Offset = "0x550F90", Length = "0x21B")]
	[CalledBy(Type = typeof(SpriteRendererEx), Member = "IsPixelFullyTransparent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteRenderer), typeof(Vector3)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Matrix4x4), Member = "TRS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "get_inverse", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60010EF")]
	public bool ContainsPoint(Vector3 point) { }

	[Address(RVA = "0x551FB0", Offset = "0x5511B0", Length = "0x213")]
	[CalledBy(Type = typeof(ObjectExtrudeGizmo), Member = "FitBoxToTargets", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "GetTargetObjectGroupWorldAABB", ReturnType = typeof(AABB))]
	[CalledBy(Type = typeof(RTScene), Member = "CalculateBounds", ReturnType = typeof(AABB))]
	[CalledBy(Type = typeof(ObjectBounds), Member = "CalcObjectCollectionWorldAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>), typeof(QueryConfig)}, ReturnType = typeof(AABB))]
	[CalledBy(Type = typeof(ObjectBounds), Member = "CalcHierarchyCollectionWorldAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(QueryConfig)}, ReturnType = typeof(AABB))]
	[CalledBy(Type = typeof(ObjectBounds), Member = "CalcHierarchyModelAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(QueryConfig)}, ReturnType = typeof(AABB))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "Render_SystemCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(AABB), Member = "set_Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AABB), Member = "set_Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Token(Token = "0x60010ED")]
	public void Encapsulate(AABB aabb) { }

	[Address(RVA = "0x5521D0", Offset = "0x5513D0", Length = "0x1D4")]
	[CalledBy(Type = typeof(OBB), Member = "Encapsulate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OBB)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(AABB), Member = "Encapsulate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60010EC")]
	public void Encapsulate(IEnumerable<Vector3> points) { }

	[Address(RVA = "0x5523B0", Offset = "0x5515B0", Length = "0x158")]
	[CalledBy(Type = typeof(AABB), Member = "Encapsulate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArcShape3D), Member = "OnBorderPointsFoundDirty", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConeShape3D), Member = "GetAABB", ReturnType = typeof(AABB))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(AABB), Member = "set_Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AABB), Member = "set_Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Token(Token = "0x60010EB")]
	public void Encapsulate(Vector3 point) { }

	[Address(RVA = "0x3B9440", Offset = "0x3B8640", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010DB")]
	public Vector3 get_Center() { }

	[Address(RVA = "0x553770", Offset = "0x552970", Length = "0x3A")]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010DF")]
	public Vector3 get_Extents() { }

	[Address(RVA = "0x2FBD80", Offset = "0x2FAF80", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010DA")]
	public bool get_IsValid() { }

	[Address(RVA = "0x5537B0", Offset = "0x5529B0", Length = "0x53")]
	[CalledBy(Type = typeof(RTScene), Member = "OverlapBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OBB), typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x60010E2")]
	public Vector3 get_Max() { }

	[Address(RVA = "0x553810", Offset = "0x552A10", Length = "0x5F")]
	[CalledBy(Type = typeof(RTScene), Member = "OverlapBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OBB), typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Token(Token = "0x60010E0")]
	public Vector3 get_Min() { }

	[Address(RVA = "0x43C320", Offset = "0x43B520", Length = "0x12")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010DD")]
	public Vector3 get_Size() { }

	[Address(RVA = "0x552510", Offset = "0x551710", Length = "0xCC")]
	[CalledBy(Type = typeof(AABB), Member = "GetScreenCenterAndCornerPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AABB), Member = "GetCornerPoints", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60010F1")]
	public List<Vector3> GetCenterAndCornerPoints() { }

	[Address(RVA = "0x5525E0", Offset = "0x5517E0", Length = "0xE1")]
	[CalledBy(Type = typeof(GraphicsEx), Member = "DrawWireCornerBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AABB), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AABB), Member = "GetCenterAndCornerPoints", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>))]
	[CalledBy(Type = typeof(AABB), Member = "GetScreenCornerPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>))]
	[CalledBy(Type = typeof(ObjectSurfaceSnap), Member = "CalculateSitOnSurfaceOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AABB), typeof(Plane), typeof(float)}, ReturnType = typeof(Vector3))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(BoxMath), Member = "CalcBoxCornerPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Quaternion)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>))]
	[Token(Token = "0x60010F0")]
	public List<Vector3> GetCornerPoints() { }

	[Address(RVA = "0x5526D0", Offset = "0x5518D0", Length = "0x13")]
	[CalledBy(Type = typeof(ObjectBounds), Member = "CalcSpriteModelAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(AABB))]
	[CalledBy(Type = typeof(ObjectExtrudeGizmo), Member = "FitBoxToTargets", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectTransformGizmo), Member = "GetTargetObjectGroupWorldAABB", ReturnType = typeof(AABB))]
	[CalledBy(Type = typeof(Object2ObjectSnapData), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Object2ObjectSnapData), Member = "BuildVertOverlapAABBs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Sprite), typeof(RTMesh)}, ReturnType = typeof(System.Collections.Generic.List`1<RLD.AABB>))]
	[CalledBy(Type = typeof(ObjectBounds), Member = "CalcSpriteWorldOBB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(OBB))]
	[CalledBy(Type = typeof(ObjectBounds), Member = "CalcSpriteWorldAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(AABB))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "Render_SystemCall", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectBounds), Member = "CalcObjectCollectionWorldAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>), typeof(QueryConfig)}, ReturnType = typeof(AABB))]
	[CalledBy(Type = typeof(ObjectBounds), Member = "CalcHierarchyCollectionWorldAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(QueryConfig)}, ReturnType = typeof(AABB))]
	[CalledBy(Type = typeof(ObjectBounds), Member = "CalcHierarchyWorldAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(QueryConfig)}, ReturnType = typeof(AABB))]
	[CalledBy(Type = typeof(ObjectBounds), Member = "CalcMeshModelAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(AABB))]
	[CalledBy(Type = typeof(ObjectBounds), Member = "CalcModelAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(QueryConfig), typeof(GameObjectType)}, ReturnType = typeof(AABB))]
	[CalledBy(Type = typeof(RTObjectSelection), Member = "GetWorldAABB", ReturnType = typeof(AABB))]
	[CallerCount(Count = 17)]
	[Token(Token = "0x60010E8")]
	public static AABB GetInvalid() { }

	[Address(RVA = "0x5526F0", Offset = "0x5518F0", Length = "0x25E")]
	[CalledBy(Type = typeof(MeshVertexChunkCollection), Member = "GetWorldVertChunkClosestToScreenPt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Matrix4x4), typeof(Camera)}, ReturnType = typeof(MeshVertexChunk))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AABB), Member = "GetCenterAndCornerPoints", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "WorldToScreenPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60010F3")]
	public List<Vector2> GetScreenCenterAndCornerPoints(Camera camera) { }

	[Address(RVA = "0x552950", Offset = "0x551B50", Length = "0x25E")]
	[CalledBy(Type = typeof(AABB), Member = "GetScreenRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(Rect))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AABB), Member = "GetCornerPoints", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Camera), Member = "WorldToScreenPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60010F2")]
	public List<Vector2> GetScreenCornerPoints(Camera camera) { }

	[Address(RVA = "0x552BB0", Offset = "0x551DB0", Length = "0x1B5")]
	[CalledBy(Type = typeof(MeshVertexChunkCollection), Member = "GetWorldChunksHoveredByPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Matrix4x4), typeof(Camera)}, ReturnType = typeof(System.Collections.Generic.List`1<RLD.MeshVertexChunk>))]
	[CalledBy(Type = typeof(ObjectBounds), Member = "CalcScreenRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Camera), typeof(QueryConfig)}, ReturnType = typeof(Rect))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AABB), Member = "GetScreenCornerPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60010F4")]
	public Rect GetScreenRectangle(Camera camera) { }

	[Address(RVA = "0x552D70", Offset = "0x551F70", Length = "0xD7")]
	[CalledBy(Type = typeof(GraphicsEx), Member = "DrawWireBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AABB)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Matrix4x4), Member = "TRS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Token(Token = "0x60010F5")]
	public Matrix4x4 GetUnitBoxTransform() { }

	[Address(RVA = "0x552E50", Offset = "0x552050", Length = "0x2F")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010E9")]
	public void Inflate(float amount) { }

	[Address(RVA = "0x552E80", Offset = "0x552080", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60010EA")]
	public void Inflate(Vector3 amount) { }

	[Address(RVA = "0x552EC0", Offset = "0x5520C0", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60010F7")]
	private void RecalculateCenterAndSize(Vector3 min, Vector3 max) { }

	[Address(RVA = "0x3B9470", Offset = "0x3B8670", Length = "0x10")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010DC")]
	public void set_Center(Vector3 value) { }

	[Address(RVA = "0x553870", Offset = "0x552A70", Length = "0x121")]
	[CalledBy(Type = typeof(AABB), Member = "Encapsulate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AABB), Member = "Encapsulate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AABB)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x60010E3")]
	public void set_Max(Vector3 value) { }

	[Address(RVA = "0x5539A0", Offset = "0x552BA0", Length = "0x117")]
	[CalledBy(Type = typeof(AABB), Member = "Encapsulate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AABB), Member = "Encapsulate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AABB)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x60010E1")]
	public void set_Min(Vector3 value) { }

	[Address(RVA = "0x43C340", Offset = "0x43B540", Length = "0xF")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60010DE")]
	public void set_Size(Vector3 value) { }

	[Address(RVA = "0x552F50", Offset = "0x552150", Length = "0x4A")]
	[CalledBy(Type = typeof(CameraViewVolume), Member = "CheckAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AABB)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CameraViewVolume), Member = "CheckAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(AABB)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CameraViewVolume), Member = "CheckAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(AABB), typeof(Plane[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(CameraEx), Member = "GetVisibleObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(CameraViewVolume), typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Token(Token = "0x60010F6")]
	public Bounds ToBounds() { }

	[Address(RVA = "0x552FA0", Offset = "0x5521A0", Length = "0xEC")]
	[CalledBy(Type = typeof(ObjectBounds), Member = "CalcObjectCollectionWorldAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>), typeof(QueryConfig)}, ReturnType = typeof(AABB))]
	[CalledBy(Type = typeof(TorusMath), Member = "CalcCylAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(float), typeof(float), typeof(float), typeof(Quaternion)}, ReturnType = typeof(AABB))]
	[CalledBy(Type = typeof(MeshVertexChunkCollection), Member = "GetWorldChunksHoveredByPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Matrix4x4), typeof(Camera)}, ReturnType = typeof(System.Collections.Generic.List`1<RLD.MeshVertexChunk>))]
	[CalledBy(Type = typeof(MeshVertexChunkCollection), Member = "GetWorldVertChunkClosestToScreenPt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Matrix4x4), typeof(Camera)}, ReturnType = typeof(MeshVertexChunk))]
	[CalledBy(Type = typeof(CylinderShape3D), Member = "GetAABB", ReturnType = typeof(AABB))]
	[CalledBy(Type = typeof(ObjectBounds), Member = "CalcSpriteWorldAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(AABB))]
	[CalledBy(Type = typeof(ObjectBounds), Member = "GetMeshWorldAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(AABB))]
	[CalledBy(Type = typeof(ObjectBounds), Member = "CalcHierarchyCollectionWorldAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.GameObject>), typeof(QueryConfig)}, ReturnType = typeof(AABB))]
	[CalledBy(Type = typeof(ObjectBounds), Member = "CalcHierarchyWorldAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(QueryConfig)}, ReturnType = typeof(AABB))]
	[CalledBy(Type = typeof(ObjectBounds), Member = "CalcWorldAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(QueryConfig)}, ReturnType = typeof(AABB))]
	[CalledBy(Type = typeof(ObjectBounds), Member = "CalcMeshWorldAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(AABB))]
	[CalledBy(Type = typeof(ObjectBounds), Member = "CalcHierarchyModelAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(QueryConfig)}, ReturnType = typeof(AABB))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(BoxMath), Member = "TransformBox", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Matrix4x4), typeof(Vector3&), typeof(Vector3&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x60010EE")]
	public void Transform(Matrix4x4 transformMatrix) { }

}

