namespace Unity.AI.Navigation;

[AddComponentMenu("Navigation/NavMesh Modifier Volume", 31)]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.ai.navigation@2.0/manual/NavMeshModifierVolume.html")]
[Token(Token = "0x2000007")]
public class NavMeshModifierVolume : MonoBehaviour
{
	[Token(Token = "0x400002F")]
	private static readonly List<NavMeshModifierVolume> s_NavMeshModifiers; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400002A")]
	private byte m_SerializedVersion; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x400002B")]
	private Vector3 m_Size; //Field offset: 0x24
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x400002C")]
	private Vector3 m_Center; //Field offset: 0x30
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Token(Token = "0x400002D")]
	private int m_Area; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x400002E")]
	private List<Int32> m_AffectedAgents; //Field offset: 0x40

	[Token(Token = "0x1700001A")]
	public static List<NavMeshModifierVolume> activeModifiers
	{
		[Address(RVA = "0x18149A0", Offset = "0x1813BA0", Length = "0x4E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x600004E")]
		 get { } //Length: 78
	}

	[Token(Token = "0x17000019")]
	public int area
	{
		[Address(RVA = "0x3DCA70", Offset = "0x3DBC70", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600004C")]
		 get { } //Length: 4
		[Address(RVA = "0x5AABF0", Offset = "0x5A9DF0", Length = "0x4")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x600004D")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000018")]
	public Vector3 center
	{
		[Address(RVA = "0x3DCA50", Offset = "0x3DBC50", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600004A")]
		 get { } //Length: 19
		[Address(RVA = "0x5AABC0", Offset = "0x5A9DC0", Length = "0x10")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600004B")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000017")]
	public Vector3 size
	{
		[Address(RVA = "0x2DD160", Offset = "0x2DC360", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000048")]
		 get { } //Length: 19
		[Address(RVA = "0x2DD420", Offset = "0x2DC620", Length = "0x10")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000049")]
		 set { } //Length: 16
	}

	[Address(RVA = "0x1814810", Offset = "0x1813A10", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000054")]
	private static NavMeshModifierVolume() { }

	[Address(RVA = "0x18148A0", Offset = "0x1813AA0", Length = "0xFC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000053")]
	public NavMeshModifierVolume() { }

	[Address(RVA = "0x1814520", Offset = "0x1813720", Length = "0xAF")]
	[CalledBy(Type = typeof(NavMeshSurface), Member = "AppendModifierVolumes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(List`1<NavMeshBuildSource>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000052")]
	public bool AffectsAgentType(int agentTypeID) { }

	[Address(RVA = "0x18145D0", Offset = "0x18137D0", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	[Token(Token = "0x600004F")]
	private static void ClearNavMeshModifiers() { }

	[Address(RVA = "0x18149A0", Offset = "0x1813BA0", Length = "0x4E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600004E")]
	public static List<NavMeshModifierVolume> get_activeModifiers() { }

	[Address(RVA = "0x3DCA70", Offset = "0x3DBC70", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600004C")]
	public int get_area() { }

	[Address(RVA = "0x3DCA50", Offset = "0x3DBC50", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600004A")]
	public Vector3 get_center() { }

	[Address(RVA = "0x2DD160", Offset = "0x2DC360", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000048")]
	public Vector3 get_size() { }

	[Address(RVA = "0x1814660", Offset = "0x1813860", Length = "0x78")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000051")]
	private void OnDisable() { }

	[Address(RVA = "0x18146E0", Offset = "0x18138E0", Length = "0x120")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000050")]
	private void OnEnable() { }

	[Address(RVA = "0x5AABF0", Offset = "0x5A9DF0", Length = "0x4")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x600004D")]
	public void set_area(int value) { }

	[Address(RVA = "0x5AABC0", Offset = "0x5A9DC0", Length = "0x10")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600004B")]
	public void set_center(Vector3 value) { }

	[Address(RVA = "0x2DD420", Offset = "0x2DC620", Length = "0x10")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000049")]
	public void set_size(Vector3 value) { }

}

