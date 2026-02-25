namespace Mirror;

[Token(Token = "0x2000010")]
internal class HexGrid3D
{
	[Token(Token = "0x400003A")]
	private static readonly Cell3D[] neighborCellsBase; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000032")]
	internal float cellRadius; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000033")]
	internal float cellHeight; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000034")]
	private Vector3 originOffset; //Field offset: 0x18
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000035")]
	private readonly float sqrt3Div3; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000036")]
	private readonly float oneDiv3; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000037")]
	private readonly float twoDiv3; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000038")]
	private readonly float sqrt3; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000039")]
	private readonly float sqrt3Div2; //Field offset: 0x34

	[Address(RVA = "0x120D180", Offset = "0x120C380", Length = "0x3B6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000048")]
	private static HexGrid3D() { }

	[Address(RVA = "0x120D540", Offset = "0x120C740", Length = "0xFF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AF70")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000043")]
	internal HexGrid3D(ushort visRange, ushort height) { }

	[Address(RVA = "0x120CB80", Offset = "0x120BD80", Length = "0x8A")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000044")]
	internal Vector3 CellToWorld(Cell3D cell) { }

	[Address(RVA = "0x120CC10", Offset = "0x120BE10", Length = "0x190")]
	[CalledBy(Type = typeof(HexSpatialHash3DInterestManagement), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HexSpatialHash3DInterestManagement), Member = "OnCheckObserver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity), typeof(NetworkConnectionToClient)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000047")]
	internal void GetNeighborCells(Cell3D center, Cell3D[] neighbors) { }

	[Address(RVA = "0x120CDB0", Offset = "0x120BFB0", Length = "0x17F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F70")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000046")]
	private Cell3D RoundToCell(float q, float r, int layer) { }

	[Address(RVA = "0x120CF30", Offset = "0x120C130", Length = "0x242")]
	[CalledBy(Type = typeof(HexSpatialHash3DInterestManagement), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HexSpatialHash3DInterestManagement), Member = "UpdateIdentityPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802897E0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F70")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000045")]
	internal Cell3D WorldToCell(Vector3 position) { }

}

