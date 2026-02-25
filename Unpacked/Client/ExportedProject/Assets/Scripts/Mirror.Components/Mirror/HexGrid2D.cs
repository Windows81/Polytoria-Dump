namespace Mirror;

[Token(Token = "0x200000E")]
internal class HexGrid2D
{
	[Token(Token = "0x400002F")]
	private static readonly Cell2D[] neighborCellsBase; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000028")]
	internal float cellRadius; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000029")]
	private Vector2 originOffset; //Field offset: 0x14
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400002A")]
	private readonly float sqrt3Div3; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400002B")]
	private readonly float oneDiv3; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400002C")]
	private readonly float twoDiv3; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400002D")]
	private readonly float sqrt3; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x400002E")]
	private readonly float sqrt3Div2; //Field offset: 0x2C

	[Address(RVA = "0x120C930", Offset = "0x120BB30", Length = "0x14B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600003F")]
	private static HexGrid2D() { }

	[Address(RVA = "0x120CA80", Offset = "0x120BC80", Length = "0xF9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AF70")]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600003A")]
	internal HexGrid2D(ushort visRange) { }

	[Address(RVA = "0x120C450", Offset = "0x120B650", Length = "0x53")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600003B")]
	internal Vector2 CellToWorld(Cell2D cell) { }

	[Address(RVA = "0x120C4B0", Offset = "0x120B6B0", Length = "0x16A")]
	[CalledBy(Type = typeof(HexSpatialHash2DInterestManagement), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HexSpatialHash2DInterestManagement), Member = "OnCheckObserver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity), typeof(NetworkConnectionToClient)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600003E")]
	internal void GetNeighborCells(Cell2D center, Cell2D[] neighbors) { }

	[Address(RVA = "0x120C620", Offset = "0x120B820", Length = "0x16D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F70")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600003D")]
	private Cell2D RoundToCell(float q, float r) { }

	[Address(RVA = "0x120C790", Offset = "0x120B990", Length = "0x19B")]
	[CalledBy(Type = typeof(HexSpatialHash2DInterestManagement), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(HexSpatialHash2DInterestManagement), Member = "UpdateIdentityPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkIdentity)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F70")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600003C")]
	internal Cell2D WorldToCell(Vector2 position) { }

}

