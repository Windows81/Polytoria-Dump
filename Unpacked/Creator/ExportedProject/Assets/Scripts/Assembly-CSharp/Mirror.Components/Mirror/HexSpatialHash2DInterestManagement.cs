namespace Mirror;

[AddComponentMenu("Network/ Interest Management/ Spatial Hash/Hex Spatial Hash (2D)")]
[Token(Token = "0x2000013")]
public class HexSpatialHash2DInterestManagement : InterestManagement
{
	[CompilerGenerated]
	[Token(Token = "0x2000015")]
	private sealed class <>c
	{
		[Token(Token = "0x4000056")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000057")]
		public static Func<Renderer, Boolean> <>9__23_0; //Field offset: 0x8

		[Address(RVA = "0x122A460", Offset = "0x1229660", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000059")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600005A")]
		public <>c() { }

		[Address(RVA = "0x122A440", Offset = "0x1229640", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Renderer), Member = "get_isPartOfStaticBatch", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600005B")]
		internal bool <OnSpawned>b__23_0(Renderer r) { }

	}

	[Token(Token = "0x2000014")]
	internal enum CheckMethod
	{
		XZ_FOR_3D = 0,
		XY_FOR_2D = 1,
	}

	[Token(Token = "0x4000052")]
	private const ushort MAX_AREA = 9000; //Field offset: 0x0
	[Token(Token = "0x4000050")]
	private const int MAX_Q = 19; //Field offset: 0x0
	[Token(Token = "0x4000051")]
	private const int MAX_R = 23; //Field offset: 0x0
	[FieldOffset(Offset = "0x28")]
	[Range(1, 60)]
	[Token(Token = "0x4000040")]
	[Tooltip("Time interval in seconds between observer rebuilds")]
	public byte rebuildInterval; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[Range(1, 60)]
	[Token(Token = "0x4000041")]
	[Tooltip("Time interval in seconds between static object rebuilds")]
	public byte staticRebuildInterval; //Field offset: 0x29
	[FieldOffset(Offset = "0x2A")]
	[Range(10, 5000)]
	[Token(Token = "0x4000042")]
	[Tooltip("Radius of super hex.\nSet to 10% larger than camera far clip plane.")]
	public ushort visRange; //Field offset: 0x2A
	[FieldOffset(Offset = "0x2C")]
	[Range(1, 100)]
	[Token(Token = "0x4000043")]
	[Tooltip("Distance an object must move for updating cell positions")]
	public ushort minMoveDistance; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000044")]
	[Tooltip("Spatial Hashing supports XZ for 3D games or XY for 2D games.")]
	public CheckMethod checkMethod; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000045")]
	private double lastRebuildTime; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000046")]
	private byte rebuildCounter; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000047")]
	private HexGrid2D grid; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000048")]
	private readonly List<HashSet`1<NetworkIdentity>> cells; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000049")]
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"cell", "worldPos"})]
	private readonly Dictionary<NetworkIdentity, ValueTuple`2<Cell2D, Vector2>> lastIdentityPositions; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400004A")]
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"cell", "worldPos"})]
	private readonly Dictionary<NetworkConnectionToClient, ValueTuple`2<Cell2D, Vector2>> lastConnectionPositions; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400004B")]
	private readonly Cell2D[] neighborCells; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400004C")]
	private readonly Dictionary<NetworkConnectionToClient, HashSet`1<NetworkIdentity>> connectionObservers; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400004D")]
	private readonly List<NetworkIdentity> identityKeys; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400004E")]
	private readonly Stack<HashSet`1<NetworkIdentity>> cellPool; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400004F")]
	private readonly HashSet<NetworkIdentity> staticObjects; //Field offset: 0x88

	[Address(RVA = "0x120F280", Offset = "0x120E480", Length = "0x265")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Stack`1), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(InterestManagement), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000058")]
	public HexSpatialHash2DInterestManagement() { }

	[Address(RVA = "0x120D640", Offset = "0x120C840", Length = "0x18A")]
	[CalledBy(Type = typeof(HexSpatialHash2DInterestManagement), Member = "UpdateIdentityPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000052")]
	private void AddToCell(Cell2D cell, NetworkIdentity identity) { }

	[Address(RVA = "0x120D7D0", Offset = "0x120C9D0", Length = "0x1C8")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AF70")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600004D")]
	private void Awake() { }

	[Address(RVA = "0x120D9A0", Offset = "0x120CBA0", Length = "0x12")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000057")]
	private int GetCellIndex(Cell2D cell) { }

	[Address(RVA = "0x120D9C0", Offset = "0x120CBC0", Length = "0xA1C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(HexGrid2D), Member = "GetNeighborCells", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cell2D), typeof(Cell2D[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(HexSpatialHash2DInterestManagement), Member = "UpdateIdentityPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.ValueTuple`2<Mirror.Cell2D, UnityEngine.Vector2>>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(System.ValueTuple`2<Mirror.Cell2D, UnityEngine.Vector2>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HexGrid2D), Member = "WorldToCell", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Cell2D))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18120B020")]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18120AE80")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(InterestManagement), Member = "RebuildAll", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 17)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600004F")]
	private void LateUpdate() { }

	[Address(RVA = "0x120E3E0", Offset = "0x120D5E0", Length = "0x1D7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HexGrid2D), Member = "GetNeighborCells", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cell2D), typeof(Cell2D[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000053")]
	public virtual bool OnCheckObserver(NetworkIdentity identity, NetworkConnectionToClient newObserver) { }

	[Address(RVA = "0x120E5C0", Offset = "0x120D7C0", Length = "0x208")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000056")]
	public virtual void OnDestroyed(NetworkIdentity identity) { }

	[Address(RVA = "0x120E7D0", Offset = "0x120D9D0", Length = "0x2A0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x6000054")]
	public virtual void OnRebuildObservers(NetworkIdentity identity, HashSet<NetworkConnectionToClient> newObservers) { }

	[Address(RVA = "0x120EA80", Offset = "0x120DC80", Length = "0x1A3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(HexSpatialHash2DInterestManagement), Member = "UpdateIdentityPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Func`2<System.Object, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Boolean>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000050")]
	public virtual void OnSpawned(NetworkIdentity identity) { }

	[Address(RVA = "0x120EC30", Offset = "0x120DE30", Length = "0x26")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600004E")]
	private Vector2 ProjectToGrid(Vector3 position) { }

	[Address(RVA = "0x120EC60", Offset = "0x120DE60", Length = "0x216")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000055")]
	public virtual void ResetState() { }

	[Address(RVA = "0x120EE80", Offset = "0x120E080", Length = "0x3F2")]
	[CalledBy(Type = typeof(HexSpatialHash2DInterestManagement), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HexSpatialHash2DInterestManagement), Member = "OnSpawned", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Dictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18120B020")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.ValueTuple`2<Mirror.Cell2D, UnityEngine.Vector2>>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(System.ValueTuple`2<Mirror.Cell2D, UnityEngine.Vector2>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HexSpatialHash2DInterestManagement), Member = "AddToCell", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cell2D), typeof(NetworkIdentity)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HexGrid2D), Member = "WorldToCell", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Cell2D))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000051")]
	private void UpdateIdentityPosition(NetworkIdentity identity) { }

}

