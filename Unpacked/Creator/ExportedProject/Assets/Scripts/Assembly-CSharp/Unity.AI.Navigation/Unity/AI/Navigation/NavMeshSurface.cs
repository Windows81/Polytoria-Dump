namespace Unity.AI.Navigation;

[AddComponentMenu("Navigation/NavMesh Surface", 30)]
[DefaultExecutionOrder(-102)]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.ai.navigation@2.0/manual/NavMeshSurface.html")]
[Token(Token = "0x2000009")]
public class NavMeshSurface : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x200000A")]
	private sealed class <>c
	{
		[Token(Token = "0x400004B")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400004C")]
		public static Predicate<NavMeshModifierVolume> <>9__86_0; //Field offset: 0x8
		[Token(Token = "0x400004D")]
		public static Predicate<NavMeshModifier> <>9__87_0; //Field offset: 0x10
		[Token(Token = "0x400004E")]
		public static Predicate<NavMeshBuildSource> <>9__87_1; //Field offset: 0x18
		[Token(Token = "0x400004F")]
		public static Predicate<NavMeshBuildSource> <>9__87_2; //Field offset: 0x20

		[Address(RVA = "0x1818720", Offset = "0x1817920", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600008E")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600008F")]
		public <>c() { }

		[Address(RVA = "0x1818530", Offset = "0x1817730", Length = "0x22")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000090")]
		internal bool <AppendModifierVolumes>b__86_0(NavMeshModifierVolume x) { }

		[Address(RVA = "0x1818530", Offset = "0x1817730", Length = "0x22")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000091")]
		internal bool <CollectSources>b__87_0(NavMeshModifier x) { }

		[Address(RVA = "0x1818560", Offset = "0x1817760", Length = "0xD5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(NavMeshBuildSource), Member = "get_component", ReturnType = typeof(Component))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000092")]
		internal bool <CollectSources>b__87_1(NavMeshBuildSource x) { }

		[Address(RVA = "0x1818640", Offset = "0x1817840", Length = "0xD5")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(NavMeshBuildSource), Member = "get_component", ReturnType = typeof(Component))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000093")]
		internal bool <CollectSources>b__87_2(NavMeshBuildSource x) { }

	}

	[Token(Token = "0x400004A")]
	private static readonly List<NavMeshSurface> s_NavMeshSurfaces; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000035")]
	private byte m_SerializedVersion; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x4000036")]
	private int m_AgentTypeID; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000037")]
	private CollectObjects m_CollectObjects; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[Token(Token = "0x4000038")]
	private Vector3 m_Size; //Field offset: 0x2C
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000039")]
	private Vector3 m_Center; //Field offset: 0x38
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	[Token(Token = "0x400003A")]
	private LayerMask m_LayerMask; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x400003B")]
	private NavMeshCollectGeometry m_UseGeometry; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	[Token(Token = "0x400003C")]
	private int m_DefaultArea; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x400003D")]
	private bool m_GenerateLinks; //Field offset: 0x50
	[FieldOffset(Offset = "0x51")]
	[SerializeField]
	[Token(Token = "0x400003E")]
	private bool m_IgnoreNavMeshAgent; //Field offset: 0x51
	[FieldOffset(Offset = "0x52")]
	[SerializeField]
	[Token(Token = "0x400003F")]
	private bool m_IgnoreNavMeshObstacle; //Field offset: 0x52
	[FieldOffset(Offset = "0x53")]
	[SerializeField]
	[Token(Token = "0x4000040")]
	private bool m_OverrideTileSize; //Field offset: 0x53
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	[Token(Token = "0x4000041")]
	private int m_TileSize; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Token(Token = "0x4000042")]
	private bool m_OverrideVoxelSize; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	[Token(Token = "0x4000043")]
	private float m_VoxelSize; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x4000044")]
	private float m_MinRegionArea; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[FormerlySerializedAs("m_BakedNavMeshData")]
	[SerializeField]
	[Token(Token = "0x4000045")]
	private NavMeshData m_NavMeshData; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	[Token(Token = "0x4000046")]
	private bool m_BuildHeightMesh; //Field offset: 0x70
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x4000047")]
	private NavMeshDataInstance m_NavMeshDataInstance; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000048")]
	private Vector3 m_LastPosition; //Field offset: 0x78
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x4000049")]
	private Quaternion m_LastRotation; //Field offset: 0x84

	[Token(Token = "0x1700002C")]
	public static List<NavMeshSurface> activeSurfaces
	{
		[Address(RVA = "0x1818480", Offset = "0x1817680", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000076")]
		 get { } //Length: 78
	}

	[Token(Token = "0x1700001B")]
	public int agentTypeID
	{
		[Address(RVA = "0x309510", Offset = "0x308710", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000055")]
		 get { } //Length: 4
		[Address(RVA = "0x309520", Offset = "0x308720", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000056")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000029")]
	public bool buildHeightMesh
	{
		[Address(RVA = "0x521560", Offset = "0x520760", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000071")]
		 get { } //Length: 5
		[Address(RVA = "0x522A10", Offset = "0x521C10", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000072")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700001E")]
	public Vector3 center
	{
		[Address(RVA = "0x3B8800", Offset = "0x3B7A00", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600005B")]
		 get { } //Length: 19
		[Address(RVA = "0x3B8880", Offset = "0x3B7A80", Length = "0x10")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600005C")]
		 set { } //Length: 16
	}

	[Token(Token = "0x1700001C")]
	public CollectObjects collectObjects
	{
		[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000057")]
		 get { } //Length: 4
		[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000058")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000021")]
	public int defaultArea
	{
		[Address(RVA = "0x5B9B30", Offset = "0x5B8D30", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000061")]
		 get { } //Length: 4
		[Address(RVA = "0x5B9B40", Offset = "0x5B8D40", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000062")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000022")]
	public bool ignoreNavMeshAgent
	{
		[Address(RVA = "0x3EB940", Offset = "0x3EAB40", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000063")]
		 get { } //Length: 5
		[Address(RVA = "0x3EB980", Offset = "0x3EAB80", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000064")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000023")]
	public bool ignoreNavMeshObstacle
	{
		[Address(RVA = "0x3EB930", Offset = "0x3EAB30", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000065")]
		 get { } //Length: 5
		[Address(RVA = "0x3EB970", Offset = "0x3EAB70", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000066")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700001F")]
	public LayerMask layerMask
	{
		[Address(RVA = "0x1060130", Offset = "0x105F330", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600005D")]
		 get { } //Length: 4
		[Address(RVA = "0x124FA60", Offset = "0x124EC60", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600005E")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000028")]
	public float minRegionArea
	{
		[Address(RVA = "0x53C060", Offset = "0x53B260", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600006F")]
		 get { } //Length: 6
		[Address(RVA = "0x18184E0", Offset = "0x18176E0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000070")]
		 set { } //Length: 6
	}

	[Token(Token = "0x1700002A")]
	public NavMeshData navMeshData
	{
		[Address(RVA = "0x369270", Offset = "0x368470", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000073")]
		 get { } //Length: 5
		[Address(RVA = "0x3692A0", Offset = "0x3684A0", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000074")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700002B")]
	internal NavMeshDataInstance navMeshDataInstance
	{
		[Address(RVA = "0x16BC4E0", Offset = "0x16BB6E0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000075")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x17000024")]
	public bool overrideTileSize
	{
		[Address(RVA = "0x18184D0", Offset = "0x18176D0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000067")]
		 get { } //Length: 5
		[Address(RVA = "0x18184F0", Offset = "0x18176F0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6000068")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000026")]
	public bool overrideVoxelSize
	{
		[Address(RVA = "0x3F5830", Offset = "0x3F4A30", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600006B")]
		 get { } //Length: 5
		[Address(RVA = "0x12CDBA0", Offset = "0x12CCDA0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600006C")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700001D")]
	public Vector3 size
	{
		[Address(RVA = "0x573970", Offset = "0x572B70", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000059")]
		 get { } //Length: 19
		[Address(RVA = "0x1818500", Offset = "0x1817700", Length = "0x10")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600005A")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000025")]
	public int tileSize
	{
		[Address(RVA = "0x3EB950", Offset = "0x3EAB50", Length = "0x4")]
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000069")]
		 get { } //Length: 4
		[Address(RVA = "0x1818510", Offset = "0x1817710", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600006A")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000020")]
	public NavMeshCollectGeometry useGeometry
	{
		[Address(RVA = "0x309620", Offset = "0x308820", Length = "0x4")]
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		[Token(Token = "0x600005F")]
		 get { } //Length: 4
		[Address(RVA = "0x309680", Offset = "0x308880", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000060")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000027")]
	public float voxelSize
	{
		[Address(RVA = "0x58DEC0", Offset = "0x58D0C0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600006D")]
		 get { } //Length: 6
		[Address(RVA = "0x1818520", Offset = "0x1817720", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600006E")]
		 set { } //Length: 6
	}

	[Address(RVA = "0x1818310", Offset = "0x1817510", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600008D")]
	private static NavMeshSurface() { }

	[Address(RVA = "0x18183A0", Offset = "0x18175A0", Length = "0xDE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x600008C")]
	public NavMeshSurface() { }

	[Address(RVA = "0x56EAE0", Offset = "0x56DCE0", Length = "0x31")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000085")]
	private static Vector3 Abs(Vector3 v) { }

	[Address(RVA = "0x1814F90", Offset = "0x1814190", Length = "0x175")]
	[CalledBy(Type = typeof(NavMeshSurface), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NavMeshSurface), Member = "BuildNavMesh", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NavMeshSurface), Member = "UpdateActive", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NavMeshSurface), Member = "UpdateDataIfTransformChanged", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(NavMeshDataInstance), Member = "get_valid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NavMesh), Member = "AddNavMeshData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavMeshData), typeof(Vector3), typeof(Quaternion)}, ReturnType = typeof(NavMeshDataInstance))]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NavMeshDataInstance), Member = "set_owner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Token(Token = "0x600007B")]
	public void AddData() { }

	[Address(RVA = "0x1815110", Offset = "0x1814310", Length = "0x6A1")]
	[CalledBy(Type = typeof(NavMeshSurface), Member = "CollectSources", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.AI.NavMeshBuildSource>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Matrix4x4), Member = "TRS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Transform), Member = "get_lossyScale", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "TransformPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(NavMeshModifierVolume), Member = "AffectsAgentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GameObject), Member = "get_layer", ReturnType = typeof(int))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Predicate`1<System.Object>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NavMeshBuildSource), Member = "set_transform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Component), Member = "GetComponentsInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800D39C0")]
	[CallsDeduplicatedMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000083")]
	private void AppendModifierVolumes(ref List<NavMeshBuildSource>& sources) { }

	[Address(RVA = "0x18157C0", Offset = "0x18149C0", Length = "0x2DA")]
	[CalledBy(Type = "Polytoria.Datamodel.Environment", Member = "RebuildNavMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(NavMeshDataInstance), Member = "Remove", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "set_name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NavMeshBuilder), Member = "BuildNavMeshData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavMeshBuildSettings), typeof(System.Collections.Generic.List`1<UnityEngine.AI.NavMeshBuildSource>), typeof(Bounds), typeof(Vector3), typeof(Quaternion)}, ReturnType = typeof(NavMeshData))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(NavMeshSurface), Member = "AddData", ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(NavMeshSurface), Member = "GetBuildSettings", ReturnType = typeof(NavMeshBuildSettings))]
	[Calls(Type = typeof(NavMeshSurface), Member = "CalculateWorldBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.AI.NavMeshBuildSource>)}, ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NavMeshSurface), Member = "CollectSources", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.AI.NavMeshBuildSource>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Token(Token = "0x600007E")]
	public void BuildNavMesh() { }

	[Address(RVA = "0x1815AA0", Offset = "0x1814CA0", Length = "0x950")]
	[CalledBy(Type = typeof(NavMeshSurface), Member = "BuildNavMesh", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NavMeshSurface), Member = "UpdateNavMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavMeshData)}, ReturnType = typeof(AsyncOperation))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NavMeshBuildSource), Member = "get_shape", ReturnType = typeof(NavMeshBuildSourceShape))]
	[Calls(Type = typeof(Bounds), Member = "Expand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NavMeshBuildSource), Member = "get_size", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(TerrainData), Member = "get_size", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Bounds), Member = "Encapsulate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bounds)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NavMeshSurface), Member = "GetWorldBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Bounds)}, ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Mesh), Member = "get_bounds", ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(NavMeshBuildSource), Member = "get_transform", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<UnityEngine.AI.NavMeshBuildSource>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.AI.NavMeshBuildSource>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.List`1+Enumerator<UnityEngine.AI.NavMeshBuildSource>))]
	[Calls(Type = typeof(Matrix4x4), Member = "get_inverse", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "TRS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NavMeshBuildSource), Member = "get_sourceObject", ReturnType = typeof(Object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000087")]
	private Bounds CalculateWorldBounds(List<NavMeshBuildSource> sources) { }

	[Address(RVA = "0x1816410", Offset = "0x1815610", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	[Token(Token = "0x6000078")]
	private static void ClearNavMeshSurfaces() { }

	[Address(RVA = "0x1816590", Offset = "0x1815790", Length = "0xAC4")]
	[CalledBy(Type = typeof(NavMeshSurface), Member = "BuildNavMesh", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NavMeshSurface), Member = "UpdateNavMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavMeshData)}, ReturnType = typeof(AsyncOperation))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(NavMeshBuildMarkup), Member = "set_ignoreFromBuild", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NavMeshBuildMarkup), Member = "set_applyToChildren", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NavMeshBuildMarkup), Member = "set_overrideGenerateLinks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NavMeshBuildMarkup), Member = "set_generateLinks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800D3AA0")]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(NavMesh), Member = "GetSettingsByID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(NavMeshBuildSettings))]
	[Calls(Type = typeof(Matrix4x4), Member = "TRS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(NavMeshBuildMarkup), Member = "set_overrideArea", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NavMeshSurface), Member = "GetWorldBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Bounds)}, ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(NavMeshBuilder), Member = "CollectSources", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bounds), typeof(int), typeof(NavMeshCollectGeometry), typeof(int), typeof(bool), typeof(System.Collections.Generic.List`1<UnityEngine.AI.NavMeshBuildMarkup>), typeof(bool), typeof(System.Collections.Generic.List`1<UnityEngine.AI.NavMeshBuildSource>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NavMeshBuilder), Member = "CollectSources", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(int), typeof(NavMeshCollectGeometry), typeof(int), typeof(bool), typeof(System.Collections.Generic.List`1<UnityEngine.AI.NavMeshBuildMarkup>), typeof(bool), typeof(System.Collections.Generic.List`1<UnityEngine.AI.NavMeshBuildSource>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Predicate`1<UnityEngine.AI.NavMeshBuildSource>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(NavMeshBuildMarkup), Member = "set_root", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NavMeshModifier), Member = "AffectsAgentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.AI.NavMeshBuildSource>), Member = "RemoveAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Predicate`1<UnityEngine.AI.NavMeshBuildSource>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(GameObject), Member = "get_layer", ReturnType = typeof(int))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "RemoveAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Predicate`1<System.Object>)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "GetComponentsInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(NavMeshSurface), Member = "AppendModifierVolumes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(List`1<NavMeshBuildSource>&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 13)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000084")]
	private List<NavMeshBuildSource> CollectSources() { }

	[Address(RVA = "0x18164A0", Offset = "0x18156A0", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NavMeshBuilder), Member = "CollectSources", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(int), typeof(NavMeshCollectGeometry), typeof(int), typeof(bool), typeof(System.Collections.Generic.List`1<UnityEngine.AI.NavMeshBuildMarkup>), typeof(bool), typeof(System.Collections.Generic.List`1<UnityEngine.AI.NavMeshBuildSource>)}, ReturnType = typeof(void))]
	[Token(Token = "0x600008B")]
	private void CollectSourcesInHierarchy(Transform root, int includedLayerMask, NavMeshCollectGeometry geometry, int areaByDefault, bool generateLinksByDefault, List<NavMeshBuildMarkup> markups, bool includeOnlyMarkedObjects, List<NavMeshBuildSource> results) { }

	[Address(RVA = "0x1816510", Offset = "0x1815710", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NavMeshBuilder), Member = "CollectSources", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bounds), typeof(int), typeof(NavMeshCollectGeometry), typeof(int), typeof(bool), typeof(System.Collections.Generic.List`1<UnityEngine.AI.NavMeshBuildMarkup>), typeof(bool), typeof(System.Collections.Generic.List`1<UnityEngine.AI.NavMeshBuildSource>)}, ReturnType = typeof(void))]
	[Token(Token = "0x600008A")]
	private void CollectSourcesInVolume(Bounds includedWorldBounds, int includedLayerMask, NavMeshCollectGeometry geometry, int areaByDefault, bool generateLinksByDefault, List<NavMeshBuildMarkup> markups, bool includeOnlyMarkedObjects, List<NavMeshBuildSource> results) { }

	[Address(RVA = "0x1818480", Offset = "0x1817680", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000076")]
	public static List<NavMeshSurface> get_activeSurfaces() { }

	[Address(RVA = "0x309510", Offset = "0x308710", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000055")]
	public int get_agentTypeID() { }

	[Address(RVA = "0x521560", Offset = "0x520760", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000071")]
	public bool get_buildHeightMesh() { }

	[Address(RVA = "0x3B8800", Offset = "0x3B7A00", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600005B")]
	public Vector3 get_center() { }

	[Address(RVA = "0x324340", Offset = "0x323540", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000057")]
	public CollectObjects get_collectObjects() { }

	[Address(RVA = "0x5B9B30", Offset = "0x5B8D30", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000061")]
	public int get_defaultArea() { }

	[Address(RVA = "0x3EB940", Offset = "0x3EAB40", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000063")]
	public bool get_ignoreNavMeshAgent() { }

	[Address(RVA = "0x3EB930", Offset = "0x3EAB30", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000065")]
	public bool get_ignoreNavMeshObstacle() { }

	[Address(RVA = "0x1060130", Offset = "0x105F330", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600005D")]
	public LayerMask get_layerMask() { }

	[Address(RVA = "0x53C060", Offset = "0x53B260", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600006F")]
	public float get_minRegionArea() { }

	[Address(RVA = "0x369270", Offset = "0x368470", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000073")]
	public NavMeshData get_navMeshData() { }

	[Address(RVA = "0x16BC4E0", Offset = "0x16BB6E0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000075")]
	internal NavMeshDataInstance get_navMeshDataInstance() { }

	[Address(RVA = "0x18184D0", Offset = "0x18176D0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000067")]
	public bool get_overrideTileSize() { }

	[Address(RVA = "0x3F5830", Offset = "0x3F4A30", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600006B")]
	public bool get_overrideVoxelSize() { }

	[Address(RVA = "0x573970", Offset = "0x572B70", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000059")]
	public Vector3 get_size() { }

	[Address(RVA = "0x3EB950", Offset = "0x3EAB50", Length = "0x4")]
	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000069")]
	public int get_tileSize() { }

	[Address(RVA = "0x309620", Offset = "0x308820", Length = "0x4")]
	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	[Token(Token = "0x600005F")]
	public NavMeshCollectGeometry get_useGeometry() { }

	[Address(RVA = "0x58DEC0", Offset = "0x58D0C0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600006D")]
	public float get_voxelSize() { }

	[Address(RVA = "0x1817060", Offset = "0x1816260", Length = "0x166")]
	[CalledBy(Type = typeof(NavMeshSurface), Member = "BuildNavMesh", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NavMeshSurface), Member = "UpdateNavMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavMeshData)}, ReturnType = typeof(AsyncOperation))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NavMesh), Member = "GetSettingsByID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(NavMeshBuildSettings))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NavMeshBuildSettings), Member = "set_overrideTileSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NavMeshBuildSettings), Member = "set_overrideVoxelSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NavMeshBuildSettings), Member = "set_buildHeightMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x600007D")]
	public NavMeshBuildSettings GetBuildSettings() { }

	[Address(RVA = "0x18171D0", Offset = "0x18163D0", Length = "0x108")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NavMesh), Member = "GetSettingsByID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(NavMeshBuildSettings))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000077")]
	private Bounds GetInflatedBounds() { }

	[Address(RVA = "0x18172E0", Offset = "0x18164E0", Length = "0x314")]
	[CalledBy(Type = typeof(NavMeshSurface), Member = "CollectSources", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.AI.NavMeshBuildSource>))]
	[CalledBy(Type = typeof(NavMeshSurface), Member = "CalculateWorldBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.AI.NavMeshBuildSource>)}, ReturnType = typeof(Bounds))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Token(Token = "0x6000086")]
	private static Bounds GetWorldBounds(Matrix4x4 mat, Bounds bounds) { }

	[Address(RVA = "0x1817600", Offset = "0x1816800", Length = "0x141")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000088")]
	private bool HasTransformChanged() { }

	[Address(RVA = "0x1817750", Offset = "0x1816950", Length = "0x1E1")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NavMeshDataInstance), Member = "Remove", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600007A")]
	private void OnDisable() { }

	[Address(RVA = "0x1817940", Offset = "0x1816B40", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NavMeshSurface), Member = "Register", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavMeshSurface)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NavMeshSurface), Member = "AddData", ReturnType = typeof(void))]
	[Token(Token = "0x6000079")]
	private void OnEnable() { }

	[Address(RVA = "0x18179A0", Offset = "0x1816BA0", Length = "0x266")]
	[CalledBy(Type = typeof(NavMeshSurface), Member = "OnEnable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000080")]
	private static void Register(NavMeshSurface surface) { }

	[Address(RVA = "0x1817C10", Offset = "0x1816E10", Length = "0x1F")]
	[CalledBy(Type = "Polytoria.Datamodel.Environment", Member = "RebuildNavMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Instance"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NavMeshDataInstance), Member = "Remove", ReturnType = typeof(void))]
	[Token(Token = "0x600007C")]
	public void RemoveData() { }

	[Address(RVA = "0x309520", Offset = "0x308720", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000056")]
	public void set_agentTypeID(int value) { }

	[Address(RVA = "0x522A10", Offset = "0x521C10", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000072")]
	public void set_buildHeightMesh(bool value) { }

	[Address(RVA = "0x3B8880", Offset = "0x3B7A80", Length = "0x10")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600005C")]
	public void set_center(Vector3 value) { }

	[Address(RVA = "0x324360", Offset = "0x323560", Length = "0x4")]
	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000058")]
	public void set_collectObjects(CollectObjects value) { }

	[Address(RVA = "0x5B9B40", Offset = "0x5B8D40", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000062")]
	public void set_defaultArea(int value) { }

	[Address(RVA = "0x3EB980", Offset = "0x3EAB80", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000064")]
	public void set_ignoreNavMeshAgent(bool value) { }

	[Address(RVA = "0x3EB970", Offset = "0x3EAB70", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000066")]
	public void set_ignoreNavMeshObstacle(bool value) { }

	[Address(RVA = "0x124FA60", Offset = "0x124EC60", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600005E")]
	public void set_layerMask(LayerMask value) { }

	[Address(RVA = "0x18184E0", Offset = "0x18176E0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000070")]
	public void set_minRegionArea(float value) { }

	[Address(RVA = "0x3692A0", Offset = "0x3684A0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000074")]
	public void set_navMeshData(NavMeshData value) { }

	[Address(RVA = "0x18184F0", Offset = "0x18176F0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000068")]
	public void set_overrideTileSize(bool value) { }

	[Address(RVA = "0x12CDBA0", Offset = "0x12CCDA0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600006C")]
	public void set_overrideVoxelSize(bool value) { }

	[Address(RVA = "0x1818500", Offset = "0x1817700", Length = "0x10")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600005A")]
	public void set_size(Vector3 value) { }

	[Address(RVA = "0x1818510", Offset = "0x1817710", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600006A")]
	public void set_tileSize(int value) { }

	[Address(RVA = "0x309680", Offset = "0x308880", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000060")]
	public void set_useGeometry(NavMeshCollectGeometry value) { }

	[Address(RVA = "0x1818520", Offset = "0x1817720", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600006E")]
	public void set_voxelSize(float value) { }

	[Address(RVA = "0x1817C30", Offset = "0x1816E30", Length = "0x1A4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000081")]
	private static void Unregister(NavMeshSurface surface) { }

	[Address(RVA = "0x1817DE0", Offset = "0x1816FE0", Length = "0x245")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(NavMeshDataInstance), Member = "Remove", ReturnType = typeof(void))]
	[Calls(Type = typeof(NavMeshSurface), Member = "AddData", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000082")]
	private static void UpdateActive() { }

	[Address(RVA = "0x1818030", Offset = "0x1817230", Length = "0x143")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(NavMeshDataInstance), Member = "Remove", ReturnType = typeof(void))]
	[Calls(Type = typeof(NavMeshSurface), Member = "AddData", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000089")]
	private void UpdateDataIfTransformChanged() { }

	[Address(RVA = "0x1818180", Offset = "0x1817380", Length = "0x18A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NavMeshSurface), Member = "CollectSources", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.AI.NavMeshBuildSource>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NavMeshSurface), Member = "CalculateWorldBounds", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.AI.NavMeshBuildSource>)}, ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(NavMeshSurface), Member = "GetBuildSettings", ReturnType = typeof(NavMeshBuildSettings))]
	[Calls(Type = typeof(NavMeshBuilder), Member = "UpdateNavMeshDataAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavMeshData), typeof(NavMeshBuildSettings), typeof(System.Collections.Generic.List`1<UnityEngine.AI.NavMeshBuildSource>), typeof(Bounds)}, ReturnType = typeof(AsyncOperation))]
	[Token(Token = "0x600007F")]
	public AsyncOperation UpdateNavMesh(NavMeshData data) { }

}

