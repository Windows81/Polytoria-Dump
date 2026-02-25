namespace Mirror;

[AddComponentMenu("Network/ Interest Management/ Spatial Hash/Hex Spatial Hash (3D)")]
[Token(Token = "0x2000016")]
public class HexSpatialHash3DInterestManagement : InterestManagement
{
	[CompilerGenerated]
	[Token(Token = "0x2000017")]
	private sealed class <>c
	{
		[Token(Token = "0x400006D")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400006E")]
		public static Func<Renderer, Boolean> <>9__23_0; //Field offset: 0x8

		[Address(RVA = "0x122A540", Offset = "0x1229740", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6000067")]
		private static <>c() { }

		[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
		[CallerCount(Count = 2609)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000068")]
		public <>c() { }

		[Address(RVA = "0x122A440", Offset = "0x1229640", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Renderer), Member = "get_isPartOfStaticBatch", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000069")]
		internal bool <OnSpawned>b__23_0(Renderer r) { }

	}

	[Token(Token = "0x400006C")]
	private const ushort MAX_AREA = 9000; //Field offset: 0x0
	[Token(Token = "0x400006A")]
	private const int LAYER_OFFSET = 18; //Field offset: 0x0
	[Token(Token = "0x4000069")]
	private const int MAX_R = 23; //Field offset: 0x0
	[Token(Token = "0x4000068")]
	private const int MAX_Q = 19; //Field offset: 0x0
	[Token(Token = "0x400006B")]
	private const int MAX_LAYERS = 36; //Field offset: 0x0
	[FieldOffset(Offset = "0x28")]
	[Range(1, 60)]
	[Token(Token = "0x4000058")]
	[Tooltip("Time interval in seconds between observer rebuilds")]
	public byte rebuildInterval; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[Range(1, 60)]
	[Token(Token = "0x4000059")]
	[Tooltip("Time interval in seconds between static object rebuilds")]
	public byte staticRebuildInterval; //Field offset: 0x29
	[FieldOffset(Offset = "0x2A")]
	[Range(10, 5000)]
	[Token(Token = "0x400005A")]
	[Tooltip("Radius of super hex.\nSet to 10% larger than camera far clip plane.")]
	public ushort visRange; //Field offset: 0x2A
	[FieldOffset(Offset = "0x2C")]
	[Range(10, 5000)]
	[Token(Token = "0x400005B")]
	[Tooltip("Cell3D height effects all 3 layers")]
	public ushort cellHeight; //Field offset: 0x2C
	[FieldOffset(Offset = "0x2E")]
	[Range(1, 100)]
	[Token(Token = "0x400005C")]
	[Tooltip("Distance an object must move for updating cell positions")]
	public ushort minMoveDistance; //Field offset: 0x2E
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400005D")]
	private double lastRebuildTime; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400005E")]
	private byte rebuildCounter; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400005F")]
	private HexGrid3D grid; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000060")]
	private readonly List<HashSet`1<NetworkIdentity>> cells; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000061")]
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"cell", "worldPos"})]
	private readonly Dictionary<NetworkIdentity, ValueTuple`2<Cell3D, Vector3>> lastIdentityPositions; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000062")]
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"cell", "worldPos"})]
	private readonly Dictionary<NetworkConnectionToClient, ValueTuple`2<Cell3D, Vector3>> lastConnectionPositions; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000063")]
	private readonly Cell3D[] neighborCells; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000064")]
	private readonly Dictionary<NetworkConnectionToClient, HashSet`1<NetworkIdentity>> connectionObservers; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000065")]
	private readonly List<NetworkIdentity> identityKeys; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000066")]
	private readonly Stack<HashSet`1<NetworkIdentity>> cellPool; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000067")]
	private readonly HashSet<NetworkIdentity> staticObjects; //Field offset: 0x80

	[Address(RVA = "0x12112A0", Offset = "0x12104A0", Length = "0x260")]
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
	[Token(Token = "0x6000066")]
	public HexSpatialHash3DInterestManagement() { }

	[Address(RVA = "0x120F4F0", Offset = "0x120E6F0", Length = "0x1A3")]
	[CalledBy(Type = typeof(HexSpatialHash3DInterestManagement), Member = "UpdateIdentityPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Pop", ReturnType = typeof(object))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000060")]
	private void AddToCell(Cell3D cell, NetworkIdentity identity) { }

	[Address(RVA = "0x120F6A0", Offset = "0x120E8A0", Length = "0x1CD")]
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
	[Token(Token = "0x600005C")]
	private void Awake() { }

	[Address(RVA = "0x120F870", Offset = "0x120EA70", Length = "0x14")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000065")]
	private int GetCellIndex(Cell3D cell) { }

	[Address(RVA = "0x120F890", Offset = "0x120EA90", Length = "0xAC3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "GetEnumerator", ReturnType = typeof(System.Collections.Generic.HashSet`1+Enumerator<System.Object>))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(HexGrid3D), Member = "GetNeighborCells", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cell3D), typeof(Cell3D[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(HexSpatialHash3DInterestManagement), Member = "UpdateIdentityPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.ValueTuple`2<Mirror.Cell3D, UnityEngine.Vector3>>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(System.ValueTuple`2<Mirror.Cell3D, UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HexGrid3D), Member = "WorldToCell", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Cell3D))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC240")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.ValueTuple`2<Mirror.Cell3D, UnityEngine.Vector3>>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ValueTuple`2<Cell3D, Vector3>&)}, ReturnType = typeof(bool))]
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
	[Token(Token = "0x600005D")]
	private void LateUpdate() { }

	[Address(RVA = "0x1210360", Offset = "0x120F560", Length = "0x1A0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.ValueTuple`2<Mirror.Cell3D, UnityEngine.Vector3>>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ValueTuple`2<Cell3D, Vector3>&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(HexGrid3D), Member = "GetNeighborCells", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cell3D), typeof(Cell3D[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(Cell3D), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000061")]
	public virtual bool OnCheckObserver(NetworkIdentity identity, NetworkConnectionToClient newObserver) { }

	[Address(RVA = "0x1210510", Offset = "0x120F710", Length = "0x213")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.ValueTuple`2<Mirror.Cell3D, UnityEngine.Vector3>>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ValueTuple`2<Cell3D, Vector3>&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.ValueTuple`2<Mirror.Cell3D, UnityEngine.Vector3>>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6000064")]
	public virtual void OnDestroyed(NetworkIdentity identity) { }

	[Address(RVA = "0x1210730", Offset = "0x120F930", Length = "0x2A0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.ValueTuple`2<Mirror.Cell3D, UnityEngine.Vector3>>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ValueTuple`2<Cell3D, Vector3>&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Token(Token = "0x6000062")]
	public virtual void OnRebuildObservers(NetworkIdentity identity, HashSet<NetworkConnectionToClient> newObservers) { }

	[Address(RVA = "0x12109E0", Offset = "0x120FBE0", Length = "0x1A3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(HexSpatialHash3DInterestManagement), Member = "UpdateIdentityPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[Calls(Type = typeof(GameObject), Member = "GetComponentsInChildren", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T[]")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(System.Func`2<System.Object, System.Boolean>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(System.Func`2<System.Object, System.Boolean>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600005E")]
	public virtual void OnSpawned(NetworkIdentity identity) { }

	[Address(RVA = "0x1210B90", Offset = "0x120FD90", Length = "0x213")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(HashSet`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Stack`1<System.Object>), Member = "Push", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Dictionary`2), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000063")]
	public virtual void ResetState() { }

	[Address(RVA = "0x1210DB0", Offset = "0x120FFB0", Length = "0x4EE")]
	[CalledBy(Type = typeof(HexSpatialHash3DInterestManagement), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HexSpatialHash3DInterestManagement), Member = "OnSpawned", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(HexGrid3D), Member = "WorldToCell", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Cell3D))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802BC240")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.ValueTuple`2<Mirror.Cell3D, UnityEngine.Vector3>>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(System.ValueTuple`2<Mirror.Cell3D, UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HexSpatialHash3DInterestManagement), Member = "AddToCell", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Cell3D), typeof(NetworkIdentity)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.ValueTuple`2<Mirror.Cell3D, UnityEngine.Vector3>>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(ValueTuple`2<Cell3D, Vector3>&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(System.Collections.Generic.HashSet`1<System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600005F")]
	private void UpdateIdentityPosition(NetworkIdentity identity) { }

}

