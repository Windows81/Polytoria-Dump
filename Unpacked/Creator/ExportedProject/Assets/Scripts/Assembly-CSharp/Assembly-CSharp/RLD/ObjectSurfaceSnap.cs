namespace RLD;

[Token(Token = "0x200028C")]
public class ObjectSurfaceSnap
{
	[Token(Token = "0x2000291")]
	private class MeshSurfaceRaycaster : SurfaceRaycaster
	{

		[Address(RVA = "0x3E7A20", Offset = "0x3E6C20", Length = "0x44")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60018E8")]
		public MeshSurfaceRaycaster(GameObject surfaceObject, bool raycastReverse) { }

		[Address(RVA = "0x3E7980", Offset = "0x3E6B80", Length = "0x95")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(MonoSingleton`1), Member = "get_Get", ReturnType = "T")]
		[Calls(Type = typeof(RTScene), Member = "RaycastMeshObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(GameObject)}, ReturnType = typeof(GameObjectRayHit))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60018E9")]
		public virtual GameObjectRayHit Raycast(Ray ray) { }

	}

	[Token(Token = "0x200028E")]
	internal struct SnapConfig
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009F2")]
		public bool AlignAxis; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40009F3")]
		public TransformAxis AlignmentAxis; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40009F4")]
		public Type SurfaceType; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x40009F5")]
		public float OffsetFromSurface; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40009F6")]
		public Vector3 SurfaceHitPoint; //Field offset: 0x10
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x40009F7")]
		public Vector3 SurfaceHitNormal; //Field offset: 0x1C
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40009F8")]
		public Plane SurfaceHitPlane; //Field offset: 0x28
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40009F9")]
		public GameObject SurfaceObject; //Field offset: 0x38

		[Address(RVA = "0x3FF290", Offset = "0x3FE490", Length = "0x17")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x60018E4")]
		public bool IsSurfaceMesh() { }

	}

	[Token(Token = "0x200028F")]
	internal struct SnapResult
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009FA")]
		public bool Success; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40009FB")]
		public Plane SittingPlane; //Field offset: 0x4
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40009FC")]
		public Vector3 SittingPoint; //Field offset: 0x14

		[Address(RVA = "0x3FF2B0", Offset = "0x3FE4B0", Length = "0x1C")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60018E5")]
		public SnapResult(Plane sittingPlane, Vector3 sittingPoint) { }

	}

	[Token(Token = "0x2000290")]
	private abstract class SurfaceRaycaster
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40009FD")]
		protected GameObject _surfaceObject; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40009FE")]
		protected bool _raycastReverse; //Field offset: 0x18

		[Address(RVA = "0x3E7A20", Offset = "0x3E6C20", Length = "0x44")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60018E6")]
		public SurfaceRaycaster(GameObject surfaceObject, bool raycastReverse) { }

		[Token(Token = "0x60018E7")]
		public abstract GameObjectRayHit Raycast(Ray ray) { }

	}

	[Token(Token = "0x200028D")]
	internal enum Type
	{
		UnityTerrain = 0,
		Mesh = 1,
		TerrainMesh = 2,
		SphericalMesh = 3,
		SceneGrid = 4,
	}


	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60018E3")]
	public ObjectSurfaceSnap() { }

	[Address(RVA = "0x3EC9F0", Offset = "0x3EBBF0", Length = "0x412")]
	[CalledBy(Type = typeof(ObjectSurfaceSnap), Member = "SnapHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(SnapConfig)}, ReturnType = typeof(SnapResult))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ObjectSurfaceSnap), Member = "CreateSurfaceRaycaster", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(GameObject), typeof(bool)}, ReturnType = typeof(SurfaceRaycaster))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AF70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60018E1")]
	public static Vector3 CalculateEmbedVector(List<Vector3> embedPoints, GameObject embedSurface, Vector3 embedDirection, Type surfaceType) { }

	[Address(RVA = "0x3ECE10", Offset = "0x3EC010", Length = "0x184")]
	[CalledBy(Type = typeof(ObjectSpawnUtil), Member = "SpawnInFrontOfCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(Camera), typeof(Config)}, ReturnType = typeof(GameObject))]
	[CalledBy(Type = typeof(ObjectSurfaceSnap), Member = "SnapHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(SnapConfig)}, ReturnType = typeof(SnapResult))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(OBB), Member = "GetCornerPoints", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>))]
	[Calls(Type = typeof(PlaneEx), Member = "GetFurthestPtBehind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Plane), typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(PlaneEx), Member = "GetClosestPtInFrontOrOnPlane", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Plane), typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(PlaneEx), Member = "ProjectPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Plane), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60018DF")]
	public static Vector3 CalculateSitOnSurfaceOffset(OBB obb, Plane surfacePlane, float offsetFromSurface) { }

	[Address(RVA = "0x3ECFA0", Offset = "0x3EC1A0", Length = "0x184")]
	[CalledBy(Type = typeof(Object2ObjectSnapSession), Member = "SnapTargets", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(AABB), Member = "GetCornerPoints", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>))]
	[Calls(Type = typeof(PlaneEx), Member = "GetFurthestPtBehind", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Plane), typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(PlaneEx), Member = "GetClosestPtInFrontOrOnPlane", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Plane), typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(PlaneEx), Member = "ProjectPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Plane), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60018E0")]
	public static Vector3 CalculateSitOnSurfaceOffset(AABB aabb, Plane surfacePlane, float offsetFromSurface) { }

	[Address(RVA = "0x3ED130", Offset = "0x3EC330", Length = "0x93")]
	[CalledBy(Type = typeof(ObjectSurfaceSnap), Member = "SnapHierarchy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(SnapConfig)}, ReturnType = typeof(SnapResult))]
	[CalledBy(Type = typeof(ObjectSurfaceSnap), Member = "CalculateEmbedVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>), typeof(GameObject), typeof(Vector3), typeof(Type)}, ReturnType = typeof(Vector3))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60018E2")]
	private static SurfaceRaycaster CreateSurfaceRaycaster(Type surfaceType, GameObject surfaceObject, bool raycastReverse) { }

	[Address(RVA = "0x3ED1D0", Offset = "0x3EC3D0", Length = "0x26BE")]
	[CalledBy(Type = typeof(PrefabSpawnSnap), Member = "OnInputDeviceMoved", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DeviceObjectGrabSession), Member = "SnapTargetsToSurface", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ObjectBounds), Member = "CalcHierarchyWorldOBB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(QueryConfig)}, ReturnType = typeof(OBB))]
	[Calls(Type = typeof(ObjectBounds), Member = "CalcMeshWorldAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(AABB))]
	[Calls(Type = typeof(Vector3Ex), Member = "GetPointCloudCenter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.Vector3>)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(TransformEx), Member = "Align", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(Vector3), typeof(TransformAxis)}, ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(ObjectSurfaceSnap), Member = "CalculateEmbedVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>), typeof(GameObject), typeof(Vector3), typeof(Type)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Vector3Ex), Member = "OffsetPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>), typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ObjectSurfaceSnap), Member = "CalculateSitOnSurfaceOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OBB), typeof(Plane), typeof(float)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(ObjectVertexCollect), Member = "CollectHierarchyVerts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject), typeof(BoxFace), typeof(float), typeof(float)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>))]
	[Calls(Type = typeof(BoxMath), Member = "GetMostAlignedFace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(BoxFace))]
	[Calls(Type = typeof(Vector3Ex), Member = "GetMaxAbsComp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Transform), Member = "get_lossyScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(ObjectSurfaceSnap), Member = "CreateSurfaceRaycaster", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(GameObject), typeof(bool)}, ReturnType = typeof(SurfaceRaycaster))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
	[Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PlaneEx), Member = "ProjectPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Plane), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(GameObjectEx), Member = "HierarchyHasSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObjectEx), Member = "HierarchyHasMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GameObject)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(QuaternionEx), Member = "RotatePoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Quaternion), typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>), typeof(Vector3)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60018DE")]
	public static SnapResult SnapHierarchy(GameObject root, SnapConfig snapConfig) { }

}

