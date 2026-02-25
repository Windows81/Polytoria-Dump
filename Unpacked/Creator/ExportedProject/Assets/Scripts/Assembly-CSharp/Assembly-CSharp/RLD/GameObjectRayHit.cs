namespace RLD;

[Token(Token = "0x2000201")]
public class GameObjectRayHit
{
	[CompilerGenerated]
	[Token(Token = "0x2000202")]
	private sealed class <>c
	{
		[Token(Token = "0x40007CA")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x40007CB")]
		public static Comparison<GameObjectRayHit> <>9__18_0; //Field offset: 0x8

		[Address(RVA = "0x5A5A70", Offset = "0x5A4C70", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60013B8")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60013B9")]
		public <>c() { }

		[Address(RVA = "0x5A59C0", Offset = "0x5A4BC0", Length = "0x38")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(float), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60013BA")]
		internal int <SortByHitDistance>b__18_0(GameObjectRayHit h0, GameObjectRayHit h1) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007C4")]
	private GameObject _hitObject; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40007C5")]
	private Vector3 _hitPoint; //Field offset: 0x18
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40007C6")]
	private float _hitEnter; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40007C7")]
	private Vector3 _hitNormal; //Field offset: 0x28
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40007C8")]
	private Plane _hitPlane; //Field offset: 0x34
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40007C9")]
	private MeshRayHit _meshRayHit; //Field offset: 0x48

	[Token(Token = "0x17000634")]
	public float HitEnter
	{
		[Address(RVA = "0x3B21B0", Offset = "0x3B13B0", Length = "0x6")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60013AE")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000635")]
	public Vector3 HitNormal
	{
		[Address(RVA = "0x3C1A50", Offset = "0x3C0C50", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60013AF")]
		 get { } //Length: 19
	}

	[Token(Token = "0x17000632")]
	public GameObject HitObject
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x60013AC")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000636")]
	public Plane HitPlane
	{
		[Address(RVA = "0x2DD270", Offset = "0x2DC470", Length = "0xB")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60013B0")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000633")]
	public Vector3 HitPoint
	{
		[Address(RVA = "0x2DD290", Offset = "0x2DC490", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60013AD")]
		 get { } //Length: 19
	}

	[Token(Token = "0x17000637")]
	public MeshRayHit MeshRayHit
	{
		[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x60013B1")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x594B50", Offset = "0x593D50", Length = "0x129")]
	[CalledBy(Type = typeof(GameObjectRayHit), Member = "Store", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.RaycastHit2D>), typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.RaycastHit>), typeof(System.Collections.Generic.List`1<RLD.GameObjectRayHit>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RTScene), Member = "RaycastMeshObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(GameObject)}, ReturnType = typeof(GameObjectRayHit))]
	[CalledBy(Type = typeof(SceneTree), Member = "RaycastMeshObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(GameObject)}, ReturnType = typeof(GameObjectRayHit))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RaycastHit), Member = "get_collider", ReturnType = typeof(Collider))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x60013B4")]
	public GameObjectRayHit(Ray hitRay, RaycastHit hit3D) { }

	[Address(RVA = "0x594EB0", Offset = "0x5940B0", Length = "0x140")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RaycastHit2D), Member = "get_collider", ReturnType = typeof(Collider2D))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x60013B5")]
	public GameObjectRayHit(Ray hitRay, RaycastHit2D hit2D) { }

	[Address(RVA = "0x594D90", Offset = "0x593F90", Length = "0x11B")]
	[CalledBy(Type = typeof(SceneTree), Member = "RaycastSpriteObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(GameObject)}, ReturnType = typeof(GameObjectRayHit))]
	[CalledBy(Type = typeof(SceneTree), Member = "RaycastAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(SceneRaycastPrecision), typeof(System.Collections.Generic.List`1<RLD.GameObjectRayHit>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Ray), Member = "GetPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60013B6")]
	public GameObjectRayHit(Ray hitRay, GameObject hitObject, Vector3 hitNormal, float hitEnter) { }

	[Address(RVA = "0x594C80", Offset = "0x593E80", Length = "0x103")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60013B7")]
	public GameObjectRayHit(Ray ray, GameObject hitObject, MeshRayHit meshRayHit) { }

	[Address(RVA = "0x3B21B0", Offset = "0x3B13B0", Length = "0x6")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013AE")]
	public float get_HitEnter() { }

	[Address(RVA = "0x3C1A50", Offset = "0x3C0C50", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013AF")]
	public Vector3 get_HitNormal() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013AC")]
	public GameObject get_HitObject() { }

	[Address(RVA = "0x2DD270", Offset = "0x2DC470", Length = "0xB")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013B0")]
	public Plane get_HitPlane() { }

	[Address(RVA = "0x2DD290", Offset = "0x2DC490", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013AD")]
	public Vector3 get_HitPoint() { }

	[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013B1")]
	public MeshRayHit get_MeshRayHit() { }

	[Address(RVA = "0x594320", Offset = "0x593520", Length = "0x117")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Comparison`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Sort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Comparison`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60013B2")]
	public static void SortByHitDistance(List<GameObjectRayHit> hits) { }

	[Address(RVA = "0x594440", Offset = "0x593640", Length = "0x703")]
	[CalledBy(Type = typeof(RTScene), Member = "RaycastAllObjects", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(SceneRaycastPrecision), typeof(System.Collections.Generic.List`1<RLD.GameObjectRayHit>)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RTScene), Member = "RaycastAllObjectsSorted", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(SceneRaycastPrecision), typeof(System.Collections.Generic.List`1<RLD.GameObjectRayHit>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RaycastHit2D), Member = "get_collider", ReturnType = typeof(Collider2D))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(GameObjectRayHit), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray), typeof(RaycastHit)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	[Token(Token = "0x60013B3")]
	public static void Store(Ray hitRay, IEnumerable<RaycastHit2D> hits2D, IEnumerable<RaycastHit> hits3D, List<GameObjectRayHit> hits) { }

}

