namespace Mirror;

[AddComponentMenu("Network/ Interest Management/ Spatial Hash/Spatial Hashing Interest Management")]
[Token(Token = "0x2000019")]
public class SpatialHashingInterestManagement : InterestManagement
{
	[Token(Token = "0x200001A")]
	internal enum CheckMethod
	{
		XZ_FOR_3D = 0,
		XY_FOR_2D = 1,
	}

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000074")]
	[Tooltip("The maximum range that objects will be visible at.")]
	public int visRange; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000075")]
	[Tooltip("Rebuild all every 'rebuildInterval' seconds.")]
	public float rebuildInterval; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000076")]
	private double lastRebuildTime; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000077")]
	[Tooltip("Spatial Hashing supports 3D (XZ) and 2D (XY) games.")]
	public CheckMethod checkMethod; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Header("Debug Settings")]
	[Token(Token = "0x4000078")]
	public bool showSlider; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000079")]
	private Grid2D<NetworkConnectionToClient> grid; //Field offset: 0x40

	[Token(Token = "0x17000004")]
	public int resolution
	{
		[Address(RVA = "0x1228C40", Offset = "0x1227E40", Length = "0x9")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000071")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x12292D0", Offset = "0x12284D0", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Grid2D`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(InterestManagement), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x6000077")]
	public SpatialHashingInterestManagement() { }

	[Address(RVA = "0x1228C40", Offset = "0x1227E40", Length = "0x9")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000071")]
	public int get_resolution() { }

	[Address(RVA = "0x1228C50", Offset = "0x1227E50", Length = "0x15C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Vector2Int), Member = "RoundToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2Int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000073")]
	public virtual bool OnCheckObserver(NetworkIdentity identity, NetworkConnectionToClient newObserver) { }

	[Address(RVA = "0x1228DB0", Offset = "0x1227FB0", Length = "0xD0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Vector2Int), Member = "RoundToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2Int))]
	[Calls(Type = typeof(Grid2D`1), Member = "GetWithNeighbours", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2Int), "System.Collections.Generic.HashSet`1<T>"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000074")]
	public virtual void OnRebuildObservers(NetworkIdentity identity, HashSet<NetworkConnectionToClient> newObservers) { }

	[Address(RVA = "0x1228E90", Offset = "0x1228090", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector2Int), Member = "RoundToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2Int))]
	[Token(Token = "0x6000072")]
	private Vector2Int ProjectToGrid(Vector3 position) { }

	[Address(RVA = "0x1228ED0", Offset = "0x12280D0", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ServerCallback]
	[Token(Token = "0x6000075")]
	public virtual void ResetState() { }

	[Address(RVA = "0x1228F60", Offset = "0x1228160", Length = "0x362")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(InterestManagement), Member = "RebuildAll", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Grid2D`1), Member = "ClearNonAlloc", ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Vector2Int), Member = "RoundToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2Int))]
	[Calls(Type = typeof(Grid2D`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2Int), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Time), Member = "get_unscaledTimeAsDouble", ReturnType = typeof(double))]
	[CallsDeduplicatedMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[ServerCallback]
	[Token(Token = "0x6000076")]
	internal void Update() { }

}

