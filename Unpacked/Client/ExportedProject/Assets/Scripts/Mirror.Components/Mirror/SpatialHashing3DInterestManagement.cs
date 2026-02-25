namespace Mirror;

[AddComponentMenu("Network/ Interest Management/ Spatial Hash/Spatial Hashing Interest Management")]
[Token(Token = "0x2000018")]
public class SpatialHashing3DInterestManagement : InterestManagement
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400006F")]
	[Tooltip("The maximum range that objects will be visible at.")]
	public int visRange; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000070")]
	[Tooltip("Rebuild all every 'rebuildInterval' seconds.")]
	public float rebuildInterval; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000071")]
	private double lastRebuildTime; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Header("Debug Settings")]
	[Token(Token = "0x4000072")]
	public bool showSlider; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000073")]
	private Grid3D<NetworkConnectionToClient> grid; //Field offset: 0x40

	[Token(Token = "0x17000003")]
	public int resolution
	{
		[Address(RVA = "0x1228C40", Offset = "0x1227E40", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600006A")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x1228BC0", Offset = "0x1227DC0", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Grid3D`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(InterestManagement), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000070")]
	public SpatialHashing3DInterestManagement() { }

	[Address(RVA = "0x1228C40", Offset = "0x1227E40", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600006A")]
	public int get_resolution() { }

	[Address(RVA = "0x1228490", Offset = "0x1227690", Length = "0x12A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(SpatialHashing3DInterestManagement), Member = "ProjectToGrid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3Int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600006C")]
	public virtual bool OnCheckObserver(NetworkIdentity identity, NetworkConnectionToClient newObserver) { }

	[Address(RVA = "0x12285C0", Offset = "0x12277C0", Length = "0xBC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(SpatialHashing3DInterestManagement), Member = "ProjectToGrid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3Int))]
	[Calls(Type = typeof(Grid3D`1), Member = "GetWithNeighbours", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3Int), "System.Collections.Generic.HashSet`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600006D")]
	public virtual void OnRebuildObservers(NetworkIdentity identity, HashSet<NetworkConnectionToClient> newObservers) { }

	[Address(RVA = "0x1228680", Offset = "0x1227880", Length = "0x151")]
	[CalledBy(Type = typeof(SpatialHashing3DInterestManagement), Member = "OnCheckObserver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity), typeof(NetworkConnectionToClient)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(SpatialHashing3DInterestManagement), Member = "OnRebuildObservers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity), typeof(System.Collections.Generic.HashSet`1<Mirror.NetworkConnectionToClient>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SpatialHashing3DInterestManagement), Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F70")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600006B")]
	private Vector3Int ProjectToGrid(Vector3 position) { }

	[Address(RVA = "0x12287E0", Offset = "0x12279E0", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ServerCallback]
	[Token(Token = "0x600006E")]
	public virtual void ResetState() { }

	[Address(RVA = "0x1228870", Offset = "0x1227A70", Length = "0x346")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(InterestManagement), Member = "RebuildAll", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Grid3D`1), Member = "ClearNonAlloc", ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(SpatialHashing3DInterestManagement), Member = "ProjectToGrid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3Int))]
	[Calls(Type = typeof(Grid3D`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3Int), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Time), Member = "get_unscaledTimeAsDouble", ReturnType = typeof(double))]
	[CallsDeduplicatedMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[ServerCallback]
	[Token(Token = "0x600006F")]
	internal void Update() { }

}

