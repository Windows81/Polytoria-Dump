namespace Unity.AI.Navigation;

[AddComponentMenu("Navigation/NavMesh Modifier", 32)]
[DefaultExecutionOrder(-103)]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.ai.navigation@2.0/manual/NavMeshModifier.html")]
[Token(Token = "0x2000006")]
public class NavMeshModifier : MonoBehaviour
{
	[Token(Token = "0x4000027")]
	private static bool s_RebuildNavMeshModifiers; //Field offset: 0x0
	[Token(Token = "0x4000028")]
	private static List<NavMeshModifier> s_NavMeshModifiers; //Field offset: 0x8
	[Token(Token = "0x4000029")]
	private static readonly HashSet<NavMeshModifier> s_NavMeshModifiersSet; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400001F")]
	private byte m_SerializedVersion; //Field offset: 0x20
	[FieldOffset(Offset = "0x21")]
	[SerializeField]
	[Token(Token = "0x4000020")]
	private bool m_OverrideArea; //Field offset: 0x21
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x4000021")]
	private int m_Area; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000022")]
	private bool m_OverrideGenerateLinks; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[SerializeField]
	[Token(Token = "0x4000023")]
	private bool m_GenerateLinks; //Field offset: 0x29
	[FieldOffset(Offset = "0x2A")]
	[SerializeField]
	[Token(Token = "0x4000024")]
	private bool m_IgnoreFromBuild; //Field offset: 0x2A
	[FieldOffset(Offset = "0x2B")]
	[SerializeField]
	[Token(Token = "0x4000025")]
	private bool m_ApplyToChildren; //Field offset: 0x2B
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000026")]
	private List<Int32> m_AffectedAgents; //Field offset: 0x30

	[Token(Token = "0x17000016")]
	public static List<NavMeshModifier> activeModifiers
	{
		[Address(RVA = "0x1814E90", Offset = "0x1814090", Length = "0xF9")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x600003F")]
		 get { } //Length: 249
	}

	[Token(Token = "0x17000015")]
	public bool applyToChildren
	{
		[Address(RVA = "0x5C6FE0", Offset = "0x5C61E0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600003D")]
		 get { } //Length: 5
		[Address(RVA = "0x5C6FF0", Offset = "0x5C61F0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600003E")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000011")]
	public int area
	{
		[Address(RVA = "0x309510", Offset = "0x308710", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000035")]
		 get { } //Length: 4
		[Address(RVA = "0x309520", Offset = "0x308720", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000036")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000013")]
	public bool generateLinks
	{
		[Address(RVA = "0x339410", Offset = "0x338610", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000039")]
		 get { } //Length: 5
		[Address(RVA = "0x339450", Offset = "0x338650", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600003A")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000014")]
	public bool ignoreFromBuild
	{
		[Address(RVA = "0x3893E0", Offset = "0x3885E0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600003B")]
		 get { } //Length: 5
		[Address(RVA = "0x389400", Offset = "0x388600", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600003C")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000010")]
	public bool overrideArea
	{
		[Address(RVA = "0x3292C0", Offset = "0x3284C0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000033")]
		 get { } //Length: 5
		[Address(RVA = "0x3292F0", Offset = "0x3284F0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000034")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000012")]
	public bool overrideGenerateLinks
	{
		[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000037")]
		 get { } //Length: 5
		[Address(RVA = "0x309690", Offset = "0x308890", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000038")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x1814CC0", Offset = "0x1813EC0", Length = "0xFC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000047")]
	private static NavMeshModifier() { }

	[Address(RVA = "0x1814DC0", Offset = "0x1813FC0", Length = "0xC5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000046")]
	public NavMeshModifier() { }

	[Address(RVA = "0x18149F0", Offset = "0x1813BF0", Length = "0xAF")]
	[CalledBy(Type = typeof(NavMeshSurface), Member = "CollectSources", ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.AI.NavMeshBuildSource>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000045")]
	public bool AffectsAgentType(int agentTypeID) { }

	[Address(RVA = "0x1814AA0", Offset = "0x1813CA0", Length = "0xB4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	[Token(Token = "0x6000040")]
	private static void ClearNavMeshModifiers() { }

	[Address(RVA = "0x1814E90", Offset = "0x1814090", Length = "0xF9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Object>))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600003F")]
	public static List<NavMeshModifier> get_activeModifiers() { }

	[Address(RVA = "0x5C6FE0", Offset = "0x5C61E0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600003D")]
	public bool get_applyToChildren() { }

	[Address(RVA = "0x309510", Offset = "0x308710", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000035")]
	public int get_area() { }

	[Address(RVA = "0x339410", Offset = "0x338610", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000039")]
	public bool get_generateLinks() { }

	[Address(RVA = "0x3893E0", Offset = "0x3885E0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600003B")]
	public bool get_ignoreFromBuild() { }

	[Address(RVA = "0x3292C0", Offset = "0x3284C0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000033")]
	public bool get_overrideArea() { }

	[Address(RVA = "0x309630", Offset = "0x308830", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000037")]
	public bool get_overrideGenerateLinks() { }

	[Address(RVA = "0x1814B60", Offset = "0x1813D60", Length = "0xA7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000042")]
	private void OnDisable() { }

	[Address(RVA = "0x1814C10", Offset = "0x1813E10", Length = "0xA7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000041")]
	private void OnEnable() { }

	[Address(RVA = "0x1814C10", Offset = "0x1813E10", Length = "0xA7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000043")]
	private void RegisterModifier() { }

	[Address(RVA = "0x5C6FF0", Offset = "0x5C61F0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600003E")]
	public void set_applyToChildren(bool value) { }

	[Address(RVA = "0x309520", Offset = "0x308720", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000036")]
	public void set_area(int value) { }

	[Address(RVA = "0x339450", Offset = "0x338650", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600003A")]
	public void set_generateLinks(bool value) { }

	[Address(RVA = "0x389400", Offset = "0x388600", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600003C")]
	public void set_ignoreFromBuild(bool value) { }

	[Address(RVA = "0x3292F0", Offset = "0x3284F0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000034")]
	public void set_overrideArea(bool value) { }

	[Address(RVA = "0x309690", Offset = "0x308890", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000038")]
	public void set_overrideGenerateLinks(bool value) { }

	[Address(RVA = "0x1814B60", Offset = "0x1813D60", Length = "0xA7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000044")]
	private void UnregisterModifier() { }

}

