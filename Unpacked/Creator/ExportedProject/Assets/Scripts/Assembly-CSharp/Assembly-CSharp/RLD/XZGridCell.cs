namespace RLD;

[Token(Token = "0x2000207")]
public class XZGridCell
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007D6")]
	private IXZGrid _parentGrid; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40007D7")]
	private int _xIndex; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40007D8")]
	private int _zIndex; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40007D9")]
	private Vector3 _min; //Field offset: 0x20
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40007DA")]
	private Vector3 _max; //Field offset: 0x2C

	[Token(Token = "0x1700064C")]
	public Vector3 Center
	{
		[Address(RVA = "0x5A64E0", Offset = "0x5A56E0", Length = "0x54")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x60013E2")]
		 get { } //Length: 84
	}

	[Token(Token = "0x1700064B")]
	public Vector3 Max
	{
		[Address(RVA = "0x573970", Offset = "0x572B70", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60013E1")]
		 get { } //Length: 19
	}

	[Token(Token = "0x1700064A")]
	public Vector3 Min
	{
		[Address(RVA = "0x561A40", Offset = "0x560C40", Length = "0x13")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60013E0")]
		 get { } //Length: 19
	}

	[Token(Token = "0x17000647")]
	public IXZGrid ParentGrid
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x60013DD")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000648")]
	public int XIndex
	{
		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x60013DE")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000649")]
	public int ZIndex
	{
		[Address(RVA = "0x3893F0", Offset = "0x3885F0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x60013DF")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x5A6460", Offset = "0x5A5660", Length = "0x75")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60013E3")]
	public XZGridCell(int xIndex, int zIndex, Vector3 min, Vector3 max, IXZGrid parentGrid) { }

	[Address(RVA = "0x5A5AE0", Offset = "0x5A4CE0", Length = "0x564")]
	[CalledBy(Type = typeof(RTSceneGrid), Member = "CellFromWorldPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(XZGridCell))]
	[CalledBy(Type = typeof(RTScene), Member = "RaycastSceneGridIfVisible", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Ray)}, ReturnType = typeof(XZGridRayHit))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Matrix4x4), Member = "get_inverse", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802897E0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60013E4")]
	public static XZGridCell FromPoint(Vector3 point, float cellSizeX, float cellSizeZ, IXZGrid parentGrid) { }

	[Address(RVA = "0x5A64E0", Offset = "0x5A56E0", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x60013E2")]
	public Vector3 get_Center() { }

	[Address(RVA = "0x573970", Offset = "0x572B70", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013E1")]
	public Vector3 get_Max() { }

	[Address(RVA = "0x561A40", Offset = "0x560C40", Length = "0x13")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013E0")]
	public Vector3 get_Min() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013DD")]
	public IXZGrid get_ParentGrid() { }

	[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013DE")]
	public int get_XIndex() { }

	[Address(RVA = "0x3893F0", Offset = "0x3885F0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60013DF")]
	public int get_ZIndex() { }

	[Address(RVA = "0x5A6050", Offset = "0x5A5250", Length = "0x40F")]
	[CalledBy(Type = typeof(GizmoObjectVertexSnapDrag3D), Member = "CalculateDragValues", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectGridSnapSession), Member = "Snap", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60013E5")]
	public List<Vector3> GetCenterAndCorners() { }

}

