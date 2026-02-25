namespace Unity.AI.Navigation;

[AddComponentMenu("Navigation/NavMesh Link", 33)]
[DefaultExecutionOrder(-101)]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.ai.navigation@2.0/manual/NavMeshLink.html")]
[Token(Token = "0x2000005")]
public class NavMeshLink : MonoBehaviour
{
	[Token(Token = "0x400001E")]
	private static readonly List<NavMeshLink> s_Tracked; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400000A")]
	private byte m_SerializedVersion; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x400000B")]
	private int m_AgentTypeID; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x400000C")]
	private Vector3 m_StartPoint; //Field offset: 0x28
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Token(Token = "0x400000D")]
	private Vector3 m_EndPoint; //Field offset: 0x34
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x400000E")]
	private Transform m_StartTransform; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x400000F")]
	private Transform m_EndTransform; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x4000010")]
	private bool m_Activated; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	[Token(Token = "0x4000011")]
	private float m_Width; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Min(0)]
	[SerializeField]
	[Token(Token = "0x4000012")]
	private float m_CostModifier; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	[Token(Token = "0x4000013")]
	private bool m_IsOverridingCost; //Field offset: 0x5C
	[FieldOffset(Offset = "0x5D")]
	[SerializeField]
	[Token(Token = "0x4000014")]
	private bool m_Bidirectional; //Field offset: 0x5D
	[FieldOffset(Offset = "0x5E")]
	[SerializeField]
	[Token(Token = "0x4000015")]
	private bool m_AutoUpdatePosition; //Field offset: 0x5E
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x4000016")]
	private int m_Area; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000017")]
	private NavMeshLinkInstance m_LinkInstance; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000018")]
	private bool m_StartTransformWasEmpty; //Field offset: 0x68
	[FieldOffset(Offset = "0x69")]
	[Token(Token = "0x4000019")]
	private bool m_EndTransformWasEmpty; //Field offset: 0x69
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x400001A")]
	private Vector3 m_LastStartWorldPosition; //Field offset: 0x6C
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400001B")]
	private Vector3 m_LastEndWorldPosition; //Field offset: 0x78
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x400001C")]
	private Vector3 m_LastPosition; //Field offset: 0x84
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400001D")]
	private Quaternion m_LastRotation; //Field offset: 0x90

	[Token(Token = "0x1700000B")]
	public bool activated
	{
		[Address(RVA = "0x3EB920", Offset = "0x3EAB20", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000017")]
		 get { } //Length: 5
		[Address(RVA = "0x1813FE0", Offset = "0x18131E0", Length = "0xE")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NavMesh), Member = "SetLinkActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavMeshLinkInstance), typeof(bool)}, ReturnType = typeof(void))]
		[Token(Token = "0x6000018")]
		 set { } //Length: 14
	}

	[Token(Token = "0x17000001")]
	public int agentTypeID
	{
		[Address(RVA = "0x309510", Offset = "0x308710", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000003")]
		 get { } //Length: 4
		[Address(RVA = "0x1813FF0", Offset = "0x18131F0", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(NavMeshLink), Member = "AddLink", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000004")]
		 set { } //Length: 59
	}

	[Token(Token = "0x1700000A")]
	public int area
	{
		[Address(RVA = "0x504360", Offset = "0x503560", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000015")]
		 get { } //Length: 4
		[Address(RVA = "0x1814030", Offset = "0x1813230", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(NavMeshLink), Member = "AddLink", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000016")]
		 set { } //Length: 59
	}

	[Token(Token = "0x17000009")]
	public bool autoUpdate
	{
		[Address(RVA = "0x1813F80", Offset = "0x1813180", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000013")]
		 get { } //Length: 5
		[Address(RVA = "0x1814070", Offset = "0x1813270", Length = "0x87")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(NavMeshLink), Member = "RemoveTracking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavMeshLink)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(NavMeshLink), Member = "AddTracking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavMeshLink)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x6000014")]
		 set { } //Length: 135
	}

	[Obsolete("autoUpdatePositions has been deprecated. Use autoUpdate instead. (UnityUpgradable) -> autoUpdate")]
	[Token(Token = "0x1700000D")]
	public bool autoUpdatePositions
	{
		[Address(RVA = "0x1813F80", Offset = "0x1813180", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600002A")]
		 get { } //Length: 5
		[Address(RVA = "0x1814070", Offset = "0x1813270", Length = "0x87")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(NavMeshLink), Member = "RemoveTracking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavMeshLink)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(NavMeshLink), Member = "AddTracking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavMeshLink)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		[Token(Token = "0x600002B")]
		 set { } //Length: 135
	}

	[Token(Token = "0x17000008")]
	public bool bidirectional
	{
		[Address(RVA = "0x1813F90", Offset = "0x1813190", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000011")]
		 get { } //Length: 5
		[Address(RVA = "0x1814100", Offset = "0x1813300", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(NavMeshLink), Member = "AddLink", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000012")]
		 set { } //Length: 59
	}

	[Obsolete("biDirectional has been deprecated. Use bidirectional instead. (UnityUpgradable) -> bidirectional")]
	[Token(Token = "0x1700000E")]
	public bool biDirectional
	{
		[Address(RVA = "0x1813F90", Offset = "0x1813190", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600002C")]
		 get { } //Length: 5
		[Address(RVA = "0x1814100", Offset = "0x1813300", Length = "0x3B")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(NavMeshLink), Member = "AddLink", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600002D")]
		 set { } //Length: 59
	}

	[Token(Token = "0x17000007")]
	public float costModifier
	{
		[Address(RVA = "0x1813FA0", Offset = "0x18131A0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600000F")]
		 get { } //Length: 19
		[Address(RVA = "0x1814140", Offset = "0x1813340", Length = "0x89")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(float), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(NavMeshLink), Member = "AddLink", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000010")]
		 set { } //Length: 137
	}

	[Obsolete("costOverride has been deprecated. Use costModifier instead. (UnityUpgradable) -> costModifier")]
	[Token(Token = "0x1700000F")]
	public float costOverride
	{
		[Address(RVA = "0x1813FA0", Offset = "0x18131A0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600002E")]
		 get { } //Length: 19
		[Address(RVA = "0x18141D0", Offset = "0x18133D0", Length = "0x89")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(float), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(NavMeshLink), Member = "AddLink", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600002F")]
		 set { } //Length: 137
	}

	[Token(Token = "0x17000003")]
	public Vector3 endPoint
	{
		[Address(RVA = "0x3B91F0", Offset = "0x3B83F0", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000007")]
		 get { } //Length: 19
		[Address(RVA = "0x1814260", Offset = "0x1813460", Length = "0x8A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(NavMeshLink), Member = "AddLink", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000008")]
		 set { } //Length: 138
	}

	[Token(Token = "0x17000005")]
	public Transform endTransform
	{
		[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x600000B")]
		 get { } //Length: 5
		[Address(RVA = "0x18142F0", Offset = "0x18134F0", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(NavMeshLink), Member = "AddLink", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600000C")]
		 set { } //Length: 158
	}

	[Token(Token = "0x1700000C")]
	public bool occupied
	{
		[Address(RVA = "0x1813FC0", Offset = "0x18131C0", Length = "0xA")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000019")]
		 get { } //Length: 10
	}

	[Token(Token = "0x17000002")]
	public Vector3 startPoint
	{
		[Address(RVA = "0x3C1A50", Offset = "0x3C0C50", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000005")]
		 get { } //Length: 19
		[Address(RVA = "0x1814390", Offset = "0x1813590", Length = "0x8A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(NavMeshLink), Member = "AddLink", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000006")]
		 set { } //Length: 138
	}

	[Token(Token = "0x17000004")]
	public Transform startTransform
	{
		[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000009")]
		 get { } //Length: 5
		[Address(RVA = "0x1814420", Offset = "0x1813620", Length = "0x9E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(NavMeshLink), Member = "AddLink", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600000A")]
		 set { } //Length: 158
	}

	[Token(Token = "0x17000006")]
	public float width
	{
		[Address(RVA = "0x1813FD0", Offset = "0x18131D0", Length = "0x6")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600000D")]
		 get { } //Length: 6
		[Address(RVA = "0x18144C0", Offset = "0x18136C0", Length = "0x57")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(float), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(NavMeshLink), Member = "AddLink", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600000E")]
		 set { } //Length: 87
	}

	[Address(RVA = "0x1813DA0", Offset = "0x1812FA0", Length = "0x84")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000032")]
	private static NavMeshLink() { }

	[Address(RVA = "0x1813E30", Offset = "0x1813030", Length = "0x14B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000031")]
	public NavMeshLink() { }

	[Address(RVA = "0x1812680", Offset = "0x1811880", Length = "0x5B5")]
	[CalledBy(Type = typeof(NavMeshLink), Member = "set_costOverride", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NavMeshLink), Member = "UpdatePositions", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NavMeshLink), Member = "UpdateTrackedInstances", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NavMeshLink), Member = "OnDidApplyAnimationProperties", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NavMeshLink), Member = "UpdateLink", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NavMeshLink), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NavMeshLink), Member = "set_area", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NavMeshLink), Member = "set_bidirectional", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NavMeshLink), Member = "set_biDirectional", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NavMeshLink), Member = "set_width", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NavMeshLink), Member = "set_endTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NavMeshLink), Member = "set_startTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NavMeshLink), Member = "set_endPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NavMeshLink), Member = "set_startPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NavMeshLink), Member = "set_agentTypeID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NavMeshLink), Member = "set_costModifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(NavMesh), Member = "AddLink", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavMeshLinkData), typeof(Vector3), typeof(Quaternion)}, ReturnType = typeof(NavMeshLinkInstance))]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(NavMeshLinkData), Member = "set_bidirectional", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint3x4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NavMeshLink), Member = "LocalToWorldUnscaled", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(NavMesh), Member = "SetLinkOwner", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavMeshLinkInstance), typeof(Object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Matrix4x4), Member = "get_inverse", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(NavMesh), Member = "SetLinkActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavMeshLinkInstance), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000024")]
	private void AddLink() { }

	[Address(RVA = "0x1812C40", Offset = "0x1811E40", Length = "0x274")]
	[CalledBy(Type = typeof(NavMeshLink), Member = "set_autoUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NavMeshLink), Member = "OnEnable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NavMeshLink), Member = "set_autoUpdatePositions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000020")]
	private static void AddTracking(NavMeshLink link) { }

	[Address(RVA = "0x1812EC0", Offset = "0x18120C0", Length = "0x12A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600001C")]
	private void Awake() { }

	[Address(RVA = "0x1812FF0", Offset = "0x18121F0", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	[Token(Token = "0x600001A")]
	private static void ClearTrackedList() { }

	[Address(RVA = "0x3EB920", Offset = "0x3EAB20", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000017")]
	public bool get_activated() { }

	[Address(RVA = "0x309510", Offset = "0x308710", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000003")]
	public int get_agentTypeID() { }

	[Address(RVA = "0x504360", Offset = "0x503560", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000015")]
	public int get_area() { }

	[Address(RVA = "0x1813F80", Offset = "0x1813180", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000013")]
	public bool get_autoUpdate() { }

	[Address(RVA = "0x1813F80", Offset = "0x1813180", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600002A")]
	public bool get_autoUpdatePositions() { }

	[Address(RVA = "0x1813F90", Offset = "0x1813190", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000011")]
	public bool get_bidirectional() { }

	[Address(RVA = "0x1813F90", Offset = "0x1813190", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600002C")]
	public bool get_biDirectional() { }

	[Address(RVA = "0x1813FA0", Offset = "0x18131A0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000F")]
	public float get_costModifier() { }

	[Address(RVA = "0x1813FA0", Offset = "0x18131A0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600002E")]
	public float get_costOverride() { }

	[Address(RVA = "0x3B91F0", Offset = "0x3B83F0", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000007")]
	public Vector3 get_endPoint() { }

	[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000B")]
	public Transform get_endTransform() { }

	[Address(RVA = "0x1813FC0", Offset = "0x18131C0", Length = "0xA")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000019")]
	public bool get_occupied() { }

	[Address(RVA = "0x3C1A50", Offset = "0x3C0C50", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000005")]
	public Vector3 get_startPoint() { }

	[Address(RVA = "0x309600", Offset = "0x308800", Length = "0x5")]
	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000009")]
	public Transform get_startTransform() { }

	[Address(RVA = "0x1813FD0", Offset = "0x18131D0", Length = "0x6")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000D")]
	public float get_width() { }

	[Address(RVA = "0x1813080", Offset = "0x1812280", Length = "0x20C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NavMeshLink), Member = "LocalToWorldUnscaled", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "get_inverse", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint3x4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000023")]
	internal void GetLocalPositions(out Vector3 localStartPosition, out Vector3 localEndPosition) { }

	[Address(RVA = "0x1813290", Offset = "0x1812490", Length = "0x1C6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NavMeshLink), Member = "LocalToWorldUnscaled", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint3x4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000022")]
	internal void GetWorldPositions(out Vector3 worldStartPosition, out Vector3 worldEndPosition) { }

	[Address(RVA = "0x1813460", Offset = "0x1812660", Length = "0x364")]
	[CalledBy(Type = typeof(NavMeshLink), Member = "UpdateTrackedInstances", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(NavMeshLink), Member = "LocalToWorldUnscaled", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint3x4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000026")]
	internal bool HaveTransformsChanged() { }

	[Address(RVA = "0x18137D0", Offset = "0x18129D0", Length = "0x12E")]
	[CalledBy(Type = typeof(NavMeshLink), Member = "GetWorldPositions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3&), typeof(Vector3&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NavMeshLink), Member = "GetLocalPositions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3&), typeof(Vector3&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NavMeshLink), Member = "AddLink", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NavMeshLink), Member = "HaveTransformsChanged", ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Matrix4x4), Member = "TRS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Quaternion), typeof(Vector3)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000027")]
	internal Matrix4x4 LocalToWorldUnscaled() { }

	[Address(RVA = "0x1813900", Offset = "0x1812B00", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NavMeshLink), Member = "AddLink", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000028")]
	private void OnDidApplyAnimationProperties() { }

	[Address(RVA = "0x1813940", Offset = "0x1812B40", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NavMeshLink), Member = "RemoveTracking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavMeshLink)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600001E")]
	private void OnDisable() { }

	[Address(RVA = "0x18139A0", Offset = "0x1812BA0", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NavMeshLink), Member = "AddLink", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NavMeshLink), Member = "AddTracking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavMeshLink)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600001D")]
	private void OnEnable() { }

	[Address(RVA = "0x1813A10", Offset = "0x1812C10", Length = "0x6E")]
	[CalledBy(Type = typeof(NavMeshLink), Member = "UpdateTrackedInstances", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000025")]
	internal void RecordEndpointTransforms() { }

	[Address(RVA = "0x1813A80", Offset = "0x1812C80", Length = "0x1A4")]
	[CalledBy(Type = typeof(NavMeshLink), Member = "set_autoUpdate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NavMeshLink), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NavMeshLink), Member = "set_autoUpdatePositions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000021")]
	private static void RemoveTracking(NavMeshLink link) { }

	[Address(RVA = "0x1813FE0", Offset = "0x18131E0", Length = "0xE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NavMesh), Member = "SetLinkActive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavMeshLinkInstance), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000018")]
	public void set_activated(bool value) { }

	[Address(RVA = "0x1813FF0", Offset = "0x18131F0", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NavMeshLink), Member = "AddLink", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000004")]
	public void set_agentTypeID(int value) { }

	[Address(RVA = "0x1814030", Offset = "0x1813230", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NavMeshLink), Member = "AddLink", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000016")]
	public void set_area(int value) { }

	[Address(RVA = "0x1814070", Offset = "0x1813270", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NavMeshLink), Member = "RemoveTracking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavMeshLink)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NavMeshLink), Member = "AddTracking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavMeshLink)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000014")]
	public void set_autoUpdate(bool value) { }

	[Address(RVA = "0x1814070", Offset = "0x1813270", Length = "0x87")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(NavMeshLink), Member = "RemoveTracking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavMeshLink)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NavMeshLink), Member = "AddTracking", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NavMeshLink)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[Token(Token = "0x600002B")]
	public void set_autoUpdatePositions(bool value) { }

	[Address(RVA = "0x1814100", Offset = "0x1813300", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NavMeshLink), Member = "AddLink", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000012")]
	public void set_bidirectional(bool value) { }

	[Address(RVA = "0x1814100", Offset = "0x1813300", Length = "0x3B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NavMeshLink), Member = "AddLink", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600002D")]
	public void set_biDirectional(bool value) { }

	[Address(RVA = "0x1814140", Offset = "0x1813340", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NavMeshLink), Member = "AddLink", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000010")]
	public void set_costModifier(float value) { }

	[Address(RVA = "0x18141D0", Offset = "0x18133D0", Length = "0x89")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NavMeshLink), Member = "AddLink", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600002F")]
	public void set_costOverride(float value) { }

	[Address(RVA = "0x1814260", Offset = "0x1813460", Length = "0x8A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NavMeshLink), Member = "AddLink", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000008")]
	public void set_endPoint(Vector3 value) { }

	[Address(RVA = "0x18142F0", Offset = "0x18134F0", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NavMeshLink), Member = "AddLink", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600000C")]
	public void set_endTransform(Transform value) { }

	[Address(RVA = "0x1814390", Offset = "0x1813590", Length = "0x8A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NavMeshLink), Member = "AddLink", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000006")]
	public void set_startPoint(Vector3 value) { }

	[Address(RVA = "0x1814420", Offset = "0x1813620", Length = "0x9E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NavMeshLink), Member = "AddLink", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600000A")]
	public void set_startTransform(Transform value) { }

	[Address(RVA = "0x18144C0", Offset = "0x18136C0", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(float), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NavMeshLink), Member = "AddLink", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600000E")]
	public void set_width(float value) { }

	[Address(RVA = "0x1813900", Offset = "0x1812B00", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NavMeshLink), Member = "AddLink", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600001F")]
	public void UpdateLink() { }

	[Address(RVA = "0x1813900", Offset = "0x1812B00", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NavMeshLink), Member = "AddLink", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Obsolete("UpdatePositions() has been deprecated. Use UpdateLink() instead. (UnityUpgradable) -> UpdateLink(*)")]
	[Token(Token = "0x6000030")]
	public void UpdatePositions() { }

	[Address(RVA = "0x1813C30", Offset = "0x1812E30", Length = "0x165")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NavMeshLink), Member = "HaveTransformsChanged", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Behaviour), Member = "get_isActiveAndEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NavMeshLink), Member = "AddLink", ReturnType = typeof(void))]
	[Calls(Type = typeof(NavMeshLink), Member = "RecordEndpointTransforms", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000029")]
	private static void UpdateTrackedInstances() { }

	[Address(RVA = "0x1812EC0", Offset = "0x18120C0", Length = "0x12A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x600001B")]
	private void UpgradeSerializedVersion() { }

}

